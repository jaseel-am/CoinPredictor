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
    public partial class frmAutoTradeReport : Form
    {
        public frmAutoTradeReport()
        {
            InitializeComponent();
        }

        private void frmAutoTradeReport_Load(object sender, EventArgs e)
        {
            AutoTradeDal objDal = new AutoTradeDal();
            DgvData.DataSource = objDal.GetAutoTradeReport();
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
    }
}
