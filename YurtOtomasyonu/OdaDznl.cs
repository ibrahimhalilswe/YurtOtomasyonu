using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace YurtOtomasyonu
{
    public partial class OdaDznl : DevExpress.XtraEditors.XtraForm
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True";

        public OdaDznl()
        {
            InitializeComponent();
        }

        // TCKimlikNo'ya göre öğrenci bilgilerini getirir
        public void BilgiGetir(string tckimlikno)
        {
            if (string.IsNullOrWhiteSpace(tckimlikno) || !long.TryParse(tckimlikno, out _))
            {
                MessageBox.Show("Lütfen geçerli bir TCKimlikNo giriniz.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    const string query = "SELECT OgrAd, OgrSoyAd, OdaNo, YatakNo FROM OdaListesi WHERE TCKimlikNo = @TCKimlikNo";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TCKimlikNo", tckimlikno);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                textEdit2.Text = dr["OgrAd"].ToString();
                                textEdit3.Text = dr["OgrSoyAd"].ToString();
                                textEdit4.Text = dr["OdaNo"].ToString();
                                textEdit5.Text = dr["YatakNo"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Belirtilen TCKimlikNo ile öğrenci bulunamadı.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Tüm oda bilgilerini listeleyen metot
        public void Listele()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    const string query = "SELECT OdaNo, OgrAd, OgrSoyAd, YatakNo, TCKimlikNo FROM OdaListesi ORDER BY OdaNo";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        gridControl1.DataSource = dt;
                        gridView1.BestFitColumns();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri listeleme hatası: " + ex.Message);
            }
        }

        // Öğrenci bilgilerini ve oda numarasını günceller
        public void BilgiGuncelle()
        {
            if (string.IsNullOrWhiteSpace(textEdit1.Text) || string.IsNullOrWhiteSpace(textEdit4.Text))
            {
                MessageBox.Show("TCKimlikNo ve OdaNo boş bırakılamaz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textEdit2.Text) || string.IsNullOrWhiteSpace(textEdit3.Text) || string.IsNullOrWhiteSpace(textEdit5.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurunuz.");
                return;
            }

            SqlTransaction transaction = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    // Önceki odadaki öğrenciyi kaldır
                    const string eskiOdaQuery = "UPDATE OdaListesi SET TCKimlikNo = NULL, OgrAd = NULL, OgrSoyAd = NULL WHERE TCKimlikNo = @TCKimlikNo";
                    using (SqlCommand eskiOdaCmd = new SqlCommand(eskiOdaQuery, conn, transaction))
                    {
                        eskiOdaCmd.Parameters.AddWithValue("@TCKimlikNo", textEdit1.Text);
                        eskiOdaCmd.ExecuteNonQuery();
                    }

                    // Yeni odaya öğrenciyi ata
                    const string yeniOdaQuery = "UPDATE OdaListesi SET TCKimlikNo = @TCKimlikNo, OgrAd = @OgrAd, OgrSoyAd = @OgrSoyAd WHERE OdaNo = @OdaNo AND YatakNo = @YatakNo";
                    using (SqlCommand yeniOdaCmd = new SqlCommand(yeniOdaQuery, conn, transaction))
                    {
                        yeniOdaCmd.Parameters.AddWithValue("@TCKimlikNo", textEdit1.Text);
                        yeniOdaCmd.Parameters.AddWithValue("@OgrAd", textEdit2.Text);
                        yeniOdaCmd.Parameters.AddWithValue("@OgrSoyAd", textEdit3.Text);
                        yeniOdaCmd.Parameters.AddWithValue("@OdaNo", textEdit4.Text);
                        yeniOdaCmd.Parameters.AddWithValue("@YatakNo", textEdit5.Text);
                        yeniOdaCmd.ExecuteNonQuery();
                    }

                    // Öğrenci_Bilgi tablosunu güncelle
                    const string ogrBilgiQuery = "UPDATE Ogrenci_Bilgi SET OdaNo = @OdaNo WHERE TCKimlikNo = @TCKimlikNo";
                    using (SqlCommand ogrBilgiCmd = new SqlCommand(ogrBilgiQuery, conn, transaction))
                    {
                        ogrBilgiCmd.Parameters.AddWithValue("@OdaNo", textEdit4.Text);
                        ogrBilgiCmd.Parameters.AddWithValue("@TCKimlikNo", textEdit1.Text);
                        ogrBilgiCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Bilgiler başarıyla güncellendi.");
                }
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        // Form yüklendiğinde listeleme işlemi yapılır
        private void OdaDznl_Load(object sender, EventArgs e)
        {
            Listele();
        }

        // TCKimlikNo ile bilgileri getirir
        private void BtnBilgiGetir_Click(object sender, EventArgs e)
        {
            string tckimlikno = textEdit1.Text;
            BilgiGetir(tckimlikno);
        }

        // Bilgi güncelleme işlemini başlatır
        private void BtnOdaGuncelle_Click(object sender, EventArgs e)
        {
            BilgiGuncelle();
        }
    }
}
