using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace YurtOtomasyonu
{
    public partial class YoneticiGiris : DevExpress.XtraEditors.XtraForm
    {
        // Veritabanı bağlantısı
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True");

        private string kullaniciAdi;  // Kullanıcı adını sınıf seviyesinde tanımlıyoruz.

        public YoneticiGiris()
        {
            InitializeComponent();
        }

        // YoneticiGiris formunda, giriş başarılı olduğunda YoneticiFormu'nu kullanıcı adıyla açıyoruz.
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre kontrolü
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Kullanıcı Adı ve Parola boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kullanıcı bilgilerini al
            kullaniciAdi = txtKullaniciAdi.Text.Trim();  // Kullanıcı adını sınıf seviyesinde saklıyoruz.
            string sifre = txtSifre.Text.Trim();

            try
            {
                // Kullanıcı adı ve şifreyi veritabanında sorgula
                string query = "SELECT COUNT(1) FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                command.Parameters.AddWithValue("@Sifre", sifre);

                connection.Open();
                int userCount = (int)command.ExecuteScalar();

                if (userCount > 0)
                {
                    // YoneticiFormu'nu kullanıcı adıyla açıyoruz
                    YoneticiFormu Yoneticiformu = new YoneticiFormu(kullaniciAdi);  // Kullanıcı adı parametre olarak geçiyor
                    this.Hide();
                    Yoneticiformu.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Parola hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
