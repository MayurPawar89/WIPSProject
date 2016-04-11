namespace WIPSProject
{
    partial class frmClientNew
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReceivedPath = new System.Windows.Forms.Button();
            this.curMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnectToServer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "   ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "File receiving path:";
            // 
            // btnReceivedPath
            // 
            this.btnReceivedPath.Location = new System.Drawing.Point(35, 74);
            this.btnReceivedPath.Name = "btnReceivedPath";
            this.btnReceivedPath.Size = new System.Drawing.Size(150, 23);
            this.btnReceivedPath.TabIndex = 16;
            this.btnReceivedPath.Text = "Select Receiving Path";
            this.btnReceivedPath.UseVisualStyleBackColor = true;
            // 
            // curMsg
            // 
            this.curMsg.AutoSize = true;
            this.curMsg.Location = new System.Drawing.Point(117, 157);
            this.curMsg.MaximumSize = new System.Drawing.Size(250, 0);
            this.curMsg.Name = "curMsg";
            this.curMsg.Size = new System.Drawing.Size(24, 13);
            this.curMsg.TabIndex = 15;
            this.curMsg.Text = "Idle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Present Status:";
            // 
            // btnConnectToServer
            // 
            this.btnConnectToServer.Location = new System.Drawing.Point(35, 29);
            this.btnConnectToServer.Name = "btnConnectToServer";
            this.btnConnectToServer.Size = new System.Drawing.Size(113, 23);
            this.btnConnectToServer.TabIndex = 13;
            this.btnConnectToServer.Text = "Connect to Server";
            this.btnConnectToServer.UseVisualStyleBackColor = true;
            // 
            // frmClientNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 458);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnReceivedPath);
            this.Controls.Add(this.curMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConnectToServer);
            this.Name = "frmClientNew";
            this.Text = "frmClientNew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReceivedPath;
        private System.Windows.Forms.Label curMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnectToServer;
        private System.Windows.Forms.Timer timer1;
    }
}