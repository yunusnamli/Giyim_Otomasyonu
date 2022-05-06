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
    public partial class Urun_Formu : Form
    {
        public Form Admin { get; set; }
        public string Who { get; set; }
        public Urun_Formu()
        {
            InitializeComponent();
        }

        private void Urun_Formu_Load(object sender, EventArgs e)
        {
            TuruDoldur();           
            if (Who == "Admin")
            {
                button_Geri_Donus.Visible = true;
            }
            else
            {
                button_Geri_Donus.Visible = false;
            }
        }

        private void TuruDoldur()
        {
            List<string> liste = new List<string>();
            UrunDb urundb = new UrunDb();
            liste = urundb.TuruGetir();

            foreach (var item in liste)
            {
                comboBox_Urun_Turu_Listesi.Items.Add(item);
            }



        }

        private void button_Geri_Donus_Click(object sender, EventArgs e)
        {
            Admin urun_Formu = new Admin();
            urun_Formu.Urun_Formu = this;
            urun_Formu.Show();
            this.Hide();

        }
        int i = 0;

        private void button_Urun_Ekle_Click(object sender, EventArgs e)
        {

            Urun urun = new Urun();
            urun.Urun_Adi = textBox_Urun_Adi.Text;
            urun.Turu = textBox_Urun_Turu.Text;
            urun.Adedi = Convert.ToInt16(textBox_Urun_Adedi.Text);
            urun.Fiyati = Convert.ToInt16(textBox_Urun_Fiyati.Text);
            urun.Rengi = textBox_Urun_Rengi.Text;
            urun.Bedeni = textBox_Urun_Bedeni.Text;

            UrunDb urundb = new UrunDb();
            urundb.Ekle(urun);

            try
            {
                if (timer_Urun.Enabled == false)
                {
                    timer_Urun.Enabled = true;
                    label_Urun_Mesaj.Visible = true;
                    label_Urun_Mesaj.Text = "Ürün Ekleme Başarılı";
                    i = 0;
                    textBox_Urun_Adi.Text = "";
                    textBox_Urun_Turu.Text = "";
                    textBox_Urun_Adedi.Text = "";
                    textBox_Urun_Fiyati.Text = "";
                    textBox_Urun_Rengi.Text = "";
                    textBox_Urun_Bedeni.Text = "";

                }



            }
            catch (Exception)
            {
                timer_Urun.Enabled = true;
                label_Urun_Mesaj.Visible = true;
                label_Urun_Mesaj.Text = "Ürün Ekleme Başarısız";
           
            }
            comboBox_Urun_Turu_Listesi.Items.Clear();
            TuruDoldur();


        }

        private void timer_Urun_Tick(object sender, EventArgs e)
        {
            i++;
            if (i==2)
            {
                timer_Urun.Enabled = false;
                label_Urun_Mesaj.Visible = false;
                label_Urun_Mesaj.Enabled = false;

            }
        }

        private void comboBox_Urun_Turu_Listesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.Turu = comboBox_Urun_Turu_Listesi.SelectedItem.ToString();

            UrunDb urundb = new UrunDb();
            urundb.TuruGetir(urun);
            textBox_Urun_Adi.Text = urun.Urun_Adi.ToString() ;
            textBox_Urun_Turu.Text = urun.Turu.ToString();
            textBox_Urun_Adedi.Text = urun.Adedi.ToString();
            textBox_Urun_Fiyati.Text = urun.Fiyati.ToString();
            textBox_Urun_Rengi.Text = urun.Rengi.ToString();
            textBox_Urun_Bedeni.Text = urun.Bedeni.ToString();
            label_Urun_Id.Text = urun.Urun_Id.ToString();



        }

        private void button_Urun_Guncelle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.Urun_Id = Convert.ToInt16(label_Urun_Id.Text);
            urun.Urun_Adi = textBox_Urun_Adi.Text;
            urun.Turu = textBox_Urun_Turu.Text;
            urun.Adedi = Convert.ToInt16(textBox_Urun_Adedi.Text);
            urun.Fiyati = Convert.ToInt16(textBox_Urun_Fiyati.Text);
            urun.Rengi = textBox_Urun_Rengi.Text;
            urun.Bedeni = textBox_Urun_Bedeni.Text;

            UrunDb urundb = new UrunDb();
            urundb.Guncelle(urun);

            try
            {
                if (timer_Urun.Enabled==false)
                {
                    timer_Urun.Enabled = true;
                    label_Urun_Mesaj.Visible = true;
                    label_Urun_Mesaj.Text = "Ürün Güncelleme Başarılı";
                    i = 0;
                    textBox_Urun_Adi.Text = "";
                    textBox_Urun_Turu.Text = "";
                    textBox_Urun_Adedi.Text = "";
                    textBox_Urun_Fiyati.Text = "";
                    textBox_Urun_Rengi.Text = "";
                    textBox_Urun_Bedeni.Text = "";
           }


            }

            catch (Exception)
            {
                timer_Urun.Enabled = true;
                label_Urun_Mesaj.Visible = true;
                label_Urun_Mesaj.Text = "Ürün Güncelleme Başarısız";

                
            }
            comboBox_Urun_Turu_Listesi.Items.Clear();
            TuruDoldur();

        }

        private void button_Urun_Arama_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.Urun_Adi = textBox_Urun_Adi.Text;

            UrunDb urundb = new UrunDb();
            urundb.Getir(urun);

            if (urun.Urun_Id!=0)
            {
                label_Urun_Id.Text = urun.Urun_Id.ToString();
                textBox_Urun_Adi.Text = urun.Urun_Adi;                
                textBox_Urun_Adedi.Text = urun.Adedi.ToString();
                textBox_Urun_Fiyati.Text = urun.Adedi.ToString();
                textBox_Urun_Rengi.Text = urun.Rengi;
                textBox_Urun_Bedeni.Text = urun.Bedeni;                
                textBox_Urun_Turu.Text = urun.Turu;
                comboBox_Urun_Turu_Listesi.SelectedItem = urun.Turu.ToString();
                if (timer_Urun.Enabled==false)
                {
                    timer_Urun.Enabled = true;
                    label_Urun_Mesaj.Visible = true;
                    label_Urun_Mesaj.Text = "Ürün Kaydı Bulundu";
                    i = 0;
                }

            }
            else
            {
                timer_Urun.Enabled = true;
                label_Urun_Mesaj.Visible = true;
                label_Urun_Mesaj.Text = "Ürün Kaydı Bulunamadı";
                i = 0;
            }





        }

        private void button_Urun_Sil_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.Urun_Adi = textBox_Urun_Adi.Text;


            UrunDb urundb = new UrunDb();
            urundb.Sil(urun);

            try
            {
                if (timer_Urun.Enabled == false)
                {
                    timer_Urun.Enabled = true;
                    label_Urun_Mesaj.Visible = true;
                    label_Urun_Mesaj.Text = "Ürün Silme Başarılı";
                    i = 0;
                    textBox_Urun_Adi.Text = "";


                }

            }
            catch (Exception)
            {
                timer_Urun.Enabled = true;
                label_Urun_Mesaj.Visible = true;
                label_Urun_Mesaj.Text = "Ürün Silme Başarısız";

            }
            comboBox_Urun_Turu_Listesi.Items.Clear();
            TuruDoldur();
        }
    }
}
