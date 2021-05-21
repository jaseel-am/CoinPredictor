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
    public partial class frmAutoTrade : Form
    {
        public frmAutoTrade()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            GetCurrentBalance();
            btnSave.Visible = false;
            string strTempFromDate = "2021-05-02";
            string strTempToDate = "2021-05-05";
            txtStartDate.Text = strTempFromDate.AsDateTime().ToString("dd-MMM-yyyy");
            txtEndDate.Text = strTempToDate.AsDateTime().ToString("dd-MMM-yyyy");
            SymbolDropdownFill();
            txtStartDate.Focus();
            DgvData.DataSource = CreateTable();
            FillTradePerfoMatrix();
        }
        private void SymbolDropdownFill()
        {
            BackLogDal objDal = new BackLogDal();
            cmbInstrument.DataSource = objDal.SymbolGetAllForDropdown();
            cmbInstrument.ValueMember = "SymbolId";
            cmbInstrument.DisplayMember = "Symbol";
        }
        private void GetCurrentBalance()
        {
            try
            {
                AutoTradeDal objDal = new AutoTradeDal();
                double decOpeningBal = objDal.GetAutoTradeCurrentBalance();
                txtOpeningBalance.Text = decOpeningBal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetCurrentBalance: " + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private DataTable GetDataForAutomation()
        {
            DataTable dtOutput = new DataTable();
            try
            {
                bool isFirst = false;
                DateTime dtEntryDate = DateTime.Now;
                DateTime dtExitDate = DateTime.Now;
                double decExitPrice = 0;
                double inShare = 0;
                double decEntryPrice = 0;

                double decEntryTotal = 0;
                double decExitTotal = 0;
                double decProfit = 0;
                double decTotalBal = txtOpeningBalance.Text.AsDouble();

                int inDuration = txtDuration.Text.AsInt();
                PurcahseDal objDal = new PurcahseDal();
                DataTable dtFromDB = objDal.GetValuesForAutoTrade(cmbInstrument.SelectedValue.ToString().AsInt(), txtStartDate.Text.AsDateTime(), txtEndDate.Text.AsDateTime());

                DataView view = dtFromDB.DefaultView;
                view.Sort = "LogDate ASC";
                DataTable dtbl = view.ToTable();


                dtOutput = CreateTable();
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    double decResult = dtbl.Rows[i]["RESULT"].ToString().AsDouble();
                    if (decResult < 0.9 )
                    {
                        dtEntryDate = dtbl.Rows[i]["LogDate"].ToString().AsDateTime();
                        dtExitDate = dtbl.Rows[i]["LogDate"].ToString().AsDateTime().AddDays(inDuration);
                        decExitPrice = GetExitPrice(dtbl, dtExitDate);
                        inShare = Math.Round(txtOpeningBalance.Text.AsDouble() / dtbl.Rows[i]["CloseVal"].ToString().AsDouble(), 0);
                        decEntryPrice = dtbl.Rows[i]["CloseVal"].ToString().AsDouble();

                        decEntryTotal = inShare * decEntryPrice;
                        decExitTotal = Math.Round(inShare * decExitPrice, 0);
                        //decProfit = Math.Round((decExitTotal) - (decEntryTotal), 0);
                        decProfit = Math.Round(((decEntryPrice - decExitPrice) / decEntryPrice) * decTotalBal, 0);
                        decProfit = decProfit < 0 ? Math.Abs(decProfit) : decProfit * -1;
                        DataRow dr = dtOutput.NewRow();
                        dr["Symbol"] = dtbl.Rows[i]["Symbol"].ToString();
                        dr["EntryDate"] = dtEntryDate.ToString("dd-MMM-yyyy");
                        dr["EntryPrice"] = decEntryPrice;
                        dr["ExitDate"] = dtExitDate.ToString("dd-MMM-yyyy");
                        dr["ExitPrice"] = decExitPrice;
                        dr["Share"] = inShare;
                        dr["Profit"] = decProfit;
                        dr["ExitOn"] = "Duration Limit";
                        dr["AccountBalance"] = decExitTotal;
                        dtOutput.Rows.Add(dr);
                        isFirst = true;
                        decTotalBal = decProfit + txtOpeningBalance.Text.AsDouble();
                    }
                    else if (isFirst)
                    {
                        //dtEntryDate = dtExitDate;
                        //decEntryPrice = decExitPrice;
                        //dtExitDate = dtEntryDate.AddDays(txtDuration.Text.AsInt());
                        //decExitPrice = GetExitPrice(dtbl, dtExitDate);
                        //if (decExitPrice > 0)
                        //{
                        //    inShare = Math.Round(decTotalBal / decEntryPrice, 0);
                        //    decEntryTotal = inShare * decEntryPrice;
                        //    decExitTotal = Math.Round(inShare * decExitPrice, 0);
                        //    //decProfit = Math.Round((decExitTotal) - (decEntryTotal), 0);
                        //    decProfit = Math.Round(((decEntryPrice - decExitPrice) / decEntryPrice) * decTotalBal, 0);
                        //    decProfit = decProfit < 0 ? Math.Abs(decProfit) : decProfit * -1;
                        //    DataRow dr = dtOutput.NewRow();
                        //    dr["Symbol"] = dtbl.Rows[i]["Symbol"].ToString();
                        //    dr["EntryDate"] = dtEntryDate.ToString("dd-MMM-yyyy");
                        //    dr["EntryPrice"] = decEntryPrice;
                        //    dr["ExitDate"] = dtExitDate.ToString("dd-MMM-yyyy");
                        //    dr["ExitPrice"] = decExitPrice;
                        //    dr["Share"] = inShare;
                        //    dr["Profit"] = decProfit;
                        //    dr["ExitOn"] = "Duration Limit";
                        //    dr["AccountBalance"] = decExitTotal;
                        //    dtOutput.Rows.Add(dr);
                        //    decTotalBal = decExitTotal;
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trade: 3" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dtOutput;
        }
        private double GetExitPrice(DataTable dtbl, DateTime dtExitDate)
        {
            double decExitPrice = 0;
            try
            {
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    if (dtbl.Rows[i]["LogDate"].ToString().AsDateTime() == dtExitDate)
                    {
                        decExitPrice = dtbl.Rows[i]["CloseVal"].ToString().AsDouble();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trade: 3" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decExitPrice;
        }
        private DataTable CreateTable()
        {
            DataTable Dtbl = new DataTable();
            Dtbl.Columns.Add("Symbol");
            Dtbl.Columns.Add("EntryDate");
            Dtbl.Columns.Add("EntryPrice");
            Dtbl.Columns.Add("ExitDate");
            Dtbl.Columns.Add("ExitPrice");
            Dtbl.Columns.Add("Share");
            Dtbl.Columns.Add("Profit");
            Dtbl.Columns.Add("AccountBalance");
            Dtbl.Columns.Add("ExitOn");
            return Dtbl;
        }
        private void frmCoinAutomate_Load(object sender, EventArgs e)
        {
            Clear();
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

        private void BtnAutomate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStartDate.Text != string.Empty && txtEndDate.Text != string.Empty)
                {
                    DataTable dtbl = GetDataForAutomation();
                    int inCount = dtbl.Rows.Count;
                    if (inCount > 0)
                    {
                        dtbl.Rows[inCount - 1]["ExitOn"] = "Period End";
                        DgvData.DataSource = dtbl;
                        btnSave.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trade: 1" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < DgvData.Rows.Count; i++)
            {
                double decVal = DgvData.Rows[i].Cells[6].Value.ToString().AsDouble();
                if (decVal > 0)
                {
                    DgvData.Rows[i].Cells[6].Style.ForeColor = Color.Green;
                }
                else
                {
                    DgvData.Rows[i].Cells[6].Style.ForeColor = Color.Red;
                }
            }
        }
        private int SaveAutoTradeMaster()
        {
            int inRetId = 0;
            try
            {
                AutoTradeDal objDal = new AutoTradeDal();
                AutoTradeModel ojbModel = new AutoTradeModel();
                ojbModel.OpeningBalance = txtOpeningBalance.Text.AsDouble();
                ojbModel.Duration = txtDuration.Text.AsInt();
                ojbModel.StartDate = txtStartDate.Text.AsDateTime();
                ojbModel.EndDate = txtEndDate.Text.AsDateTime();
                ojbModel.SymbolId = cmbInstrument.SelectedValue.ToString().AsInt();
                inRetId = objDal.AutoTradeMasterInsert(ojbModel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trade: AutoTradeMaster" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return inRetId;
        }
        private void SaveAutoTradeDetails(int inMasterId)
        {
            try
            {
                AutoTradeDal objDal = new AutoTradeDal();
                foreach (DataGridViewRow dgrow in DgvData.Rows)
                {
                    AutoTradeDetailsModel ojbModel = new AutoTradeDetailsModel();
                    if (dgrow.Cells["Symbol"].Value != null)
                    {
                        ojbModel.AutoTradeId = inMasterId;
                        ojbModel.EntryDate = dgrow.Cells["EntryDate"].Value.ToString().AsDateTime();
                        ojbModel.EntryPrice = dgrow.Cells["EntryPrice"].Value.ToString().AsDouble();
                        ojbModel.ExitDate = dgrow.Cells["ExitDate"].Value.ToString().AsDateTime();
                        ojbModel.ExitPrice = dgrow.Cells["ExitPrice"].Value.ToString().AsDouble();
                        ojbModel.Qty = dgrow.Cells["Share"].Value.ToString().AsInt();
                        ojbModel.ProfitorLoss = dgrow.Cells["Profit"].Value.ToString().AsDouble();
                        ojbModel.ClosingBalance = dgrow.Cells["AccountBalance"].Value.ToString().AsDouble();
                        ojbModel.ExitOn = dgrow.Cells["ExitOn"].Value.ToString();
                        int inRetId = objDal.AutoTradeDetailsInsert(ojbModel);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trade: AutoTradeMaster" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FillTradePerfoMatrix()
        {
            try
            {
                AutoTradeDal objDal = new AutoTradeDal();
                DataSet dsData = objDal.GetAutoTradePerfomanceMatrixReport();
                DataTable dtbl0 = dsData.Tables[0];
                DataTable dtbl1 = dsData.Tables[1];
                DataTable dtbl2 = dsData.Tables[2];
                DataTable dtbl3 = dsData.Tables[3];
                DataTable dtbl4 = dsData.Tables[4];
                txtProfitableTrade.Text = Math.Round(dtbl0.Rows[0]["ProfitableTrade"].ToString().AsDouble(), 2).ToString();
                txtFinalAccountBalance.Text = Math.Round(dtbl1.Rows[0]["FinalAccountBalance"].ToString().AsDouble(), 2).ToString();
                txtProfitFactor.Text = Math.Round(dtbl2.Rows[0]["ProfitFactor"].ToString().AsDouble(), 2).ToString();
                txtTotalTrade.Text = Math.Round(dtbl3.Rows[0]["TotalTrade"].ToString().AsDouble(), 2).ToString();
                txtGainPercent.Text = Math.Round(dtbl4.Rows[0]["GainPercent"].ToString().AsDouble(), 2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trade: AutoTradeMaster" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Messages.UpdateMessageCustom("Are you Sure You want to Save this Auto Trading?"))
                {
                    int inMasterId = SaveAutoTradeMaster();
                    if (inMasterId > 0)
                    {
                        SaveAutoTradeDetails(inMasterId);
                        MessageBox.Show("Auto Trade Saved Successfully", "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong details not Saved", "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trade: btnSave_Click" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trade: btnClear_Click" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                FillTradePerfoMatrix();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trade: btnRefresh_Click" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
