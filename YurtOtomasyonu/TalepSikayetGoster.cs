using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace YurtOtomasyonu
{
    public partial class TalepSikayetGoster : DevExpress.XtraEditors.XtraForm
    {
        private string TcKimlikNo;
        private string connectionString = "Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True";

        public TalepSikayetGoster(string tcKimlikNo)
        {
            InitializeComponent();
            TcKimlikNo = tcKimlikNo;
            tckimlikNoTextEdit.Text = TcKimlikNo; // TCKimlikNo'yu TextEdit'e yazdır
            LoadData();
        }

        private void LoadData()
        {
            LoadTalepler();
            LoadSikayetler();
        }

        private void LoadTalepler()
        {
            string query = @"
                SELECT 
                    TalepTuru, 
                    TalepDetay, 
                    TalepTarihi, 
                    Durum, 
                    ISNULL(YoneticiNotu, 'Beklemede') AS YoneticiNotu 
                FROM Talepler 
                WHERE TCKimlikNo = @TCKimlikNo";

            DataTable dataTable = GetData(query, TcKimlikNo);
            gridControl1.DataSource = dataTable.Rows.Count > 0 ? dataTable : null;
        }

        private void LoadSikayetler()
        {
            string query = @"
                SELECT 
                    AdSoyad, 
                    OdaNo, 
                    SikayetBaslik, 
                    SikayetDetay, 
                    SikayetTarihi, 
                    Durum, 
                    ISNULL(YoneticiNotu, 'Beklemede') AS YoneticiNotu 
                FROM Sikayetler 
                WHERE TCKimlikNo = @TCKimlikNo";

            DataTable dataTable = GetData(query, TcKimlikNo);
            gridControl2.DataSource = dataTable.Rows.Count > 0 ? dataTable : null;
        }

        private DataTable GetData(string query, string tckimlikNo)
        {
            DataTable table = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TCKimlikNo", tckimlikNo);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Veri alınırken bir hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return table;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                tckimlikNoTextEdit.Text = TcKimlikNo; // TCKimlikNo'yu yazdır
                durumTextEdit.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "Durum")?.ToString();
                yoneticiNotuMemoEdit.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "YoneticiNotu")?.ToString();
            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                tckimlikNoTextEdit.Text = TcKimlikNo; // TCKimlikNo'yu yazdır
                durumTextEdit.Text = gridView2.GetRowCellValue(e.FocusedRowHandle, "Durum")?.ToString();
                yoneticiNotuMemoEdit.Text = gridView2.GetRowCellValue(e.FocusedRowHandle, "YoneticiNotu")?.ToString();
            }
        }

        private Dictionary<string, Color> GetStatusColorsForTalepler()
        {
            return new Dictionary<string, Color>
            {
                { "Beklemede", Color.LightYellow },
                { "Onaylandı", Color.LightGreen },
                { "Reddedildi", Color.LightCoral }
            };
        }

        private Dictionary<string, Color> GetStatusColorsForSikayetler()
        {
            return new Dictionary<string, Color>
            {
                { "Beklemede", Color.LightYellow },
                { "İşlemde", Color.LightBlue },
                { "Tamamlandı", Color.LightGreen }
            };
        }

        private void ApplyRowStyle(DevExpress.XtraGrid.Views.Grid.GridView gridView, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e, Dictionary<string, Color> statusColors)
        {
            if (e.RowHandle >= 0)
            {
                string durum = gridView.GetRowCellValue(e.RowHandle, "Durum")?.ToString();
                if (!string.IsNullOrEmpty(durum) && statusColors.ContainsKey(durum))
                {
                    e.Appearance.BackColor = statusColors[durum];
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
