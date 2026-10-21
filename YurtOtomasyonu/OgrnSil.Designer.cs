using DevExpress.XtraGrid.Columns;

namespace YurtOtomasyonu
{
    partial class OgrnSil
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOgrAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrSoyAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTCKimlikNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrDogum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdaNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVeliAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVeliSoyAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVeliTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BtnSil);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1106, 652);
            this.splitContainer1.SplitterDistance = 368;
            this.splitContainer1.TabIndex = 0;
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold);
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = global::YurtOtomasyonu.Properties.Resources.delete_32x32;
            this.BtnSil.Location = new System.Drawing.Point(197, 203);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(123, 41);
            this.BtnSil.TabIndex = 22;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(70, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 29);
            this.label11.TabIndex = 21;
            this.label11.Text = "Öğrenci Silme Sistemi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(48, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC Kimlik No:";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(176, 126);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold);
            this.textEdit3.Properties.Appearance.Options.UseFont = true;
            this.textEdit3.Size = new System.Drawing.Size(159, 28);
            this.textEdit3.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(734, 652);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOgrAd,
            this.colOgrSoyAd,
            this.colTCKimlikNo,
            this.colOgrDogum,
            this.colOgrTel,
            this.colOdaNo,
            this.colVeliAd,
            this.colVeliSoyAd,
            this.colVeliTel,
            this.colOgrAdres});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colOgrAd
            // 
            this.colOgrAd.FieldName = "OgrAd";
            this.colOgrAd.Name = "colOgrAd";
            this.colOgrAd.Visible = true;
            this.colOgrAd.VisibleIndex = 0;
            // 
            // colOgrSoyAd
            // 
            this.colOgrSoyAd.FieldName = "OgrSoyAd";
            this.colOgrSoyAd.Name = "colOgrSoyAd";
            this.colOgrSoyAd.Visible = true;
            this.colOgrSoyAd.VisibleIndex = 1;
            // 
            // colTCKimlikNo
            // 
            this.colTCKimlikNo.FieldName = "TCKimlikNo";
            this.colTCKimlikNo.Name = "colTCKimlikNo";
            this.colTCKimlikNo.Visible = true;
            this.colTCKimlikNo.VisibleIndex = 2;
            // 
            // colOgrDogum
            // 
            this.colOgrDogum.FieldName = "OgrDogum";
            this.colOgrDogum.Name = "colOgrDogum";
            this.colOgrDogum.Visible = true;
            this.colOgrDogum.VisibleIndex = 3;
            // 
            // colOgrTel
            // 
            this.colOgrTel.FieldName = "OgrTel";
            this.colOgrTel.Name = "colOgrTel";
            this.colOgrTel.Visible = true;
            this.colOgrTel.VisibleIndex = 4;
            // 
            // colOdaNo
            // 
            this.colOdaNo.FieldName = "OdaNo";
            this.colOdaNo.Name = "colOdaNo";
            this.colOdaNo.Visible = true;
            this.colOdaNo.VisibleIndex = 5;
            // 
            // colVeliAd
            // 
            this.colVeliAd.FieldName = "VeliAd";
            this.colVeliAd.Name = "colVeliAd";
            this.colVeliAd.Visible = true;
            this.colVeliAd.VisibleIndex = 6;
            // 
            // colVeliSoyAd
            // 
            this.colVeliSoyAd.FieldName = "VeliSoyAd";
            this.colVeliSoyAd.Name = "colVeliSoyAd";
            this.colVeliSoyAd.Visible = true;
            this.colVeliSoyAd.VisibleIndex = 7;
            // 
            // colVeliTel
            // 
            this.colVeliTel.FieldName = "VeliTel";
            this.colVeliTel.Name = "colVeliTel";
            this.colVeliTel.Visible = true;
            this.colVeliTel.VisibleIndex = 8;
            // 
            // colOgrAdres
            // 
            this.colOgrAdres.FieldName = "OgrAdres";
            this.colOgrAdres.Name = "colOgrAdres";
            this.colOgrAdres.Visible = true;
            this.colOgrAdres.VisibleIndex = 9;
            // 
            // OgrnSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 652);
            this.Controls.Add(this.splitContainer1);
            this.Name = "OgrnSil";
            this.Text = "Öğrenci Sil";
            this.Load += new System.EventHandler(this.OgrnSil_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private GridColumn colOgrAd;
        private GridColumn colOgrSoyAd;
        private GridColumn colTCKimlikNo;
        private GridColumn colOgrDogum;
        private GridColumn colOgrTel;
        private GridColumn colOdaNo;
        private GridColumn colVeliAd;
        private GridColumn colVeliSoyAd;
        private GridColumn colVeliTel;
        private GridColumn colOgrAdres;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private System.Windows.Forms.Label label11;
    }
}