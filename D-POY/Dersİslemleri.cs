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
    public partial class Dersİslemleri : Form
    {
        Fonksiyon system = new Fonksiyon();
        public Dersİslemleri()
        {
            InitializeComponent();
            DersTip();
            SinifCek();
            SecDersGrup();
            OgretimElemaniCek();
            DonemCek();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string DersAdi = system.GetDataCell("select DersAdi from Dersler where DersId=" + txtDersId.Text + "").ToString();
                string OeId = system.GetDataCell("select OeId from OgrElemanlari where OeAdSoyad='" + cmbOgrGor.Text + "' ");
                string DonemId = system.GetDataCell("select DonemId from Donemler where DonemAdi='" + cmbDonemAdi.Text + "' ");
                system.cmd("update  Dersler set DersAdi='" + txtDersAdi.Text +
                "', DersSaati='" + txtSaati.Text +
                "', DersKredi='" + txtKredisi.Text +
                "', OeId ='" + OeId +
                "', DersTip ='" + cmbDersTip.Text +
                "', SecDersGrup ='" + cmbSecDersGrup.Text +
                "', Sinif  ='" + cmbSinif.Text +
                "', DonemId  ='" + DonemId +
                "' where DersId=" + txtDersId.Text + "");
                MessageBox.Show("Ders Bilgileri Güncellendi.","Bilgi");
            }
            catch 
            {
                MessageBox.Show("Hatalı Parametre.","Hata!");
               
            }
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dtDersler = system.GetDataRow("select * from Dersler where DersId=" + Int32.Parse(txtDersId.Text) + "");
                txtDersAdi.Text = dtDersler["DersAdi"].ToString();
                txtKredisi.Text = dtDersler["DersKredi"].ToString();
                txtSaati.Text = dtDersler["DersSaati"].ToString();
                cmbOgrGor.SelectedItem = system.GetDataCell("select OeAdSoyad from OgrElemanlari where OeId="+dtDersler["OeId"]+"");
                cmbDersTip.SelectedItem = dtDersler["DersTip"].ToString();
                cmbSecDersGrup.SelectedItem= dtDersler["SecDersGrup"].ToString();
                cmbSinif.SelectedItem = dtDersler["Sinif"].ToString();
                cmbDonemAdi.SelectedItem = system.GetDataCell("select DonemAdi  from Donemler Where DonemId=" + dtDersler["DonemId"] + "");
            }
            catch 
            {
                MessageBox.Show("Hatalı Ders kodu!","Hata!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                string DersAdi = system.GetDataCell("select DersAdi from Dersler where DersId=" + txtDersIdSilinecek.Text + "");
                DialogResult sonuc;
                sonuc= MessageBox.Show(DersAdi.ToString() + "ni silmek istiyor musunuz?", "UYARI !",MessageBoxButtons.YesNo);
                if (sonuc==DialogResult.Yes)
                {
                    system.cmd("delete from Dersler where DersId=" + txtDersIdSilinecek.Text + ""); 
                }
                


            }
            catch
            {
                MessageBox.Show("Hatalı Ders Kodu Girdiniz!","Hata!");
            }
        }
        
        void SinifCek()
        {
            DataTable dtSiniflar = system.GetDataTable("select * from OgrSiniflar order by OgrSinifAdi");

            int sira = 1;
            for (int i = 0; i < dtSiniflar.Rows.Count; i++)
            {
                DataRow drKategori = dtSiniflar.Rows[i];
                cmbSinif.Items.Add(drKategori["OgrSinifAdi"].ToString());
                sira++;
            }

            for (int i = 0; i < cmbSinif.Items.Count; i++)
            {

                string Sinif = cmbSinif.Items[i].ToString();
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
            cmbDersTip.Items.Add("Zorunlu");
            cmbDersTip.Items.Add("Secmeli");

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

        private void Dersİslemleri_Load(object sender, EventArgs e)
        {

        }
    }
}
