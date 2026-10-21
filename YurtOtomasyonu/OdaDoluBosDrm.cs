using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace YurtOtomasyonu
{
    public partial class OdaDoluBosDrm : DevExpress.XtraEditors.XtraForm
    {
        private readonly SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True");

        public OdaDoluBosDrm()
        {
            InitializeComponent();
        }

        // Oda durumlarını listeleyen fonksiyon.
        public void OdaDurumuListele()
        {
            try
            {
                conn.Open();

                string query = @"
            SELECT 
                OdaNo AS [Oda Numarası],
                COUNT(TCKimlikNo) AS [Dolu Kişi Sayısı],
                3 - COUNT(TCKimlikNo) AS [Kalan Kişi Sayısı],
                CASE 
                    WHEN COUNT(TCKimlikNo) = 3 THEN 'Dolu'
                    WHEN COUNT(TCKimlikNo) = 2 THEN '1 kişilik yer var'
                    WHEN COUNT(TCKimlikNo) = 1 THEN '2 kişilik yer var'
                    ELSE 'Boş (3 kişilik yer var)'
                END AS [Oda Durumu]
            FROM OdaListesi
            GROUP BY OdaNo
            ORDER BY OdaNo";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gridControl1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri listeleme hatası: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void BtnDurumListele_Click(object sender, EventArgs e)
        {
            OdaDurumuListele();
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            string status = view.GetRowCellValue(e.RowHandle, "Oda Durumu")?.ToString();

            if (status?.Contains("Dolu") == true)
            {
                e.Appearance.BackColor = Color.Red;
                e.Appearance.ForeColor = Color.White;
            }
            else if (status?.Contains("1 kişilik yer var") == true)
            {
                e.Appearance.BackColor = Color.Orange;
                e.Appearance.ForeColor = Color.Black;
            }
            else if (status?.Contains("2 kişilik yer var") == true)
            {
                e.Appearance.BackColor = Color.Yellow;
                e.Appearance.ForeColor = Color.Black;
            }
            else if (status?.Contains("Boş") == true)
            {
                e.Appearance.BackColor = Color.Green;
                e.Appearance.ForeColor = Color.White;
            }
        }

        private void OdaDoluBosDrm_Load(object sender, EventArgs e)
        {
            OdaDurumuListele();
        }
    }
}
