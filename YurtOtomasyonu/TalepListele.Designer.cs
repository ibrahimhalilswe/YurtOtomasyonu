using System;
using DevExpress.XtraGrid.Views.Base;

namespace YurtOtomasyonu
{
    partial class TalepListele
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
            this.components = new System.ComponentModel.Container();
            this.gridControlTalep = new DevExpress.XtraGrid.GridControl();
            this.gridViewTalep = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnOnayla = new DevExpress.XtraEditors.SimpleButton();
            this.btnReddet = new DevExpress.XtraEditors.SimpleButton();
            this.btnDetay = new DevExpress.XtraEditors.SimpleButton();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textEditAra = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.textEditYoneticiNotu = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.timerTalepKontrol = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTalep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTalep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditYoneticiNotu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlTalep
            // 
            this.gridControlTalep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlTalep.Location = new System.Drawing.Point(0, 150);
            this.gridControlTalep.MainView = this.gridViewTalep;
            this.gridControlTalep.Name = "gridControlTalep";
            this.gridControlTalep.Size = new System.Drawing.Size(1100, 350);
            this.gridControlTalep.TabIndex = 0;
            this.gridControlTalep.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTalep});
            // 
            // gridViewTalep
            // 
            this.gridViewTalep.GridControl = this.gridControlTalep;
            this.gridViewTalep.Name = "gridViewTalep";
            this.gridViewTalep.OptionsView.ShowGroupPanel = false;
            this.gridViewTalep.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewTalep_FocusedRowChanged);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnOnayla.Appearance.Options.UseFont = true;
            this.btnOnayla.Location = new System.Drawing.Point(30, 30);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(120, 35);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnReddet
            // 
            this.btnReddet.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnReddet.Appearance.Options.UseFont = true;
            this.btnReddet.Location = new System.Drawing.Point(170, 30);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(120, 35);
            this.btnReddet.TabIndex = 2;
            this.btnReddet.Text = "Reddet";
            this.btnReddet.Click += new System.EventHandler(this.btnReddet_Click);
            // 
            // btnDetay
            // 
            this.btnDetay.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnDetay.Appearance.Options.UseFont = true;
            this.btnDetay.Location = new System.Drawing.Point(310, 30);
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.Size = new System.Drawing.Size(120, 35);
            this.btnDetay.TabIndex = 3;
            this.btnDetay.Text = "Detay";
            this.btnDetay.Click += new System.EventHandler(this.btnDetay_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnYenile.Appearance.Options.UseFont = true;
            this.btnYenile.Location = new System.Drawing.Point(450, 30);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(120, 35);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "Güncelle";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(610, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Talep Arama:";
            // 
            // textEditAra
            // 
            this.textEditAra.Location = new System.Drawing.Point(750, 30);
            this.textEditAra.Name = "textEditAra";
            this.textEditAra.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textEditAra.Properties.Appearance.Options.UseFont = true;
            this.textEditAra.Size = new System.Drawing.Size(300, 30);
            this.textEditAra.TabIndex = 6;
            this.textEditAra.EditValueChanged += new System.EventHandler(this.textEditAra_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(750, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Aramak için bir kelime girin";
            // 
            // textEditYoneticiNotu
            // 
            this.textEditYoneticiNotu.Location = new System.Drawing.Point(750, 94);
            this.textEditYoneticiNotu.Name = "textEditYoneticiNotu";
            this.textEditYoneticiNotu.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textEditYoneticiNotu.Properties.Appearance.Options.UseFont = true;
            this.textEditYoneticiNotu.Size = new System.Drawing.Size(300, 30);
            this.textEditYoneticiNotu.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(551, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yönetici Açıklaması:";
            // 
            // timerTalepKontrol
            // 
            this.timerTalepKontrol.Interval = 60000;
            // 
            // TalepListele
            // 
            this.ClientSize = new System.Drawing.Size(1100, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textEditYoneticiNotu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textEditAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnDetay);
            this.Controls.Add(this.btnReddet);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.gridControlTalep);
            this.Name = "TalepListele";
            this.Text = "Talep Listeleme";
            this.Load += new System.EventHandler(this.TalepListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTalep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTalep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditYoneticiNotu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlTalep;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTalep;
        private DevExpress.XtraEditors.SimpleButton btnOnayla;
        private DevExpress.XtraEditors.SimpleButton btnReddet;
        private DevExpress.XtraEditors.SimpleButton btnDetay;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEditAra;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEditYoneticiNotu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerTalepKontrol;
    }
}
