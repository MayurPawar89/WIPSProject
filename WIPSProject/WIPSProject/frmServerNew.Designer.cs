namespace WIPSProject
{
    partial class frmServerNew
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
            this.components = new System.ComponentModel.Container();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.curMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStopServer
            // 
            this.btnStopServer.Location = new System.Drawing.Point(196, 23);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(109, 33);
            this.btnStopServer.TabIndex = 14;
            this.btnStopServer.Text = "Stop Server";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(40, 89);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(157, 23);
            this.btnSendFile.TabIndex = 13;
            this.btnSendFile.Text = "Select File to Send";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // curMsg
            // 
            this.curMsg.AutoSize = true;
            this.curMsg.Location = new System.Drawing.Point(117, 133);
            this.curMsg.Name = "curMsg";
            this.curMsg.Size = new System.Drawing.Size(0, 13);
            this.curMsg.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Server Status:";
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(40, 23);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(109, 33);
            this.btnStartServer.TabIndex = 10;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmServerNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.btnStopServer);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.curMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStartServer);
            this.Name = "frmServerNew";
            this.Text = "frmServerNew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Label curMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Timer timer1;
    }
}