namespace SmartFoodCourtSystem
{
    partial class UCManMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCManMain));
            this.ManEmail = new System.Windows.Forms.Label();
            this.ManName = new System.Windows.Forms.Label();
            this.ManAva = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ManAva)).BeginInit();
            this.SuspendLayout();
            // 
            // ManEmail
            // 
            this.ManEmail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManEmail.Location = new System.Drawing.Point(355, 339);
            this.ManEmail.Name = "ManEmail";
            this.ManEmail.Size = new System.Drawing.Size(146, 16);
            this.ManEmail.TabIndex = 14;
            this.ManEmail.Text = "manager@hcmut.edu.vn";
            this.ManEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManName
            // 
            this.ManName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManName.Location = new System.Drawing.Point(263, 302);
            this.ManName.Name = "ManName";
            this.ManName.Size = new System.Drawing.Size(328, 45);
            this.ManName.TabIndex = 12;
            this.ManName.Text = "Manager";
            this.ManName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManAva
            // 
            this.ManAva.BackColor = System.Drawing.Color.White;
            this.ManAva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManAva.Image = ((System.Drawing.Image)(resources.GetObject("ManAva.Image")));
            this.ManAva.Location = new System.Drawing.Point(375, 199);
            this.ManAva.Name = "ManAva";
            this.ManAva.Size = new System.Drawing.Size(105, 100);
            this.ManAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ManAva.TabIndex = 13;
            this.ManAva.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 600);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 40);
            this.panel2.TabIndex = 16;
            // 
            // UCManMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ManEmail);
            this.Controls.Add(this.ManName);
            this.Controls.Add(this.ManAva);
            this.DoubleBuffered = true;
            this.Name = "UCManMain";
            this.Size = new System.Drawing.Size(840, 640);
            this.Load += new System.EventHandler(this.UCManMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManAva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ManEmail;
        private System.Windows.Forms.Label ManName;
        private System.Windows.Forms.PictureBox ManAva;
        private System.Windows.Forms.Panel panel2;
    }
}
