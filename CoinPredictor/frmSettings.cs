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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnClearTransactions_Click(object sender, EventArgs e)
        {
            try
            {
                CommonDal objDal = new CommonDal();
                objDal.ClearAllTransactions("Manual");
                MessageBox.Show("All Data Cleared Successfully..!", "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trade: 2" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearAutoTrade_Click(object sender, EventArgs e)
        {
            try
            {
                CommonDal objDal = new CommonDal();
                objDal.ClearAllTransactions("Auto");
                MessageBox.Show("All Data Cleared Successfully..!", "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trade: 2" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
