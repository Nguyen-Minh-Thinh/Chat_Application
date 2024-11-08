using System;
using System.Windows.Forms;

namespace Mikejzx.ChatServer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Thiết lập các cấu hình cho ứng dụng WinForms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy form chính của ứng dụng (ServerForm)
            Application.Run(new ServerForm());
        }
    }
}
