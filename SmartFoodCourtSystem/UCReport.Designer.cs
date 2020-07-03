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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.btnMakeReport = new System.Windows.Forms.Button();
            this.grBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.grBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lV
            // 
            this.lV.BackColor = System.Drawing.Color.White;
            this.lV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.idbill,
            this.foodlist,
            this.amount,
            this.date,
            this.money});
            this.lV.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lV.FullRowSelect = true;
            this.lV.GridLines = true;
            this.lV.HideSelection = false;
            this.lV.Location = new System.Drawing.Point(38, 144);
            this.lV.Name = "lV";
            this.lV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lV.Size = new System.Drawing.Size(1050, 509);
            this.lV.TabIndex = 5;
            this.lV.UseCompatibleStateImageBehavior = false;
            this.lV.View = System.Windows.Forms.View.Details;
            // 
            // Number
            // 
            this.Number.Text = "No";
            this.Number.Width = 40;
            // 
            // idbill
            // 
            this.idbill.Text = "Bill ID";
            this.idbill.Width = 90;
            // 
            // foodlist
            // 
            this.foodlist.Text = "Food List";
            this.foodlist.Width = 315;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.Width = 70;
            // 
            // date
            // 
            this.date.Text = "Time Checkout";
            this.date.Width = 160;
            // 
            // money
            // 
            this.money.Text = "Total Price";
            this.money.Width = 109;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1114, 559);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Bills";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cb3);
            this.groupBox2.Controls.Add(this.cb2);
            this.groupBox2.Controls.Add(this.btnMakeReport);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 98);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Month";
            // 
            // cb3
            // 
            this.cb3.FormattingEnabled = true;
            this.cb3.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015"});
            this.cb3.Location = new System.Drawing.Point(85, 43);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(70, 24);
            this.cb3.TabIndex = 13;
            // 
            // cb2
            // 
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
            this.cb2.Location = new System.Drawing.Point(9, 43);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(70, 24);
            this.cb2.TabIndex = 12;
            // 
            // btnMakeReport
            // 
            this.btnMakeReport.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMakeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeReport.ForeColor = System.Drawing.Color.White;
            this.btnMakeReport.Location = new System.Drawing.Point(161, 31);
            this.btnMakeReport.Name = "btnMakeReport";
            this.btnMakeReport.Size = new System.Drawing.Size(167, 46);
            this.btnMakeReport.TabIndex = 10;
            this.btnMakeReport.Text = "GENERATE REPORT";
            this.btnMakeReport.UseVisualStyleBackColor = false;
            this.btnMakeReport.Click += new System.EventHandler(this.btnMakeReport_Click);
            // 
            // grBox
            // 
            this.grBox.BackColor = System.Drawing.Color.DarkGray;
            this.grBox.Controls.Add(this.label1);
            this.grBox.Controls.Add(this.btnExport);
            this.grBox.Controls.Add(this.lV2);
            this.grBox.Controls.Add(this.lV1);
            this.grBox.Controls.Add(this.btnExit);
            this.grBox.Controls.Add(this.pictureBox1);
            this.grBox.Controls.Add(this.label4);
            this.grBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBox.ForeColor = System.Drawing.Color.Yellow;
            this.grBox.Location = new System.Drawing.Point(0, 0);
            this.grBox.Name = "grBox";
            this.grBox.Size = new System.Drawing.Size(1120, 665);
            this.grBox.TabIndex = 12;
            this.grBox.TabStop = false;
            this.grBox.Text = "REVENUE REPORT";
            this.grBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Gray;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Yellow;
            this.btnExport.Location = new System.Drawing.Point(500, 575);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 48);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lV2
            // 
            this.lV2.BackColor = System.Drawing.Color.White;
            this.lV2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lV2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lV2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lV2.FullRowSelect = true;
            this.lV2.GridLines = true;
            this.lV2.HideSelection = false;
            this.lV2.Location = new System.Drawing.Point(264, 238);
            this.lV2.Name = "lV2";
            this.lV2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lV2.Scrollable = false;
            this.lV2.Size = new System.Drawing.Size(656, 82);
            this.lV2.TabIndex = 9;
            this.lV2.UseCompatibleStateImageBehavior = false;
            this.lV2.View = System.Windows.Forms.View.Details;
            this.lV2.Visible = false;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Year";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sales Revenue";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cost Of Sales";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Gross Profit";
            this.columnHeader5.Width = 150;
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
            this.lV1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lV1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lV1.FullRowSelect = true;
            this.lV1.GridLines = true;
            this.lV1.HideSelection = false;
            this.lV1.Location = new System.Drawing.Point(232, 238);
            this.lV1.Name = "lV1";
            this.lV1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lV1.Scrollable = false;
            this.lV1.Size = new System.Drawing.Size(718, 82);
            this.lV1.TabIndex = 8;
            this.lV1.UseCompatibleStateImageBehavior = false;
            this.lV1.View = System.Windows.Forms.View.Details;
            this.lV1.Visible = false;
            // 
            // Month
            // 
            this.Month.Text = "Month";
            // 
            // Year
            // 
            this.Year.Text = "Year";
            // 
            // SalesRevenue
            // 
            this.SalesRevenue.Text = "Sales Revenue";
            this.SalesRevenue.Width = 150;
            // 
            // CostOfSales
            // 
            this.CostOfSales.Text = "Cost Of Sales";
            this.CostOfSales.Width = 150;
            // 
            // GrossProfit
            // 
            this.GrossProfit.Text = "Gross Profit";
            this.GrossProfit.Width = 150;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1085, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 38);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(331, -24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(3, 644);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chuỗi nhà hàng Hippo Town";
            this.label4.Visible = false;
            // 
            // UCReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lV);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCReport";
            this.Size = new System.Drawing.Size(1120, 665);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grBox.ResumeLayout(false);
            this.grBox.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Button btnExport;
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
    }
}
