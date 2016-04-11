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
    public partial class frmServerNew : Form
    {
        public frmServerNew()
        {
            InitializeComponent();
        }
        IPEndPoint ipEnd;
        Socket sock;
        Socket clientSock;

        public string sCurrentStatus { get; set; }
        private void SendFile(string fileName)
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
                sCurrentStatus = "File size is more than 850kb, please try with small file.";
                return;
            }

            sCurrentStatus = "Buffering ...";
            byte[] fileData = File.ReadAllBytes(filePath + fileName);
            byte[] clientData = new byte[4 + fileNameByte.Length + fileData.Length];
            byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);

            fileNameLen.CopyTo(clientData, 0);
            fileNameByte.CopyTo(clientData, 4);
            fileData.CopyTo(clientData, 4 + fileNameByte.Length);

            //curMsg.Text = "Connection to server ...";
            //clientSock.Connect(ipEnd);

            sCurrentStatus = "File sending...";
            clientSock.Send(clientData);

            sCurrentStatus = "Disconnecting...";
            clientSock.Close();
            clientSock = null;
            sCurrentStatus = "File transferred.";
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            IPHostEntry ipEntry = Dns.GetHostByName(Dns.GetHostName());
            IPAddress[] addr = ipEntry.AddressList;

            IPAddress ip = addr[0];
            //MessageBox.Show("IP Address: " + ip.ToString());
            ipEnd = new IPEndPoint(ip, 5656);
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            sock.Bind(ipEnd);
            sCurrentStatus = "Starting...";
            sock.Listen(100);
            sCurrentStatus = "Running and waiting for client connection.";
            //clientSock = sock.Accept();
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            FileDialog fDg = new OpenFileDialog();
            if (fDg.ShowDialog() == DialogResult.OK)
            {
                clientSock = sock.Accept();
                SendFile(fDg.FileName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            curMsg.Text = sCurrentStatus;
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            if (sock == null)
            {
                MessageBox.Show("Please start server.");
                return;
            }
            if (!sock.Connected)
            {
                sock.Close();
                sCurrentStatus = "Stopped.";
            }
        }
    }
}
