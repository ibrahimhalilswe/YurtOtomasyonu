using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace YurtOtomasyonu
{
    public partial class SikayetleriListele : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True");

        public SikayetleriListele()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Şikayetleri veritabanından yükleyip listeleme.
        /// </summary>
        private void LoadSikayetList()
        {
            try
            {
                string query = "SELECT SikayetID, TCKimlikNo, SikayetBaslik, SikayetDetay, SikayetTarihi, Durum, YoneticiNotu " +
                               "FROM Sikayetler " +
                               "ORDER BY Durum ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                gridControlSikayet.DataSource = dataTable;
                gridViewSikayet.PopulateColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Şikayetler yüklenirken bir hata oluştu:\n\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            try
            {
                LoadSikayetList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Şikayetler yenilenirken bir hata oluştu:\n\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewSikayet.GetFocusedRowCellValue("SikayetID") != null)
                {
                    int sikayetID = Convert.ToInt32(gridViewSikayet.GetFocusedRowCellValue("SikayetID"));
                    string yoneticiNotu = textEditYoneticiNotu.Text;
                    string durum = comboBoxEditDurum.Text; // Durum bilgisini al

                    string query = "UPDATE Sikayetler SET YoneticiNotu = @not, Durum = @durum WHERE SikayetID = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@not", yoneticiNotu);
                    command.Parameters.AddWithValue("@durum", durum); // Durum bilgisi sorguya eklendi
                    command.Parameters.AddWithValue("@id", sikayetID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Yönetici notu ve durum başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tabloyu yeniden yükle
                    LoadSikayetList();
                }
                else
                {
                    MessageBox.Show("Lütfen bir şikayet seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yönetici notu veya durum güncellenirken bir hata oluştu:\n\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }


        private void textEditAra_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string searchValue = textEditAra.Text.Trim();
                string query = "SELECT SikayetID, TCKimlikNo, SikayetBaslik, SikayetDetay, SikayetTarihi, Durum, YoneticiNotu " +
                               "FROM Sikayetler WHERE TCKimlikNo LIKE @search OR SikayetBaslik LIKE @search";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@search", $"%{searchValue}%");

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                gridControlSikayet.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Şikayetler filtrelenirken bir hata oluştu:\n\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewSikayet_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                // Yönetici notunu doldur
                if (gridViewSikayet.GetFocusedRowCellValue("YoneticiNotu") != null)
                {
                    textEditYoneticiNotu.Text = gridViewSikayet.GetFocusedRowCellValue("YoneticiNotu").ToString();
                }
                else
                {
                    textEditYoneticiNotu.Text = "";
                }

                // Şikayet detayını doldur
                if (gridViewSikayet.GetFocusedRowCellValue("SikayetDetay") != null)
                {
                    textEditSikayetDetay.Text = gridViewSikayet.GetFocusedRowCellValue("SikayetDetay").ToString();
                }
                else
                {
                    textEditSikayetDetay.Text = "";
                }

                // Durum bilgisini doldur
                if (gridViewSikayet.GetFocusedRowCellValue("Durum") != null)
                {
                    comboBoxEditDurum.Text = gridViewSikayet.GetFocusedRowCellValue("Durum").ToString();
                }
                else
                {
                    comboBoxEditDurum.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Şikayet detayları, yönetici notu veya durum okunurken bir hata oluştu:\n\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SikayetleriListele_Load(object sender, EventArgs e)
        {
            LoadSikayetList();
        }
    }
}
