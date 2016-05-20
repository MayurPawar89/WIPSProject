using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPSProject
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
        Int16 nConnectionType = 0;
        public Int16 ConnectionType
        {
            get
            {
                return nConnectionType;
            }
            set
            {
                nConnectionType = value;
            }
        }

        public string sClientReceivedPath { get; set; }

        public string sClientCurrentStatus { get; set; }

        private void mainformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnectAnalyseScan frmcon = new frmConnectAnalyseScan();
            frmcon.ShowDialog();
        }

        private void showProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmShowProgress frmshowprog = new frmShowProgress();
            frmshowprog.ShowDialog();

        }

        private void serverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmServerNew ofrmserver = new frmServerNew();
            //ofrmserver.ShowDialog();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Connected as: " + ConnectionType.ToString());
            if (ConnectionType == 1)
            {
                pnlServer.Dock = DockStyle.Fill;
                pnlClient.Visible = false;
                pnlServer.Visible = true;
                tmrServer.Start();
                tmrClient.Stop();
            }
            else if (ConnectionType == 2)
            {
                pnlClient.Dock = DockStyle.Fill;
                pnlServer.Visible = false;
                pnlClient.Visible = true;
                tmrServer.Stop();
                tmrClient.Start();
                btnCilentReceivingPath.Visible = false;
                CheckLocationAvailable();
            }

        }

        IPEndPoint ipEnd;
        Socket sock;
        Socket clientSock;

        public string sServerCurrentStatus { get; set; }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            StartServer();
        }

        private void StartServer()
        {
            try
            {
                IPHostEntry ipEntry = Dns.GetHostByName(Dns.GetHostName());
                IPAddress[] addr = ipEntry.AddressList;

                IPAddress ip = addr[0];
                //MessageBox.Show("IP Address: " + ip.ToString());
                ipEnd = new IPEndPoint(ip, 5656);
                sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                sock.Bind(ipEnd);
                sServerCurrentStatus = "Starting...";
                sock.Listen(100);
                sServerCurrentStatus = "Running and waiting for client connection.";
                lblServerMachineIP.Text = ip.ToString();
                lblServerMachineName.Text = ipEntry.HostName.ToString();
                lblServerPort.Text = ipEnd.Port.ToString();
                btnStopServer.Visible = true;
                btnSendFile.Visible = true;
                pnlServerDetails.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Start server: " + ex.ToString());
            }
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (sock == null)
                {
                    MessageBox.Show("Please start server.");
                    return;
                }
                if (!sock.Connected)
                {
                    sock.Close();
                    sServerCurrentStatus = "Stopped.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Stop server: " + ex.ToString());
            }
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (sock != null)
                {
                    FileDialog fDg = new OpenFileDialog();
                    if (fDg.ShowDialog() == DialogResult.OK)
                    {
                        clientSock = sock.Accept();
                        if (clientSock != null)
                        {
                            SendFile(fDg.FileName);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in sending file: " + ex.ToString());
            }
        }

        private void SendFile(string fileName)
        {
            try
            {

                if (fileName == "")
                {
                    MessageBox.Show("Please select file to send");
                    return;
                }

                string filePath = "";

                fileName = fileName.Replace("\\", "/");
                while (fileName.IndexOf("/") > -1)
                {
                    filePath += fileName.Substring(0, fileName.IndexOf("/") + 1);
                    fileName = fileName.Substring(fileName.IndexOf("/") + 1);
                }


                byte[] fileNameByte = Encoding.ASCII.GetBytes(fileName);
                if (fileNameByte.Length > 850 * 1024)
                {
                    sServerCurrentStatus = "File size is more than 850kb, please try with small file.";
                    return;
                }

                sServerCurrentStatus = "Buffering ...";
                byte[] fileData = File.ReadAllBytes(filePath + fileName);
                byte[] clientData = new byte[4 + fileNameByte.Length + fileData.Length];
                byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);

                fileNameLen.CopyTo(clientData, 0);
                fileNameByte.CopyTo(clientData, 4);
                fileData.CopyTo(clientData, 4 + fileNameByte.Length);

                //curMsg.Text = "Connection to server ...";
                //clientSock.Connect(ipEnd);

                sServerCurrentStatus = "File sending...";
                clientSock.Send(clientData);

                sServerCurrentStatus = "Disconnecting...";
                clientSock.Close();
                clientSock = null;
                sServerCurrentStatus = "File transferred.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in send file: " + ex.ToString());
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void tmrClient_Tick(object sender, EventArgs e)
        {
            lblFileRecevingPath.Text = sClientReceivedPath;
            lblFileRecevingPath.Refresh();
            lblClientStatus.Text = sClientCurrentStatus;
            lblClientStatus.Refresh();
        }

        private void tmrServer_Tick(object sender, EventArgs e)
        {
            curMsg.Text = sServerCurrentStatus;

        }

        private void btnConnectToServer_Click(object sender, EventArgs e)
        {
            lblClientStatus.Text = ""; lblClientStatus.Refresh();
            //if (string.IsNullOrEmpty(sClientReceivedPath))
            //{
            //    MessageBox.Show("Please select file receiving path");
            //    return;
            //}
            try
            {
                pnlClientDetails.Visible = true;
                IPHostEntry ipEntry = Dns.GetHostByName(Dns.GetHostName());
                IPAddress[] addr = ipEntry.AddressList;

                IPAddress ip = addr[0];
                //MessageBox.Show("IP Address: " + ip.ToString());
                IPEndPoint ipEnd = new IPEndPoint(ip, 5656);
                Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                sClientCurrentStatus = "Connection to server ..."; curMsg.Refresh();
                clientSock.Connect(ipEnd);
                lblClinentMAchineIP.Text = ip.ToString();
                lblClientMachineName.Text = ipEntry.HostName.ToString();
                curMsg.Text = "Connected to server waiting to receive file."; curMsg.Refresh();
                
                AddFileWatcher();
                
                byte[] clientData = new byte[1024 * 5000];
                string receivedPath = sClientReceivedPath;

                int receivedBytesLen = clientSock.Receive(clientData);
                sClientCurrentStatus = "Receiving data...";

                int fileNameLen = BitConverter.ToInt32(clientData, 0);
                string fileName = Encoding.ASCII.GetString(clientData, 4, fileNameLen);

                BinaryWriter bWrite = new BinaryWriter(File.Open(receivedPath + "/" + fileName, FileMode.Append)); ;
                bWrite.Write(clientData, 4 + fileNameLen, receivedBytesLen - 4 - fileNameLen);

                sClientCurrentStatus = "Saving file...";

                bWrite.Close();
                clientSock.Close();
                sClientCurrentStatus = "Reeived & Saved file; Client Disconnected.";
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("No connection could be made because the target machine actively refused it"))
                    sClientCurrentStatus = "Unable to connect to server. \nPlease check server is runnung or not.";
                else
                    sClientCurrentStatus = "Unable to received file from server. \n" + ex.Message;
            }
        }

        private void AddFileWatcher()
        {
            FileSystemWatcher fsw = new FileSystemWatcher();
            fsw.Path = sClientReceivedPath;
            fsw.Filter = "*.*";

            fsw.IncludeSubdirectories = true;
            fsw.EnableRaisingEvents = true;

            fsw.Created += fsw_Created;
        }

        void fsw_Created(object sender, FileSystemEventArgs e)
        {
            //check file contains hot listed words.
            string[] sFileContent=File.ReadAllLines(Path.Combine(sClientReceivedPath, e.Name));
            foreach (string item in sFileContent)
            {
                if (item.Contains("SystemRoot"))
                {
                    MessageBox.Show("File " + e.Name.ToString() + " has been received from server.\nThis file may harm your computer. Please check file.");
                    break;
                }
            }
            //if hotlisted word found then show alert else show file received message.
            //Insert value in database.
            //MessageBox.Show("File " + e.Name.ToString() + " has been received from server.");
        }

        private void btnCilentReceivingPath_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog fd = new FolderBrowserDialog();
            //if (fd.ShowDialog() == DialogResult.OK)
            //{
            //    sClientReceivedPath = fd.SelectedPath;
            //}
            
        }

        private void CheckLocationAvailable()
        {
            sClientReceivedPath = Path.Combine("C:\\WIPS Project\\Files From Server");
            if (!Directory.Exists(sClientReceivedPath))
            {
                Directory.CreateDirectory(sClientReceivedPath);
            }
        }
    }
}
