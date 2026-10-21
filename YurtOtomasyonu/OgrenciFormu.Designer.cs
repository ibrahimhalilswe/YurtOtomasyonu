namespace YurtOtomasyonu
{
    partial class OgrenciFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciFormu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnTaleplerGonder = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSikayet = new DevExpress.XtraBars.BarButtonItem();
            this.BtnTlpSkytGrnt = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAidat = new DevExpress.XtraBars.BarButtonItem();
            this.BtnEtkinliktkb = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGuncelDyr = new DevExpress.XtraBars.BarButtonItem();
            this.BtnProfilGrnt = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSfrDgstr = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAnaSyf = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.BtnOdemeGcms = new DevExpress.XtraBars.BarButtonItem();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnTaleplerGonder,
            this.BtnSikayet,
            this.BtnTlpSkytGrnt,
            this.BtnAidat,
            this.BtnEtkinliktkb,
            this.BtnGuncelDyr,
            this.BtnProfilGrnt,
            this.BtnSfrDgstr,
            this.barButtonItem11,
            this.BtnAnaSyf,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 16;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1198, 207);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnTaleplerGonder
            // 
            this.btnTaleplerGonder.Caption = "Talep Gönder";
            this.btnTaleplerGonder.Id = 1;
            this.btnTaleplerGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaleplerGonder.ImageOptions.Image")));
            this.btnTaleplerGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaleplerGonder.ImageOptions.LargeImage")));
            this.btnTaleplerGonder.Name = "btnTaleplerGonder";
            this.btnTaleplerGonder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaleplerGonder_ItemClick_1);
            // 
            // BtnSikayet
            // 
            this.BtnSikayet.Caption = "Şikayet Gönder";
            this.BtnSikayet.Id = 3;
            this.BtnSikayet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSikayet.ImageOptions.Image")));
            this.BtnSikayet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnSikayet.ImageOptions.LargeImage")));
            this.BtnSikayet.Name = "BtnSikayet";
            this.BtnSikayet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSikayet_ItemClick);
            // 
            // BtnTlpSkytGrnt
            // 
            this.BtnTlpSkytGrnt.Caption = "Talep ve Şikayet Durumu Görüntüle";
            this.BtnTlpSkytGrnt.Id = 4;
            this.BtnTlpSkytGrnt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTlpSkytGrnt.ImageOptions.Image")));
            this.BtnTlpSkytGrnt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnTlpSkytGrnt.ImageOptions.LargeImage")));
            this.BtnTlpSkytGrnt.Name = "BtnTlpSkytGrnt";
            this.BtnTlpSkytGrnt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnTlpSkytGrnt_ItemClick);
            // 
            // BtnAidat
            // 
            this.BtnAidat.Caption = "Aidat Durumu";
            this.BtnAidat.Id = 5;
            this.BtnAidat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAidat.ImageOptions.Image")));
            this.BtnAidat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAidat.ImageOptions.LargeImage")));
            this.BtnAidat.Name = "BtnAidat";
            this.BtnAidat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAidat_ItemClick);
            // 
            // BtnEtkinliktkb
            // 
            this.BtnEtkinliktkb.Caption = "Etkinlik Takvimi";
            this.BtnEtkinliktkb.Id = 7;
            this.BtnEtkinliktkb.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEtkinliktkb.ImageOptions.Image")));
            this.BtnEtkinliktkb.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnEtkinliktkb.ImageOptions.LargeImage")));
            this.BtnEtkinliktkb.Name = "BtnEtkinliktkb";
            this.BtnEtkinliktkb.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnEtkinliktkb_ItemClick);
            // 
            // BtnGuncelDyr
            // 
            this.BtnGuncelDyr.Caption = "Duyurular";
            this.BtnGuncelDyr.Id = 8;
            this.BtnGuncelDyr.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelDyr.ImageOptions.Image")));
            this.BtnGuncelDyr.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnGuncelDyr.ImageOptions.LargeImage")));
            this.BtnGuncelDyr.Name = "BtnGuncelDyr";
            this.BtnGuncelDyr.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGuncelDyr_ItemClick);
            // 
            // BtnProfilGrnt
            // 
            this.BtnProfilGrnt.Caption = "Profil Bilgilerimi Görüntüle";
            this.BtnProfilGrnt.Id = 9;
            this.BtnProfilGrnt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnProfilGrnt.ImageOptions.Image")));
            this.BtnProfilGrnt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnProfilGrnt.ImageOptions.LargeImage")));
            this.BtnProfilGrnt.Name = "BtnProfilGrnt";
            this.BtnProfilGrnt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnProfilGrnt_ItemClick);
            // 
            // BtnSfrDgstr
            // 
            this.BtnSfrDgstr.Caption = "Şifre Değiştir";
            this.BtnSfrDgstr.Id = 10;
            this.BtnSfrDgstr.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSfrDgstr.ImageOptions.Image")));
            this.BtnSfrDgstr.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnSfrDgstr.ImageOptions.LargeImage")));
            this.BtnSfrDgstr.Name = "BtnSfrDgstr";
            this.BtnSfrDgstr.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSfrDgstr_ItemClick);
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "barButtonItem11";
            this.barButtonItem11.Id = 11;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // BtnAnaSyf
            // 
            this.BtnAnaSyf.Caption = "Ana Sayfa";
            this.BtnAnaSyf.Id = 14;
            this.BtnAnaSyf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnaSyf.ImageOptions.Image")));
            this.BtnAnaSyf.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAnaSyf.ImageOptions.LargeImage")));
            this.BtnAnaSyf.Name = "BtnAnaSyf";
            this.BtnAnaSyf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAnaSyf_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Çıkış";
            this.barButtonItem1.Id = 15;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7,
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Öğrenci İşlemleri";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ImageOptions.ImageIndex = 5;
            this.ribbonPageGroup7.ItemLinks.Add(this.BtnAnaSyf);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Ana Sayfa";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTaleplerGonder);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnSikayet);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnTlpSkytGrnt);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Talep ve Şikayetler";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnAidat);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Aidat Durumu";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnEtkinliktkb);
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnGuncelDyr, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Etkinlik ve Duyurular";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.BtnProfilGrnt);
            this.ribbonPageGroup4.ItemLinks.Add(this.BtnSfrDgstr);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Hesap ve Güvenlik";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Çıkış";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 1071);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1198, 28);
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Yardım";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 178);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1113, 700);
            this.fluentDesignFormContainer1.TabIndex = 2;
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = null;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(0, 38);
            this.fluentDesignFormControl1.TabIndex = 3;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // BtnOdemeGcms
            // 
            this.BtnOdemeGcms.Caption = "Ödeme Geçmişi";
            this.BtnOdemeGcms.Id = 6;
            this.BtnOdemeGcms.ImageOptions.Image = global::YurtOtomasyonu.Properties.Resources.charttitlescenteredoverlaytitle_16x16;
            this.BtnOdemeGcms.ImageOptions.LargeImage = global::YurtOtomasyonu.Properties.Resources.charttitlescenteredoverlaytitle_32x32;
            this.BtnOdemeGcms.Name = "BtnOdemeGcms";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Black";
            // 
            // OgrenciFormu
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 1099);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.IsMdiContainer = true;
            this.Name = "OgrenciFormu";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Ogrenci Formu";
            this.Load += new System.EventHandler(this.OgrenciFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnTaleplerGonder;
        private DevExpress.XtraBars.BarButtonItem BtnSikayet;
        private DevExpress.XtraBars.BarButtonItem BtnTlpSkytGrnt;
        private DevExpress.XtraBars.BarButtonItem BtnAidat;
        private DevExpress.XtraBars.BarButtonItem BtnEtkinliktkb;
        private DevExpress.XtraBars.BarButtonItem BtnGuncelDyr;
        private DevExpress.XtraBars.BarButtonItem BtnProfilGrnt;
        private DevExpress.XtraBars.BarButtonItem BtnSfrDgstr;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem BtnAnaSyf;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraBars.BarButtonItem BtnOdemeGcms;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}