using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace CoinPredictor
{
    public partial class frmProcessData : Form
    {
        public frmProcessData()
        {
            InitializeComponent();
        }
        private void FillSheets()
        {
            List<string> Lists = new List<string>();
            ReadFromExcel objClass = new ReadFromExcel();
            string strPath = txtFilePath.Text.Trim();
            Lists = objClass.GetAllSheetNames(strPath);
            CmbSheets.DataSource = Lists;

            ///// Load all data to Symbol Table first time------------
            //AutoTradeDal objDal = new AutoTradeDal();
            //for (int i = 0; i < Lists.Count; i++)
            //{
            //    string Symbol = Lists[i].ToString();
            //    string desc = "USDT";
            //    objDal.SymbolsAdd(Symbol, desc);
            //}
        }
        private int FillCoinData()
        {
            int inCount = 0;
            try
            {
                ReadFromExcel objClass = new ReadFromExcel();
                ReadOpenXml objopnxml = new ReadOpenXml();
                string strPath = txtFilePath.Text.Trim();
                string SheetName = CmbSheets.SelectedValue.ToString();

                DataTable dtExcelData = objClass.ReadExcelFile(strPath, SheetName, "YES");
                //DataTable dtExcelData = objopnxml.ReadFromExcel(strPath);

                DataView view = dtExcelData.DefaultView;
                view.Sort = "Date DESC";
                DataTable dtView = view.ToTable();
                DataTable dtbl = AddCoulmns(dtView);
                double decTrueRange = 0;
                double decPrevRange = 0;


                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    string strSymbol, strDecription = string.Empty;

                    double decCurrClose, decCurrLow, decCurrHigh = 0;
                    double decPrevClose;
                    DateTime dtCurrDate, dtPrevDate;
                    dtPrevDate = Convert.ToDateTime(dtbl.Rows[i]["Date"].ToString()).AddDays(-1);
                    dtCurrDate = Convert.ToDateTime(dtbl.Rows[i]["Date"].ToString());

                    decCurrHigh = dtbl.Rows[i]["High"].ToString().AsDouble();
                    decCurrLow = dtbl.Rows[i]["Low"].ToString().AsDouble();
                    decCurrClose = dtbl.Rows[i]["Close"].ToString().AsDouble();

                    strSymbol = dtbl.Rows[i]["Symbol"].ToString();
                    strDecription = dtbl.Rows[i]["Description"].ToString();


                    var prevclos = from customer in dtbl.AsEnumerable()
                                   where customer.Field<string>("Symbol") == strSymbol && customer.Field<DateTime>("Date") == dtPrevDate
                                   select customer.Field<double>("Close");
                    if (prevclos.Any())
                    {
                        decPrevClose = prevclos.First().ToString().AsDouble();
                        decTrueRange = Math.Max(decCurrHigh - decCurrLow, Math.Max(decCurrHigh - decPrevClose, decPrevClose - decPrevClose));
                        dtbl.Rows[i]["True_Range"] = decTrueRange;
                    }
                    if (decPrevRange > 0 && decTrueRange > 0 && i > 0)
                    {
                        dtbl.Rows[i - 1]["ATR_2"] = Average(decTrueRange, decPrevRange);
                        decPrevRange = decTrueRange;
                    }
                    else
                    {
                        decPrevRange = decTrueRange;
                    }
                    inCount++;
                }
                DataTable dtblATR5 = ATR5(dtbl);
                DataTable dtblATR14 = ATR14(dtblATR5);
                DataTable dtblROC2 = ROC2(dtblATR14);
                DataTable dtblROC5 = ROC5(dtblROC2);
                DataTable dtblROC14 = ROC14(dtblROC5);
                DataTable dtblNATR2 = NATR2(dtblROC14);
                DataTable dtblNATR5 = NATR5(dtblNATR2);
                DataTable dtblNATR14 = NATR14(dtblNATR5);
                DataTable dtblPP_Ratio = PP_Ratio(dtblNATR14);

                DataView vw = dtblPP_Ratio.DefaultView;
                vw.Sort = "Symbol ASC";
                DataTable dtfinal = vw.ToTable();
                DgvData.DataSource = dtfinal;
                return inCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return inCount;
        }
        private DataTable ATR5(DataTable dtbl)
        {
            try
            {
                int incount = 0;
                double decOutput = 0;
                double decResult = 0;
                for (int j = 0; j < dtbl.Rows.Count; j++)
                {
                    string strSymbol = dtbl.Rows[j]["Symbol"].ToString().ToUpper();
                    DateTime dtfrom = Convert.ToDateTime(dtbl.Rows[j]["Date"].ToString());
                    DateTime dtTo = dtfrom.AddDays(-5);
                    for (int i = 0; i < dtbl.Rows.Count; i++)
                    {
                        string strSymbI = dtbl.Rows[i]["Symbol"].ToString().ToUpper();
                        DateTime dtDate = Convert.ToDateTime(dtbl.Rows[i]["Date"].ToString());
                        if ((dtDate >= dtTo && dtDate <= dtfrom) && (strSymbol == strSymbI))
                        {
                            if (dtbl.Rows[i]["True_Range"].ToString() != string.Empty)
                            {
                                decResult = decResult + dtbl.Rows[i]["True_Range"].ToString().AsDouble();
                                incount++;
                            }
                        }
                    }
                    if (incount == 6)
                    {
                        decOutput = Math.Round(decResult / 6, 2);
                    }
                    dtbl.Rows[j]["ATR_5"] = decOutput;
                    decOutput = 0;
                    decResult = 0;
                    incount = 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtbl;
        }
        private DataTable ATR14(DataTable dtbl)
        {
            try
            {
                int incount = 0;
                double decOutput = 0;
                double decResult = 0;
                for (int j = 0; j < dtbl.Rows.Count; j++)
                {
                    string strSymbol = dtbl.Rows[j]["Symbol"].ToString().ToUpper();
                    DateTime dtfrom = Convert.ToDateTime(dtbl.Rows[j]["Date"].ToString());
                    DateTime dtTo = dtfrom.AddDays(-14);
                    for (int i = 0; i < dtbl.Rows.Count; i++)
                    {
                        DateTime dtDate = Convert.ToDateTime(dtbl.Rows[i]["Date"].ToString());
                        string strSymbI = dtbl.Rows[i]["Symbol"].ToString().ToUpper();
                        if ((dtDate >= dtTo && dtDate <= dtfrom) && (strSymbol == strSymbI))
                        {
                            if (dtbl.Rows[i]["True_Range"].ToString() != string.Empty)
                            {
                                decResult = decResult + dtbl.Rows[i]["True_Range"].ToString().AsDouble();
                                incount++;
                            }
                        }
                    }
                    if (incount == 15)
                    {
                        decOutput = Math.Round(decResult / 15, 2);
                    }
                    dtbl.Rows[j]["ATR_14"] = decOutput;
                    decOutput = 0;
                    decResult = 0;
                    incount = 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtbl;
        }

        private DataTable ROC2(DataTable dtbl)
        {
            for (int j = 0; j < dtbl.Rows.Count; j++)
            {
                string strSymbol = dtbl.Rows[j]["Symbol"].ToString().ToUpper();
                DateTime dtfrom = Convert.ToDateTime(dtbl.Rows[j]["Date"].ToString());
                double decCurrClose = dtbl.Rows[j]["Close"].ToString().AsDouble();
                DateTime dtTo = dtfrom.AddDays(-2);
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    if (Convert.ToDateTime(dtbl.Rows[i]["Date"].ToString()) == dtTo && (dtbl.Rows[i]["Symbol"].ToString() == strSymbol))
                    {
                        double decPrevClose = dtbl.Rows[i]["Close"].ToString().AsDouble();
                        double decResult = Math.Round(((decCurrClose - decPrevClose) / decPrevClose) * 100, 2);
                        dtbl.Rows[j]["ROC_2"] = decResult;
                    }
                }

            }
            return dtbl;
        }
        private DataTable ROC5(DataTable dtbl)
        {
            for (int j = 0; j < dtbl.Rows.Count; j++)
            {
                double decCurrClose = 0;
                string strSymbol = dtbl.Rows[j]["Symbol"].ToString().ToUpper();
                DateTime dtfrom = Convert.ToDateTime(dtbl.Rows[j]["Date"].ToString()).AddDays(1);
                if (j > 0)
                {
                    decCurrClose = dtbl.Rows[j - 1]["Close"].ToString().AsDouble();
                }
                DateTime dtTo = dtfrom.AddDays(-5);
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    if (Convert.ToDateTime(dtbl.Rows[i]["Date"].ToString()) == dtTo && (dtbl.Rows[i]["Symbol"].ToString() == strSymbol))
                    {
                        double decPrevClose = dtbl.Rows[i]["Close"].ToString().AsDouble();
                        double decResult = Math.Round(((decCurrClose - decPrevClose) / decPrevClose) * 100, 2);
                        dtbl.Rows[j]["ROC_5"] = decResult;
                        decCurrClose = 0;
                    }
                }

            }
            return dtbl;
        }
        private DataTable ROC14(DataTable dtbl)
        {
            for (int j = 0; j < dtbl.Rows.Count; j++)
            {
                double decCurrClose = 0;
                string strSymbol = dtbl.Rows[j]["Symbol"].ToString().ToUpper();
                DateTime dtfrom = Convert.ToDateTime(dtbl.Rows[j]["Date"].ToString());
                decCurrClose = dtbl.Rows[j]["Close"].ToString().AsDouble();
                DateTime dtTo = dtfrom.AddDays(-14);
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    if (Convert.ToDateTime(dtbl.Rows[i]["Date"].ToString()) == dtTo && (dtbl.Rows[i]["Symbol"].ToString() == strSymbol))
                    {
                        double decPrevClose = dtbl.Rows[i]["Close"].ToString().AsDouble();
                        double decResult = Math.Round(((decCurrClose - decPrevClose) / decPrevClose) * 100, 2);
                        dtbl.Rows[j]["ROC_14"] = decResult;
                        decCurrClose = 0;
                    }
                }

            }
            return dtbl;
        }

        private DataTable NATR2(DataTable dtbl)
        {
            for (int j = 0; j < dtbl.Rows.Count; j++)
            {
                double decCurrHigh = 0;
                double decCurrATR2 = 0;
                decCurrHigh = dtbl.Rows[j]["High"].ToString().AsDouble();
                decCurrATR2 = dtbl.Rows[j]["ATR_2"].ToString().AsDouble();
                double decResult = Math.Round((decCurrATR2 / decCurrHigh) * 100, 2);
                dtbl.Rows[j]["NATR_2"] = decResult;
            }
            return dtbl;
        }
        private DataTable NATR5(DataTable dtbl)
        {
            for (int j = 0; j < dtbl.Rows.Count; j++)
            {
                double decCurrHigh = 0;
                double decCurrATR5 = 0;
                decCurrHigh = dtbl.Rows[j]["High"].ToString().AsDouble();
                decCurrATR5 = dtbl.Rows[j]["ATR_5"].ToString().AsDouble();
                double decResult = Math.Round((decCurrATR5 / decCurrHigh) * 100, 2);
                dtbl.Rows[j]["NATR_5"] = decResult;
            }
            return dtbl;
        }
        private DataTable NATR14(DataTable dtbl)
        {
            for (int j = 0; j < dtbl.Rows.Count; j++)
            {
                double decCurrHigh = 0;
                double decCurrATR14 = 0;
                decCurrHigh = dtbl.Rows[j]["High"].ToString().AsDouble();
                decCurrATR14 = dtbl.Rows[j]["ATR_14"].ToString().AsDouble();
                double decResult = Math.Round((decCurrATR14 / decCurrHigh) * 100, 2);
                dtbl.Rows[j]["NATR_14"] = decResult;
            }
            return dtbl;
        }

        private DataTable PP_Ratio(DataTable dtbl)
        {
            for (int j = 0; j < dtbl.Rows.Count; j++)
            {
                double decCurrHigh = 0;
                string strSymbol = dtbl.Rows[j]["Symbol"].ToString().ToUpper();
                DateTime dtfrom = Convert.ToDateTime(dtbl.Rows[j]["Date"].ToString());
                decCurrHigh = dtbl.Rows[j]["High"].ToString().AsDouble();
                DateTime dtTo = dtfrom.AddDays(-1);
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    if (Convert.ToDateTime(dtbl.Rows[i]["Date"].ToString()) == dtTo && (dtbl.Rows[i]["Symbol"].ToString() == strSymbol))
                    {
                        double decPrevHigh = dtbl.Rows[i]["High"].ToString().AsDouble();
                        double decResult = Math.Round((decCurrHigh / decPrevHigh), 2);
                        dtbl.Rows[j]["PPRatio"] = decResult;
                        decCurrHigh = 0;
                    }
                }

            }
            return dtbl;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "txt files (*.xlsx)|*.xlsx|Excel files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        txtFilePath.Text = openFileDialog.FileName;
                        FillSheets();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Coin Predictor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFilePath.Text != string.Empty && CmbSheets.SelectedValue != null)
                {
                    FillCoinData();
                }
                else
                {
                    MessageBox.Show("Please Enter Excel File path including file Name..! Then Select Sheet Name", "IDPExcelImport", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataTable AddCoulmns(DataTable Dtbl)
        {
            Dtbl.Columns.Add("True_Range");
            Dtbl.Columns.Add("ATR_2");
            Dtbl.Columns.Add("ATR_5");
            Dtbl.Columns.Add("ATR_14");
            Dtbl.Columns.Add("ROC_2");
            Dtbl.Columns.Add("ROC_5");
            Dtbl.Columns.Add("ROC_14");
            Dtbl.Columns.Add("NATR_2");
            Dtbl.Columns.Add("NATR_5");
            Dtbl.Columns.Add("NATR_14");
            Dtbl.Columns.Add("PPRatio");
            return Dtbl;
        }
        public static double Average(double valueA, double valueB)
        {
            return (double)(valueA + valueB) / 2;
        }
        public static double Average(double valueA, double valueB, double valueC, double valueD, double valueE, double valueF)
        {
            return (double)(valueA + valueB + valueC + valueD + valueE + valueF) / 6;
        }

        private void BtnListGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFilePath.Text.ToString() != string.Empty)
                {
                    FillSheets();
                    if (chkRemember.Checked)
                    {
                        Properties.Settings.Default.FilePath = txtFilePath.Text;
                        Properties.Settings.Default.Save();
                    }
                }
                else
                {
                    MessageBox.Show("Browse and Select Excel File first", "Coin Predictor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                DgvData.DataSource = null;
                DgvData.Rows.Clear();
                MessageBox.Show("Data Cleared Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnExporttoExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvData.Rows.Count > 0)
                {
                    XLWorkbook wb = new XLWorkbook();
                    DataTable dt = (DataTable)DgvData.DataSource;
                    wb.Worksheets.Add(dt, "OP_" + CmbSheets.SelectedValue.ToString());
                    var saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel files|*.xlsx",
                        Title = "Save an Excel File"
                    };
                    saveFileDialog.FileName = CmbSheets.SelectedValue.ToString() + ".xlsx";
                    saveFileDialog.ShowDialog();
                    if (!String.IsNullOrWhiteSpace(saveFileDialog.FileName))
                    {
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("File Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("There is no data to export", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProcessData_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FilePath != string.Empty)
            {
                txtFilePath.Text = Properties.Settings.Default.FilePath;
            }
        }

        private void btnLoadtoDb_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvData.Rows.Count > 0)
                {
                    bool isFirst = true;
                    DataTable dt = (DataTable)DgvData.DataSource;
                    foreach (DataRow row in dt.Rows)
                    {
                        BackLogModel objModel = new BackLogModel();
                        objModel.Symbol = row["Symbol"].ToString();
                        objModel.Description = row["Description"].ToString();
                        objModel.LogDate = row["Date"].ToString().AsDateTime();
                        objModel.OpenVal = row["Open"].ToString().AsDouble();
                        objModel.HighVal = row["High"].ToString().AsDouble();
                        objModel.LowVal = row["Low"].ToString().AsDouble();
                        objModel.CloseVal = row["Close"].ToString().AsDouble();
                        objModel.TotalVolume = row["TotalVolume"].ToString().AsLong();
                        objModel.True_Range = row["True_Range"].ToString().AsDouble();
                        objModel.ATR_2 = row["ATR_2"].ToString().AsDouble();
                        objModel.ATR_5 = row["ATR_5"].ToString().AsDouble();
                        objModel.ATR_14 = row["ATR_14"].ToString().AsDouble();
                        objModel.ROC_2 = row["ROC_2"].ToString().AsDouble();
                        objModel.ROC_5 = row["ROC_5"].ToString().AsDouble();
                        objModel.ROC_14 = row["ROC_14"].ToString().AsDouble();
                        objModel.NATR_2 = row["NATR_2"].ToString().AsDouble();
                        objModel.NATR_5 = row["NATR_5"].ToString().AsDouble();
                        objModel.NATR_14 = row["NATR_14"].ToString().AsDouble();
                        objModel.PPRatio = row["PPRatio"].ToString().AsDouble();
                        BackLogDal objDal = new BackLogDal();
                        if (isFirst)
                        {
                            objDal.BackLogClearBySymbol(objModel);
                            isFirst = false;
                        }
                        objDal.BackLogInsert(objModel);
                    }
                    MessageBox.Show("Data Saved Successfully..", "Coin Predictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
