using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPSProject
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        SqlConnection con = null;
        private SqlConnection InitializeConnection()
        {
            SqlConnection conn = null;
            string strCon = System.Configuration.ConfigurationManager.ConnectionStrings["WIPSCon"].ConnectionString;
            conn = new SqlConnection(strCon);
            return conn;
        }
        private void frmReport_Load(object sender, EventArgs e)
        {
            rdAll.Checked = true;
            //GetTransactionDetails();
        }

        private void GetTransactionDetails(int nStatus)
        {
            string sFilter = string.Empty;
            switch (nStatus)
            {
                case 0: sFilter = "('Success','Error')";
                    break;
                case 1: sFilter = "('Success')";
                    break;
                case 2: sFilter = "('Error')";
                    break;
            }
            DataTable _dt = new DataTable();
            try
            {
                using (con = InitializeConnection())
                {

                    using (SqlCommand cmd = new SqlCommand(string.Format("SELECT  ROW_NUMBER() OVER (ORDER BY ntrnid) AS Row,FileTransactions.dtTrnDate, FileTransactions.sSourceID, FileTransactions.sDestinationID, FileTransactions.sTrnStatus, FileTransactions.sTrnDetails, FileInformation.sFileName, FileInformation.sFileSize FROM  FileTransactions INNER JOIN FileInformation ON FileTransactions.nFileID = FileInformation.nFileID where sTrnStatus in {0}",sFilter), con))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            sda.Fill(_dt);
                        }
                    }
                }

                if (_dt != null)
                {
                    dgvFileInfo.DataSource = _dt;
                }
                else
                    MessageBox.Show("No file transaction not presemt in database.", "WIPS", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in getting data from database.", "WIPS", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                //ShowMessageBox("Error in Insert file details in Database: " + ex.ToString(), MessageType.Error);
            }
            finally
            {

            }
        }

        private void rdAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAll.Checked)
            {
                GetTransactionDetails(0);
            }
        }

        private void rdSuccess_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSuccess.Checked)
            {
                GetTransactionDetails(1);
            }
        }

        private void rdError_CheckedChanged(object sender, EventArgs e)
        {
            if (rdError.Checked)
            {
                GetTransactionDetails(2);
            }
        }
    }
}
