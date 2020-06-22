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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ManEmail = new System.Windows.Forms.Label();
            this.ManName = new System.Windows.Forms.Label();
            this.ManAva = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ManAva)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 590);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 50);
            this.panel2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(94)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 50);
            this.panel1.TabIndex = 15;
            // 
            // ManEmail
            // 
            this.ManEmail.AutoSize = true;
            this.ManEmail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManEmail.Location = new System.Drawing.Point(353, 321);
            this.ManEmail.Name = "ManEmail";
            this.ManEmail.Size = new System.Drawing.Size(146, 16);
            this.ManEmail.TabIndex = 14;
            this.ManEmail.Text = "manager@hcmut.edu.vn";
            // 
            // ManName
            // 
            this.ManName.AutoSize = true;
            this.ManName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManName.Location = new System.Drawing.Point(387, 302);
            this.ManName.Name = "ManName";
            this.ManName.Size = new System.Drawing.Size(81, 19);
            this.ManName.TabIndex = 12;
            this.ManName.Text = "Manager";
            // 
            // ManAva
            // 
            this.ManAva.BackColor = System.Drawing.Color.White;
            this.ManAva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManAva.Image = ((System.Drawing.Image)(resources.GetObject("ManAva.Image")));
            this.ManAva.Location = new System.Drawing.Point(377, 199);
            this.ManAva.Name = "ManAva";
            this.ManAva.Size = new System.Drawing.Size(100, 100);
            this.ManAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ManAva.TabIndex = 13;
            this.ManAva.TabStop = false;
            // 
            // UCManMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ManEmail);
            this.Controls.Add(this.ManName);
            this.Controls.Add(this.ManAva);
            this.DoubleBuffered = true;
            this.Name = "UCManMain";
            this.Size = new System.Drawing.Size(840, 640);
            ((System.ComponentModel.ISupportInitialize)(this.ManAva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ManEmail;
        private System.Windows.Forms.Label ManName;
        private System.Windows.Forms.PictureBox ManAva;
    }
}
