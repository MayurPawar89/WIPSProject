using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPSProject
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }
        enum ConnectionType
        {
            None,
            Server,
            Client
        }
        public Int16 ConnectAs = 0;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (ConnectAs!=0)
            {
                frmDashboard frmDashboard = new frmDashboard();
                frmDashboard.ConnectionType = ConnectAs;
                frmDashboard.Show();
                if (ConnectAs==(int)ConnectionType.Server)
                    frmDashboard.Text = "Dashboard Server";
                else
                    frmDashboard.Text = "Dashboard Client";
                
                this.Hide();
            }
        }

        private void rdClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rdClient.Checked)
            {
                ConnectAs = Convert.ToInt16(ConnectionType.Client);
            }
        }

        private void rdServer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdServer.Checked)
            {
                ConnectAs = Convert.ToInt16(ConnectionType.Server);
            }
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            txtTitle.Text = "Windows Intrusion Prevension" + Environment.NewLine + " System (WIPS)";
        }
    }
}
