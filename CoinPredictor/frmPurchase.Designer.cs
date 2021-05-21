namespace CoinPredictor
{
    partial class frmBuyCoin
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbInstrument = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.btnCheckClose = new System.Windows.Forms.Button();
            this.txtClose0Value = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClose1Value = new System.Windows.Forms.TextBox();
            this.lblCloseValue = new System.Windows.Forms.Label();
            this.txtCloseValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClose0Date = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClose1Date = new System.Windows.Forms.TextBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.txtOpeningBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtCurrentBalance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblProfitTarget = new System.Windows.Forms.Label();
            this.txtProfitTarget = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instrument";
            // 
            // cmbInstrument
            // 
            this.cmbInstrument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstrument.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInstrument.FormattingEnabled = true;
            this.cmbInstrument.Location = new System.Drawing.Point(150, 43);
            this.cmbInstrument.Name = "cmbInstrument";
            this.cmbInstrument.Size = new System.Drawing.Size(198, 25);
            this.cmbInstrument.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(393, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opening Balance $:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(763, 45);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(19, 25);
            this.dtpStartDate.TabIndex = 770;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // txtStartDate
            // 
            this.txtStartDate.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(547, 45);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(217, 25);
            this.txtStartDate.TabIndex = 769;
            this.txtStartDate.TextChanged += new System.EventHandler(this.txtStartDate_TextChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(1130, 43);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(19, 25);
            this.dtpEndDate.TabIndex = 772;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // txtEndDate
            // 
            this.txtEndDate.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(932, 43);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(199, 25);
            this.txtEndDate.TabIndex = 771;
            // 
            // btnCheckClose
            // 
            this.btnCheckClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCheckClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckClose.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckClose.ForeColor = System.Drawing.Color.White;
            this.btnCheckClose.Location = new System.Drawing.Point(150, 74);
            this.btnCheckClose.Name = "btnCheckClose";
            this.btnCheckClose.Size = new System.Drawing.Size(94, 29);
            this.btnCheckClose.TabIndex = 773;
            this.btnCheckClose.Text = "Check Close";
            this.btnCheckClose.UseVisualStyleBackColor = false;
            this.btnCheckClose.Click += new System.EventHandler(this.btnCheckClose_Click);
            // 
            // txtClose0Value
            // 
            this.txtClose0Value.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClose0Value.Location = new System.Drawing.Point(150, 163);
            this.txtClose0Value.Name = "txtClose0Value";
            this.txtClose0Value.ReadOnly = true;
            this.txtClose0Value.Size = new System.Drawing.Size(198, 25);
            this.txtClose0Value.TabIndex = 774;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Close 0 Value:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(390, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Close 1 Value:";
            // 
            // txtClose1Value
            // 
            this.txtClose1Value.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClose1Value.Location = new System.Drawing.Point(547, 171);
            this.txtClose1Value.Name = "txtClose1Value";
            this.txtClose1Value.ReadOnly = true;
            this.txtClose1Value.Size = new System.Drawing.Size(236, 25);
            this.txtClose1Value.TabIndex = 774;
            // 
            // lblCloseValue
            // 
            this.lblCloseValue.AutoSize = true;
            this.lblCloseValue.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseValue.ForeColor = System.Drawing.Color.White;
            this.lblCloseValue.Location = new System.Drawing.Point(841, 139);
            this.lblCloseValue.Name = "lblCloseValue";
            this.lblCloseValue.Size = new System.Drawing.Size(82, 17);
            this.lblCloseValue.TabIndex = 2;
            this.lblCloseValue.Text = "Close Value:";
            // 
            // txtCloseValue
            // 
            this.txtCloseValue.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCloseValue.Location = new System.Drawing.Point(931, 136);
            this.txtCloseValue.Name = "txtCloseValue";
            this.txtCloseValue.ReadOnly = true;
            this.txtCloseValue.Size = new System.Drawing.Size(218, 25);
            this.txtCloseValue.TabIndex = 774;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Close 0 Date:";
            // 
            // txtClose0Date
            // 
            this.txtClose0Date.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClose0Date.Location = new System.Drawing.Point(150, 126);
            this.txtClose0Date.Name = "txtClose0Date";
            this.txtClose0Date.ReadOnly = true;
            this.txtClose0Date.Size = new System.Drawing.Size(198, 25);
            this.txtClose0Date.TabIndex = 774;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(390, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Close 1 Date:";
            // 
            // txtClose1Date
            // 
            this.txtClose1Date.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClose1Date.Location = new System.Drawing.Point(547, 134);
            this.txtClose1Date.Name = "txtClose1Date";
            this.txtClose1Date.ReadOnly = true;
            this.txtClose1Date.Size = new System.Drawing.Size(236, 25);
            this.txtClose1Date.TabIndex = 774;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(14, 58);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(94, 29);
            this.btnBuy.TabIndex = 773;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // txtOpeningBalance
            // 
            this.txtOpeningBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtOpeningBalance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpeningBalance.Location = new System.Drawing.Point(150, 10);
            this.txtOpeningBalance.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtOpeningBalance.Name = "txtOpeningBalance";
            this.txtOpeningBalance.ReadOnly = true;
            this.txtOpeningBalance.Size = new System.Drawing.Size(198, 25);
            this.txtOpeningBalance.TabIndex = 776;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(841, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "End Date:";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(14, 29);
            this.txtQty.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(197, 25);
            this.txtQty.TabIndex = 777;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.White;
            this.lblQty.Location = new System.Drawing.Point(11, 6);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(35, 17);
            this.lblQty.TabIndex = 778;
            this.lblQty.Text = "Qty:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmount.Location = new System.Drawing.Point(236, 6);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(97, 17);
            this.lblTotalAmount.TabIndex = 780;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(239, 29);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(198, 25);
            this.txtTotalAmount.TabIndex = 779;
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCurrentBalance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentBalance.Location = new System.Drawing.Point(547, 11);
            this.txtCurrentBalance.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.ReadOnly = true;
            this.txtCurrentBalance.Size = new System.Drawing.Size(236, 25);
            this.txtCurrentBalance.TabIndex = 779;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(393, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 780;
            this.label9.Text = "Current Balance:";
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Teal;
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.txtOpeningBalance);
            this.splitContainer1.Panel1.Controls.Add(this.txtClose0Date);
            this.splitContainer1.Panel1.Controls.Add(this.txtClose0Value);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtClose1Value);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtCurrentBalance);
            this.splitContainer1.Panel1.Controls.Add(this.txtClose1Date);
            this.splitContainer1.Panel1.Controls.Add(this.cmbInstrument);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txtCloseValue);
            this.splitContainer1.Panel1.Controls.Add(this.lblCloseValue);
            this.splitContainer1.Panel1.Controls.Add(this.btnCheckClose);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.dtpEndDate);
            this.splitContainer1.Panel1.Controls.Add(this.txtStartDate);
            this.splitContainer1.Panel1.Controls.Add(this.txtEndDate);
            this.splitContainer1.Panel1.Controls.Add(this.dtpStartDate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(110)))), ((int)(((byte)(105)))));
            this.splitContainer1.Panel2.Controls.Add(this.txtQty);
            this.splitContainer1.Panel2.Controls.Add(this.btnBuy);
            this.splitContainer1.Panel2.Controls.Add(this.lblQty);
            this.splitContainer1.Panel2.Controls.Add(this.lblProfitTarget);
            this.splitContainer1.Panel2.Controls.Add(this.lblTotalAmount);
            this.splitContainer1.Panel2.Controls.Add(this.txtProfitTarget);
            this.splitContainer1.Panel2.Controls.Add(this.txtTotalAmount);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 345);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 781;
            // 
            // lblProfitTarget
            // 
            this.lblProfitTarget.AutoSize = true;
            this.lblProfitTarget.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfitTarget.ForeColor = System.Drawing.Color.White;
            this.lblProfitTarget.Location = new System.Drawing.Point(468, 6);
            this.lblProfitTarget.Name = "lblProfitTarget";
            this.lblProfitTarget.Size = new System.Drawing.Size(197, 17);
            this.lblProfitTarget.TabIndex = 780;
            this.lblProfitTarget.Text = "Expected Target Profit (10%):";
            // 
            // txtProfitTarget
            // 
            this.txtProfitTarget.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfitTarget.Location = new System.Drawing.Point(468, 29);
            this.txtProfitTarget.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.txtProfitTarget.Name = "txtProfitTarget";
            this.txtProfitTarget.ReadOnly = true;
            this.txtProfitTarget.Size = new System.Drawing.Size(197, 25);
            this.txtProfitTarget.TabIndex = 779;
            // 
            // frmBuyCoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 345);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmBuyCoin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Coin";
            this.Load += new System.EventHandler(this.frmBackTrack_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbInstrument;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Button btnCheckClose;
        private System.Windows.Forms.TextBox txtClose0Value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClose1Value;
        private System.Windows.Forms.Label lblCloseValue;
        private System.Windows.Forms.TextBox txtCloseValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClose0Date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClose1Date;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.TextBox txtOpeningBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtCurrentBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblProfitTarget;
        private System.Windows.Forms.TextBox txtProfitTarget;
    }
}