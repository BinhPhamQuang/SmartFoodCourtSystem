namespace SmartFoodCourtSystem
{
    partial class UserControl_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Home));
            this.btn_Ordernow = new System.Windows.Forms.Button();
            this.richTextBox_detailfoodinfo = new System.Windows.Forms.RichTextBox();
            this.lb_resource = new System.Windows.Forms.Label();
            this.lb_namefood = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picturebox1 = new System.Windows.Forms.PictureBox();
            this.lb_price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ordernow
            // 
            this.btn_Ordernow.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Ordernow.FlatAppearance.BorderSize = 0;
            this.btn_Ordernow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ordernow.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ordernow.ForeColor = System.Drawing.Color.White;
            this.btn_Ordernow.Location = new System.Drawing.Point(32, 338);
            this.btn_Ordernow.Name = "btn_Ordernow";
            this.btn_Ordernow.Size = new System.Drawing.Size(461, 50);
            this.btn_Ordernow.TabIndex = 13;
            this.btn_Ordernow.Text = "Order now";
            this.btn_Ordernow.UseVisualStyleBackColor = false;
            this.btn_Ordernow.Click += new System.EventHandler(this.btn_Ordernow_Click);
            // 
            // richTextBox_detailfoodinfo
            // 
            this.richTextBox_detailfoodinfo.BackColor = System.Drawing.Color.White;
            this.richTextBox_detailfoodinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_detailfoodinfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_detailfoodinfo.Location = new System.Drawing.Point(32, 267);
            this.richTextBox_detailfoodinfo.Name = "richTextBox_detailfoodinfo";
            this.richTextBox_detailfoodinfo.Size = new System.Drawing.Size(292, 110);
            this.richTextBox_detailfoodinfo.TabIndex = 12;
            this.richTextBox_detailfoodinfo.Text = "The best Vietnamese sandwich";
            // 
            // lb_resource
            // 
            this.lb_resource.AutoSize = true;
            this.lb_resource.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resource.Location = new System.Drawing.Point(26, 212);
            this.lb_resource.Name = "lb_resource";
            this.lb_resource.Size = new System.Drawing.Size(399, 33);
            this.lb_resource.TabIndex = 11;
            this.lb_resource.Text = "With onion,tomato and meat";
            // 
            // lb_namefood
            // 
            this.lb_namefood.AutoSize = true;
            this.lb_namefood.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_namefood.Location = new System.Drawing.Point(24, 165);
            this.lb_namefood.Name = "lb_namefood";
            this.lb_namefood.Size = new System.Drawing.Size(174, 47);
            this.lb_namefood.TabIndex = 10;
            this.lb_namefood.Text = "Banh Mi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Only";
            // 
            // picturebox1
            // 
            this.picturebox1.Image = ((System.Drawing.Image)(resources.GetObject("picturebox1.Image")));
            this.picturebox1.Location = new System.Drawing.Point(499, 70);
            this.picturebox1.Name = "picturebox1";
            this.picturebox1.Size = new System.Drawing.Size(444, 318);
            this.picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox1.TabIndex = 8;
            this.picturebox1.TabStop = false;
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Font = new System.Drawing.Font("Malgun Gothic", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_price.Location = new System.Drawing.Point(19, 91);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(326, 74);
            this.lb_price.TabIndex = 7;
            this.lb_price.Text = "25.000 vnd";
            // 
            // UserControl_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Ordernow);
            this.Controls.Add(this.richTextBox_detailfoodinfo);
            this.Controls.Add(this.lb_resource);
            this.Controls.Add(this.lb_namefood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picturebox1);
            this.Controls.Add(this.lb_price);
            this.Name = "UserControl_Home";
            this.Size = new System.Drawing.Size(960, 459);
            this.Load += new System.EventHandler(this.UserControl_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ordernow;
        private System.Windows.Forms.RichTextBox richTextBox_detailfoodinfo;
        private System.Windows.Forms.Label lb_resource;
        private System.Windows.Forms.Label lb_namefood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picturebox1;
        private System.Windows.Forms.Label lb_price;
    }
}
