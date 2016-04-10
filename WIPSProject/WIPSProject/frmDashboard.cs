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
            FTServerCode.frmServer ofrmserver = new FTServerCode.frmServer();
            ofrmserver.ShowDialog();
        }
    }
}
