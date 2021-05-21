namespace CoinPredictor
{
    partial class frmMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCoinPredict = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoTradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBuyCoin = new System.Windows.Forms.ToolStripMenuItem();
            this.holdingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoTradeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profitorLossReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfomanceMatricsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mastersToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1456, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mastersToolStripMenuItem
            // 
            this.mastersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCoinPredict});
            this.mastersToolStripMenuItem.Name = "mastersToolStripMenuItem";
            this.mastersToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.mastersToolStripMenuItem.Text = "Masters";
            // 
            // mnuCoinPredict
            // 
            this.mnuCoinPredict.Name = "mnuCoinPredict";
            this.mnuCoinPredict.Size = new System.Drawing.Size(160, 26);
            this.mnuCoinPredict.Text = "CoinPredict";
            this.mnuCoinPredict.Visible = false;
            this.mnuCoinPredict.Click += new System.EventHandler(this.mnuCoinPredict_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoTradeToolStripMenuItem,
            this.mnuBuyCoin,
            this.holdingsToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.transactionToolStripMenuItem.Text = "Transactions";
            // 
            // autoTradeToolStripMenuItem
            // 
            this.autoTradeToolStripMenuItem.Name = "autoTradeToolStripMenuItem";
            this.autoTradeToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.autoTradeToolStripMenuItem.Text = "Auto Trade";
            this.autoTradeToolStripMenuItem.Click += new System.EventHandler(this.autoTradeToolStripMenuItem_Click);
            // 
            // mnuBuyCoin
            // 
            this.mnuBuyCoin.Name = "mnuBuyCoin";
            this.mnuBuyCoin.Size = new System.Drawing.Size(176, 26);
            this.mnuBuyCoin.Text = "Purchase Coin";
            this.mnuBuyCoin.Visible = false;
            this.mnuBuyCoin.Click += new System.EventHandler(this.mnuBuyCoin_Click);
            // 
            // holdingsToolStripMenuItem
            // 
            this.holdingsToolStripMenuItem.Name = "holdingsToolStripMenuItem";
            this.holdingsToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.holdingsToolStripMenuItem.Text = "Holdings";
            this.holdingsToolStripMenuItem.Visible = false;
            this.holdingsToolStripMenuItem.Click += new System.EventHandler(this.holdingsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoTradeReportToolStripMenuItem,
            this.profitorLossReportToolStripMenuItem,
            this.perfomanceMatricsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // autoTradeReportToolStripMenuItem
            // 
            this.autoTradeReportToolStripMenuItem.Name = "autoTradeReportToolStripMenuItem";
            this.autoTradeReportToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.autoTradeReportToolStripMenuItem.Text = "AutoTrade Report";
            this.autoTradeReportToolStripMenuItem.Click += new System.EventHandler(this.autoTradeReportToolStripMenuItem_Click);
            // 
            // profitorLossReportToolStripMenuItem
            // 
            this.profitorLossReportToolStripMenuItem.Name = "profitorLossReportToolStripMenuItem";
            this.profitorLossReportToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.profitorLossReportToolStripMenuItem.Text = "ProfitorLossReport";
            this.profitorLossReportToolStripMenuItem.Visible = false;
            this.profitorLossReportToolStripMenuItem.Click += new System.EventHandler(this.profitorLossReportToolStripMenuItem_Click);
            // 
            // perfomanceMatricsToolStripMenuItem
            // 
            this.perfomanceMatricsToolStripMenuItem.Name = "perfomanceMatricsToolStripMenuItem";
            this.perfomanceMatricsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.perfomanceMatricsToolStripMenuItem.Text = "Perfomance Metrics";
            this.perfomanceMatricsToolStripMenuItem.Visible = false;
            this.perfomanceMatricsToolStripMenuItem.Click += new System.EventHandler(this.perfomanceMatricsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // appSettingsToolStripMenuItem
            // 
            this.appSettingsToolStripMenuItem.Name = "appSettingsToolStripMenuItem";
            this.appSettingsToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.appSettingsToolStripMenuItem.Text = "App Settings";
            this.appSettingsToolStripMenuItem.Click += new System.EventHandler(this.appSettingsToolStripMenuItem_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 617);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.Text = "Coin Predictor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCoinPredict;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBuyCoin;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profitorLossReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem holdingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfomanceMatricsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoTradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoTradeReportToolStripMenuItem;
    }
}

