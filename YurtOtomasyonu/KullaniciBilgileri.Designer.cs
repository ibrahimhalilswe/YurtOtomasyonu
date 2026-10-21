using DevExpress.XtraEditors;
using System;

namespace YurtOtomasyonu
{
    partial class KullaniciBilgileri
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
            this.labelControlAd = new DevExpress.XtraEditors.LabelControl();
            this.labelControlSoyad = new DevExpress.XtraEditors.LabelControl();
            this.labelControlEmail = new DevExpress.XtraEditors.LabelControl();
            this.labelControlTelefon = new DevExpress.XtraEditors.LabelControl();
            this.labelControlKayitTarihi = new DevExpress.XtraEditors.LabelControl();
            this.textEditKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.textEditAd = new DevExpress.XtraEditors.TextEdit();
            this.textEditSoyad = new DevExpress.XtraEditors.TextEdit();
            this.textEditEmail = new DevExpress.XtraEditors.TextEdit();
            this.textEditTelefon = new DevExpress.XtraEditors.TextEdit();
            this.textEditKayitTarihi = new DevExpress.XtraEditors.TextEdit();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKayitTarihi.Properties)).BeginInit();
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
            // labelControlAd
            // 
            this.labelControlAd.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelControlAd.Appearance.Options.UseFont = true;
            this.labelControlAd.Location = new System.Drawing.Point(40, 90);
            this.labelControlAd.Name = "labelControlAd";
            this.labelControlAd.Size = new System.Drawing.Size(29, 24);
            this.labelControlAd.TabIndex = 2;
            this.labelControlAd.Text = "Ad:";
            // 
            // labelControlSoyad
            // 
            this.labelControlSoyad.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelControlSoyad.Appearance.Options.UseFont = true;
            this.labelControlSoyad.Location = new System.Drawing.Point(40, 130);
            this.labelControlSoyad.Name = "labelControlSoyad";
            this.labelControlSoyad.Size = new System.Drawing.Size(60, 24);
            this.labelControlSoyad.TabIndex = 4;
            this.labelControlSoyad.Text = "Soyad:";
            // 
            // labelControlEmail
            // 
            this.labelControlEmail.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelControlEmail.Appearance.Options.UseFont = true;
            this.labelControlEmail.Location = new System.Drawing.Point(40, 170);
            this.labelControlEmail.Name = "labelControlEmail";
            this.labelControlEmail.Size = new System.Drawing.Size(56, 24);
            this.labelControlEmail.TabIndex = 6;
            this.labelControlEmail.Text = "Email:";
            // 
            // labelControlTelefon
            // 
            this.labelControlTelefon.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelControlTelefon.Appearance.Options.UseFont = true;
            this.labelControlTelefon.Location = new System.Drawing.Point(40, 210);
            this.labelControlTelefon.Name = "labelControlTelefon";
            this.labelControlTelefon.Size = new System.Drawing.Size(71, 24);
            this.labelControlTelefon.TabIndex = 8;
            this.labelControlTelefon.Text = "Telefon:";
            // 
            // labelControlKayitTarihi
            // 
            this.labelControlKayitTarihi.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelControlKayitTarihi.Appearance.Options.UseFont = true;
            this.labelControlKayitTarihi.Location = new System.Drawing.Point(40, 250);
            this.labelControlKayitTarihi.Name = "labelControlKayitTarihi";
            this.labelControlKayitTarihi.Size = new System.Drawing.Size(107, 24);
            this.labelControlKayitTarihi.TabIndex = 10;
            this.labelControlKayitTarihi.Text = "Kayıt Tarihi:";
            // 
            // textEditKullaniciAdi
            // 
            this.textEditKullaniciAdi.Location = new System.Drawing.Point(166, 49);
            this.textEditKullaniciAdi.Name = "textEditKullaniciAdi";
            this.textEditKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textEditKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.textEditKullaniciAdi.Properties.ReadOnly = true;
            this.textEditKullaniciAdi.Size = new System.Drawing.Size(300, 30);
            this.textEditKullaniciAdi.TabIndex = 1;
            // 
            // textEditAd
            // 
            this.textEditAd.Location = new System.Drawing.Point(166, 89);
            this.textEditAd.Name = "textEditAd";
            this.textEditAd.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textEditAd.Properties.Appearance.Options.UseFont = true;
            this.textEditAd.Size = new System.Drawing.Size(300, 30);
            this.textEditAd.TabIndex = 3;
            // 
            // textEditSoyad
            // 
            this.textEditSoyad.Location = new System.Drawing.Point(166, 129);
            this.textEditSoyad.Name = "textEditSoyad";
            this.textEditSoyad.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textEditSoyad.Properties.Appearance.Options.UseFont = true;
            this.textEditSoyad.Size = new System.Drawing.Size(300, 30);
            this.textEditSoyad.TabIndex = 5;
            // 
            // textEditEmail
            // 
            this.textEditEmail.Location = new System.Drawing.Point(166, 169);
            this.textEditEmail.Name = "textEditEmail";
            this.textEditEmail.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textEditEmail.Properties.Appearance.Options.UseFont = true;
            this.textEditEmail.Size = new System.Drawing.Size(300, 30);
            this.textEditEmail.TabIndex = 7;
            // 
            // textEditTelefon
            // 
            this.textEditTelefon.Location = new System.Drawing.Point(166, 209);
            this.textEditTelefon.Name = "textEditTelefon";
            this.textEditTelefon.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textEditTelefon.Properties.Appearance.Options.UseFont = true;
            this.textEditTelefon.Size = new System.Drawing.Size(300, 30);
            this.textEditTelefon.TabIndex = 9;
            // 
            // textEditKayitTarihi
            // 
            this.textEditKayitTarihi.Location = new System.Drawing.Point(166, 249);
            this.textEditKayitTarihi.Name = "textEditKayitTarihi";
            this.textEditKayitTarihi.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textEditKayitTarihi.Properties.Appearance.Options.UseFont = true;
            this.textEditKayitTarihi.Properties.ReadOnly = true;
            this.textEditKayitTarihi.Size = new System.Drawing.Size(300, 30);
            this.textEditKayitTarihi.TabIndex = 11;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.Location = new System.Drawing.Point(166, 299);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(300, 40);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // KullaniciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 380);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.textEditKayitTarihi);
            this.Controls.Add(this.textEditTelefon);
            this.Controls.Add(this.textEditEmail);
            this.Controls.Add(this.textEditSoyad);
            this.Controls.Add(this.textEditAd);
            this.Controls.Add(this.textEditKullaniciAdi);
            this.Controls.Add(this.labelControlKayitTarihi);
            this.Controls.Add(this.labelControlTelefon);
            this.Controls.Add(this.labelControlEmail);
            this.Controls.Add(this.labelControlSoyad);
            this.Controls.Add(this.labelControlAd);
            this.Controls.Add(this.labelControlKullaniciAdi);
            this.Name = "KullaniciBilgileri";
            this.Text = "Kullanıcı Bilgileri";
            this.Load += new System.EventHandler(this.KullaniciBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKayitTarihi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.XtraEditors.LabelControl labelControlKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl labelControlAd;
        private DevExpress.XtraEditors.LabelControl labelControlSoyad;
        private DevExpress.XtraEditors.LabelControl labelControlEmail;
        private DevExpress.XtraEditors.LabelControl labelControlTelefon;
        private DevExpress.XtraEditors.LabelControl labelControlKayitTarihi;
        private DevExpress.XtraEditors.TextEdit textEditKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit textEditAd;
        private DevExpress.XtraEditors.TextEdit textEditSoyad;
        private DevExpress.XtraEditors.TextEdit textEditEmail;
        private DevExpress.XtraEditors.TextEdit textEditTelefon;
        private DevExpress.XtraEditors.TextEdit textEditKayitTarihi;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
    }
}
