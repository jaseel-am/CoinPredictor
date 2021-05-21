namespace CoinPredictor
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClearTransactions = new System.Windows.Forms.Button();
            this.btnClearAutoTrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClearTransactions
            // 
            this.btnClearTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(29)))));
            this.btnClearTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTransactions.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTransactions.ForeColor = System.Drawing.Color.White;
            this.btnClearTransactions.Location = new System.Drawing.Point(221, 41);
            this.btnClearTransactions.Name = "btnClearTransactions";
            this.btnClearTransactions.Size = new System.Drawing.Size(309, 29);
            this.btnClearTransactions.TabIndex = 774;
            this.btnClearTransactions.Text = "Clear All Transactions";
            this.btnClearTransactions.UseVisualStyleBackColor = false;
            this.btnClearTransactions.Click += new System.EventHandler(this.btnClearTransactions_Click);
            // 
            // btnClearAutoTrade
            // 
            this.btnClearAutoTrade.BackColor = System.Drawing.Color.Blue;
            this.btnClearAutoTrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAutoTrade.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAutoTrade.ForeColor = System.Drawing.Color.White;
            this.btnClearAutoTrade.Location = new System.Drawing.Point(221, 85);
            this.btnClearAutoTrade.Name = "btnClearAutoTrade";
            this.btnClearAutoTrade.Size = new System.Drawing.Size(309, 29);
            this.btnClearAutoTrade.TabIndex = 774;
            this.btnClearAutoTrade.Text = "Clear All Auto Trade";
            this.btnClearAutoTrade.UseVisualStyleBackColor = false;
            this.btnClearAutoTrade.Click += new System.EventHandler(this.btnClearAutoTrade_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearAutoTrade);
            this.Controls.Add(this.btnClearTransactions);
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSettings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClearTransactions;
        private System.Windows.Forms.Button btnClearAutoTrade;
    }
}