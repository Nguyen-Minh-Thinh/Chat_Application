namespace Mikejzx.ChatServer
{
    partial class ServerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            start_server = new Button();
            stop_server = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(10, 63);
            richTextBox1.Margin = new Padding(2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(682, 405);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // start_server
            // 
            start_server.Location = new Point(249, 21);
            start_server.Margin = new Padding(2);
            start_server.Name = "start_server";
            start_server.Size = new Size(98, 27);
            start_server.TabIndex = 1;
            start_server.Text = "Start Server";
            start_server.UseVisualStyleBackColor = true;
            start_server.Click += button1_Click;
            // 
            // stop_server
            // 
            stop_server.Location = new Point(364, 21);
            stop_server.Margin = new Padding(2);
            stop_server.Name = "stop_server";
            stop_server.Size = new Size(98, 27);
            stop_server.TabIndex = 2;
            stop_server.Text = "Stop Server";
            stop_server.UseVisualStyleBackColor = true;
            stop_server.Click += stop_server_Click;
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 498);
            Controls.Add(stop_server);
            Controls.Add(start_server);
            Controls.Add(richTextBox1);
            Margin = new Padding(2);
            Name = "ServerForm";
            Text = "ServerForm";
            Load += ServerForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button start_server;
        private Button stop_server;
    }
}