using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Giyim_Otomasyonu
{
    public class KullaniciDb : TemelDb
    {
        public override void Ara(IEntity varlik)
        {
         

        }

        public override void Ekle(IEntity varlik)
        {

            Kullanici gelen = (Kullanici)varlik;
            Baglan();
            komut = new SqlCommand("insert into Tbl_Kullanici  values(@adi,@sifre,@gorev) ", baglanti);
            komut.Parameters.AddWithValue("@adi", gelen.Kullanici_Adi);
            komut.Parameters.AddWithValue("@sifre", gelen.Sifre);
            komut.Parameters.AddWithValue("gorev", gelen.Gorevi);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }



        public override void Guncelle(IEntity varlik)
        {
            Kullanici gelen = (Kullanici)varlik;
            Baglan();
            komut = new SqlCommand("Update Tbl_Kullanici Set Kullanici_Adi=@adi,Sifre=@sifre,Gorevi=@gorev where Kullanici_Id=@id", baglanti);
           
            komut.Parameters.AddWithValue("@adi", gelen.Kullanici_Adi);
            komut.Parameters.AddWithValue("@sifre", gelen.Sifre);
            komut.Parameters.AddWithValue("@gorev", gelen.Gorevi);
            komut.Parameters.AddWithValue("@id", gelen.Kullanici_Id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
             


     
        }

        public override void Sil(IEntity varlik)
        {

            Kullanici gelen = (Kullanici)varlik;
            Baglan();
            komut = new SqlCommand("Delete  from Tbl_Kullanici where Kullanici_Adi=@adi ", baglanti);
            komut.Parameters.AddWithValue("@adi", gelen.Kullanici_Adi);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();

        }

        internal List<string> ListeDoldur()
        {
            List<string> dizi = new List<string>();
            Baglan();
            komut = new SqlCommand("Select Gorevi From Tbl_Kullanici", baglanti);
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                dizi.Add(okuyucu["Gorevi"].ToString());
            }
            baglanti.Close();
            baglanti.Dispose();
            return dizi;

        }

        internal void Getir(Kullanici kullanici)
        {
            Baglan();
            komut = new SqlCommand("Select * from Tbl_Kullanici where Gorevi=@gorev", baglanti);
            komut.Parameters.AddWithValue("@gorev", kullanici.Gorevi);
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                kullanici.Kullanici_Id = Convert.ToInt16(okuyucu["Kullanici_Id"]);
                kullanici.Kullanici_Adi = okuyucu["Kullanici_Adi"].ToString();
                kullanici.Sifre = okuyucu["Sifre"].ToString();
                kullanici.Gorevi = okuyucu["Gorevi"].ToString();
                kullanici.Kullanici_Id = Convert.ToInt32(okuyucu["Kullanici_Id"].ToString());
            }
            baglanti.Close();
            baglanti.Dispose();


        }

        internal void GetirAd(Kullanici kullanici)
        {
            Baglan();
            komut = new SqlCommand("Select * from Tbl_Kullanici where Kullanici_Adi=@adi ", baglanti);
            komut.Parameters.AddWithValue("@adi", kullanici.Kullanici_Adi);
            komut.ExecuteNonQuery();

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                kullanici.Kullanici_Adi = okuyucu["Kullanici_Adi"].ToString();
                kullanici.Sifre = okuyucu["Sifre"].ToString();
                kullanici.Gorevi = okuyucu["Gorevi"].ToString();
                kullanici.Kullanici_Id =Convert.ToInt16( okuyucu["Kullanici_Id"].ToString());

            }
            baglanti.Close();
            baglanti.Dispose();





        }
    }
}