using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace D_POY
{
    public partial class KullaniciBilgilerim : Form
    {
        Fonksiyon system = new Fonksiyon();
        public KullaniciBilgilerim()
        {
            InitializeComponent();
        }

        private void KullaniciBilgilerim_Load(object sender, EventArgs e)
        {
            BilgiYenile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            system.cmd("update Kullanicilar set KullaniciAdi='"+txtYKullaniciAdi.Text+"' where Durum='1'");
            BilgiYenile();
            MessageBox.Show("Bilgi Güncellendi!","Bilgi!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            system.cmd("update Kullanicilar set KullaniciSifre='" + txtYeniSifre.Text + "' where Durum='1'");
            BilgiYenile();
            MessageBox.Show("Bilgi Güncellendi!", "Bilgi!");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }
        void BilgiYenile()
        {
            txtEKullaniciAdi.Text = system.GetDataCell("select KullaniciAdi from Kullanicilar where Durum='1'");

            txtKullaniciAdi.Text = system.GetDataCell("select KullaniciAdi from Kullanicilar where Durum='1'");
        }
    }
}
