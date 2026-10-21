using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace YurtOtomasyonu
{
    public partial class KullaniciSil : DevExpress.XtraEditors.XtraForm
    {
        // Veritabanı bağlantı cümlesi
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True");

        public KullaniciSil()
        {
            InitializeComponent();
        }

        private void KullaniciSil_Load(object sender, EventArgs e)
        {
            // Kullanıcıları listele
            ListeleKullanicilar();
        }

        private void ListeleKullanicilar()
        {
            try
            {
                string query = "SELECT KullaniciID, KullaniciAdi, Ad, Soyad, Email, Telefon, KayitTarihi FROM Kullanicilar";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Veriyi GridControl'e aktar
                gridControlKullanicilar.DataSource = dt;
                gridControlKullanicilar.ForceInitialize(); // Grid'i zorla başlat

                // Gereksiz kolonları gizle
                if (gridViewKullanicilar.Columns["KullaniciID"] != null)
                    gridViewKullanicilar.Columns["KullaniciID"].Visible = false;

                if (gridViewKullanicilar.Columns["Sifre"] != null)
                    gridViewKullanicilar.Columns["Sifre"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBoxKullaniciAdi.Text.Trim();
            if (!string.IsNullOrEmpty(kullaniciAdi))
            {
                try
                {
                    string query = "SELECT KullaniciID, KullaniciAdi, Ad, Soyad, Email, Telefon, KayitTarihi FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    gridControlKullanicilar.DataSource = dt;
                    gridControlKullanicilar.ForceInitialize(); // Grid'i zorla başlat

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Kullanıcı bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (gridViewKullanicilar.Columns["KullaniciID"] != null)
                            gridViewKullanicilar.Columns["KullaniciID"].Visible = false;

                        if (gridViewKullanicilar.Columns["Sifre"] != null)
                            gridViewKullanicilar.Columns["Sifre"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı adı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBoxKullaniciAdi.Text.Trim();
            if (!string.IsNullOrEmpty(kullaniciAdi))
            {
                try
                {
                    // Kullanıcı silme sorgusu
                    string query = "DELETE FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    connection.Close();

                    if (result > 0)
                    {
                        MessageBox.Show("Kullanıcı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Grid'i yenilemek için
                    ListeleKullanicilar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı adı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
