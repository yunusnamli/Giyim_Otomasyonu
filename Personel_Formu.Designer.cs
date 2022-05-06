namespace Giyim_Otomasyonu
{
    partial class Personel_Formu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel_Formu));
            this.label_Personel_Adi = new System.Windows.Forms.Label();
            this.label_Personel_Soyadi = new System.Windows.Forms.Label();
            this.label_Personel_Yasi = new System.Windows.Forms.Label();
            this.label_Personel_Gorev_Listesi = new System.Windows.Forms.Label();
            this.textBox_Personel_Adi = new System.Windows.Forms.TextBox();
            this.textBox_Personel_Soyadi = new System.Windows.Forms.TextBox();
            this.textBox_Personel_Yasi = new System.Windows.Forms.TextBox();
            this.comboBox_Personel_Gorev_Listesi = new System.Windows.Forms.ComboBox();
            this.button_Personel_Ekle = new System.Windows.Forms.Button();
            this.button_Personel_Guncelle = new System.Windows.Forms.Button();
            this.button_Personel_Sil = new System.Windows.Forms.Button();
            this.button_Geri_Donus = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_Personel_Mesaj = new System.Windows.Forms.Label();
            this.label_Personel_Id = new System.Windows.Forms.Label();
            this.timer_Personel = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_Kullanici_Gorevi = new System.Windows.Forms.Label();
            this.textBox_Personel_Gorevi = new System.Windows.Forms.TextBox();
            this.button_Personel_Arama = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Personel_Adi
            // 
            this.label_Personel_Adi.AutoSize = true;
            this.label_Personel_Adi.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Personel_Adi.Location = new System.Drawing.Point(12, 27);
            this.label_Personel_Adi.Name = "label_Personel_Adi";
            this.label_Personel_Adi.Size = new System.Drawing.Size(50, 25);
            this.label_Personel_Adi.TabIndex = 0;
            this.label_Personel_Adi.Text = "Adı :";
            // 
            // label_Personel_Soyadi
            // 
            this.label_Personel_Soyadi.AutoSize = true;
            this.label_Personel_Soyadi.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Personel_Soyadi.Location = new System.Drawing.Point(183, 27);
            this.label_Personel_Soyadi.Name = "label_Personel_Soyadi";
            this.label_Personel_Soyadi.Size = new System.Drawing.Size(82, 25);
            this.label_Personel_Soyadi.TabIndex = 1;
            this.label_Personel_Soyadi.Text = "Soyadi :";
            this.label_Personel_Soyadi.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_Personel_Yasi
            // 
            this.label_Personel_Yasi.AutoSize = true;
            this.label_Personel_Yasi.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Personel_Yasi.Location = new System.Drawing.Point(390, 27);
            this.label_Personel_Yasi.Name = "label_Personel_Yasi";
            this.label_Personel_Yasi.Size = new System.Drawing.Size(60, 25);
            this.label_Personel_Yasi.TabIndex = 2;
            this.label_Personel_Yasi.Text = "Yaşı :";
            // 
            // label_Personel_Gorev_Listesi
            // 
            this.label_Personel_Gorev_Listesi.AutoSize = true;
            this.label_Personel_Gorev_Listesi.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Personel_Gorev_Listesi.Location = new System.Drawing.Point(788, 28);
            this.label_Personel_Gorev_Listesi.Name = "label_Personel_Gorev_Listesi";
            this.label_Personel_Gorev_Listesi.Size = new System.Drawing.Size(79, 25);
            this.label_Personel_Gorev_Listesi.TabIndex = 3;
            this.label_Personel_Gorev_Listesi.Text = "Görevi :";
            // 
            // textBox_Personel_Adi
            // 
            this.textBox_Personel_Adi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Personel_Adi.Location = new System.Drawing.Point(68, 26);
            this.textBox_Personel_Adi.Name = "textBox_Personel_Adi";
            this.textBox_Personel_Adi.Size = new System.Drawing.Size(100, 30);
            this.textBox_Personel_Adi.TabIndex = 4;
            // 
            // textBox_Personel_Soyadi
            // 
            this.textBox_Personel_Soyadi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Personel_Soyadi.Location = new System.Drawing.Point(271, 26);
            this.textBox_Personel_Soyadi.Name = "textBox_Personel_Soyadi";
            this.textBox_Personel_Soyadi.Size = new System.Drawing.Size(100, 30);
            this.textBox_Personel_Soyadi.TabIndex = 5;
            // 
            // textBox_Personel_Yasi
            // 
            this.textBox_Personel_Yasi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Personel_Yasi.Location = new System.Drawing.Point(456, 27);
            this.textBox_Personel_Yasi.Name = "textBox_Personel_Yasi";
            this.textBox_Personel_Yasi.Size = new System.Drawing.Size(100, 30);
            this.textBox_Personel_Yasi.TabIndex = 6;
            // 
            // comboBox_Personel_Gorev_Listesi
            // 
            this.comboBox_Personel_Gorev_Listesi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_Personel_Gorev_Listesi.FormattingEnabled = true;
            this.comboBox_Personel_Gorev_Listesi.Location = new System.Drawing.Point(873, 25);
            this.comboBox_Personel_Gorev_Listesi.Name = "comboBox_Personel_Gorev_Listesi";
            this.comboBox_Personel_Gorev_Listesi.Size = new System.Drawing.Size(121, 31);
            this.comboBox_Personel_Gorev_Listesi.TabIndex = 7;
            this.comboBox_Personel_Gorev_Listesi.SelectedIndexChanged += new System.EventHandler(this.comboBox_Personel_Gorev_Listesi_SelectedIndexChanged);
            // 
            // button_Personel_Ekle
            // 
            this.button_Personel_Ekle.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Personel_Ekle.Image = ((System.Drawing.Image)(resources.GetObject("button_Personel_Ekle.Image")));
            this.button_Personel_Ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Personel_Ekle.Location = new System.Drawing.Point(165, 107);
            this.button_Personel_Ekle.Name = "button_Personel_Ekle";
            this.button_Personel_Ekle.Size = new System.Drawing.Size(133, 76);
            this.button_Personel_Ekle.TabIndex = 8;
            this.button_Personel_Ekle.Text = "Ekle";
            this.button_Personel_Ekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Personel_Ekle.UseVisualStyleBackColor = true;
            this.button_Personel_Ekle.Click += new System.EventHandler(this.button_Personel_Ekle_Click);
            // 
            // button_Personel_Guncelle
            // 
            this.button_Personel_Guncelle.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Personel_Guncelle.Image = ((System.Drawing.Image)(resources.GetObject("button_Personel_Guncelle.Image")));
            this.button_Personel_Guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Personel_Guncelle.Location = new System.Drawing.Point(327, 107);
            this.button_Personel_Guncelle.Name = "button_Personel_Guncelle";
            this.button_Personel_Guncelle.Size = new System.Drawing.Size(158, 76);
            this.button_Personel_Guncelle.TabIndex = 9;
            this.button_Personel_Guncelle.Text = "Güncelle";
            this.button_Personel_Guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Personel_Guncelle.UseVisualStyleBackColor = true;
            this.button_Personel_Guncelle.Click += new System.EventHandler(this.button_Personel_Guncelle_Click);
            // 
            // button_Personel_Sil
            // 
            this.button_Personel_Sil.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Personel_Sil.Image = ((System.Drawing.Image)(resources.GetObject("button_Personel_Sil.Image")));
            this.button_Personel_Sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Personel_Sil.Location = new System.Drawing.Point(513, 107);
            this.button_Personel_Sil.Name = "button_Personel_Sil";
            this.button_Personel_Sil.Size = new System.Drawing.Size(115, 76);
            this.button_Personel_Sil.TabIndex = 10;
            this.button_Personel_Sil.Text = "Sil";
            this.button_Personel_Sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Personel_Sil.UseVisualStyleBackColor = true;
            this.button_Personel_Sil.Click += new System.EventHandler(this.button_Personel_Sil_Click);
            // 
            // button_Geri_Donus
            // 
            this.button_Geri_Donus.Image = ((System.Drawing.Image)(resources.GetObject("button_Geri_Donus.Image")));
            this.button_Geri_Donus.Location = new System.Drawing.Point(897, 315);
            this.button_Geri_Donus.Name = "button_Geri_Donus";
            this.button_Geri_Donus.Size = new System.Drawing.Size(112, 103);
            this.button_Geri_Donus.TabIndex = 12;
            this.button_Geri_Donus.UseVisualStyleBackColor = true;
            this.button_Geri_Donus.Click += new System.EventHandler(this.button_Geri_Donus_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(888, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label_Personel_Mesaj
            // 
            this.label_Personel_Mesaj.AutoSize = true;
            this.label_Personel_Mesaj.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Personel_Mesaj.Location = new System.Drawing.Point(860, 224);
            this.label_Personel_Mesaj.Name = "label_Personel_Mesaj";
            this.label_Personel_Mesaj.Size = new System.Drawing.Size(51, 18);
            this.label_Personel_Mesaj.TabIndex = 15;
            this.label_Personel_Mesaj.Text = "Mesaj :";
            this.label_Personel_Mesaj.Visible = false;
            // 
            // label_Personel_Id
            // 
            this.label_Personel_Id.AutoSize = true;
            this.label_Personel_Id.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Personel_Id.Location = new System.Drawing.Point(885, 254);
            this.label_Personel_Id.Name = "label_Personel_Id";
            this.label_Personel_Id.Size = new System.Drawing.Size(26, 18);
            this.label_Personel_Id.TabIndex = 16;
            this.label_Personel_Id.Text = "Id :";
            this.label_Personel_Id.Visible = false;
            // 
            // timer_Personel
            // 
            this.timer_Personel.Interval = 1000;
            this.timer_Personel.Tick += new System.EventHandler(this.timer_Personel_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 204);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(803, 214);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // label_Kullanici_Gorevi
            // 
            this.label_Kullanici_Gorevi.AutoSize = true;
            this.label_Kullanici_Gorevi.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Kullanici_Gorevi.Location = new System.Drawing.Point(581, 27);
            this.label_Kullanici_Gorevi.Name = "label_Kullanici_Gorevi";
            this.label_Kullanici_Gorevi.Size = new System.Drawing.Size(79, 25);
            this.label_Kullanici_Gorevi.TabIndex = 18;
            this.label_Kullanici_Gorevi.Text = "Görevi :";
            // 
            // textBox_Personel_Gorevi
            // 
            this.textBox_Personel_Gorevi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Personel_Gorevi.Location = new System.Drawing.Point(666, 26);
            this.textBox_Personel_Gorevi.Name = "textBox_Personel_Gorevi";
            this.textBox_Personel_Gorevi.Size = new System.Drawing.Size(100, 30);
            this.textBox_Personel_Gorevi.TabIndex = 19;
            // 
            // button_Personel_Arama
            // 
            this.button_Personel_Arama.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Personel_Arama.Image = ((System.Drawing.Image)(resources.GetObject("button_Personel_Arama.Image")));
            this.button_Personel_Arama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Personel_Arama.Location = new System.Drawing.Point(655, 107);
            this.button_Personel_Arama.Name = "button_Personel_Arama";
            this.button_Personel_Arama.Size = new System.Drawing.Size(201, 76);
            this.button_Personel_Arama.TabIndex = 20;
            this.button_Personel_Arama.Text = " Ada Göre Ara";
            this.button_Personel_Arama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Personel_Arama.UseVisualStyleBackColor = true;
            this.button_Personel_Arama.Click += new System.EventHandler(this.button_Personel_Arama_Click);
            // 
            // Personel_Formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 430);
            this.Controls.Add(this.button_Personel_Arama);
            this.Controls.Add(this.textBox_Personel_Gorevi);
            this.Controls.Add(this.label_Kullanici_Gorevi);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label_Personel_Id);
            this.Controls.Add(this.label_Personel_Mesaj);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Geri_Donus);
            this.Controls.Add(this.button_Personel_Sil);
            this.Controls.Add(this.button_Personel_Guncelle);
            this.Controls.Add(this.button_Personel_Ekle);
            this.Controls.Add(this.comboBox_Personel_Gorev_Listesi);
            this.Controls.Add(this.textBox_Personel_Yasi);
            this.Controls.Add(this.textBox_Personel_Soyadi);
            this.Controls.Add(this.textBox_Personel_Adi);
            this.Controls.Add(this.label_Personel_Gorev_Listesi);
            this.Controls.Add(this.label_Personel_Yasi);
            this.Controls.Add(this.label_Personel_Soyadi);
            this.Controls.Add(this.label_Personel_Adi);
            this.Name = "Personel_Formu";
            this.Text = "Personel_Formu";
            this.Load += new System.EventHandler(this.Personel_Formu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Personel_Adi;
        private System.Windows.Forms.Label label_Personel_Soyadi;
        private System.Windows.Forms.Label label_Personel_Yasi;
        private System.Windows.Forms.Label label_Personel_Gorev_Listesi;
        private System.Windows.Forms.TextBox textBox_Personel_Adi;
        private System.Windows.Forms.TextBox textBox_Personel_Soyadi;
        private System.Windows.Forms.TextBox textBox_Personel_Yasi;
        private System.Windows.Forms.ComboBox comboBox_Personel_Gorev_Listesi;
        private System.Windows.Forms.Button button_Personel_Ekle;
        private System.Windows.Forms.Button button_Personel_Guncelle;
        private System.Windows.Forms.Button button_Personel_Sil;
        private System.Windows.Forms.Button button_Geri_Donus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_Personel_Mesaj;
        private System.Windows.Forms.Label label_Personel_Id;
        private System.Windows.Forms.Timer timer_Personel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_Kullanici_Gorevi;
        private System.Windows.Forms.TextBox textBox_Personel_Gorevi;
        private System.Windows.Forms.Button button_Personel_Arama;
    }
}