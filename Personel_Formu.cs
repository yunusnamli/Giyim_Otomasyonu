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
    public partial class Personel_Formu : Form
    {
        public Form Admin { get; set; }
        public string Who { get; set; }
        public Personel_Formu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Personel_Formu_Load(object sender, EventArgs e)
        {
            Gorevdoldur();
            if (Who == "Admin")
            {
                button_Geri_Donus.Visible = true;
            }
            else
            {
                button_Geri_Donus.Visible = false;
            }
        }

        private void Gorevdoldur()//Burada Kaldık
        {
            List<string> liste = new List<string>();
            PersonelDb personeldb = new PersonelDb();

            liste = personeldb.GorevDoldur();

            foreach (var item in liste)
            {
                comboBox_Personel_Gorev_Listesi.Items.Add(item);
            }


        }

        private void button_Geri_Donus_Click(object sender, EventArgs e)
        {
            Admin personel_formu = new Admin();
            personel_formu.Personel_Formu = this;
            personel_formu.Show();
            this.Hide();



        }
        int i = 0;
        private void button_Personel_Ekle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.Adi = textBox_Personel_Adi.Text;
            personel.Soyadi = textBox_Personel_Soyadi.Text;
            personel.Yasi = Convert.ToInt32(textBox_Personel_Yasi.Text);
            personel.Gorevi = textBox_Personel_Gorevi.Text;

            PersonelDb personeldb = new PersonelDb();
            personeldb.Ekle(personel);

            try
            {
                if (timer_Personel.Enabled==false)
                {
                    timer_Personel.Enabled = true;
                    label_Personel_Mesaj.Visible = true;
                    label_Personel_Mesaj.Text = "Personel Ekleme Başarılı";
                    i = 0;
                    textBox_Personel_Adi.Text = "";
                    textBox_Personel_Soyadi.Text = "";
                    textBox_Personel_Yasi.Text = "";
                    textBox_Personel_Gorevi.Text = "";


                }

            }
            catch (Exception)
            {
                timer_Personel.Enabled = true;
                label_Personel_Mesaj.Visible = true;
                label_Personel_Mesaj.Text = "Personel Ekleme Başarısız";
                i = 0;
                
            }
            comboBox_Personel_Gorev_Listesi.Items.Clear();
            Gorevdoldur();



        }

        private void timer_Personel_Tick(object sender, EventArgs e)
        {
            i++;

            if (i==2)
            {
                timer_Personel.Enabled = false;
                label_Personel_Mesaj.Visible = false;
                label_Personel_Mesaj.Enabled = false;

            }


        }

        private void comboBox_Personel_Gorev_Listesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.Gorevi = comboBox_Personel_Gorev_Listesi.SelectedItem.ToString();

            PersonelDb personeldb = new PersonelDb();
            personeldb.Getir(personel);

            textBox_Personel_Adi.Text = personel.Adi.ToString();
            textBox_Personel_Soyadi.Text = personel.Soyadi.ToString();
            textBox_Personel_Yasi.Text = personel.Yasi.ToString();
            textBox_Personel_Gorevi.Text = personel.Gorevi.ToString();
            label_Personel_Id.Text = personel.Personel_Id.ToString();



        }

        private void button_Personel_Guncelle_Click(object sender, EventArgs e)
        {

            Personel personel = new Personel();
            personel.Personel_Id = Convert.ToInt16(label_Personel_Id.Text);
            personel.Adi = textBox_Personel_Adi.Text;
            personel.Soyadi = textBox_Personel_Soyadi.Text;
            personel.Yasi = Convert.ToInt16(textBox_Personel_Yasi.Text);
            personel.Gorevi = textBox_Personel_Gorevi.Text;

            PersonelDb personeldb = new PersonelDb();
            personeldb.Guncelle(personel);

            try
            {
                if (timer_Personel.Enabled==false)
                {
                    timer_Personel.Enabled = true;
                    label_Personel_Mesaj.Visible = true;
                    label_Personel_Mesaj.Text = "Personel Güncelleme Başarılı";
                    i = 0;
                    label_Personel_Id.Text = "";
                    textBox_Personel_Adi.Text = "";
                    textBox_Personel_Soyadi.Text = "";
                    textBox_Personel_Yasi.Text = "";
                    textBox_Personel_Gorevi.Text = "";


                }

            }


            catch (Exception)
            {
                timer_Personel.Enabled = true;
                label_Personel_Mesaj.Visible = true;
                label_Personel_Mesaj.Text = "Personel Güncelleme Başarısız !";

                
            }
            comboBox_Personel_Gorev_Listesi.Items.Clear();
            Gorevdoldur();





        }

        private void button_Personel_Arama_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.Adi = textBox_Personel_Adi.Text;

            PersonelDb personeldb = new PersonelDb();
            personeldb.GetirAd(personel);

            if (personel.Personel_Id!=0)
            {
                label_Personel_Id.Text = personel.Personel_Id.ToString();
                textBox_Personel_Adi.Text = personel.Adi;
                textBox_Personel_Soyadi.Text = personel.Soyadi;
                textBox_Personel_Yasi.Text = personel.Yasi.ToString();
                textBox_Personel_Gorevi.Text = personel.Gorevi;
                comboBox_Personel_Gorev_Listesi.SelectedItem = personel.Gorevi;
                if (timer_Personel.Enabled==false)
                {
                    timer_Personel.Enabled = true;
                    label_Personel_Mesaj.Visible = true;
                    label_Personel_Mesaj.Text = "Personel Kaydı Bulundu";
                    i = 0;
      }
  
            }
            else
            {
                timer_Personel.Enabled = true;
                label_Personel_Mesaj.Visible = true;
                label_Personel_Mesaj.Text = "Personel Kaydı Bulunamadı";
                i = 0;
            }






        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_Personel_Sil_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.Adi = textBox_Personel_Adi.Text;


            PersonelDb personeldb = new PersonelDb();
            personeldb.Sil(personel);

            try
            {
                if (timer_Personel.Enabled == false)
                {
                    timer_Personel.Enabled = true;
                    label_Personel_Mesaj.Visible = true;
                    label_Personel_Mesaj.Text = "Personel Silme Başarılı";
                    i = 0;
                    textBox_Personel_Adi.Text = "";

            }

            }
            catch (Exception)
            {
                timer_Personel.Enabled = true;
                label_Personel_Mesaj.Visible = true;
                label_Personel_Mesaj.Text = "Personel Silme Başarısız";
                i = 0;

            }
            comboBox_Personel_Gorev_Listesi.Items.Clear();
            Gorevdoldur();
        }
    }
}
