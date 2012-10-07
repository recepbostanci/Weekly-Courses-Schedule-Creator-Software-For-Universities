using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace D_POY
{
    public partial class GunVeSaatler : Form
    {
        Fonksiyon system = new Fonksiyon();
        
        public GunVeSaatler()
        {
            InitializeComponent();
            cmbOgretimDilimi.Items.Add("I.Ogretim");
            cmbOgretimDilimi.Items.Add("II.Ogretim");
            cmbGunler.Items.Clear();
            Guncek();
            ListeDoldur();
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dersBaslama = DateTime.Parse(txtDersBaslamaZamanı.Text);
                DateTime dersBitis;

                ArrayList alDesrler = new ArrayList();
                for (int i = 0; i < nmDersSayisi.Value; i++)
                {
                    dersBitis = dersBaslama.AddMinutes((double)nmDersSuresi.Value);

                    alDesrler.Add(dersBaslama.ToShortTimeString() + "___" + dersBitis.ToShortTimeString());

                    dersBaslama = dersBaslama.AddMinutes((double)nmDersSuresi.Value);
                    dersBitis = dersBaslama.AddMinutes((double)nmDersSuresi.Value);

                    dersBaslama = dersBaslama.AddMinutes((double)nmTenefusSuresi.Value);

                }

                for (int i = 0; i < alDesrler.Count; i++)
                {
                    lbSaatler.Items.Add(alDesrler[i]);
                }

            }
            catch 
            {
                MessageBox.Show("Hatalı parametre girişi!","Uyarı!");
                
            }

        }

        private void GunVeSaatler_Load(object sender, EventArgs e)
        {
            
            
        }
        void Guncek()
        {
            DataTable dtGunler = system.GetDataTable("select * from DersGunleri where Secili='0'");

            int sira = 1;
            for (int i = 0; i < dtGunler.Rows.Count; i++)
            {
                DataRow drGun = dtGunler.Rows[i];
                cmbGunler.Items.Add(drGun["GunAdi"].ToString());
                sira++;
            }
        
        }
        void ListeDoldur()
        {
            dataGridView1.DataSource = system.GetDataTable("select GunId as Gün_Kodu, GunAdi from DersGunleri where Secili='1'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            system.cmd("update DersGunleri set Secili='1' where GunAdi='"+cmbGunler.Text+"'");
            cmbGunler.Items.Clear();
            Guncek();
            ListeDoldur();
            GunSirala();

        }
        void GunSirala()
        {
            DataTable dtGunler = system.GetDataTable("select * from DersGunleri where Secili='1'");
            int sira = 0;
            for (int i = 0; i < dtGunler.Rows.Count; i++)
            {
                DataRow dr = dtGunler.Rows[i];
                system.cmd("update DersGunleri set Gss='"+sira+"' where GunId="+dr["GunId"]+"");

                sira++;
            }

            DataTable dtGunlerDiger = system.GetDataTable("select * from DersGunleri where Secili='0'");

            for (int i = 0; i < dtGunlerDiger.Rows.Count; i++)
            {
                DataRow dr = dtGunlerDiger.Rows[i];
                system.cmd("update DersGunleri set Gss='-' where GunId=" + dr["GunId"] + "");

            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                system.cmd("update DersGunleri set Secili='0' where GunId=" + txtSilinecekGunId.Text + "");
                cmbGunler.Items.Clear();
                Guncek();
                ListeDoldur();
                GunSirala();
            }
            catch 
            {
                MessageBox.Show("Hatalı Parametre !", "Uyarı!");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            system.cmd("delete from GunlukDersler where ODilimi='"+cmbOgretimDilimi.Text+"'");
            MessageBox.Show("Eski kayıtlar silindi!","Uyarı!");
            lbSaatler.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lbSaatler.Items.Clear();
            DataTable dtEskiDersSaatleri = system.GetDataTable("Select * from GunlukDersler where ODilimi='"+cmbOgretimDilimi.Text+"'");

            for (int i = 0; i < dtEskiDersSaatleri.Rows.Count; i++)
            {
                DataRow drSaat = dtEskiDersSaatleri.Rows[i];
                lbSaatler.Items.Add(drSaat["DersBaslamaSaati"].ToString() + "-" + drSaat["DersBitisSaati"].ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dersBaslama = DateTime.Parse(txtDersBaslamaZamanı.Text);
                DateTime dersBitis;
                int DSS = 0;

                string ODilimi = cmbOgretimDilimi.Text;
                for (int i = 0; i < nmDersSayisi.Value; i++)
                {
                    dersBitis = dersBaslama.AddMinutes((double)nmDersSuresi.Value);
                    system.cmd("insert into GunlukDersler (Dss,DersBaslamaSaati,DersBitisSaati,ODilimi) values('" + DSS + "','" + dersBaslama.ToShortTimeString() + "','" + dersBitis.ToShortTimeString() + "','" + ODilimi + "')");
                    dersBaslama = dersBaslama.AddMinutes((double)nmDersSuresi.Value);
                    dersBitis = dersBaslama.AddMinutes((double)nmDersSuresi.Value);

                    dersBaslama = dersBaslama.AddMinutes((double)nmTenefusSuresi.Value);
                    DSS++;
                }
                MessageBox.Show("Ders saatleri eklendi!", "Uyarı!");
            }
            catch 
            {
                MessageBox.Show("Hatalı Parametre Girişi Yaptınız!","Hata!");
            }
            
        }

        private void cmbOgretimDilimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSaatler.Items.Clear();
        }
    }
}
