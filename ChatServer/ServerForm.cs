using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mikejzx.ChatServer
{
    public partial class ServerForm : Form
    {
        private ChatServer _chatServer;
        private ChatRoom _chatRoom;
        public ServerForm()
        {
            InitializeComponent();
            _chatServer = new ChatServer(this);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Đường dẫn tới chứng chỉ SSL
            string certificatePath = Path.Combine(Application.StartupPath, "localhost.pfx");

            // Kiểm tra nếu chứng chỉ không tồn tại, tạo chứng chỉ tự sinh
            if (!FileExistsAndIsReadable(certificatePath))
            {
                CreateSelfSignedCertificate(certificatePath);
            }

            // Chạy server với chứng chỉ đã tạo
            await Task.Run(() => _chatServer.Run(certificatePath));
            AppendLog("Server started.");
        }

        private async void stop_server_Click(object sender, EventArgs e)
        {
            // Dừng server
            await Task.Run(() => _chatServer.Cleanup());
            AppendLog("Server stopped.");
        }

        // Tạo chứng chỉ tự sinh (self-signed certificate)
        public void CreateSelfSignedCertificate(string certificatePath)
        {
            // Đường dẫn đến PowerShell
            var powershellExePath = "powershell.exe";

            // Đảm bảo đường dẫn chứa tệp chứng chỉ là thư mục hiện tại của chương trình
            string certificateDirectory = Application.StartupPath;
            string certificateFilePath = Path.Combine(certificateDirectory, "localhost.pfx");

            // Lệnh PowerShell tạo chứng chỉ và xuất ra file .pfx (với mật khẩu là '12345')
            var arguments = $"-Command \"New-SelfSignedCertificate -DnsName 'localhost' -CertStoreLocation 'cert:\\LocalMachine\\My'; " +
                            "$cert = Get-ChildItem -Path cert:\\LocalMachine\\My | Where-Object { $_.DnsNameList -contains 'localhost' } | Select-Object -First 1; " +
                            "Export-PfxCertificate -Cert $cert -FilePath '{certificateFilePath}' -Password (ConvertTo-SecureString -String '12345' -Force -AsPlainText)\"";

            // Đảm bảo bạn thay thế {certificateFilePath} bằng đường dẫn thực tế của certificateFilePath
            arguments = arguments.Replace("{certificateFilePath}", certificateFilePath);

            var processStartInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = powershellExePath,
                Arguments = arguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true,  // Đọc lỗi nếu có
                UseShellExecute = false,
                CreateNoWindow = true
            };

            try
            {
                using (var process = System.Diagnostics.Process.Start(processStartInfo))
                {
                    // Đọc các thông báo từ PowerShell
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    if (process.ExitCode != 0)
                    {
                        AppendLog($"Error creating self-signed certificate: {error}");
                    }
                    else
                    {
                        AppendLog($"Self-signed certificate created at {certificateFilePath}");
                        AppendLog($"Output: {output}");
                    }
                }
            }
            catch (Exception ex)
            {
                AppendLog($"Exception occurred while creating certificate: {ex.Message}");
            }
        }

        // Phương thức để thêm thông báo vào richTextBox1
        public void AppendLog(string message)
        {
            if (richTextBox1.InvokeRequired)
            {
                // Sử dụng Invoke để đảm bảo việc cập nhật từ một luồng khác
                richTextBox1.Invoke(new Action(() =>
                {
                    richTextBox1.AppendText(message + Environment.NewLine);
                }));
            }
            else
            {
                richTextBox1.AppendText(message + Environment.NewLine);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ServerForm_Load(object sender, EventArgs e)
        {

        }
        // Phương thức kiểm tra xem file có tồn tại và có thể đọc được không
        private bool FileExistsAndIsReadable(string path)
        {
            if (!File.Exists(path))
                return false;

            try
            {
                File.Open(path, FileMode.Open, FileAccess.Read).Dispose();
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }


    }
}