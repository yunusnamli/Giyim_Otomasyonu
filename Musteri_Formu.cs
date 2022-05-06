using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giyim_Otomasyonu
{
    public partial class Musteri_Formu : Form
    {
        public Form Admin { get; set; }
        public string Who { get; set; }

        public Musteri_Formu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin musteri_formu = new Admin();
           musteri_formu.Musteri_Formu = this;
            musteri_formu.Show();
            this.Hide();

        }

        private void Musteri_Formu_Load(object sender, EventArgs e)
        {
         
            if (Who == "Admin")
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }

        int i = 0;
        private void button_Musteri_Ekle_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Adi = textBox_Musteri_Adi.Text;
            musteri.Soyadi = textBox_Musteri_Soyadi.Text;
            musteri.Musteri_Sicil_No =Convert.ToInt16(textBox_Musteri_Sicil_No.Text);

            MusteriDb musteridb = new MusteriDb();
            musteridb.Ekle(musteri);

            try
            {
                if (timer_Musteri.Enabled==false)
                {
                    timer_Musteri.Enabled = true;
                    label_Musteri_Mesaj.Visible = true;
                    label_Musteri_Mesaj.Text = "Müşteri Ekleme Başarılı";
                    i = 0;
                    textBox_Musteri_Adi.Text = "";
                    textBox_Musteri_Soyadi.Text = "";
                    textBox_Musteri_Sicil_No.Text = "";
                

                }


            }
            catch (Exception)
            {
                timer_Musteri.Enabled = true;
                label_Musteri_Mesaj.Visible = true;
                label_Musteri_Mesaj.Text = "Müşteri Ekleme Başarısız";
                i = 0;
        
            }



        }

        private void timer_Musteri_Tick(object sender, EventArgs e)
        {
            i++;
            if (i==2)
            {
                label_Musteri_Mesaj.Visible = false;
                timer_Musteri.Enabled = false;
            }
        }

        private void button_Musteri_Guncelle_Click(object sender, EventArgs e)
        {
                  
        }

        private void button_Musteri_Sil_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Adi = textBox_Musteri_Adi.Text;

            MusteriDb musteridb = new MusteriDb();
            musteridb.Sil(musteri);

            try
            {
                if (timer_Musteri.Enabled == false)
                {
                    timer_Musteri.Enabled = true;
                    label_Musteri_Mesaj.Visible = true;
                    label_Musteri_Mesaj.Text = "Müşteri Silme Başarılı";
                    i = 0;
                    textBox_Musteri_Adi.Text = "";



                }
            }

            catch (Exception)
            {
                timer_Musteri.Enabled = true;
                label_Musteri_Mesaj.Visible = true;
                label_Musteri_Mesaj.Text = "Müşteri Silme Başarısız";
                i = 0;

            }


        }

        private void button_Musteri_Ara_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Musteri_Sicil_No =Convert.ToInt16( textBox_Musteri_Sicil_No.Text);

            MusteriDb musteridb = new MusteriDb();
            musteridb.Getir(musteri);

            if (musteri.Musteri_Id!=0)
            {
                label_Musteri_Id.Text = musteri.Musteri_Id.ToString();
                textBox_Musteri_Adi.Text = musteri.Adi;
                textBox_Musteri_Soyadi.Text = musteri.Soyadi;
                textBox_Musteri_Sicil_No.Text = musteri.Musteri_Sicil_No.ToString();

                if (timer_Musteri.Enabled==false)
                {
                    timer_Musteri.Enabled = true;
                    label_Musteri_Mesaj.Visible = true;
                    label_Musteri_Mesaj.Text = "Müşteri Kaydı Buylundu";
                    i = 0;
                }



            }
            else
            {
                timer_Musteri.Enabled = true;
                label_Musteri_Mesaj.Visible = true;
                label_Musteri_Mesaj.Text = "Müşteri Kaydı Bulunamadı";
                i = 0;
            }


        }
    }
}
