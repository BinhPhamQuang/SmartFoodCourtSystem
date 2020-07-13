namespace SmartFoodCourtSystem
{
    partial class ViewOrderList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DisplayMode = new System.Windows.Forms.Label();
            this.ListOfOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.DisplayMode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 65);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "In Queue",
            "Processing",
            "Finished"});
            this.comboBox1.Location = new System.Drawing.Point(251, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 31);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // DisplayMode
            // 
            this.DisplayMode.AutoSize = true;
            this.DisplayMode.Location = new System.Drawing.Point(96, 20);
            this.DisplayMode.Name = "DisplayMode";
            this.DisplayMode.Size = new System.Drawing.Size(132, 23);
            this.DisplayMode.TabIndex = 0;
            this.DisplayMode.Text = "DisplayMode";
            // 
            // ListOfOrder
            // 
            this.ListOfOrder.AutoScroll = true;
            this.ListOfOrder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ListOfOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListOfOrder.Location = new System.Drawing.Point(0, 65);
            this.ListOfOrder.Name = "ListOfOrder";
            this.ListOfOrder.Size = new System.Drawing.Size(834, 416);
            this.ListOfOrder.TabIndex = 1;
            // 
            // ViewOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListOfOrder);
            this.Controls.Add(this.panel1);
            this.Name = "ViewOrderList";
            this.Size = new System.Drawing.Size(834, 481);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label DisplayMode;
        private System.Windows.Forms.FlowLayoutPanel ListOfOrder;
    }
}
