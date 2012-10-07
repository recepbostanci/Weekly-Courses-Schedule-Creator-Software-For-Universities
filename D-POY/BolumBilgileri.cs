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
    public partial class BolumBilgileri : Form
    {
        Fonksiyon system = new Fonksiyon();
        public BolumBilgileri()
        {
            InitializeComponent();
        }

        private void BolumBilgileri_Load(object sender, EventArgs e)
        {
            BilgiCek();

        }
        void BilgiCek()
        {
            try
            {
                DataRow drUniBil = system.GetDataRow("select * from BolumBilgileri where Secili='1'");
                txtUniAd.Text = drUniBil["UniAd"].ToString();
                txtUniAdres.Text = drUniBil["UniAdres"].ToString();
                txtUniBol.Text = drUniBil["UniBol"].ToString();
                txtUniFak.Text = drUniBil["UniFak"].ToString();
                txtUniFax.Text = drUniBil["UniFax"].ToString();
                txtUniTel.Text = drUniBil["UniTel"].ToString();
                txtUniWeb.Text = drUniBil["UniWeb"].ToString();
            }
            catch 
            {

                MessageBox.Show("Bölüm Bilgileri Girilmemiş","Bilgi!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            system.cmd("update BolumBilgileri set UniAd='" + txtUniAd.Text + 
                "', UniAdres='"+txtUniAdres.Text +
                "', UniBol='"+txtUniBol.Text+
                "', UniFak='"+txtUniFak.Text+
                "', UniFax ='"+txtUniFax.Text+
                "', UniTel='"+txtUniTel.Text+
                "', UniWeb ='"+txtUniWeb.Text+"' where Secili='1'");
            MessageBox.Show("Bilgiler Güncellendi!","Bilgi!",MessageBoxButtons.OKCancel);
        }
    }
}
