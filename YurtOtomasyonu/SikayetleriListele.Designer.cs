using System;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace YurtOtomasyonu
{
    partial class SikayetleriListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private GridControl gridControlSikayet;
        private GridView gridViewSikayet;
        private TextEdit textEditAra;
        private LabelControl labelControlAra;
        private MemoEdit textEditSikayetDetay;
        private LabelControl labelControlDetay;
        private SimpleButton btnYenile;
        private SimpleButton btnGuncelle;
        private LabelControl labelControlYoneticiNotu;
        private ComboBoxEdit comboBoxEditDurum;
        private LabelControl labelControlDurum;

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
            this.gridControlSikayet = new DevExpress.XtraGrid.GridControl();
            this.gridViewSikayet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textEditAra = new DevExpress.XtraEditors.TextEdit();
            this.labelControlAra = new DevExpress.XtraEditors.LabelControl();
            this.textEditSikayetDetay = new DevExpress.XtraEditors.MemoEdit();
            this.labelControlDetay = new DevExpress.XtraEditors.LabelControl();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControlYoneticiNotu = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditDurum = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControlDurum = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.textEditYoneticiNotu = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSikayet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSikayet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSikayetDetay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditYoneticiNotu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlSikayet
            // 
            this.gridControlSikayet.Location = new System.Drawing.Point(12, 60);
            this.gridControlSikayet.MainView = this.gridViewSikayet;
            this.gridControlSikayet.Name = "gridControlSikayet";
            this.gridControlSikayet.Size = new System.Drawing.Size(1082, 350);
            this.gridControlSikayet.TabIndex = 0;
            this.gridControlSikayet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSikayet});
            // 
            // gridViewSikayet
            // 
            this.gridViewSikayet.GridControl = this.gridControlSikayet;
            this.gridViewSikayet.Name = "gridViewSikayet";
            this.gridViewSikayet.OptionsBehavior.Editable = false;
            this.gridViewSikayet.OptionsView.ShowGroupPanel = false;
            this.gridViewSikayet.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewSikayet_FocusedRowChanged);
            // 
            // textEditAra
            // 
            this.textEditAra.Location = new System.Drawing.Point(80, 20);
            this.textEditAra.Name = "textEditAra";
            this.textEditAra.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textEditAra.Properties.Appearance.Options.UseFont = true;
            this.textEditAra.Size = new System.Drawing.Size(300, 30);
            this.textEditAra.TabIndex = 1;
            this.textEditAra.EditValueChanged += new System.EventHandler(this.textEditAra_EditValueChanged);
            // 
            // labelControlAra
            // 
            this.labelControlAra.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelControlAra.Appearance.Options.UseFont = true;
            this.labelControlAra.Location = new System.Drawing.Point(21, 23);
            this.labelControlAra.Name = "labelControlAra";
            this.labelControlAra.Size = new System.Drawing.Size(38, 24);
            this.labelControlAra.TabIndex = 2;
            this.labelControlAra.Text = "Ara:";
            // 
            // textEditSikayetDetay
            // 
            this.textEditSikayetDetay.Location = new System.Drawing.Point(12, 450);
            this.textEditSikayetDetay.Name = "textEditSikayetDetay";
            this.textEditSikayetDetay.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textEditSikayetDetay.Properties.Appearance.Options.UseFont = true;
            this.textEditSikayetDetay.Properties.ReadOnly = true;
            this.textEditSikayetDetay.Size = new System.Drawing.Size(780, 80);
            this.textEditSikayetDetay.TabIndex = 3;
            // 
            // labelControlDetay
            // 
            this.labelControlDetay.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelControlDetay.Appearance.Options.UseFont = true;
            this.labelControlDetay.Location = new System.Drawing.Point(12, 420);
            this.labelControlDetay.Name = "labelControlDetay";
            this.labelControlDetay.Size = new System.Drawing.Size(160, 24);
            this.labelControlDetay.TabIndex = 4;
            this.labelControlDetay.Text = "Şikayet Detayları:";
            // 
            // btnYenile
            // 
            this.btnYenile.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnYenile.Appearance.Options.UseFont = true;
            this.btnYenile.Location = new System.Drawing.Point(856, 490);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(100, 40);
            this.btnYenile.TabIndex = 5;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.Location = new System.Drawing.Point(856, 536);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 40);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // labelControlYoneticiNotu
            // 
            this.labelControlYoneticiNotu.Location = new System.Drawing.Point(0, 0);
            this.labelControlYoneticiNotu.Name = "labelControlYoneticiNotu";
            this.labelControlYoneticiNotu.Size = new System.Drawing.Size(94, 17);
            this.labelControlYoneticiNotu.TabIndex = 0;
            // 
            // comboBoxEditDurum
            // 
            this.comboBoxEditDurum.Location = new System.Drawing.Point(856, 448);
            this.comboBoxEditDurum.Name = "comboBoxEditDurum";
            this.comboBoxEditDurum.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxEditDurum.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditDurum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditDurum.Properties.Items.AddRange(new object[] {
            "Beklemede",
            "İşlemde",
            "Tamamlandı"});
            this.comboBoxEditDurum.Size = new System.Drawing.Size(200, 30);
            this.comboBoxEditDurum.TabIndex = 7;
            // 
            // labelControlDurum
            // 
            this.labelControlDurum.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelControlDurum.Appearance.Options.UseFont = true;
            this.labelControlDurum.Location = new System.Drawing.Point(856, 420);
            this.labelControlDurum.Name = "labelControlDurum";
            this.labelControlDurum.Size = new System.Drawing.Size(66, 24);
            this.labelControlDurum.TabIndex = 8;
            this.labelControlDurum.Text = "Durum:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(411, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(123, 24);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Yönetici Notu:";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(12, 566);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.memoEdit1.Properties.Appearance.Options.UseFont = true;
            this.memoEdit1.Properties.ReadOnly = true;
            this.memoEdit1.Size = new System.Drawing.Size(780, 80);
            this.memoEdit1.TabIndex = 9;
            // 
            // textEditYoneticiNotu
            // 
            this.textEditYoneticiNotu.Location = new System.Drawing.Point(555, 17);
            this.textEditYoneticiNotu.Name = "textEditYoneticiNotu";
            this.textEditYoneticiNotu.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.textEditYoneticiNotu.Properties.Appearance.Options.UseFont = true;
            this.textEditYoneticiNotu.Size = new System.Drawing.Size(501, 30);
            this.textEditYoneticiNotu.TabIndex = 11;
            // 
            // SikayetleriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 670);
            this.Controls.Add(this.textEditYoneticiNotu);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControlDurum);
            this.Controls.Add(this.comboBoxEditDurum);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.labelControlDetay);
            this.Controls.Add(this.textEditSikayetDetay);
            this.Controls.Add(this.labelControlAra);
            this.Controls.Add(this.textEditAra);
            this.Controls.Add(this.gridControlSikayet);
            this.Name = "SikayetleriListele";
            this.Text = "Şikayetleri Listele";
            this.Load += new System.EventHandler(this.SikayetleriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSikayet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSikayet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSikayetDetay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditYoneticiNotu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private LabelControl labelControl1;
        private MemoEdit memoEdit1;
        private TextEdit textEditYoneticiNotu;
    }
}