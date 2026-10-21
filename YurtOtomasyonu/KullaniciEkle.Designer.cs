using DevExpress.XtraEditors;

namespace YurtOtomasyonu
{
    partial class KullaniciEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private LabelControl labelKullaniciAdi;
        private TextEdit textBoxKullaniciAdi;
        private LabelControl labelSifre;
        private TextEdit textBoxSifre;
        private LabelControl labelAd;
        private TextEdit textBoxAd;
        private LabelControl labelSoyad;
        private TextEdit textBoxSoyad;
        private LabelControl labelEposta;
        private TextEdit textBoxEposta;
        private LabelControl labelTelefon;
        private TextEdit textBoxTelefon;
        private SimpleButton btnEkle;

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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            this.textBoxKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelSifre = new DevExpress.XtraEditors.LabelControl();
            this.textBoxSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelAd = new DevExpress.XtraEditors.LabelControl();
            this.textBoxAd = new DevExpress.XtraEditors.TextEdit();
            this.labelSoyad = new DevExpress.XtraEditors.LabelControl();
            this.textBoxSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelEposta = new DevExpress.XtraEditors.LabelControl();
            this.textBoxEposta = new DevExpress.XtraEditors.TextEdit();
            this.labelTelefon = new DevExpress.XtraEditors.LabelControl();
            this.textBoxTelefon = new DevExpress.XtraEditors.TextEdit();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEposta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTelefon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKullaniciAdi
            // 
            this.labelKullaniciAdi.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelKullaniciAdi.Appearance.Options.UseFont = true;
            this.labelKullaniciAdi.Location = new System.Drawing.Point(50, 30);
            this.labelKullaniciAdi.Name = "labelKullaniciAdi";
            this.labelKullaniciAdi.Size = new System.Drawing.Size(117, 24);
            this.labelKullaniciAdi.TabIndex = 0;
            this.labelKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(200, 27);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(250, 30);
            this.textBoxKullaniciAdi.TabIndex = 1;
            // 
            // labelSifre
            // 
            this.labelSifre.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelSifre.Appearance.Options.UseFont = true;
            this.labelSifre.Location = new System.Drawing.Point(50, 80);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(48, 24);
            this.labelSifre.TabIndex = 2;
            this.labelSifre.Text = "Şifre:";
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(200, 77);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxSifre.Properties.Appearance.Options.UseFont = true;
            this.textBoxSifre.Properties.UseSystemPasswordChar = true;
            this.textBoxSifre.Size = new System.Drawing.Size(250, 30);
            this.textBoxSifre.TabIndex = 3;
            // 
            // labelAd
            // 
            this.labelAd.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelAd.Appearance.Options.UseFont = true;
            this.labelAd.Location = new System.Drawing.Point(50, 130);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(29, 24);
            this.labelAd.TabIndex = 4;
            this.labelAd.Text = "Ad:";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(200, 127);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxAd.Properties.Appearance.Options.UseFont = true;
            this.textBoxAd.Size = new System.Drawing.Size(250, 26);
            this.textBoxAd.TabIndex = 5;
            // 
            // labelSoyad
            // 
            this.labelSoyad.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelSoyad.Appearance.Options.UseFont = true;
            this.labelSoyad.Location = new System.Drawing.Point(50, 180);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(60, 24);
            this.labelSoyad.TabIndex = 6;
            this.labelSoyad.Text = "Soyad:";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(200, 177);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxSoyad.Properties.Appearance.Options.UseFont = true;
            this.textBoxSoyad.Size = new System.Drawing.Size(250, 30);
            this.textBoxSoyad.TabIndex = 7;
            // 
            // labelEposta
            // 
            this.labelEposta.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelEposta.Appearance.Options.UseFont = true;
            this.labelEposta.Location = new System.Drawing.Point(50, 230);
            this.labelEposta.Name = "labelEposta";
            this.labelEposta.Size = new System.Drawing.Size(77, 24);
            this.labelEposta.TabIndex = 8;
            this.labelEposta.Text = "E-posta:";
            // 
            // textBoxEposta
            // 
            this.textBoxEposta.Location = new System.Drawing.Point(200, 227);
            this.textBoxEposta.Name = "textBoxEposta";
            this.textBoxEposta.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxEposta.Properties.Appearance.Options.UseFont = true;
            this.textBoxEposta.Size = new System.Drawing.Size(250, 30);
            this.textBoxEposta.TabIndex = 9;
            // 
            // labelTelefon
            // 
            this.labelTelefon.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelTelefon.Appearance.Options.UseFont = true;
            this.labelTelefon.Location = new System.Drawing.Point(50, 280);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(71, 24);
            this.labelTelefon.TabIndex = 10;
            this.labelTelefon.Text = "Telefon:";
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(200, 277);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxTelefon.Properties.Appearance.Options.UseFont = true;
            this.textBoxTelefon.Size = new System.Drawing.Size(250, 30);
            this.textBoxTelefon.TabIndex = 11;
            // 
            // btnEkle
            // 
            this.btnEkle.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnEkle.Appearance.Options.UseFont = true;
            this.btnEkle.Location = new System.Drawing.Point(200, 330);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(120, 40);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // KullaniciEkle
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.textBoxEposta);
            this.Controls.Add(this.labelEposta);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.labelSoyad);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Controls.Add(this.labelKullaniciAdi);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.Name = "KullaniciEkle";
            this.Text = "Kullanıcı Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.textBoxKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEposta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTelefon.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}

