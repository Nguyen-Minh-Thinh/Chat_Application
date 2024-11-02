namespace Mikejzx.ChatClient
{
    partial class ChatClientForm
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
            components = new System.ComponentModel.Container();
            lblHeading = new Label();
            btnSend = new Button();
            txtCompose = new TextBox();
            splitContainer1 = new SplitContainer();
            btnScrollToBottom = new Button();
            txtMessages = new ReadOnlyRichTextBox(components);
            splitContainer2 = new SplitContainer();
            lstRooms = new ChannelListBox(components);
            label1 = new Label();
            lstChannels = new ChannelListBox(components);
            lblServer = new Label();
            btnConnect = new Button();
            lblMyName = new Label();
            label2 = new Label();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            roomToolStripMenuItem = new ToolStripMenuItem();
            createRoomToolStripMenuItem = new ToolStripMenuItem();
            deleteRoomToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHeading.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.Location = new Point(4, 5);
            lblHeading.Margin = new Padding(4, 0, 4, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(597, 45);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Heading";
            lblHeading.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSend.BackColor = Color.FromArgb(192, 192, 255);
            btnSend.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSend.Location = new Point(654, 639);
            btnSend.Margin = new Padding(4, 5, 4, 5);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(107, 38);
            btnSend.TabIndex = 4;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // txtCompose
            // 
            txtCompose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCompose.Location = new Point(4, 639);
            txtCompose.Margin = new Padding(4, 5, 4, 5);
            txtCompose.Name = "txtCompose";
            txtCompose.Size = new Size(639, 31);
            txtCompose.TabIndex = 5;
            txtCompose.KeyDown += txtCompose_KeyDown;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Location = new Point(17, 45);
            splitContainer1.Margin = new Padding(4, 5, 4, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnScrollToBottom);
            splitContainer1.Panel1.Controls.Add(txtMessages);
            splitContainer1.Panel1.Controls.Add(txtCompose);
            splitContainer1.Panel1.Controls.Add(lblHeading);
            splitContainer1.Panel1.Controls.Add(btnSend);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1109, 685);
            splitContainer1.SplitterDistance = 767;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 6;
            // 
            // btnScrollToBottom
            // 
            btnScrollToBottom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnScrollToBottom.Enabled = false;
            btnScrollToBottom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnScrollToBottom.Location = new Point(610, 5);
            btnScrollToBottom.Margin = new Padding(4, 5, 4, 5);
            btnScrollToBottom.Name = "btnScrollToBottom";
            btnScrollToBottom.Size = new Size(151, 40);
            btnScrollToBottom.TabIndex = 7;
            btnScrollToBottom.Text = "Scroll to bottom";
            btnScrollToBottom.UseVisualStyleBackColor = true;
            btnScrollToBottom.Click += btnScrollToBottom_Click;
            // 
            // txtMessages
            // 
            txtMessages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMessages.BackColor = SystemColors.Window;
            txtMessages.BorderStyle = BorderStyle.FixedSingle;
            txtMessages.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMessages.Location = new Point(4, 55);
            txtMessages.Margin = new Padding(4, 5, 4, 5);
            txtMessages.Name = "txtMessages";
            txtMessages.ReadOnly = true;
            txtMessages.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            txtMessages.ShortcutsEnabled = false;
            txtMessages.Size = new Size(755, 560);
            txtMessages.TabIndex = 6;
            txtMessages.TabStop = false;
            txtMessages.Text = "";
            // 
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.FixedSingle;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(4, 5, 4, 5);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(lstRooms);
            splitContainer2.Panel1.Controls.Add(label1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(lstChannels);
            splitContainer2.Panel2.Controls.Add(lblServer);
            splitContainer2.Panel2.Controls.Add(btnConnect);
            splitContainer2.Panel2.Controls.Add(lblMyName);
            splitContainer2.Panel2.Controls.Add(label2);
            splitContainer2.Size = new Size(336, 685);
            splitContainer2.SplitterDistance = 231;
            splitContainer2.SplitterWidth = 7;
            splitContainer2.TabIndex = 0;
            // 
            // lstRooms
            // 
            lstRooms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstRooms.FormattingEnabled = true;
            lstRooms.IntegralHeight = false;
            lstRooms.ItemHeight = 25;
            lstRooms.Location = new Point(4, 55);
            lstRooms.Margin = new Padding(4, 5, 4, 5);
            lstRooms.Name = "lstRooms";
            lstRooms.Size = new Size(324, 166);
            lstRooms.TabIndex = 15;
            lstRooms.SelectedIndexChanged += lstRooms_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 5);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(325, 45);
            label1.TabIndex = 13;
            label1.Text = "Rooms:";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lstChannels
            // 
            lstChannels.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstChannels.FormattingEnabled = true;
            lstChannels.IntegralHeight = false;
            lstChannels.ItemHeight = 25;
            lstChannels.Location = new Point(4, 38);
            lstChannels.Margin = new Padding(4, 5, 4, 5);
            lstChannels.Name = "lstChannels";
            lstChannels.Size = new Size(324, 302);
            lstChannels.TabIndex = 14;
            lstChannels.SelectedIndexChanged += lstChannels_SelectedIndexChanged;
            // 
            // lblServer
            // 
            lblServer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblServer.AutoEllipsis = true;
            lblServer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblServer.Location = new Point(4, 395);
            lblServer.Margin = new Padding(4, 0, 4, 0);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(141, 42);
            lblServer.TabIndex = 12;
            lblServer.Text = "Server: ";
            lblServer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnConnect
            // 
            btnConnect.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConnect.AutoSize = true;
            btnConnect.BackColor = Color.FromArgb(192, 192, 255);
            btnConnect.Enabled = false;
            btnConnect.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConnect.Location = new Point(153, 378);
            btnConnect.Margin = new Padding(4, 5, 4, 5);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(177, 58);
            btnConnect.TabIndex = 11;
            btnConnect.Text = "Connecting...";
            btnConnect.UseVisualStyleBackColor = false;
            // 
            // lblMyName
            // 
            lblMyName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMyName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMyName.Location = new Point(4, 348);
            lblMyName.Margin = new Padding(4, 0, 4, 0);
            lblMyName.Name = "lblMyName";
            lblMyName.Size = new Size(245, 42);
            lblMyName.TabIndex = 10;
            lblMyName.Text = "Logged in as ...";
            lblMyName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(4, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(325, 33);
            label2.TabIndex = 9;
            label2.Text = "Direct Messages:";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, roomToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(9, 3, 0, 3);
            menuStrip.Size = new Size(1143, 35);
            menuStrip.TabIndex = 7;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logOutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(57, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(176, 34);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(176, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // roomToolStripMenuItem
            // 
            roomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createRoomToolStripMenuItem, deleteRoomToolStripMenuItem });
            roomToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            roomToolStripMenuItem.Size = new Size(78, 29);
            roomToolStripMenuItem.Text = "Room";
            roomToolStripMenuItem.DropDownOpening += roomToolStripMenuItem_DropDownOpening;
            // 
            // createRoomToolStripMenuItem
            // 
            createRoomToolStripMenuItem.Name = "createRoomToolStripMenuItem";
            createRoomToolStripMenuItem.Size = new Size(225, 34);
            createRoomToolStripMenuItem.Text = "Create room...";
            createRoomToolStripMenuItem.Click += createRoomToolStripMenuItem_Click;
            // 
            // deleteRoomToolStripMenuItem
            // 
            deleteRoomToolStripMenuItem.Enabled = false;
            deleteRoomToolStripMenuItem.Name = "deleteRoomToolStripMenuItem";
            deleteRoomToolStripMenuItem.Size = new Size(225, 34);
            deleteRoomToolStripMenuItem.Text = "Delete room...";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(68, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(164, 34);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // ChatClientForm
            // 
            AcceptButton = btnSend;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(1143, 750);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ChatClientForm";
            Text = "Chat";
            FormClosing += ChatClientForm_FormClosing;
            Load += ChatClientForm_Load;
            Resize += ChatClientForm_Resize;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private Button btnSend;
        private TextBox txtCompose;
        private SplitContainer splitContainer1;
        private ReadOnlyRichTextBox txtMessages;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Button btnScrollToBottom;
        private ToolStripMenuItem roomToolStripMenuItem;
        private ToolStripMenuItem createRoomToolStripMenuItem;
        private ToolStripMenuItem deleteRoomToolStripMenuItem;
        private SplitContainer splitContainer2;
        private ChannelListBox lstRooms;
        private Label label1;
        private ChannelListBox lstChannels;
        private Label lblServer;
        private Button btnConnect;
        private Label lblMyName;
        private Label label2;
    }
}