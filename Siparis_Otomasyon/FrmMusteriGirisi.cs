using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siparis_Otomasyon
{
    public partial class FrmMusteriGirisi : Form
    {
        public FrmMusteriGirisi()
        {
            InitializeComponent();
        }
        
        FrmMusteriKayit frmusterikayit = new FrmMusteriKayit();

        private void txtkullaniciadi_Click(object sender, EventArgs e)
        {
            txtkullaniciadi.Clear();
            pictureBox2.Image = Properties.Resources.user2;
            panel1.ForeColor=Color.FromArgb(78, 184, 206);
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txtkullaniciadi.ForeColor=Color.FromArgb(78, 184, 206);

            pictureBox3.Image = Properties.Resources.sifre1;
            panel2.ForeColor = Color.WhiteSmoke;
            panel2.ForeColor = Color.WhiteSmoke;
            txtsifre.ForeColor = Color.WhiteSmoke;

        }

        private void txtsifre_Click(object sender, EventArgs e)
        {
            txtsifre.Clear();
            txtsifre.PasswordChar = '*';
            pictureBox3.Image = Properties.Resources.sifre2;
            panel2.ForeColor = Color.FromArgb(78, 184, 206);
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txtsifre.ForeColor = Color.FromArgb(78, 184, 206);

            pictureBox2.Image = Properties.Resources._456212;
            panel1.ForeColor = Color.WhiteSmoke;
            txtkullaniciadi.ForeColor = Color.WhiteSmoke;
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frmusterikayit.Left += 10;
            if (frmusterikayit.Left>=830)
            {
                timer1.Stop();
                this.TopMost = false;
                frmusterikayit.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            frmusterikayit.Left -= 10;
            if (frmusterikayit.Left <= 525)
            {
                timer2.Stop();
            }
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            
            frmusterikayit.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                txtsifre.UseSystemPasswordChar = true;
            }
            else if (checkBox2.CheckState == CheckState.Unchecked)
            {
                txtsifre.UseSystemPasswordChar = false;
            }
        }
    }
}
