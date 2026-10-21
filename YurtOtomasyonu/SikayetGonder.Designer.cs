namespace YurtOtomasyonu
{
    partial class SikayetGonder
    {
        private DevExpress.XtraEditors.LabelControl lblTCKimlikNo;
        private DevExpress.XtraEditors.LabelControl lblAdSoyad;
        private DevExpress.XtraEditors.LabelControl lblOdaNo;
        private DevExpress.XtraEditors.LabelControl lblSikayetBaslik;
        private DevExpress.XtraEditors.LabelControl lblSikayetDetay;
        private DevExpress.XtraEditors.LabelControl lblSikayetTarihi;
        private DevExpress.XtraEditors.TextEdit txtTCKimlikNo;
        private DevExpress.XtraEditors.TextEdit txtAdSoyad;
        private DevExpress.XtraEditors.TextEdit txtOdaNo;
        private DevExpress.XtraEditors.TextEdit txtSikayetBaslik;
        private DevExpress.XtraEditors.MemoEdit txtSikayetDetay;
        private DevExpress.XtraEditors.DateEdit dtpSikayetTarihi;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraGrid.GridControl gridControlSikayetler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSikayetler;

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

        private void InitializeComponent()
        {
            this.lblTCKimlikNo = new DevExpress.XtraEditors.LabelControl();
            this.lblAdSoyad = new DevExpress.XtraEditors.LabelControl();
            this.lblOdaNo = new DevExpress.XtraEditors.LabelControl();
            this.lblSikayetBaslik = new DevExpress.XtraEditors.LabelControl();
            this.lblSikayetDetay = new DevExpress.XtraEditors.LabelControl();
            this.lblSikayetTarihi = new DevExpress.XtraEditors.LabelControl();
            this.txtTCKimlikNo = new DevExpress.XtraEditors.TextEdit();
            this.txtAdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtOdaNo = new DevExpress.XtraEditors.TextEdit();
            this.txtSikayetBaslik = new DevExpress.XtraEditors.TextEdit();
            this.txtSikayetDetay = new DevExpress.XtraEditors.MemoEdit();
            this.dtpSikayetTarihi = new DevExpress.XtraEditors.DateEdit();
            this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlSikayetler = new DevExpress.XtraGrid.GridControl();
            this.gridViewSikayetler = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtTCKimlikNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdaNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSikayetBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSikayetDetay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSikayetTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSikayetTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSikayetler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSikayetler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTCKimlikNo
            // 
            this.lblTCKimlikNo.Appearance.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold);
            this.lblTCKimlikNo.Appearance.Options.UseFont = true;
            this.lblTCKimlikNo.Location = new System.Drawing.Point(50, 30);
            this.lblTCKimlikNo.Name = "lblTCKimlikNo";
            this.lblTCKimlikNo.Size = new System.Drawing.Size(110, 21);
            this.lblTCKimlikNo.TabIndex = 0;
            this.lblTCKimlikNo.Text = "T.C. Kimlik No:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.Appearance.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold);
            this.lblAdSoyad.Appearance.Options.UseFont = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(50, 80);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(74, 21);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.Appearance.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold);
            this.lblOdaNo.Appearance.Options.UseFont = true;
            this.lblOdaNo.Location = new System.Drawing.Point(50, 130);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(59, 21);
            this.lblOdaNo.TabIndex = 2;
            this.lblOdaNo.Text = "Oda No:";
            // 
            // lblSikayetBaslik
            // 
            this.lblSikayetBaslik.Appearance.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold);
            this.lblSikayetBaslik.Appearance.Options.UseFont = true;
            this.lblSikayetBaslik.Location = new System.Drawing.Point(50, 180);
            this.lblSikayetBaslik.Name = "lblSikayetBaslik";
            this.lblSikayetBaslik.Size = new System.Drawing.Size(111, 21);
            this.lblSikayetBaslik.TabIndex = 3;
            this.lblSikayetBaslik.Text = "Şikayet Başlık:";
            // 
            // lblSikayetDetay
            // 
            this.lblSikayetDetay.Appearance.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold);
            this.lblSikayetDetay.Appearance.Options.UseFont = true;
            this.lblSikayetDetay.Location = new System.Drawing.Point(50, 230);
            this.lblSikayetDetay.Name = "lblSikayetDetay";
            this.lblSikayetDetay.Size = new System.Drawing.Size(107, 21);
            this.lblSikayetDetay.TabIndex = 4;
            this.lblSikayetDetay.Text = "Şikayet Detay:";
            // 
            // lblSikayetTarihi
            // 
            this.lblSikayetTarihi.Appearance.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold);
            this.lblSikayetTarihi.Appearance.Options.UseFont = true;
            this.lblSikayetTarihi.Location = new System.Drawing.Point(50, 350);
            this.lblSikayetTarihi.Name = "lblSikayetTarihi";
            this.lblSikayetTarihi.Size = new System.Drawing.Size(105, 21);
            this.lblSikayetTarihi.TabIndex = 5;
            this.lblSikayetTarihi.Text = "Şikayet Tarihi:";
            // 
            // txtTCKimlikNo
            // 
            this.txtTCKimlikNo.Location = new System.Drawing.Point(50, 50);
            this.txtTCKimlikNo.Name = "txtTCKimlikNo";
            this.txtTCKimlikNo.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.txtTCKimlikNo.Properties.Appearance.Options.UseFont = true;
            this.txtTCKimlikNo.Size = new System.Drawing.Size(300, 30);
            this.txtTCKimlikNo.TabIndex = 6;
            this.txtTCKimlikNo.ToolTip = "T.C. Kimlik No giriniz";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(50, 100);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.txtAdSoyad.Properties.Appearance.Options.UseFont = true;
            this.txtAdSoyad.Size = new System.Drawing.Size(300, 30);
            this.txtAdSoyad.TabIndex = 7;
            this.txtAdSoyad.ToolTip = "Ad Soyad giriniz";
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Location = new System.Drawing.Point(50, 150);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.txtOdaNo.Properties.Appearance.Options.UseFont = true;
            this.txtOdaNo.Size = new System.Drawing.Size(300, 30);
            this.txtOdaNo.TabIndex = 8;
            this.txtOdaNo.ToolTip = "Oda No giriniz";
            // 
            // txtSikayetBaslik
            // 
            this.txtSikayetBaslik.Location = new System.Drawing.Point(50, 200);
            this.txtSikayetBaslik.Name = "txtSikayetBaslik";
            this.txtSikayetBaslik.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.txtSikayetBaslik.Properties.Appearance.Options.UseFont = true;
            this.txtSikayetBaslik.Size = new System.Drawing.Size(300, 30);
            this.txtSikayetBaslik.TabIndex = 9;
            this.txtSikayetBaslik.ToolTip = "Şikayet Başlığını giriniz";
            // 
            // txtSikayetDetay
            // 
            this.txtSikayetDetay.Location = new System.Drawing.Point(50, 250);
            this.txtSikayetDetay.Name = "txtSikayetDetay";
            this.txtSikayetDetay.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.txtSikayetDetay.Properties.Appearance.Options.UseFont = true;
            this.txtSikayetDetay.Size = new System.Drawing.Size(300, 100);
            this.txtSikayetDetay.TabIndex = 10;
            this.txtSikayetDetay.ToolTip = "Şikayet detaylarını giriniz";
            // 
            // dtpSikayetTarihi
            // 
            this.dtpSikayetTarihi.EditValue = new System.DateTime(2025, 1, 10, 0, 0, 0, 0);
            this.dtpSikayetTarihi.Location = new System.Drawing.Point(50, 370);
            this.dtpSikayetTarihi.Name = "dtpSikayetTarihi";
            this.dtpSikayetTarihi.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.dtpSikayetTarihi.Properties.Appearance.Options.UseFont = true;
            this.dtpSikayetTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpSikayetTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpSikayetTarihi.Size = new System.Drawing.Size(300, 30);
            this.dtpSikayetTarihi.TabIndex = 11;
            this.dtpSikayetTarihi.ToolTip = "Şikayet Tarihini seçiniz";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(50, 420);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(140, 40);
            this.btnGonder.TabIndex = 12;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(210, 420);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(140, 40);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // gridControlSikayetler
            // 
            this.gridControlSikayetler.Location = new System.Drawing.Point(400, 50);
            this.gridControlSikayetler.MainView = this.gridViewSikayetler;
            this.gridControlSikayetler.Name = "gridControlSikayetler";
            this.gridControlSikayetler.Size = new System.Drawing.Size(600, 410);
            this.gridControlSikayetler.TabIndex = 14;
            this.gridControlSikayetler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSikayetler});
            // 
            // gridViewSikayetler
            // 
            this.gridViewSikayetler.GridControl = this.gridControlSikayetler;
            this.gridViewSikayetler.Name = "gridViewSikayetler";
            this.gridViewSikayetler.OptionsView.ShowGroupPanel = false;
            // 
            // SikayetGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 652);
            this.Controls.Add(this.gridControlSikayetler);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.dtpSikayetTarihi);
            this.Controls.Add(this.txtSikayetDetay);
            this.Controls.Add(this.txtSikayetBaslik);
            this.Controls.Add(this.txtOdaNo);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtTCKimlikNo);
            this.Controls.Add(this.lblSikayetTarihi);
            this.Controls.Add(this.lblSikayetDetay);
            this.Controls.Add(this.lblSikayetBaslik);
            this.Controls.Add(this.lblOdaNo);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblTCKimlikNo);
            this.Name = "SikayetGonder";
            this.Text = "Şikayet Gönder";
            ((System.ComponentModel.ISupportInitialize)(this.txtTCKimlikNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdaNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSikayetBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSikayetDetay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSikayetTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSikayetTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSikayetler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSikayetler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
