using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace YurtOtomasyonu
{
    public partial class SikayetGonder : DevExpress.XtraEditors.XtraForm
    {
        private string TcKimlikNo;

        public SikayetGonder(string tcKimlikNo)
        {
            InitializeComponent();
            TcKimlikNo = tcKimlikNo;
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // TCKimlikNo, AdSoyad ve OdaNo alanlarını sadece okunabilir yapma
            txtTCKimlikNo.Properties.ReadOnly = true;
            txtTCKimlikNo.Text = TcKimlikNo;

            txtAdSoyad.Properties.ReadOnly = true;
            txtOdaNo.Properties.ReadOnly = true;

            // Veritabanından verileri çekip TextEdit bileşenlerine aktarma
            LoadSikayetData();

            // GridControl için veritabanından veri çekme
            gridControlSikayetler.DataSource = GetSikayetData();
        }

        private void LoadSikayetData()
        {
            string connectionString = "Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT OgrAd, OgrSoyAd, OdaNo FROM Ogrenci_Bilgi WHERE TCKimlikNo = @TCKimlikNo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TCKimlikNo", TcKimlikNo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtAdSoyad.Text = reader["OgrAd"].ToString() + " " + reader["OgrSoyAd"].ToString();
                            txtOdaNo.Text = reader["OdaNo"].ToString();
                        }
                    }
                }

                query = "SELECT SikayetBaslik, SikayetDetay, SikayetTarihi FROM Sikayetler WHERE TCKimlikNo = @TCKimlikNo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TCKimlikNo", TcKimlikNo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtSikayetBaslik.Text = reader["SikayetBaslik"].ToString();
                            txtSikayetDetay.Text = reader["SikayetDetay"].ToString();
                            dtpSikayetTarihi.DateTime = Convert.ToDateTime(reader["SikayetTarihi"]);
                        }
                    }
                }
            }
        }

        private DataTable GetSikayetData()
        {
            DataTable table = new DataTable();
            string connectionString = "Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TCKimlikNo, AdSoyad, OdaNo, SikayetBaslik, SikayetDetay, SikayetTarihi FROM Sikayetler WHERE TCKimlikNo = @TCKimlikNo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TCKimlikNo", TcKimlikNo);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }

            return table;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Sikayetler (TCKimlikNo, AdSoyad, OdaNo, SikayetBaslik, SikayetDetay, SikayetTarihi) VALUES (@TCKimlikNo, @AdSoyad, @OdaNo, @SikayetBaslik, @SikayetDetay, @SikayetTarihi)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TCKimlikNo", txtTCKimlikNo.Text);
                    command.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                    command.Parameters.AddWithValue("@OdaNo", txtOdaNo.Text);
                    command.Parameters.AddWithValue("@SikayetBaslik", txtSikayetBaslik.Text);
                    command.Parameters.AddWithValue("@SikayetDetay", txtSikayetDetay.Text);
                    command.Parameters.AddWithValue("@SikayetTarihi", dtpSikayetTarihi.DateTime);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Şikayet başarıyla gönderildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Veritabanından güncel verileri çekip GridControl'e yükleme
            gridControlSikayetler.DataSource = GetSikayetData();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSikayetBaslik.Text = "";
            txtSikayetDetay.Text = "";
            dtpSikayetTarihi.EditValue = null;
        }
    }
}
