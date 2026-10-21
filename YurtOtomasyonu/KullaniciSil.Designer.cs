namespace YurtOtomasyonu
{
    partial class KullaniciSil
    {
        private DevExpress.XtraEditors.LabelControl labelKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit textBoxKullaniciAdi;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraGrid.GridControl gridControlKullanicilar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKullanicilar;

        private void InitializeComponent()
        {
            this.labelKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            this.textBoxKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlKullanicilar = new DevExpress.XtraGrid.GridControl();
            this.gridViewKullanicilar = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKullaniciAdi
            // 
            this.labelKullaniciAdi.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelKullaniciAdi.Appearance.Options.UseFont = true;
            this.labelKullaniciAdi.Location = new System.Drawing.Point(30, 30);
            this.labelKullaniciAdi.Name = "labelKullaniciAdi";
            this.labelKullaniciAdi.Size = new System.Drawing.Size(117, 24);
            this.labelKullaniciAdi.TabIndex = 0;
            this.labelKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(180, 27);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.textBoxKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(250, 30);
            this.textBoxKullaniciAdi.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnAra.Appearance.Options.UseFont = true;
            this.btnAra.Location = new System.Drawing.Point(450, 25);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 30);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.Location = new System.Drawing.Point(570, 25);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 30);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // gridControlKullanicilar
            // 
            this.gridControlKullanicilar.Location = new System.Drawing.Point(30, 80);
            this.gridControlKullanicilar.MainView = this.gridViewKullanicilar;
            this.gridControlKullanicilar.Name = "gridControlKullanicilar";
            this.gridControlKullanicilar.Size = new System.Drawing.Size(800, 300);
            this.gridControlKullanicilar.TabIndex = 4;
            this.gridControlKullanicilar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKullanicilar});
            // 
            // gridViewKullanicilar
            // 
            this.gridViewKullanicilar.GridControl = this.gridControlKullanicilar;
            this.gridViewKullanicilar.Name = "gridViewKullanicilar";
            this.gridViewKullanicilar.OptionsBehavior.Editable = false;
            this.gridViewKullanicilar.OptionsView.ShowGroupPanel = false;
            // 
            // KullaniciSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 400);
            this.Controls.Add(this.gridControlKullanicilar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Controls.Add(this.labelKullaniciAdi);
            this.Name = "KullaniciSil";
            this.Text = "Kullanıcı Sil";
            this.Load += new System.EventHandler(this.KullaniciSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKullanicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
