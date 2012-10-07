namespace D_POY
{
    partial class OgrElemanlari
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVerdigiDersler = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupEkle = new System.Windows.Forms.GroupBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.lblUnvan = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.txtUnvan = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GroupEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 437);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretim Eleman Listesi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAdSoyad2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblVerdigiDersler);
            this.groupBox3.Location = new System.Drawing.Point(7, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(488, 189);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hakkında";
            // 
            // lblAdSoyad2
            // 
            this.lblAdSoyad2.AutoSize = true;
            this.lblAdSoyad2.Location = new System.Drawing.Point(120, 35);
            this.lblAdSoyad2.Name = "lblAdSoyad2";
            this.lblAdSoyad2.Size = new System.Drawing.Size(16, 13);
            this.lblAdSoyad2.TabIndex = 3;
            this.lblAdSoyad2.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Verdiği Dersler :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad- Soyad       :";
            // 
            // lblVerdigiDersler
            // 
            this.lblVerdigiDersler.AutoSize = true;
            this.lblVerdigiDersler.Location = new System.Drawing.Point(120, 68);
            this.lblVerdigiDersler.Name = "lblVerdigiDersler";
            this.lblVerdigiDersler.Size = new System.Drawing.Size(16, 13);
            this.lblVerdigiDersler.TabIndex = 0;
            this.lblVerdigiDersler.Text = "---";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(488, 193);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GroupEkle
            // 
            this.GroupEkle.Controls.Add(this.lblTel);
            this.GroupEkle.Controls.Add(this.lblOdaNo);
            this.GroupEkle.Controls.Add(this.lblUnvan);
            this.GroupEkle.Controls.Add(this.lblAdSoyad);
            this.GroupEkle.Controls.Add(this.btnEkle);
            this.GroupEkle.Controls.Add(this.txtTel);
            this.GroupEkle.Controls.Add(this.txtOdaNo);
            this.GroupEkle.Controls.Add(this.txtUnvan);
            this.GroupEkle.Controls.Add(this.txtAdSoyad);
            this.GroupEkle.Location = new System.Drawing.Point(521, 24);
            this.GroupEkle.Name = "GroupEkle";
            this.GroupEkle.Size = new System.Drawing.Size(251, 202);
            this.GroupEkle.TabIndex = 1;
            this.GroupEkle.TabStop = false;
            this.GroupEkle.Text = "Ekle";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(6, 119);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(49, 13);
            this.lblTel.TabIndex = 8;
            this.lblTel.Text = "Telefon :";
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.Location = new System.Drawing.Point(6, 93);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(50, 13);
            this.lblOdaNo.TabIndex = 7;
            this.lblOdaNo.Text = "Oda No :";
            // 
            // lblUnvan
            // 
            this.lblUnvan.AutoSize = true;
            this.lblUnvan.Location = new System.Drawing.Point(6, 67);
            this.lblUnvan.Name = "lblUnvan";
            this.lblUnvan.Size = new System.Drawing.Size(45, 13);
            this.lblUnvan.TabIndex = 6;
            this.lblUnvan.Text = "Ünvan :";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(6, 41);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(59, 13);
            this.lblAdSoyad.TabIndex = 5;
            this.lblAdSoyad.Text = "Ad-Soyad :";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(170, 155);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Kaydet";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(114, 116);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(131, 20);
            this.txtTel.TabIndex = 3;
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Location = new System.Drawing.Point(114, 90);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(131, 20);
            this.txtOdaNo.TabIndex = 2;
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(114, 64);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(131, 20);
            this.txtUnvan.TabIndex = 1;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(114, 38);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(131, 20);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Listeyi Yenile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OgrElemanlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GroupEkle);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "OgrElemanlari";
            this.Text = "Öğretim Elemanları";
            this.Load += new System.EventHandler(this.OgrElemanlari_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GroupEkle.ResumeLayout(false);
            this.GroupEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox GroupEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.TextBox txtUnvan;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Windows.Forms.Label lblUnvan;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblVerdigiDersler;
        private System.Windows.Forms.Label lblAdSoyad2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}