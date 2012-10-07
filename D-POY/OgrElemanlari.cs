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
    public partial class OgrElemanlari : Form
    {
        Fonksiyon system = new Fonksiyon();
        public OgrElemanlari()
        {
            InitializeComponent();
        }

        private void OgrElemanlari_Load(object sender, EventArgs e)
        {
            ListeDoldur();
            temizle();
         
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdSoyad.Text != "")
                {
                    system.cmd("insert into OgrElemanlari (OeAdSoyad,OeUnvan,OeOdaNo,OeTel) values('" + txtAdSoyad.Text + "','" + txtUnvan.Text + "','" + txtOdaNo.Text + "','" + txtTel.Text + "')");

                    ListeDoldur();
                    temizle();
                }
                else {
                    MessageBox.Show("Ad Soyad Boş Geçilemez!","Uyarı!");
                }
                
            }
            catch 
            {
                MessageBox.Show("Hatalı Parametre !","Hata!");
               
            }
           
            
        }
        void temizle()
        {
            txtAdSoyad.Clear();
            txtOdaNo.Clear();
            txtTel.Clear();
            txtUnvan.Clear();
        }
        
        void ListeDoldur()
        { 
        
            DataTable dt = new DataTable();
            dt = system.GetDataTable("SELECT * FROM OgrElemanlari");
            dataGridView1.DataSource = dt;
            
        
        }
        
        



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblVerdigiDersler.Text = "";
                string OgrId = "";
                DataTable dtOgrler = system.GetDataTable("select * from OgrElemanlari");
                DataRow drOgr = dtOgrler.Rows[dataGridView1.CurrentRow.Index];
                OgrId = drOgr["OeId"].ToString();
                lblAdSoyad2.Text = drOgr["OeUnvan"].ToString() +" " + drOgr["OeAdSoyad"].ToString();
                DataTable dtVerdigiDersler = system.GetDataTable("select * from Dersler where OeId='" + OgrId + "'");
                int sira = 1;
                for (int i = 0; i < dtVerdigiDersler.Rows.Count; i++)
                {
                    DataRow drVerdigiDers = dtVerdigiDersler.Rows[i];
                    lblVerdigiDersler.Text = drVerdigiDers["DersAdi"].ToString() + " , " + lblVerdigiDersler.Text;
                    sira++;
                }
            }
            catch 
            {
                
               
            }
            
        }

        
 

        private void button1_Click(object sender, EventArgs e)
        {
            ListeDoldur();
        }

       
       
    }
}
