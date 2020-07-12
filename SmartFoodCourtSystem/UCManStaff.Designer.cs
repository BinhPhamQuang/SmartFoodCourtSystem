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
            this.label8 = new System.Windows.Forms.Label();
            this.tBpass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nmAge = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nmPhone = new System.Windows.Forms.NumericUpDown();
            this.nmSalary = new System.Windows.Forms.NumericUpDown();
            this.tBusername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cBtype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListEmployee)).BeginInit();
            this.gBdetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListEmployee
            // 
            this.dtgListEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListEmployee.Location = new System.Drawing.Point(22, 13);
            this.dtgListEmployee.Name = "dtgListEmployee";
            this.dtgListEmployee.Size = new System.Drawing.Size(791, 262);
            this.dtgListEmployee.TabIndex = 0;
            this.dtgListEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListEmployee_CellContentClick);
            // 
            // gBdetail
            // 
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
            this.gBdetail.Controls.Add(this.nmPhone);
            this.gBdetail.Controls.Add(this.nmSalary);
            this.gBdetail.Controls.Add(this.tBusername);
            this.gBdetail.Controls.Add(this.label5);
            this.gBdetail.Controls.Add(this.label4);
            this.gBdetail.Controls.Add(this.label3);
            this.gBdetail.Controls.Add(this.tBname);
            this.gBdetail.Controls.Add(this.label2);
            this.gBdetail.Location = new System.Drawing.Point(22, 291);
            this.gBdetail.Name = "gBdetail";
            this.gBdetail.Size = new System.Drawing.Size(791, 237);
            this.gBdetail.TabIndex = 41;
            this.gBdetail.TabStop = false;
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(390, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Type";
            // 
            // tBpass
            // 
            this.tBpass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBpass.Location = new System.Drawing.Point(484, 97);
            this.tBpass.Name = "tBpass";
            this.tBpass.Size = new System.Drawing.Size(170, 26);
            this.tBpass.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(390, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Password";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(705, 157);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(86, 79);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(705, 82);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 79);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(705, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 79);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nmAge
            // 
            this.nmAge.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmAge.Location = new System.Drawing.Point(142, 97);
            this.nmAge.Name = "nmAge";
            this.nmAge.Size = new System.Drawing.Size(170, 26);
            this.nmAge.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Age";
            // 
            // nmPhone
            // 
            this.nmPhone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmPhone.Location = new System.Drawing.Point(142, 193);
            this.nmPhone.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nmPhone.Name = "nmPhone";
            this.nmPhone.Size = new System.Drawing.Size(170, 26);
            this.nmPhone.TabIndex = 9;
            // 
            // nmSalary
            // 
            this.nmSalary.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmSalary.Location = new System.Drawing.Point(142, 144);
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
            this.tBusername.Location = new System.Drawing.Point(484, 48);
            this.tBusername.Name = "tBusername";
            this.tBusername.Size = new System.Drawing.Size(170, 26);
            this.tBusername.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(390, 51);
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
            this.label4.Location = new System.Drawing.Point(48, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // tBname
            // 
            this.tBname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBname.Location = new System.Drawing.Point(142, 51);
            this.tBname.Name = "tBname";
            this.tBname.Size = new System.Drawing.Size(170, 26);
            this.tBname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Personal Information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(471, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "Personal Account";
            // 
            // cBtype
            // 
            this.cBtype.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cBtype.FormattingEnabled = true;
            this.cBtype.Items.AddRange(new object[] {
            "Cook",
            "Manager"});
            this.cBtype.Location = new System.Drawing.Point(484, 144);
            this.cBtype.Name = "cBtype";
            this.cBtype.Size = new System.Drawing.Size(170, 26);
            this.cBtype.TabIndex = 26;
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
            ((System.ComponentModel.ISupportInitialize)(this.nmPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListEmployee;
        private System.Windows.Forms.GroupBox gBdetail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nmAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmPhone;
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
    }
}
