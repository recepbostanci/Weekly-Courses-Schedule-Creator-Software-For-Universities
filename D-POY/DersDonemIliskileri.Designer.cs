namespace D_POY
{
    partial class DersDonemIliskileri
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
            this.lbSiniflar = new System.Windows.Forms.ListBox();
            this.cmbDonemler = new System.Windows.Forms.ComboBox();
            this.lbSecilmisler = new System.Windows.Forms.ListBox();
            this.lbSecilmemisler = new System.Windows.Forms.ListBox();
            this.btnCikart = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNot = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSiniflar
            // 
            this.lbSiniflar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSiniflar.FormattingEnabled = true;
            this.lbSiniflar.Location = new System.Drawing.Point(93, 197);
            this.lbSiniflar.Name = "lbSiniflar";
            this.lbSiniflar.Size = new System.Drawing.Size(172, 199);
            this.lbSiniflar.TabIndex = 0;
            this.lbSiniflar.SelectedIndexChanged += new System.EventHandler(this.lbSiniflar_SelectedIndexChanged);
            // 
            // cmbDonemler
            // 
            this.cmbDonemler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonemler.FormattingEnabled = true;
            this.cmbDonemler.Location = new System.Drawing.Point(93, 126);
            this.cmbDonemler.Name = "cmbDonemler";
            this.cmbDonemler.Size = new System.Drawing.Size(172, 21);
            this.cmbDonemler.TabIndex = 1;
            this.cmbDonemler.SelectedIndexChanged += new System.EventHandler(this.cmbDonemler_SelectedIndexChanged);
            // 
            // lbSecilmisler
            // 
            this.lbSecilmisler.FormattingEnabled = true;
            this.lbSecilmisler.Location = new System.Drawing.Point(372, 54);
            this.lbSecilmisler.Name = "lbSecilmisler";
            this.lbSecilmisler.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSecilmisler.Size = new System.Drawing.Size(232, 199);
            this.lbSecilmisler.TabIndex = 2;
            // 
            // lbSecilmemisler
            // 
            this.lbSecilmemisler.FormattingEnabled = true;
            this.lbSecilmemisler.Location = new System.Drawing.Point(372, 305);
            this.lbSecilmemisler.Name = "lbSecilmemisler";
            this.lbSecilmemisler.Size = new System.Drawing.Size(232, 199);
            this.lbSecilmemisler.TabIndex = 3;
            this.lbSecilmemisler.SelectedIndexChanged += new System.EventHandler(this.lbSecilmemisler_SelectedIndexChanged);
            // 
            // btnCikart
            // 
            this.btnCikart.Location = new System.Drawing.Point(610, 54);
            this.btnCikart.Name = "btnCikart";
            this.btnCikart.Size = new System.Drawing.Size(75, 23);
            this.btnCikart.TabIndex = 4;
            this.btnCikart.Text = "ÇIKART";
            this.btnCikart.UseVisualStyleBackColor = true;
            this.btnCikart.Click += new System.EventHandler(this.btnCikart_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(610, 305);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(369, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SEÇİLMEMİŞ DERSLER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(369, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "SEÇİLMİŞ DERSLER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(90, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "SINIFLAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(27, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "DÖNEM :";
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNot.Location = new System.Drawing.Point(27, 9);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(13, 13);
            this.lblNot.TabIndex = 10;
            this.lblNot.Text = "--";
            this.lblNot.Click += new System.EventHandler(this.lblNot_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Tüm dönemlerin ders listesini temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DersDonemIliskileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnCikart);
            this.Controls.Add(this.lbSecilmemisler);
            this.Controls.Add(this.lbSecilmisler);
            this.Controls.Add(this.cmbDonemler);
            this.Controls.Add(this.lbSiniflar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DersDonemIliskileri";
            this.Text = "Ders-Dönem İlişkileri";
            this.Load += new System.EventHandler(this.DersDonemIliskileri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSiniflar;
        private System.Windows.Forms.ComboBox cmbDonemler;
        private System.Windows.Forms.ListBox lbSecilmisler;
        private System.Windows.Forms.ListBox lbSecilmemisler;
        private System.Windows.Forms.Button btnCikart;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNot;
        private System.Windows.Forms.Button button1;
    }
}