using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace YurtOtomasyonu
{
    public partial class DuyuruIslemleri : XtraForm
    {
        // SQL Bağlantısı
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True");

        public DuyuruIslemleri()
        {
            InitializeComponent();
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

        private void IDleriYenile()
        {
            try
            {
                OpenConnection();

                // Geçici bir tablo kullanarak ID'leri yeniden düzenleme
                SqlCommand cmd = new SqlCommand(@"
                DECLARE @TempTable TABLE (
                NewID INT IDENTITY(1,1),
                Baslik NVARCHAR(100),
                Icerik NVARCHAR(MAX),
                Tarih DATE,
                GecerlilikTarihi DATE
                );

                INSERT INTO @TempTable (Baslik, Icerik, Tarih, GecerlilikTarihi)
                SELECT Baslik, Icerik, Tarih, GecerlilikTarihi
                FROM Duyurular;

                DELETE FROM Duyurular;

                SET IDENTITY_INSERT Duyurular ON;

                INSERT INTO Duyurular (ID, Baslik, Icerik, Tarih, GecerlilikTarihi)
                SELECT NewID, Baslik, Icerik, Tarih, GecerlilikTarihi
                FROM @TempTable;

                SET IDENTITY_INSERT Duyurular OFF;", connection);

                cmd.ExecuteNonQuery();
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ID yenileme hatası: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
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

                gridControl.DataSource = dataTable; // GridControl'e verileri bağlama
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

        // Timer için süre dolmuş duyuruları silme
        private void timerDuyuruKontrol_Tick(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();

                string query = "DELETE FROM Duyurular WHERE GecerlilikTarihi < @Bugun";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Bugun", DateTime.Now.Date);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"{rowsAffected} adet duyuru süresi dolduğu için silindi.");
                    Listele(); // Listeyi yenile
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Duyuru kontrolü sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        // Ekleme işlemi
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();

                string query = "INSERT INTO Duyurular (Baslik, Icerik, Tarih, GecerlilikTarihi) VALUES (@Baslik, @Icerik, @Tarih, @GecerlilikTarihi)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Baslik", textEditBaslik.Text);
                command.Parameters.AddWithValue("@Icerik", memoEditIcerik.Text);
                command.Parameters.AddWithValue("@Tarih", dateEditTarih.DateTime);
                command.Parameters.AddWithValue("@GecerlilikTarihi", dateEditGecerlilikTarihi.DateTime);

                command.ExecuteNonQuery();
                MessageBox.Show("Duyuru başarıyla eklendi!");
                IDleriYenile();
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Duyuru eklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        // Güncelleme işlemi
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();

                string query = "UPDATE Duyurular SET Baslik = @Baslik, Icerik = @Icerik, Tarih = @Tarih, GecerlilikTarihi = @GecerlilikTarihi WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Baslik", textEditBaslik.Text);
                command.Parameters.AddWithValue("@Icerik", memoEditIcerik.Text);
                command.Parameters.AddWithValue("@Tarih", dateEditTarih.DateTime);
                command.Parameters.AddWithValue("@GecerlilikTarihi", dateEditGecerlilikTarihi.DateTime);

                int selectedRowId = Convert.ToInt32(gridView.GetFocusedRowCellValue("ID"));
                command.Parameters.AddWithValue("@ID", selectedRowId);

                command.ExecuteNonQuery();
                MessageBox.Show("Duyuru başarıyla güncellendi!");
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Duyuru güncellenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        // Silme işlemi
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();

                string query = "DELETE FROM Duyurular WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);

                int selectedRowId = Convert.ToInt32(gridView.GetFocusedRowCellValue("ID"));
                command.Parameters.AddWithValue("@ID", selectedRowId);

                command.ExecuteNonQuery();
                MessageBox.Show("Duyuru başarıyla silindi!");
                IDleriYenile();
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Duyuru silinirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        // Temizleme işlemi
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textEditBaslik.Text = string.Empty;
            memoEditIcerik.Text = string.Empty;
            dateEditTarih.EditValue = null;
            dateEditGecerlilikTarihi.EditValue = null;
        }

        private void DuyuruIslemleri_Load(object sender, EventArgs e)
        {
            IDleriYenile();
            Listele();
            timerDuyuruKontrol.Start(); // Timer'ı başlat
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView view = sender as GridView;

            if (view != null && view.GetFocusedRowCellValue("ID") != null)
            {
                textEditBaslik.Text = view.GetFocusedRowCellValue("Baslik")?.ToString();
                memoEditIcerik.Text = view.GetFocusedRowCellValue("Icerik")?.ToString();

                // Tarihler null değilse DateEdit'lere aktar
                if (DateTime.TryParse(view.GetFocusedRowCellValue("Tarih")?.ToString(), out DateTime tarih))
                    dateEditTarih.DateTime = tarih;
                else
                    dateEditTarih.EditValue = null;

                if (DateTime.TryParse(view.GetFocusedRowCellValue("GecerlilikTarihi")?.ToString(), out DateTime gecerlilikTarihi))
                    dateEditGecerlilikTarihi.DateTime = gecerlilikTarihi;
                else
                    dateEditGecerlilikTarihi.EditValue = null;
            }
        }

        private void BtnYenile_Click(object sender, EventArgs e)
        {
            IDleriYenile();
            Listele();
        }
    }    
}
