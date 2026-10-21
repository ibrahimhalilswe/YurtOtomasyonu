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

namespace YurtOtomasyonu
{
    public partial class SecimFormu : DevExpress.XtraEditors.XtraForm
    {
        public SecimFormu()
        {
            InitializeComponent();
        }

        private void Ytngrs_Click(object sender, EventArgs e)
        {
            YoneticiGiris Ytngrs = new YoneticiGiris();
            this.Hide();
            Ytngrs.Show();
        }

        private void Ogrnbtn_Click(object sender, EventArgs e)
        {
            OgrenciGiris Ogrngrs = new OgrenciGiris();
            this.Hide();
            Ogrngrs.Show();
        }
    }
}