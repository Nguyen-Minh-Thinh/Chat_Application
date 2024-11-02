namespace Mikejzx.ChatClient
{
    partial class ChatClientLoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtHostname = new TextBox();
            label2 = new Label();
            txtNickname = new TextBox();
            btnLogin = new Button();
            cboxLan = new ComboBox();
            radUseHostname = new RadioButton();
            radUseLan = new RadioButton();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(349, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter hostname or IP address of chat server:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtHostname
            // 
            txtHostname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtHostname.Location = new Point(49, 45);
            txtHostname.Margin = new Padding(4, 5, 4, 5);
            txtHostname.Name = "txtHostname";
            txtHostname.Size = new Size(315, 31);
            txtHostname.TabIndex = 1;
            txtHostname.Text = "localhost";
            txtHostname.MouseClick += txtHostname_MouseClick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 175);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(349, 38);
            label2.TabIndex = 2;
            label2.Text = "Enter your nickname:";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // txtNickname
            // 
            txtNickname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNickname.Location = new Point(17, 218);
            txtNickname.Margin = new Padding(4, 5, 4, 5);
            txtNickname.Name = "txtNickname";
            txtNickname.Size = new Size(347, 31);
            txtNickname.TabIndex = 3;
            txtNickname.Text = "User";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.BackColor = Color.FromArgb(192, 192, 255);
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(122, 271);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(125, 38);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "&Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // cboxLan
            // 
            cboxLan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboxLan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxLan.Enabled = false;
            cboxLan.FormattingEnabled = true;
            cboxLan.Location = new Point(49, 132);
            cboxLan.Margin = new Padding(4, 5, 4, 5);
            cboxLan.Name = "cboxLan";
            cboxLan.Size = new Size(315, 33);
            cboxLan.TabIndex = 5;
            cboxLan.MouseClick += cboxLan_MouseClick;
            // 
            // radUseHostname
            // 
            radUseHostname.CheckAlign = ContentAlignment.MiddleCenter;
            radUseHostname.Checked = true;
            radUseHostname.Location = new Point(17, 45);
            radUseHostname.Margin = new Padding(4, 5, 4, 5);
            radUseHostname.Name = "radUseHostname";
            radUseHostname.Size = new Size(23, 38);
            radUseHostname.TabIndex = 6;
            radUseHostname.TabStop = true;
            radUseHostname.UseVisualStyleBackColor = true;
            // 
            // radUseLan
            // 
            radUseLan.CheckAlign = ContentAlignment.MiddleCenter;
            radUseLan.Enabled = false;
            radUseLan.Location = new Point(17, 132);
            radUseLan.Margin = new Padding(4, 5, 4, 5);
            radUseLan.Name = "radUseLan";
            radUseLan.Size = new Size(23, 38);
            radUseLan.TabIndex = 7;
            radUseLan.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 88);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(349, 38);
            label3.TabIndex = 8;
            label3.Text = "Or select a server on your LAN:";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // ChatClientLoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(383, 323);
            Controls.Add(label3);
            Controls.Add(radUseLan);
            Controls.Add(radUseHostname);
            Controls.Add(cboxLan);
            Controls.Add(btnLogin);
            Controls.Add(txtNickname);
            Controls.Add(label2);
            Controls.Add(txtHostname);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "ChatClientLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chat Client Login";
            FormClosing += ChatClientLoginForm_FormClosing;
            Load += Form1_Load;
            VisibleChanged += ChatClientLoginForm_VisibleChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHostname;
        private Label label2;
        private TextBox txtNickname;
        private Button btnLogin;
        private ComboBox cboxLan;
        private RadioButton radUseHostname;
        private RadioButton radUseLan;
        private Label label3;
    }
}