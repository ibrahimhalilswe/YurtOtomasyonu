using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace YurtOtomasyonu
{
    public partial class OgrnBlgGrtlm : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True");

        public OgrnBlgGrtlm()
        {
            InitializeComponent();
        }

        public void Bul()
        {
            // T.C. Kimlik Numarasını kontrol et
            if (string.IsNullOrWhiteSpace(textEdit3.Text))
            {
                MessageBox.Show("Lütfen T.C. Kimlik Numarasını girin.");
                return;
            }

            try
            {
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
                    dr.Close();
                    return;
                }

                dr.Close(); // Yeni bir SqlCommand çalıştıracağımız için SqlDataReader'ı kapatıyoruz

                // OdaListesi tablosundan YatakNo'yu çek
                SqlCommand yatakNoCmd = new SqlCommand("SELECT YatakNo FROM OdaListesi WHERE TCKimlikNo = @tckimlikno", conn);
                yatakNoCmd.Parameters.AddWithValue("@odano", textEdit6.Text); // Daha önce doldurulmuş olan OdaNo
                yatakNoCmd.Parameters.AddWithValue("@tckimlikno", textEdit3.Text); // Girilen TCKimlikNo

                object yatakNo = yatakNoCmd.ExecuteScalar();

                if (yatakNo != null)
                {
                    textEdit11.Text = yatakNo.ToString();
                }
                else
                {
                    textEdit11.Text = "YatakNo bulunamadı.";
                }

                // Ogrenci_Giris tablosundan şifreyi al
                SqlCommand sifreCmd = new SqlCommand("SELECT OgrSifre FROM Ogrenci_Giris WHERE TC_KimlikNo = @tckimlikno", conn);
                sifreCmd.Parameters.AddWithValue("@tckimlikno", textEdit3.Text);

                object ogrSifre = sifreCmd.ExecuteScalar();

                if (ogrSifre != null)
                {
                    textEdit10.Text += " - Şifre: " + ogrSifre.ToString();
                }
                else
                {
                    textEdit10.Text += " - Şifre bulunamadı.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri getirme hatası: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void BtnBul_Click_1(object sender, EventArgs e)
        {
            Bul();
        }
    }
}
