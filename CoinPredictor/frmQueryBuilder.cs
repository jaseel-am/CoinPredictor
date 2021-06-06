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
    public partial class frmQueryBuilder : Form
    {
        public frmQueryBuilder()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQuery.Text!=string.Empty)
                {
                    if (Messages.UpdateMessageCustom("Are you Sure You want to run this Query..?"))
                    {
                        CommonDal objDal = new CommonDal();
                        objDal.ExecuteQuery(txtQuery.Text.Trim());
                    }
                }
                else
                {
                    MessageBox.Show("Query field should not be empty", "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuery.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trade: btnSave_Click" + ex.Message, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
