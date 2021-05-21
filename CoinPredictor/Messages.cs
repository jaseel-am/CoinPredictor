using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoinPredictor
{
    static class Messages
    {
        /// <summary>
        /// Function to display information message
        /// </summary>
        /// <param name="strMsg"></param>
        public static void InformationMessage(string strMsg)
        {
            MessageBox.Show(strMsg, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Function for warning message
        /// </summary>
        /// <param name="strMsg"></param>
        public static void WarningMessage(string strMsg)
        {
            MessageBox.Show(strMsg, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// Function for error message
        /// </summary>
        /// <param name="strMsg"></param>
        public static void ErrorMessage(string strMsg)
        {
            MessageBox.Show(strMsg, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Function for saved message
        /// </summary>
        public static void SavedMessage()
        {
            MessageBox.Show("Saved successfully", "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Function for updated message
        /// </summary>
        public static void UpdatedMessage()
        {
            MessageBox.Show("Updated successfully ", "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Function for deleted message
        /// </summary>
        public static void DeletedMessage()
        {
            MessageBox.Show("Deleted successfully ", "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Function for exception
        /// </summary>
        /// <param name="strMsg"></param>
        public static void ExceptionMessage(string strMsg)
        {
            MessageBox.Show(strMsg, "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Function for reference exist message
        /// </summary>
        public static void ReferenceExistsMessage()
        {
            MessageBox.Show("You can't delete,reference exist", "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// Function for reference exist message for update
        /// </summary>
        public static void ReferenceExistsMessageForUpdate()
        {
            MessageBox.Show("You can't update,reference exist", "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// Function for no privillage message
        /// </summary>
        public static void NoPrivillageMessage()
        {
            MessageBox.Show("You dont have the privilege", "CoinPredictor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Function for delete confirmation message
        /// </summary>
        /// <returns></returns>
        public static bool DeleteMessage()
        {
            bool isOk = true;
            if (MessageBox.Show("Are you sure to delete ? ", "CoinPredictor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                isOk = false;
            }
            return isOk;
        }
        /// <summary>
        /// Function for save confirmation message
        /// </summary>
        /// <returns></returns>
        public static bool SaveMessage()
        {
            bool isOk = true;
            if (MessageBox.Show("Do you want to save ? ", "CoinPredictor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                isOk = false;
            }
            return isOk;
        }
        /// <summary>
        /// Function for update confirmation message
        /// </summary>
        /// <returns></returns>
        public static bool UpdateMessage()
        {
            bool isOk = true;
            if (MessageBox.Show("Do you want to update ? ", "CoinPredictor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                isOk = false;
            }
            return isOk;
        }
        /// <summary>
        /// Function for custome update message
        /// </summary>
        /// <param name="strMsg"></param>
        /// <returns></returns>
        public static bool UpdateMessageCustom(string strMsg)
        {
            bool isOk = false;
            if ((MessageBox.Show(strMsg, "CoinPredictor", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                isOk = true;
            }
            return isOk;
        }
        /// <summary>
        /// Function for close message
        /// </summary>
        /// <param name="frm"></param>
        public static void CloseMessage(System.Windows.Forms.Form frm)
        {
            if ((MessageBox.Show("Are you sure to exit ? ", "CoinPredictor", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                frm.Close();
            }
        }
        /// <summary>
        /// Function for save confirmation message
        /// </summary>
        /// <returns></returns>
        public static bool SaveConfirmation()
        {
            bool isOk = true;
            if (PublicVariables.isMessageAdd)
            {
                if (MessageBox.Show("Do you want to save ? ", "CoinPredictor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    isOk = false;
                }
            }
            return isOk;
        }
        /// <summary>
        /// Function for update confirmation
        /// </summary>
        /// <returns></returns>
        public static bool UpdateConfirmation()
        {
            bool isOk = true;
            if (PublicVariables.isMessageEdit)
            {
                if (MessageBox.Show("Do you want to update ? ", "CoinPredictor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    isOk = false;
                }
            }
            return isOk;
        }
        /// <summary>
        /// Function for delete confirmation message
        /// </summary>
        /// <returns></returns>
        public static bool DeleteConfirmation()
        {
            bool isOk = true;
            if (PublicVariables.isMessageDelete)
            {
                if (MessageBox.Show("Are you sure to delete ? ", "CoinPredictor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    isOk = false;
                }
            }
            return isOk;
        }
        /// <summary>
        /// Function for close confirmation
        /// </summary>
        /// <returns></returns>
        public static bool CloseConfirmation()
        {
            bool isOk = true;
            if (PublicVariables.isMessageClose)
            {
                if ((MessageBox.Show("Are you sure to exit ? ", "CoinPredictor", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.No)
                {
                    isOk = false;
                }
            }
            return isOk;
        }
    }
}