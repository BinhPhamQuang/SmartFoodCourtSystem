namespace SmartFoodCourtSystem
{
    partial class UserControl1_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1_Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_searchfood = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.flp_menu = new System.Windows.Forms.FlowLayoutPanel();
            this.ptb_clear = new System.Windows.Forms.PictureBox();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_clear)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu";
            // 
            // tb_searchfood
            // 
            this.tb_searchfood.BackColor = System.Drawing.Color.White;
            this.tb_searchfood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_searchfood.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchfood.ForeColor = System.Drawing.Color.Gray;
            this.tb_searchfood.Location = new System.Drawing.Point(124, 21);
            this.tb_searchfood.Name = "tb_searchfood";
            this.tb_searchfood.Size = new System.Drawing.Size(218, 20);
            this.tb_searchfood.TabIndex = 6;
            this.tb_searchfood.Text = "Seach food";
            this.tb_searchfood.Enter += new System.EventHandler(this.tb_searchfood_Enter);
            this.tb_searchfood.Leave += new System.EventHandler(this.tb_searchfood_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(124, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 5);
            this.panel1.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(339, 26);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(36, 26);
            this.btn_search.TabIndex = 7;
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button8);
            this.panel9.Controls.Add(this.button7);
            this.panel9.Controls.Add(this.label19);
            this.panel9.Location = new System.Drawing.Point(661, 16);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(284, 36);
            this.panel9.TabIndex = 9;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(191, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(86, 24);
            this.button8.TabIndex = 2;
            this.button8.Text = "Newest";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(99, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 24);
            this.button7.TabIndex = 1;
            this.button7.Text = "Best-selling";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(5, 7);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 21);
            this.label19.TabIndex = 0;
            this.label19.Text = "Sorted by:";
            // 
            // flp_menu
            // 
            this.flp_menu.AutoScroll = true;
            this.flp_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flp_menu.Location = new System.Drawing.Point(60, 88);
            this.flp_menu.Name = "flp_menu";
            this.flp_menu.Size = new System.Drawing.Size(830, 358);
            this.flp_menu.TabIndex = 10;
            // 
            // ptb_clear
            // 
            this.ptb_clear.Image = ((System.Drawing.Image)(resources.GetObject("ptb_clear.Image")));
            this.ptb_clear.Location = new System.Drawing.Point(325, 29);
            this.ptb_clear.Name = "ptb_clear";
            this.ptb_clear.Size = new System.Drawing.Size(17, 12);
            this.ptb_clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_clear.TabIndex = 11;
            this.ptb_clear.TabStop = false;
            this.ptb_clear.Visible = false;
            this.ptb_clear.Click += new System.EventHandler(this.ptb_clear_Click);
            // 
            // UserControl1_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ptb_clear);
            this.Controls.Add(this.flp_menu);
            this.Controls.Add(this.tb_searchfood);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1_Menu";
            this.Size = new System.Drawing.Size(960, 459);
            this.Load += new System.EventHandler(this.UserControl1_Menu_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_clear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_searchfood;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.FlowLayoutPanel flp_menu;
        private System.Windows.Forms.PictureBox ptb_clear;
    }
}
