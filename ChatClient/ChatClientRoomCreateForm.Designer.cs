namespace Mikejzx.ChatClient
{
    partial class ChatClientRoomCreateForm
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
            groupBox1 = new GroupBox();
            txtTopic = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            btnCancel = new Button();
            btnCreate = new Button();
            chkEncrypt = new CheckBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtTopic);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtName);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(17, 20);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(467, 142);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Room Information";
            // 
            // txtTopic
            // 
            txtTopic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTopic.Location = new Point(181, 85);
            txtTopic.Margin = new Padding(4, 5, 4, 5);
            txtTopic.Name = "txtTopic";
            txtTopic.Size = new Size(275, 31);
            txtTopic.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new Point(9, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 38);
            label2.TabIndex = 2;
            label2.Text = "Room topic:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Location = new Point(9, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 38);
            label1.TabIndex = 1;
            label1.Text = "Room name:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtName.Location = new Point(181, 37);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(275, 31);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 192, 255);
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(377, 315);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 38);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(192, 192, 255);
            btnCreate.Enabled = false;
            btnCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.Location = new Point(224, 315);
            btnCreate.Margin = new Padding(4, 5, 4, 5);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(144, 38);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create room";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // chkEncrypt
            // 
            chkEncrypt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chkEncrypt.Location = new Point(9, 37);
            chkEncrypt.Margin = new Padding(4, 5, 4, 5);
            chkEncrypt.Name = "chkEncrypt";
            chkEncrypt.Size = new Size(450, 38);
            chkEncrypt.TabIndex = 0;
            chkEncrypt.Text = "Use end-to-end encryption";
            chkEncrypt.UseVisualStyleBackColor = true;
            chkEncrypt.CheckedChanged += chkEncrypt_CheckedChanged;
            // 
            // lblPassword
            // 
            lblPassword.Enabled = false;
            lblPassword.Location = new Point(9, 80);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(143, 38);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Room password:";
            lblPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPassword.Enabled = false;
            txtPassword.Location = new Point(181, 80);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(275, 31);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(lblPassword);
            groupBox2.Controls.Add(chkEncrypt);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(17, 172);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(467, 133);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Security Settings";
            groupBox2.Visible = false;
            // 
            // ChatClientRoomCreateForm
            // 
            AcceptButton = btnCreate;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(501, 375);
            Controls.Add(btnCreate);
            Controls.Add(btnCancel);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ChatClientRoomCreateForm";
            Text = "Create room";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTopic;
        private Label label2;
        private Label label1;
        private TextBox txtName;
        private Button btnCancel;
        private Button btnCreate;
        private CheckBox chkEncrypt;
        private Label lblPassword;
        private TextBox txtPassword;
        private GroupBox groupBox2;
    }
}