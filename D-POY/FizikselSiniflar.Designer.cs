namespace D_POY
{
    partial class FizikselSiniflar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtSinAciklama = new System.Windows.Forms.TextBox();
            this.txtSinifKapst = new System.Windows.Forms.TextBox();
            this.txtSinifYeri = new System.Windows.Forms.TextBox();
            this.txtSinifAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSinifId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtSinAciklamaG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSinKapG = new System.Windows.Forms.TextBox();
            this.txtSinYeriG = new System.Windows.Forms.TextBox();
            this.txtSinAdiG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSinKoduSil = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtSinAciklama);
            this.groupBox1.Controls.Add(this.txtSinifKapst);
            this.groupBox1.Controls.Add(this.txtSinifYeri);
            this.groupBox1.Controls.Add(this.txtSinifAdi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(511, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sınıf Ekle";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(178, 237);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtSinAciklama
            // 
            this.txtSinAciklama.Location = new System.Drawing.Point(96, 108);
            this.txtSinAciklama.Multiline = true;
            this.txtSinAciklama.Name = "txtSinAciklama";
            this.txtSinAciklama.Size = new System.Drawing.Size(157, 105);
            this.txtSinAciklama.TabIndex = 7;
            // 
            // txtSinifKapst
            // 
            this.txtSinifKapst.Location = new System.Drawing.Point(96, 82);
            this.txtSinifKapst.Name = "txtSinifKapst";
            this.txtSinifKapst.Size = new System.Drawing.Size(157, 20);
            this.txtSinifKapst.TabIndex = 6;
            // 
            // txtSinifYeri
            // 
            this.txtSinifYeri.Location = new System.Drawing.Point(96, 56);
            this.txtSinifYeri.Name = "txtSinifYeri";
            this.txtSinifYeri.Size = new System.Drawing.Size(157, 20);
            this.txtSinifYeri.TabIndex = 5;
            // 
            // txtSinifAdi
            // 
            this.txtSinifAdi.Location = new System.Drawing.Point(96, 30);
            this.txtSinifAdi.Name = "txtSinifAdi";
            this.txtSinifAdi.Size = new System.Drawing.Size(157, 20);
            this.txtSinifAdi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Açıklama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kapasite :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sınıf Yeri (Katı) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sınıf Adı :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSinifId);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.txtSinAciklamaG);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSinKapG);
            this.groupBox2.Controls.Add(this.txtSinYeriG);
            this.groupBox2.Controls.Add(this.txtSinAdiG);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 281);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınıf Güncelle";
            // 
            // txtSinifId
            // 
            this.txtSinifId.Location = new System.Drawing.Point(96, 28);
            this.txtSinifId.Name = "txtSinifId";
            this.txtSinifId.Size = new System.Drawing.Size(157, 20);
            this.txtSinifId.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Sınıf Kodu :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(300, 252);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Kaydet";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtSinAciklamaG
            // 
            this.txtSinAciklamaG.Location = new System.Drawing.Point(96, 163);
            this.txtSinAciklamaG.Multiline = true;
            this.txtSinAciklamaG.Name = "txtSinAciklamaG";
            this.txtSinAciklamaG.Size = new System.Drawing.Size(279, 80);
            this.txtSinAciklamaG.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Açıklama :";
            // 
            // txtSinKapG
            // 
            this.txtSinKapG.Location = new System.Drawing.Point(96, 128);
            this.txtSinKapG.Name = "txtSinKapG";
            this.txtSinKapG.Size = new System.Drawing.Size(157, 20);
            this.txtSinKapG.TabIndex = 12;
            // 
            // txtSinYeriG
            // 
            this.txtSinYeriG.Location = new System.Drawing.Point(96, 102);
            this.txtSinYeriG.Name = "txtSinYeriG";
            this.txtSinYeriG.Size = new System.Drawing.Size(157, 20);
            this.txtSinYeriG.TabIndex = 11;
            // 
            // txtSinAdiG
            // 
            this.txtSinAdiG.Location = new System.Drawing.Point(96, 76);
            this.txtSinAdiG.Name = "txtSinAdiG";
            this.txtSinAdiG.Size = new System.Drawing.Size(157, 20);
            this.txtSinAdiG.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kapasite :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sınıf Yeri (Katı) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sınıf Adı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(493, 231);
            this.dataGridView1.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSinKoduSil);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(511, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 90);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sınıf Sil";
            // 
            // txtSinKoduSil
            // 
            this.txtSinKoduSil.Location = new System.Drawing.Point(96, 30);
            this.txtSinKoduSil.Name = "txtSinKoduSil";
            this.txtSinKoduSil.Size = new System.Drawing.Size(157, 20);
            this.txtSinKoduSil.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Sınıf Kodu :";
            // 
            // FizikselSiniflar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 542);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FizikselSiniflar";
            this.Text = "Fiziksel Sınıflar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSinifKapst;
        private System.Windows.Forms.TextBox txtSinifYeri;
        private System.Windows.Forms.TextBox txtSinifAdi;
        private System.Windows.Forms.TextBox txtSinAciklama;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtSinAciklamaG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSinKapG;
        private System.Windows.Forms.TextBox txtSinYeriG;
        private System.Windows.Forms.TextBox txtSinAdiG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSinifId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSinKoduSil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
    }
}