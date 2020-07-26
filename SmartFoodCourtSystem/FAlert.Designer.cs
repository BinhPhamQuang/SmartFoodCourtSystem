namespace SmartFoodCourtSystem
{
    partial class FAlert
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAlert));
            this.ptbcheck = new System.Windows.Forms.PictureBox();
            this.lbmsg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ptbsad = new System.Windows.Forms.PictureBox();
            this.ptbexclamation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbcheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbsad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbexclamation)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbcheck
            // 
            this.ptbcheck.Image = ((System.Drawing.Image)(resources.GetObject("ptbcheck.Image")));
            this.ptbcheck.Location = new System.Drawing.Point(12, 22);
            this.ptbcheck.Name = "ptbcheck";
            this.ptbcheck.Size = new System.Drawing.Size(32, 32);
            this.ptbcheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbcheck.TabIndex = 0;
            this.ptbcheck.TabStop = false;
            // 
            // lbmsg
            // 
            this.lbmsg.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmsg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbmsg.Location = new System.Drawing.Point(50, 22);
            this.lbmsg.Name = "lbmsg";
            this.lbmsg.Size = new System.Drawing.Size(246, 33);
            this.lbmsg.TabIndex = 1;
            this.lbmsg.Text = "Successfully";
            this.lbmsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbmsg.Click += new System.EventHandler(this.lbmsg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Location = new System.Drawing.Point(289, 18);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(40, 40);
            this.btnexit.TabIndex = 2;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ptbsad
            // 
            this.ptbsad.Image = ((System.Drawing.Image)(resources.GetObject("ptbsad.Image")));
            this.ptbsad.Location = new System.Drawing.Point(12, 22);
            this.ptbsad.Name = "ptbsad";
            this.ptbsad.Size = new System.Drawing.Size(32, 32);
            this.ptbsad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbsad.TabIndex = 3;
            this.ptbsad.TabStop = false;
            // 
            // ptbexclamation
            // 
            this.ptbexclamation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ptbexclamation.Image = ((System.Drawing.Image)(resources.GetObject("ptbexclamation.Image")));
            this.ptbexclamation.Location = new System.Drawing.Point(12, 22);
            this.ptbexclamation.Name = "ptbexclamation";
            this.ptbexclamation.Size = new System.Drawing.Size(32, 32);
            this.ptbexclamation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbexclamation.TabIndex = 4;
            this.ptbexclamation.TabStop = false;
            // 
            // FAlert
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(332, 74);
            this.Controls.Add(this.ptbexclamation);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lbmsg);
            this.Controls.Add(this.ptbcheck);
            this.Controls.Add(this.ptbsad);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAlert";
            this.Opacity = 0.2D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FAlert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbcheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbsad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbexclamation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbcheck;
        private System.Windows.Forms.Label lbmsg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.PictureBox ptbsad;
        internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ptbexclamation;
    }
}