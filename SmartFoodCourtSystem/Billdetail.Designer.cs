namespace SmartFoodCourtSystem
{
    partial class Billdetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billdetail));
            this.lV = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idbill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.foodlist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.das = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbdate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbprice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // lV
            // 
            this.lV.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.idbill,
            this.foodlist,
            this.amount});
            this.lV.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lV.FullRowSelect = true;
            this.lV.GridLines = true;
            this.lV.HideSelection = false;
            this.lV.Location = new System.Drawing.Point(11, 38);
            this.lV.Margin = new System.Windows.Forms.Padding(2);
            this.lV.Name = "lV";
            this.lV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lV.Size = new System.Drawing.Size(407, 412);
            this.lV.TabIndex = 6;
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
            this.idbill.Text = "Name";
            this.idbill.Width = 180;
            // 
            // foodlist
            // 
            this.foodlist.Text = "Quantity";
            this.foodlist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.foodlist.Width = 90;
            // 
            // amount
            // 
            this.amount.Text = "Discount";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amount.Width = 90;
            // 
            // das
            // 
            this.das.AutoSize = true;
            this.das.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.das.Location = new System.Drawing.Point(14, 13);
            this.das.Name = "das";
            this.das.Size = new System.Drawing.Size(57, 19);
            this.das.TabIndex = 7;
            this.das.Text = "Bill ID: ";
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(399, 1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 31);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 10;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbID
            // 
            this.lbID.Location = new System.Drawing.Point(67, 13);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(113, 21);
            this.lbID.TabIndex = 11;
            this.lbID.Text = "12313901239";
            // 
            // lbdate
            // 
            this.lbdate.Font = new System.Drawing.Font("Letter Gothic Std", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdate.Location = new System.Drawing.Point(186, 13);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(203, 21);
            this.lbdate.TabIndex = 12;
            this.lbdate.Text = "12313901239 - 1/7/8";
            this.lbdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Total price:";
            // 
            // lbprice
            // 
            this.lbprice.Font = new System.Drawing.Font("Dungeon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprice.ForeColor = System.Drawing.Color.Crimson;
            this.lbprice.Location = new System.Drawing.Point(100, 455);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(318, 21);
            this.lbprice.TabIndex = 14;
            this.lbprice.Text = "99999999999999";
            this.lbprice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(103, 475);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 2);
            this.panel1.TabIndex = 15;
            // 
            // Billdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(424, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbprice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.das);
            this.Controls.Add(this.lV);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Billdetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill detail";
            this.Load += new System.EventHandler(this.Billdetail_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Billdetail_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lV;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader idbill;
        private System.Windows.Forms.ColumnHeader foodlist;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.Label das;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbprice;
        private System.Windows.Forms.Panel panel1;
    }
}