namespace YurtOtomasyonu
{
    partial class SecimFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecimFormu));
            this.Ytngrs = new DevExpress.XtraEditors.SimpleButton();
            this.Ogrnbtn = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // Ytngrs
            // 
            this.Ytngrs.Appearance.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ytngrs.Appearance.Options.UseFont = true;
            this.Ytngrs.Location = new System.Drawing.Point(77, 54);
            this.Ytngrs.Name = "Ytngrs";
            this.Ytngrs.Size = new System.Drawing.Size(268, 46);
            this.Ytngrs.TabIndex = 0;
            this.Ytngrs.Text = "Yönetim Girişi";
            this.Ytngrs.Click += new System.EventHandler(this.Ytngrs_Click);
            // 
            // Ogrnbtn
            // 
            this.Ogrnbtn.Appearance.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ogrnbtn.Appearance.Options.UseFont = true;
            this.Ogrnbtn.Location = new System.Drawing.Point(77, 126);
            this.Ogrnbtn.Name = "Ogrnbtn";
            this.Ogrnbtn.Size = new System.Drawing.Size(268, 46);
            this.Ogrnbtn.TabIndex = 1;
            this.Ogrnbtn.Text = "Öğrenci Girişi";
            this.Ogrnbtn.Click += new System.EventHandler(this.Ogrnbtn_Click);
            // 
            // SecimFormu
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 241);
            this.Controls.Add(this.Ogrnbtn);
            this.Controls.Add(this.Ytngrs);
            this.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SecimFormu";
            this.Text = "Secimformu";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Ytngrs;
        private DevExpress.XtraEditors.SimpleButton Ogrnbtn;
    }
}