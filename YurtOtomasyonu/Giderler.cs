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
using DevExpress.XtraGrid.Views.Grid;


namespace YurtOtomasyonu
{
    public partial class Giderler : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True");
        public Giderler()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Giderler", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridControl1.DataSource = dt; // GridControl'e verileri bağla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private void IDleriYenile()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                // Geçici bir tablo kullanarak ID'leri yeniden düzenleme
                SqlCommand cmd = new SqlCommand(@"
            DECLARE @TempTable TABLE (
                NewID INT IDENTITY(1,1),
                GiderAdi NVARCHAR(100),
                GiderTuru NVARCHAR(50),
                Tutar DECIMAL(18,2),
                Tarih DATE,
                Aciklama NVARCHAR(MAX)
            );

            INSERT INTO @TempTable (GiderAdi, GiderTuru, Tutar, Tarih, Aciklama)
            SELECT GiderAdi, GiderTuru, Tutar, Tarih, Aciklama
            FROM Giderler;

            DELETE FROM Giderler;

            SET IDENTITY_INSERT Giderler ON;

            INSERT INTO Giderler (GiderID, GiderAdi, GiderTuru, Tutar, Tarih, Aciklama)
            SELECT NewID, GiderAdi, GiderTuru, Tutar, Tarih, Aciklama
            FROM @TempTable;

            SET IDENTITY_INSERT Giderler OFF;
        ", connection);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ID yenileme hatası: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }


        private void BtnGiderEkle_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Giderler (GiderAdi, GiderTuru, Tutar, Tarih, Aciklama) VALUES (@adi, @turu, @tutar, @tarih, @aciklama)",
                    connection);

                cmd.Parameters.AddWithValue("@adi", textEditGiderAdi.Text);
                cmd.Parameters.AddWithValue("@turu", comboBoxEditGiderTuru.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@tutar", Convert.ToDecimal(textEditTutar.Text));
                cmd.Parameters.AddWithValue("@tarih", dateEditTarih.DateTime);
                cmd.Parameters.AddWithValue("@aciklama", memoEditAciklama.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Gider başarıyla eklendi.");

                IDleriYenile(); // ID'leri yeniden sırala
                Listele
                    ();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme hatası: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void BtnGiderGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Giderler SET GiderAdi = @adi, GiderTuru = @turu, Tutar = @tutar, Tarih = @tarih, Aciklama = @aciklama WHERE GiderID = @id",
                    connection);

                cmd.Parameters.AddWithValue("@adi", textEditGiderAdi.Text);
                cmd.Parameters.AddWithValue("@turu", comboBoxEditGiderTuru.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@tutar", Convert.ToDecimal(textEditTutar.Text));
                cmd.Parameters.AddWithValue("@tarih", dateEditTarih.DateTime);
                cmd.Parameters.AddWithValue("@aciklama", memoEditAciklama.Text);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textEditGiderID.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Gider başarıyla güncellendi.");
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void BtnGiderSil_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Giderler WHERE GiderID = @id", connection);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textEditGiderID.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Gider başarıyla silindi.");

                IDleriYenile(); // ID'leri yeniden sırala
                Listele(); // Güncel listeyi yükle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            // Formu temizle
            textEditGiderID.Text = "";
            textEditGiderAdi.Text = "";
            comboBoxEditGiderTuru.SelectedIndex = -1;
            textEditTutar.Text = "";
            dateEditTarih.EditValue = null;
            memoEditAciklama.Text = "";
        }

        private void Giderler_Load(object sender, EventArgs e)
        {
            // Gider türlerini ComboBoxEdit'e ekle
            comboBoxEditGiderTuru.Properties.Items.AddRange(new string[] { "Elektrik", "Su", "İnternet", "Doğalgaz", "Diğer" });
            Listele(); // Giderleri listele
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                // Satırın seçili olup olmadığını kontrol edin
                int focusedRowHandle = gridView1.FocusedRowHandle;

                if (focusedRowHandle >= 0) // Satır seçili mi?
                {
                    // Hücre değerlerini doldurun (Null kontrolü ile)
                    textEditGiderID.Text = gridView1.GetFocusedRowCellValue("GiderID")?.ToString() ?? "";
                    textEditGiderAdi.Text = gridView1.GetFocusedRowCellValue("GiderAdi")?.ToString() ?? "";
                    comboBoxEditGiderTuru.Text = gridView1.GetFocusedRowCellValue("GiderTuru")?.ToString() ?? "";
                    textEditTutar.Text = gridView1.GetFocusedRowCellValue("Tutar")?.ToString() ?? "";
                    dateEditTarih.EditValue = gridView1.GetFocusedRowCellValue("Tarih") ?? null;
                    memoEditAciklama.Text = gridView1.GetFocusedRowCellValue("Aciklama")?.ToString() ?? "";
                }
                else
                {
                    MessageBox.Show("Seçili bir satır yok. Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Satır seçilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}