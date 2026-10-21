using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace YurtOtomasyonu
{
    public partial class YoneticiFormu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string kullaniciAdi;
        public YoneticiFormu(string kullaniciAdi)  // Kullanıcı adını constructor ile alıyoruz
        {
            InitializeComponent();
            this.kullaniciAdi = kullaniciAdi;  // Kullanıcı adını saklıyoruz
        }

        private void BarButtonItem54_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Tüm açık MDI çocuk formlarını kapat
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            // Ana sayfa formunu kontrol et ve aç
            AnasayfaYntm AnaSayfa = Application.OpenForms["AnaSayfa"] as AnasayfaYntm;

            if (AnaSayfa == null)
            {
                AnaSayfa = new AnasayfaYntm();
                AnaSayfa.MdiParent = this; // Ana formun MDIParent olarak ayarlanması
                AnaSayfa.Show();
            }
            else
            {
                AnaSayfa.BringToFront(); // Eğer açıksa, öne getir
            }
        }

        private void YoneticiFormu_Load(object sender, EventArgs e)
        {
            // Ana sayfa formunu kontrol et ve aç
            AnasayfaYntm AnaSayfa = Application.OpenForms["AnaSayfa"] as AnasayfaYntm;

            if (AnaSayfa == null)
            {
                AnaSayfa = new AnasayfaYntm();
                AnaSayfa.MdiParent = this; // Ana formun MDIParent olarak ayarlanması
                AnaSayfa.Show();
            }
            else
            {
                AnaSayfa.BringToFront(); // Eğer açıksa, öne getir
            }
        }

        private void barButtonItem53_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Kullanıcıya onay sormak için bir dialog gösterelim
            DialogResult result = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?",
                                                  "Onay",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // Kullanıcı "Evet" seçerse program kapatılsın
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Uygulamayı tamamen kapatır
            }
        }

        private void barButtonItem47_ItemClick(object sender, ItemClickEventArgs e)
        {
            TalepListele TalepLst = new TalepListele
            {
                MdiParent = this
            };
            TalepLst.Show();
        }

        private void barButtonItem40_ItemClick(object sender, ItemClickEventArgs e)
        {
            EtkinlikIslemleri EtknlkEkle = new EtkinlikIslemleri
            {
                MdiParent = this
            };
            EtknlkEkle.Show();
        }

        private void barButtonItem38_ItemClick(object sender, ItemClickEventArgs e)
        {
            DuyuruIslemleri DyrEkle = new DuyuruIslemleri
            {
                MdiParent = this
            };
            DyrEkle.Show();
        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            Giderler OdemeDuzenle = new Giderler
            {
                MdiParent = this
            };
            OdemeDuzenle.Show();
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            AidatIslemleri AidatDuzenle = new AidatIslemleri
            {
                MdiParent = this
            };
            AidatDuzenle.Show();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            OdaDoluBosDrm OdaBosdolu = new OdaDoluBosDrm
            {
                MdiParent = this
            };
            OdaBosdolu.Show();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            OdaListele OdaLst = new OdaListele
            {
                MdiParent = this
            };
            OdaLst.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            OdaDznl Odaduznele = new OdaDznl
            {
                MdiParent = this
            };
            Odaduznele.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            OgrnBlgGrtlm OgrenciBilgiGrntl = new OgrnBlgGrtlm
            {
                MdiParent = this
            };
            OgrenciBilgiGrntl.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            OgrnDznlm OgrenciDuzenle = new OgrnDznlm
            {
                MdiParent = this
            };
            OgrenciDuzenle.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            OgrnSil OgrenciSil = new OgrnSil
            {
                MdiParent = this
            };
            OgrenciSil.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            OgrnEkle OgrenciEkleme = new OgrnEkle
            {
                MdiParent = this
            };
            OgrenciEkleme.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {

            // Kullanıcıya onay sormak için bir dialog gösterelim
            DialogResult result = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?",
                                                  "Onay",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // Kullanıcı "Evet" seçerse program kapatılsın
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Uygulamayı tamamen kapatır
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Tüm açık MDI çocuk formlarını kapat
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            // Ana sayfa formunu kontrol et ve aç
            AnasayfaYntm AnaSayfa = Application.OpenForms["AnaSayfa"] as AnasayfaYntm;

            if (AnaSayfa == null)
            {
                AnaSayfa = new AnasayfaYntm();
                AnaSayfa.MdiParent = this; // Ana formun MDIParent olarak ayarlanması
                AnaSayfa.Show();
            }
            else
            {
                AnaSayfa.BringToFront(); // Eğer açıksa, öne getir
            }
        }

        private void barButtonItem7_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            // Tüm açık MDI çocuk formlarını kapat
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            // Ana sayfa formunu kontrol et ve aç
            AnasayfaYntm AnaSayfa = Application.OpenForms["AnaSayfa"] as AnasayfaYntm;

            if (AnaSayfa == null)
            {
                AnaSayfa = new AnasayfaYntm();
                AnaSayfa.MdiParent = this; // Ana formun MDIParent olarak ayarlanması
                AnaSayfa.Show();
            }
            else
            {
                AnaSayfa.BringToFront(); // Eğer açıksa, öne getir
            }
        }

        private void barButtonItem49_ItemClick(object sender, ItemClickEventArgs e)
        {
            SikayetleriListele SikayetlerListele = new SikayetleriListele
            {
                MdiParent = this
            };
            SikayetlerListele.Show();
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            KullaniciEkle Kullaniciekle = new KullaniciEkle
            {
                MdiParent = this
            };
            Kullaniciekle.Show();
        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            KullaniciSil kullanicisil = new KullaniciSil
            {
                MdiParent = this
            };
            kullanicisil.Show();
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            KullaniciBilgileri kullaniciBilgileriFormu = new KullaniciBilgileri(kullaniciAdi)
            {
                MdiParent = this
            };
            kullaniciBilgileriFormu.Show();
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            KullaniciSifreDegistir KullaniciSifre = new KullaniciSifreDegistir(kullaniciAdi)
            {
                MdiParent = this
            };
            KullaniciSifre.Show();
        }
    }
}