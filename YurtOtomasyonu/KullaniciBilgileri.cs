using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace YurtOtomasyonu
{
    public partial class KullaniciBilgileri : DevExpress.XtraEditors.XtraForm
    {
        private string kullaniciAdi;

        // Constructor
        public KullaniciBilgileri(string kullaniciAdi)
        {
            InitializeComponent();
            this.kullaniciAdi = kullaniciAdi;
        }

        // Form yüklendiğinde kullanıcı bilgilerini al
        private void KullaniciBilgileri_Load(object sender, EventArgs e)
        {
            // Veritabanı bağlantısı
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True");

            try
            {
                // Kullanıcı bilgilerini çekmek için SQL sorgusu
                string query = "SELECT KullaniciAdi, Ad, Soyad, Email, Telefon, KayitTarihi FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Eğer kullanıcı bilgileri bulunduysa, text editlere aktaralım
                if (reader.HasRows)
                {
                    reader.Read();
                    textEditKullaniciAdi.Text = reader["KullaniciAdi"].ToString();
                    textEditAd.Text = reader["Ad"].ToString();
                    textEditSoyad.Text = reader["Soyad"].ToString();
                    textEditEmail.Text = reader["Email"].ToString();
                    textEditTelefon.Text = reader["Telefon"].ToString();
                    textEditKayitTarihi.Text = reader["KayitTarihi"].ToString();
                }
                else
                {
                    MessageBox.Show("Kullanıcı bilgileri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();

                // TextEdit özelliklerini ayarla
                textEditKullaniciAdi.Properties.ReadOnly = false; // Kullanıcı adı değiştirilebilir
                textEditKayitTarihi.Properties.ReadOnly = false;  // Kayıt tarihi değiştirilebilir
                textEditAd.Properties.ReadOnly = false;           // Ad düzenlenebilir
                textEditSoyad.Properties.ReadOnly = false;        // Soyad düzenlenebilir
                textEditEmail.Properties.ReadOnly = false;        // Email düzenlenebilir
                textEditTelefon.Properties.ReadOnly = false;      // Telefon düzenlenebilir
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Kullanıcı bilgileri boş mu kontrol edelim
            if (string.IsNullOrWhiteSpace(textEditAd.Text) ||
                string.IsNullOrWhiteSpace(textEditSoyad.Text) ||
                string.IsNullOrWhiteSpace(textEditEmail.Text) ||
                string.IsNullOrWhiteSpace(textEditTelefon.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True");

            try
            {
                // SQL sorgusunu oluşturuyoruz
                string query = "UPDATE Kullanicilar SET Ad = @Ad, Soyad = @Soyad, Email = @Email, Telefon = @Telefon WHERE KullaniciAdi = @KullaniciAdi";

                SqlCommand command = new SqlCommand(query, connection);
                // Parametreleri ekliyoruz
                command.Parameters.AddWithValue("@Ad", textEditAd.Text.Trim());
                command.Parameters.AddWithValue("@Soyad", textEditSoyad.Text.Trim());
                command.Parameters.AddWithValue("@Email", textEditEmail.Text.Trim());
                command.Parameters.AddWithValue("@Telefon", textEditTelefon.Text.Trim());
                command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu veya güncellenecek bilgi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
