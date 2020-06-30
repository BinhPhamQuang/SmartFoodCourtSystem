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
            this.btnMakeReport = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.grBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
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
            this.Number.Text = "STT";
            this.Number.Width = 40;
            // 
            // idbill
            // 
            this.idbill.Text = "Mã hóa đơn";
            this.idbill.Width = 90;
            // 
            // foodlist
            // 
            this.foodlist.Text = "Danh sách món ăn";
            this.foodlist.Width = 315;
            // 
            // amount
            // 
            this.amount.Text = "Số món";
            this.amount.Width = 70;
            // 
            // date
            // 
            this.date.Text = "Thời gian xuất";
            this.date.Width = 160;
            // 
            // money
            // 
            this.money.Text = "Tổng tiền";
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
            this.groupBox1.Text = "Doanh thu";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cb3);
            this.groupBox2.Controls.Add(this.cb2);
            this.groupBox2.Controls.Add(this.cb1);
            this.groupBox2.Controls.Add(this.btnMakeReport);
            this.groupBox2.Location = new System.Drawing.Point(420, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 98);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // btnMakeReport
            // 
            this.btnMakeReport.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMakeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeReport.ForeColor = System.Drawing.Color.White;
            this.btnMakeReport.Location = new System.Drawing.Point(258, 31);
            this.btnMakeReport.Name = "btnMakeReport";
            this.btnMakeReport.Size = new System.Drawing.Size(157, 46);
            this.btnMakeReport.TabIndex = 10;
            this.btnMakeReport.Text = "TẠO BÁO CÁO";
            this.btnMakeReport.UseVisualStyleBackColor = false;
            this.btnMakeReport.Click += new System.EventHandler(this.btnMakeReport_Click);
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
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
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "Ngày"});
            this.cb1.Location = new System.Drawing.Point(21, 43);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(70, 24);
            this.cb1.TabIndex = 11;
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
            "12",
            "Tháng"});
            this.cb2.Location = new System.Drawing.Point(97, 43);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(70, 24);
            this.cb2.TabIndex = 12;
            // 
            // cb3
            // 
            this.cb3.FormattingEnabled = true;
            this.cb3.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017",
            "Năm"});
            this.cb3.Location = new System.Drawing.Point(173, 43);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(70, 24);
            this.cb3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Năm";
            // 
            // grBox
            // 
            this.grBox.BackColor = System.Drawing.Color.Gray;
            this.grBox.Controls.Add(this.btnExit);
            this.grBox.Controls.Add(this.label5);
            this.grBox.Controls.Add(this.pictureBox1);
            this.grBox.Controls.Add(this.label4);
            this.grBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBox.ForeColor = System.Drawing.Color.Yellow;
            this.grBox.Location = new System.Drawing.Point(0, 0);
            this.grBox.Name = "grBox";
            this.grBox.Size = new System.Drawing.Size(1120, 665);
            this.grBox.TabIndex = 12;
            this.grBox.TabStop = false;
            this.grBox.Text = "BÁO CÁO DOANH THU";
            this.grBox.Visible = false;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(293, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 44);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 139);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            // UCReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCReport";
            this.Size = new System.Drawing.Size(1120, 665);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grBox.ResumeLayout(false);
            this.grBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
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
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnExit;
    }
}
