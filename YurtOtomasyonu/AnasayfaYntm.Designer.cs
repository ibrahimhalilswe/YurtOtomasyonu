namespace YurtOtomasyonu
{
    partial class AnasayfaYntm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnasayfaYntm));
            this.labelTitle = new DevExpress.XtraEditors.LabelControl();
            this.labelDescription = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Appearance.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTitle.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelTitle.Appearance.Options.UseFont = true;
            this.labelTitle.Appearance.Options.UseForeColor = true;
            this.labelTitle.Location = new System.Drawing.Point(313, 196);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(501, 72);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Yönetim Ana Sayfa";
            // 
            // labelDescription
            // 
            this.labelDescription.Appearance.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDescription.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelDescription.Appearance.Options.UseFont = true;
            this.labelDescription.Appearance.Options.UseForeColor = true;
            this.labelDescription.Location = new System.Drawing.Point(150, 274);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(811, 40);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Yönetim işlemleri için menülerden seçim yapabilirsiniz.";
            // 
            // AnasayfaYntm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Center;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1201, 703);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "AnasayfaYntm";
            this.Text = "Yönetim Ana Sayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DevExpress.XtraEditors.LabelControl labelTitle;
        private DevExpress.XtraEditors.LabelControl labelDescription;

        #endregion
    }
}