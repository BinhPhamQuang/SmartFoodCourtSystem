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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCManMenu));
            this.dtgListFood = new System.Windows.Forms.DataGridView();
            this.gBdetail = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.pBfood = new System.Windows.Forms.PictureBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.cBcat = new System.Windows.Forms.ComboBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nmPrice = new System.Windows.Forms.NumericUpDown();
            this.tBdescript = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListFood)).BeginInit();
            this.gBdetail.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBfood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListFood
            // 
            this.dtgListFood.AllowUserToAddRows = false;
            this.dtgListFood.AllowUserToDeleteRows = false;
            this.dtgListFood.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtgListFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListFood.Location = new System.Drawing.Point(54, 15);
            this.dtgListFood.Name = "dtgListFood";
            this.dtgListFood.ReadOnly = true;
            this.dtgListFood.Size = new System.Drawing.Size(761, 264);
            this.dtgListFood.TabIndex = 0;
            this.dtgListFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListFood_CellClick);
            this.dtgListFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gBdetail
            // 
            this.gBdetail.Controls.Add(this.panel1);
            this.gBdetail.Controls.Add(this.btnNew);
            this.gBdetail.Controls.Add(this.cBcat);
            this.gBdetail.Controls.Add(this.btnDel);
            this.gBdetail.Controls.Add(this.btnUpdate);
            this.gBdetail.Controls.Add(this.btnAdd);
            this.gBdetail.Controls.Add(this.nmDiscount);
            this.gBdetail.Controls.Add(this.label6);
            this.gBdetail.Controls.Add(this.nmPrice);
            this.gBdetail.Controls.Add(this.tBdescript);
            this.gBdetail.Controls.Add(this.label5);
            this.gBdetail.Controls.Add(this.label4);
            this.gBdetail.Controls.Add(this.label3);
            this.gBdetail.Controls.Add(this.tBname);
            this.gBdetail.Controls.Add(this.label2);
            this.gBdetail.Location = new System.Drawing.Point(54, 285);
            this.gBdetail.Name = "gBdetail";
            this.gBdetail.Size = new System.Drawing.Size(761, 236);
            this.gBdetail.TabIndex = 40;
            this.gBdetail.TabStop = false;
            this.gBdetail.Enter += new System.EventHandler(this.gBdetail_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnAddImage);
            this.panel1.Controls.Add(this.pBfood);
            this.panel1.Location = new System.Drawing.Point(11, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 208);
            this.panel1.TabIndex = 29;
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddImage.BackgroundImage")));
            this.btnAddImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddImage.Location = new System.Drawing.Point(150, 169);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(25, 25);
            this.btnAddImage.TabIndex = 21;
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // pBfood
            // 
            this.pBfood.BackColor = System.Drawing.Color.White;
            this.pBfood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBfood.Location = new System.Drawing.Point(15, 15);
            this.pBfood.Name = "pBfood";
            this.pBfood.Size = new System.Drawing.Size(160, 179);
            this.pBfood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBfood.TabIndex = 19;
            this.pBfood.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.btnNew.Location = new System.Drawing.Point(675, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 59);
            this.btnNew.TabIndex = 28;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cBcat
            // 
            this.cBcat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBcat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cBcat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.cBcat.FormattingEnabled = true;
            this.cBcat.Items.AddRange(new object[] {
            "Food",
            "Drink"});
            this.cBcat.Location = new System.Drawing.Point(569, 19);
            this.cBcat.Name = "cBcat";
            this.cBcat.Size = new System.Drawing.Size(100, 26);
            this.cBcat.TabIndex = 18;
            this.cBcat.SelectedIndexChanged += new System.EventHandler(this.cBcat_SelectedIndexChanged);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.btnDel.Location = new System.Drawing.Point(675, 177);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(86, 59);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.btnUpdate.Location = new System.Drawing.Point(675, 122);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 59);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.btnAdd.Location = new System.Drawing.Point(675, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 59);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nmDiscount
            // 
            this.nmDiscount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.nmDiscount.Location = new System.Drawing.Point(569, 70);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(100, 26);
            this.nmDiscount.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.label6.Location = new System.Drawing.Point(485, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Discount";
            // 
            // nmPrice
            // 
            this.nmPrice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.nmPrice.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmPrice.Location = new System.Drawing.Point(266, 70);
            this.nmPrice.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nmPrice.Name = "nmPrice";
            this.nmPrice.Size = new System.Drawing.Size(194, 26);
            this.nmPrice.TabIndex = 8;
            // 
            // tBdescript
            // 
            this.tBdescript.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBdescript.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.tBdescript.Location = new System.Drawing.Point(210, 129);
            this.tBdescript.Multiline = true;
            this.tBdescript.Name = "tBdescript";
            this.tBdescript.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBdescript.Size = new System.Drawing.Size(459, 101);
            this.tBdescript.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.label5.Location = new System.Drawing.Point(207, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(485, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(207, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // tBname
            // 
            this.tBname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.tBname.Location = new System.Drawing.Point(266, 19);
            this.tBname.Name = "tBname";
            this.tBname.Size = new System.Drawing.Size(194, 26);
            this.tBname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(207, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBfood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListFood;
        private System.Windows.Forms.GroupBox gBdetail;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmPrice;
        private System.Windows.Forms.TextBox tBdescript;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBcat;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.PictureBox pBfood;
        private System.Windows.Forms.Label label5;
    }
}
