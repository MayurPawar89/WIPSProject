namespace WIPSProject
{
    partial class frmDashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infectedFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.btnCilentReceivingPath = new System.Windows.Forms.Button();
            this.btnConnectToServer = new System.Windows.Forms.Button();
            this.lblFileRecevingPath = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblClientStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblClinentMAchineIP = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblClientMachineName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlServer = new System.Windows.Forms.Panel();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.curMsg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.lblServerMachineIP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblServerMachineName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrServer = new System.Windows.Forms.Timer(this.components);
            this.tmrClient = new System.Windows.Forms.Timer(this.components);
            this.pnlServerDetails = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlClientDetails = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlClient.SuspendLayout();
            this.pnlServer.SuspendLayout();
            this.pnlServerDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlClientDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainformToolStripMenuItem,
            this.serverToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mainformToolStripMenuItem
            // 
            this.mainformToolStripMenuItem.Name = "mainformToolStripMenuItem";
            this.mainformToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.mainformToolStripMenuItem.Text = "Mainform";
            this.mainformToolStripMenuItem.Click += new System.EventHandler(this.mainformToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.serverToolStripMenuItem.Text = "Server";
            this.serverToolStripMenuItem.Visible = false;
            this.serverToolStripMenuItem.Click += new System.EventHandler(this.serverToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showProgressToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showProgressToolStripMenuItem
            // 
            this.showProgressToolStripMenuItem.Name = "showProgressToolStripMenuItem";
            this.showProgressToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.showProgressToolStripMenuItem.Text = "Show Progress";
            this.showProgressToolStripMenuItem.Click += new System.EventHandler(this.showProgressToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationSettingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // configurationSettingsToolStripMenuItem
            // 
            this.configurationSettingsToolStripMenuItem.Name = "configurationSettingsToolStripMenuItem";
            this.configurationSettingsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.configurationSettingsToolStripMenuItem.Text = "Configuration Settings";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infectedFilesToolStripMenuItem,
            this.progressFilesToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // infectedFilesToolStripMenuItem
            // 
            this.infectedFilesToolStripMenuItem.Name = "infectedFilesToolStripMenuItem";
            this.infectedFilesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.infectedFilesToolStripMenuItem.Text = "Infected Files";
            // 
            // progressFilesToolStripMenuItem
            // 
            this.progressFilesToolStripMenuItem.Name = "progressFilesToolStripMenuItem";
            this.progressFilesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.progressFilesToolStripMenuItem.Text = "Progress Files";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlClient);
            this.pnlMain.Controls.Add(this.pnlServer);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(708, 437);
            this.pnlMain.TabIndex = 6;
            // 
            // pnlClient
            // 
            this.pnlClient.Controls.Add(this.panel4);
            this.pnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClient.Location = new System.Drawing.Point(0, 201);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(708, 236);
            this.pnlClient.TabIndex = 1;
            // 
            // btnCilentReceivingPath
            // 
            this.btnCilentReceivingPath.Location = new System.Drawing.Point(331, 6);
            this.btnCilentReceivingPath.Name = "btnCilentReceivingPath";
            this.btnCilentReceivingPath.Size = new System.Drawing.Size(126, 23);
            this.btnCilentReceivingPath.TabIndex = 26;
            this.btnCilentReceivingPath.Text = "Select Reveiving Path";
            this.btnCilentReceivingPath.UseVisualStyleBackColor = true;
            this.btnCilentReceivingPath.Click += new System.EventHandler(this.btnCilentReceivingPath_Click);
            // 
            // btnConnectToServer
            // 
            this.btnConnectToServer.Location = new System.Drawing.Point(194, 6);
            this.btnConnectToServer.Name = "btnConnectToServer";
            this.btnConnectToServer.Size = new System.Drawing.Size(110, 23);
            this.btnConnectToServer.TabIndex = 25;
            this.btnConnectToServer.Text = "Connect To Server";
            this.btnConnectToServer.UseVisualStyleBackColor = true;
            this.btnConnectToServer.Click += new System.EventHandler(this.btnConnectToServer_Click);
            // 
            // lblFileRecevingPath
            // 
            this.lblFileRecevingPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileRecevingPath.AutoSize = true;
            this.lblFileRecevingPath.Location = new System.Drawing.Point(358, 61);
            this.lblFileRecevingPath.Name = "lblFileRecevingPath";
            this.lblFileRecevingPath.Size = new System.Drawing.Size(33, 13);
            this.lblFileRecevingPath.TabIndex = 24;
            this.lblFileRecevingPath.Text = "name";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(243, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "File Receiving Path : ";
            // 
            // lblClientStatus
            // 
            this.lblClientStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClientStatus.AutoSize = true;
            this.lblClientStatus.Location = new System.Drawing.Point(358, 85);
            this.lblClientStatus.Name = "lblClientStatus";
            this.lblClientStatus.Size = new System.Drawing.Size(34, 13);
            this.lblClientStatus.TabIndex = 22;
            this.lblClientStatus.Text = "ststus";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Client Status : ";
            // 
            // lblClinentMAchineIP
            // 
            this.lblClinentMAchineIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClinentMAchineIP.AutoSize = true;
            this.lblClinentMAchineIP.Location = new System.Drawing.Point(358, 37);
            this.lblClinentMAchineIP.Name = "lblClinentMAchineIP";
            this.lblClinentMAchineIP.Size = new System.Drawing.Size(15, 13);
            this.lblClinentMAchineIP.TabIndex = 20;
            this.lblClinentMAchineIP.Text = "ip";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Client Machine IP : ";
            // 
            // lblClientMachineName
            // 
            this.lblClientMachineName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClientMachineName.AutoSize = true;
            this.lblClientMachineName.Location = new System.Drawing.Point(358, 13);
            this.lblClientMachineName.Name = "lblClientMachineName";
            this.lblClientMachineName.Size = new System.Drawing.Size(33, 13);
            this.lblClientMachineName.TabIndex = 18;
            this.lblClientMachineName.Text = "name";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(234, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Client Machine Name : ";
            // 
            // pnlServer
            // 
            this.pnlServer.Controls.Add(this.panel2);
            this.pnlServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlServer.Location = new System.Drawing.Point(0, 0);
            this.pnlServer.Name = "pnlServer";
            this.pnlServer.Size = new System.Drawing.Size(708, 201);
            this.pnlServer.TabIndex = 0;
            // 
            // lblServerPort
            // 
            this.lblServerPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Location = new System.Drawing.Point(356, 73);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(25, 13);
            this.lblServerPort.TabIndex = 17;
            this.lblServerPort.Text = "port";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Port : ";
            // 
            // curMsg
            // 
            this.curMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.curMsg.AutoSize = true;
            this.curMsg.Location = new System.Drawing.Point(356, 101);
            this.curMsg.Name = "curMsg";
            this.curMsg.Size = new System.Drawing.Size(34, 13);
            this.curMsg.TabIndex = 15;
            this.curMsg.Text = "ststus";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Server Status : ";
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(397, 9);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(75, 23);
            this.btnSendFile.TabIndex = 13;
            this.btnSendFile.Text = "Send File ";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Visible = false;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnStopServer
            // 
            this.btnStopServer.Location = new System.Drawing.Point(297, 9);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(75, 23);
            this.btnStopServer.TabIndex = 12;
            this.btnStopServer.Text = "Stop Server";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Visible = false;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(197, 9);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(75, 23);
            this.btnStartServer.TabIndex = 11;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // lblServerMachineIP
            // 
            this.lblServerMachineIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServerMachineIP.AutoSize = true;
            this.lblServerMachineIP.Location = new System.Drawing.Point(356, 45);
            this.lblServerMachineIP.Name = "lblServerMachineIP";
            this.lblServerMachineIP.Size = new System.Drawing.Size(15, 13);
            this.lblServerMachineIP.TabIndex = 10;
            this.lblServerMachineIP.Text = "ip";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Server Machine IP : ";
            // 
            // lblServerMachineName
            // 
            this.lblServerMachineName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServerMachineName.AutoSize = true;
            this.lblServerMachineName.Location = new System.Drawing.Point(356, 17);
            this.lblServerMachineName.Name = "lblServerMachineName";
            this.lblServerMachineName.Size = new System.Drawing.Size(33, 13);
            this.lblServerMachineName.TabIndex = 8;
            this.lblServerMachineName.Text = "name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Server Machine Name : ";
            // 
            // tmrServer
            // 
            this.tmrServer.Enabled = true;
            this.tmrServer.Tick += new System.EventHandler(this.tmrServer_Tick);
            // 
            // tmrClient
            // 
            this.tmrClient.Tick += new System.EventHandler(this.tmrClient_Tick);
            // 
            // pnlServerDetails
            // 
            this.pnlServerDetails.Controls.Add(this.label2);
            this.pnlServerDetails.Controls.Add(this.lblServerPort);
            this.pnlServerDetails.Controls.Add(this.lblServerMachineName);
            this.pnlServerDetails.Controls.Add(this.label7);
            this.pnlServerDetails.Controls.Add(this.label4);
            this.pnlServerDetails.Controls.Add(this.curMsg);
            this.pnlServerDetails.Controls.Add(this.lblServerMachineIP);
            this.pnlServerDetails.Controls.Add(this.label5);
            this.pnlServerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlServerDetails.Location = new System.Drawing.Point(0, 73);
            this.pnlServerDetails.Name = "pnlServerDetails";
            this.pnlServerDetails.Size = new System.Drawing.Size(708, 122);
            this.pnlServerDetails.TabIndex = 18;
            this.pnlServerDetails.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStartServer);
            this.panel1.Controls.Add(this.btnStopServer);
            this.panel1.Controls.Add(this.btnSendFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 42);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlServerDetails);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 195);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(708, 31);
            this.panel3.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "You have connected as server.";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnlClientDetails);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(3, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(702, 181);
            this.panel4.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(702, 31);
            this.panel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(247, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "You have connected as Client.";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnCilentReceivingPath);
            this.panel6.Controls.Add(this.btnConnectToServer);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 31);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(702, 38);
            this.panel6.TabIndex = 1;
            // 
            // pnlClientDetails
            // 
            this.pnlClientDetails.Controls.Add(this.label10);
            this.pnlClientDetails.Controls.Add(this.lblFileRecevingPath);
            this.pnlClientDetails.Controls.Add(this.lblClientMachineName);
            this.pnlClientDetails.Controls.Add(this.label17);
            this.pnlClientDetails.Controls.Add(this.label8);
            this.pnlClientDetails.Controls.Add(this.lblClientStatus);
            this.pnlClientDetails.Controls.Add(this.lblClinentMAchineIP);
            this.pnlClientDetails.Controls.Add(this.label6);
            this.pnlClientDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClientDetails.Location = new System.Drawing.Point(0, 69);
            this.pnlClientDetails.Name = "pnlClientDetails";
            this.pnlClientDetails.Size = new System.Drawing.Size(702, 112);
            this.pnlClientDetails.TabIndex = 2;
            this.pnlClientDetails.Visible = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 461);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDashboard";
            this.Text = "Dashboard Server";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlClient.ResumeLayout(false);
            this.pnlServer.ResumeLayout(false);
            this.pnlServerDetails.ResumeLayout(false);
            this.pnlServerDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.pnlClientDetails.ResumeLayout(false);
            this.pnlClientDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showProgressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infectedFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progressFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlServer;
        private System.Windows.Forms.Panel pnlClient;
        private System.Windows.Forms.Label lblServerMachineIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblServerMachineName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Label curMsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer tmrServer;
        private System.Windows.Forms.Label lblClientStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblClinentMAchineIP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblClientMachineName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblFileRecevingPath;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCilentReceivingPath;
        private System.Windows.Forms.Button btnConnectToServer;
        private System.Windows.Forms.Timer tmrClient;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlServerDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlClientDetails;
        private System.Windows.Forms.Panel panel6;
    }
}