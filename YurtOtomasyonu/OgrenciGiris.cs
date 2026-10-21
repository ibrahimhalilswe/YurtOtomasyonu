using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;

namespace YurtOtomasyonu
{
    public partial class OgrenciGiris : DevExpress.XtraEditors.XtraForm
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }

        private void Ogrbtngrs_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTcnmr.Text) || string.IsNullOrWhiteSpace(txtParola.Text))
            {
                MessageBox.Show("T.C Kimlik Numarası ve Parola boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kullanıcı giriş bilgilerini al
            string TcKimlikNo = txtTcnmr.Text.Trim();
            string OgrSifre = txtParola.Text.Trim();

            // T.C Kimlik numarasını doğrula
            if (!System.Text.RegularExpressions.Regex.IsMatch(TcKimlikNo, @"^\d{11}$"))
            {
                MessageBox.Show("T.C Kimlik Numarası 11 haneli olmalıdır ve yalnızca rakamlardan oluşmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantı dizesi
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True");

            // SQL sorgusunu yaz
            string query = "SELECT * FROM Ogrenci_Giris WHERE TC_KimlikNo = @TCKimlikNo AND OgrSifre = @OgrSifre";

            try
            {
                // SQL bağlantısı açma
                using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@TCKimlikNo", SqlDbType.NVarChar).Value = TcKimlikNo;
                    cmd.Parameters.Add("@OgrSifre", SqlDbType.NVarChar).Value = OgrSifre;

                    // Kullanıcı doğrulama
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Öğrenci girişi başarılı, yeni formu aç
                        OgrenciFormu ogrenciFormu = new OgrenciFormu(TcKimlikNo); // TcKimlikNo'yu parametre olarak gönderiyoruz
                        this.Hide(); // Mevcut formu gizle
                        ogrenciFormu.Show(); // Öğrenci formunu aç
                    }
                    else
                    {
                        // Hatalı giriş
                        MessageBox.Show("T.C Kimlik Numarası veya Parola hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
