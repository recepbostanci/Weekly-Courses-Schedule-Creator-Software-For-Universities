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
    public partial class DersDonemIliskileri : Form
    {
        Fonksiyon system = new Fonksiyon();
        public DersDonemIliskileri()
        {
            InitializeComponent();
            SinifCek();
            DonemCek();
            
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string DonemId = system.GetDataCell("select DonemId from Donemler where DonemAdi='" + cmbDonemler.Text + "'");
                string ders = lbSecilmemisler.SelectedItem.ToString();
                system.cmd("update Dersler set  Sinif='" + lbSiniflar.SelectedItem.ToString() + "', DonemId='" + DonemId + "' where DersAdi='" + lbSecilmemisler.SelectedItem.ToString() + "'");
                ListeYenile();
            }
            catch 
            {
                MessageBox.Show("Ders seçimi yapınız.");
            }
            
        }

        void DonemCek()
        {
            DataTable dtDonemler = system.GetDataTable("select * from Donemler");

            
            
            int sira = 1;
            for (int i = 0; i < dtDonemler.Rows.Count; i++)
            {
                DataRow drDonem = dtDonemler.Rows[i];
                cmbDonemler.Items.Add(drDonem["DonemAdi"].ToString());    
                sira++;
            }
            cmbDonemler.SelectedIndex = 0;
            
        }
        void SinifCek()
        {
            DataTable dtSiniflar = system.GetDataTable("select * from OgrSiniflar order by OgrSinifAdi");


            string Sinif = "";
            int sira = 1;
            for (int i = 0; i < dtSiniflar.Rows.Count; i++)
            {
                DataRow drSinif = dtSiniflar.Rows[i];
                
                lbSiniflar.Items.Add(drSinif["OgrSinifAdi"].ToString());
                sira++;
            }
            
            
            for (int i = 0; i < lbSiniflar.Items.Count; i++)
            {
     
                Sinif = lbSiniflar.Items[i].ToString();
                for (int j =i+1; j < lbSiniflar.Items.Count; j++)
                {
                    if (Sinif == lbSiniflar.Items[j].ToString())
                    {
                        lbSiniflar.Items.RemoveAt(j);
                    }
                 
                }
            }
            lbSiniflar.SelectedIndex = 0;
            
        }

        private void DersDonemIliskileri_Load(object sender, EventArgs e)
        {
            lblNot.Text = "Not : Seçili dönemin ders programını hazırlamak için,"+
            "öncelikle  bu panelde dönem ve sınıfların derslerinin seçimini yapın";
        }

        private void lbSiniflar_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListeYenile();
            
        }
        void ListeYenile()
        {
            string DonemId = system.GetDataCell("select DonemId from Donemler where DonemAdi='" + cmbDonemler.Text + "'");
            lbSecilmisler.Items.Clear();
            lbSecilmemisler.Items.Clear();
            
            DataTable dtSecilmemisDersler = system.GetDataTable("select * from Dersler where Sinif='0'");


            int sira = 1;
            for (int i = 0; i < dtSecilmemisDersler.Rows.Count; i++)
            {
                DataRow drSecilmemisDers = dtSecilmemisDersler.Rows[i];
                lbSecilmemisler.Items.Add(drSecilmemisDers["DersAdi"].ToString());
                sira++;
            }

            DataTable dtSecilmisDersler = system.GetDataTable("select * from Dersler where Sinif='" + lbSiniflar.SelectedItem.ToString() + "' and  DonemId='" + DonemId + "'");


            sira = 1;
            for (int i = 0; i < dtSecilmisDersler.Rows.Count; i++)
            {
                DataRow drSecilmisDers = dtSecilmisDersler.Rows[i];
                lbSecilmisler.Items.Add(drSecilmisDers["DersAdi"].ToString());
                sira++;
            }
        
        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            try
            {
                string ders = lbSecilmisler.SelectedItems.ToString();
                system.cmd("update Dersler set  Sinif='0' where DersAdi='" + lbSecilmisler.SelectedItem.ToString() + "'");
                ListeYenile();

            }
            catch
            {
                MessageBox.Show("Ders seçimi yapınız.");
            } 
        }

        private void cmbDonemler_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListeYenile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            system.cmd("update Dersler set  Sinif='0', DonemId='0'");
            ListeYenile();
        }

        private void lbSecilmemisler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNot_Click(object sender, EventArgs e)
        {

        }
    }
}
