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
    public partial class YoneticiPaneli : Form
    {
        Fonksiyon system = new Fonksiyon();
        public YoneticiPaneli()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        void YavruForm(Form yavru)
        {
            bool durum = false;
            foreach (Form eleman in this.MdiChildren)
            {
                if (eleman.Text == yavru.Text)
                {
                    durum = true;
                    eleman.Activate();

                }
            }
            if (durum == false)
            {
                yavru.MdiParent = this;
                yavru.Show();
               
            }
        
        }

        private void öğrElemanlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void derslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dönemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donemler donemler = new Donemler();
            YavruForm(donemler);
        }

        private void oESilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrElemanlari OgrElemanlari = new OgrElemanlari();
            YavruForm(OgrElemanlari);
        }

        private void oESilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OgrElemaniIslemleri OgrElemaniIslemleri = new OgrElemaniIslemleri();
            YavruForm(OgrElemaniIslemleri);
        }

        private void fizikselSınıflarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FizikselSiniflar FizikselSiniflar = new FizikselSiniflar();
            YavruForm(FizikselSiniflar);
        }

        private void öğrenciSınıflarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciSiniflari OgrenciSiniflari = new OgrenciSiniflari();
            YavruForm(OgrenciSiniflari);
        }

        private void dersGünVeSaatleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GunVeSaatler GunVeSaatler = new GunVeSaatler();
            YavruForm(GunVeSaatler);
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaSayfa AnaSayfa = new AnaSayfa();
            YavruForm(AnaSayfa);
        }

        private void desDonemSecimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersDonemIliskileri DersDonemIliskileri = new DersDonemIliskileri();
            YavruForm(DersDonemIliskileri);
        }

        private void dersListeleEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dersler dersler = new Dersler();
            YavruForm(dersler);
        }

        private void dersİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dersİslemleri Dersİslemleri = new Dersİslemleri();
            YavruForm(Dersİslemleri);
        }

        private void YoneticiPaneli_Load(object sender, EventArgs e)
        {
            system.cmd("update  Kullanicilar set durum='0'");
            //string KullaniciId = system.GetDataCell("select Durum from Kullanicilar where Durum='1'");
            //if (KullaniciId=="1")
            //{
            //    menuStrip1.Enabled = true;
            //}else
                menuStrip1.Enabled = false;
        }

        private void kullanıcıBilgilerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string KullaniciAdi= system.GetDataCell("select KullaniciAdi from Kullanicilar where KullaniciAdi='" + txtKullaniciAdi.Text + "' and KullaniciSifre='" + txtSifre.Text + "'");
            string KullaniciId= system.GetDataCell("select KullaniciId from Kullanicilar where KullaniciAdi='" + txtKullaniciAdi.Text + "' and KullaniciSifre='" + txtSifre.Text + "'");
            DataTable dtKullanicilar = system.GetDataTable("select * from Kullanicilar");
            if (dtKullanicilar.Rows.Count == 0)
            {
                MessageBox.Show("Sistemde kayıtlı Kullanıcı yok! Yeni Kullanıcı uygulamayı ekleyip tekrar başlatın!","Hata!");
                YeniKullanici YeniKullanici = new YeniKullanici();
                YavruForm(YeniKullanici);
                groupBox1.Visible = false;

            }
            else 
            {
                if (KullaniciAdi == txtKullaniciAdi.Text)
                {
                    system.cmd("update  Kullanicilar set durum='1' where KullaniciId="+KullaniciId+"");
                    menuStrip1.Enabled = true;
                    groupBox1.Visible = false;
                }
                else MessageBox.Show("Kullanıcı Adı yada şifre hatalı!","Hata!");
            
            }
            
            
            
            }

        private void loginBilgiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciBilgilerim KullaniciBilgilerim = new KullaniciBilgilerim();
            YavruForm(KullaniciBilgilerim);
        }

        private void bölümBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BolumBilgileri BolumBilgileri = new BolumBilgileri();
            YavruForm(BolumBilgileri);
        }
            
        


    }
}
