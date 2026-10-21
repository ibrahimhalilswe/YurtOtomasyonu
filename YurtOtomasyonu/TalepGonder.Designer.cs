namespace YurtOtomasyonu
{
    partial class TalepGonder
    {
        private DevExpress.XtraEditors.TextEdit txtTCKimlikNo;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTalepTuru;
        private DevExpress.XtraEditors.MemoEdit txtTalepDetay;
        private DevExpress.XtraEditors.DateEdit dtpTalepTarihi;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraGrid.GridControl gridControlTalepler;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewTalepler;

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
            this.txtTCKimlikNo = new DevExpress.XtraEditors.TextEdit();
            this.cmbTalepTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTalepDetay = new DevExpress.XtraEditors.MemoEdit();
            this.dtpTalepTarihi = new DevExpress.XtraEditors.DateEdit();
            this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlTalepler = new DevExpress.XtraGrid.GridControl();
            this.GridViewTalepler = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtTCKimlikNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTalepTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTalepDetay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTalepTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTalepTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTalepler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTalepler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTCKimlikNo
            // 
            this.txtTCKimlikNo.Location = new System.Drawing.Point(50, 50);
            this.txtTCKimlikNo.Name = "txtTCKimlikNo";
            this.txtTCKimlikNo.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.txtTCKimlikNo.Properties.Appearance.Options.UseFont = true;
            this.txtTCKimlikNo.Size = new System.Drawing.Size(300, 30);
            this.txtTCKimlikNo.TabIndex = 0;
            this.txtTCKimlikNo.ToolTip = "T.C. Kimlik No giriniz";
            // 
            // cmbTalepTuru
            // 
            this.cmbTalepTuru.Location = new System.Drawing.Point(50, 100);
            this.cmbTalepTuru.Name = "cmbTalepTuru";
            this.cmbTalepTuru.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.cmbTalepTuru.Properties.Appearance.Options.UseFont = true;
            this.cmbTalepTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTalepTuru.Size = new System.Drawing.Size(300, 30);
            this.cmbTalepTuru.TabIndex = 1;
            this.cmbTalepTuru.ToolTip = "Talep Türü seçiniz";
            // 
            // txtTalepDetay
            // 
            this.txtTalepDetay.Location = new System.Drawing.Point(50, 150);
            this.txtTalepDetay.Name = "txtTalepDetay";
            this.txtTalepDetay.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.txtTalepDetay.Properties.Appearance.Options.UseFont = true;
            this.txtTalepDetay.Size = new System.Drawing.Size(300, 100);
            this.txtTalepDetay.TabIndex = 2;
            this.txtTalepDetay.ToolTip = "Talep detaylarını giriniz";
            // 
            // dtpTalepTarihi
            // 
            this.dtpTalepTarihi.EditValue = new System.DateTime(2025, 1, 10, 0, 0, 0, 0);
            this.dtpTalepTarihi.Location = new System.Drawing.Point(50, 270);
            this.dtpTalepTarihi.Name = "dtpTalepTarihi";
            this.dtpTalepTarihi.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.dtpTalepTarihi.Properties.Appearance.Options.UseFont = true;
            this.dtpTalepTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTalepTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTalepTarihi.Size = new System.Drawing.Size(300, 30);
            this.dtpTalepTarihi.TabIndex = 3;
            this.dtpTalepTarihi.ToolTip = "Talep Tarihini seçiniz";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(50, 320);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(140, 40);
            this.btnGonder.TabIndex = 4;
            this.btnGonder.Text = "Gönder";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(210, 320);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(140, 40);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Temizle";
            // 
            // gridControlTalepler
            // 
            this.gridControlTalepler.Location = new System.Drawing.Point(400, 50);
            this.gridControlTalepler.MainView = this.GridViewTalepler;
            this.gridControlTalepler.Name = "gridControlTalepler";
            this.gridControlTalepler.Size = new System.Drawing.Size(600, 310);
            this.gridControlTalepler.TabIndex = 6;
            this.gridControlTalepler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewTalepler});
            // 
            // GridViewTalepler
            // 
            this.GridViewTalepler.GridControl = this.gridControlTalepler;
            this.GridViewTalepler.Name = "GridViewTalepler";
            this.GridViewTalepler.OptionsView.ShowGroupPanel = false;
            this.GridViewTalepler.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewTalepler_FocusedRowChanged);
            // 
            // TalepGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 400);
            this.Controls.Add(this.gridControlTalepler);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.dtpTalepTarihi);
            this.Controls.Add(this.txtTalepDetay);
            this.Controls.Add(this.cmbTalepTuru);
            this.Controls.Add(this.txtTCKimlikNo);
            this.Name = "TalepGonder";
            this.Text = "Talep Gönder";
            ((System.ComponentModel.ISupportInitialize)(this.txtTCKimlikNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTalepTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTalepDetay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTalepTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTalepTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTalepler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTalepler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
