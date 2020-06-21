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
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cart";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.lbPrice);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Location = new System.Drawing.Point(713, 351);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(508, 70);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(155, 54);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 2);
            this.panel2.TabIndex = 5;
            // 
            // lbPrice
            // 
            this.lbPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbPrice.Location = new System.Drawing.Point(149, 22);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(325, 28);
            this.lbPrice.TabIndex = 21;
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPrice.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel7.Location = new System.Drawing.Point(155, 48);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(307, 2);
            this.panel7.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(4, 20);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(140, 28);
            this.label17.TabIndex = 20;
            this.label17.Text = "Total price:";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOrder.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(713, 492);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(508, 44);
            this.btnOrder.TabIndex = 22;
            this.btnOrder.Text = "Cancel order";
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPayment.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(713, 442);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(508, 43);
            this.btnPayment.TabIndex = 21;
            this.btnPayment.Text = "Make payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tbPromotioncode);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.label20);
            this.panel8.Location = new System.Drawing.Point(713, 177);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(508, 70);
            this.panel8.TabIndex = 22;
            // 
            // tbPromotioncode
            // 
            this.tbPromotioncode.BackColor = System.Drawing.Color.White;
            this.tbPromotioncode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPromotioncode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPromotioncode.Location = new System.Drawing.Point(228, 17);
            this.tbPromotioncode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPromotioncode.Name = "tbPromotioncode";
            this.tbPromotioncode.Size = new System.Drawing.Size(247, 25);
            this.tbPromotioncode.TabIndex = 21;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel9.Location = new System.Drawing.Point(228, 47);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(247, 2);
            this.panel9.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(4, 21);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(203, 28);
            this.label20.TabIndex = 20;
            this.label20.Text = "Promotion code:";
            // 
            // btnApplyPromotioncode
            // 
            this.btnApplyPromotioncode.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnApplyPromotioncode.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnApplyPromotioncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyPromotioncode.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyPromotioncode.ForeColor = System.Drawing.Color.White;
            this.btnApplyPromotioncode.Location = new System.Drawing.Point(713, 266);
            this.btnApplyPromotioncode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApplyPromotioncode.Name = "btnApplyPromotioncode";
            this.btnApplyPromotioncode.Size = new System.Drawing.Size(508, 43);
            this.btnApplyPromotioncode.TabIndex = 23;
            this.btnApplyPromotioncode.Text = "Apply";
            this.btnApplyPromotioncode.UseVisualStyleBackColor = false;
            // 
            // flp_cart
            // 
            this.flp_cart.AutoScroll = true;
            this.flp_cart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.flp_cart.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flp_cart.Location = new System.Drawing.Point(81, 84);
            this.flp_cart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flp_cart.Name = "flp_cart";
            this.flp_cart.Size = new System.Drawing.Size(589, 458);
            this.flp_cart.TabIndex = 24;
            // 
            // UC_cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flp_cart);
            this.Controls.Add(this.btnApplyPromotioncode);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_cart";
            this.Size = new System.Drawing.Size(1280, 565);
            this.Load += new System.EventHandler(this.UC_cart_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
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
    }
}
