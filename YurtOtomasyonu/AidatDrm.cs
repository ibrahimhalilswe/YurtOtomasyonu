using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace YurtOtomasyonu
{
    public partial class AidatDrm : DevExpress.XtraEditors.XtraForm
    {
        private string TcKimlikNo;

        public AidatDrm(string tcKimlikNo)
        {
            InitializeComponent();
            TcKimlikNo = tcKimlikNo;
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // TCKimlikNo alanını doldur ve yalnızca okunabilir yap
            tcKimlikNoTextEdit.Text = TcKimlikNo;
            tcKimlikNoTextEdit.Properties.ReadOnly = true;

            // Tüm TextEdit kontrollerini sadece okunabilir yap
            odaNoTextEdit.Properties.ReadOnly = true;
            ayTextEdit.Properties.ReadOnly = true;
            yilTextEdit.Properties.ReadOnly = true;
            aidatTutariTextEdit.Properties.ReadOnly = true;
            odemeDurumuTextEdit.Properties.ReadOnly = true;
            odemeTarihiTextEdit.Properties.ReadOnly = true;
            notlarTextEdit.Properties.ReadOnly = true;

            // Veritabanından verileri çekip GridControl'e yükle
            gridControl.DataSource = GetData();

            // Yenile butonu tıklama olayı
            yenileButton.Click += yenileButton_Click;

            // GridView satır değişikliği olayı
            gridView.FocusedRowChanged += gridView_FocusedRowChanged;
        }

        private void yenileButton_Click(object sender, EventArgs e)
        {
            // Verileri yeniden yükle
            gridControl.DataSource = GetData();
            MessageBox.Show("Veriler başarıyla yenilendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private DataTable GetData()
        {
            DataTable table = new DataTable();
            string connectionString = "Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT TCKimlikNo, OdaNo, Ay, Yil, AidatTutari, OdemeDurumu, OdemeTarihi, Notlar FROM AidatDurum WHERE TCKimlikNo = @TCKimlikNo";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TCKimlikNo", TcKimlikNo);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return table;
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView.GetFocusedDataRow() is DataRow row)
            {
                // Seçili satırdaki verileri TextEdit kontrollerine yükle
                odaNoTextEdit.Text = row["OdaNo"].ToString();
                ayTextEdit.Text = row["Ay"].ToString();
                yilTextEdit.Text = row["Yil"].ToString();
                aidatTutariTextEdit.Text = row["AidatTutari"].ToString();
                odemeDurumuTextEdit.Text = row["OdemeDurumu"].ToString();
                odemeTarihiTextEdit.Text = row["OdemeTarihi"]?.ToString();
                notlarTextEdit.Text = row["Notlar"].ToString();
            }
        }
    }
}
