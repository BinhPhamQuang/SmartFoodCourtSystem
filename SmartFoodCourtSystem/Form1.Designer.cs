namespace SmartFoodCourtSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.bntPaymentMethod = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCart = new System.Windows.Forms.Button();
            this.bntMenu = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_uc = new System.Windows.Forms.Panel();
            this.userControl_Home1 = new SmartFoodCourtSystem.UserControl_Home();
            this.uC_cart1 = new SmartFoodCourtSystem.UC_cart();
            this.uC_payment1 = new SmartFoodCourtSystem.UC_payment();
            this.userControl1_Menu1 = new SmartFoodCourtSystem.UserControl1_Menu();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pn_uc.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnDelivery);
            this.panel1.Controls.Add(this.bntPaymentMethod);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCart);
            this.panel1.Controls.Add(this.bntMenu);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 690);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.Location = new System.Drawing.Point(214, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(21, 691);
            this.panel6.TabIndex = 11;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SidePanel.Location = new System.Drawing.Point(204, 63);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 80);
            this.SidePanel.TabIndex = 3;
            this.SidePanel.Visible = false;
            this.SidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SidePanel_Paint);
            // 
            // btnDelivery
            // 
            this.btnDelivery.FlatAppearance.BorderSize = 0;
            this.btnDelivery.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelivery.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnDelivery.ForeColor = System.Drawing.Color.White;
            this.btnDelivery.Image = ((System.Drawing.Image)(resources.GetObject("btnDelivery.Image")));
            this.btnDelivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelivery.Location = new System.Drawing.Point(0, 420);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(220, 80);
            this.btnDelivery.TabIndex = 5;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.UseVisualStyleBackColor = true;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // bntPaymentMethod
            // 
            this.bntPaymentMethod.FlatAppearance.BorderSize = 0;
            this.bntPaymentMethod.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bntPaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntPaymentMethod.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.bntPaymentMethod.ForeColor = System.Drawing.Color.White;
            this.bntPaymentMethod.Image = global::SmartFoodCourtSystem.Properties.Resources.money;
            this.bntPaymentMethod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntPaymentMethod.Location = new System.Drawing.Point(0, 328);
            this.bntPaymentMethod.Name = "bntPaymentMethod";
            this.bntPaymentMethod.Size = new System.Drawing.Size(220, 80);
            this.bntPaymentMethod.TabIndex = 4;
            this.bntPaymentMethod.Text = "Payment method";
            this.bntPaymentMethod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntPaymentMethod.UseVisualStyleBackColor = true;
            this.bntPaymentMethod.Click += new System.EventHandler(this.bntPaymentMethod_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 668);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Version 1.0";
            // 
            // btnCart
            // 
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Location = new System.Drawing.Point(0, 237);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(220, 80);
            this.btnCart.TabIndex = 2;
            this.btnCart.Text = "Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // bntMenu
            // 
            this.bntMenu.FlatAppearance.BorderSize = 0;
            this.bntMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bntMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMenu.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.bntMenu.ForeColor = System.Drawing.Color.White;
            this.bntMenu.Image = ((System.Drawing.Image)(resources.GetObject("bntMenu.Image")));
            this.bntMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntMenu.Location = new System.Drawing.Point(2, 149);
            this.bntMenu.Name = "bntMenu";
            this.bntMenu.Size = new System.Drawing.Size(220, 80);
            this.bntMenu.TabIndex = 1;
            this.bntMenu.Text = "Menu";
            this.bntMenu.UseVisualStyleBackColor = true;
            this.bntMenu.Click += new System.EventHandler(this.bntMenu_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Gray;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 14.75F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(2, 63);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(220, 80);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(241, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 153);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "restaurant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hippo Town";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pn_uc
            // 
            this.pn_uc.Controls.Add(this.userControl_Home1);
            this.pn_uc.Controls.Add(this.uC_cart1);
            this.pn_uc.Controls.Add(this.uC_payment1);
            this.pn_uc.Controls.Add(this.userControl1_Menu1);
            this.pn_uc.Location = new System.Drawing.Point(219, 177);
            this.pn_uc.Name = "pn_uc";
            this.pn_uc.Size = new System.Drawing.Size(1020, 490);
            this.pn_uc.TabIndex = 8;
            // 
            // userControl_Home1
            // 
            this.userControl_Home1.BackColor = System.Drawing.Color.White;
            this.userControl_Home1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Home1.Margin = new System.Windows.Forms.Padding(4);
            this.userControl_Home1.Name = "userControl_Home1";
            this.userControl_Home1.Size = new System.Drawing.Size(1016, 490);
            this.userControl_Home1.TabIndex = 3;
            this.userControl_Home1.Load += new System.EventHandler(this.userControl_Home1_Load);
            // 
            // uC_cart1
            // 
            this.uC_cart1.BackColor = System.Drawing.Color.White;
            this.uC_cart1.Location = new System.Drawing.Point(0, 0);
            this.uC_cart1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_cart1.Name = "uC_cart1";
            this.uC_cart1.Size = new System.Drawing.Size(1020, 490);
            this.uC_cart1.TabIndex = 2;
            // 
            // uC_payment1
            // 
            this.uC_payment1.Location = new System.Drawing.Point(0, 0);
            this.uC_payment1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_payment1.Name = "uC_payment1";
            this.uC_payment1.Size = new System.Drawing.Size(1020, 490);
            this.uC_payment1.TabIndex = 4;
            // 
            // userControl1_Menu1
            // 
            this.userControl1_Menu1.Location = new System.Drawing.Point(0, 0);
            this.userControl1_Menu1.Name = "userControl1_Menu1";
            this.userControl1_Menu1.Size = new System.Drawing.Size(1020, 490);
            this.userControl1_Menu1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.btnMail);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(219, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 35);
            this.panel2.TabIndex = 1;
            // 
            // btnMail
            // 
            this.btnMail.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMail.FlatAppearance.BorderSize = 0;
            this.btnMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMail.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMail.ForeColor = System.Drawing.Color.Transparent;
            this.btnMail.Image = ((System.Drawing.Image)(resources.GetObject("btnMail.Image")));
            this.btnMail.Location = new System.Drawing.Point(940, 3);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(35, 28);
            this.btnMail.TabIndex = 7;
            this.btnMail.UseVisualStyleBackColor = false;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(981, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 28);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(219, 685);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1015, 5);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1234, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 655);
            this.panel5.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(219, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1020, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 690);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pn_uc);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pn_uc.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button bntMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntPaymentMethod;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel pn_uc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private UC_cart uC_cart1;
         
        private UC_payment uC_payment1;
        private UserControl1_Menu userControl1_Menu1;
        private UserControl_Home userControl_Home1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}

