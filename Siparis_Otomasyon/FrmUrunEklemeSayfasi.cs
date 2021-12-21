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
    public partial class FrmUrunEklemeSayfasi : Form
    {
        public FrmUrunEklemeSayfasi()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void txtkullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into urun(urunId,kategori,marka,miktar,fiyat,KDV,urunadi,tarih,aciklama) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txturunId.Text);
            komut.Parameters.AddWithValue("@p2", cmbkategori.Text);
            komut.Parameters.AddWithValue("@p3", cmbmarka.Text);
            komut.Parameters.AddWithValue("@p4", txtmiktar.Text);
            komut.Parameters.AddWithValue("@p5", txtfiyat.Text);
            komut.Parameters.AddWithValue("@p6", txtKDV.Text);
            komut.Parameters.AddWithValue("@p7", txturunadi.Text);
            komut.Parameters.AddWithValue("@p8", txttarih.Text);
            komut.Parameters.AddWithValue("@p9", txtaciklama.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();


        }
    }
}
