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
    public partial class Kullanici_Ayarlari : Form
    {
        public Form Admin { get; set; }
        public string Who { get; set; }
        public Kullanici_Ayarlari()
        {
            InitializeComponent();
        }

        private void label_Kullanici_Adi_Click(object sender, EventArgs e)
        {

        }

        private void Kullanici_Ayarlari_Load(object sender, EventArgs e)
        {
            GorevDoldur();
            
            if (Who == "Admin")
            {
                button_Geri_Donus.Visible = true;
            }
            else
            {
                button_Geri_Donus.Visible = false;
            }
        }

        private void GorevDoldur()
        {
            List<string> liste = new List<string>();
            KullaniciDb kullanicidb = new KullaniciDb();
            liste = kullanicidb.ListeDoldur();

            foreach (var item in liste)
            {
                comboBox_Kullanici_Gorev_Listesi.Items.Add(item);
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Gorevi = comboBox_Kullanici_Gorev_Listesi.SelectedItem.ToString();
            KullaniciDb kullanicidb = new KullaniciDb();

            kullanicidb.Getir(kullanici);
            textBox_Kullanici_Adi.Text = kullanici.Kullanici_Adi.ToString();
            textBox_Kullanici_Sifresi.Text = kullanici.Sifre.ToString();
            textBox_Kullanici_Gorevi.Text = kullanici.Gorevi.ToString();
            label_Kullanici_Ayarlari_Id.Text = kullanici.Kullanici_Id.ToString();
                
         }

        private void button3_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Kullanici_Adi = textBox_Kullanici_Adi.Text;


            KullaniciDb kullanicidb = new KullaniciDb();
            kullanicidb.Sil(kullanici);


            try
            {

                if (timer_Kullanici_Ayarlari_Mesaj.Enabled == false)
                {
                    timer_Kullanici_Ayarlari_Mesaj.Enabled = true;
                    label_Kullanici_Ayarlari_Mesaj.Visible = true;
                    label_Kullanici_Ayarlari_Mesaj.Text = "Kullanıcı Silme Başarılı";
                    i = 0;
                    textBox_Kullanici_Adi.Text = "";


                }

            }
            catch (Exception)
            {
                timer_Kullanici_Ayarlari_Mesaj.Enabled = true;
                label_Kullanici_Ayarlari_Mesaj.Visible = true;
                label_Kullanici_Ayarlari_Mesaj.Text = "Kullanıcı Silme Başarısız";
                i = 0;

            }
            comboBox_Kullanici_Gorev_Listesi.Items.Clear();
            GorevDoldur();
        }

  

        private void button_Geri_Donus_Click(object sender, EventArgs e)
        {
            
            Admin adm = new Admin();
            adm.Kullanici_Ayarlari = this;
            adm.Show();
            this.Hide();


        }
        int i = 0;
        private void button_Kullanici_Ekle_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Kullanici_Adi = textBox_Kullanici_Adi.Text;
            kullanici.Sifre = textBox_Kullanici_Sifresi.Text;
            kullanici.Gorevi = textBox_Kullanici_Gorevi.Text;
            
            KullaniciDb kullanicidb = new KullaniciDb();
            kullanicidb.Ekle(kullanici);


            try
            {

                if (timer_Kullanici_Ayarlari_Mesaj.Enabled==false)
                {
                    timer_Kullanici_Ayarlari_Mesaj.Enabled = true;
                    label_Kullanici_Ayarlari_Mesaj.Visible = true;
                    label_Kullanici_Ayarlari_Mesaj.Text = "Kullanıcı Ekleme Başarılı";
                    i = 0;
                    textBox_Kullanici_Adi.Text = "";
                    textBox_Kullanici_Sifresi.Text = "";
                    textBox_Kullanici_Gorevi.Text = "";

                }

            }
            catch (Exception)
            {
                timer_Kullanici_Ayarlari_Mesaj.Enabled = true;
                label_Kullanici_Ayarlari_Mesaj.Visible = true;
                label_Kullanici_Ayarlari_Mesaj.Text = "Kullanıcı Ekleme Başarısız";
                i = 0;
                
            }
            comboBox_Kullanici_Gorev_Listesi.Items.Clear();
            GorevDoldur();

        }

        private void timer_Kullanici_Ayarlari_Mesaj_Tick(object sender, EventArgs e)
        {
            i++;
            if (i==2)
            {
                label_Kullanici_Ayarlari_Mesaj.Visible = false;
                timer_Kullanici_Ayarlari_Mesaj.Enabled = false;
               
            }
        }

        private void button_Kullanici_Guncelle_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Kullanici_Id =Convert.ToInt32( label_Kullanici_Ayarlari_Id.Text);
            kullanici.Kullanici_Adi = textBox_Kullanici_Adi.Text;
            kullanici.Sifre = textBox_Kullanici_Sifresi.Text;
            kullanici.Gorevi = textBox_Kullanici_Gorevi.Text;

            KullaniciDb kullanicidb = new KullaniciDb();
            kullanicidb.Guncelle(kullanici);


            try
            {
             
                if (timer_Kullanici_Ayarlari_Mesaj.Enabled==false)
                {

                   timer_Kullanici_Ayarlari_Mesaj.Enabled = true;
                    label_Kullanici_Ayarlari_Mesaj.Visible = true;
                    label_Kullanici_Ayarlari_Mesaj.Text = "Kullanıcı Güncelleme Başarılı";
                    i = 0;
                    label_Kullanici_Ayarlari_Id.Text = "";
                    textBox_Kullanici_Adi.Text = "";
                    textBox_Kullanici_Sifresi.Text = "";
                    textBox_Kullanici_Gorevi.Text = "";               
       }
                

            }

            catch (Exception)
            {
                timer_Kullanici_Ayarlari_Mesaj.Enabled = true;
                label_Kullanici_Ayarlari_Mesaj.Visible = true;
                label_Kullanici_Ayarlari_Mesaj.Text = "Kullanıcı Güncelleme Başarısız";


            }
            comboBox_Kullanici_Gorev_Listesi.Items.Clear();
            GorevDoldur();
        


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Kullanici_Adi = textBox_Kullanici_Adi.Text;

            KullaniciDb kullanicidb = new KullaniciDb();
            kullanicidb.GetirAd(kullanici);

            if (kullanici.Kullanici_Id!=0)
            {
                label_Kullanici_Ayarlari_Id.Text = kullanici.Kullanici_Id.ToString();
                textBox_Kullanici_Adi.Text = kullanici.Kullanici_Adi;
                textBox_Kullanici_Sifresi.Text = kullanici.Sifre;
                textBox_Kullanici_Gorevi.Text = kullanici.Gorevi;
                comboBox_Kullanici_Gorev_Listesi.SelectedItem = kullanici.Gorevi;

                if (timer_Kullanici_Ayarlari_Mesaj.Enabled==false)
                {

                    timer_Kullanici_Ayarlari_Mesaj.Enabled = true;
                    label_Kullanici_Ayarlari_Mesaj.Visible = true;
                    label_Kullanici_Ayarlari_Mesaj.Text = "Kullanıcı Kaydı Bulundu";
                    i = 0;
                }


            }
            else
            {

                timer_Kullanici_Ayarlari_Mesaj.Enabled = true;
                label_Kullanici_Ayarlari_Mesaj.Visible = true;
                label_Kullanici_Ayarlari_Mesaj.Text = "Kullanıcı Kaydı Bulunamadı";
                i = 0;
            }







        }
    }
}
