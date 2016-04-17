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
                return  nConnectionType;
            }
            set
            {
                nConnectionType = value;
            }
        }


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
            frmServerNew ofrmserver = new frmServerNew();
            ofrmserver.ShowDialog();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Connected as: " + ConnectionType.ToString());
        }
    }
}
