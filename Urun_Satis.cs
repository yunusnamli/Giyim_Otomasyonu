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
   
    public partial class Urun_Satis : Form
    {
        public Form Admin { get; set; }
        public string Who { get; set; }
        public Urun_Satis()
        {
            InitializeComponent();
        }

        private void Urun_Satis_Load(object sender, EventArgs e)
        {
            UrunDoldur();
            
            if (Who == "Admin")
            {
                button_Geri_Donus.Visible = true;
            }
            else
            {
                button_Geri_Donus.Visible = false;
            }
        }

        private void UrunDoldur()
        {
            UrunDb urundb = new UrunDb();
            comboBox_Urun_Listesi.DataSource = urundb.UrunListele();
            comboBox_Urun_Listesi.DisplayMember = "Urun_Adi";
            comboBox_Urun_Listesi.ValueMember = "Urun_Id";



        }

        private void button_Geri_Donus_Click(object sender, EventArgs e)
        {
            Admin urun_satis = new Admin();
            urun_satis.Urun_Satis = this;
            urun_satis.Show();
            this.Hide();
        }
        int i = 0;
        private void textBox_Musteri_Sicil_No_TextChanged(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Musteri_Sicil_No = Convert.ToInt16 (textBox_Musteri_Sicil_No.Text);

            MusteriDb musteridb = new MusteriDb();
            musteridb.Bul(musteri);

            try
            {
                label_Musteri_Ad_Soyad.Visible = true;
                string ad = musteri.Adi + "" + musteri.Soyadi;
                label_Musteri_Ad_Soyad.Text = ad;
                label_Satis_Id.Text = musteri.Musteri_Id.ToString();

                if (musteri.Adi!="")
                {
                    timer_Urun_Satis.Enabled = false;
                    label_Satis_Mesaj.Visible = true;
                    label_Satis_Mesaj.Text = "Müşteri Mevcut";
                    i = 0;
                }
                else
                {
                    timer_Urun_Satis.Enabled = true;
                    label_Satis_Mesaj.Visible = true;
                    label_Satis_Mesaj.Text = "Müşteri Bulunamadı";
                    i = 0;

                }



            }
            catch (Exception)
            {
                timer_Urun_Satis.Enabled = true;
                label_Satis_Mesaj.Visible = true;
                label_Satis_Mesaj.Text = "Bağlantı Sorunu";
                i = 0;
                
            }

        }

        private void timer_Urun_Satis_Tick(object sender, EventArgs e)
        {
            i++;

            if (i==2)
            {
                timer_Urun_Satis.Enabled = false;
                label_Satis_Mesaj.Visible = false;

            }
        }

        private void button_Urun_Ekle_Click(object sender, EventArgs e)
        {
            Satis satis = new Satis();
            satis.Adedi =Convert.ToInt16(textBox_Urun_Adedi.Text);
            satis.Fiyati = Convert.ToInt16(textBox_Urun_Fiyati.Text);
            satis.Turu = textBox_Urun_İsmi.Text;
            satis.Rengi = textBox_Urun_Rengi.Text;
            satis.Bedeni = textBox_Urun_Bedeni.Text;
            satis.Urun_No.Urun_Id = Convert.ToInt16(comboBox_Urun_Listesi.SelectedValue);
            satis.Musteri_No.Musteri_Id = Convert.ToInt16(label_Satis_Id.Text);

            SatisDb satdb = new SatisDb();
            satdb.Ekle(satis);

            try
            {
                if (timer_Urun_Satis.Enabled == false)
                {
                    timer_Urun_Satis.Enabled = true;
                    label_Satis_Mesaj.Visible = true;
                    label_Satis_Mesaj.Text = "Satis Ekleme Başarılı";
                    i = 0;
                    textBox_Urun_Adedi.Text = "";
                    textBox_Urun_Fiyati.Text = "";
                    textBox_Urun_İsmi.Text = "";
                    textBox_Urun_Rengi.Text = "";
                    textBox_Urun_Bedeni.Text = "";


                }

            }
            catch (Exception)
            {
                timer_Urun_Satis.Enabled = true;
                label_Satis_Mesaj.Visible = true;
                label_Satis_Mesaj.Text = "Satış Ekleme Başarısız";
                i = 0;
        
            }










        }
    }
}
