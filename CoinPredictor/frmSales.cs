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
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            string strTempFromDate = "2021-05-02";
            txtStartDate.Text = strTempFromDate.AsDateTime().ToString("dd-MMM-yyyy");
            SymbolDropdownFill();
            txtStartDate.Focus();
            DgvHoldings.DataSource = null;
            DgvHoldings.Rows.Clear();
        }
        private void SymbolDropdownFill()
        {
            BackLogDal objDal = new BackLogDal();
            cmbInstrument.DataSource = objDal.SymbolGetAllForDropdown();
            cmbInstrument.ValueMember = "SymbolId";
            cmbInstrument.DisplayMember = "Symbol";
        }
        private void GetHoldings()
        {
            try
            {
                HoldingsDal objDal = new HoldingsDal();
                DataSet DsData = objDal.GetHoldings(1,cmbInstrument.SelectedValue.ToString().AsInt(), txtStartDate.Text.AsDateTime());
                DgvHoldings.DataSource = DsData.Tables[1];
                DataTable dtblHeader = DsData.Tables[0];
                foreach (DataRow row in dtblHeader.Rows)
                {
                    txtPurchaseRate.Text = row["PurchaseRate"].ToString();
                    txtPurchaseDate.Text = row["PurchaseDate"].ToString().AsDateTime().ToString("dd-MMM-yyyy");
                    txtPurchaseQty.Text = Math.Round(row["PurchaseQty"].ToString().AsDouble(),0).ToString();
                    txtTotalAmount.Text = row["TotalAmount"].ToString();
                    TxtTargetProfit.Text = row["ProfitTarget"].ToString();
                    txtPurchaseId.Text = row["PurchaseId"].ToString();
                }
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
                GetHoldings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trade: 3" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpStartDate.Value;
                this.txtStartDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trade: 1" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmHoldings_Load(object sender, EventArgs e)
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

        private void DgvHoldings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (Messages.UpdateMessageCustom("Are you Sure You want to exit this holdings?"))
                {
                    HoldingsDal objDal = new HoldingsDal();
                    SalesModel objModel = new SalesModel();
                    objModel.PurchaseId = txtPurchaseId.Text.Trim().AsInt();
                    objModel.SalesQty = txtPurchaseQty.Text.Trim().AsInt();
                    objModel.SalesRate = DgvHoldings.Rows[e.RowIndex].Cells["CloseVal"].Value.ToString().AsDouble();
                    objModel.SalesDate = DgvHoldings.Rows[e.RowIndex].Cells["LogDate"].Value.ToString().AsDateTime();
                    objModel.TotalAmount = DgvHoldings.Rows[e.RowIndex].Cells["TodaysTotalAmount"].Value.ToString().AsDouble();
                    objModel.ProfitorLoss = DgvHoldings.Rows[e.RowIndex].Cells["ProfitorLoss"].Value.ToString().AsDouble();
                    objModel.UserId = 1;
                    objModel.SymbolId = cmbInstrument.SelectedValue.ToString().AsInt();
                    int inRetId = objDal.SalesAdd(objModel);
                    Clear();
                    MessageBox.Show("Holding Exited Successfully..!", "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
