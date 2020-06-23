namespace SmartFoodCourtSystem
{
    partial class UCMomo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMomo));
            this.wbMono = new System.Windows.Forms.WebBrowser();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wbMono
            // 
            this.wbMono.Location = new System.Drawing.Point(-4, -67);
            this.wbMono.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMono.Name = "wbMono";
            this.wbMono.ScriptErrorsSuppressed = true;
            this.wbMono.ScrollBarsEnabled = false;
            this.wbMono.Size = new System.Drawing.Size(964, 533);
            this.wbMono.TabIndex = 0;
            this.wbMono.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbMono_DocumentCompleted);
            this.wbMono.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wbMono_Navigated);
            // 
            // btncancel
            // 
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.Location = new System.Drawing.Point(3, 3);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(43, 40);
            this.btncancel.TabIndex = 1;
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // UCMomo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.wbMono);
            this.Name = "UCMomo";
            this.Size = new System.Drawing.Size(960, 469);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbMono;
        private System.Windows.Forms.Button btncancel;
    }
}
