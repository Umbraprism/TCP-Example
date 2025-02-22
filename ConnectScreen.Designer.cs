namespace tcpTest
{
    partial class ConnectScreen
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
            btnConnect = new Button();
            lvLog = new ListView();
            llHost = new LinkLabel();
            btnSend = new Button();
            tbUsername = new TextBox();
            tbId = new TextBox();
            tbPassword = new TextBox();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(12, 12);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(144, 64);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // lvLog
            // 
            lvLog.Location = new Point(307, 12);
            lvLog.Name = "lvLog";
            lvLog.Size = new Size(481, 395);
            lvLog.TabIndex = 1;
            lvLog.UseCompatibleStateImageBehavior = false;
            // 
            // llHost
            // 
            llHost.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            llHost.AutoSize = true;
            llHost.Location = new Point(756, 426);
            llHost.Name = "llHost";
            llHost.Size = new Size(32, 15);
            llHost.TabIndex = 2;
            llHost.TabStop = true;
            llHost.Text = "Host";
            llHost.LinkClicked += llHost_LinkClicked;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(226, 384);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 4;
            btnSend.Text = "Send Plr";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(12, 222);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Username";
            tbUsername.Size = new Size(289, 23);
            tbUsername.TabIndex = 5;
            // 
            // tbId
            // 
            tbId.Location = new Point(12, 103);
            tbId.Name = "tbId";
            tbId.PlaceholderText = "ID";
            tbId.Size = new Size(110, 23);
            tbId.TabIndex = 6;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(12, 264);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Password";
            tbPassword.Size = new Size(289, 23);
            tbPassword.TabIndex = 7;
            // 
            // ConnectScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbPassword);
            Controls.Add(tbId);
            Controls.Add(tbUsername);
            Controls.Add(btnSend);
            Controls.Add(llHost);
            Controls.Add(lvLog);
            Controls.Add(btnConnect);
            Name = "ConnectScreen";
            Text = "ConnectScreen";
            Load += ConnectScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private ListView lvLog;
        private LinkLabel llHost;
        private Button btnSend;
        private TextBox tbUsername;
        private TextBox tbId;
        private TextBox tbPassword;
    }
}