namespace D_POY
{
    partial class GunVeSaatler
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbGunler = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSilinecekGunId = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nmDersSuresi = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDersBaslamaZamanı = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbOgretimDilimi = new System.Windows.Forms.ComboBox();
            this.nmDersSayisi = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmTenefusSuresi = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.lbSaatler = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDersSuresi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDersSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTenefusSuresi)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(683, 506);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 286;
            this.lineShape1.X2 = 286;
            this.lineShape1.Y1 = 26;
            this.lineShape1.Y2 = 384;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbGunler);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Günleri";
            // 
            // cmbGunler
            // 
            this.cmbGunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGunler.FormattingEnabled = true;
            this.cmbGunler.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşembe",
            "Cuma",
            "Cumartesi",
            "Pazar"});
            this.cmbGunler.Location = new System.Drawing.Point(7, 44);
            this.cmbGunler.Name = "cmbGunler";
            this.cmbGunler.Size = new System.Drawing.Size(143, 21);
            this.cmbGunler.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(160, 182);
            this.dataGridView1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kayıtlı Günler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSilinecekGunId);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(13, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 67);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gün Sil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gün Kodu :";
            // 
            // txtSilinecekGunId
            // 
            this.txtSilinecekGunId.Location = new System.Drawing.Point(82, 30);
            this.txtSilinecekGunId.Name = "txtSilinecekGunId";
            this.txtSilinecekGunId.Size = new System.Drawing.Size(34, 20);
            this.txtSilinecekGunId.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.nmDersSuresi);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtDersBaslamaZamanı);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cmbOgretimDilimi);
            this.groupBox3.Controls.Add(this.nmDersSayisi);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.nmTenefusSuresi);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(300, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 289);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ders Zaman İşlemleri";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(238, 42);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 23);
            this.button6.TabIndex = 29;
            this.button6.Text = "Eski Kaydı Göster";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(238, 81);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 23);
            this.button5.TabIndex = 28;
            this.button5.Text = "Eski Kaydı Sil";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Öğretim Dilimi :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "dk.";
            // 
            // nmDersSuresi
            // 
            this.nmDersSuresi.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmDersSuresi.Location = new System.Drawing.Point(111, 120);
            this.nmDersSuresi.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmDersSuresi.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nmDersSuresi.Name = "nmDersSuresi";
            this.nmDersSuresi.ReadOnly = true;
            this.nmDersSuresi.Size = new System.Drawing.Size(43, 20);
            this.nmDersSuresi.TabIndex = 25;
            this.nmDersSuresi.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Ders Süresi :";
            // 
            // txtDersBaslamaZamanı
            // 
            this.txtDersBaslamaZamanı.Location = new System.Drawing.Point(120, 184);
            this.txtDersBaslamaZamanı.Mask = "00:00";
            this.txtDersBaslamaZamanı.Name = "txtDersBaslamaZamanı";
            this.txtDersBaslamaZamanı.Size = new System.Drawing.Size(34, 20);
            this.txtDersBaslamaZamanı.TabIndex = 5;
            this.txtDersBaslamaZamanı.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 23;
            // 
            // cmbOgretimDilimi
            // 
            this.cmbOgretimDilimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgretimDilimi.FormattingEnabled = true;
            this.cmbOgretimDilimi.Location = new System.Drawing.Point(111, 44);
            this.cmbOgretimDilimi.Name = "cmbOgretimDilimi";
            this.cmbOgretimDilimi.Size = new System.Drawing.Size(121, 21);
            this.cmbOgretimDilimi.TabIndex = 22;
            this.cmbOgretimDilimi.SelectedIndexChanged += new System.EventHandler(this.cmbOgretimDilimi_SelectedIndexChanged);
            // 
            // nmDersSayisi
            // 
            this.nmDersSayisi.Location = new System.Drawing.Point(111, 216);
            this.nmDersSayisi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmDersSayisi.Name = "nmDersSayisi";
            this.nmDersSayisi.ReadOnly = true;
            this.nmDersSayisi.Size = new System.Drawing.Size(43, 20);
            this.nmDersSayisi.TabIndex = 21;
            this.nmDersSayisi.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Günlük Ders Sayısı  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ders Başlama Saati  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tenefüs Süresi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "dk.";
            // 
            // nmTenefusSuresi
            // 
            this.nmTenefusSuresi.Location = new System.Drawing.Point(111, 152);
            this.nmTenefusSuresi.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmTenefusSuresi.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmTenefusSuresi.Name = "nmTenefusSuresi";
            this.nmTenefusSuresi.ReadOnly = true;
            this.nmTenefusSuresi.Size = new System.Drawing.Size(43, 20);
            this.nmTenefusSuresi.TabIndex = 16;
            this.nmTenefusSuresi.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Görüntüle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbSaatler
            // 
            this.lbSaatler.FormattingEnabled = true;
            this.lbSaatler.Location = new System.Drawing.Point(300, 346);
            this.lbSaatler.Name = "lbSaatler";
            this.lbSaatler.Size = new System.Drawing.Size(182, 147);
            this.lbSaatler.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(538, 470);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "ONAYLA";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(297, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Günlük Ders Saatleri Önizlemesi   :";
            // 
            // GunVeSaatler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 506);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbSaatler);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "GunVeSaatler";
            this.Text = "Gün ve Saatler";
            this.Load += new System.EventHandler(this.GunVeSaatler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDersSuresi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDersSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTenefusSuresi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbGunler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSilinecekGunId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmTenefusSuresi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmDersSayisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbOgretimDilimi;
        private System.Windows.Forms.MaskedTextBox txtDersBaslamaZamanı;
        private System.Windows.Forms.ListBox lbSaatler;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmDersSuresi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}