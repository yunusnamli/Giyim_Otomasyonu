namespace Giyim_Otomasyonu
{
    partial class Kullanici_Ayarlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanici_Ayarlari));
            this.label_Kullanici_Adi = new System.Windows.Forms.Label();
            this.label_Kullanici_Sifresi = new System.Windows.Forms.Label();
            this.label_Kullanici_Gorev_Listesi = new System.Windows.Forms.Label();
            this.textBox_Kullanici_Adi = new System.Windows.Forms.TextBox();
            this.textBox_Kullanici_Sifresi = new System.Windows.Forms.TextBox();
            this.comboBox_Kullanici_Gorev_Listesi = new System.Windows.Forms.ComboBox();
            this.button_Kullanici_Ekle = new System.Windows.Forms.Button();
            this.button_Kullanici_Guncelle = new System.Windows.Forms.Button();
            this.button_Kullanici_Sil = new System.Windows.Forms.Button();
            this.label_Kullanici_Ayarlari_Mesaj = new System.Windows.Forms.Label();
            this.label_Kullanici_Ayarlari_Id = new System.Windows.Forms.Label();
            this.button_Geri_Donus = new System.Windows.Forms.Button();
            this.timer_Kullanici_Ayarlari_Mesaj = new System.Windows.Forms.Timer(this.components);
            this.label_Kullanici_Gorevi = new System.Windows.Forms.Label();
            this.textBox_Kullanici_Gorevi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Kullanici_Adi
            // 
            this.label_Kullanici_Adi.AutoSize = true;
            this.label_Kullanici_Adi.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Kullanici_Adi.Location = new System.Drawing.Point(136, 21);
            this.label_Kullanici_Adi.Name = "label_Kullanici_Adi";
            this.label_Kullanici_Adi.Size = new System.Drawing.Size(125, 25);
            this.label_Kullanici_Adi.TabIndex = 0;
            this.label_Kullanici_Adi.Text = "Kullanıcı Adı :";
            this.label_Kullanici_Adi.Click += new System.EventHandler(this.label_Kullanici_Adi_Click);
            // 
            // label_Kullanici_Sifresi
            // 
            this.label_Kullanici_Sifresi.AutoSize = true;
            this.label_Kullanici_Sifresi.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Kullanici_Sifresi.Location = new System.Drawing.Point(199, 64);
            this.label_Kullanici_Sifresi.Name = "label_Kullanici_Sifresi";
            this.label_Kullanici_Sifresi.Size = new System.Drawing.Size(61, 25);
            this.label_Kullanici_Sifresi.TabIndex = 1;
            this.label_Kullanici_Sifresi.Text = "Şifre :";
            // 
            // label_Kullanici_Gorev_Listesi
            // 
            this.label_Kullanici_Gorev_Listesi.AutoSize = true;
            this.label_Kullanici_Gorev_Listesi.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Kullanici_Gorev_Listesi.Location = new System.Drawing.Point(181, 147);
            this.label_Kullanici_Gorev_Listesi.Name = "label_Kullanici_Gorev_Listesi";
            this.label_Kullanici_Gorev_Listesi.Size = new System.Drawing.Size(79, 25);
            this.label_Kullanici_Gorev_Listesi.TabIndex = 2;
            this.label_Kullanici_Gorev_Listesi.Text = "Görevi :";
            // 
            // textBox_Kullanici_Adi
            // 
            this.textBox_Kullanici_Adi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Kullanici_Adi.Location = new System.Drawing.Point(266, 20);
            this.textBox_Kullanici_Adi.Name = "textBox_Kullanici_Adi";
            this.textBox_Kullanici_Adi.Size = new System.Drawing.Size(134, 30);
            this.textBox_Kullanici_Adi.TabIndex = 3;
            // 
            // textBox_Kullanici_Sifresi
            // 
            this.textBox_Kullanici_Sifresi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Kullanici_Sifresi.Location = new System.Drawing.Point(266, 64);
            this.textBox_Kullanici_Sifresi.Name = "textBox_Kullanici_Sifresi";
            this.textBox_Kullanici_Sifresi.Size = new System.Drawing.Size(134, 30);
            this.textBox_Kullanici_Sifresi.TabIndex = 4;
            this.textBox_Kullanici_Sifresi.UseSystemPasswordChar = true;
            // 
            // comboBox_Kullanici_Gorev_Listesi
            // 
            this.comboBox_Kullanici_Gorev_Listesi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_Kullanici_Gorev_Listesi.FormattingEnabled = true;
            this.comboBox_Kullanici_Gorev_Listesi.Location = new System.Drawing.Point(266, 146);
            this.comboBox_Kullanici_Gorev_Listesi.Name = "comboBox_Kullanici_Gorev_Listesi";
            this.comboBox_Kullanici_Gorev_Listesi.Size = new System.Drawing.Size(134, 31);
            this.comboBox_Kullanici_Gorev_Listesi.TabIndex = 5;
            this.comboBox_Kullanici_Gorev_Listesi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_Kullanici_Ekle
            // 
            this.button_Kullanici_Ekle.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Kullanici_Ekle.Image = ((System.Drawing.Image)(resources.GetObject("button_Kullanici_Ekle.Image")));
            this.button_Kullanici_Ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Kullanici_Ekle.Location = new System.Drawing.Point(12, 206);
            this.button_Kullanici_Ekle.Name = "button_Kullanici_Ekle";
            this.button_Kullanici_Ekle.Size = new System.Drawing.Size(118, 71);
            this.button_Kullanici_Ekle.TabIndex = 6;
            this.button_Kullanici_Ekle.Text = "Ekle";
            this.button_Kullanici_Ekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Kullanici_Ekle.UseVisualStyleBackColor = true;
            this.button_Kullanici_Ekle.Click += new System.EventHandler(this.button_Kullanici_Ekle_Click);
            // 
            // button_Kullanici_Guncelle
            // 
            this.button_Kullanici_Guncelle.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Kullanici_Guncelle.Image = ((System.Drawing.Image)(resources.GetObject("button_Kullanici_Guncelle.Image")));
            this.button_Kullanici_Guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Kullanici_Guncelle.Location = new System.Drawing.Point(141, 206);
            this.button_Kullanici_Guncelle.Name = "button_Kullanici_Guncelle";
            this.button_Kullanici_Guncelle.Size = new System.Drawing.Size(144, 71);
            this.button_Kullanici_Guncelle.TabIndex = 7;
            this.button_Kullanici_Guncelle.Text = "Güncelle";
            this.button_Kullanici_Guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Kullanici_Guncelle.UseVisualStyleBackColor = true;
            this.button_Kullanici_Guncelle.Click += new System.EventHandler(this.button_Kullanici_Guncelle_Click);
            // 
            // button_Kullanici_Sil
            // 
            this.button_Kullanici_Sil.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Kullanici_Sil.Image = ((System.Drawing.Image)(resources.GetObject("button_Kullanici_Sil.Image")));
            this.button_Kullanici_Sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Kullanici_Sil.Location = new System.Drawing.Point(291, 206);
            this.button_Kullanici_Sil.Name = "button_Kullanici_Sil";
            this.button_Kullanici_Sil.Size = new System.Drawing.Size(109, 71);
            this.button_Kullanici_Sil.TabIndex = 8;
            this.button_Kullanici_Sil.Text = "Sil";
            this.button_Kullanici_Sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Kullanici_Sil.UseVisualStyleBackColor = true;
            this.button_Kullanici_Sil.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_Kullanici_Ayarlari_Mesaj
            // 
            this.label_Kullanici_Ayarlari_Mesaj.AutoSize = true;
            this.label_Kullanici_Ayarlari_Mesaj.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Kullanici_Ayarlari_Mesaj.Location = new System.Drawing.Point(462, 34);
            this.label_Kullanici_Ayarlari_Mesaj.Name = "label_Kullanici_Ayarlari_Mesaj";
            this.label_Kullanici_Ayarlari_Mesaj.Size = new System.Drawing.Size(51, 18);
            this.label_Kullanici_Ayarlari_Mesaj.TabIndex = 10;
            this.label_Kullanici_Ayarlari_Mesaj.Text = "Mesaj :";
            this.label_Kullanici_Ayarlari_Mesaj.Visible = false;
            // 
            // label_Kullanici_Ayarlari_Id
            // 
            this.label_Kullanici_Ayarlari_Id.AutoSize = true;
            this.label_Kullanici_Ayarlari_Id.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Kullanici_Ayarlari_Id.Location = new System.Drawing.Point(487, 64);
            this.label_Kullanici_Ayarlari_Id.Name = "label_Kullanici_Ayarlari_Id";
            this.label_Kullanici_Ayarlari_Id.Size = new System.Drawing.Size(26, 18);
            this.label_Kullanici_Ayarlari_Id.TabIndex = 11;
            this.label_Kullanici_Ayarlari_Id.Text = "Id :";
            this.label_Kullanici_Ayarlari_Id.Visible = false;
            // 
            // button_Geri_Donus
            // 
            this.button_Geri_Donus.Image = ((System.Drawing.Image)(resources.GetObject("button_Geri_Donus.Image")));
            this.button_Geri_Donus.Location = new System.Drawing.Point(240, 293);
            this.button_Geri_Donus.Name = "button_Geri_Donus";
            this.button_Geri_Donus.Size = new System.Drawing.Size(115, 102);
            this.button_Geri_Donus.TabIndex = 12;
            this.button_Geri_Donus.UseVisualStyleBackColor = true;
            this.button_Geri_Donus.Click += new System.EventHandler(this.button_Geri_Donus_Click);
            // 
            // timer_Kullanici_Ayarlari_Mesaj
            // 
            this.timer_Kullanici_Ayarlari_Mesaj.Interval = 1000;
            this.timer_Kullanici_Ayarlari_Mesaj.Tick += new System.EventHandler(this.timer_Kullanici_Ayarlari_Mesaj_Tick);
            // 
            // label_Kullanici_Gorevi
            // 
            this.label_Kullanici_Gorevi.AutoSize = true;
            this.label_Kullanici_Gorevi.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Kullanici_Gorevi.Location = new System.Drawing.Point(181, 106);
            this.label_Kullanici_Gorevi.Name = "label_Kullanici_Gorevi";
            this.label_Kullanici_Gorevi.Size = new System.Drawing.Size(79, 25);
            this.label_Kullanici_Gorevi.TabIndex = 13;
            this.label_Kullanici_Gorevi.Text = "Görevi :";
            // 
            // textBox_Kullanici_Gorevi
            // 
            this.textBox_Kullanici_Gorevi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Kullanici_Gorevi.Location = new System.Drawing.Point(266, 105);
            this.textBox_Kullanici_Gorevi.Name = "textBox_Kullanici_Gorevi";
            this.textBox_Kullanici_Gorevi.Size = new System.Drawing.Size(134, 30);
            this.textBox_Kullanici_Gorevi.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(406, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 71);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ada Göre Arama ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Kullanici_Ayarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 407);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Kullanici_Gorevi);
            this.Controls.Add(this.label_Kullanici_Gorevi);
            this.Controls.Add(this.button_Geri_Donus);
            this.Controls.Add(this.label_Kullanici_Ayarlari_Id);
            this.Controls.Add(this.label_Kullanici_Ayarlari_Mesaj);
            this.Controls.Add(this.button_Kullanici_Sil);
            this.Controls.Add(this.button_Kullanici_Guncelle);
            this.Controls.Add(this.button_Kullanici_Ekle);
            this.Controls.Add(this.comboBox_Kullanici_Gorev_Listesi);
            this.Controls.Add(this.textBox_Kullanici_Sifresi);
            this.Controls.Add(this.textBox_Kullanici_Adi);
            this.Controls.Add(this.label_Kullanici_Gorev_Listesi);
            this.Controls.Add(this.label_Kullanici_Sifresi);
            this.Controls.Add(this.label_Kullanici_Adi);
            this.Name = "Kullanici_Ayarlari";
            this.Text = "Kullanici_Ayarlari";
            this.Load += new System.EventHandler(this.Kullanici_Ayarlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Kullanici_Adi;
        private System.Windows.Forms.Label label_Kullanici_Sifresi;
        private System.Windows.Forms.Label label_Kullanici_Gorev_Listesi;
        private System.Windows.Forms.TextBox textBox_Kullanici_Adi;
        private System.Windows.Forms.TextBox textBox_Kullanici_Sifresi;
        private System.Windows.Forms.ComboBox comboBox_Kullanici_Gorev_Listesi;
        private System.Windows.Forms.Button button_Kullanici_Ekle;
        private System.Windows.Forms.Button button_Kullanici_Guncelle;
        private System.Windows.Forms.Button button_Kullanici_Sil;
        private System.Windows.Forms.Label label_Kullanici_Ayarlari_Mesaj;
        private System.Windows.Forms.Label label_Kullanici_Ayarlari_Id;
        private System.Windows.Forms.Button button_Geri_Donus;
        private System.Windows.Forms.Timer timer_Kullanici_Ayarlari_Mesaj;
        private System.Windows.Forms.Label label_Kullanici_Gorevi;
        private System.Windows.Forms.TextBox textBox_Kullanici_Gorevi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}