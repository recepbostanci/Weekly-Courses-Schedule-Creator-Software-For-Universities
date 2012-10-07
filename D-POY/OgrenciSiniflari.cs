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
    public partial class OgrenciSiniflari : Form
    {
        Fonksiyon system = new Fonksiyon();
        public OgrenciSiniflari()
        {
            InitializeComponent();
            ListeDoldur();
            OgrDilimleriCek();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtSinifAdi.Text != "")
            {
                system.cmd("insert into OgrSiniflar (OgrSinifAdi,OgrSinifDilim) values('" + txtSinifAdi.Text + "','" + cmbDilimi.Text + "')");
                ListeDoldur();
            }
            else
            {
                MessageBox.Show("Sınıf Adı Boş Bırakılamaz!","Uyarı!");
            }
            
        }
        void ListeDoldur()
        {

            DataTable dt = new DataTable();
            dt = system.GetDataTable("SELECT OgrSinifId as Sınıf_Kodu, OgrSinifAdi as Sınıf, OgrSinifDilim as Öğretim_Dilim FROM OgrSiniflar");
            dataGridView1.DataSource = dt;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string SinifAdi = system.GetDataCell("select OgrSinifAdi from OgrSiniflar where OgrSinifId=" + txtSinKoduSil.Text + "").ToString();
                DialogResult sonuc = MessageBox.Show(SinifAdi.ToString() + "ni silmek istiyor musunuz?","Uyarı!",MessageBoxButtons.YesNo);
                if (sonuc == DialogResult.Yes)
                {
                    system.cmd("delete from OgrSiniflar where OgrSinifId=" + txtSinKoduSil.Text + "");
                    ListeDoldur();
                }
                
            }
            catch
            {

                MessageBox.Show("Hatalı sınıf kodu !","Hata!");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dtOgrSinif = system.GetDataRow("select * from OgrSiniflar where OgrSinifId=" + txtSinifId.Text + "");

                txtSinAdiG.Text = dtOgrSinif["OgrSinifAdi"].ToString();
                cmbDilimG.SelectedItem = dtOgrSinif["OgrSinifDilim"].ToString();
            }
            catch 
            {

                MessageBox.Show("Hatalı Sınıf Kodu Girdiniz!","Hata!");
            }
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                string SınıfAdi = system.GetDataCell("select OgrSinifAdi from OgrSiniflar where OgrSinifId=" + txtSinifId.Text + "").ToString();
                system.cmd("update  OgrSiniflar set OgrSinifAdi='" + txtSinAdiG.Text + "', OgrSinifDilim='" + cmbDilimG.Text + "' where OgrSinifId=" + txtSinifId.Text + "");
                MessageBox.Show("Sınıf Bilgileri Güncellendi.");
                ListeDoldur();
            }
            catch 
            {
                MessageBox.Show("Hatalı Sınıf Kodu Girdiniz!", "Hata!");
               
            }
            
        }
        void OgrDilimleriCek()
        {
            cmbDilimi.Items.Add("I.Ogretim");
            cmbDilimi.Items.Add("II.Ogretim");
            cmbDilimG.Items.Add("I.Ogretim");
            cmbDilimG.Items.Add("II.Ogretim");
        }
    }
}
