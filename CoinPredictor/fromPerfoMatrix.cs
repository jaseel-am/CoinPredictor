using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinPredictor
{
    public partial class frmPerfoMatrix : Form
    {
        public frmPerfoMatrix()
        {
            InitializeComponent();
        }

        private void frmPerfoMatrix_Load(object sender, EventArgs e)
        {
            ReportDal objDal = new ReportDal();
            DataSet dsData = objDal.PerfomanceMatrix();
            DataTable dtbl0 = dsData.Tables[0];
            DataTable dtbl1 = dsData.Tables[1];
            DataTable dtbl2 = dsData.Tables[2];
            DataTable dtbl3 = dsData.Tables[3];
            DataTable dtbl4 = dsData.Tables[4];
            txtProfitableTrade.Text = dtbl0.Rows[0]["ProfitableTrade"].ToString();
            txtFinalAccountBalance.Text = dtbl1.Rows[0]["FinalAccountBalance"].ToString();
            txtTotalTrade.Text = dtbl2.Rows[0]["TotalTrade"].ToString();
            txtProfitFactor.Text = dtbl3.Rows[0]["ProfitFactor"].ToString();
            txtGainPercent.Text = dtbl4.Rows[0]["GainPercent"].ToString();
        }
    }
}
