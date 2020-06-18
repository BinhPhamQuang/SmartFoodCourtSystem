namespace SmartFoodCourtSystem
{
    partial class FManMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FManMain));
            this.ManAva = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ManEmail = new System.Windows.Forms.Label();
            this.ManName = new System.Windows.Forms.Label();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnEditMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ManAva)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManAva
            // 
            this.ManAva.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ManAva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManAva.Image = ((System.Drawing.Image)(resources.GetObject("ManAva.Image")));
            this.ManAva.Location = new System.Drawing.Point(50, 12);
            this.ManAva.Name = "ManAva";
            this.ManAva.Size = new System.Drawing.Size(100, 100);
            this.ManAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ManAva.TabIndex = 5;
            this.ManAva.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.ManEmail);
            this.panel1.Controls.Add(this.ManName);
            this.panel1.Controls.Add(this.ManAva);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 388);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ManEmail
            // 
            this.ManEmail.AutoSize = true;
            this.ManEmail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManEmail.Location = new System.Drawing.Point(12, 134);
            this.ManEmail.Name = "ManEmail";
            this.ManEmail.Size = new System.Drawing.Size(168, 16);
            this.ManEmail.TabIndex = 6;
            this.ManEmail.Text = "nguyenvana@hcmut.edu.vn";
            // 
            // ManName
            // 
            this.ManName.AutoSize = true;
            this.ManName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManName.Location = new System.Drawing.Point(36, 115);
            this.ManName.Name = "ManName";
            this.ManName.Size = new System.Drawing.Size(123, 19);
            this.ManName.TabIndex = 5;
            this.ManName.Text = "Nguyen Van A";
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.BackColor = System.Drawing.Color.Orange;
            this.btnEditStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStaff.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditStaff.Location = new System.Drawing.Point(397, 215);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(141, 45);
            this.btnEditStaff.TabIndex = 11;
            this.btnEditStaff.Text = "Edit Staff";
            this.btnEditStaff.UseVisualStyleBackColor = false;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.BackColor = System.Drawing.Color.SandyBrown;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(697, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(31, 31);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnEditMenu
            // 
            this.btnEditMenu.BackColor = System.Drawing.Color.Orange;
            this.btnEditMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMenu.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditMenu.Location = new System.Drawing.Point(397, 145);
            this.btnEditMenu.Name = "btnEditMenu";
            this.btnEditMenu.Size = new System.Drawing.Size(141, 45);
            this.btnEditMenu.TabIndex = 9;
            this.btnEditMenu.Text = "Edit Menu";
            this.btnEditMenu.UseVisualStyleBackColor = false;
            this.btnEditMenu.Click += new System.EventHandler(this.btnEditMenu_Click);
            // 
            // FManMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(742, 388);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEditStaff);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnEditMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FManMain";
            this.Text = "FManMain";
            ((System.ComponentModel.ISupportInitialize)(this.ManAva)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ManAva;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ManEmail;
        private System.Windows.Forms.Label ManName;
        private System.Windows.Forms.Button btnEditStaff;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnEditMenu;
    }
}