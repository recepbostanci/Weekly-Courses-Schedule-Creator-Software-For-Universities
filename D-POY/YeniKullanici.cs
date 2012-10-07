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
    public partial class YeniKullanici : Form
    {
        Fonksiyon system = new Fonksiyon();
        public YeniKullanici()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text != txtSifreDogrula.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor!");
            }
            else
            {
                system.cmd("insert into Kullanicilar (KullaniciAdi,KullaniciSifre) values('" + txtKullaniciAdi.Text + "','" + txtSifre.Text + "')");
                MessageBox.Show("Kullanıcı Sisteme Kaydedildi.Teşekkürler","Bilgi!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                system.cmd("insert into BolumBilgileri (UniAd,UniFak,UniBol,UniWeb,UniAdres,UniTel,UniFax,Secili) values('" +
                                txtUniAd.Text + "','" +
                                txtUniFak.Text + "','" +
                                txtUniBol.Text + "','" +
                                txtUniWeb.Text + "','" +
                                txtUniAdres.Text + "','" +
                                txtUniTel.Text + "','" +
                                txtUniFax.Text + "','"+
                                "1" + "')");
                MessageBox.Show("Üniversite Bilgileri Sisteme Kaydedildi. Teşekkürler", "Bilgi!");
            }
            catch 
            {
                MessageBox.Show("Hatalı parametre", "Hata!");
            }
            
        }
    }
}
