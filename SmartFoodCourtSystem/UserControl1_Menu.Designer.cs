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
            this.tb_searchfood = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnDrink = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flp_menu = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_search = new System.Windows.Forms.Button();
            this.ptb_clear = new System.Windows.Forms.PictureBox();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_clear)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_searchfood
            // 
            this.tb_searchfood.BackColor = System.Drawing.Color.White;
            this.tb_searchfood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_searchfood.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchfood.ForeColor = System.Drawing.Color.Gray;
            this.tb_searchfood.Location = new System.Drawing.Point(167, 25);
            this.tb_searchfood.Margin = new System.Windows.Forms.Padding(4);
            this.tb_searchfood.Name = "tb_searchfood";
            this.tb_searchfood.Size = new System.Drawing.Size(291, 25);
            this.tb_searchfood.TabIndex = 14;
            this.tb_searchfood.Text = "Seach food";
            this.tb_searchfood.Enter += new System.EventHandler(this.tb_searchfood_Enter);
            this.tb_searchfood.Leave += new System.EventHandler(this.tb_searchfood_Leave);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnDrink);
            this.panel9.Controls.Add(this.btnFood);
            this.panel9.Controls.Add(this.label19);
            this.panel9.Location = new System.Drawing.Point(883, 18);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(379, 44);
            this.panel9.TabIndex = 16;
            // 
            // btnDrink
            // 
            this.btnDrink.BackColor = System.Drawing.Color.White;
            this.btnDrink.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrink.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrink.ForeColor = System.Drawing.Color.Black;
            this.btnDrink.Location = new System.Drawing.Point(255, 4);
            this.btnDrink.Margin = new System.Windows.Forms.Padding(4);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(115, 30);
            this.btnDrink.TabIndex = 2;
            this.btnDrink.Text = "Drink";
            this.btnDrink.UseVisualStyleBackColor = false;
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFood.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.ForeColor = System.Drawing.Color.White;
            this.btnFood.Location = new System.Drawing.Point(132, 4);
            this.btnFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(115, 30);
            this.btnFood.TabIndex = 1;
            this.btnFood.Text = "Food";
            this.btnFood.UseVisualStyleBackColor = false;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(7, 9);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 23);
            this.label19.TabIndex = 0;
            this.label19.Text = "Sorted by:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(167, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 4);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 47);
            this.label1.TabIndex = 13;
            this.label1.Text = "Menu";
            // 
            // flp_menu
            // 
            this.flp_menu.AutoScroll = true;
            this.flp_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flp_menu.Location = new System.Drawing.Point(140, 82);
            this.flp_menu.Margin = new System.Windows.Forms.Padding(4);
            this.flp_menu.Name = "flp_menu";
            this.flp_menu.Size = new System.Drawing.Size(1080, 464);
            this.flp_menu.TabIndex = 17;
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Image = global::SmartFoodCourtSystem.Properties.Resources.search1;
            this.btn_search.Location = new System.Drawing.Point(464, 22);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(52, 40);
            this.btn_search.TabIndex = 15;
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // ptb_clear
            // 
            this.ptb_clear.Image = ((System.Drawing.Image)(resources.GetObject("ptb_clear.Image")));
            this.ptb_clear.Location = new System.Drawing.Point(435, 34);
            this.ptb_clear.Margin = new System.Windows.Forms.Padding(4);
            this.ptb_clear.Name = "ptb_clear";
            this.ptb_clear.Size = new System.Drawing.Size(23, 15);
            this.ptb_clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_clear.TabIndex = 18;
            this.ptb_clear.TabStop = false;
            this.ptb_clear.Visible = false;
            // 
            // UserControl1_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tb_searchfood);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptb_clear);
            this.Controls.Add(this.flp_menu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl1_Menu";
            this.Size = new System.Drawing.Size(1280, 565);
            this.Load += new System.EventHandler(this.UserControl1_Menu_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_clear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_searchfood;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptb_clear;
        private System.Windows.Forms.FlowLayoutPanel flp_menu;
    }
}
