namespace D_POY
{
    partial class AnaSayfa
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
            this.btnDersliklereGore = new System.Windows.Forms.Button();
            this.cmbDonemDG = new System.Windows.Forms.ComboBox();
            this.cmbOgrDilimiDG = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbOgrElemaiOGG = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOgretimGorevlGore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDonemOGG = new System.Windows.Forms.ComboBox();
            this.cmbOgrDilimiOGG = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSinifSG = new System.Windows.Forms.ComboBox();
            this.btnSınıflaragore = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDonemSG = new System.Windows.Forms.ComboBox();
            this.cmbOgrDilimiSG = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDersliklereGore
            // 
            this.btnDersliklereGore.Location = new System.Drawing.Point(111, 138);
            this.btnDersliklereGore.Name = "btnDersliklereGore";
            this.btnDersliklereGore.Size = new System.Drawing.Size(121, 23);
            this.btnDersliklereGore.TabIndex = 1;
            this.btnDersliklereGore.Text = "Çıktı Al";
            this.btnDersliklereGore.UseVisualStyleBackColor = true;
            this.btnDersliklereGore.Click += new System.EventHandler(this.btnDersliklereGore_Click);
            // 
            // cmbDonemDG
            // 
            this.cmbDonemDG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonemDG.FormattingEnabled = true;
            this.cmbDonemDG.Location = new System.Drawing.Point(102, 47);
            this.cmbDonemDG.Name = "cmbDonemDG";
            this.cmbDonemDG.Size = new System.Drawing.Size(170, 21);
            this.cmbDonemDG.TabIndex = 2;
            // 
            // cmbOgrDilimiDG
            // 
            this.cmbOgrDilimiDG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgrDilimiDG.FormattingEnabled = true;
            this.cmbOgrDilimiDG.Location = new System.Drawing.Point(102, 90);
            this.cmbOgrDilimiDG.Name = "cmbOgrDilimiDG";
            this.cmbOgrDilimiDG.Size = new System.Drawing.Size(170, 21);
            this.cmbOgrDilimiDG.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dönem :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnDersliklereGore);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbDonemDG);
            this.groupBox1.Controls.Add(this.cmbOgrDilimiDG);
            this.groupBox1.Location = new System.Drawing.Point(29, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 222);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dersliklere Göre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Öğretim Dilimi :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbOgrElemaiOGG);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnOgretimGorevlGore);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbDonemOGG);
            this.groupBox2.Controls.Add(this.cmbOgrDilimiOGG);
            this.groupBox2.Location = new System.Drawing.Point(390, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 222);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğretim Görevlilerine Göre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Öğretim Elemanı :";
            // 
            // cmbOgrElemaiOGG
            // 
            this.cmbOgrElemaiOGG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgrElemaiOGG.FormattingEnabled = true;
            this.cmbOgrElemaiOGG.Location = new System.Drawing.Point(107, 125);
            this.cmbOgrElemaiOGG.Name = "cmbOgrElemaiOGG";
            this.cmbOgrElemaiOGG.Size = new System.Drawing.Size(170, 21);
            this.cmbOgrElemaiOGG.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Öğretim Dilimi :";
            // 
            // btnOgretimGorevlGore
            // 
            this.btnOgretimGorevlGore.Location = new System.Drawing.Point(107, 180);
            this.btnOgretimGorevlGore.Name = "btnOgretimGorevlGore";
            this.btnOgretimGorevlGore.Size = new System.Drawing.Size(121, 23);
            this.btnOgretimGorevlGore.TabIndex = 1;
            this.btnOgretimGorevlGore.Text = "Çıktı Al";
            this.btnOgretimGorevlGore.UseVisualStyleBackColor = true;
            this.btnOgretimGorevlGore.Click += new System.EventHandler(this.btnOgretimGorevlGore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dönem :";
            // 
            // cmbDonemOGG
            // 
            this.cmbDonemOGG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonemOGG.FormattingEnabled = true;
            this.cmbDonemOGG.Location = new System.Drawing.Point(107, 44);
            this.cmbDonemOGG.Name = "cmbDonemOGG";
            this.cmbDonemOGG.Size = new System.Drawing.Size(170, 21);
            this.cmbDonemOGG.TabIndex = 2;
            // 
            // cmbOgrDilimiOGG
            // 
            this.cmbOgrDilimiOGG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgrDilimiOGG.FormattingEnabled = true;
            this.cmbOgrDilimiOGG.Location = new System.Drawing.Point(107, 85);
            this.cmbOgrDilimiOGG.Name = "cmbOgrDilimiOGG";
            this.cmbOgrDilimiOGG.Size = new System.Drawing.Size(170, 21);
            this.cmbOgrDilimiOGG.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbSinifSG);
            this.groupBox3.Controls.Add(this.btnSınıflaragore);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbDonemSG);
            this.groupBox3.Controls.Add(this.cmbOgrDilimiSG);
            this.groupBox3.Location = new System.Drawing.Point(202, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 222);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sınıflara Göre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sınıf :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Öğretim Dilimi :";
            // 
            // cmbSinifSG
            // 
            this.cmbSinifSG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSinifSG.FormattingEnabled = true;
            this.cmbSinifSG.Location = new System.Drawing.Point(94, 124);
            this.cmbSinifSG.Name = "cmbSinifSG";
            this.cmbSinifSG.Size = new System.Drawing.Size(170, 21);
            this.cmbSinifSG.TabIndex = 10;
            // 
            // btnSınıflaragore
            // 
            this.btnSınıflaragore.Location = new System.Drawing.Point(94, 179);
            this.btnSınıflaragore.Name = "btnSınıflaragore";
            this.btnSınıflaragore.Size = new System.Drawing.Size(121, 23);
            this.btnSınıflaragore.TabIndex = 1;
            this.btnSınıflaragore.Text = "Çıktı Al";
            this.btnSınıflaragore.UseVisualStyleBackColor = true;
            this.btnSınıflaragore.Click += new System.EventHandler(this.btnSınıflaragore_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dönem :";
            // 
            // cmbDonemSG
            // 
            this.cmbDonemSG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonemSG.FormattingEnabled = true;
            this.cmbDonemSG.Location = new System.Drawing.Point(94, 44);
            this.cmbDonemSG.Name = "cmbDonemSG";
            this.cmbDonemSG.Size = new System.Drawing.Size(170, 21);
            this.cmbDonemSG.TabIndex = 2;
            // 
            // cmbOgrDilimiSG
            // 
            this.cmbOgrDilimiSG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgrDilimiSG.FormattingEnabled = true;
            this.cmbOgrDilimiSG.Location = new System.Drawing.Point(94, 85);
            this.cmbOgrDilimiSG.Name = "cmbOgrDilimiSG";
            this.cmbOgrDilimiSG.Size = new System.Drawing.Size(170, 21);
            this.cmbOgrDilimiSG.TabIndex = 3;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 502);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDersliklereGore;
        private System.Windows.Forms.ComboBox cmbDonemDG;
        private System.Windows.Forms.ComboBox cmbOgrDilimiDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOgretimGorevlGore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDonemOGG;
        private System.Windows.Forms.ComboBox cmbOgrDilimiOGG;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSınıflaragore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDonemSG;
        private System.Windows.Forms.ComboBox cmbOgrDilimiSG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbOgrElemaiOGG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSinifSG;
    }
}