using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Giyim_Otomasyonu
{
    public class PersonelDb : TemelDb
    {
        public override void Ara(IEntity varlik)
        {
            throw new NotImplementedException();
        }

        public override void Ekle(IEntity varlik)
        {
            Personel gelen = (Personel)varlik;
            Baglan();
            komut = new SqlCommand("insert into Tbl_Personel values (@adi,@soyadi,@yasi,@gorevi)", baglanti);
            komut.Parameters.AddWithValue("@adi", gelen.Adi);
            komut.Parameters.AddWithValue("soyadi", gelen.Soyadi);
            komut.Parameters.AddWithValue("yasi", gelen.Yasi);
            komut.Parameters.AddWithValue("@gorevi", gelen.Gorevi);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();




        }

        public override void Guncelle(IEntity varlik)
        {
            Personel gelen = (Personel)varlik;
            Baglan();
            komut = new SqlCommand("Update Tbl_Personel Set  Adi=@adi,Soyadi=@soyadi,Yasi=@yasi,Gorevi=@gorevi where Personel_Id=@id", baglanti);
            komut.Parameters.AddWithValue("@adi", gelen.Adi);
            komut.Parameters.AddWithValue("@soyadi", gelen.Soyadi);
            komut.Parameters.AddWithValue("@yasi", gelen.Yasi);
            komut.Parameters.AddWithValue("@gorevi", gelen.Gorevi);
            komut.Parameters.AddWithValue("@id", gelen.Personel_Id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();





        }

        public override void Sil(IEntity varlik)
        {
            Personel gelen = (Personel)varlik;
            Baglan();
            komut = new SqlCommand("Delete from Tbl_Personel where Adi = @adi", baglanti);
            komut.Parameters.AddWithValue("@adi",gelen.Adi);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();




        }

        internal List<string> GorevDoldur()
        {
            List<string> dizi = new List<string>();
            Baglan();

            komut = new SqlCommand("Select Gorevi from Tbl_Personel", baglanti);
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

        internal void Getir(Personel personel)
        {
            Baglan();
            komut = new SqlCommand("Select * from Tbl_Personel where Gorevi=@gorevi", baglanti);
            komut.Parameters.AddWithValue("@gorevi",personel.Gorevi);
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                personel.Personel_Id = Convert.ToInt16(okuyucu["Personel_Id"]);
                personel.Adi = okuyucu["Adi"].ToString();
                personel.Soyadi = okuyucu["Soyadi"].ToString();
                personel.Yasi = Convert.ToInt16(okuyucu["Yasi"]);
                personel.Gorevi = okuyucu["Gorevi"].ToString();
                
            }
            baglanti.Close();
            baglanti.Dispose();

        }

        internal void GetirAd(Personel personel)
        {
            Baglan();
            komut = new SqlCommand("Select * from Tbl_Personel where Adi=@adi", baglanti);
            komut.Parameters.AddWithValue("@adi", personel.Adi);
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                personel.Adi = okuyucu["Adi"].ToString();
                personel.Soyadi = okuyucu["Soyadi"].ToString();
                personel.Yasi =Convert.ToInt16(okuyucu["Yasi"].ToString());
                personel.Gorevi = okuyucu["Gorevi"].ToString();
                personel.Personel_Id = Convert.ToInt16(okuyucu["Personel_Id"].ToString());

            }
            baglanti.Close();
            baglanti.Dispose();



        }
    }
}