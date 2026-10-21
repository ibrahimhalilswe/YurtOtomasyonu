using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace YurtOtomasyonu
{
    public partial class OdaListele : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True");

        public OdaListele()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            try
            {
                // Bağlantıyı aç
                conn.Open();

                // SQL sorgusu: Veritabanından sıralı bir şekilde veri çekiyoruz
                string query = "SELECT OdaNo, OgrAd, OgrSoyAd, TCKimlikNo, YatakNo FROM OdaListesi ORDER BY OdaNo";

                // DataAdapter ve DataTable kullanarak verileri al
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Veriyi gridControl'e bağla (DevExpress) veya dataGridView'e bağla
                gridControl1.DataSource = dt; // Eğer DevExpress kullanıyorsanız
                                              // dataGridView1.DataSource = dt; // Standart Windows Forms için
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri listeleme hatası: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                conn.Close();
            }
        }

        private void OdaListele_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}