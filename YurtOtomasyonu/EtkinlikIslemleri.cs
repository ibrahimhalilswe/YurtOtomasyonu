using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YurtOtomasyonu
{
    public partial class EtkinlikIslemleri : Form
    {
        // Bağlantı dizesi (Connection String)
        private string connectionString = @"Server=.;Database=Yurt_Otomasyonu;Trusted_Connection=True;";

        public EtkinlikIslemleri()
        {
            InitializeComponent();
        }

        // Veritabanı ile bağlantı kurma
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        private void IDleriYenile()
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    // Geçici bir tablo kullanarak ID'leri yeniden düzenleme
                    SqlCommand cmd = new SqlCommand(@"
                DECLARE @TempTable TABLE (
                    NewID INT IDENTITY(1,1),
                    Baslik NVARCHAR(100),
                    Icerik NVARCHAR(MAX),
                    Tarih DATE,
                    Kategori NVARCHAR(50),
                    BitisTarihi DATE
                );

                INSERT INTO @TempTable (Baslik, Icerik, Tarih, Kategori, BitisTarihi)
                SELECT Baslik, Icerik, Tarih, Kategori, BitisTarihi
                FROM Etkinlikler;

                DELETE FROM Etkinlikler;

                SET IDENTITY_INSERT Etkinlikler ON;

                INSERT INTO Etkinlikler (EtkinlikID, Baslik, Icerik, Tarih, Kategori, BitisTarihi)
                SELECT NewID, Baslik, Icerik, Tarih, Kategori, BitisTarihi
                FROM @TempTable;

                SET IDENTITY_INSERT Etkinlikler OFF;
            ", connection);

                    cmd.ExecuteNonQuery();
                    ListeleEtkinlikler(); // Listeyi güncelle
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ID yenileme hatası: " + ex.Message);
            }
        }

        // Etkinlikleri listeleme
        private void ListeleEtkinlikler()
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    string query = "SELECT EtkinlikID, Baslik, Icerik, Tarih, Kategori, BitisTarihi FROM Etkinlikler";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    gridControl.DataSource = dataTable;  // GridControl'a veri bağlama
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri listeleme hatası: " + ex.Message);
            }
        }

        // Etkinlik ekleme
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    string query = "INSERT INTO Etkinlikler (Baslik, Icerik, Tarih, Kategori, BitisTarihi) VALUES (@Baslik, @Icerik, @Tarih, @Kategori, @BitisTarihi)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Baslik", textEditBaslik.Text);
                    command.Parameters.AddWithValue("@Icerik", memoEditIcerik.Text);
                    command.Parameters.AddWithValue("@Tarih", dateEditTarih.DateTime);
                    command.Parameters.AddWithValue("@Kategori", comboBoxEditKategori.SelectedItem?.ToString() ?? "");
                    command.Parameters.AddWithValue("@BitisTarihi", dateEditBitisTarihi.DateTime);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Etkinlik başarıyla eklendi.");
                    IDleriYenile();
                    ListeleEtkinlikler(); // Listeyi güncelle
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Etkinlik ekleme hatası: " + ex.Message);
            }
        }

        // Etkinlik güncelleme
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int rowHandle = gridView.FocusedRowHandle; // Seçili satırın indexi
                if (rowHandle < 0)
                {
                    MessageBox.Show("Lütfen güncellenecek bir etkinlik seçin.");
                    return;
                }

                int etkinlikID = Convert.ToInt32(gridView.GetRowCellValue(rowHandle, "EtkinlikID"));

                using (SqlConnection connection = GetConnection())
                {
                    string query = "UPDATE Etkinlikler SET Baslik = @Baslik, Icerik = @Icerik, Tarih = @Tarih, Kategori = @Kategori, BitisTarihi = @BitisTarihi WHERE EtkinlikID = @EtkinlikID";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Baslik", textEditBaslik.Text);
                    command.Parameters.AddWithValue("@Icerik", memoEditIcerik.Text);
                    command.Parameters.AddWithValue("@Tarih", dateEditTarih.DateTime);
                    command.Parameters.AddWithValue("@Kategori", comboBoxEditKategori.SelectedItem?.ToString() ?? "");
                    command.Parameters.AddWithValue("@BitisTarihi", dateEditBitisTarihi.DateTime);
                    command.Parameters.AddWithValue("@EtkinlikID", etkinlikID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Etkinlik başarıyla güncellendi.");
                    ListeleEtkinlikler(); // Listeyi güncelle
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Etkinlik güncelleme hatası: " + ex.Message);
            }
        }

        // Etkinlik silme
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int rowHandle = gridView.FocusedRowHandle; // Seçili satırın indexi
                if (rowHandle < 0)
                {
                    MessageBox.Show("Lütfen silinecek bir etkinlik seçin.");
                    return;
                }

                int etkinlikID = Convert.ToInt32(gridView.GetRowCellValue(rowHandle, "EtkinlikID"));

                using (SqlConnection connection = GetConnection())
                {
                    string query = "DELETE FROM Etkinlikler WHERE EtkinlikID = @EtkinlikID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EtkinlikID", etkinlikID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Etkinlik başarıyla silindi.");
                    IDleriYenile();
                    ListeleEtkinlikler(); // Listeyi güncelle
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Etkinlik silme hatası: " + ex.Message);
            }
        }

        // Etkinlikleri temizleme
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textEditBaslik.Text = "";
            memoEditIcerik.Text = "";
            dateEditTarih.EditValue = null;
            dateEditBitisTarihi.EditValue = null;
            comboBoxEditKategori.SelectedIndex = -1;
        }

        // Form yüklendiğinde etkinlikleri listele
        private void EtkinlikIslemleri_Load(object sender, EventArgs e)
        {
            comboBoxEditKategori.Properties.Items.AddRange(new string[] { "Seminer", "Kültürel Etkinlik", "Spor Etkinliği", "Müzik", "Diğer" });
            gridView.FocusedRowChanged += gridView_FocusedRowChanged;  // Olayı bağla
            IDleriYenile();
            ListeleEtkinlikler();
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // Seçilen satırın indexi
            int rowHandle = gridView.FocusedRowHandle;

            if (rowHandle < 0) return;

            // Seçilen satırdaki verileri almak
            textEditBaslik.Text = gridView.GetRowCellValue(rowHandle, "Baslik")?.ToString();
            memoEditIcerik.Text = gridView.GetRowCellValue(rowHandle, "Icerik")?.ToString();
            dateEditTarih.DateTime = Convert.ToDateTime(gridView.GetRowCellValue(rowHandle, "Tarih"));
            comboBoxEditKategori.SelectedItem = gridView.GetRowCellValue(rowHandle, "Kategori")?.ToString();
            dateEditBitisTarihi.DateTime = Convert.ToDateTime(gridView.GetRowCellValue(rowHandle, "BitisTarihi"));
        }
    }
}
