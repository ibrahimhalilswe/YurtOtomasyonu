namespace YurtOtomasyonu
{
    partial class TalepSikayetGoster
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
            this.tckimlikNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.durumTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.yoneticiNotuMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.refreshButton = new DevExpress.XtraEditors.SimpleButton();
            this.lblTCKimlikNo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tckimlikNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durumTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiNotuMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tckimlikNoTextEdit
            // 
            this.tckimlikNoTextEdit.Location = new System.Drawing.Point(158, 20);
            this.tckimlikNoTextEdit.Name = "tckimlikNoTextEdit";
            this.tckimlikNoTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.tckimlikNoTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tckimlikNoTextEdit.Properties.ReadOnly = true;
            this.tckimlikNoTextEdit.Size = new System.Drawing.Size(200, 30);
            this.tckimlikNoTextEdit.TabIndex = 0;
            // 
            // durumTextEdit
            // 
            this.durumTextEdit.Location = new System.Drawing.Point(158, 70);
            this.durumTextEdit.Name = "durumTextEdit";
            this.durumTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.durumTextEdit.Properties.Appearance.Options.UseFont = true;
            this.durumTextEdit.Properties.ReadOnly = true;
            this.durumTextEdit.Size = new System.Drawing.Size(200, 30);
            this.durumTextEdit.TabIndex = 1;
            // 
            // yoneticiNotuMemoEdit
            // 
            this.yoneticiNotuMemoEdit.Location = new System.Drawing.Point(522, 22);
            this.yoneticiNotuMemoEdit.Name = "yoneticiNotuMemoEdit";
            this.yoneticiNotuMemoEdit.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.yoneticiNotuMemoEdit.Properties.Appearance.Options.UseFont = true;
            this.yoneticiNotuMemoEdit.Properties.ReadOnly = true;
            this.yoneticiNotuMemoEdit.Size = new System.Drawing.Size(400, 100);
            this.yoneticiNotuMemoEdit.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(20, 176);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(500, 274);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(550, 176);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(500, 274);
            this.gridControl2.TabIndex = 4;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Appearance.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.refreshButton.Appearance.Options.UseFont = true;
            this.refreshButton.Location = new System.Drawing.Point(950, 92);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(100, 30);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Yenile";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // lblTCKimlikNo
            // 
            this.lblTCKimlikNo.Appearance.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold);
            this.lblTCKimlikNo.Appearance.Options.UseFont = true;
            this.lblTCKimlikNo.Location = new System.Drawing.Point(20, 26);
            this.lblTCKimlikNo.Name = "lblTCKimlikNo";
            this.lblTCKimlikNo.Size = new System.Drawing.Size(110, 21);
            this.lblTCKimlikNo.TabIndex = 6;
            this.lblTCKimlikNo.Text = "T.C. Kimlik No:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(20, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 21);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Durum:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(386, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 21);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Yönetici Notu:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(20, 149);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 21);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Talepler:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(550, 149);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 21);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Şikayetler:";
            // 
            // TalepSikayetGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 500);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblTCKimlikNo);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.yoneticiNotuMemoEdit);
            this.Controls.Add(this.durumTextEdit);
            this.Controls.Add(this.tckimlikNoTextEdit);
            this.Name = "TalepSikayetGoster";
            this.Text = "Talep ve Şikayet Gösterimi";
            ((System.ComponentModel.ISupportInitialize)(this.tckimlikNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durumTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiNotuMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.XtraEditors.TextEdit tckimlikNoTextEdit;
        private DevExpress.XtraEditors.TextEdit durumTextEdit;
        private DevExpress.XtraEditors.MemoEdit yoneticiNotuMemoEdit;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton refreshButton;
        private DevExpress.XtraEditors.LabelControl lblTCKimlikNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}
