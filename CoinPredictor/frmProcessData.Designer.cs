namespace CoinPredictor
{
    partial class frmProcessData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcessData));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Open = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.High = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Low = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Close = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.True_Range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATR_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATR_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATR_14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROC_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROC_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROC_14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NATR_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NATR_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NATR_14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbSheets = new System.Windows.Forms.ComboBox();
            this.BtnListGenerate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExporttoExcel = new System.Windows.Forms.Button();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoadtoDb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(694, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(93, 32);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse File";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.Color.Green;
            this.btnLoadData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadData.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoadData.ForeColor = System.Drawing.Color.White;
            this.btnLoadData.Location = new System.Drawing.Point(1281, 3);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(113, 32);
            this.btnLoadData.TabIndex = 10;
            this.btnLoadData.Text = "Process Data";
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilePath.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtFilePath.Location = new System.Drawing.Point(3, 3);
            this.txtFilePath.Multiline = true;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(685, 32);
            this.txtFilePath.TabIndex = 9;
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Symbol,
            this.Description,
            this.Date,
            this.Open,
            this.High,
            this.Low,
            this.Close,
            this.TotalVolume,
            this.True_Range,
            this.ATR_2,
            this.ATR_5,
            this.ATR_14,
            this.ROC_2,
            this.ROC_5,
            this.ROC_14,
            this.NATR_2,
            this.NATR_5,
            this.NATR_14,
            this.PPRatio});
            this.DgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvData.Location = new System.Drawing.Point(0, 0);
            this.DgvData.Name = "DgvData";
            this.DgvData.RowHeadersVisible = false;
            this.DgvData.RowTemplate.Height = 26;
            this.DgvData.Size = new System.Drawing.Size(1769, 733);
            this.DgvData.TabIndex = 8;
            // 
            // Symbol
            // 
            this.Symbol.DataPropertyName = "Symbol";
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.Name = "Symbol";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Desc";
            this.Description.Name = "Description";
            this.Description.Width = 50;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 70;
            // 
            // Open
            // 
            this.Open.DataPropertyName = "Open";
            this.Open.HeaderText = "Open";
            this.Open.Name = "Open";
            // 
            // High
            // 
            this.High.DataPropertyName = "High";
            this.High.HeaderText = "High";
            this.High.Name = "High";
            // 
            // Low
            // 
            this.Low.DataPropertyName = "Low";
            this.Low.HeaderText = "Low";
            this.Low.Name = "Low";
            // 
            // Close
            // 
            this.Close.DataPropertyName = "Close";
            this.Close.HeaderText = "Close";
            this.Close.Name = "Close";
            // 
            // TotalVolume
            // 
            this.TotalVolume.DataPropertyName = "TotalVolume";
            this.TotalVolume.HeaderText = "TotalVolume";
            this.TotalVolume.Name = "TotalVolume";
            // 
            // True_Range
            // 
            this.True_Range.DataPropertyName = "True_Range";
            this.True_Range.HeaderText = "True_Range";
            this.True_Range.Name = "True_Range";
            // 
            // ATR_2
            // 
            this.ATR_2.DataPropertyName = "ATR_2";
            this.ATR_2.HeaderText = "ATR_2";
            this.ATR_2.Name = "ATR_2";
            this.ATR_2.Width = 65;
            // 
            // ATR_5
            // 
            this.ATR_5.DataPropertyName = "ATR_5";
            this.ATR_5.HeaderText = "ATR_5";
            this.ATR_5.Name = "ATR_5";
            this.ATR_5.Width = 65;
            // 
            // ATR_14
            // 
            this.ATR_14.DataPropertyName = "ATR_14";
            this.ATR_14.HeaderText = "ATR_14";
            this.ATR_14.Name = "ATR_14";
            this.ATR_14.Width = 65;
            // 
            // ROC_2
            // 
            this.ROC_2.DataPropertyName = "ROC_2";
            this.ROC_2.HeaderText = "ROC_2";
            this.ROC_2.Name = "ROC_2";
            this.ROC_2.Width = 65;
            // 
            // ROC_5
            // 
            this.ROC_5.DataPropertyName = "ROC_5";
            this.ROC_5.HeaderText = "ROC_5";
            this.ROC_5.Name = "ROC_5";
            this.ROC_5.Width = 60;
            // 
            // ROC_14
            // 
            this.ROC_14.DataPropertyName = "ROC_14";
            this.ROC_14.HeaderText = "ROC_14";
            this.ROC_14.Name = "ROC_14";
            this.ROC_14.Width = 65;
            // 
            // NATR_2
            // 
            this.NATR_2.DataPropertyName = "NATR_2";
            this.NATR_2.HeaderText = "NATR_2";
            this.NATR_2.Name = "NATR_2";
            this.NATR_2.Width = 65;
            // 
            // NATR_5
            // 
            this.NATR_5.DataPropertyName = "NATR_5";
            this.NATR_5.HeaderText = "NATR_5";
            this.NATR_5.Name = "NATR_5";
            this.NATR_5.Width = 65;
            // 
            // NATR_14
            // 
            this.NATR_14.DataPropertyName = "NATR_14";
            this.NATR_14.HeaderText = "NATR_14";
            this.NATR_14.Name = "NATR_14";
            this.NATR_14.Width = 65;
            // 
            // PPRatio
            // 
            this.PPRatio.DataPropertyName = "PPRatio";
            this.PPRatio.HeaderText = "PPRatio";
            this.PPRatio.Name = "PPRatio";
            this.PPRatio.Width = 70;
            // 
            // CmbSheets
            // 
            this.CmbSheets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbSheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSheets.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSheets.FormattingEnabled = true;
            this.CmbSheets.Location = new System.Drawing.Point(1035, 3);
            this.CmbSheets.Name = "CmbSheets";
            this.CmbSheets.Size = new System.Drawing.Size(240, 29);
            this.CmbSheets.TabIndex = 12;
            // 
            // BtnListGenerate
            // 
            this.BtnListGenerate.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnListGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnListGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListGenerate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.BtnListGenerate.ForeColor = System.Drawing.Color.White;
            this.BtnListGenerate.Location = new System.Drawing.Point(901, 3);
            this.BtnListGenerate.Name = "BtnListGenerate";
            this.BtnListGenerate.Size = new System.Drawing.Size(128, 32);
            this.BtnListGenerate.TabIndex = 11;
            this.BtnListGenerate.Text = "Generate Lists";
            this.BtnListGenerate.UseVisualStyleBackColor = false;
            this.BtnListGenerate.Click += new System.EventHandler(this.BtnListGenerate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1400, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 32);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear Table";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExporttoExcel
            // 
            this.btnExporttoExcel.BackColor = System.Drawing.Color.Olive;
            this.btnExporttoExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExporttoExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExporttoExcel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnExporttoExcel.ForeColor = System.Drawing.Color.White;
            this.btnExporttoExcel.Location = new System.Drawing.Point(1509, 3);
            this.btnExporttoExcel.Name = "btnExporttoExcel";
            this.btnExporttoExcel.Size = new System.Drawing.Size(127, 32);
            this.btnExporttoExcel.TabIndex = 10;
            this.btnExporttoExcel.Text = "Export to Excel";
            this.btnExporttoExcel.UseVisualStyleBackColor = false;
            this.btnExporttoExcel.Click += new System.EventHandler(this.btnExporttoExcel_Click);
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.ForeColor = System.Drawing.Color.White;
            this.chkRemember.Location = new System.Drawing.Point(793, 3);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(102, 21);
            this.chkRemember.TabIndex = 13;
            this.chkRemember.Text = "Remember Path";
            this.chkRemember.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgvData);
            this.splitContainer1.Size = new System.Drawing.Size(1769, 775);
            this.splitContainer1.SplitterDistance = 38;
            this.splitContainer1.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Teal;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.40554F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.59446F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.Controls.Add(this.btnLoadtoDb, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFilePath, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowse, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExporttoExcel, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.CmbSheets, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkRemember, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadData, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnListGenerate, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1769, 38);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // btnLoadtoDb
            // 
            this.btnLoadtoDb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLoadtoDb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadtoDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadtoDb.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoadtoDb.ForeColor = System.Drawing.Color.White;
            this.btnLoadtoDb.Location = new System.Drawing.Point(1642, 3);
            this.btnLoadtoDb.Name = "btnLoadtoDb";
            this.btnLoadtoDb.Size = new System.Drawing.Size(124, 32);
            this.btnLoadtoDb.TabIndex = 14;
            this.btnLoadtoDb.Text = "Save to DB";
            this.btnLoadtoDb.UseVisualStyleBackColor = false;
            this.btnLoadtoDb.Click += new System.EventHandler(this.btnLoadtoDb_Click);
            // 
            // frmProcessData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1769, 775);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProcessData";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Data";
            this.Load += new System.EventHandler(this.frmProcessData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.ComboBox CmbSheets;
        private System.Windows.Forms.Button BtnListGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExporttoExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Open;
        private System.Windows.Forms.DataGridViewTextBoxColumn High;
        private System.Windows.Forms.DataGridViewTextBoxColumn Low;
        private System.Windows.Forms.DataGridViewTextBoxColumn Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn True_Range;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATR_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATR_5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATR_14;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROC_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROC_5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROC_14;
        private System.Windows.Forms.DataGridViewTextBoxColumn NATR_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NATR_5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NATR_14;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPRatio;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLoadtoDb;
    }
}