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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void mainformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectAnalyseScan frmcon = new ConnectAnalyseScan();
            frmcon.ShowDialog();
        }

        private void showProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ShowProgress frmshowprog = new ShowProgress();
            frmshowprog.ShowDialog();

        }
    }
}
