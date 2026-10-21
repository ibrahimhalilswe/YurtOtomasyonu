using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace YurtOtomasyonu
{
    public partial class ProfilBlgGrnt : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True");

        private string TcKimlikNo; // TcKimlikNo'yu burada tanımlayın

        public ProfilBlgGrnt(string tcKimlikNo)
        {
            InitializeComponent();
            TcKimlikNo = tcKimlikNo;
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Ogrenci_Bilgi WHERE TCKimlikNo = @TcKimlikNo", conn);
                cmd.Parameters.AddWithValue("@TcKimlikNo", TcKimlikNo);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textEditOgrAd.Text = reader["OgrAd"].ToString();
                    textEditOgrSoyAd.Text = reader["OgrSoyAd"].ToString();
                    textEditTCKimlikNo.Text = reader["TCKimlikNo"].ToString();
                    dateEditOgrDogum.DateTime = Convert.ToDateTime(reader["OgrDogum"]);
                    textEditOgrTel.Text = reader["OgrTel"].ToString();
                    textEditOdaNo.Text = reader["OdaNo"].ToString();
                    textEditVeliAd.Text = reader["VeliAd"].ToString();
                    textEditVeliSoyAd.Text = reader["VeliSoyAd"].ToString();
                    textEditVeliTel.Text = reader["VeliTel"].ToString();
                    memoEditOgrAdres.Text = reader["OgrAdres"].ToString();

                    // TextEdit ve MemoEdit bileşenlerini sadece okunabilir yap
                    textEditOgrAd.Properties.ReadOnly = true;
                    textEditOgrSoyAd.Properties.ReadOnly = true;
                    textEditTCKimlikNo.Properties.ReadOnly = true;
                    dateEditOgrDogum.Properties.ReadOnly = true;
                    textEditOgrTel.Properties.ReadOnly = true;
                    textEditOdaNo.Properties.ReadOnly = true;
                    textEditVeliAd.Properties.ReadOnly = true;
                    textEditVeliSoyAd.Properties.ReadOnly = true;
                    textEditVeliTel.Properties.ReadOnly = true;
                    memoEditOgrAdres.Properties.ReadOnly = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Veri yükleme hatası: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
