using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace YurtOtomasyonu
{
    public partial class Duyurular : XtraForm
    {
        // SQL Bağlantısı
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True");

        public Duyurular()
        {
            InitializeComponent();

            // Bileşenleri yalnızca okunabilir hale getirme
            textEditBaslik.Properties.ReadOnly = true;
            memoEditIcerik.Properties.ReadOnly = true;
            dateEditAtilanTarih.Properties.ReadOnly = true;
            dateEditGecerlilikTarihi.Properties.ReadOnly = true;
        }

        // Bağlantıyı açma işlemi
        private void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        // Bağlantıyı kapatma işlemi
        private void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        // Verileri listeleme
        private void Listele()
        {
            try
            {
                OpenConnection();

                string query = "SELECT * FROM Duyurular";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                gridControlDuyurular.DataSource = dataTable; // GridControl'e verileri bağlama

                // ID sütununu gizleme
                if (gridViewDuyurular.Columns["ID"] != null)
                {
                    gridViewDuyurular.Columns["ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler listelenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        // Yenileme butonuna basıldığında
        private void btnYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        // GridView satır değiştiğinde verileri doldurma
        private void gridViewDuyurular_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView view = sender as GridView;

            if (view != null && view.GetFocusedRowCellValue("ID") != null)
            {
                textEditBaslik.Text = view.GetFocusedRowCellValue("Baslik")?.ToString();
                memoEditIcerik.Text = view.GetFocusedRowCellValue("Icerik")?.ToString();

                if (DateTime.TryParse(view.GetFocusedRowCellValue("Tarih")?.ToString(), out DateTime tarih))
                    dateEditAtilanTarih.DateTime = tarih;
                else
                    dateEditGecerlilikTarihi.EditValue = null;

                if (DateTime.TryParse(view.GetFocusedRowCellValue("GecerlilikTarihi")?.ToString(), out DateTime gecerlilikTarihi))
                    dateEditGecerlilikTarihi.DateTime = gecerlilikTarihi;
                else
                    dateEditGecerlilikTarihi.EditValue = null;
            }
        }

        private void GuncelDyr_Load(object sender, EventArgs e)
        {
            Listele(); // İlk yüklemede listeleme

            gridViewDuyurular.FocusedRowChanged += gridViewDuyurular_FocusedRowChanged; // GridView olayını bağlama
        }
    }
}
