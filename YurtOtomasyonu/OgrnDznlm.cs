using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace YurtOtomasyonu
{
    public partial class OgrnDznlm : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True");

        public OgrnDznlm()
        {
            InitializeComponent();
        }

        // Öğrenci bilgilerini listeleme fonksiyonu
        public void Listele()
        {
            try
            {
                // Bağlantıyı açıyoruz
                conn.Open();

                string komut = "SELECT * FROM Ogrenci_Bilgi";  // Veritabanından tüm öğrencileri alıyoruz
                SqlDataAdapter da = new SqlDataAdapter(komut, conn);
                DataSet ds = new DataSet();

                // Veritabanı verilerini DataSet'e çekiyoruz
                da.Fill(ds);

                if (ds.Tables.Count > 0)
                {
                    gridControl1.DataSource = ds.Tables[0]; // gridControl1'e veri bağlanıyor
                }
                else
                {
                    MessageBox.Show("Veri tablosu boş.");
                }
            }
            catch (Exception ex)
            {
                // Hata oluşursa kullanıcıya bildiriyoruz
                MessageBox.Show("Veri listeleme hatası: " + ex.ToString());
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                conn.Close();
            }
        }

        // T.C. Kimlik Numarası ile öğrenci bilgilerini getir
        public void Getir()
        {
            // T.C. Kimlik Numarasını boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(textEdit3.Text))
            {
                MessageBox.Show("Lütfen T.C. Kimlik Numarasını girin.");
                return;
            }

            try
            {
                // Bağlantıyı açıyoruz
                conn.Open();

                // Öğrenci bilgilerini T.C. Kimlik Numarasına göre alıyoruz
                SqlCommand cmd = new SqlCommand("SELECT * FROM Ogrenci_Bilgi WHERE TCKimlikNo = @tckimlikno", conn);
                cmd.Parameters.AddWithValue("@tckimlikno", textEdit3.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())  // Eğer kayıt bulunursa
                {
                    // Öğrenci bilgilerini textEdit kontrollerine aktar
                    textEdit1.Text = dr["OgrAd"].ToString();
                    textEdit2.Text = dr["OgrSoyAd"].ToString();
                    textEdit3.Text = dr["TCKimlikNo"].ToString();
                    textEdit4.Text = Convert.ToDateTime(dr["OgrDogum"]).ToString("yyyy-MM-dd");
                    textEdit5.Text = dr["OgrTel"].ToString();
                    textEdit6.Text = dr["OdaNo"].ToString();
                    textEdit7.Text = dr["VeliAd"].ToString();
                    textEdit8.Text = dr["VeliSoyAd"].ToString();
                    textEdit9.Text = dr["VeliTel"].ToString();
                    memoEdit1.Text = dr["OgrAdres"].ToString();
                }
                else
                {
                    MessageBox.Show("Bu T.C. Kimlik Numarası ile kayıt bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri getirme hatası: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                conn.Close();
            }
        }

        // Öğrenci bilgilerini güncelleme fonksiyonu
        public void Guncelle()
        {
            // T.C. Kimlik Numarasının boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(textEdit1.Text))
            {
                MessageBox.Show("Lütfen güncellenecek öğrencinin T.C. Kimlik Numarasını girin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textEdit2.Text) ||
                string.IsNullOrWhiteSpace(textEdit3.Text) ||
                string.IsNullOrWhiteSpace(textEdit4.Text) ||
                string.IsNullOrWhiteSpace(textEdit5.Text) ||
                string.IsNullOrWhiteSpace(textEdit6.Text) ||
                string.IsNullOrWhiteSpace(textEdit7.Text) ||
                string.IsNullOrWhiteSpace(textEdit8.Text) ||
                string.IsNullOrWhiteSpace(textEdit9.Text) ||
                string.IsNullOrWhiteSpace(memoEdit1.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            try
            {
                // Bağlantıyı açıyoruz
                conn.Open();

                // Güncelleme komutu
                SqlCommand cmd = new SqlCommand("UPDATE Ogrenci_Bilgi SET OgrAd = @ograd, OgrSoyAd = @ogrsoyad, OgrDogum = @ogrdogum, " +
                    "OgrTel = @ogrtel, OdaNo = @odano, VeliAd = @veliad, VeliSoyAd = @velisoyad, VeliTel = @velitel, OgrAdres = @ogradres WHERE TCKimlikNo = @tckimlikno", conn);

                cmd.Parameters.AddWithValue("@ograd", textEdit1.Text);
                cmd.Parameters.AddWithValue("@ogrsoyad", textEdit2.Text);
                cmd.Parameters.AddWithValue("@tckimlikno", textEdit3.Text);

                DateTime ogrDogum;
                if (DateTime.TryParse(textEdit4.Text, out ogrDogum))
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

                // Komut çalıştırılıyor ve etkilenen satır sayısı kontrol ediliyor
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Öğrenci bilgileri başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Bu T.C. Kimlik Numarası ile kayıt bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri güncelleme hatası: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                conn.Close();
            }
        }

        // Form yüklendiğinde yapılacak işlemler
        private void OgrnDznlm_Load(object sender, EventArgs e)
        {          
            Listele();
        }

        // Öğrenci bilgilerini getirmek için T.C. Kimlik Numarasını kontrol et
        private void BtnGetir_Click(object sender, EventArgs e)
        {
            Getir();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
    }
}
