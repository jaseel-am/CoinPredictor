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
    public partial class frmProfitReport : Form
    {
        public frmProfitReport()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            string strTempFromDate = "2021-05-02";
           //txtStartDate.Text = strTempFromDate.AsDateTime().ToString("dd-MMM-yyyy");
            SymbolDropdownFill();
            //txtStartDate.Focus();
        }
        private void SymbolDropdownFill()
        {
            BackLogDal objDal = new BackLogDal();
            cmbInstrument.DataSource = objDal.SymbolGetAllForDropdown();
            cmbInstrument.ValueMember = "Symbol";
            cmbInstrument.DisplayMember = "Symbol";
        }
        private void frmProfitReport_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Trade: 3" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                ReportDal objDal = new ReportDal();
                DataTable Dtbl = objDal.ProfitOrLossReport();
                DgvProfitorLoss.DataSource = Dtbl;
                CurrentBalanceGet();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Trade: 3" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CurrentBalanceGet()
        {
            PurcahseDal objDal = new PurcahseDal();
            DataTable dtbl = objDal.CurrentBalanceGet();
            foreach (DataRow row in dtbl.Rows)
            {
                txtClosingBalance.Text = row["CurrentBalance"].ToString();
            }
        }

        //private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DateTime date = this.dtpStartDate.Value;
        //        this.txtStartDate.Text = date.ToString("dd-MMM-yyyy");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Trade: 1" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
    }
}
