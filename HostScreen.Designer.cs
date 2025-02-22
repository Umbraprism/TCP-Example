namespace tcpTest
{
    partial class HostScreen
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
            btnHost = new Button();
            llConnect = new LinkLabel();
            lvHostLog = new ListView();
            SuspendLayout();
            // 
            // btnHost
            // 
            btnHost.Location = new Point(12, 12);
            btnHost.Name = "btnHost";
            btnHost.Size = new Size(167, 76);
            btnHost.TabIndex = 0;
            btnHost.Text = "Host";
            btnHost.UseVisualStyleBackColor = true;
            btnHost.Click += btnHost_Click;
            // 
            // llConnect
            // 
            llConnect.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            llConnect.AutoSize = true;
            llConnect.Location = new Point(736, 426);
            llConnect.Name = "llConnect";
            llConnect.Size = new Size(52, 15);
            llConnect.TabIndex = 1;
            llConnect.TabStop = true;
            llConnect.Text = "Connect";
            llConnect.LinkClicked += llConnect_LinkClicked;
            // 
            // lvHostLog
            // 
            lvHostLog.Location = new Point(283, 12);
            lvHostLog.Name = "lvHostLog";
            lvHostLog.Size = new Size(505, 411);
            lvHostLog.TabIndex = 2;
            lvHostLog.UseCompatibleStateImageBehavior = false;
            // 
            // HostScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvHostLog);
            Controls.Add(llConnect);
            Controls.Add(btnHost);
            Name = "HostScreen";
            Text = "Form1";
            Load += HostScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHost;
        private LinkLabel llConnect;
        private ListView lvHostLog;
    }
}
