using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace YurtOtomasyonu
{
    public partial class TalepGonder : DevExpress.XtraEditors.XtraForm
    {
        private string TcKimlikNo;

        public TalepGonder(string tcKimlikNo)
        {
            InitializeComponent();
            TcKimlikNo = tcKimlikNo;
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            txtTCKimlikNo.Text = TcKimlikNo;
            txtTCKimlikNo.Properties.ReadOnly = true; // TextEdit'i sadece okunabilir yapma

            // ComboBoxEdit öğeleri ekleme
            cmbTalepTuru.Properties.Items.AddRange(new object[] {
                "Oda Değişikliği Talebi",
                "İzin Talebi",
                "Tamir Talebi",
                "Temizlik Talebi",
                "Diğer Talepler"
            });

            // Buton olayları
            btnGonder.Click += BtnGonder_Click;
            btnTemizle.Click += BtnTemizle_Click;

            // GridControl için veritabanından veri çekeceğiz
            gridControlTalepler.DataSource = GetData();

            // GridView olayları
            GridViewTalepler.FocusedRowChanged += GridViewTalepler_FocusedRowChanged;
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            // Veritabanına veri ekleme kodu
            string connectionString = "Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Talepler (TCKimlikNo, TalepTuru, TalepDetay, TalepTarihi) VALUES (@TCKimlikNo, @TalepTuru, @TalepDetay, @TalepTarihi)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TCKimlikNo", txtTCKimlikNo.Text);
                    command.Parameters.AddWithValue("@TalepTuru", cmbTalepTuru.EditValue?.ToString());
                    command.Parameters.AddWithValue("@TalepDetay", txtTalepDetay.Text);
                    command.Parameters.AddWithValue("@TalepTarihi", dtpTalepTarihi.DateTime);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Talep başarıyla gönderildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Veritabanından güncel verileri çekip GridControl'e yükleme
            gridControlTalepler.DataSource = GetData();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            txtTCKimlikNo.Text = TcKimlikNo; // TCKimlikNo alanını temizlememek için aynı değeri atama
            cmbTalepTuru.EditValue = null;
            txtTalepDetay.Text = "";
            dtpTalepTarihi.EditValue = null;
        }

        private DataTable GetData()
        {
            DataTable table = new DataTable();
            string connectionString = "Data Source=.;Initial Catalog=Yurt_Otomasyonu;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TCKimlikNo, TalepTuru, TalepDetay, TalepTarihi FROM Talepler WHERE TCKimlikNo = @TCKimlikNo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TCKimlikNo", TcKimlikNo);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }

            return table;
        }

        private void GridViewTalepler_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (GridViewTalepler.GetFocusedDataRow() is DataRow row)
            {
                txtTCKimlikNo.Text = row["TCKimlikNo"].ToString();
                cmbTalepTuru.EditValue = row["TalepTuru"].ToString();
                txtTalepDetay.Text = row["TalepDetay"].ToString();
                dtpTalepTarihi.DateTime = Convert.ToDateTime(row["TalepTarihi"]);
            }
        }
    }
}
