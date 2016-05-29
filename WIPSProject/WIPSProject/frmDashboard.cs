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
using System.Configuration;
using System.Data.SqlClient;

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
        public enum MessageType
        {
            None,
            Information,
            Warning,
            Error,
            Question
        }
        public string sClientReceivedPath { get; set; }

        public string sApplicationTempPath { get; set; }

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
            if (ConnectionType == 1)
            {
                pnlServer.Dock = DockStyle.Fill;
                pnlClient.Visible = false;
                pnlServer.Visible = true;
                tmrServer.Start();
                tmrClient.Stop();
                CheckLocationAvailable(ConnectionType);
            }
            else if (ConnectionType == 2)
            {
                pnlClient.Dock = DockStyle.Fill;
                pnlServer.Visible = false;
                pnlClient.Visible = true;
                tmrServer.Stop();
                tmrClient.Start();
                btnCilentReceivingPath.Visible = false;
                CheckLocationAvailable(ConnectionType);
                pnlClientDetails.Visible = true;

                LoadHostlistWords();
                AddFileWatcher();
            }

        }

        private SqlConnection InitializeConnection()
        {
            SqlConnection conn = null;
            string strCon = System.Configuration.ConfigurationManager.ConnectionStrings["WIPSCon"].ConnectionString;
            conn = new SqlConnection(strCon);
            return conn;
        }

        private void LoadHostlistWords()
        {
            try
            {
                con = InitializeConnection();
                DataTable dt = new DataTable();
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT wor.sWord AS HotlistWord FROM dbo.WordsHotlist AS wor WHERE wor.bIsHotlistWord = 1", con))
                {
                    sda.Fill(dt);
                }
                lstWordsHotlist = new List<string>();
                foreach (DataRow dr in dt.Rows)
                {
                    lstWordsHotlist.Add(dr["HotlistWord"].ToString());
                }

            }
            catch (Exception ex)
            {
                ShowMessageBox("Error to get Hotlist of words" + ex.ToString(), MessageType.Error);
            }
            finally
            {
                if (con != null)
                {
                    con = null;
                }
            }
        }
        SqlConnection con = null;
        List<string> lstWordsHotlist = null;
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
                ShowMessageBox("Error in Start server: " + ex.ToString(), MessageType.Error);
            }
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (sock == null)
                {
                    ShowMessageBox("Please start server.", MessageType.Information);
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
                ShowMessageBox("Error in Stop server: " + ex.ToString(), MessageType.Error);
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
                ShowMessageBox("Error in sending file: " + ex.ToString(), MessageType.Error);
            }
        }

        private void SendFile(string fileName)
        {
            try
            {

                if (fileName == "")
                {
                    ShowMessageBox("Please select file to send", MessageType.Information);
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
                string sfName = string.Empty;

                string sfilename = Path.GetFileNameWithoutExtension(Path.Combine(sApplicationTempPath, fileName));
                string sfileext = Path.GetExtension(Path.Combine(sApplicationTempPath, fileName));
                sfName = sfilename + System.DateTime.Now.ToString("yyyymmddhhmmss") + sfileext;

                File.Copy(Path.Combine(filePath, fileName), Path.Combine(sApplicationTempPath, sfName));

                sServerCurrentStatus = "Buffering ...";
                byte[] fileData = File.ReadAllBytes(Path.Combine(sApplicationTempPath, sfName));
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
                ShowMessageBox("Error in send file: " + ex.ToString(), MessageType.Error);
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

            try
            {

                pnlClientDetails.Refresh();
                IPHostEntry ipEntry = Dns.GetHostByName(Dns.GetHostName());
                IPAddress[] addr = ipEntry.AddressList;

                IPAddress ip = addr[0];
                IPEndPoint ipEnd = new IPEndPoint(ip, 5656);
                Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                sClientCurrentStatus = "Connection to server ..."; 
                clientSock.Connect(ipEnd);
                lblClinentMAchineIP.Text = ip.ToString();
                lblClientMachineName.Text = ipEntry.HostName.ToString();
                sClientCurrentStatus = "Connected to server waiting to receive file.";
                pnlClientDetails.Refresh();


                byte[] btServerData = new byte[1024 * 5000];
                string receivedPath = sClientReceivedPath;

                int receivedBytesLen = clientSock.Receive(btServerData);
                sClientCurrentStatus = "Receiving data...";

                int fileNameLen = BitConverter.ToInt32(btServerData, 0);
                string fileName = Encoding.ASCII.GetString(btServerData, 4, fileNameLen);
                if (File.Exists(Path.Combine(receivedPath, fileName)))
                {
                    string sfilename = Path.GetFileNameWithoutExtension(Path.Combine(receivedPath, fileName));
                    string sfileext = Path.GetExtension(Path.Combine(receivedPath, fileName));
                    fileName = sfilename + System.DateTime.Now.ToString("yyyymmddhhmmss") + sfileext;
                }
                BinaryWriter bWrite = new BinaryWriter(File.Open(receivedPath + "/" + fileName, FileMode.Append)); ;
                bWrite.Write(btServerData, 4 + fileNameLen, receivedBytesLen - 4 - fileNameLen);

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

            //bIsFWSCreatedCalled = false;
            fsw.Created += fsw_Created;
            //fsw.Changed += fsw_Changed;
        }

        void fsw_Changed(object sender, FileSystemEventArgs e)
        {
            if (!bIsFWSCreatedCalled)
            {
                ScanFileAndAddTranInDB(e);
            }
        }
        Boolean bIsFWSCreatedCalled = false;
        void fsw_Created(object sender, FileSystemEventArgs e)
        {
            ScanFileAndAddTranInDB(e);
            //bIsFWSCreatedCalled = true;
        }

        private void ScanFileAndAddTranInDB(FileSystemEventArgs e)
        {
            try
            {
                //LoadingImage frm = new LoadingImage();
                //frm.ShowDialog();
                
                System.Threading.Thread.Sleep(1000);
                //check file contains hot listed words.
                bool bIsHotlistWordFound = false;
                string sFileFullPath = Path.Combine(sClientReceivedPath, e.Name);
                string[] sFileContent = File.ReadAllLines(sFileFullPath);
                List<string> fileLines = new List<string>();

                //using (var reader = new StreamReader(sFileFullPath))
                //{
                //    string line;
                //    while ((line = reader.ReadLine()) != null)
                //    {
                //        fileLines.Add(line);
                //    }
                //    reader.Close();
                //    reader.Dispose();
                //}
                //if (File.Exists(sFileFullPath))
                //{

                //    StreamReader SR = new StreamReader(sFileFullPath);
                //    string line;

                //    while ((line = SR.ReadLine()) != null)
                //    {
                //        fileLines.Add(line);
                //    }
                //    SR.Close();
                //    SR.Dispose();
                //}

                string sHotWord = string.Empty;
                foreach (string item in sFileContent)
                {
                    string sLine = item.ToLower();
                    foreach (string word in lstWordsHotlist)
                    {
                        if (sLine.Contains(word.ToLower()))
                        {
                            bIsHotlistWordFound = true;
                            sHotWord = word;
                            goto BreakLoop;
                        }
                    }
                }

            BreakLoop:

                //if hotlisted word found then show alert else show file received message.
                if (bIsHotlistWordFound)
                {
                    ShowMessageBox("File " + e.Name.ToString() + " has been received from server.\nThis file may harm your computer. Please check file.", MessageType.Warning);
                }
                else
                {
                    ShowMessageBox("File " + e.Name.ToString() + " has been received from server.\nThis file is safe.", MessageType.Warning);
                }



                //getFileInformation
                FileInfo sFileInfo = new FileInfo(sFileFullPath);
                string sfileName = sFileInfo.Name;
                string sfileSize = sFileInfo.Length.ToString();
                string sfileLoc = sFileInfo.FullName;
                string sTrnStatus = string.Empty;
                string sTrnDetails = string.Empty;
                if (bIsHotlistWordFound)
                {
                    sTrnStatus = "Error";
                    sTrnDetails = "File contains the word : " + sHotWord;
                }
                else
                {
                    sTrnStatus = "Success";
                    sTrnDetails = "File is safe";
                }

                //Insert value in database.
                Int64 nFileID = InsertFileDetailsInDB(sfileName, sfileSize, sfileLoc);
                bool bIsTrnInDB = InsertTransactionDetailsInDB(nFileID, sTrnStatus, sTrnDetails);
            }
            catch (Exception ex)
            {
                ShowMessageBox("Error scanning file: " + ex.ToString(), MessageType.Error);
            }
        }

        private void ShowMessageBox(string sMessageText, MessageType messageType = 0)
        {
            switch (messageType)
            {
                case MessageType.None:
                    MessageBox.Show(sMessageText, "WIPS", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    break;
                case MessageType.Information:
                    MessageBox.Show(sMessageText, "WIPS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    break;
                case MessageType.Warning:
                    MessageBox.Show(sMessageText, "WIPS", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    break;
                case MessageType.Error:
                    MessageBox.Show(sMessageText, "WIPS", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    break;
                case MessageType.Question:
                    MessageBox.Show(sMessageText, "WIPS", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    break;
            }
        }

        private bool InsertTransactionDetailsInDB(Int64 FileID, string TrnStatus, string TrnDetails)
        {
            bool result = false;
            object obj = null;
            try
            {
                using (con = InitializeConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO [FileTransactions]([nFileID],[sSourceID],[sDestinationID],[sTrnStatus],[sTrnDetails]) Output Inserted.nTrnID VALUES('{0}','{1}','{2}','{3}','{4}')", FileID, lblClinentMAchineIP.Text, lblClinentMAchineIP.Text, TrnStatus, TrnDetails), con))
                    {
                        con.Open();
                        obj = cmd.ExecuteScalar();
                        con.Close();
                    }
                }

                if (obj != null)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                ShowMessageBox("Error in Insert file details in Database: " + ex.ToString(), MessageType.Error);
            }
            finally
            {
                if (obj != null)
                    obj = null;
            }

            return result;
        }

        private Int64 InsertFileDetailsInDB(string sfileName, string sfileSize, string sfileLoc)
        {
            Int64 nFileID = 0;
            object obj = null;
            try
            {
                using (con = InitializeConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO [FileInformation]([sFileName],[sFileSize],[sFileLocation],[bIsFileScan]) Output Inserted.nFileID VALUES('{0}','{1}','{2}','{3}')", sfileName, sfileSize, sfileLoc, "True"), con))
                    {
                        con.Open();
                        obj = cmd.ExecuteScalar();
                        con.Close();
                    }
                }

                if (obj != null)
                {
                    nFileID = Convert.ToInt64(obj);
                }
            }
            catch (Exception ex)
            {
                ShowMessageBox("Error in Insert file details in Database: " + ex.ToString(), MessageType.Error);
            }
            finally
            {
                if (obj != null)
                    obj = null;
            }

            return nFileID;
        }

        private void btnCilentReceivingPath_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog fd = new FolderBrowserDialog();
            //if (fd.ShowDialog() == DialogResult.OK)
            //{
            //    sClientReceivedPath = fd.SelectedPath;
            //}

        }

        private void CheckLocationAvailable(int ConType)
        {
            try
            {
                if (ConType == 1)
                {
                    string sApplicationPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Temp");
                    if (!Directory.Exists(sApplicationPath))
                    {
                        Directory.CreateDirectory(sApplicationPath);
                    }
                    sApplicationTempPath = sApplicationPath;
                }
                else
                {
                    sClientReceivedPath = Path.Combine("C:\\WIPS Project\\Files From Server");
                    if (!Directory.Exists(sClientReceivedPath))
                    {
                        Directory.CreateDirectory(sClientReceivedPath);
                    }
                }

            }
            catch (Exception ex)
            {
                ShowMessageBox("Error creating default folder location: " + ex.ToString(), MessageType.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnClientExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.ShowInTaskbar = false;
            frm.ShowDialog();
        }

        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
