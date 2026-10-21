namespace YurtOtomasyonu
{
    partial class EtkinlikIslemleri
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textEditBaslik = new DevExpress.XtraEditors.TextEdit();
            this.labelBaslik = new DevExpress.XtraEditors.LabelControl();
            this.memoEditIcerik = new DevExpress.XtraEditors.MemoEdit();
            this.labelIcerik = new DevExpress.XtraEditors.LabelControl();
            this.labelTarih = new DevExpress.XtraEditors.LabelControl();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.labelKategori = new DevExpress.XtraEditors.LabelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelBitisTarihi = new DevExpress.XtraEditors.LabelControl();
            this.dateEditTarih = new DevExpress.XtraEditors.DateEdit();
            this.dateEditBitisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.comboBoxEditKategori = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditIcerik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBitisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBitisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditKategori.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditBaslik
            // 
            this.textEditBaslik.Location = new System.Drawing.Point(150, 20);
            this.textEditBaslik.Name = "textEditBaslik";
            this.textEditBaslik.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textEditBaslik.Properties.Appearance.Options.UseFont = true;
            this.textEditBaslik.Size = new System.Drawing.Size(300, 30);
            this.textEditBaslik.TabIndex = 1;
            this.textEditBaslik.ToolTip = "Etkinlik Başlığı";
            // 
            // labelBaslik
            // 
            this.labelBaslik.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelBaslik.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.labelBaslik.Appearance.Options.UseFont = true;
            this.labelBaslik.Appearance.Options.UseForeColor = true;
            this.labelBaslik.Location = new System.Drawing.Point(10, 20);
            this.labelBaslik.Name = "labelBaslik";
            this.labelBaslik.Size = new System.Drawing.Size(139, 24);
            this.labelBaslik.TabIndex = 0;
            this.labelBaslik.Text = "Etkinlik Başlığı:";
            // 
            // memoEditIcerik
            // 
            this.memoEditIcerik.Location = new System.Drawing.Point(150, 60);
            this.memoEditIcerik.Name = "memoEditIcerik";
            this.memoEditIcerik.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.memoEditIcerik.Properties.Appearance.Options.UseFont = true;
            this.memoEditIcerik.Size = new System.Drawing.Size(300, 100);
            this.memoEditIcerik.TabIndex = 3;
            this.memoEditIcerik.ToolTip = "Etkinlik İçeriği";
            // 
            // labelIcerik
            // 
            this.labelIcerik.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelIcerik.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.labelIcerik.Appearance.Options.UseFont = true;
            this.labelIcerik.Appearance.Options.UseForeColor = true;
            this.labelIcerik.Location = new System.Drawing.Point(14, 60);
            this.labelIcerik.Name = "labelIcerik";
            this.labelIcerik.Size = new System.Drawing.Size(135, 24);
            this.labelIcerik.TabIndex = 2;
            this.labelIcerik.Text = "Etkinlik İçeriği:";
            // 
            // labelTarih
            // 
            this.labelTarih.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelTarih.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.labelTarih.Appearance.Options.UseFont = true;
            this.labelTarih.Appearance.Options.UseForeColor = true;
            this.labelTarih.Location = new System.Drawing.Point(19, 173);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(129, 24);
            this.labelTarih.TabIndex = 4;
            this.labelTarih.Text = "Etkinlik Tarihi:";
            // 
            // btnEkle
            // 
            this.btnEkle.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnEkle.Appearance.Options.UseFont = true;
            this.btnEkle.Location = new System.Drawing.Point(500, 20);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 30);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.Location = new System.Drawing.Point(500, 60);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 30);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.Location = new System.Drawing.Point(500, 100);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 30);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.Location = new System.Drawing.Point(500, 140);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 30);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // labelKategori
            // 
            this.labelKategori.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelKategori.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.labelKategori.Appearance.Options.UseFont = true;
            this.labelKategori.Appearance.Options.UseForeColor = true;
            this.labelKategori.Location = new System.Drawing.Point(60, 213);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(83, 24);
            this.labelKategori.TabIndex = 11;
            this.labelKategori.Text = "Kategori:";
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(464, 183);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(712, 467);
            this.gridControl.TabIndex = 12;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // labelBitisTarihi
            // 
            this.labelBitisTarihi.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelBitisTarihi.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.labelBitisTarihi.Appearance.Options.UseFont = true;
            this.labelBitisTarihi.Appearance.Options.UseForeColor = true;
            this.labelBitisTarihi.Location = new System.Drawing.Point(44, 253);
            this.labelBitisTarihi.Name = "labelBitisTarihi";
            this.labelBitisTarihi.Size = new System.Drawing.Size(101, 24);
            this.labelBitisTarihi.TabIndex = 13;
            this.labelBitisTarihi.Text = "Bitiş Tarihi:";
            // 
            // dateEditTarih
            // 
            this.dateEditTarih.EditValue = new System.DateTime(2025, 1, 9, 0, 33, 34, 0);
            this.dateEditTarih.Location = new System.Drawing.Point(150, 170);
            this.dateEditTarih.Name = "dateEditTarih";
            this.dateEditTarih.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateEditTarih.Properties.Appearance.Options.UseFont = true;
            this.dateEditTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTarih.Size = new System.Drawing.Size(300, 30);
            this.dateEditTarih.TabIndex = 46;
            // 
            // dateEditBitisTarihi
            // 
            this.dateEditBitisTarihi.EditValue = new System.DateTime(2025, 1, 9, 0, 33, 34, 0);
            this.dateEditBitisTarihi.Location = new System.Drawing.Point(150, 250);
            this.dateEditBitisTarihi.Name = "dateEditBitisTarihi";
            this.dateEditBitisTarihi.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateEditBitisTarihi.Properties.Appearance.Options.UseFont = true;
            this.dateEditBitisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBitisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBitisTarihi.Size = new System.Drawing.Size(300, 30);
            this.dateEditBitisTarihi.TabIndex = 47;
            // 
            // comboBoxEditKategori
            // 
            this.comboBoxEditKategori.Location = new System.Drawing.Point(150, 210);
            this.comboBoxEditKategori.Name = "comboBoxEditKategori";
            this.comboBoxEditKategori.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxEditKategori.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditKategori.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditKategori.Size = new System.Drawing.Size(300, 30);
            this.comboBoxEditKategori.TabIndex = 48;
            // 
            // EtkinlikIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1182, 652);
            this.Controls.Add(this.comboBoxEditKategori);
            this.Controls.Add(this.dateEditBitisTarihi);
            this.Controls.Add(this.dateEditTarih);
            this.Controls.Add(this.labelBaslik);
            this.Controls.Add(this.textEditBaslik);
            this.Controls.Add(this.labelIcerik);
            this.Controls.Add(this.memoEditIcerik);
            this.Controls.Add(this.labelTarih);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.labelKategori);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.labelBitisTarihi);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "EtkinlikIslemleri";
            this.Text = "Etkinlik İşlemleri";
            this.Load += new System.EventHandler(this.EtkinlikIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditIcerik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBitisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBitisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditKategori.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEditBaslik;
        private DevExpress.XtraEditors.LabelControl labelBaslik;
        private DevExpress.XtraEditors.MemoEdit memoEditIcerik;
        private DevExpress.XtraEditors.LabelControl labelIcerik;
        private DevExpress.XtraEditors.LabelControl labelTarih;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.LabelControl labelKategori;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.LabelControl labelBitisTarihi;
        private DevExpress.XtraEditors.DateEdit dateEditTarih;
        private DevExpress.XtraEditors.DateEdit dateEditBitisTarihi;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditKategori;
    }
}
