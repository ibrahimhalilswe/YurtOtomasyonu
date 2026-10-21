using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YurtOtomasyonu
{
    public partial class KullaniciEkle : DevExpress.XtraEditors.XtraForm
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Kullanıcı girişlerini al
            string kullaniciAdi = textBoxKullaniciAdi.Text;
            string sifre = textBoxSifre.Text;
            string ad = textBoxAd.Text;
            string soyad = textBoxSoyad.Text;
            string eposta = textBoxEposta.Text;
            string telefon = textBoxTelefon.Text;

            // Girişlerin geçerliliğini kontrol et
            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre) ||
                string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) ||
                string.IsNullOrEmpty(eposta) || string.IsNullOrEmpty(telefon))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kullanıcıyı veritabanına ekle
            try
            {
                // Veritabanı ekleme fonksiyonu
                AddUserToDatabase(kullaniciAdi, sifre, ad, soyad, eposta, telefon);
                MessageBox.Show("Kullanıcı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Formu temizle
                textBoxKullaniciAdi.Text = string.Empty;
                textBoxSifre.Text = string.Empty;
                textBoxAd.Text = string.Empty;
                textBoxSoyad.Text = string.Empty;
                textBoxEposta.Text = string.Empty;
                textBoxTelefon.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kullanıcıyı veritabanına eklemek için metod
        private void AddUserToDatabase(string kullaniciAdi, string sifre, string ad, string soyad, string eposta, string telefon)
        {
            // Bağlantı dizesi
            string connectionString = "Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True";

            // SQL sorgusu (Kullanıcı ekleme)
            string query = "INSERT INTO Kullanicilar (KullaniciAdi, Sifre, Ad, Soyad, Email, Telefon) " +
                           "VALUES (@KullaniciAdi, @Sifre, @Ad, @Soyad, @Email, @Telefon)";

            // Veritabanı bağlantısını kur
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                command.Parameters.AddWithValue("@Sifre", sifre);
                command.Parameters.AddWithValue("@Ad", ad);
                command.Parameters.AddWithValue("@Soyad", soyad);
                command.Parameters.AddWithValue("@Email", eposta);
                command.Parameters.AddWithValue("@Telefon", telefon);

                // Bağlantıyı aç ve sorguyu çalıştır
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
