using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;

namespace D_POY
{
    public partial class Dersler : Form
    {
        Fonksiyon system = new Fonksiyon();
        public Dersler()
        {
            InitializeComponent();
            SinifCek();
            DersTip();
            OgretimElemaniCek();
            SecDersGrup();
            ListeDoldur();
            Temizle();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtDersAdi.Text != "")
            {
                string OeId = system.GetDataCell("select OeId from OgrElemanlari where OeAdSoyad='" + cmbOgrGor.Text + "' ");
                string DonemId = system.GetDataCell("select DonemId from Donemler where DonemAdi='" + cmbDonemAdi.Text + "' ");
                system.cmd("insert into Dersler (DersAdi, Sinif, DersTip, SecDersGrup, DersKredi, DersSaati, OeId, DonemId) values('" +
                txtDersAdi.Text + "','" +
                cmbSinif.Text + "','" +
                cmbTip.Text + "','" +
                cmbSecDersGrup.Text + "','" +
                txtKredi.Text + "','" +
                txtSaati.Text + "','" +
                OeId + "','" +
                DonemId + "')");
                Temizle();
                ListeDoldur();
            }
            else
            {
                MessageBox.Show("Ders Adı Bos Geçilemez!","Uyarı!");
            }
            
        }
        
       

        void ListeDoldur()
        {

            DataTable dt = new DataTable();
            dt = system.GetDataTable("SELECT DersId,DersAdi, DersTip, DersKredi, DersSaati FROM Dersler");
            dataGridView1.DataSource = dt;


        }
        void Temizle()
        {
            txtDersAdi.Clear(); 
            txtSaati.Clear();

           
        
        }

        private void Dersler_Load(object sender, EventArgs e)
        {
            cmbSecDersGrup.Enabled = false;
            cmbTip.SelectedIndex = 0;
            DonemCek();
        }

        
        void SinifCek()
        {
            DataTable dtSiniflar = system.GetDataTable("select * from OgrSiniflar order by OgrSinifAdi");
            string Sinif = "";
            int sira = 1;
            for (int i = 0; i < dtSiniflar.Rows.Count; i++)
            {
                DataRow drKategori = dtSiniflar.Rows[i];
                cmbSinif.Items.Add(drKategori["OgrSinifAdi"].ToString());
                sira++;
            }

            for (int i = 0; i < cmbSinif.Items.Count; i++)
            {

                Sinif = cmbSinif.Items[i].ToString();
                for (int j = i + 1; j < cmbSinif.Items.Count; j++)
                {
                    if (Sinif == cmbSinif.Items[j].ToString())
                    {
                        cmbSinif.Items.RemoveAt(j);
                    }

                }
            }
        }
        void DersTip()
        {
            cmbTip.Items.Add("Zorunlu");
            cmbTip.Items.Add("Secmeli");
            
        }

        private void cmbTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTip.SelectedItem == "Zorunlu")
	        {
                cmbSecDersGrup.SelectedIndex = 0;
                cmbSecDersGrup.Enabled = false;

	        }
            if (cmbTip.SelectedItem == "Secmeli")
            {
                cmbSecDersGrup.Enabled = true;
            } 
        }

        void OgretimElemaniCek()
        {
            DataTable dtOElemanlari = system.GetDataTable("select * from OgrElemanlari");

            int sira = 1;
            for (int i = 0; i < dtOElemanlari.Rows.Count; i++)
            {
                DataRow drOElemani = dtOElemanlari.Rows[i];
                cmbOgrGor.Items.Add(drOElemani["OeAdSoyad"].ToString());
                sira++;
            }
        }
        void SecDersGrup()
        {
            DataTable dtSecmeliDersGrup = system.GetDataTable("select * from SecDersGrup");
            cmbSecDersGrup.Items.Insert(0, "---");
            int sira = 1;
            for (int i = 0; i < dtSecmeliDersGrup.Rows.Count; i++)
            {
                DataRow drGrup = dtSecmeliDersGrup.Rows[i];
                cmbSecDersGrup.Items.Add(drGrup["GrupAdi"].ToString());
                sira++;
            }
            cmbSecDersGrup.SelectedIndex = 0;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            ListeDoldur();
        }

        private void cmbSinif_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void DonemCek()
        {
            DataTable dtDonemler = system.GetDataTable("select * from Donemler");

            for (int i = 0; i < dtDonemler.Rows.Count; i++)
            {
                DataRow drDonem = dtDonemler.Rows[i];
                cmbDonemAdi.Items.Add(drDonem["DonemAdi"].ToString());

                cmbDonemAdi.SelectedIndex = 0;
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
