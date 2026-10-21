namespace YurtOtomasyonu
{
    partial class Duyurular
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
            this.dateEditAtilanTarih = new DevExpress.XtraEditors.DateEdit();
            this.dateEditGecerlilikTarihi = new DevExpress.XtraEditors.DateEdit();
            this.gridControlDuyurular = new DevExpress.XtraGrid.GridControl();
            this.gridViewDuyurular = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.labelControlBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditIcerik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAtilanTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAtilanTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditGecerlilikTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditGecerlilikTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDuyurular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDuyurular)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditBaslik
            // 
            this.textEditBaslik.Location = new System.Drawing.Point(30, 60);
            this.textEditBaslik.Name = "textEditBaslik";
            this.textEditBaslik.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textEditBaslik.Properties.Appearance.Options.UseFont = true;
            this.textEditBaslik.Size = new System.Drawing.Size(400, 30);
            this.textEditBaslik.TabIndex = 0;
            this.textEditBaslik.ToolTip = "Duyuru Başlığını Giriniz";
            // 
            // memoEditIcerik
            // 
            this.memoEditIcerik.Location = new System.Drawing.Point(30, 110);
            this.memoEditIcerik.Name = "memoEditIcerik";
            this.memoEditIcerik.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.memoEditIcerik.Properties.Appearance.Options.UseFont = true;
            this.memoEditIcerik.Size = new System.Drawing.Size(400, 150);
            this.memoEditIcerik.TabIndex = 1;
            this.memoEditIcerik.ToolTip = "Duyuru İçeriğini Giriniz";
            // 
            // dateEditAtilanTarih
            // 
            this.dateEditAtilanTarih.EditValue = null;
            this.dateEditAtilanTarih.Location = new System.Drawing.Point(30, 280);
            this.dateEditAtilanTarih.Name = "dateEditAtilanTarih";
            this.dateEditAtilanTarih.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.dateEditAtilanTarih.Properties.Appearance.Options.UseFont = true;
            this.dateEditAtilanTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditAtilanTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditAtilanTarih.Size = new System.Drawing.Size(200, 30);
            this.dateEditAtilanTarih.TabIndex = 2;
            this.dateEditAtilanTarih.ToolTip = "Atılan Tarihi Seçiniz";
            // 
            // dateEditGecerlilikTarihi
            // 
            this.dateEditGecerlilikTarihi.EditValue = null;
            this.dateEditGecerlilikTarihi.Location = new System.Drawing.Point(250, 280);
            this.dateEditGecerlilikTarihi.Name = "dateEditGecerlilikTarihi";
            this.dateEditGecerlilikTarihi.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.dateEditGecerlilikTarihi.Properties.Appearance.Options.UseFont = true;
            this.dateEditGecerlilikTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditGecerlilikTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditGecerlilikTarihi.Size = new System.Drawing.Size(200, 30);
            this.dateEditGecerlilikTarihi.TabIndex = 3;
            this.dateEditGecerlilikTarihi.ToolTip = "Geçerlilik Tarihini Seçiniz";
            // 
            // gridControlDuyurular
            // 
            this.gridControlDuyurular.Location = new System.Drawing.Point(30, 330);
            this.gridControlDuyurular.MainView = this.gridViewDuyurular;
            this.gridControlDuyurular.Name = "gridControlDuyurular";
            this.gridControlDuyurular.Size = new System.Drawing.Size(800, 250);
            this.gridControlDuyurular.TabIndex = 4;
            this.gridControlDuyurular.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDuyurular});
            // 
            // gridViewDuyurular
            // 
            this.gridViewDuyurular.Appearance.Row.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.gridViewDuyurular.Appearance.Row.Options.UseFont = true;
            this.gridViewDuyurular.GridControl = this.gridControlDuyurular;
            this.gridViewDuyurular.Name = "gridViewDuyurular";
            this.gridViewDuyurular.OptionsView.ShowGroupPanel = false;
            this.gridViewDuyurular.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewDuyurular_FocusedRowChanged);
            // 
            // btnYenile
            // 
            this.btnYenile.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnYenile.Appearance.Options.UseFont = true;
            this.btnYenile.Location = new System.Drawing.Point(657, 208);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(173, 52);
            this.btnYenile.TabIndex = 5;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.ToolTip = "Listeyi Yenile";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // labelControlBaslik
            // 
            this.labelControlBaslik.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelControlBaslik.Appearance.Options.UseFont = true;
            this.labelControlBaslik.Location = new System.Drawing.Point(30, 30);
            this.labelControlBaslik.Name = "labelControlBaslik";
            this.labelControlBaslik.Size = new System.Drawing.Size(136, 24);
            this.labelControlBaslik.TabIndex = 6;
            this.labelControlBaslik.Text = "Duyuru Başlığı:";
            // 
            // Duyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 652);
            this.Controls.Add(this.labelControlBaslik);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.gridControlDuyurular);
            this.Controls.Add(this.dateEditGecerlilikTarihi);
            this.Controls.Add(this.dateEditAtilanTarih);
            this.Controls.Add(this.memoEditIcerik);
            this.Controls.Add(this.textEditBaslik);
            this.Name = "Duyurular";
            this.Text = "Duyurular";
            this.Load += new System.EventHandler(this.GuncelDyr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditIcerik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAtilanTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAtilanTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditGecerlilikTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditGecerlilikTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDuyurular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDuyurular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEditBaslik;
        private DevExpress.XtraEditors.MemoEdit memoEditIcerik;
        private DevExpress.XtraEditors.DateEdit dateEditAtilanTarih;
        private DevExpress.XtraEditors.DateEdit dateEditGecerlilikTarihi;
        private DevExpress.XtraGrid.GridControl gridControlDuyurular;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDuyurular;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.LabelControl labelControlBaslik;
    }
}
