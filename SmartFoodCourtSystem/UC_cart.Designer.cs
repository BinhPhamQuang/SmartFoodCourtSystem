namespace SmartFoodCourtSystem
{
    partial class UC_cart
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbPromotioncode = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.btnApplyPromotioncode = new System.Windows.Forms.Button();
            this.flp_cart = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.flp_cart.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cart";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.lbPrice);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Location = new System.Drawing.Point(582, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 57);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(116, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 2);
            this.panel2.TabIndex = 5;
            // 
            // lbPrice
            // 
            this.lbPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbPrice.Location = new System.Drawing.Point(112, 18);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(244, 23);
            this.lbPrice.TabIndex = 21;
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPrice.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel7.Location = new System.Drawing.Point(116, 39);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(230, 2);
            this.panel7.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(3, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 23);
            this.label17.TabIndex = 20;
            this.label17.Text = "Total price:";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Crimson;
            this.btnOrder.Location = new System.Drawing.Point(582, 400);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(381, 36);
            this.btnOrder.TabIndex = 22;
            this.btnOrder.Text = "Cancel order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPayment.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.Black;
            this.btnPayment.Location = new System.Drawing.Point(582, 359);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(381, 35);
            this.btnPayment.TabIndex = 21;
            this.btnPayment.Text = "Make payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tbPromotioncode);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.label20);
            this.panel8.Location = new System.Drawing.Point(582, 144);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(381, 57);
            this.panel8.TabIndex = 22;
            // 
            // tbPromotioncode
            // 
            this.tbPromotioncode.BackColor = System.Drawing.Color.White;
            this.tbPromotioncode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPromotioncode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPromotioncode.Location = new System.Drawing.Point(171, 14);
            this.tbPromotioncode.Name = "tbPromotioncode";
            this.tbPromotioncode.Size = new System.Drawing.Size(185, 20);
            this.tbPromotioncode.TabIndex = 21;
            this.tbPromotioncode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPromotioncode_KeyPress);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel9.Location = new System.Drawing.Point(171, 38);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(185, 2);
            this.panel9.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(3, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(162, 23);
            this.label20.TabIndex = 20;
            this.label20.Text = "Promotion code:";
            // 
            // btnApplyPromotioncode
            // 
            this.btnApplyPromotioncode.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnApplyPromotioncode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnApplyPromotioncode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnApplyPromotioncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyPromotioncode.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyPromotioncode.ForeColor = System.Drawing.Color.Black;
            this.btnApplyPromotioncode.Location = new System.Drawing.Point(582, 216);
            this.btnApplyPromotioncode.Name = "btnApplyPromotioncode";
            this.btnApplyPromotioncode.Size = new System.Drawing.Size(381, 35);
            this.btnApplyPromotioncode.TabIndex = 23;
            this.btnApplyPromotioncode.Text = "Apply";
            this.btnApplyPromotioncode.UseVisualStyleBackColor = false;
            this.btnApplyPromotioncode.Click += new System.EventHandler(this.btnApplyPromotioncode_Click);
            // 
            // flp_cart
            // 
            this.flp_cart.AutoScroll = true;
            this.flp_cart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.flp_cart.Controls.Add(this.panel1);
            this.flp_cart.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flp_cart.Location = new System.Drawing.Point(61, 68);
            this.flp_cart.Name = "flp_cart";
            this.flp_cart.Size = new System.Drawing.Size(442, 368);
            this.flp_cart.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 146);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "50";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // UC_cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flp_cart);
            this.Controls.Add(this.btnApplyPromotioncode);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Name = "UC_cart";
            this.Size = new System.Drawing.Size(1020, 490);
            this.Load += new System.EventHandler(this.UC_cart_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.flp_cart.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnApplyPromotioncode;
        private System.Windows.Forms.TextBox tbPromotioncode;
        private System.Windows.Forms.FlowLayoutPanel flp_cart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
