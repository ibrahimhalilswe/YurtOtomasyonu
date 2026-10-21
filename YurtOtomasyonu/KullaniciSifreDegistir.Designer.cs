using DevExpress.XtraEditors;
using System;

namespace YurtOtomasyonu
{
    partial class KullaniciSifreDegistir
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
            this.labelControlKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            this.labelControlEskiSifre = new DevExpress.XtraEditors.LabelControl();
            this.labelControlYeniSifre = new DevExpress.XtraEditors.LabelControl();
            this.labelControlYeniSifreTekrar = new DevExpress.XtraEditors.LabelControl();
            this.textEditKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.textEditEskiSifre = new DevExpress.XtraEditors.TextEdit();
            this.textEditYeniSifre = new DevExpress.XtraEditors.TextEdit();
            this.textEditYeniSifreTekrar = new DevExpress.XtraEditors.TextEdit();
            this.btnSifreDegistir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEskiSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditYeniSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditYeniSifreTekrar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlKullaniciAdi
            // 
            this.labelControlKullaniciAdi.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelControlKullaniciAdi.Appearance.Options.UseFont = true;
            this.labelControlKullaniciAdi.Location = new System.Drawing.Point(40, 50);
            this.labelControlKullaniciAdi.Name = "labelControlKullaniciAdi";
            this.labelControlKullaniciAdi.Size = new System.Drawing.Size(117, 24);
            this.labelControlKullaniciAdi.TabIndex = 0;
            this.labelControlKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // labelControlEskiSifre
            // 
            this.labelControlEskiSifre.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelControlEskiSifre.Appearance.Options.UseFont = true;
            this.labelControlEskiSifre.Location = new System.Drawing.Point(40, 90);
            this.labelControlEskiSifre.Name = "labelControlEskiSifre";
            this.labelControlEskiSifre.Size = new System.Drawing.Size(91, 24);
            this.labelControlEskiSifre.TabIndex = 2;
            this.labelControlEskiSifre.Text = "Eski Şifre:";
            // 
            // labelControlYeniSifre
            // 
            this.labelControlYeniSifre.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelControlYeniSifre.Appearance.Options.UseFont = true;
            this.labelControlYeniSifre.Location = new System.Drawing.Point(40, 130);
            this.labelControlYeniSifre.Name = "labelControlYeniSifre";
            this.labelControlYeniSifre.Size = new System.Drawing.Size(90, 24);
            this.labelControlYeniSifre.TabIndex = 4;
            this.labelControlYeniSifre.Text = "Yeni Şifre:";
            // 
            // labelControlYeniSifreTekrar
            // 
            this.labelControlYeniSifreTekrar.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelControlYeniSifreTekrar.Appearance.Options.UseFont = true;
            this.labelControlYeniSifreTekrar.Location = new System.Drawing.Point(40, 170);
            this.labelControlYeniSifreTekrar.Name = "labelControlYeniSifreTekrar";
            this.labelControlYeniSifreTekrar.Size = new System.Drawing.Size(156, 24);
            this.labelControlYeniSifreTekrar.TabIndex = 6;
            this.labelControlYeniSifreTekrar.Text = "Yeni Şifre Tekrar:";
            // 
            // textEditKullaniciAdi
            // 
            this.textEditKullaniciAdi.Location = new System.Drawing.Point(215, 46);
            this.textEditKullaniciAdi.Name = "textEditKullaniciAdi";
            this.textEditKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textEditKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.textEditKullaniciAdi.Size = new System.Drawing.Size(300, 30);
            this.textEditKullaniciAdi.TabIndex = 1;
            // 
            // textEditEskiSifre
            // 
            this.textEditEskiSifre.Location = new System.Drawing.Point(215, 86);
            this.textEditEskiSifre.Name = "textEditEskiSifre";
            this.textEditEskiSifre.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textEditEskiSifre.Properties.Appearance.Options.UseFont = true;
            this.textEditEskiSifre.Properties.PasswordChar = '●';
            this.textEditEskiSifre.Size = new System.Drawing.Size(300, 30);
            this.textEditEskiSifre.TabIndex = 3;
            // 
            // textEditYeniSifre
            // 
            this.textEditYeniSifre.Location = new System.Drawing.Point(215, 126);
            this.textEditYeniSifre.Name = "textEditYeniSifre";
            this.textEditYeniSifre.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textEditYeniSifre.Properties.Appearance.Options.UseFont = true;
            this.textEditYeniSifre.Properties.PasswordChar = '●';
            this.textEditYeniSifre.Size = new System.Drawing.Size(300, 30);
            this.textEditYeniSifre.TabIndex = 5;
            // 
            // textEditYeniSifreTekrar
            // 
            this.textEditYeniSifreTekrar.Location = new System.Drawing.Point(215, 166);
            this.textEditYeniSifreTekrar.Name = "textEditYeniSifreTekrar";
            this.textEditYeniSifreTekrar.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textEditYeniSifreTekrar.Properties.Appearance.Options.UseFont = true;
            this.textEditYeniSifreTekrar.Properties.PasswordChar = '●';
            this.textEditYeniSifreTekrar.Size = new System.Drawing.Size(300, 30);
            this.textEditYeniSifreTekrar.TabIndex = 7;
            // 
            // btnSifreDegistir
            // 
            this.btnSifreDegistir.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnSifreDegistir.Appearance.Options.UseFont = true;
            this.btnSifreDegistir.Location = new System.Drawing.Point(215, 206);
            this.btnSifreDegistir.Name = "btnSifreDegistir";
            this.btnSifreDegistir.Size = new System.Drawing.Size(300, 40);
            this.btnSifreDegistir.TabIndex = 8;
            this.btnSifreDegistir.Text = "Şifre Değiştir";
            this.btnSifreDegistir.Click += new System.EventHandler(this.btnSifreDegistir_Click);
            // 
            // KullaniciSifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 280);
            this.Controls.Add(this.btnSifreDegistir);
            this.Controls.Add(this.textEditYeniSifreTekrar);
            this.Controls.Add(this.textEditYeniSifre);
            this.Controls.Add(this.textEditEskiSifre);
            this.Controls.Add(this.textEditKullaniciAdi);
            this.Controls.Add(this.labelControlYeniSifreTekrar);
            this.Controls.Add(this.labelControlYeniSifre);
            this.Controls.Add(this.labelControlEskiSifre);
            this.Controls.Add(this.labelControlKullaniciAdi);
            this.Name = "KullaniciSifreDegistir";
            this.Text = "Şifre Değiştir";
            this.Load += new System.EventHandler(this.KullaniciSifreDegistir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEskiSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditYeniSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditYeniSifreTekrar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControlKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl labelControlEskiSifre;
        private DevExpress.XtraEditors.LabelControl labelControlYeniSifre;
        private DevExpress.XtraEditors.LabelControl labelControlYeniSifreTekrar;
        private DevExpress.XtraEditors.TextEdit textEditKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit textEditEskiSifre;
        private DevExpress.XtraEditors.TextEdit textEditYeniSifre;
        private DevExpress.XtraEditors.TextEdit textEditYeniSifreTekrar;
        private DevExpress.XtraEditors.SimpleButton btnSifreDegistir;
    }
}
