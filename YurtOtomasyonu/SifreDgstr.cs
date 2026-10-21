using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace YurtOtomasyonu
{
    public partial class SifreDgstr : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True");

        private string TcKimlikNo;

        public SifreDgstr(string tcKimlikNo)
        {
            InitializeComponent();
            TcKimlikNo = tcKimlikNo;
            textEditTCKimlikNo.Text = TcKimlikNo;
            textEditTCKimlikNo.Properties.ReadOnly = true;  // TCKimlikNo sadece okunabilir olacak
        }

        private void simpleButtonSifreDegistir_Click(object sender, EventArgs e)
        {
            string mevcutSifre = textEditMevcutSifre.Text;
            string yeniSifre = textEditYeniSifre.Text;
            string yeniSifreDogrula = textEditYeniSifreDogrula.Text;

            if (yeniSifre != yeniSifreDogrula)
            {
                XtraMessageBox.Show("Yeni şifreler eşleşmiyor. Lütfen tekrar kontrol ediniz.");
                return;
            }

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Ogrenci_Giris WHERE TC_KimlikNo = @TcKimlikNo AND OgrSifre = @MevcutSifre", conn);
                cmd.Parameters.AddWithValue("@TcKimlikNo", TcKimlikNo);
                cmd.Parameters.AddWithValue("@MevcutSifre", mevcutSifre);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    SqlCommand updateCmd = new SqlCommand("UPDATE Ogrenci_Giris SET OgrSifre = @YeniSifre WHERE TC_KimlikNo = @TcKimlikNo", conn);
                    updateCmd.Parameters.AddWithValue("@YeniSifre", yeniSifre);
                    updateCmd.Parameters.AddWithValue("@TcKimlikNo", TcKimlikNo);
                    updateCmd.ExecuteNonQuery();

                    XtraMessageBox.Show("Şifre başarıyla değiştirildi.");
                }
                else
                {
                    XtraMessageBox.Show("Mevcut şifre yanlış. Lütfen tekrar kontrol ediniz.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Şifre değiştirme hatası: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void SifreDgstr_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler (eğer gerekli ise)
        }
    }
}
