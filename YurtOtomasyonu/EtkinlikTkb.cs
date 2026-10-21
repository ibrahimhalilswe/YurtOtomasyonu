using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YurtOtomasyonu
{
    public partial class EtkinlikTkb : Form
    {
        // Bağlantı dizesi (Connection String)
        private string connectionString = @"Server=.;Database=Yurt_Otomasyonu;Trusted_Connection=True;";

        public EtkinlikTkb()
        {
            InitializeComponent();

            // Bileşenleri sadece okunabilir hale getir
            SetComponentsReadOnly();
        }

        // Veritabanı ile bağlantı kurma
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
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

                    gridControlEtkinlikler.DataSource = dataTable; // GridControl'a veri bağlama
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri listeleme hatası: " + ex.Message);
            }
        }

        // GridView'den seçim yapıldığında verileri detaylara yazdırma
        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int rowHandle = gridViewEtkinlikler.FocusedRowHandle;

            if (rowHandle < 0) return;

            // GridView'den seçilen satırdaki verileri form kontrollerine aktarma
            textEditBaslik.Text = gridViewEtkinlikler.GetRowCellValue(rowHandle, "Baslik")?.ToString();
            memoEditIcerik.Text = gridViewEtkinlikler.GetRowCellValue(rowHandle, "Icerik")?.ToString();
            dateEditTarih.EditValue = gridViewEtkinlikler.GetRowCellValue(rowHandle, "Tarih");
            comboBoxEditKategori.Text = gridViewEtkinlikler.GetRowCellValue(rowHandle, "Kategori")?.ToString();
            dateEditBitisTarihi.EditValue = gridViewEtkinlikler.GetRowCellValue(rowHandle, "BitisTarihi");
        }

        // Listeyi yenileme butonuna basıldığında
        private void btnYenile_Click(object sender, EventArgs e)
        {
            ListeleEtkinlikler();
        }

        // Form yüklendiğinde
        private void EtkinlikTkb_Load(object sender, EventArgs e)
        {
            // Kategori ComboBox içeriğini doldurma
            comboBoxEditKategori.Properties.Items.AddRange(new string[] { "Seminer", "Kültürel Etkinlik", "Spor Etkinliği", "Müzik", "Diğer" });

            // GridView satır değişiklik olayını bağlama
            gridViewEtkinlikler.FocusedRowChanged += gridView_FocusedRowChanged;

            // Etkinlikleri listeleme
            ListeleEtkinlikler();
        }

        // Bileşenleri sadece okunabilir yapma
        private void SetComponentsReadOnly()
        {
            textEditBaslik.Properties.ReadOnly = true;
            memoEditIcerik.Properties.ReadOnly = true;
            comboBoxEditKategori.Properties.ReadOnly = true;
            dateEditTarih.Properties.ReadOnly = true;
            dateEditBitisTarihi.Properties.ReadOnly = true;

            // GridView'ı sadece görüntüleme moduna ayarla
            gridViewEtkinlikler.OptionsBehavior.Editable = false;
        }
    }
}
