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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnManHome = new System.Windows.Forms.Button();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.btnEditMenu = new System.Windows.Forms.Button();
            this.ucManMain1 = new SmartFoodCourtSystem.UCManMain();
            this.ucManMenu1 = new SmartFoodCourtSystem.UCManMenu();
            this.ucManStaff1 = new SmartFoodCourtSystem.UCManStaff();
            this.ucReport1 = new SmartFoodCourtSystem.UCReport();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.btnViewReport);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnManHome);
            this.panel1.Controls.Add(this.btnEditStaff);
            this.panel1.Controls.Add(this.btnEditMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 450);
            this.panel1.TabIndex = 13;
            // 
            // btnViewReport
            // 
            this.btnViewReport.BackColor = System.Drawing.Color.Orange;
            this.btnViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReport.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnViewReport.Location = new System.Drawing.Point(0, 270);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(190, 90);
            this.btnViewReport.TabIndex = 14;
            this.btnViewReport.Text = "View report";
            this.btnViewReport.UseVisualStyleBackColor = false;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Orange;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLogOut.Location = new System.Drawing.Point(0, 360);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(190, 90);
            this.btnLogOut.TabIndex = 13;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // btnManHome
            // 
            this.btnManHome.BackColor = System.Drawing.Color.Orange;
            this.btnManHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManHome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnManHome.Location = new System.Drawing.Point(0, 0);
            this.btnManHome.Name = "btnManHome";
            this.btnManHome.Size = new System.Drawing.Size(190, 90);
            this.btnManHome.TabIndex = 12;
            this.btnManHome.Text = "Home";
            this.btnManHome.UseVisualStyleBackColor = false;
            this.btnManHome.Click += new System.EventHandler(this.btnManHome_Click);
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.BackColor = System.Drawing.Color.Orange;
            this.btnEditStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStaff.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditStaff.Location = new System.Drawing.Point(0, 180);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(190, 90);
            this.btnEditStaff.TabIndex = 11;
            this.btnEditStaff.Text = "Edit Staff";
            this.btnEditStaff.UseVisualStyleBackColor = false;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click_1);
            // 
            // btnEditMenu
            // 
            this.btnEditMenu.BackColor = System.Drawing.Color.Orange;
            this.btnEditMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMenu.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditMenu.Location = new System.Drawing.Point(0, 90);
            this.btnEditMenu.Name = "btnEditMenu";
            this.btnEditMenu.Size = new System.Drawing.Size(190, 90);
            this.btnEditMenu.TabIndex = 9;
            this.btnEditMenu.Text = "Edit Menu";
            this.btnEditMenu.UseVisualStyleBackColor = false;
            this.btnEditMenu.Click += new System.EventHandler(this.btnEditMenu_Click_1);
            // 
            // ucManMain1
            // 
            this.ucManMain1.BackColor = System.Drawing.Color.White;
            this.ucManMain1.Location = new System.Drawing.Point(190, 0);
            this.ucManMain1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucManMain1.Name = "ucManMain1";
            this.ucManMain1.Size = new System.Drawing.Size(710, 450);
            this.ucManMain1.TabIndex = 14;
            this.ucManMain1.Load += new System.EventHandler(this.ucManMain1_Load);
            // 
            // ucManMenu1
            // 
            this.ucManMenu1.AutoScroll = true;
            this.ucManMenu1.BackColor = System.Drawing.Color.White;
            this.ucManMenu1.Location = new System.Drawing.Point(190, 50);
            this.ucManMenu1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucManMenu1.Name = "ucManMenu1";
            this.ucManMenu1.Size = new System.Drawing.Size(710, 350);
            this.ucManMenu1.TabIndex = 15;
            // 
            // ucManStaff1
            // 
            this.ucManStaff1.AutoScroll = true;
            this.ucManStaff1.BackColor = System.Drawing.Color.White;
            this.ucManStaff1.Location = new System.Drawing.Point(190, 50);
            this.ucManStaff1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucManStaff1.Name = "ucManStaff1";
            this.ucManStaff1.Size = new System.Drawing.Size(710, 350);
            this.ucManStaff1.TabIndex = 16;
            // 
            // ucReport1
            // 
            this.ucReport1.BackColor = System.Drawing.Color.White;
            this.ucReport1.Location = new System.Drawing.Point(190, 50);
            this.ucReport1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucReport1.Name = "ucReport1";
            this.ucReport1.Size = new System.Drawing.Size(710, 350);
            this.ucReport1.TabIndex = 17;
            // 
            // FManMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.ucManMain1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucReport1);
            this.Controls.Add(this.ucManStaff1);
            this.Controls.Add(this.ucManMenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FManMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FManMain";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnManHome;
        private System.Windows.Forms.Button btnEditStaff;
        private System.Windows.Forms.Button btnEditMenu;
        private UCManMain ucManMain1;
        private UCManMenu ucManMenu1;
        private UCManStaff ucManStaff1;
        private UCReport ucReport1;
    }
}