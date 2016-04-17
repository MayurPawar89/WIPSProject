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
            frmDashboard frmDashboard = new frmDashboard();
            frmDashboard.ConnectionType = ConnectAs;
            frmDashboard.Show();
            this.Hide();
        }

        private void rdClient_CheckedChanged(object sender, EventArgs e)
        {
            ConnectAs = Convert.ToInt16(ConnectionType.Client);
        }

        private void rdServer_CheckedChanged(object sender, EventArgs e)
        {
            ConnectAs = Convert.ToInt16(ConnectionType.Server);
        }
    }
}
