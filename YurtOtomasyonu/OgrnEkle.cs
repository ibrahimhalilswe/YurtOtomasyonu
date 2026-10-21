using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace YurtOtomasyonu
{
    public partial class OgrnEkle : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True");

        public OgrnEkle()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            try
            {
                conn.Open();
                string komut = "SELECT * FROM Ogrenci_Bilgi";
                SqlDataAdapter da = new SqlDataAdapter(komut, conn);
                DataSet ds = new DataSet();

                textEdit1.Text = string.Empty;
                textEdit2.Text = string.Empty;
                textEdit3.Text = string.Empty;
                textEdit4.Text = string.Empty;
                textEdit5.Text = string.Empty;
                textEdit6.Text = string.Empty;
                textEdit7.Text = string.Empty;
                textEdit8.Text = string.Empty;
                textEdit9.Text = string.Empty;
                memoEdit1.Text = string.Empty;

                da.Fill(ds);

                if (ds.Tables.Count > 0)
                {
                    gridControl1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Veri tablosu boş.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri listeleme hatası: " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void Ekle()
        {
            if (string.IsNullOrWhiteSpace(textEdit1.Text) ||
                string.IsNullOrWhiteSpace(textEdit2.Text) ||
                string.IsNullOrWhiteSpace(textEdit3.Text) ||
                string.IsNullOrWhiteSpace(textEdit4.Text) ||
                string.IsNullOrWhiteSpace(textEdit5.Text) ||
                string.IsNullOrWhiteSpace(textEdit6.Text) ||
                string.IsNullOrWhiteSpace(textEdit7.Text) ||
                string.IsNullOrWhiteSpace(textEdit8.Text) ||
                string.IsNullOrWhiteSpace(textEdit9.Text) ||
                string.IsNullOrWhiteSpace(textEdit10.Text) ||  // YatakNo kontrolü
                string.IsNullOrWhiteSpace(memoEdit1.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            try
            {
                conn.Open();

                // Oda doluluk kontrolü (3 kişilik oda sınırı)
                SqlCommand odaKontrolCmd = new SqlCommand("SELECT COUNT(*) FROM OdaListesi WHERE OdaNo = @odano AND TCKimlikNo IS NOT NULL", conn);
                odaKontrolCmd.Parameters.AddWithValue("@odano", textEdit6.Text);
                int odaDoluKisiSayisi = (int)odaKontrolCmd.ExecuteScalar();

                if (odaDoluKisiSayisi >= 3)
                {
                    MessageBox.Show("Bu oda tamamen dolu! Lütfen başka bir oda seçin.");
                    return;
                }

                // Yatak doluluk kontrolü
                SqlCommand yatakKontrolCmd = new SqlCommand("SELECT COUNT(*) FROM OdaListesi WHERE OdaNo = @odano AND YatakNo = @yatakno AND TCKimlikNo IS NOT NULL", conn);
                yatakKontrolCmd.Parameters.AddWithValue("@odano", textEdit6.Text);
                yatakKontrolCmd.Parameters.AddWithValue("@yatakno", textEdit10.Text);
                int yatakDoluMu = (int)yatakKontrolCmd.ExecuteScalar();

                if (yatakDoluMu > 0)
                {
                    MessageBox.Show("Seçilen yatak dolu! Lütfen başka bir yatak seçin.");
                    return;
                }

                // Ogrenci_Bilgi tablosuna veri ekle
                SqlCommand cmd = new SqlCommand("INSERT INTO Ogrenci_Bilgi (OgrAd, OgrSoyAd, TCKimlikNo, OgrDogum, OgrTel, OdaNo, VeliAd, VeliSoyAd, VeliTel, OgrAdres) " +
                    "VALUES (@ograd, @ogrsoyad, @tckimlikno, @ogrdogum, @ogrtel, @odano, @veliad, @velisoyad, @velitel, @ogradres)", conn);

                cmd.Parameters.AddWithValue("@ograd", textEdit1.Text);
                cmd.Parameters.AddWithValue("@ogrsoyad", textEdit2.Text);
                cmd.Parameters.AddWithValue("@tckimlikno", textEdit3.Text);

                if (DateTime.TryParse(textEdit4.Text, out DateTime ogrDogum))
                {
                    cmd.Parameters.AddWithValue("@ogrdogum", ogrDogum);
                }
                else
                {
                    MessageBox.Show("Geçerli bir doğum tarihi girin.");
                    return;
                }

                cmd.Parameters.AddWithValue("@ogrtel", textEdit5.Text);
                cmd.Parameters.AddWithValue("@odano", textEdit6.Text);
                cmd.Parameters.AddWithValue("@veliad", textEdit7.Text);
                cmd.Parameters.AddWithValue("@velisoyad", textEdit8.Text);
                cmd.Parameters.AddWithValue("@velitel", textEdit9.Text);
                cmd.Parameters.AddWithValue("@ogradres", memoEdit1.Text);

                cmd.ExecuteNonQuery();

                // OdaListesi tablosuna veri güncelle
                SqlCommand odaCmd = new SqlCommand("UPDATE OdaListesi SET OgrAd = @ograd, OgrSoyAd = @ogrsoyad, TCKimlikNo = @tckimlikno " +
                    "WHERE OdaNo = @odano AND YatakNo = @yatakno", conn);

                odaCmd.Parameters.AddWithValue("@odano", textEdit6.Text);      // OdaNo'ya göre güncelleme
                odaCmd.Parameters.AddWithValue("@ograd", textEdit1.Text);      // Yeni OgrAd
                odaCmd.Parameters.AddWithValue("@ogrsoyad", textEdit2.Text);   // Yeni OgrSoyAd
                odaCmd.Parameters.AddWithValue("@tckimlikno", textEdit3.Text); // Yeni TCKimlikNo
                odaCmd.Parameters.AddWithValue("@yatakno", textEdit10.Text);   // YatakNo

                odaCmd.ExecuteNonQuery();

                // Ogrenci_Giris tablosuna veri ekle
                EkleOgrenciGiris(textEdit3.Text);

                MessageBox.Show("Kayıt başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri ekleme hatası: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void EkleOgrenciGiris(string tckimlikno)
        {
            try
            {
                // Önce Ogrenci_Giris tablosunda bu TCKimlikNo'nun olup olmadığını kontrol ediyoruz
                SqlCommand kontrolCmd = new SqlCommand("SELECT COUNT(*) FROM Ogrenci_Giris WHERE TC_KimlikNo = @tckimlikno", conn);
                kontrolCmd.Parameters.AddWithValue("@tckimlikno", tckimlikno);

                int kayitSayisi = (int)kontrolCmd.ExecuteScalar();
                if (kayitSayisi > 0)
                {
                    // Eğer TCKimlikNo zaten varsa işlem yapmıyoruz
                    return;
                }

                // Rastgele şifre oluştur
                string sifre = RastgeleSifreOlustur(8);

                // Yeni öğrenci kaydını ekliyoruz
                SqlCommand ekleCmd = new SqlCommand("INSERT INTO Ogrenci_Giris (TC_KimlikNo, OgrSifre) VALUES (@tckimlikno, @sifre)", conn);
                ekleCmd.Parameters.AddWithValue("@tckimlikno", tckimlikno);
                ekleCmd.Parameters.AddWithValue("@sifre", sifre);
                ekleCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ogrenci_Giris tablosuna ekleme hatası: " + ex.Message);
            }
        }

        private string RastgeleSifreOlustur(int uzunluk)
        {
            const string karakterler = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random rastgele = new Random();
            return new string(Enumerable.Repeat(karakterler, uzunluk)
                .Select(s => s[rastgele.Next(s.Length)]).ToArray());
        }

        private void OgrnEkle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }
    }
}
