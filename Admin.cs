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
    public partial class Admin : Form
    {
        public Form Giris { get; set; }
        public Form Kullanici_Ayarlari { get; set; }
        public  Form Urun_Satis { get; set; }
        public Form Personel_Formu { get; set; }
        public Form Urun_Formu { get; set; }
        public Form Musteri_Formu { get; set; }

        public Admin()
        {
            
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button_Kullanici_Ayarlari_Click(object sender, EventArgs e)
        {
            Kullanici_Ayarlari kullanıcı_ayarlari = new Kullanici_Ayarlari();
            kullanıcı_ayarlari.Admin = this;
            kullanıcı_ayarlari.Who = "Admin";
            kullanıcı_ayarlari.Show();
            this.Hide();
        }

        private void button_Urun_Satis_Click(object sender, EventArgs e)
        {
            Urun_Satis urun_satis = new Urun_Satis();
            urun_satis.Admin = this;
            urun_satis.Who = "Admin";
            urun_satis.Show();          
            this.Hide();
        }

        private void button_Personel_Click(object sender, EventArgs e)
        {
         
            Personel_Formu personel_formu = new Personel_Formu();
            personel_formu.Admin = this;
            personel_formu.Who = "Admin";
            personel_formu.Show();       
            this.Hide();
        }

        private void button_Urunler_Click(object sender, EventArgs e)
        {

            Urun_Formu urun_formu = new Urun_Formu();
            urun_formu.Admin = this;
            urun_formu.Who = "Admin";
            urun_formu.Show();
            this.Hide();
        }

        private void button_Geri_Donus_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Admin = this;
            grs.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Musteri_Formu musteri_formu = new Musteri_Formu();
            musteri_formu.Admin = this;
            musteri_formu.Who = "Admin";
            musteri_formu.Show();        
            this.Hide();
        }
    }
}
