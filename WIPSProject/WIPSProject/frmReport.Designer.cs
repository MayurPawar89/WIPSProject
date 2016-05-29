namespace WIPSProject
{
    partial class frmReport
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
            this.dgvFileInfo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rdAll = new System.Windows.Forms.RadioButton();
            this.rdError = new System.Windows.Forms.RadioButton();
            this.rdSuccess = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFileInfo
            // 
            this.dgvFileInfo.AllowUserToAddRows = false;
            this.dgvFileInfo.AllowUserToDeleteRows = false;
            this.dgvFileInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFileInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFileInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvFileInfo.Name = "dgvFileInfo";
            this.dgvFileInfo.ReadOnly = true;
            this.dgvFileInfo.Size = new System.Drawing.Size(1023, 462);
            this.dgvFileInfo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rdSuccess);
            this.panel1.Controls.Add(this.rdError);
            this.panel1.Controls.Add(this.rdAll);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 59);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvFileInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1023, 462);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Status : ";
            // 
            // rdAll
            // 
            this.rdAll.AutoSize = true;
            this.rdAll.Location = new System.Drawing.Point(151, 20);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(36, 17);
            this.rdAll.TabIndex = 1;
            this.rdAll.Text = "All";
            this.rdAll.UseVisualStyleBackColor = true;
            this.rdAll.CheckedChanged += new System.EventHandler(this.rdAll_CheckedChanged);
            // 
            // rdError
            // 
            this.rdError.AutoSize = true;
            this.rdError.Location = new System.Drawing.Point(275, 20);
            this.rdError.Name = "rdError";
            this.rdError.Size = new System.Drawing.Size(47, 17);
            this.rdError.TabIndex = 2;
            this.rdError.Text = "Error";
            this.rdError.UseVisualStyleBackColor = true;
            this.rdError.CheckedChanged += new System.EventHandler(this.rdError_CheckedChanged);
            // 
            // rdSuccess
            // 
            this.rdSuccess.AutoSize = true;
            this.rdSuccess.Location = new System.Drawing.Point(202, 20);
            this.rdSuccess.Name = "rdSuccess";
            this.rdSuccess.Size = new System.Drawing.Size(66, 17);
            this.rdSuccess.TabIndex = 3;
            this.rdSuccess.Text = "Success";
            this.rdSuccess.UseVisualStyleBackColor = true;
            this.rdSuccess.CheckedChanged += new System.EventHandler(this.rdSuccess_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Transaction Details : ";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 521);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReport";
            this.Text = "Transaction Report";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFileInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdSuccess;
        private System.Windows.Forms.RadioButton rdError;
        private System.Windows.Forms.RadioButton rdAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}