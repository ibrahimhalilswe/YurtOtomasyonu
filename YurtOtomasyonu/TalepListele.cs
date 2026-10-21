using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace YurtOtomasyonu
{
    public partial class TalepListele : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True");

        public TalepListele()
        {
            InitializeComponent();
        }

        // Form yüklendiğinde taleplerin listelenmesi
        private void TalepListele_Load(object sender, EventArgs e)
        {
            LoadTalepList();
        }

        /// <summary>
        /// Talepleri veritabanından yükleyip listeleme.
        /// </summary>
        /// <summary>
        /// Talepleri veritabanından yükleyip listeleme.
        /// </summary>
        private void LoadTalepList()
        {
            try
            {
                string query = "SELECT TalepID, TCKimlikNo, TalepTuru, TalepDetay, TalepTarihi, Durum, YoneticiNotu " +
                               "FROM Talepler " +
                               "ORDER BY Durum ASC"; // Durum sütununa göre artan sırada sıralama
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                gridControlTalep.DataSource = dataTable;
                gridViewTalep.PopulateColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Talepler yüklenirken bir hata oluştu:\n\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Talebi onaylar ve durumu günceller.
        /// </summary>
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            UpdateTalep("Onaylandı");
        }

        /// <summary>
        /// Talebi reddeder ve durumu günceller.
        /// </summary>
        private void btnReddet_Click(object sender, EventArgs e)
        {
            UpdateTalep("Reddedildi");
        }

        /// <summary>
        /// Seçili talebin durumunu ve yönetici notunu günceller.
        /// </summary>
        /// <param name="status">Yeni talep durumu</param>
        private void UpdateTalep(string status)
        {
            try
            {
                if (gridViewTalep.GetFocusedRowCellValue("TalepID") == null)
                {
                    MessageBox.Show("Lütfen bir talep seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int talepID = Convert.ToInt32(gridViewTalep.GetFocusedRowCellValue("TalepID"));
                string yoneticiNotu = textEditYoneticiNotu.Text;

                string query = "UPDATE Talepler SET Durum = @status, YoneticiNotu = @not WHERE TalepID = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@not", yoneticiNotu);
                command.Parameters.AddWithValue("@id", talepID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show($"Talep başarıyla {status.ToLower()}.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTalepList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Talep güncellenirken bir hata oluştu:\n\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        /// <summary>
        /// Seçili talebin detaylarını gösterir.
        /// </summary>
        private void btnDetay_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewTalep.GetFocusedRowCellValue("TalepDetay") == null)
                {
                    MessageBox.Show("Lütfen bir talep seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string talepDetay = gridViewTalep.GetFocusedRowCellValue("TalepDetay").ToString();
                MessageBox.Show($"Talep Detayları:\n\n{talepDetay}", "Talep Detayı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Talep detayları görüntülenirken bir hata oluştu:\n\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Yenile butonuna tıklanıldığında grid verilerini yeniler.
        /// </summary>
        private void btnYenile_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewTalep.GetFocusedRowCellValue("TalepID") != null)
                {
                    int talepID = Convert.ToInt32(gridViewTalep.GetFocusedRowCellValue("TalepID"));
                    string yoneticiNotu = textEditYoneticiNotu.Text;

                    string query = "UPDATE Talepler SET YoneticiNotu = @not WHERE TalepID = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@not", yoneticiNotu);
                    command.Parameters.AddWithValue("@id", talepID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Yönetici notu başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadTalepList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yönetici notu güncellenirken bir hata oluştu:\n\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        
        }

        /// <summary>
        /// TextEdit üzerinde arama yapıldığında sonuçları filtreler.
        /// </summary>
        private void textEditAra_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string searchValue = textEditAra.Text.Trim();
                string query = "SELECT TalepID, TCKimlikNo, TalepTuru, TalepDetay, TalepTarihi, Durum, YoneticiNotu " +
                               "FROM Talepler WHERE TCKimlikNo LIKE @search OR TalepTuru LIKE @search";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@search", $"%{searchValue}%");

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                gridControlTalep.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Talepler filtrelenirken bir hata oluştu:\n\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Grid üzerinde satır değiştirildiğinde seçili satırın Yönetici Notunu TextEdit'e aktarır.
        /// </summary>
        private void gridViewTalep_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewTalep.GetFocusedRowCellValue("YoneticiNotu") != null)
                {
                    textEditYoneticiNotu.Text = gridViewTalep.GetFocusedRowCellValue("YoneticiNotu").ToString();
                }
                else
                {
                    textEditYoneticiNotu.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yönetici notu okunurken bir hata oluştu:\n\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
