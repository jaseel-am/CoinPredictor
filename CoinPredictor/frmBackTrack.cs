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
    public partial class frmBackTrack : Form
    {
        CheckBox headerCheckBox = new CheckBox();

        public frmBackTrack()
        {
            InitializeComponent();
        }

        private void Clear()
        {

            GetCurrentBalance();
            string strTempFromDate = "2021-05-02";
            string strTempToDate = "2021-05-05";
            txtStartDate.Text = strTempFromDate.AsDateTime().ToString("dd-MMM-yyyy");
            txtEndDate.Text = strTempToDate.AsDateTime().ToString("dd-MMM-yyyy");
            SymbolsFill();
            //  SymbolDropdownFill();
            txtStartDate.Focus();
            DgvData.DataSource = CreateTable();
            FillTradePerfoMatrix();
        }

        //private void SymbolDropdownFill()
        //{
        //    //BackLogDal objDal = new BackLogDal();
        //    //cmbInstrument.DataSource = objDal.SymbolGetAllForDropdown();
        //    //cmbInstrument.ValueMember = "SymbolId";
        //    //cmbInstrument.DisplayMember = "Symbol";
        //}

        //private void SymbolCheckBoxListFill()
        //{
        //    try
        //    {
        //        BackLogDal objDal = new BackLogDal();
        //        DataTable Dtbl = objDal.SymbolGetAllForDropdown();
        //        chbxLstInstrument.DataSource = Dtbl;
        //        chbxLstInstrument.DisplayMember = "Symbol";
        //        chbxLstInstrument.ValueMember = "SymbolId";
        //        DataTable dtTop10 = objDal.SymbolsTopTenGetAllForDropDown();
        //        DgvInstruments.DataSource = dtTop10;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("GetCurrentBalance: " + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
        private void SymbolsFill()
        {
            try
            {
                BackLogDal objDal = new BackLogDal();
                DataTable Dtbl = objDal.SymbolsTopTenGetAllForDropDown(txtStartDate.Text.AsDateTime());
                DataView view = new DataView(Dtbl);
                view.RowFilter = "RESULT = 0.00";
                foreach (DataRowView row in view)
                {
                    row.Delete();
                }
                DgvInstruments.DataSource = Dtbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetCurrentBalance: " + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //private void AddCheckBox()
        //{
        //    try
        //    {
        //        //Add a CheckBox Column to the DataGridView Header Cell.
        //        //Find the Location of Header Cell.
        //        Point headerCellLocation = this.DgvInstruments.GetCellDisplayRectangle(0, -1, true).Location;
        //        //Place the Header CheckBox in the Location of the Header Cell.
        //        headerCheckBox.Location = new Point(headerCellLocation.X + 8, headerCellLocation.Y + 2);
        //        headerCheckBox.BackColor = Color.White;
        //        headerCheckBox.Size = new Size(18, 18);
        //        //Assign Click event to the Header CheckBox.
        //        headerCheckBox.Click += new EventHandler(HeaderCheckBox_Clicked);
        //        DgvInstruments.Controls.Add(headerCheckBox);

        //        if (DgvInstruments.Columns.Contains("checkBoxColumn") == false)
        //        {
        //            //Add a CheckBox Column to the DataGridView at the first position.
        //            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
        //            checkBoxColumn.HeaderText = "";
        //            checkBoxColumn.Width = 30;
        //            checkBoxColumn.Name = "checkBoxColumn";
        //            DgvInstruments.Columns.Insert(0, checkBoxColumn);
        //            //Assign Click event to the DataGridView Cell.
        //            DgvInstruments.CellContentClick += new DataGridViewCellEventHandler(DataGridView_CellClick);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("AddCheckBox: " + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        //private void HeaderCheckBox_Clicked(object sender, EventArgs e)
        //{
        //    DgvInstruments.EndEdit();
        //    foreach (DataGridViewRow row in DgvInstruments.Rows)
        //    {
        //        DataGridViewCheckBoxCell checkBox = (row.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell);
        //        checkBox.Value = headerCheckBox.Checked;
        //    }
        //}

        //private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex == 0)
        //    {
        //        bool isChecked = true;
        //        foreach (DataGridViewRow row in DgvInstruments.Rows)
        //        {
        //            if (Convert.ToBoolean(row.Cells["checkBoxColumn"].EditedFormattedValue) == false)
        //            {
        //                isChecked = false;
        //                break;
        //            }
        //        }
        //        headerCheckBox.Checked = isChecked;
        //    }
        //}


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

        private DataTable GetDataForAutomation(string strSymbolId)
        {
            DataTable dtOutput = new DataTable();
            try
            {
                DateTime dtEntryDate = DateTime.Now;

                DateTime dtCurrEntryDate = DateTime.Now;
                DateTime dtPrevExitDate = DateTime.Now;
                double decExitPrice = 0;
                double inShare = 0;
                double decEntryPrice = 0;
                double decExitTotal = 0;
                double decProfit = 0;

                int inDuration = txtDuration.Text.AsInt();
                PurcahseDal objDal = new PurcahseDal();
                DataTable dtFromDB = objDal.GetValuesForAutoTradeMultiSymbol(strSymbolId, txtStartDate.Text.AsDateTime(), txtEndDate.Text.AsDateTime());

                //DataView view = dtFromDB.DefaultView;
                //view.Sort = "LogDate ASC";
                //DataTable dtbl = view.ToTable();

                dtOutput = CreateTable();
                List<DataTable> DtResult = dtFromDB.AsEnumerable().GroupBy(row => row.Field<string>("Symbol")).Select(g => g.CopyToDataTable()).ToList();
                foreach (DataTable table in DtResult)
                {
                    double decTotalOpening = txtOpeningBalance.Text.AsDouble();
                    int inSymbolCount = GetSelectedSymbolsCount();
                    double decTotalBal = Math.Round(decTotalOpening / inSymbolCount, 2);
                    DataView view = table.DefaultView;
                    view.Sort = "LogDate ASC";
                    DataTable dtbl = view.ToTable();
                    DateTime dtExitDate = DateTime.Now;
                    for (int i = 0; i < dtbl.Rows.Count; i++)
                    {
                        double decResult = dtbl.Rows[i]["RESULT"].ToString().AsDouble();
                        dtCurrEntryDate = dtbl.Rows[i]["LogDate"].ToString().AsDateTime();
                        if (decResult < 0.9)
                        {
                            dtEntryDate = dtbl.Rows[i]["LogDate"].ToString().AsDateTime();
                            if (dtExitDate.ToString("dd-MMM-yyyy") == DateTime.Now.ToString("dd-MMM-yyyy"))
                            {
                                dtExitDate = dtEntryDate.AddDays(-1);
                            }
                            if (dtEntryDate > dtExitDate)
                            {
                                dtExitDate = dtbl.Rows[i]["LogDate"].ToString().AsDateTime().AddDays(inDuration);
                                decExitPrice = GetExitPrice(dtbl, dtExitDate);
                                inShare = Math.Round(decTotalBal / dtbl.Rows[i]["CloseVal"].ToString().AsDouble(), 2);
                                decEntryPrice = dtbl.Rows[i]["CloseVal"].ToString().AsDouble();
                                decExitTotal = Math.Round(((decExitPrice - decEntryPrice) / decEntryPrice) * decTotalBal + decTotalBal, 0);
                                decProfit = Math.Round(((decEntryPrice - decExitPrice) / decEntryPrice) * decTotalBal, 0);
                                decProfit = decProfit < 0 ? Math.Abs(decProfit) : decProfit * -1;
                                DataRow dr = dtOutput.NewRow();
                                dr["SymbolId"] = dtbl.Rows[i]["SymbolId"].ToString();
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
                                decTotalBal = decExitTotal;
                            }
                        }
                    }
                    if (dtOutput.Rows.Count > 0)
                    {
                        dtOutput.Rows[dtOutput.Rows.Count - 1]["ExitOn"] = "Period End";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetDataForAutomation: " + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dtOutput;
        }

        private string GetSelectedSymbols()
        {
            string strIds = "";
            try
            {
                string message = string.Empty;
                foreach (DataGridViewRow row in DgvInstruments.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[chkSymbolSelect.Name].Value) == true)
                    {
                        int? id = row.Cells["insSymbolId"].Value.ToString().AsInt();
                        strIds = strIds + id + ",";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BtnAutomate_Click : " + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strIds.TrimEnd(',');
        }

        private int GetSelectedSymbolsCount()
        {
            int inCount = 0;
            foreach (DataGridViewRow row in DgvInstruments.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["chkSymbolSelect"].Value);
                if (isSelected)
                {
                    inCount++;
                }
            }
            return inCount;
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
                MessageBox.Show("GetExitPrice: " + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decExitPrice;
        }

        private DataTable CreateTable()
        {
            DataTable Dtbl = new DataTable();
            Dtbl.Columns.Add("SymbolId");
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

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpStartDate.Value;
                this.txtStartDate.Text = date.ToString("dd-MMM-yyyy");
                this.txtEndDate.Text = date.AddDays(30).ToString("dd-MMM-yyyy");
                this.dtpStartDate.Value = txtStartDate.Text.AsDateTime();
                this.dtpEndDate.Value = txtEndDate.Text.AsDateTime();
                SymbolsFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("dtpStartDate_ValueChanged : " + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("dtpEndDate_ValueChanged: " + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAutomate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStartDate.Text != string.Empty && txtEndDate.Text != string.Empty)
                {
                    string strSymbolIds = GetSelectedSymbols();
                    if (strSymbolIds != string.Empty)
                    {
                        DataTable dtbl = GetDataForAutomation(strSymbolIds);
                        int inCount = dtbl.Rows.Count;
                        if (inCount > 0)
                        {
                            dtbl.Rows[inCount - 1]["ExitOn"] = "Period End";
                            DgvData.DataSource = dtbl;
                            int inMasterId = SaveAutoTradeMaster();
                            if (inMasterId > 0)
                            {
                                SaveAutoTradeDetails(inMasterId);
                                MessageBox.Show("Auto Trade Saved Successfully", "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GetCurrentBalance();
                                FillTradePerfoMatrix();
                            }
                            else
                            {
                                MessageBox.Show("Something went wrong details not Saved", "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No Data to Automate", "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select atleast one Symbol to Run the Back Track", "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BtnAutomate_Click : " + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < DgvData.Rows.Count; i++)
            {
                double decVal = DgvData.Rows[i].Cells[7].Value.ToString().AsDouble();
                if (decVal > 0)
                {
                    DgvData.Rows[i].Cells[7].Style.ForeColor = Color.Green;
                }
                else
                {
                    DgvData.Rows[i].Cells[7].Style.ForeColor = Color.Red;
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
                inRetId = objDal.AutoTradeMasterInsert(ojbModel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AutoTradeMaster : " + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        ojbModel.SymbolId = dgrow.Cells["SymbolId"].Value.ToString().AsInt();
                        ojbModel.EntryDate = dgrow.Cells["EntryDate"].Value.ToString().AsDateTime();
                        ojbModel.EntryPrice = dgrow.Cells["EntryPrice"].Value.ToString().AsDouble();
                        ojbModel.ExitDate = dgrow.Cells["ExitDate"].Value.ToString().AsDateTime();
                        ojbModel.ExitPrice = dgrow.Cells["ExitPrice"].Value.ToString().AsDouble();
                        ojbModel.Qty = dgrow.Cells["Share"].Value.ToString().AsDouble();
                        ojbModel.ProfitorLoss = dgrow.Cells["Profit"].Value.ToString().AsDouble();
                        ojbModel.ClosingBalance = dgrow.Cells["AccountBalance"].Value.ToString().AsDouble();
                        ojbModel.ExitOn = dgrow.Cells["ExitOn"].Value.ToString();
                        int inRetId = objDal.AutoTradeDetailsInsert(ojbModel);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SaveAutoTradeDetails : " + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("FillTradePerfoMatrix : " + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("btnSave_Click : " + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("btnClear_Click : " + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("btnRefresh_Click : " + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmBackTrack_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("frmBackTrack_Load : " + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
