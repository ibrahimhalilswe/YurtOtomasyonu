using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace YurtOtomasyonu
{
    public partial class KullaniciSifreDegistir : DevExpress.XtraEditors.XtraForm
    {
        private string kullaniciAdi;

        // Constructor
        public KullaniciSifreDegistir(string kullaniciAdi)
        {
            InitializeComponent();
            this.kullaniciAdi = kullaniciAdi;
        }

        // Form yüklendiğinde kullanıcı adı textEditKullaniciAdi'ye aktarılır.
        private void KullaniciSifreDegistir_Load(object sender, EventArgs e)
        {
            textEditKullaniciAdi.Text = this.kullaniciAdi;
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı, eski şifre, yeni şifre ve yeni şifre tekrarının boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(textEditKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(textEditEskiSifre.Text) ||
                string.IsNullOrWhiteSpace(textEditYeniSifre.Text) ||
                string.IsNullOrWhiteSpace(textEditYeniSifreTekrar.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurduğunuzdan emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Yeni şifre ve yeni şifre tekrarını karşılaştır
            if (textEditYeniSifre.Text != textEditYeniSifreTekrar.Text)
            {
                MessageBox.Show("Yeni şifreler uyuşmuyor. Lütfen aynı şifreyi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True");

            try
            {
                // Kullanıcı adını ve eski şifreyi kontrol et
                string query = "SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @EskiSifre";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KullaniciAdi", textEditKullaniciAdi.Text.Trim());
                command.Parameters.AddWithValue("@EskiSifre", textEditEskiSifre.Text.Trim());

                connection.Open();
                int userExists = (int)command.ExecuteScalar(); // Kullanıcı adı ve şifreyi kontrol et

                if (userExists == 0)
                {
                    MessageBox.Show("Kullanıcı adı veya eski şifre yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    connection.Close();
                    return;
                }

                // Şifreyi güncelleme işlemi
                string updateQuery = "UPDATE Kullanicilar SET Sifre = @YeniSifre WHERE KullaniciAdi = @KullaniciAdi";
                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@YeniSifre", textEditYeniSifre.Text.Trim());
                updateCommand.Parameters.AddWithValue("@KullaniciAdi", textEditKullaniciAdi.Text.Trim());

                int rowsAffected = updateCommand.ExecuteNonQuery(); // Şifreyi günceller

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Şifreniz başarıyla değiştirildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu. Şifreniz değiştirilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
