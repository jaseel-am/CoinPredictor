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
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void mnuCoinPredict_Click(object sender, EventArgs e)
        {
            try
            {
                frmProcessData frm = new frmProcessData();
                frmProcessData open = Application.OpenForms["frmProcessData"] as frmProcessData;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 1: " + ex.Message, "Coin Predictor Data Loader", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mnuBuyCoin_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuyCoin frm = new frmBuyCoin();
                frmBuyCoin open = Application.OpenForms["frmBackTrack"] as frmBuyCoin;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 2: " + ex.Message, "Coin Predictor Data Loader", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void appSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSettings frm = new frmSettings();
                frmSettings open = Application.OpenForms["frmSettings"] as frmSettings;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 2: " + ex.Message, "Coin Predictor Data Loader", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void profitorLossReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmProfitReport frm = new frmProfitReport();
                frmProfitReport open = Application.OpenForms["frmProfitReport"] as frmProfitReport;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 2: " + ex.Message, "Coin Predictor Data Loader", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void holdingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSales frm = new frmSales();
                frmSales open = Application.OpenForms["frmHoldings"] as frmSales;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 2: " + ex.Message, "Coin Predictor Data Loader", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void perfomanceMatricsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPerfoMatrix frm = new frmPerfoMatrix();
                frmPerfoMatrix open = Application.OpenForms["frmPerfoMatrix"] as frmPerfoMatrix;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 2: " + ex.Message, "Coin Predictor Data Loader", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void autoTradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBackTrack frm = new frmBackTrack();
                frmBackTrack open = Application.OpenForms["frmBackTrack"] as frmBackTrack;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 2: " + ex.Message, "Coin Predictor Data Loader", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void autoTradeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAutoTradeReport frm = new frmAutoTradeReport();
                frmAutoTradeReport open = Application.OpenForms["frmAutoTradeReport"] as frmAutoTradeReport;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 2: " + ex.Message, "Coin Predictor Data Loader", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void autoTradePerfomanceMatricsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    frmAutoTradePerfoMatrixReport frm = new frmAutoTradePerfoMatrixReport();
            //    frmAutoTradePerfoMatrixReport open = Application.OpenForms["frmAutoTradePerfoMatrixReport"] as frmAutoTradePerfoMatrixReport;
            //    if (open == null)
            //    {
            //        frm.MdiParent = this;
            //        frm.Show();
            //    }
            //    else
            //    {
            //        open.Activate();
            //        if (open.WindowState == FormWindowState.Minimized)
            //        {
            //            open.WindowState = FormWindowState.Normal;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("MDI 2: " + ex.Message, "Coin Predictor Data Loader", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void queryRunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmQueryBuilder frm = new frmQueryBuilder();
                frmQueryBuilder open = Application.OpenForms["frmQueryBuilder"] as frmQueryBuilder;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 2: " + ex.Message, "Coin Predictor Data Loader", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAutoTrade frm = new frmAutoTrade();
                frmAutoTrade open = Application.OpenForms["frmAutoTrade"] as frmAutoTrade;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 2: " + ex.Message, "Coin Predictor Data Loader", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
