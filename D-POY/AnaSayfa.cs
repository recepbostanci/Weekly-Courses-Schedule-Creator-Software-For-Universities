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
using System.Data.OleDb;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;
using System.Xml;
using Ms = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace D_POY
{
    public partial class AnaSayfa : Form
    {
        Fonksiyon system = new Fonksiyon();
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            DonemCek();
            SinifCek();
            OgretimDilimleri();
            OgretimElemaniCek();

        }
        void DonemCek()
        {
            DataTable dtDonemler = system.GetDataTable("select * from Donemler");

            for (int i = 0; i < dtDonemler.Rows.Count; i++)
            {
                DataRow drDonem = dtDonemler.Rows[i];
                cmbDonemDG.Items.Add(drDonem["DonemAdi"].ToString());
                cmbDonemOGG.Items.Add(drDonem["DonemAdi"].ToString());
                cmbDonemSG.Items.Add(drDonem["DonemAdi"].ToString());
                cmbDonemDG.SelectedIndex = 0;
                cmbDonemOGG.SelectedIndex = 0;
                cmbDonemSG.SelectedIndex = 0;
            }


        }
        void SinifCek()
        {
            DataTable dtSiniflar = system.GetDataTable("select * from OgrSiniflar order by OgrSinifAdi");
            string Sinif = "";
            int sira = 1;
            for (int i = 0; i < dtSiniflar.Rows.Count; i++)
            {
                DataRow drKategori = dtSiniflar.Rows[i];
                cmbSinifSG.Items.Add(drKategori["OgrSinifAdi"].ToString());
                sira++;
            }

            for (int i = 0; i < cmbSinifSG.Items.Count; i++)
            {

                Sinif = cmbSinifSG.Items[i].ToString();
                for (int j = i + 1; j < cmbSinifSG.Items.Count; j++)
                {
                    if (Sinif == cmbSinifSG.Items[j].ToString())
                    {
                        cmbSinifSG.Items.RemoveAt(j);
                    }

                }
                cmbSinifSG.SelectedIndex = 0;
            }

        }
        void OgretimDilimleri()
        {
            cmbOgrDilimiDG.Items.Add("I.Ogretim");
            cmbOgrDilimiDG.Items.Add("II.Ogretim");
            cmbOgrDilimiDG.SelectedIndex = 0;
            cmbOgrDilimiOGG.Items.Add("I.Ogretim");
            cmbOgrDilimiOGG.Items.Add("II.Ogretim");
            cmbOgrDilimiOGG.SelectedIndex = 0;
            cmbOgrDilimiSG.Items.Add("I.Ogretim");
            cmbOgrDilimiSG.Items.Add("II.Ogretim");
            cmbOgrDilimiSG.SelectedIndex = 0;
        }
        void OgretimElemaniCek()
        {
            DataTable dtOElemanlari = system.GetDataTable("select * from OgrElemanlari");

            for (int i = 0; i < dtOElemanlari.Rows.Count; i++)
            {
                DataRow drOElemani = dtOElemanlari.Rows[i];
                cmbOgrElemaiOGG.Items.Add(drOElemani["OeAdSoyad"].ToString());
                cmbOgrElemaiOGG.SelectedIndex = 0;
            }

        }

        void Komsuluklar()
        {
            
            string DonemId = system.GetDataCell("select DonemId From Donemler where DonemAdi='" + cmbDonemDG.Text + "'").ToString();
            DataTable dtDersler = system.GetDataTable("select * from dersler where DonemId='"+DonemId+"'");
            //DataTable dtDersler = system.GetDataTable("select * from dersler ");
            int[] alOgrler = new int[dtDersler.Rows.Count];
            int[] alDersler = new int[dtDersler.Rows.Count];
            int[] DersKomSay = new int[dtDersler.Rows.Count];
            
            for (int i = 0; i < dtDersler.Rows.Count; i++)
            {
                DataRow drDers = dtDersler.Rows[i];
                alOgrler[i] = Int32.Parse(drDers["OeId"].ToString());
                alDersler[i] = Int32.Parse(drDers["DersId"].ToString());
            }

            
            int KomSay;
            for (int i = 0; i < dtDersler.Rows.Count; i++)
            {
                int dersSinif = Int32.Parse(system.GetDataCell("select Sinif from dersler where dersId=" + alDersler[i] + "").ToString());
                DataTable dtKomsular = system.GetDataTable("Select * From Dersler Where (OeId='" + alOgrler[i] + "' or Sinif='" + dersSinif + "') and DonemId='" + DonemId + "'");
                //DataTable dtKomsular = system.GetDataTable("Select * From Dersler Where (OeId=" + alOgrler[i] + " or Sinif='" + dersSinif + "') ");

                KomSay = dtKomsular.Rows.Count;
                DersKomSay[i] = KomSay;
                
            }
            // dizi sırala
            #region Dersleri Sırala
            int temp, tempal, tempogr, n = dtDersler.Rows.Count;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 1; j < n - i; j++)
                {
                    if (DersKomSay[j] > DersKomSay[j - 1])
                    {
                        temp = DersKomSay[j - 1];
                        tempal = alDersler[j - 1];
                        tempogr = alOgrler[j - 1];

                        DersKomSay[j - 1] = DersKomSay[j];
                        alDersler[j - 1] = alDersler[j];
                        alOgrler[j - 1] = alOgrler[j];

                        DersKomSay[j] = temp;
                        alDersler[j] = tempal;
                        alOgrler[j] = tempogr;
                    }

                }

            }
            #endregion

            #region  Dizi Komsuluk Atamaları
            int[][] dizi = new int[dtDersler.Rows.Count][];
            KomSay = 0;
            for (int i = 0; i < dtDersler.Rows.Count; i++)
            {
                string dersSinif = system.GetDataCell("select Sinif from Dersler Where DersId=" + alDersler[i] + "");
                DataTable dtKomsular = system.GetDataTable("Select * From Dersler Where (OeId='" + alOgrler[i] + "' or Sinif='" + dersSinif + "') and DonemId='" + DonemId + "'");
                KomSay = dtKomsular.Rows.Count;
                dizi[i] = new int[3 + DersKomSay[i]]; // 0- DersId, 1- Komsuluk Sayısı, 2- Rengi

                dizi[i][0] = alDersler[i];
                dizi[i][1] = DersKomSay[i];
                dizi[i][2] = 0;

               

                for (int j = 3; j < KomSay + 3; j++)
                {
                    DataRow drKomsu = dtKomsular.Rows[j - 3];
                    dizi[i][j] = Int32.Parse(drKomsu["DersId"].ToString());
                }

            }
            #endregion

            // Renk Ataması
            #region Renk Atama
            int renk = 0;
            for (int i = 0; i < n; i++) // n=ders sayısı
            {
                renk++;
                if (dizi[i][2] == 0)
                {
                    dizi[i][2] = renk;
                }
                else
                    dizi[i][2] += renk;
                //lbDersler.Items.Add("-*-*-*-*-*-*-*-*-*");
                // komsuluğa ba. komssusu olan en büyük komsu sayısı olan derse  aynı rengi ver
                for (int j = i; j < n; j++)
                {
                    if (Komsumu(dizi, i, dizi[j][0]) == false)
                    {
                        dizi[j][2] -= 1;
                    }
                    //lbDersler.Items.Add(i + "^^" + dizi[j][0] + "_" + dizi[j][2]);
                }


            }
            #endregion
           

            # region Renklere Göre Dersleri Sırala
            int[,] dersler = new int[n, 3]; // 0-dersId   1-Ders saati   2- rengi

            for (int ass = 0; ass < n; ass++)
            {
                dersler[ass, 0] = dizi[ass][0];
                dersler[ass, 2] = dizi[ass][2];
                dersler[ass, 1] = Convert.ToInt32(system.GetDataCell("SELECT DersSaati FROM Dersler WHERE  DersId =" + dersler[ass, 0] + ""));
            }
            for (int s = 0; s < n; s++)  // 
            {
                for (int a = s + 1; a < n; a++)
                    if (dersler[s, 2] > dersler[a, 2])
                    {
                        int tp1 = dersler[s, 0];
                        int tp2 = dersler[s, 2];
                        int tp3 = dersler[s, 1];
                        dersler[s, 0] = dersler[a, 0];
                        dersler[s, 2] = dersler[a, 2];
                        dersler[s, 1] = dersler[a, 1];
                        dersler[a, 0] = tp1;
                        dersler[a, 2] = tp2;
                        dersler[a, 1] = tp3;
                    }
                //lbDersler.Items.Add(dersler[s, 0].ToString() + "--->" + dersler[s, 2].ToString());
            }
            //lbDersler.Items.Add(".....................");
            #endregion
            #region DERS PROGRAMI MATRİSİ
            int saatSayisi = system.GetDataTable("select * from GunlukDersler where ODilimi='" + cmbOgrDilimiDG.Text + "'").Rows.Count;
            int sinifSayisi = system.GetDataTable("select * from FizSiniflar").Rows.Count;
            int günsayisi = system.GetDataTable("select * from DersGunleri where secili='1'").Rows.Count;
            int kontrol = 0; // atanmış ders sayısı
            int atanacak = 0;
            int atlama = 0;
            int[, ,] DersP = new int[günsayisi, saatSayisi, sinifSayisi];
            for (int i = 0; i < günsayisi; i++)
            {
                atlama = 0;
                for (int j = 0; j < saatSayisi; j++)
                {
                    for (int k = 0; k < sinifSayisi; k++)
                    {
                        if (kontrol > 0)
                        {
                            if (dersler[kontrol, 2] != dersler[kontrol - 1, 2] || atlama > 0)
                            {

                                if (DersP[i, 0, 0] == 0)
                                    atlama = 0;
                                else
                                    atlama += 1;
                                if (atlama == 2)
                                    atanacak = dersler[kontrol, 0];
                                if ((Bak(DersP, i, j, dersler[kontrol, 0], sinifSayisi) == false) && (BakOgrSinif(DersP, i, j, dersler[kontrol, 0], sinifSayisi) == false))
                                {
                                    if (DersP[i, j, k] == 0 && (j + dersler[kontrol, 1] <= 7))  // ders atanmılş mı kontrolü
                                    {
                                        for (int t = 0; t < dersler[kontrol, 1]; t++) // 
                                            DersP[i, j + t, k] = dersler[kontrol, 0];
                                        kontrol++;
                                    }
                                }
                                else
                                {
                                    Degis(dersler, kontrol, dersler[kontrol, 2]);
                                    break;
                                    //{
                                    //    k--;
                                    //    if (dersler[kontrol, 0] == atanacak)
                                    //    {
                                    //        MessageBox.Show(k.ToString());
                                    //        MessageBox.Show(dersler[kontrol, 0].ToString());
                                    //        MessageBox.Show(atanacak.ToString());
                                    //        break;
                                    //    }
                                    //}

                                }
                            }
                            else
                            {
                                if (DersP[i, j, k] == 0 && (j + dersler[kontrol, 1] <= 7))  // ders atanmılş mı kontrolü
                                {
                                    for (int t = 0; t < dersler[kontrol, 1]; t++) // 
                                        DersP[i, j + t, k] = dersler[kontrol, 0];
                                    kontrol++;
                                }
                            }
                        }
                        else
                        {
                            if (DersP[i, j, k] == 0 && (j + dersler[kontrol, 1] <= 7))  // ders atanmılş mı kontrolü
                            {
                                for (int t = 0; t < dersler[kontrol, 1]; t++) // 
                                    DersP[i, j + t, k] = dersler[kontrol, 0];
                                kontrol++;
                            }
                        }

                        if (kontrol == n)
                            break;
                    }
                    if (kontrol == n)
                        break;
                }
                if (kontrol == n)
                    break;
            }


            #endregion
          

            excelRapor(günsayisi, saatSayisi, sinifSayisi, DersP);
        }//KOMSULUK METODU BİTİR
        bool Komsumu(int[][] dizi, int D1Index, int DersId)
        {
            bool durum = false;

            for (int i = 0; i < dizi[D1Index].Length; i++)
            {
                if (dizi[D1Index][i] == DersId)
                {
                    durum = true;
                    break;
                }
            }
            return durum;

        }

        bool Bak(int[, ,] DersP, int i, int j, int ders, int sinif)
        {
            int hoca = Convert.ToInt32(system.GetDataCell("SELECT OeId FROM Dersler WHERE DersId=" + ders + ""));
            for (int a = 0; a < sinif; a++)
            {
                if (hoca == Convert.ToInt32(system.GetDataCell("SELECT OeId FROM Dersler WHERE DersId=" + DersP[i, j, a] + "")))
                {
                    return true;
                }
            }
            return false;
        }

        bool BakOgrSinif(int[, ,] DersP, int i, int j, int ders, int sinif)
        {
            int Ogrsinif = Convert.ToInt32(system.GetDataCell("SELECT sinif FROm Dersler WHERE DersID=" + ders + ""));
            for (int a = 0; a < sinif; a++)
            {
                if (Ogrsinif == Convert.ToInt32(system.GetDataCell("SELECT sinif FROM Dersler WHERE DersId=" + DersP[i, j, a] + "")))
                {
                    return true;
                }
            }
            return false;
        }

        void Degis(int[,] dersler, int indis, int renk)
        {
            try // indeks hatası vermesi için son dersi göndermesi gerekir 
            {
                while (renk == dersler[indis + 1, 2])
                {
                    int ID = dersler[indis, 0];
                    int saat = dersler[indis, 1];
                    int Drenk = dersler[indis, 2];

                    dersler[indis, 0] = dersler[indis + 1, 0];
                    dersler[indis, 1] = dersler[indis + 1, 1];
                    dersler[indis, 2] = dersler[indis + 1, 2];

                    dersler[indis + 1, 0] = ID;
                    dersler[indis + 1, 1] = saat;
                    dersler[indis + 1, 2] = Drenk;

                    indis++;
                }
            }
            catch
            {
            }
        }
        public void excelRapor(int günsayisi, int saatSayisi, int sinifSayisi, int[, ,] DersP)
        {
            Ms.Application exceluygulama = new Ms.Application();
            Ms.Workbook ekitap = exceluygulama.Workbooks.Add(true);//bitane kitap
            exceluygulama.Visible = true;//sayfa göster
            Ms.Worksheet tablo = (Ms.Worksheet)ekitap.Worksheets[1];//kitaptan bir sayfa türettik
            this.Text = tablo.Name;//birinci SAyf
            Microsoft.Office.Interop.Excel.Range chartRange;
            DataTable dtderslikler = system.GetDataTable("select * from FizSiniflar");
            for (int i = 0; i < sinifSayisi; i++)
            {
                DataRow drDerslik = dtderslikler.Rows[i];
                tablo.Cells[3, i + 6] = drDerslik["SinifAdi"].ToString();
            }

            int satir =3, sutun = 4;

            for (int i = 0; i < günsayisi; i++)
            {

                satir++;
                tablo.Cells.RowHeight = 20;
                
                tablo.Cells.Borders.ColorIndex = 5;

                tablo.Cells[satir, sutun] = system.GetDataCell("select GunAdi from DersGunleri where Gss='" + i + "'");

                for (int j = 0; j < saatSayisi; j++)
                {
                    sutun = 4;
                    sutun++;
                    tablo.Cells[satir, sutun] = system.GetDataCell("select DersBaslamaSaati from GunlukDersler where Dss='" + j + "' and ODilimi='" + cmbOgrDilimiDG.Text + "'") + "-" + system.GetDataCell("select DersBitisSaati from GunlukDersler where Dss='" + j + "' and ODilimi='" + cmbOgrDilimiDG.Text + "'");
                    tablo.Cells[satir, sutun - 1] = system.GetDataCell("select GunAdi from DersGunleri where Gss='" + i + "'");
                    for (int k = 0; k < sinifSayisi; k++)
                    {
                        sutun++;
                        try
                        {
                            //tablo.Cells[satir, sutun] = DersP[i, j, k] + " ogr>" + system.GetDataCell("select OeId from Dersler where DersId='" + DersP[i, j, k] + "'");
                            tablo.Cells[satir, sutun] = system.GetDataCell("select DersAdi from Dersler where DersId=" + DersP[i, j, k] + "");


                        }
                        catch
                        {

                            tablo.Cells[satir, sutun] = 0;

                        }

                    }
                    satir++;

                }
            }
            int cc = saatSayisi*günsayisi +(günsayisi+2);
            tablo.get_Range("d2", "l2").Merge(false);

            tablo.Cells[2,4] = cmbDonemDG.Text+ "  "+cmbOgrDilimiDG.Text +" Dersliklere Göre Ders Programı";

            chartRange = tablo.get_Range("d2", "d2");
            chartRange.Font.Bold = true;
            //chartRange = tablo.get_Range("b15", "e15");
            //chartRange.Font.Bold = true;

            //chartRange.HorizontalAlignment = 3;
            //chartRange.VerticalAlignment = 3;

            chartRange = tablo.get_Range("d3", "l"+cc); // çerçeve yapılmış
            chartRange.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic);

            ekitap.SaveAs("C:\\Derslikler_DersProgramı.xlsx");
            ekitap.Close(true, Missing.Value, Missing.Value);
            exceluygulama.Quit();

        }

        private void btnDersliklereGore_Click(object sender, EventArgs e)
        {
            try
            {
                Komsuluklar();
            }
            catch
            {
                MessageBox.Show("Döneme ait kayıtlı ders bulunamadı!", "Hata!");
            }
            //Komsuluklar();
        }

        private void btnOgretimGorevlGore_Click(object sender, EventArgs e)
        {
            try
            {
                Komsuluklar2();
            }
            catch
            {
                MessageBox.Show("Döneme ait kayıtlı öğretim görevlisi bulunamadı!", "Hata!");
            }


        }
        void Komsuluklar2()
        {

            string DonemId = system.GetDataCell("select DonemId From Donemler where DonemAdi='" + cmbDonemOGG.Text + "'").ToString();
            DataTable dtDersler = system.GetDataTable("select * from dersler where DonemId='" + DonemId + "'");
            //DataTable dtDersler = system.GetDataTable("select * from dersler ");
            int[] alOgrler = new int[dtDersler.Rows.Count];
            int[] alDersler = new int[dtDersler.Rows.Count];
            int[] DersKomSay = new int[dtDersler.Rows.Count];

            for (int i = 0; i < dtDersler.Rows.Count; i++)
            {
                DataRow drDers = dtDersler.Rows[i];
                alOgrler[i] = Int32.Parse(drDers["OeId"].ToString());
                alDersler[i] = Int32.Parse(drDers["DersId"].ToString());
            }


            int KomSay;
            for (int i = 0; i < dtDersler.Rows.Count; i++)
            {
                int dersSinif = Int32.Parse(system.GetDataCell("select Sinif from dersler where dersId=" + alDersler[i] + "").ToString());
                DataTable dtKomsular = system.GetDataTable("Select * From Dersler Where (OeId='" + alOgrler[i] + "' or Sinif='" + dersSinif + "') and DonemId='" + DonemId + "'");
                //DataTable dtKomsular = system.GetDataTable("Select * From Dersler Where (OeId=" + alOgrler[i] + " or Sinif='" + dersSinif + "') ");

                KomSay = dtKomsular.Rows.Count;
                DersKomSay[i] = KomSay;

            }
            // dizi sırala
            #region Dersleri Sırala
            int temp, tempal, tempogr, n = dtDersler.Rows.Count;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 1; j < n - i; j++)
                {
                    if (DersKomSay[j] > DersKomSay[j - 1])
                    {
                        temp = DersKomSay[j - 1];
                        tempal = alDersler[j - 1];
                        tempogr = alOgrler[j - 1];

                        DersKomSay[j - 1] = DersKomSay[j];
                        alDersler[j - 1] = alDersler[j];
                        alOgrler[j - 1] = alOgrler[j];

                        DersKomSay[j] = temp;
                        alDersler[j] = tempal;
                        alOgrler[j] = tempogr;
                    }

                }

            }
            #endregion

            #region  Dizi Komsuluk Atamaları
            int[][] dizi = new int[dtDersler.Rows.Count][];
            KomSay = 0;
            for (int i = 0; i < dtDersler.Rows.Count; i++)
            {
                string dersSinif = system.GetDataCell("select Sinif from Dersler Where DersId=" + alDersler[i] + "");
                DataTable dtKomsular = system.GetDataTable("Select * From Dersler Where (OeId='" + alOgrler[i] + "' or Sinif='" + dersSinif + "') and DonemId='" + DonemId + "'");
                KomSay = dtKomsular.Rows.Count;
                dizi[i] = new int[3 + DersKomSay[i]]; // 0- DersId, 1- Komsuluk Sayısı, 2- Rengi

                dizi[i][0] = alDersler[i];
                dizi[i][1] = DersKomSay[i];
                dizi[i][2] = 0;

                for (int j = 3; j < KomSay + 3; j++)
                {
                    DataRow drKomsu = dtKomsular.Rows[j - 3];
                    dizi[i][j] = Int32.Parse(drKomsu["DersId"].ToString());
                }

            }
            #endregion

            // Renk Ataması
            #region Renk Atama
            int renk = 0;
            for (int i = 0; i < n; i++) // n=ders sayısı
            {
                renk++;
                if (dizi[i][2] == 0)
                {
                    dizi[i][2] = renk;
                }
                else
                    dizi[i][2] += renk;
                //lbDersler.Items.Add("-*-*-*-*-*-*-*-*-*");
                // komsuluğa ba. komssusu olan en büyük komsu sayısı olan derse  aynı rengi ver
                for (int j = i; j < n; j++)
                {
                    if (Komsumu(dizi, i, dizi[j][0]) == false)
                    {
                        dizi[j][2] -= 1;
                    }
                    //lbDersler.Items.Add(i + "^^" + dizi[j][0] + "_" + dizi[j][2]);
                }


            }
            #endregion


            # region Renklere Göre Dersleri Sırala
            int[,] dersler = new int[n, 3]; // 0-dersId   1-Ders saati   2- rengi

            for (int ass = 0; ass < n; ass++)
            {
                dersler[ass, 0] = dizi[ass][0];
                dersler[ass, 2] = dizi[ass][2];
                dersler[ass, 1] = Convert.ToInt32(system.GetDataCell("SELECT DersSaati FROM Dersler WHERE  DersId =" + dersler[ass, 0] + ""));
            }
            for (int s = 0; s < n; s++)  // 
            {
                for (int a = s + 1; a < n; a++)
                    if (dersler[s, 2] > dersler[a, 2])
                    {
                        int tp1 = dersler[s, 0];
                        int tp2 = dersler[s, 2];
                        int tp3 = dersler[s, 1];
                        dersler[s, 0] = dersler[a, 0];
                        dersler[s, 2] = dersler[a, 2];
                        dersler[s, 1] = dersler[a, 1];
                        dersler[a, 0] = tp1;
                        dersler[a, 2] = tp2;
                        dersler[a, 1] = tp3;
                    }
                //lbDersler.Items.Add(dersler[s, 0].ToString() + "--->" + dersler[s, 2].ToString());
            }
            //lbDersler.Items.Add(".....................");
            #endregion
            #region DERS PROGRAMI MATRİSİ
            int saatSayisi = system.GetDataTable("select * from GunlukDersler where ODilimi='" + cmbOgrDilimiOGG.Text + "'").Rows.Count;
            int sinifSayisi = system.GetDataTable("select * from FizSiniflar").Rows.Count;
            int günsayisi = system.GetDataTable("select * from DersGunleri where secili='1'").Rows.Count;
            int kontrol = 0; // atanmış ders sayısı
            int atanacak = 0;
            int atlama = 0;
            int[, ,] DersP = new int[günsayisi, saatSayisi, sinifSayisi];
            for (int i = 0; i < günsayisi; i++)
            {
                atlama = 0;
                for (int j = 0; j < saatSayisi; j++)
                {
                    for (int k = 0; k < sinifSayisi; k++)
                    {
                        if (kontrol > 0)
                        {
                            if (dersler[kontrol, 2] != dersler[kontrol - 1, 2] || atlama > 0)
                            {

                                if (DersP[i, 0, 0] == 0)
                                    atlama = 0;
                                else
                                    atlama += 1;
                                if (atlama == 2)
                                    atanacak = dersler[kontrol, 0];
                                if ((Bak(DersP, i, j, dersler[kontrol, 0], sinifSayisi) == false) && (BakOgrSinif(DersP, i, j, dersler[kontrol, 0], sinifSayisi) == false))
                                {
                                    if (DersP[i, j, k] == 0 && (j + dersler[kontrol, 1] <= 7))  // ders atanmılş mı kontrolü
                                    {
                                        for (int t = 0; t < dersler[kontrol, 1]; t++) // 
                                            DersP[i, j + t, k] = dersler[kontrol, 0];
                                        kontrol++;
                                    }
                                }
                                else
                                {
                                    Degis(dersler, kontrol, dersler[kontrol, 2]);
                                    break;
                                    //{
                                    //    k--;
                                    //    if (dersler[kontrol, 0] == atanacak)
                                    //    {
                                    //        MessageBox.Show(k.ToString());
                                    //        MessageBox.Show(dersler[kontrol, 0].ToString());
                                    //        MessageBox.Show(atanacak.ToString());
                                    //        break;
                                    //    }
                                    //}

                                }
                            }
                            else
                            {
                                if (DersP[i, j, k] == 0 && (j + dersler[kontrol, 1] <= 7))  // ders atanmılş mı kontrolü
                                {
                                    for (int t = 0; t < dersler[kontrol, 1]; t++) // 
                                        DersP[i, j + t, k] = dersler[kontrol, 0];
                                    kontrol++;
                                }
                            }
                        }
                        else
                        {
                            if (DersP[i, j, k] == 0 && (j + dersler[kontrol, 1] <= 7))  // ders atanmılş mı kontrolü
                            {
                                for (int t = 0; t < dersler[kontrol, 1]; t++) // 
                                    DersP[i, j + t, k] = dersler[kontrol, 0];
                                kontrol++;
                            }
                        }

                        if (kontrol == n)
                            break;
                    }
                    if (kontrol == n)
                        break;
                }
                if (kontrol == n)
                    break;
            }


            #endregion


            excelRapor2(günsayisi, saatSayisi, sinifSayisi, DersP);
        }//KOMSULUK METODU BİTİR
        public void excelRapor2(int günsayisi, int saatSayisi, int sinifSayisi, int[, ,] DersP)
        {
            int OeId = Int32.Parse(system.GetDataCell("select OeId from OgrElemanlari where OeAdSoyad='" + cmbOgrElemaiOGG.Text + "'").ToString());
            Ms.Application exceluygulama = new Ms.Application();
            Ms.Workbook ekitap = exceluygulama.Workbooks.Add(true);//bitane kitap
            exceluygulama.Visible = true;//sayfa göster
            Ms.Worksheet tablo = (Ms.Worksheet)ekitap.Worksheets[1];//kitaptan bir sayfa türettik
            this.Text = tablo.Name;//birinci SAyf


            DataTable dtderslikler = system.GetDataTable("select * from FizSiniflar");
            for (int i = 0; i < sinifSayisi; i++)
            {
                DataRow drDerslik = dtderslikler.Rows[i];
                tablo.Cells[3, i + 6] = drDerslik["SinifAdi"].ToString();
            }

            int satir = 3, sutun = 4;

            for (int i = 0; i < günsayisi; i++)
            {

                satir++;
                tablo.Cells.RowHeight = 20;

                tablo.Cells.Borders.ColorIndex = 5;

                tablo.Cells[satir, sutun] = system.GetDataCell("select GunAdi from DersGunleri where Gss='" + i + "'");

                for (int j = 0; j < saatSayisi; j++)
                {
                    sutun = 4;
                    sutun++;
                    tablo.Cells[satir, sutun] = system.GetDataCell("select DersBaslamaSaati from GunlukDersler where Dss='" + j + "' and ODilimi='" + cmbOgrDilimiOGG.Text + "'") + "-" + system.GetDataCell("select DersBitisSaati from GunlukDersler where Dss='" + j + "' and ODilimi='" + cmbOgrDilimiOGG.Text + "'");
                    tablo.Cells[satir, sutun - 1] = system.GetDataCell("select GunAdi from DersGunleri where Gss='" + i + "'");
                    for (int k = 0; k < sinifSayisi; k++)
                    {
                        sutun++;
                        try
                        {
                            //tablo.Cells[satir, sutun] = DersP[i, j, k] + " ogr>" + system.GetDataCell("select OeId from Dersler where DersId='" + DersP[i, j, k] + "'");
                            tablo.Cells[satir, sutun] = system.GetDataCell("select DersAdi from Dersler where DersId=" + DersP[i, j, k] + " and OeId='" + OeId + "'");


                        }
                        catch
                        {

                            tablo.Cells[satir, sutun] = 0;

                        }

                    }
                    satir++;

                }
            }
            int cc = saatSayisi * günsayisi + (günsayisi + 2);
            tablo.get_Range("d2", "l2").Merge(false);

            tablo.Cells[2, 4] = cmbDonemDG.Text + "  " + cmbOgrElemaiOGG.Text + "  "+  cmbOgrDilimiOGG.Text+"  Ders Programı";
            Microsoft.Office.Interop.Excel.Range chartRange;
            chartRange = tablo.get_Range("d2", "d2");
            chartRange.Font.Bold = true;
            

            chartRange = tablo.get_Range("d3", "l" + cc); // çerçeve yapılmış
            chartRange.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic);

            

            ekitap.SaveAs("C:\\" + cmbOgrElemaiOGG.Text + "_" + cmbOgrDilimiOGG.Text + "_DersProgramı.xlsx");
            ekitap.Close(true, Missing.Value, Missing.Value);
            exceluygulama.Quit();

        }
        private void btnSınıflaragore_Click(object sender, EventArgs e)
        {
            try
            {
                Komsuluklar3();
            }
            catch
            {
                MessageBox.Show("Döneme ait kayıtlı sınıf bulunamadı!", "Hata!");
            }

        }
        void Komsuluklar3()
        {

            string DonemId = system.GetDataCell("select DonemId From Donemler where DonemAdi='" + cmbDonemSG.Text + "'").ToString();
            DataTable dtDersler = system.GetDataTable("select * from dersler where DonemId='" + DonemId + "'");
            //DataTable dtDersler = system.GetDataTable("select * from dersler ");
            int[] alOgrler = new int[dtDersler.Rows.Count];
            int[] alDersler = new int[dtDersler.Rows.Count];
            int[] DersKomSay = new int[dtDersler.Rows.Count];

            for (int i = 0; i < dtDersler.Rows.Count; i++)
            {
                DataRow drDers = dtDersler.Rows[i];
                alOgrler[i] = Int32.Parse(drDers["OeId"].ToString());
                alDersler[i] = Int32.Parse(drDers["DersId"].ToString());
            }


            int KomSay;
            for (int i = 0; i < dtDersler.Rows.Count; i++)
            {
                int dersSinif = Int32.Parse(system.GetDataCell("select Sinif from dersler where dersId=" + alDersler[i] + "").ToString());
                DataTable dtKomsular = system.GetDataTable("Select * From Dersler Where (OeId='" + alOgrler[i] + "' or Sinif='" + dersSinif + "') and DonemId='" + DonemId + "'");
                //DataTable dtKomsular = system.GetDataTable("Select * From Dersler Where (OeId=" + alOgrler[i] + " or Sinif='" + dersSinif + "') ");

                KomSay = dtKomsular.Rows.Count;
                DersKomSay[i] = KomSay;

            }
            // dizi sırala
            #region Dersleri Sırala
            int temp, tempal, tempogr, n = dtDersler.Rows.Count;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 1; j < n - i; j++)
                {
                    if (DersKomSay[j] > DersKomSay[j - 1])
                    {
                        temp = DersKomSay[j - 1];
                        tempal = alDersler[j - 1];
                        tempogr = alOgrler[j - 1];

                        DersKomSay[j - 1] = DersKomSay[j];
                        alDersler[j - 1] = alDersler[j];
                        alOgrler[j - 1] = alOgrler[j];

                        DersKomSay[j] = temp;
                        alDersler[j] = tempal;
                        alOgrler[j] = tempogr;
                    }

                }

            }
            #endregion

            #region  Dizi Komsuluk Atamaları
            int[][] dizi = new int[dtDersler.Rows.Count][];
            KomSay = 0;
            for (int i = 0; i < dtDersler.Rows.Count; i++)
            {
                string dersSinif = system.GetDataCell("select Sinif from Dersler Where DersId=" + alDersler[i] + "");
                DataTable dtKomsular = system.GetDataTable("Select * From Dersler Where (OeId='" + alOgrler[i] + "' or Sinif='" + dersSinif + "') and DonemId='" + DonemId + "'");
                KomSay = dtKomsular.Rows.Count;
                dizi[i] = new int[3 + DersKomSay[i]]; // 0- DersId, 1- Komsuluk Sayısı, 2- Rengi

                dizi[i][0] = alDersler[i];
                dizi[i][1] = DersKomSay[i];
                dizi[i][2] = 0;

                for (int j = 3; j < KomSay + 3; j++)
                {
                    DataRow drKomsu = dtKomsular.Rows[j - 3];
                    dizi[i][j] = Int32.Parse(drKomsu["DersId"].ToString());
                }

            }
            #endregion

            // Renk Ataması
            #region Renk Atama
            int renk = 0;
            for (int i = 0; i < n; i++) // n=ders sayısı
            {
                renk++;
                if (dizi[i][2] == 0)
                {
                    dizi[i][2] = renk;
                }
                else
                    dizi[i][2] += renk;
                //lbDersler.Items.Add("-*-*-*-*-*-*-*-*-*");
                // komsuluğa ba. komssusu olan en büyük komsu sayısı olan derse  aynı rengi ver
                for (int j = i; j < n; j++)
                {
                    if (Komsumu(dizi, i, dizi[j][0]) == false)
                    {
                        dizi[j][2] -= 1;
                    }
                    //lbDersler.Items.Add(i + "^^" + dizi[j][0] + "_" + dizi[j][2]);
                }


            }
            #endregion


            # region Renklere Göre Dersleri Sırala
            int[,] dersler = new int[n, 3]; // 0-dersId   1-Ders saati   2- rengi

            for (int ass = 0; ass < n; ass++)
            {
                dersler[ass, 0] = dizi[ass][0];
                dersler[ass, 2] = dizi[ass][2];
                dersler[ass, 1] = Convert.ToInt32(system.GetDataCell("SELECT DersSaati FROM Dersler WHERE  DersId =" + dersler[ass, 0] + ""));
            }
            for (int s = 0; s < n; s++)  // 
            {
                for (int a = s + 1; a < n; a++)
                    if (dersler[s, 2] > dersler[a, 2])
                    {
                        int tp1 = dersler[s, 0];
                        int tp2 = dersler[s, 2];
                        int tp3 = dersler[s, 1];
                        dersler[s, 0] = dersler[a, 0];
                        dersler[s, 2] = dersler[a, 2];
                        dersler[s, 1] = dersler[a, 1];
                        dersler[a, 0] = tp1;
                        dersler[a, 2] = tp2;
                        dersler[a, 1] = tp3;
                    }
                //lbDersler.Items.Add(dersler[s, 0].ToString() + "--->" + dersler[s, 2].ToString());
            }
            //lbDersler.Items.Add(".....................");
            #endregion
            #region DERS PROGRAMI MATRİSİ
            int saatSayisi = system.GetDataTable("select * from GunlukDersler where ODilimi='" + cmbOgrDilimiSG.Text + "'").Rows.Count;
            int sinifSayisi = system.GetDataTable("select * from FizSiniflar").Rows.Count;
            int günsayisi = system.GetDataTable("select * from DersGunleri where secili='1'").Rows.Count;
            int kontrol = 0; // atanmış ders sayısı
            int atanacak = 0;
            int atlama = 0;
            int[, ,] DersP = new int[günsayisi, saatSayisi, sinifSayisi];
            for (int i = 0; i < günsayisi; i++)
            {
                atlama = 0;
                for (int j = 0; j < saatSayisi; j++)
                {
                    for (int k = 0; k < sinifSayisi; k++)
                    {
                        if (kontrol > 0)
                        {
                            if (dersler[kontrol, 2] != dersler[kontrol - 1, 2] || atlama > 0)
                            {

                                if (DersP[i, 0, 0] == 0)
                                    atlama = 0;
                                else
                                    atlama += 1;
                                if (atlama == 2)
                                    atanacak = dersler[kontrol, 0];
                                if ((Bak(DersP, i, j, dersler[kontrol, 0], sinifSayisi) == false) && (BakOgrSinif(DersP, i, j, dersler[kontrol, 0], sinifSayisi) == false))
                                {
                                    if (DersP[i, j, k] == 0 && (j + dersler[kontrol, 1] <= 7))  // ders atanmılş mı kontrolü
                                    {
                                        for (int t = 0; t < dersler[kontrol, 1]; t++) // 
                                            DersP[i, j + t, k] = dersler[kontrol, 0];
                                        kontrol++;
                                    }
                                }
                                else
                                {
                                    Degis(dersler, kontrol, dersler[kontrol, 2]);
                                    break;
                                    //{
                                    //    k--;
                                    //    if (dersler[kontrol, 0] == atanacak)
                                    //    {
                                    //        MessageBox.Show(k.ToString());
                                    //        MessageBox.Show(dersler[kontrol, 0].ToString());
                                    //        MessageBox.Show(atanacak.ToString());
                                    //        break;
                                    //    }
                                    //}

                                }
                            }
                            else
                            {
                                if (DersP[i, j, k] == 0 && (j + dersler[kontrol, 1] <= 7))  // ders atanmılş mı kontrolü
                                {
                                    for (int t = 0; t < dersler[kontrol, 1]; t++) // 
                                        DersP[i, j + t, k] = dersler[kontrol, 0];
                                    kontrol++;
                                }
                            }
                        }
                        else
                        {
                            if (DersP[i, j, k] == 0 && (j + dersler[kontrol, 1] <= 7))  // ders atanmılş mı kontrolü
                            {
                                for (int t = 0; t < dersler[kontrol, 1]; t++) // 
                                    DersP[i, j + t, k] = dersler[kontrol, 0];
                                kontrol++;
                            }
                        }

                        if (kontrol == n)
                            break;
                    }
                    if (kontrol == n)
                        break;
                }
                if (kontrol == n)
                    break;
            }


            #endregion


            excelRapor3(günsayisi, saatSayisi, sinifSayisi, DersP);
        }//KOMSULUK METODU BİTİR
        public void excelRapor3(int günsayisi, int saatSayisi, int sinifSayisi, int[, ,] DersP) 
        {
            //int Sinif = Int32.Parse(system.GetDataCell("select OgrSinifAdi from OgrElemanlari where ='" + cmbOgrElemaiOGG.Text + "'").ToString());
            Ms.Application exceluygulama = new Ms.Application();
            Ms.Workbook ekitap = exceluygulama.Workbooks.Add(true);//bitane kitap
            exceluygulama.Visible = true;//sayfa göster
            Ms.Worksheet tablo = (Ms.Worksheet)ekitap.Worksheets[1];//kitaptan bir sayfa türettik
            this.Text = tablo.Name;//birinci SAyf

            Microsoft.Office.Interop.Excel.Range chartRange;
            DataTable dtderslikler = system.GetDataTable("select * from FizSiniflar");

            for (int i = 0; i < sinifSayisi; i++)
            {
                DataRow drDerslik = dtderslikler.Rows[i];
                tablo.Cells[3, i + 6] = drDerslik["SinifAdi"].ToString();
            }

            int satir = 3, sutun = 4;

            for (int i = 0; i < günsayisi; i++)
            {

                satir++;
                tablo.Cells.RowHeight = 20;

                tablo.Cells.Borders.ColorIndex = 5;

                tablo.Cells[satir, sutun] = system.GetDataCell("select GunAdi from DersGunleri where Gss='" + i + "'");

                for (int j = 0; j < saatSayisi; j++)
                {
                    sutun = 4;
                    sutun++;
                    tablo.Cells[satir, sutun] = system.GetDataCell("select DersBaslamaSaati from GunlukDersler where Dss='" + j + "' and ODilimi='" + cmbOgrDilimiSG.Text + "'") + "-" + system.GetDataCell("select DersBitisSaati from GunlukDersler where Dss='" + j + "' and ODilimi='" + cmbOgrDilimiSG.Text + "'");
                    tablo.Cells[satir, sutun - 1] = system.GetDataCell("select GunAdi from DersGunleri where Gss='" + i + "'");
                    for (int k = 0; k < sinifSayisi; k++)
                    {
                        sutun++;
                        try
                        {
                            //tablo.Cells[satir, sutun] = DersP[i, j, k] + " ogr>" + system.GetDataCell("select OeId from Dersler where DersId='" + DersP[i, j, k] + "'");
                            tablo.Cells[satir, sutun] = system.GetDataCell("select DersAdi from Dersler where DersId=" + DersP[i, j, k] + " and Sinif ='" + cmbSinifSG.Text + "'");


                        }
                        catch
                        {

                            tablo.Cells[satir, sutun] = 0;

                        }

                    }
                    satir++;

                }
            }

            int cc = saatSayisi * günsayisi + (günsayisi + 2);
            tablo.get_Range("d2", "l2").Merge(false);

            tablo.Cells[2, 4] = cmbDonemSG.Text + "  " + cmbSinifSG.Text + " .Sınıf " + cmbOgrDilimiSG.Text + "  Ders Programı";

            chartRange = tablo.get_Range("d2", "d2");
            chartRange.Font.Bold = true;


            chartRange = tablo.get_Range("d3", "l" + cc); // çerçeve yapılmış
            chartRange.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic);


            ekitap.SaveAs("C:\\" + cmbSinifSG.Text + "_Sinif_" + cmbOgrDilimiSG.Text + "_DersProgramı.xlsx");
            ekitap.Close(true, Missing.Value, Missing.Value);
            exceluygulama.Quit();


        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}
