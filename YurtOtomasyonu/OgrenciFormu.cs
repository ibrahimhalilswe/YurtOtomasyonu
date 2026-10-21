using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.FluentDesignSystem;

namespace YurtOtomasyonu
{
    public partial class OgrenciFormu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string TcKimlikNo; // Kimlik numarasını saklamak için bir alan

        public OgrenciFormu(string tcKimlikNo) // Kimlik numarasını constructor ile alıyoruz
        {
            InitializeComponent();
            TcKimlikNo = tcKimlikNo; // Gelen kimlik numarasını saklıyoruz
        }

        public static implicit operator FluentDesignForm(OgrenciFormu v)
        {
            throw new NotImplementedException();
        }

        private void BtnSikayet_ItemClick(object sender, ItemClickEventArgs e)
        {
            SikayetGonder SkytTlb = new SikayetGonder(TcKimlikNo)
            {
                MdiParent = this
            };
            SkytTlb.Show();
        }

        private void BtnTlpSkytGrnt_ItemClick(object sender, ItemClickEventArgs e)
        {
            TalepSikayetGoster TlbSkytGrtl = new TalepSikayetGoster(TcKimlikNo)
            {
                MdiParent = this
            };
            TlbSkytGrtl.Show();
        }

        private void BtnAidat_ItemClick(object sender, ItemClickEventArgs e)
        {
            AidatDrm AidatDurum = new AidatDrm(TcKimlikNo)
            {
                MdiParent = this
            };
            AidatDurum.Show();
        }

        private void BtnEtkinliktkb_ItemClick(object sender, ItemClickEventArgs e)
        {
            EtkinlikTkb EtkinlikTkbi = new EtkinlikTkb
            {
                MdiParent = this
            };
            EtkinlikTkbi.Show();
        }

        private void BtnGuncelDyr_ItemClick(object sender, ItemClickEventArgs e)
        {
            Duyurular GuncelDuyuru = new Duyurular
            {
                MdiParent = this
            };
            GuncelDuyuru.Show();
        }

        private void BtnProfilGrnt_ItemClick(object sender, ItemClickEventArgs e)
        {
            ProfilBlgGrnt ProfilBilgiGrnt = new ProfilBlgGrnt(TcKimlikNo)
            {
                MdiParent = this
            };
            ProfilBilgiGrnt.Show();
        }

        private void BtnSfrDgstr_ItemClick(object sender, ItemClickEventArgs e)
        {
            SifreDgstr SifreDegistir = new SifreDgstr(TcKimlikNo)
            {
                MdiParent = this
            };
            SifreDegistir.Show();
        }

        private void BtnAnaSyf_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Tüm açık MDI çocuk formlarını kapat
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            // Ana sayfa formunu kontrol et ve aç
            AnaSayfaFormuOgr anaSayfa = Application.OpenForms["AnaSayfaFormu"] as AnaSayfaFormuOgr;

            if (anaSayfa == null)
            {
                anaSayfa = new AnaSayfaFormuOgr();
                anaSayfa.MdiParent = this; // Ana formun MDIParent olarak ayarlanması
                anaSayfa.Show();
            }
            else
            {
                anaSayfa.BringToFront(); // Eğer açıksa, öne getir
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
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

        private void OgrenciFormu_Load(object sender, EventArgs e)
        {
            // Ana sayfa formunu kontrol et ve aç
            AnaSayfaFormuOgr anaSayfa = Application.OpenForms["AnaSayfaFormu"] as AnaSayfaFormuOgr;

            if (anaSayfa == null)
            {
                anaSayfa = new AnaSayfaFormuOgr();
                anaSayfa.MdiParent = this; // Ana formun MDIParent olarak ayarlanması
                anaSayfa.Show();
            }
            else
            {
                anaSayfa.BringToFront(); // Eğer açıksa, öne getir
            }
        }

        private void btnTaleplerGonder_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            // TalepGonder formunu, kimlik numarası parametresi ile başlatıyoruz
            TalepGonder talepGonderFormu = new TalepGonder(TcKimlikNo) // TalepGonder constructor parametre alıyor
            {
                MdiParent = this
            };
            talepGonderFormu.Show();
        }
    }
}
