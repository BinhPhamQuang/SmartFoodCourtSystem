namespace SmartFoodCourtSystem
{
    partial class UCReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCReport));
            this.lV = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idbill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.foodlist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.money = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbprocessing = new System.Windows.Forms.Label();
            this.ptbprocessing = new System.Windows.Forms.PictureBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFitler = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.btnMakeReport = new System.Windows.Forms.Button();
            this.grBox = new System.Windows.Forms.GroupBox();
            this.lV2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lV1 = new System.Windows.Forms.ListView();
            this.Month = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SalesRevenue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CostOfSales = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GrossProfit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbprocessing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lV
            // 
            this.lV.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.idbill,
            this.foodlist,
            this.amount,
            this.date,
            this.money});
            this.lV.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lV.FullRowSelect = true;
            this.lV.GridLines = true;
            this.lV.HideSelection = false;
            this.lV.Location = new System.Drawing.Point(28, 121);
            this.lV.Margin = new System.Windows.Forms.Padding(2);
            this.lV.Name = "lV";
            this.lV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lV.Size = new System.Drawing.Size(788, 414);
            this.lV.TabIndex = 5;
            this.lV.UseCompatibleStateImageBehavior = false;
            this.lV.View = System.Windows.Forms.View.Details;
            this.lV.SelectedIndexChanged += new System.EventHandler(this.lV_SelectedIndexChanged);
            this.lV.DoubleClick += new System.EventHandler(this.lV_DoubleClick);
            // 
            // Number
            // 
            this.Number.Text = "No";
            this.Number.Width = 40;
            // 
            // idbill
            // 
            this.idbill.Text = "Bill ID";
            this.idbill.Width = 80;
            // 
            // foodlist
            // 
            this.foodlist.Text = "Food List";
            this.foodlist.Width = 280;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.Width = 70;
            // 
            // date
            // 
            this.date.Text = "Time Checkout";
            this.date.Width = 200;
            // 
            // money
            // 
            this.money.Text = "Total Price";
            this.money.Width = 113;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.lbprocessing);
            this.groupBox1.Controls.Add(this.ptbprocessing);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.groupBox1.Location = new System.Drawing.Point(2, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(836, 454);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Bills";
            // 
            // lbprocessing
            // 
            this.lbprocessing.AutoSize = true;
            this.lbprocessing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(72)))), ((int)(((byte)(230)))));
            this.lbprocessing.Location = new System.Drawing.Point(315, 208);
            this.lbprocessing.Name = "lbprocessing";
            this.lbprocessing.Size = new System.Drawing.Size(118, 25);
            this.lbprocessing.TabIndex = 13;
            this.lbprocessing.Text = "Processing...";
            this.lbprocessing.Visible = false;
            // 
            // ptbprocessing
            // 
            this.ptbprocessing.Image = ((System.Drawing.Image)(resources.GetObject("ptbprocessing.Image")));
            this.ptbprocessing.Location = new System.Drawing.Point(401, 1);
            this.ptbprocessing.Name = "ptbprocessing";
            this.ptbprocessing.Size = new System.Drawing.Size(32, 29);
            this.ptbprocessing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbprocessing.TabIndex = 12;
            this.ptbprocessing.TabStop = false;
            this.ptbprocessing.Visible = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(670, 0);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(144, 29);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export to csv";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(352, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(1, 31);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 30);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnFitler);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cb3);
            this.groupBox2.Controls.Add(this.cb2);
            this.groupBox2.Controls.Add(this.btnMakeReport);
            this.groupBox2.Location = new System.Drawing.Point(4, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(254, 80);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // btnFitler
            // 
            this.btnFitler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFitler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFitler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFitler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.btnFitler.Location = new System.Drawing.Point(124, 35);
            this.btnFitler.Margin = new System.Windows.Forms.Padding(2);
            this.btnFitler.Name = "btnFitler";
            this.btnFitler.Size = new System.Drawing.Size(113, 38);
            this.btnFitler.TabIndex = 17;
            this.btnFitler.Text = "Filter";
            this.btnFitler.UseVisualStyleBackColor = false;
            this.btnFitler.Click += new System.EventHandler(this.btnFitler_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Month";
            // 
            // cb3
            // 
            this.cb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb3.FormattingEnabled = true;
            this.cb3.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015"});
            this.cb3.Location = new System.Drawing.Point(183, 10);
            this.cb3.Margin = new System.Windows.Forms.Padding(2);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(54, 21);
            this.cb3.TabIndex = 13;
            // 
            // cb2
            // 
            this.cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb2.Location = new System.Drawing.Point(45, 10);
            this.cb2.Margin = new System.Windows.Forms.Padding(2);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(54, 21);
            this.cb2.TabIndex = 12;
            // 
            // btnMakeReport
            // 
            this.btnMakeReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMakeReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.btnMakeReport.Location = new System.Drawing.Point(7, 35);
            this.btnMakeReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnMakeReport.Name = "btnMakeReport";
            this.btnMakeReport.Size = new System.Drawing.Size(113, 38);
            this.btnMakeReport.TabIndex = 10;
            this.btnMakeReport.Text = "Generate report";
            this.btnMakeReport.UseVisualStyleBackColor = false;
            this.btnMakeReport.Click += new System.EventHandler(this.btnMakeReport_Click);
            // 
            // grBox
            // 
            this.grBox.BackColor = System.Drawing.Color.Transparent;
            this.grBox.Controls.Add(this.lV2);
            this.grBox.Controls.Add(this.lV1);
            this.grBox.Controls.Add(this.btnExit);
            this.grBox.Controls.Add(this.label1);
            this.grBox.Controls.Add(this.pictureBox1);
            this.grBox.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.grBox.Location = new System.Drawing.Point(0, 0);
            this.grBox.Margin = new System.Windows.Forms.Padding(2);
            this.grBox.Name = "grBox";
            this.grBox.Padding = new System.Windows.Forms.Padding(2);
            this.grBox.Size = new System.Drawing.Size(840, 540);
            this.grBox.TabIndex = 12;
            this.grBox.TabStop = false;
            this.grBox.Text = "REVENUE REPORT";
            this.grBox.Visible = false;
            // 
            // lV2
            // 
            this.lV2.BackColor = System.Drawing.Color.White;
            this.lV2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lV2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lV2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lV2.FullRowSelect = true;
            this.lV2.GridLines = true;
            this.lV2.HideSelection = false;
            this.lV2.Location = new System.Drawing.Point(71, 164);
            this.lV2.Margin = new System.Windows.Forms.Padding(2);
            this.lV2.Name = "lV2";
            this.lV2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lV2.Scrollable = false;
            this.lV2.Size = new System.Drawing.Size(745, 275);
            this.lV2.TabIndex = 9;
            this.lV2.UseCompatibleStateImageBehavior = false;
            this.lV2.View = System.Windows.Forms.View.Details;
            this.lV2.Visible = false;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Year";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sales Revenue";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cost Of Sales";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Gross Profit";
            this.columnHeader5.Width = 200;
            // 
            // lV1
            // 
            this.lV1.BackColor = System.Drawing.Color.White;
            this.lV1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Month,
            this.Year,
            this.SalesRevenue,
            this.CostOfSales,
            this.GrossProfit});
            this.lV1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lV1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lV1.FullRowSelect = true;
            this.lV1.GridLines = true;
            this.lV1.HideSelection = false;
            this.lV1.Location = new System.Drawing.Point(71, 164);
            this.lV1.Margin = new System.Windows.Forms.Padding(2);
            this.lV1.Name = "lV1";
            this.lV1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lV1.Scrollable = false;
            this.lV1.Size = new System.Drawing.Size(745, 275);
            this.lV1.TabIndex = 8;
            this.lV1.UseCompatibleStateImageBehavior = false;
            this.lV1.View = System.Windows.Forms.View.Details;
            this.lV1.Visible = false;
            // 
            // Month
            // 
            this.Month.Text = "Month";
            this.Month.Width = 110;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Year.Width = 110;
            // 
            // SalesRevenue
            // 
            this.SalesRevenue.Text = "Sales Revenue";
            this.SalesRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SalesRevenue.Width = 180;
            // 
            // CostOfSales
            // 
            this.CostOfSales.Text = "Cost Of Sales";
            this.CostOfSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CostOfSales.Width = 180;
            // 
            // GrossProfit
            // 
            this.GrossProfit.Text = "Gross Profit";
            this.GrossProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GrossProfit.Width = 150;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(814, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 31);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(149, 441);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 47);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(277, -33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UCReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grBox);
            this.Name = "UCReport";
            this.Size = new System.Drawing.Size(840, 540);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbprocessing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lV;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader idbill;
        private System.Windows.Forms.ColumnHeader foodlist;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader money;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMakeReport;
        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.ListView lV2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lV1;
        private System.Windows.Forms.ColumnHeader Month;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader SalesRevenue;
        private System.Windows.Forms.ColumnHeader CostOfSales;
        private System.Windows.Forms.ColumnHeader GrossProfit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFitler;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbprocessing;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.PictureBox ptbprocessing;
    }
}
