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
    public partial class OgrElemaniIslemleri : Form
    {
        Fonksiyon system = new Fonksiyon();
        public OgrElemaniIslemleri()
        {
            InitializeComponent();
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dtOgrElemani = system.GetDataRow("select * from OgrElemanlari where OeId=" + txtOgrId.Text + "");
                txtAdSoyad.Text = dtOgrElemani["OeAdSoyad"].ToString();
                txtOdaNo.Text = dtOgrElemani["OeOdaNo"].ToString();
                txtUnvan.Text = dtOgrElemani["OeUnvan"].ToString();
                txtTelNo.Text = dtOgrElemani["OeTel"].ToString();
            }
            catch 
            {
                MessageBox.Show("Hatalı Parametre!","Hata!");
            }
                
         
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string OgrAd = system.GetDataCell("select OeAdSoyad from OgrElemanlari where OeId =" + txtOgrId.Text + "").ToString();
                system.cmd("update  OgrElemanlari set OeAdSoyad='" + txtAdSoyad.Text + "', OeOdaNo='" + txtOdaNo.Text + "', OeUnvan='" + txtUnvan.Text + "', OeTel='" + txtTelNo.Text + "' where OeId =" + txtOgrId.Text + "");
                MessageBox.Show("Öğretim Elemanı Bilgileri Güncellendi.","Bilgi!");
            }
            catch 
            {
                MessageBox.Show("Hatalı Parametre!", "Hata!");
               
            }
            
        }

        void Temizle()
        {
            txtAdSoyad.Clear();
            txtOdaNo.Clear();
            txtOgrId.Clear();
            txtTelNo.Clear();
            txtUnvan.Clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtOgrId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGoruntule2_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dtOgrElemani = system.GetDataRow("select * from OgrElemanlari where OeId=" + txtOgrId2.Text + "");
                lblAdSoyad.Text = dtOgrElemani["OeAdSoyad"].ToString();
                lblOdaNo.Text = dtOgrElemani["OeOdaNo"].ToString();
                lblUnvan.Text = dtOgrElemani["OeUnvan"].ToString();
                lblTelNo.Text = dtOgrElemani["OeTel"].ToString();
            }
            catch 
            {

                MessageBox.Show("Hatalı Parametre!", "Hata!");
            }
            


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                string OgrAdi = system.GetDataCell("select OeAdSoyad from OgrElemanlari where OeId=" + txtOgrId2.Text + "");
                DialogResult sonuc= MessageBox.Show(OgrAdi.ToString() + "ni silmek istiyor musunuz?", "Bilgi!",MessageBoxButtons.YesNo);
                if (sonuc == DialogResult.Yes)
                {
                    system.cmd("delete from OgrElemanlari where OeId=" + txtOgrId2.Text + "");
                }
                
             
                
            }
            catch
            {
                MessageBox.Show("Hatalı Öğretim Elemanı Kodu Girdiniz!", "Hata!");
            }
        }
    }
}
