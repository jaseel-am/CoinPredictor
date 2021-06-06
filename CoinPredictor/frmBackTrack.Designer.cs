namespace CoinPredictor
{
    partial class frmBackTrack
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackTrack));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chbxLstInstrument = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtGainPercent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFinalAccountBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProfitFactor = new System.Windows.Forms.TextBox();
            this.txtProfitableTrade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalTrade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.BtnAutomate = new System.Windows.Forms.Button();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpeningBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.SymbolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProfitTarget = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(233)))));
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.chbxLstInstrument);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.btnClear);
            this.splitContainer1.Panel1.Controls.Add(this.BtnAutomate);
            this.splitContainer1.Panel1.Controls.Add(this.txtProfitTarget);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.txtDuration);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.dtpEndDate);
            this.splitContainer1.Panel1.Controls.Add(this.txtEndDate);
            this.splitContainer1.Panel1.Controls.Add(this.dtpStartDate);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txtStartDate);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtOpeningBalance);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgvData);
            this.splitContainer1.Size = new System.Drawing.Size(1749, 752);
            this.splitContainer1.SplitterDistance = 499;
            this.splitContainer1.TabIndex = 0;
            // 
            // chbxLstInstrument
            // 
            this.chbxLstInstrument.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxLstInstrument.FormattingEnabled = true;
            this.chbxLstInstrument.Location = new System.Drawing.Point(141, 178);
            this.chbxLstInstrument.Name = "chbxLstInstrument";
            this.chbxLstInstrument.Size = new System.Drawing.Size(252, 256);
            this.chbxLstInstrument.TabIndex = 814;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.txtGainPercent);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtFinalAccountBalance);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtProfitFactor);
            this.panel2.Controls.Add(this.txtProfitableTrade);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtTotalTrade);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(3, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 217);
            this.panel2.TabIndex = 813;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(181)))), ((int)(((byte)(5)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(178, 169);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 28);
            this.btnRefresh.TabIndex = 812;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtGainPercent
            // 
            this.txtGainPercent.BackColor = System.Drawing.Color.DarkGray;
            this.txtGainPercent.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGainPercent.Location = new System.Drawing.Point(178, 135);
            this.txtGainPercent.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtGainPercent.Name = "txtGainPercent";
            this.txtGainPercent.ReadOnly = true;
            this.txtGainPercent.Size = new System.Drawing.Size(156, 25);
            this.txtGainPercent.TabIndex = 806;
            this.txtGainPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(121)))), ((int)(((byte)(191)))));
            this.label8.Location = new System.Drawing.Point(4, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 802;
            this.label8.Text = "Total Trades:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(121)))), ((int)(((byte)(191)))));
            this.label9.Location = new System.Drawing.Point(4, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 16);
            this.label9.TabIndex = 803;
            this.label9.Text = "Profitable Trades:";
            // 
            // txtFinalAccountBalance
            // 
            this.txtFinalAccountBalance.BackColor = System.Drawing.Color.DarkGray;
            this.txtFinalAccountBalance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalAccountBalance.Location = new System.Drawing.Point(178, 42);
            this.txtFinalAccountBalance.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtFinalAccountBalance.Name = "txtFinalAccountBalance";
            this.txtFinalAccountBalance.ReadOnly = true;
            this.txtFinalAccountBalance.Size = new System.Drawing.Size(156, 25);
            this.txtFinalAccountBalance.TabIndex = 805;
            this.txtFinalAccountBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(121)))), ((int)(((byte)(191)))));
            this.label7.Location = new System.Drawing.Point(4, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 16);
            this.label7.TabIndex = 801;
            this.label7.Text = "Final Account Balance:";
            // 
            // txtProfitFactor
            // 
            this.txtProfitFactor.BackColor = System.Drawing.Color.DarkGray;
            this.txtProfitFactor.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfitFactor.Location = new System.Drawing.Point(178, 73);
            this.txtProfitFactor.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtProfitFactor.Name = "txtProfitFactor";
            this.txtProfitFactor.ReadOnly = true;
            this.txtProfitFactor.Size = new System.Drawing.Size(156, 25);
            this.txtProfitFactor.TabIndex = 809;
            this.txtProfitFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtProfitableTrade
            // 
            this.txtProfitableTrade.BackColor = System.Drawing.Color.DarkGray;
            this.txtProfitableTrade.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfitableTrade.Location = new System.Drawing.Point(178, 11);
            this.txtProfitableTrade.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtProfitableTrade.Name = "txtProfitableTrade";
            this.txtProfitableTrade.ReadOnly = true;
            this.txtProfitableTrade.Size = new System.Drawing.Size(156, 25);
            this.txtProfitableTrade.TabIndex = 808;
            this.txtProfitableTrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(121)))), ((int)(((byte)(191)))));
            this.label5.Location = new System.Drawing.Point(4, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 800;
            this.label5.Text = "GainPercent:";
            // 
            // txtTotalTrade
            // 
            this.txtTotalTrade.BackColor = System.Drawing.Color.DarkGray;
            this.txtTotalTrade.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTrade.Location = new System.Drawing.Point(178, 104);
            this.txtTotalTrade.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtTotalTrade.Name = "txtTotalTrade";
            this.txtTotalTrade.ReadOnly = true;
            this.txtTotalTrade.Size = new System.Drawing.Size(156, 25);
            this.txtTotalTrade.TabIndex = 807;
            this.txtTotalTrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(121)))), ((int)(((byte)(191)))));
            this.label10.Location = new System.Drawing.Point(4, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 16);
            this.label10.TabIndex = 804;
            this.label10.Text = "Profit Factor:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(121)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(2, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 47);
            this.panel1.TabIndex = 812;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell Nova Cond", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(115, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 25);
            this.label11.TabIndex = 803;
            this.label11.Text = "Perfomance Matrix";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(181)))), ((int)(((byte)(5)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(234, 440);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 28);
            this.btnClear.TabIndex = 795;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // BtnAutomate
            // 
            this.BtnAutomate.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnAutomate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAutomate.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAutomate.ForeColor = System.Drawing.Color.White;
            this.BtnAutomate.Location = new System.Drawing.Point(141, 440);
            this.BtnAutomate.Name = "BtnAutomate";
            this.BtnAutomate.Size = new System.Drawing.Size(87, 28);
            this.BtnAutomate.TabIndex = 793;
            this.BtnAutomate.Text = "Run";
            this.BtnAutomate.UseVisualStyleBackColor = false;
            this.BtnAutomate.Click += new System.EventHandler(this.BtnAutomate_Click);
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.Color.White;
            this.txtDuration.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(141, 111);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(196, 25);
            this.txtDuration.TabIndex = 792;
            this.txtDuration.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(4)))), ((int)(((byte)(122)))));
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 791;
            this.label4.Text = "Duration:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(368, 76);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(25, 25);
            this.dtpEndDate.TabIndex = 790;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // txtEndDate
            // 
            this.txtEndDate.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(141, 76);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(229, 25);
            this.txtEndDate.TabIndex = 789;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(368, 42);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(25, 25);
            this.dtpStartDate.TabIndex = 788;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(4)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 785;
            this.label2.Text = "Start Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(4)))), ((int)(((byte)(122)))));
            this.label6.Location = new System.Drawing.Point(12, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 786;
            this.label6.Text = "End Date:";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(141, 42);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(229, 25);
            this.txtStartDate.TabIndex = 787;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(4)))), ((int)(((byte)(122)))));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 783;
            this.label3.Text = "Current Balance:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtOpeningBalance
            // 
            this.txtOpeningBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtOpeningBalance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpeningBalance.Location = new System.Drawing.Point(141, 9);
            this.txtOpeningBalance.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtOpeningBalance.Name = "txtOpeningBalance";
            this.txtOpeningBalance.ReadOnly = true;
            this.txtOpeningBalance.Size = new System.Drawing.Size(252, 25);
            this.txtOpeningBalance.TabIndex = 784;
            this.txtOpeningBalance.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(4)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(12, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 774;
            this.label1.Text = "Instrument:";
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
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
            this.ExitOn,
            this.SymbolId});
            this.DgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvData.Location = new System.Drawing.Point(0, 0);
            this.DgvData.Name = "DgvData";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvData.RowHeadersVisible = false;
            this.DgvData.RowTemplate.Height = 24;
            this.DgvData.Size = new System.Drawing.Size(1246, 752);
            this.DgvData.TabIndex = 1;
            this.DgvData.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvData_DataBindingComplete);
            // 
            // Symbol
            // 
            this.Symbol.DataPropertyName = "Symbol";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Symbol.DefaultCellStyle = dataGridViewCellStyle2;
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.Name = "Symbol";
            this.Symbol.Width = 80;
            // 
            // EntryDate
            // 
            this.EntryDate.DataPropertyName = "EntryDate";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.EntryDate.HeaderText = "EntryDate";
            this.EntryDate.Name = "EntryDate";
            this.EntryDate.Width = 75;
            // 
            // EntryPrice
            // 
            this.EntryPrice.DataPropertyName = "EntryPrice";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.EntryPrice.HeaderText = "EntryPrice";
            this.EntryPrice.Name = "EntryPrice";
            this.EntryPrice.Width = 65;
            // 
            // ExitDate
            // 
            this.ExitDate.DataPropertyName = "ExitDate";
            this.ExitDate.HeaderText = "ExitDate";
            this.ExitDate.Name = "ExitDate";
            this.ExitDate.Width = 75;
            // 
            // ExitPrice
            // 
            this.ExitPrice.DataPropertyName = "ExitPrice";
            this.ExitPrice.HeaderText = "ExitPrice";
            this.ExitPrice.Name = "ExitPrice";
            this.ExitPrice.Width = 60;
            // 
            // Share
            // 
            this.Share.DataPropertyName = "Share";
            this.Share.HeaderText = "Qty";
            this.Share.Name = "Share";
            this.Share.Width = 60;
            // 
            // Profit
            // 
            this.Profit.DataPropertyName = "Profit";
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            // 
            // AccountBalance
            // 
            this.AccountBalance.DataPropertyName = "AccountBalance";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountBalance.DefaultCellStyle = dataGridViewCellStyle5;
            this.AccountBalance.HeaderText = "Closing Bal.";
            this.AccountBalance.Name = "AccountBalance";
            this.AccountBalance.Width = 110;
            // 
            // ExitOn
            // 
            this.ExitOn.DataPropertyName = "ExitOn";
            this.ExitOn.HeaderText = "ExitOn";
            this.ExitOn.Name = "ExitOn";
            this.ExitOn.Width = 85;
            // 
            // SymbolId
            // 
            this.SymbolId.DataPropertyName = "SymbolId";
            this.SymbolId.HeaderText = "SymbolId";
            this.SymbolId.Name = "SymbolId";
            this.SymbolId.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(4)))), ((int)(((byte)(122)))));
            this.label12.Location = new System.Drawing.Point(12, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 17);
            this.label12.TabIndex = 791;
            this.label12.Text = "Profit Target:";
            // 
            // txtProfitTarget
            // 
            this.txtProfitTarget.BackColor = System.Drawing.Color.White;
            this.txtProfitTarget.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfitTarget.Location = new System.Drawing.Point(141, 142);
            this.txtProfitTarget.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtProfitTarget.Name = "txtProfitTarget";
            this.txtProfitTarget.Size = new System.Drawing.Size(196, 25);
            this.txtProfitTarget.TabIndex = 792;
            this.txtProfitTarget.Text = "10";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(337, 142);
            this.textBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(56, 25);
            this.textBox1.TabIndex = 815;
            this.textBox1.Text = "%";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(337, 111);
            this.textBox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(56, 25);
            this.textBox2.TabIndex = 816;
            this.textBox2.Text = "Days";
            // 
            // frmBackTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1749, 752);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBackTrack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Back Track";
            this.Load += new System.EventHandler(this.frmBackTrack_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpeningBalance;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button BtnAutomate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtGainPercent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFinalAccountBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProfitFactor;
        private System.Windows.Forms.TextBox txtProfitableTrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalTrade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox chbxLstInstrument;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Share;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SymbolId;
        private System.Windows.Forms.TextBox txtProfitTarget;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}