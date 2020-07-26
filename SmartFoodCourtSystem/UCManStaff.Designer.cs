namespace SmartFoodCourtSystem
{
    partial class UCManStaff
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
            this.dtgListEmployee = new System.Windows.Forms.DataGridView();
            this.gBdetail = new System.Windows.Forms.GroupBox();
            this.nmPhone = new System.Windows.Forms.TextBox();
            this.cBtype = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tBpass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nmAge = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nmSalary = new System.Windows.Forms.NumericUpDown();
            this.tBusername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListEmployee)).BeginInit();
            this.gBdetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListEmployee
            // 
            this.dtgListEmployee.AllowUserToAddRows = false;
            this.dtgListEmployee.AllowUserToDeleteRows = false;
            this.dtgListEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtgListEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListEmployee.Location = new System.Drawing.Point(54, 15);
            this.dtgListEmployee.Name = "dtgListEmployee";
            this.dtgListEmployee.ReadOnly = true;
            this.dtgListEmployee.Size = new System.Drawing.Size(761, 264);
            this.dtgListEmployee.TabIndex = 0;
            this.dtgListEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListEmployee_CellClick);
            this.dtgListEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListEmployee_CellContentClick);
            // 
            // gBdetail
            // 
            this.gBdetail.Controls.Add(this.nmPhone);
            this.gBdetail.Controls.Add(this.btnNew);
            this.gBdetail.Controls.Add(this.cBtype);
            this.gBdetail.Controls.Add(this.label9);
            this.gBdetail.Controls.Add(this.label1);
            this.gBdetail.Controls.Add(this.label8);
            this.gBdetail.Controls.Add(this.tBpass);
            this.gBdetail.Controls.Add(this.label7);
            this.gBdetail.Controls.Add(this.btnDel);
            this.gBdetail.Controls.Add(this.btnUpdate);
            this.gBdetail.Controls.Add(this.btnAdd);
            this.gBdetail.Controls.Add(this.nmAge);
            this.gBdetail.Controls.Add(this.label6);
            this.gBdetail.Controls.Add(this.nmSalary);
            this.gBdetail.Controls.Add(this.tBusername);
            this.gBdetail.Controls.Add(this.label5);
            this.gBdetail.Controls.Add(this.label4);
            this.gBdetail.Controls.Add(this.label3);
            this.gBdetail.Controls.Add(this.tBname);
            this.gBdetail.Controls.Add(this.label2);
            this.gBdetail.Controls.Add(this.checkBox1);
            this.gBdetail.Location = new System.Drawing.Point(54, 285);
            this.gBdetail.Name = "gBdetail";
            this.gBdetail.Size = new System.Drawing.Size(761, 236);
            this.gBdetail.TabIndex = 41;
            this.gBdetail.TabStop = false;
            // 
            // nmPhone
            // 
            this.nmPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.nmPhone.Location = new System.Drawing.Point(102, 189);
            this.nmPhone.Name = "nmPhone";
            this.nmPhone.Size = new System.Drawing.Size(170, 24);
            this.nmPhone.TabIndex = 29;
            this.nmPhone.Text = "0";
            this.nmPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nmPhone_KeyPress);
            // 
            // cBtype
            // 
            this.cBtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBtype.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cBtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.cBtype.FormattingEnabled = true;
            this.cBtype.Items.AddRange(new object[] {
            "Cook",
            "Manager"});
            this.cBtype.Location = new System.Drawing.Point(481, 178);
            this.cBtype.Name = "cBtype";
            this.cBtype.Size = new System.Drawing.Size(170, 26);
            this.cBtype.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.label9.Location = new System.Drawing.Point(468, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "Personal Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(86, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Personal Information";
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.label8.Location = new System.Drawing.Point(387, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Type";
            // 
            // tBpass
            // 
            this.tBpass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.tBpass.Location = new System.Drawing.Point(481, 112);
            this.tBpass.Name = "tBpass";
            this.tBpass.Size = new System.Drawing.Size(170, 26);
            this.tBpass.TabIndex = 21;
            this.tBpass.UseSystemPasswordChar = true;
            this.tBpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBpass_KeyPress);
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.label7.Location = new System.Drawing.Point(387, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Password";
            // 
            // nmAge
            // 
            this.nmAge.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.nmAge.Location = new System.Drawing.Point(102, 97);
            this.nmAge.Name = "nmAge";
            this.nmAge.Size = new System.Drawing.Size(170, 26);
            this.nmAge.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.label6.Location = new System.Drawing.Point(8, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Age";
            // 
            // nmSalary
            // 
            this.nmSalary.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.nmSalary.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nmSalary.Location = new System.Drawing.Point(102, 144);
            this.nmSalary.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmSalary.Name = "nmSalary";
            this.nmSalary.Size = new System.Drawing.Size(170, 26);
            this.nmSalary.TabIndex = 8;
            // 
            // tBusername
            // 
            this.tBusername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.tBusername.Location = new System.Drawing.Point(481, 49);
            this.tBusername.Name = "tBusername";
            this.tBusername.ReadOnly = true;
            this.tBusername.Size = new System.Drawing.Size(170, 26);
            this.tBusername.TabIndex = 7;
            this.tBusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBusername_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.label5.Location = new System.Drawing.Point(387, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Username";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(8, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(8, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // tBname
            // 
            this.tBname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.tBname.Location = new System.Drawing.Point(102, 51);
            this.tBname.Name = "tBname";
            this.tBname.Size = new System.Drawing.Size(170, 26);
            this.tBname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(481, 143);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 21);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Unhide password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            // UCManStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gBdetail);
            this.Controls.Add(this.dtgListEmployee);
            this.Name = "UCManStaff";
            this.Size = new System.Drawing.Size(840, 540);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListEmployee)).EndInit();
            this.gBdetail.ResumeLayout(false);
            this.gBdetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListEmployee;
        private System.Windows.Forms.GroupBox gBdetail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmSalary;
        private System.Windows.Forms.TextBox tBusername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBpass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBtype;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox nmPhone;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}
