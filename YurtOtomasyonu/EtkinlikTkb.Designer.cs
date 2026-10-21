namespace YurtOtomasyonu
{
    partial class EtkinlikTkb
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
            this.memoEditIcerik = new DevExpress.XtraEditors.MemoEdit();
            this.gridControlEtkinlikler = new DevExpress.XtraGrid.GridControl();
            this.gridViewEtkinlikler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.comboBoxEditKategori = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.dateEditTarih = new DevExpress.XtraEditors.DateEdit();
            this.dateEditBitisTarihi = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditIcerik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEtkinlikler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEtkinlikler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditKategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBitisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBitisTarihi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditBaslik
            // 
            this.textEditBaslik.Location = new System.Drawing.Point(34, 30);
            this.textEditBaslik.Name = "textEditBaslik";
            this.textEditBaslik.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textEditBaslik.Properties.Appearance.Options.UseFont = true;
            this.textEditBaslik.Size = new System.Drawing.Size(457, 30);
            this.textEditBaslik.TabIndex = 0;
            // 
            // memoEditIcerik
            // 
            this.memoEditIcerik.Location = new System.Drawing.Point(34, 130);
            this.memoEditIcerik.Name = "memoEditIcerik";
            this.memoEditIcerik.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.memoEditIcerik.Properties.Appearance.Options.UseFont = true;
            this.memoEditIcerik.Size = new System.Drawing.Size(457, 150);
            this.memoEditIcerik.TabIndex = 3;
            // 
            // gridControlEtkinlikler
            // 
            this.gridControlEtkinlikler.Location = new System.Drawing.Point(34, 300);
            this.gridControlEtkinlikler.MainView = this.gridViewEtkinlikler;
            this.gridControlEtkinlikler.Name = "gridControlEtkinlikler";
            this.gridControlEtkinlikler.Size = new System.Drawing.Size(914, 300);
            this.gridControlEtkinlikler.TabIndex = 4;
            this.gridControlEtkinlikler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEtkinlikler});
            // 
            // gridViewEtkinlikler
            // 
            this.gridViewEtkinlikler.Appearance.Row.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.gridViewEtkinlikler.Appearance.Row.Options.UseFont = true;
            this.gridViewEtkinlikler.GridControl = this.gridControlEtkinlikler;
            this.gridViewEtkinlikler.Name = "gridViewEtkinlikler";
            this.gridViewEtkinlikler.OptionsView.ShowGroupPanel = false;
            // 
            // comboBoxEditKategori
            // 
            this.comboBoxEditKategori.Location = new System.Drawing.Point(514, 30);
            this.comboBoxEditKategori.Name = "comboBoxEditKategori";
            this.comboBoxEditKategori.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxEditKategori.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditKategori.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditKategori.Size = new System.Drawing.Size(229, 30);
            this.comboBoxEditKategori.TabIndex = 5;
            // 
            // btnYenile
            // 
            this.btnYenile.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnYenile.Appearance.Options.UseFont = true;
            this.btnYenile.Location = new System.Drawing.Point(571, 227);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(171, 53);
            this.btnYenile.TabIndex = 8;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // dateEditTarih
            // 
            this.dateEditTarih.EditValue = null;
            this.dateEditTarih.Location = new System.Drawing.Point(34, 80);
            this.dateEditTarih.Name = "dateEditTarih";
            this.dateEditTarih.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.dateEditTarih.Properties.Appearance.Options.UseFont = true;
            this.dateEditTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTarih.Size = new System.Drawing.Size(229, 30);
            this.dateEditTarih.TabIndex = 9;
            // 
            // dateEditBitisTarihi
            // 
            this.dateEditBitisTarihi.EditValue = null;
            this.dateEditBitisTarihi.Location = new System.Drawing.Point(286, 80);
            this.dateEditBitisTarihi.Name = "dateEditBitisTarihi";
            this.dateEditBitisTarihi.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.dateEditBitisTarihi.Properties.Appearance.Options.UseFont = true;
            this.dateEditBitisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBitisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBitisTarihi.Size = new System.Drawing.Size(229, 30);
            this.dateEditBitisTarihi.TabIndex = 10;
            // 
            // EtkinlikTkb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1264, 652);
            this.Controls.Add(this.dateEditBitisTarihi);
            this.Controls.Add(this.dateEditTarih);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.comboBoxEditKategori);
            this.Controls.Add(this.gridControlEtkinlikler);
            this.Controls.Add(this.memoEditIcerik);
            this.Controls.Add(this.textEditBaslik);
            this.Name = "EtkinlikTkb";
            this.Text = "Etkinlik Takvimi";
            this.Load += new System.EventHandler(this.EtkinlikTkb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditIcerik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEtkinlikler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEtkinlikler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditKategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBitisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBitisTarihi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEditBaslik;
        private DevExpress.XtraEditors.MemoEdit memoEditIcerik;
        private DevExpress.XtraGrid.GridControl gridControlEtkinlikler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEtkinlikler;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditKategori;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.DateEdit dateEditTarih;
        private DevExpress.XtraEditors.DateEdit dateEditBitisTarihi;
    }
}
