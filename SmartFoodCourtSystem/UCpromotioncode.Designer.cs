namespace SmartFoodCourtSystem
{
    partial class UCpromotioncode
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
            this.gBdetail = new System.Windows.Forms.GroupBox();
            this.btncreate = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.numTimes = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericdiscount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.duedate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datestart = new System.Windows.Forms.DateTimePicker();
            this.tbnamecode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timestart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enddate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.discount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcode = new System.Windows.Forms.ListView();
            this.gBdetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericdiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // gBdetail
            // 
            this.gBdetail.Controls.Add(this.btncreate);
            this.gBdetail.Controls.Add(this.btncancel);
            this.gBdetail.Controls.Add(this.numTimes);
            this.gBdetail.Controls.Add(this.label5);
            this.gBdetail.Controls.Add(this.numericdiscount);
            this.gBdetail.Controls.Add(this.label4);
            this.gBdetail.Controls.Add(this.duedate);
            this.gBdetail.Controls.Add(this.label3);
            this.gBdetail.Controls.Add(this.label2);
            this.gBdetail.Controls.Add(this.datestart);
            this.gBdetail.Controls.Add(this.tbnamecode);
            this.gBdetail.Controls.Add(this.label1);
            this.gBdetail.Location = new System.Drawing.Point(34, 292);
            this.gBdetail.Name = "gBdetail";
            this.gBdetail.Size = new System.Drawing.Size(426, 230);
            this.gBdetail.TabIndex = 42;
            this.gBdetail.TabStop = false;
            // 
            // btncreate
            // 
            this.btncreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btncreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncreate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btncreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.btncreate.Location = new System.Drawing.Point(13, 184);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(180, 30);
            this.btncreate.TabIndex = 43;
            this.btncreate.Text = "Confirm";
            this.btncreate.UseVisualStyleBackColor = false;
            this.btncreate.Visible = false;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btncancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.btncancel.Location = new System.Drawing.Point(226, 184);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(180, 30);
            this.btncancel.TabIndex = 44;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Visible = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // numTimes
            // 
            this.numTimes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTimes.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numTimes.Location = new System.Drawing.Point(146, 175);
            this.numTimes.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numTimes.Name = "numTimes";
            this.numTimes.Size = new System.Drawing.Size(260, 26);
            this.numTimes.TabIndex = 46;
            this.numTimes.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.label5.Location = new System.Drawing.Point(9, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Number of times:";
            this.label5.Visible = false;
            // 
            // numericdiscount
            // 
            this.numericdiscount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericdiscount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericdiscount.Location = new System.Drawing.Point(146, 140);
            this.numericdiscount.Name = "numericdiscount";
            this.numericdiscount.Size = new System.Drawing.Size(260, 26);
            this.numericdiscount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(9, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Discount";
            // 
            // duedate
            // 
            this.duedate.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duedate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duedate.Location = new System.Drawing.Point(146, 101);
            this.duedate.Name = "duedate";
            this.duedate.Size = new System.Drawing.Size(260, 26);
            this.duedate.TabIndex = 5;
            this.duedate.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(7, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Due date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date start";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // datestart
            // 
            this.datestart.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datestart.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datestart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datestart.Location = new System.Drawing.Point(146, 66);
            this.datestart.Name = "datestart";
            this.datestart.Size = new System.Drawing.Size(260, 26);
            this.datestart.TabIndex = 2;
            this.datestart.ValueChanged += new System.EventHandler(this.datestart_ValueChanged);
            // 
            // tbnamecode
            // 
            this.tbnamecode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnamecode.Location = new System.Drawing.Point(146, 30);
            this.tbnamecode.Name = "tbnamecode";
            this.tbnamecode.Size = new System.Drawing.Size(260, 26);
            this.tbnamecode.TabIndex = 1;
            this.tbnamecode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnamecode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.btnUpdate.Location = new System.Drawing.Point(565, 382);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(257, 59);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.btnDel.Location = new System.Drawing.Point(565, 447);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(257, 59);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.btnNew.Location = new System.Drawing.Point(565, 317);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(257, 59);
            this.btnNew.TabIndex = 28;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Number
            // 
            this.Number.Text = "No";
            this.Number.Width = 40;
            // 
            // code
            // 
            this.code.Text = "Code";
            this.code.Width = 200;
            // 
            // timestart
            // 
            this.timestart.Text = "Date start";
            this.timestart.Width = 180;
            // 
            // enddate
            // 
            this.enddate.Text = "Due date";
            this.enddate.Width = 180;
            // 
            // discount
            // 
            this.discount.Text = "Discount";
            this.discount.Width = 180;
            // 
            // lvcode
            // 
            this.lvcode.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lvcode.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.code,
            this.timestart,
            this.enddate,
            this.discount});
            this.lvcode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lvcode.FullRowSelect = true;
            this.lvcode.GridLines = true;
            this.lvcode.HideSelection = false;
            this.lvcode.Location = new System.Drawing.Point(34, 25);
            this.lvcode.Margin = new System.Windows.Forms.Padding(2);
            this.lvcode.Name = "lvcode";
            this.lvcode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvcode.Size = new System.Drawing.Size(788, 269);
            this.lvcode.TabIndex = 30;
            this.lvcode.UseCompatibleStateImageBehavior = false;
            this.lvcode.View = System.Windows.Forms.View.Details;
            this.lvcode.SelectedIndexChanged += new System.EventHandler(this.lvcode_SelectedIndexChanged);
            // 
            // UCpromotioncode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lvcode);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.gBdetail);
            this.Controls.Add(this.btnUpdate);
            this.Name = "UCpromotioncode";
            this.Size = new System.Drawing.Size(840, 540);
            this.gBdetail.ResumeLayout(false);
            this.gBdetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericdiscount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBdetail;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker duedate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datestart;
        private System.Windows.Forms.TextBox tbnamecode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericdiscount;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader code;
        private System.Windows.Forms.ColumnHeader timestart;
        private System.Windows.Forms.ColumnHeader enddate;
        private System.Windows.Forms.ColumnHeader discount;
        private System.Windows.Forms.ListView lvcode;
        private System.Windows.Forms.NumericUpDown numTimes;
        private System.Windows.Forms.Label label5;
    }
}
