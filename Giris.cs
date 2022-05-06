using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Giyim_Otomasyonu
{
    public partial class Giris : Form
    {
        public Form Admin { get; set; }

        public Giris()
        {
            InitializeComponent();
        }

        private void button_Giris_Click(object sender, EventArgs e)
        {                
            if (textBox_Kullanici_Adi.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adı Giriniz");
            }
            else if (textBox_Kullanici_Sifresi.Text == "")             
            {
                MessageBox.Show("Lütfen Sifre Giriniz");
            }
            else
            {
                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-70OIF6J;Initial Catalog=Giyim Otomasyonu;Integrated Security=True");
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_Kullanici WHERE Kullanici_Adi = '"+textBox_Kullanici_Adi.Text+"'and Sifre = '"+textBox_Kullanici_Sifresi.Text+"'",cn);
                SqlDataReader dr = cmd.ExecuteReader();                
                if (dr.Read())
                {
                    if (dr["Gorevi"].ToString() == comboBox_Kullanici_Yetkisi.Text)
                    {
                        if (comboBox_Kullanici_Yetkisi.Text == "Admin")
                        {                           
                          
                            Admin ad = new Admin();
                            ad.Show();
                            this.Hide();
                           
                        }
                        else if (comboBox_Kullanici_Yetkisi.Text == "Satış Danışmanı")
                        {
                            Urun_Satis ad = new Urun_Satis();
                            ad.Show();
                            this.Hide();
                            
                        }
                        else if (comboBox_Kullanici_Yetkisi.Text == "Muhasebe")
                        {
                            Urun_Formu ad = new Urun_Formu();
                            ad.Show();
                            this.Hide();
                            
                        }
                        else if (comboBox_Kullanici_Yetkisi.Text == "Görevli")
                        {
                            Musteri_Formu ad = new Musteri_Formu();
                            ad.Show();
                            this.Hide();   
                        }
                    }
                   else 
                    {
                        MessageBox.Show("Hata");
                    }
                        
                    
                    cn.Close();
                }
            }

}

        private void Giris_Load(object sender, EventArgs e)
        {
            comboBox_Kullanici_Yetkisi.Items.Add("Görevli");
            comboBox_Kullanici_Yetkisi.Items.Add("Satış Danışmanı");
            comboBox_Kullanici_Yetkisi.Items.Add("Muhasebe");            
            comboBox_Kullanici_Yetkisi.Items.Add("Admin");
        }

        private void comboBox_Kullanici_Yetkisi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}