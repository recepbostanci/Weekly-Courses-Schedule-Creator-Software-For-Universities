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
    public partial class FizikselSiniflar : Form
    {
        Fonksiyon system = new Fonksiyon();
        public FizikselSiniflar()
        {
            InitializeComponent();
            ListeDoldur();
            Temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtSinifAdi.Text != "")
            {
                system.cmd("insert into FizSiniflar (SinifAdi, Kat, Kapasite, Aciklama) values('" + txtSinifAdi.Text + "','" + txtSinifYeri.Text + "','" + txtSinifKapst.Text + "','" + txtSinAciklama.Text + "')");
                ListeDoldur();
                Temizle();
            }
            else
            {
                MessageBox.Show("Sınıf Adı Boş Bırakılamaz!","Uyarı!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string SinifAdi = system.GetDataCell("select SinifAdi from FizSiniflar where SinifId=" + txtSinKoduSil.Text + "").ToString();
                DialogResult sonuc = MessageBox.Show(SinifAdi.ToString() + "ni silmek istiyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo);
                if (sonuc == DialogResult.Yes)
                {
                    system.cmd("delete from FizSiniflar where SinifId=" + txtSinKoduSil.Text + "");
                    ListeDoldur();
                    Temizle();
                }
            }
            catch 
            {

                MessageBox.Show("Derslik Bulunamadı!", "Hata!");
            }
            
            
        }
        void ListeDoldur()
        {

            DataTable dt = new DataTable();
            dt = system.GetDataTable("SELECT SinifId,SinifAdi, Kat, Kapasite, Aciklama FROM FizSiniflar");
            dataGridView1.DataSource = dt;


        }
        void Temizle()
        {
            txtSinYeriG.Clear();
            txtSinKoduSil.Clear();
            txtSinifId.Clear();
            txtSinKapG.Clear();
            txtSinifYeri.Clear();
            txtSinifKapst.Clear();
            txtSinifAdi.Clear();
            txtSinAdiG.Clear();
            txtSinAciklamaG.Clear();
            txtSinAciklama.Clear();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dtFizSinif = system.GetDataRow("select * from FizSiniflar where SinifId=" + txtSinifId.Text + "");
                txtSinAciklamaG.Text = dtFizSinif["Aciklama"].ToString();
                txtSinAdiG.Text = dtFizSinif["SinifAdi"].ToString();
                txtSinKapG.Text = dtFizSinif["Kapasite"].ToString();
                txtSinYeriG.Text = dtFizSinif["Kat"].ToString();
            }
            catch 
            {

                MessageBox.Show("Derslik Bulunamadı!", "Hata!");
            }
                

           
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string sinifadi = system.GetDataCell("select SinifAdi from FizSiniflar where SinifId=" + txtSinifId.Text + "").ToString();
                system.cmd("update  FizSiniflar set SinifAdi='" + txtSinAdiG.Text + "', Kat='" + txtSinYeriG.Text + "', Kapasite='" + txtSinKapG.Text + "', Aciklama='" + txtSinAciklamaG.Text + "' where SinifId=" + txtSinifId.Text + "");
                MessageBox.Show("Sınıf Bilgileri Güncellendi.","Bilgi!");
                ListeDoldur();
            }
            catch 
            {

                MessageBox.Show("Derslik Bulunamadı!", "Hata!");
            }
            
        }
        
    }
}
