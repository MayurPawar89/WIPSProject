namespace WIPSProject
{
    partial class ShowProgress
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
            this.DgV1 = new System.Windows.Forms.DataGridView();
            this.lblPacketinfo = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.MyProgressbar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.DgV1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgV1
            // 
            this.DgV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgV1.Location = new System.Drawing.Point(33, 78);
            this.DgV1.Name = "DgV1";
            this.DgV1.Size = new System.Drawing.Size(648, 143);
            this.DgV1.TabIndex = 1;
            // 
            // lblPacketinfo
            // 
            this.lblPacketinfo.AutoSize = true;
            this.lblPacketinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacketinfo.Location = new System.Drawing.Point(36, 40);
            this.lblPacketinfo.Name = "lblPacketinfo";
            this.lblPacketinfo.Size = new System.Drawing.Size(123, 16);
            this.lblPacketinfo.TabIndex = 2;
            this.lblPacketinfo.Text = "Scan Packet List";
            this.lblPacketinfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(223, 391);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(104, 29);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Continue
            // 
            this.btn_Continue.Location = new System.Drawing.Point(356, 391);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(104, 29);
            this.btn_Continue.TabIndex = 4;
            this.btn_Continue.Text = "Continue";
            this.btn_Continue.UseVisualStyleBackColor = true;
            // 
            // btn_Pause
            // 
            this.btn_Pause.Location = new System.Drawing.Point(498, 391);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(104, 29);
            this.btn_Pause.TabIndex = 5;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseVisualStyleBackColor = true;
            // 
            // MyProgressbar
            // 
            this.MyProgressbar.Location = new System.Drawing.Point(33, 279);
            this.MyProgressbar.Name = "MyProgressbar";
            this.MyProgressbar.Size = new System.Drawing.Size(648, 41);
            this.MyProgressbar.TabIndex = 6;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 456);
            this.Controls.Add(this.MyProgressbar);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lblPacketinfo);
            this.Controls.Add(this.DgV1);
            this.Name = "Mainform";
            this.Text = "Show Progress";
            ((System.ComponentModel.ISupportInitialize)(this.DgV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgV1;
        private System.Windows.Forms.Label lblPacketinfo;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Continue;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.ProgressBar MyProgressbar;

    }
}

