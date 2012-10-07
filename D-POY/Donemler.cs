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
    public partial class Donemler : Form
    {
        Fonksiyon system = new Fonksiyon();
        public Donemler()
        {
            InitializeComponent();
            ListeDoldur();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtDonemAdi.Text != "")
            {
                system.cmd("insert into Donemler (DonemAdi) values('" + txtDonemAdi.Text + "')");
                ListeDoldur();
                Temizle();
            }
            else
            {
                MessageBox.Show("Dönem Adı Boş Geçilemez!","Uyarı!");
            }
            
            
        }
        void ListeDoldur()
        {

            DataTable dt = new DataTable();
            dt = system.GetDataTable("SELECT DonemId as Dönem_Kodu, DonemAdi as Dönem FROM Donemler");
            dataGridView1.DataSource = dt;


        }

        

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                string DonemAdi = system.GetDataCell("select DonemAdi from Donemler where DonemId =" + txtDonemIdSilinecek.Text + "").ToString();
                DialogResult sonuc= MessageBox.Show(DonemAdi.ToString() + "ni silmek istiyor musunuz?","Uyarı!",MessageBoxButtons.YesNo);
                if (sonuc == DialogResult.Yes)
                {
                    system.cmd("delete from Donemler where DonemId =" + txtDonemIdSilinecek.Text + "");
                    Temizle();
                    ListeDoldur();   
                }
                
            }
            catch 
            {
                MessageBox.Show("Hatalı Dönem Kodu Girdiniz!","Hata!");
            }
           
        }
        void Temizle()
        {
            txtDonemIdSilinecek.Clear();
            txtDonemIdG.Clear();
            txtDonemAdiG.Clear();
            txtDonemAdi.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                string DonemAdi = system.GetDataCell("select DonemAdi from Donemler where DonemId =" + txtDonemIdG.Text + "").ToString();
                
                txtDonemAdiG.Text = DonemAdi;


            }
            catch 
            {
                MessageBox.Show("Hatalı Dönem Kodu Girdiniz!","Hata!");
            }
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string DonemAdi = system.GetDataCell("select DonemAdi from Donemler where DonemId=" + txtDonemIdG.Text + "").ToString();
                system.cmd("update  Donemler set DonemAdi='" +  txtDonemAdiG.Text+ "' where DonemId=" + txtDonemIdG.Text + "");
                Temizle();
                ListeDoldur();
                MessageBox.Show("Dönem Adı Güncellendi.","Bilgi!");
            }
            catch 
            {
                MessageBox.Show("Hatalı Dönem Kodu Girdiniz!","Hata!");
            }
           
        }
    }
}
