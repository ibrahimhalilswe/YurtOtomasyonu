using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace YurtOtomasyonu
{
    public partial class OgrnSil : DevExpress.XtraEditors.XtraForm
    {
        // Veritabanı bağlantısı
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True");

        public OgrnSil()
        {
            InitializeComponent();
        }

        // Öğrenci silme fonksiyonu
        public void Sil()
        {
            // T.C. Kimlik Numarasının boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(textEdit3.Text))
            {
                MessageBox.Show("Lütfen silinecek öğrencinin T.C. Kimlik Numarasını girin.");
                return;
            }

            SqlTransaction transaction = null;
            try
            {
                // Bağlantıyı açıyoruz
                conn.Open();

                // İşlem başlatıyoruz
                transaction = conn.BeginTransaction();

                // Ogrenci_Bilgi tablosundan öğrenci bilgilerini silme
                string query1 = "DELETE FROM Ogrenci_Bilgi WHERE TCKimlikNo = @tckimlikno";
                SqlCommand cmd1 = new SqlCommand(query1, conn, transaction);
                cmd1.Parameters.AddWithValue("@tckimlikno", textEdit3.Text);

                int rowsAffected1 = cmd1.ExecuteNonQuery();

                // OdaListesi tablosunda öğrenciye ait bilgileri silme (OdaNo'yu koruyarak)
                string query2 = "UPDATE OdaListesi SET OgrAd = NULL, OgrSoyAd = NULL, TCKimlikNo = NULL WHERE TCKimlikNo = @tckimlikno";
                SqlCommand cmd2 = new SqlCommand(query2, conn, transaction);
                cmd2.Parameters.AddWithValue("@tckimlikno", textEdit3.Text);

                int rowsAffected2 = cmd2.ExecuteNonQuery();

                // Ogrenci_Giris tablosundan öğrenci bilgilerini silme
                string query3 = "DELETE FROM Ogrenci_Giris WHERE TC_KimlikNo = @tckimlikno";
                SqlCommand cmd3 = new SqlCommand(query3, conn, transaction);
                cmd3.Parameters.AddWithValue("@tckimlikno", textEdit3.Text);

                int rowsAffected3 = cmd3.ExecuteNonQuery();

                // Eğer en az bir tabloya ait kayıt silindiyse işlemi onaylıyoruz
                if (rowsAffected1 > 0 || rowsAffected2 > 0 || rowsAffected3 > 0)
                {
                    transaction.Commit();
                    MessageBox.Show("Öğrenci bilgileri başarıyla silindi ve oda boşaltıldı.");
                }
                else
                {
                    // Hiçbir tablo güncellenmediyse işlemi geri alıyoruz
                    transaction.Rollback();
                    MessageBox.Show("Bu T.C. Kimlik Numarası ile kayıt bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                // Hata oluşursa, işlemi geri alıyoruz
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show("Veri silme hatası: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                conn.Close();
            }
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

        // Form yüklendiğinde yapılacak işlemler
        private void OgrnSil_Load(object sender, EventArgs e)
        {
            // Listele fonksiyonu çağrılıyor
            Listele();
        }

        // Silme butonuna tıklanıldığında
        private void BtnSil_Click(object sender, EventArgs e)
        {
            Sil();  // Silme fonksiyonunu çağırıyoruz
        }
    }
}
