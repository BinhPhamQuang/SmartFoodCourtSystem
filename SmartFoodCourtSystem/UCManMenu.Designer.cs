namespace SmartFoodCourtSystem
{
    partial class UCManMenu
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
            this.dtgListFood = new System.Windows.Forms.DataGridView();
            this.gBdetail = new System.Windows.Forms.GroupBox();
            this.tBid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nmCat = new System.Windows.Forms.NumericUpDown();
            this.nmPrice = new System.Windows.Forms.NumericUpDown();
            this.tBdescript = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cBsize = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListFood)).BeginInit();
            this.gBdetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListFood
            // 
            this.dtgListFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListFood.Location = new System.Drawing.Point(26, 15);
            this.dtgListFood.Name = "dtgListFood";
            this.dtgListFood.Size = new System.Drawing.Size(789, 264);
            this.dtgListFood.TabIndex = 0;
            this.dtgListFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gBdetail
            // 
            this.gBdetail.Controls.Add(this.cBsize);
            this.gBdetail.Controls.Add(this.label7);
            this.gBdetail.Controls.Add(this.tBid);
            this.gBdetail.Controls.Add(this.label1);
            this.gBdetail.Controls.Add(this.btnDel);
            this.gBdetail.Controls.Add(this.btnUpdate);
            this.gBdetail.Controls.Add(this.btnAdd);
            this.gBdetail.Controls.Add(this.nmDiscount);
            this.gBdetail.Controls.Add(this.label6);
            this.gBdetail.Controls.Add(this.nmCat);
            this.gBdetail.Controls.Add(this.nmPrice);
            this.gBdetail.Controls.Add(this.tBdescript);
            this.gBdetail.Controls.Add(this.label5);
            this.gBdetail.Controls.Add(this.label4);
            this.gBdetail.Controls.Add(this.label3);
            this.gBdetail.Controls.Add(this.tBname);
            this.gBdetail.Controls.Add(this.label2);
            this.gBdetail.Location = new System.Drawing.Point(26, 285);
            this.gBdetail.Name = "gBdetail";
            this.gBdetail.Size = new System.Drawing.Size(789, 236);
            this.gBdetail.TabIndex = 40;
            this.gBdetail.TabStop = false;
            // 
            // tBid
            // 
            this.tBid.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBid.Location = new System.Drawing.Point(145, 37);
            this.tBid.Name = "tBid";
            this.tBid.ReadOnly = true;
            this.tBid.Size = new System.Drawing.Size(121, 26);
            this.tBid.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(640, 179);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(86, 38);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(640, 104);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 38);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(640, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 38);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nmDiscount
            // 
            this.nmDiscount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmDiscount.Location = new System.Drawing.Point(447, 90);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(121, 26);
            this.nmDiscount.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Discount";
            // 
            // nmCat
            // 
            this.nmCat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCat.Location = new System.Drawing.Point(447, 37);
            this.nmCat.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmCat.Name = "nmCat";
            this.nmCat.Size = new System.Drawing.Size(121, 26);
            this.nmCat.TabIndex = 9;
            // 
            // nmPrice
            // 
            this.nmPrice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmPrice.Location = new System.Drawing.Point(145, 141);
            this.nmPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nmPrice.Name = "nmPrice";
            this.nmPrice.Size = new System.Drawing.Size(121, 26);
            this.nmPrice.TabIndex = 8;
            // 
            // tBdescript
            // 
            this.tBdescript.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBdescript.Location = new System.Drawing.Point(145, 194);
            this.tBdescript.Name = "tBdescript";
            this.tBdescript.Size = new System.Drawing.Size(121, 26);
            this.tBdescript.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // tBname
            // 
            this.tBname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBname.Location = new System.Drawing.Point(145, 91);
            this.tBname.Name = "tBname";
            this.tBname.Size = new System.Drawing.Size(121, 26);
            this.tBname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(353, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Size";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cBsize
            // 
            this.cBsize.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBsize.FormattingEnabled = true;
            this.cBsize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cBsize.Location = new System.Drawing.Point(447, 141);
            this.cBsize.Name = "cBsize";
            this.cBsize.Size = new System.Drawing.Size(121, 24);
            this.cBsize.TabIndex = 21;
            // 
            // UCManMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gBdetail);
            this.Controls.Add(this.dtgListFood);
            this.Name = "UCManMenu";
            this.Size = new System.Drawing.Size(840, 540);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListFood)).EndInit();
            this.gBdetail.ResumeLayout(false);
            this.gBdetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListFood;
        private System.Windows.Forms.GroupBox gBdetail;
        private System.Windows.Forms.TextBox tBid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmCat;
        private System.Windows.Forms.NumericUpDown nmPrice;
        private System.Windows.Forms.TextBox tBdescript;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBsize;
    }
}
