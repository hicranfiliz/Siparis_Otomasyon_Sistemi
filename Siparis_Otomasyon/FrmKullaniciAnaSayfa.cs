using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Siparis_Otomasyon
{
    public partial class FrmKullaniciAnaSayfa : Form
    {
        public FrmKullaniciAnaSayfa()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            FrmUrunEklemeSayfasi fr = new FrmUrunEklemeSayfasi();
            fr.Show();
            this.Hide();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
