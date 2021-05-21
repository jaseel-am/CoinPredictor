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
    public partial class frmBuyCoin : Form
    {
        public frmBuyCoin()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            string strTempFromDate = "2021-05-02";
            string strTempToDate = "2021-05-05";
            //txtStartDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");
            //txtEndDate.Text = DateTime.Now.AddDays(3).ToString("dd-MMM-yyyy");

            txtStartDate.Text = strTempFromDate.AsDateTime().ToString("dd-MMM-yyyy");
            txtEndDate.Text = strTempToDate.AsDateTime().ToString("dd-MMM-yyyy");
            SymbolDropdownFill();
            OpeningBalanceGet();
            CurrentBalanceGet();
            btnBuy.Visible = false;
            txtQty.Visible = false;
            lblQty.Visible = false;
            txtQty.Text = string.Empty;
            txtTotalAmount.Visible = false;
            lblTotalAmount.Visible = false;
            txtTotalAmount.Text = string.Empty;
            lblProfitTarget.Visible = false;
            txtProfitTarget.Visible = false;
            txtProfitTarget.Text = string.Empty;
            txtStartDate.Focus();
        }
        private void SymbolDropdownFill()
        {
            BackLogDal objDal = new BackLogDal();
            cmbInstrument.DataSource = objDal.SymbolGetAllForDropdown();
            cmbInstrument.ValueMember = "SymbolId";
            cmbInstrument.DisplayMember = "Symbol";
        }
        private void OpeningBalanceGet()
        {
            PurcahseDal objDal = new PurcahseDal();
            DataTable dtbl = objDal.OpeningBalanceGet();
            foreach (DataRow row in dtbl.Rows)
            {
                txtOpeningBalance.Text = row["Credit"].ToString();
            }
        }
        private void CurrentBalanceGet()
        {
            PurcahseDal objDal = new PurcahseDal();
            DataTable dtbl = objDal.CurrentBalanceGet();
            foreach (DataRow row in dtbl.Rows)
            {
                txtCurrentBalance.Text = row["CurrentBalance"].ToString();
            }
        }
        private void CheckCondetionsForBuy()
        {
            try
            {
                BackLogDal objDal = new BackLogDal();
                DataTable dtbl = objDal.GetCloseValue(cmbInstrument.SelectedValue.ToString().AsInt(), txtStartDate.Text.AsDateTime());
                if (dtbl.Rows.Count > 0)
                {
                    if (dtbl.Rows[0]["RESULT"].ToString() != string.Empty)
                    {
                        txtClose0Date.Text = dtbl.Rows[0]["CLOSE0DATE"].ToString().AsDateTime().ToString("dd-MMM-yyyy");
                        txtClose1Date.Text = dtbl.Rows[0]["CLOSE1DATE"].ToString().AsDateTime().ToString("dd-MMM-yyyy");
                        txtClose0Value.Text = dtbl.Rows[0]["CLOSE0Val"].ToString();
                        txtClose1Value.Text = dtbl.Rows[0]["CLOSE1Val"].ToString();
                        double decClosVal = dtbl.Rows[0]["RESULT"].ToString().AsDouble();
                        txtCloseValue.Text = decClosVal.ToString();
                        if (decClosVal < 0.9)
                        {
                            txtCloseValue.BackColor = Color.Green;
                            txtCloseValue.ForeColor = Color.White;
                            btnBuy.Visible = true;
                            txtQty.Visible = true;
                            lblQty.Visible = true;
                            txtTotalAmount.Visible = true;
                            lblTotalAmount.Visible = true;
                            txtTotalAmount.Text = string.Empty;
                            lblProfitTarget.Visible = true;
                            txtProfitTarget.Visible = true;
                            double decClose0Value = txtClose0Value.Text.AsDouble();
                            double decCurrBal = txtCurrentBalance.Text.AsDouble();
                            double decQty = Math.Round(decCurrBal / decClose0Value, 0);
                            txtQty.Text = decQty.ToString();
                            txtQty.Focus();
                            AmountCalc();
                        }
                        else
                        {
                            txtCloseValue.BackColor = Color.Red;
                            txtCloseValue.ForeColor = Color.White;
                            btnBuy.Visible = false;
                            txtQty.Visible = false;
                            lblQty.Visible = false;
                            txtQty.Text = string.Empty;
                            txtTotalAmount.Visible = false;
                            lblTotalAmount.Visible = false;
                            txtTotalAmount.Text = string.Empty;
                            lblProfitTarget.Visible = false;
                            txtProfitTarget.Visible = false;
                            txtProfitTarget.Text = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Record found at this Date, Please change From Date", "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtStartDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trade: 3" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void AmountCalc()
        {
            try
            {
                double decQty = txtQty.Text.Trim().AsDouble();
                double decClose0Value = txtClose0Value.Text.Trim().AsDouble();
                double decTotal = Math.Round(decQty * decClose0Value, 3);
                double decProfitPer = Math.Round(decTotal * 1.1, 3);
                txtTotalAmount.Text = decTotal.ToString();
                txtProfitTarget.Text = decProfitPer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trade: 3" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnCheckClose_Click(object sender, EventArgs e)
        {
            try
            {
                CheckCondetionsForBuy();
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
                CheckCondetionsForBuy();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trade: 1" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpEndDate.Value;
                this.txtEndDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trade: 1" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmBackTrack_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtStartDate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string strTempToDate = txtStartDate.Text.AsDateTime().AddDays(3).ToString();
                txtEndDate.Text = strTempToDate.AsDateTime().ToString("dd-MMM-yyyy");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Trade: 2" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AmountCalc();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trade: 2" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SavePurchase()
        {
            PurcahseDal objDal = new PurcahseDal();
            PurchaseModel objModel = new PurchaseModel();
            objModel.PurchaseQty = txtQty.Text.AsInt();
            objModel.PurchaseDate = txtStartDate.Text.AsDateTime();
            objModel.TotalAmount = txtTotalAmount.Text.AsDouble();
            objModel.SymbolId = 1;
            objModel.UserId = 1;
            objModel.PurchaseRate = txtClose0Value.Text.AsDouble();
            objModel.ProfitTarget = txtProfitTarget.Text.AsDouble();
            int inRetId = objDal.PurchaseAdd(objModel);
            if (inRetId > 0)
            {
                MessageBox.Show("Purchased Successfully..!", "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTotalAmount.Text.AsDouble() > txtCurrentBalance.Text.AsDouble())
                {
                    MessageBox.Show("Cannot Purcahse.. You dont have enough balance. Modify the Qty to proceed.", "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQty.Focus();
                }
                else
                {
                    int inQty = txtQty.Text.AsInt();
                    if (inQty > 0)
                    {
                        if (Messages.UpdateMessageCustom("Are you Sure You want to purchase this item?"))
                        {
                            SavePurchase();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Quantity should be greaterthan 0", "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trade: 2" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
