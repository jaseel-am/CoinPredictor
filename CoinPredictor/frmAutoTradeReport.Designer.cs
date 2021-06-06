namespace CoinPredictor
{
    partial class frmAutoTradeReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Share = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Symbol,
            this.EntryDate,
            this.EntryPrice,
            this.ExitDate,
            this.ExitPrice,
            this.Share,
            this.Profit,
            this.AccountBalance,
            this.ExitOn});
            this.DgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvData.Location = new System.Drawing.Point(0, 0);
            this.DgvData.Name = "DgvData";
            this.DgvData.RowHeadersVisible = false;
            this.DgvData.RowTemplate.Height = 24;
            this.DgvData.Size = new System.Drawing.Size(1519, 751);
            this.DgvData.TabIndex = 1;
            this.DgvData.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvData_DataBindingComplete);
            // 
            // Symbol
            // 
            this.Symbol.DataPropertyName = "Symbol";
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.Name = "Symbol";
            // 
            // EntryDate
            // 
            this.EntryDate.DataPropertyName = "EntryDate";
            this.EntryDate.HeaderText = "EntryDate";
            this.EntryDate.Name = "EntryDate";
            this.EntryDate.Width = 120;
            // 
            // EntryPrice
            // 
            this.EntryPrice.DataPropertyName = "EntryPrice";
            this.EntryPrice.HeaderText = "EntryPrice";
            this.EntryPrice.Name = "EntryPrice";
            // 
            // ExitDate
            // 
            this.ExitDate.DataPropertyName = "ExitDate";
            this.ExitDate.HeaderText = "ExitDate";
            this.ExitDate.Name = "ExitDate";
            this.ExitDate.Width = 120;
            // 
            // ExitPrice
            // 
            this.ExitPrice.DataPropertyName = "ExitPrice";
            this.ExitPrice.HeaderText = "ExitPrice";
            this.ExitPrice.Name = "ExitPrice";
            // 
            // Share
            // 
            this.Share.DataPropertyName = "Share";
            this.Share.HeaderText = "Qty";
            this.Share.Name = "Share";
            this.Share.Width = 120;
            // 
            // Profit
            // 
            this.Profit.DataPropertyName = "Profit";
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            this.Profit.Width = 120;
            // 
            // AccountBalance
            // 
            this.AccountBalance.DataPropertyName = "AccountBalance";
            this.AccountBalance.HeaderText = "Account Balance";
            this.AccountBalance.Name = "AccountBalance";
            this.AccountBalance.Width = 150;
            // 
            // ExitOn
            // 
            this.ExitOn.DataPropertyName = "ExitOn";
            this.ExitOn.HeaderText = "ExitOn";
            this.ExitOn.Name = "ExitOn";
            this.ExitOn.Width = 130;
            // 
            // frmAutoTradeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 751);
            this.Controls.Add(this.DgvData);
            this.Name = "frmAutoTradeReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Trade Report";
            this.Load += new System.EventHandler(this.frmAutoTradeReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Share;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitOn;
    }
}