using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace YurtOtomasyonu
{
    public partial class AidatIslemleri : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True");

        public AidatIslemleri()
        {
            InitializeComponent();
        }

        private void Getir()
        {
            if (string.IsNullOrWhiteSpace(textEdit1.Text))
            {
                MessageBox.Show("Lütfen T.C. Kimlik Numarasını girin.");
                return;
            }

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM AidatDurum WHERE TCKimlikNo = @tckimlikno", connection);
                cmd.Parameters.AddWithValue("@tckimlikno", textEdit1.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    textEdit2.Text = dr["OdaNo"].ToString();
                    textEdit3.Text = dr["Ay"].ToString();
                    textEdit4.Text = dr["Yil"].ToString();
                    textEdit5.Text = dr["AidatTutari"].ToString();
                    textEdit6.Text = dr["OdemeTarihi"].ToString();
                    textEdit7.Text = dr["Notlar"].ToString();
                    comboBoxEdit1.SelectedItem = dr["OdemeDurumu"].ToString();
                }
                else
                {
                    MessageBox.Show("Bu T.C. Kimlik Numarası ile kayıt bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri getirme hatası: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Temizle()
        {
            textEdit1.Text = string.Empty;
            textEdit2.Text = string.Empty;
            textEdit3.Text = string.Empty;
            textEdit4.Text = string.Empty;
            textEdit5.Text = string.Empty;
            textEdit6.Text = string.Empty;
            textEdit7.Text = string.Empty;
            comboBoxEdit1.SelectedIndex = 0;
            gridControl1.DataSource = null;
        }

        void Listele()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                // Öğrenci Bilgi'den TCKimlikNo ve OdaNo al
                SqlDataAdapter ogrenciDa = new SqlDataAdapter("SELECT TCKimlikNo, OdaNo FROM Ogrenci_Bilgi", connection);
                DataTable ogrenciDt = new DataTable();
                ogrenciDa.Fill(ogrenciDt);

                // AidatDurum'daki mevcut kayıtları al
                SqlDataAdapter aidatDa = new SqlDataAdapter("SELECT TCKimlikNo FROM AidatDurum", connection);
                DataTable aidatDt = new DataTable();
                aidatDa.Fill(aidatDt);

                // Yeni kullanıcıları ekle
                foreach (DataRow ogrenci in ogrenciDt.Rows)
                {
                    string tckimlikno = ogrenci["TCKimlikNo"].ToString();
                    string odano = ogrenci["OdaNo"].ToString();

                    bool exists = aidatDt.AsEnumerable().Any(row => row["TCKimlikNo"].ToString() == tckimlikno);

                    if (!exists)
                    {
                        SqlCommand insertCmd = new SqlCommand(
                            "INSERT INTO AidatDurum (TCKimlikNo, OdaNo, Ay, Yil, AidatTutari, OdemeDurumu, OdemeTarihi, Notlar) " +
                            "VALUES (@tckimlikno, @odano, @ay, @yil, @tutar, @durum, @tarih, @notlar)", connection);

                        string ayAdi = DateTime.Now.ToString("MMMM", new CultureInfo("tr-TR"));

                        insertCmd.Parameters.AddWithValue("@tckimlikno", tckimlikno);
                        insertCmd.Parameters.AddWithValue("@odano", odano);
                        insertCmd.Parameters.AddWithValue("@ay", ayAdi);
                        insertCmd.Parameters.AddWithValue("@yil", DateTime.Now.Year);
                        insertCmd.Parameters.AddWithValue("@tutar", 500);
                        insertCmd.Parameters.AddWithValue("@durum", "0");
                        insertCmd.Parameters.AddWithValue("@tarih", DBNull.Value);
                        insertCmd.Parameters.AddWithValue("@notlar", "Ödeme bekleniyor.");
                        insertCmd.ExecuteNonQuery();
                    }
                }

                // Silinen kullanıcıları kaldır
                foreach (DataRow aidat in aidatDt.Rows)
                {
                    string tckimlikno = aidat["TCKimlikNo"].ToString();

                    bool exists = ogrenciDt.AsEnumerable().Any(row => row["TCKimlikNo"].ToString() == tckimlikno);

                    if (!exists)
                    {
                        SqlCommand deleteCmd = new SqlCommand("DELETE FROM AidatDurum WHERE TCKimlikNo = @tckimlikno", connection);
                        deleteCmd.Parameters.AddWithValue("@tckimlikno", tckimlikno);
                        deleteCmd.ExecuteNonQuery();
                    }
                }

                // AidatDurum tablosunu listele (Sıralama eklenmiş hali)
                SqlDataAdapter da = new SqlDataAdapter(@"
            SELECT * 
            FROM AidatDurum
            ORDER BY 
                Yil DESC,
                CASE 
                    Ay
                    WHEN 'Ocak' THEN 1
                    WHEN 'Şubat' THEN 2
                    WHEN 'Mart' THEN 3
                    WHEN 'Nisan' THEN 4
                    WHEN 'Mayıs' THEN 5
                    WHEN 'Haziran' THEN 6
                    WHEN 'Temmuz' THEN 7
                    WHEN 'Ağustos' THEN 8
                    WHEN 'Eylül' THEN 9
                    WHEN 'Ekim' THEN 10
                    WHEN 'Kasım' THEN 11
                    WHEN 'Aralık' THEN 12
                END DESC", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridControl1.DataSource = dt;
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


        private void BtnAidatGuncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE AidatDurum SET AidatTutari = @p1, OdemeDurumu = @p2, OdemeTarihi = @p3, Notlar = @p4 WHERE TCKimlikNo = @p5 AND OdaNo = @p6 AND Ay = @p7 AND Yil = @p8", connection);
                cmd.Parameters.AddWithValue("@p1", Convert.ToDecimal(textEdit5.Text));
                cmd.Parameters.AddWithValue("@p2", comboBoxEdit1.SelectedItem.ToString());

                DateTime odemeTarihi;
                if (DateTime.TryParse(textEdit6.Text, out odemeTarihi))
                {
                    cmd.Parameters.AddWithValue("@p3", odemeTarihi);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@p3", DBNull.Value);
                }

                cmd.Parameters.AddWithValue("@p4", textEdit7.Text);
                cmd.Parameters.AddWithValue("@p5", textEdit1.Text);
                cmd.Parameters.AddWithValue("@p6", textEdit2.Text);
                cmd.Parameters.AddWithValue("@p7", textEdit3.Text);
                cmd.Parameters.AddWithValue("@p8", textEdit4.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Aidat başarıyla güncellendi.");
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void BtnTemizle_Click_1(object sender, EventArgs e)
        {
            Temizle();
            Listele();
        }

        private void BtnAidatBul_Click(object sender, EventArgs e)
        {
            Getir();
        }

        private void AidatDznl_Load(object sender, EventArgs e)
        {
            comboBoxEdit1.Properties.Items.Add("0");
            comboBoxEdit1.Properties.Items.Add("1");
            comboBoxEdit1.SelectedIndex = 0;
            Listele();
        }

        private void YeniAyAidati_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Öğrenci bilgilerini getir
                SqlDataAdapter ogrenciDa = new SqlDataAdapter("SELECT TCKimlikNo, OdaNo FROM Ogrenci_Bilgi", connection);
                DataTable ogrenciDt = new DataTable();
                ogrenciDa.Fill(ogrenciDt);

                // Sonraki ayın hesaplanması
                DateTime simdikiZaman = DateTime.Now;
                DateTime sonrakiAyTarihi = simdikiZaman.AddMonths(1);
                string sonrakiAyAdi = sonrakiAyTarihi.ToString("MMMM", new CultureInfo("tr-TR")); // Sonraki ay adı (Türkçe)
                int sonrakiYil = sonrakiAyTarihi.Year; // Sonraki ayın yılı

                foreach (DataRow ogrenci in ogrenciDt.Rows)
                {
                    string tckimlikno = ogrenci["TCKimlikNo"].ToString();
                    string odano = ogrenci["OdaNo"].ToString();

                    // Sonraki ay ve yıl için mevcut kayıt olup olmadığını kontrol et
                    SqlCommand kontrolCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM AidatDurum WHERE TCKimlikNo = @tckimlikno AND Ay = @ay AND Yil = @yil", connection);
                    kontrolCmd.Parameters.AddWithValue("@tckimlikno", tckimlikno);
                    kontrolCmd.Parameters.AddWithValue("@ay", sonrakiAyAdi);
                    kontrolCmd.Parameters.AddWithValue("@yil", sonrakiYil);

                    int kayitSayisi = Convert.ToInt32(kontrolCmd.ExecuteScalar());

                    if (kayitSayisi == 0) // Eğer kayıt yoksa yeni bir kayıt ekle
                    {
                        SqlCommand ekleCmd = new SqlCommand(
                            "INSERT INTO AidatDurum (TCKimlikNo, OdaNo, Ay, Yil, AidatTutari, OdemeDurumu, OdemeTarihi, Notlar) " +
                            "VALUES (@tckimlikno, @odano, @ay, @yil, @tutar, @durum, @tarih, @notlar)", connection);
                        ekleCmd.Parameters.AddWithValue("@tckimlikno", tckimlikno);
                        ekleCmd.Parameters.AddWithValue("@odano", odano);
                        ekleCmd.Parameters.AddWithValue("@ay", sonrakiAyAdi);
                        ekleCmd.Parameters.AddWithValue("@yil", sonrakiYil);
                        ekleCmd.Parameters.AddWithValue("@tutar", 500); // Varsayılan aidat tutarı
                        ekleCmd.Parameters.AddWithValue("@durum", "0"); // Ödeme durumu: Ödenmedi
                        ekleCmd.Parameters.AddWithValue("@tarih", DBNull.Value); // Ödeme tarihi: Boş
                        ekleCmd.Parameters.AddWithValue("@notlar", "Ödeme bekleniyor.");

                        ekleCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Sonraki ayın aidatları başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele(); // Aidat durumunu güncellenmiş olarak listele
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
