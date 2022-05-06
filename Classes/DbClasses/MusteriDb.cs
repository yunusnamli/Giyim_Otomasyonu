using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Giyim_Otomasyonu
{
    public class MusteriDb : TemelDb
    {
        public override void Ara(IEntity varlik)
        {
            throw new NotImplementedException();
        }

        public override void Ekle(IEntity varlik)
        {
            Musteri gelen = (Musteri)varlik;
            Baglan();
            komut = new SqlCommand("insert into Tbl_Musteri values (@adi,@soyadi,@sicilno)", baglanti);
            komut.Parameters.AddWithValue("@adi", gelen.Adi);
            komut.Parameters.AddWithValue("@soyadi", gelen.Soyadi);
            komut.Parameters.AddWithValue("@sicilno", gelen.Musteri_Sicil_No);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();






        }

        public override void Guncelle(IEntity varlik)
        {
            throw new NotImplementedException();
        }

        public override void Sil(IEntity varlik)
        {
            Musteri gelen = (Musteri)varlik;
            Baglan();
            komut = new SqlCommand("Delete From Tbl_Musteri where Adi=@adi ", baglanti);
            komut.Parameters.AddWithValue("@adi", gelen.Adi);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        internal void Bul(Musteri musteri)
        {
            Baglan();
            komut = new SqlCommand("Select Adi,Soyadi, Musteri_Id from Tbl_Musteri where Musteri_Sicil_No=@sicilno ", baglanti);
            komut.Parameters.AddWithValue("@sicilno", musteri.Musteri_Sicil_No);
            komut.ExecuteNonQuery();

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                musteri.Adi = okuyucu["Adi"].ToString();
                musteri.Soyadi = okuyucu["Soyadi"].ToString();
                musteri.Musteri_Id = Convert.ToInt16(okuyucu["Musteri_Id"].ToString());

     }
            baglanti.Close();
            baglanti.Dispose();


        }

        internal void Getir(Musteri musteri)
        {
            Baglan();
            komut = new SqlCommand("Select * from Tbl_Musteri where Musteri_Sicil_No=@sicilno", baglanti);
            komut.Parameters.AddWithValue("@sicilno", musteri.Musteri_Sicil_No);

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                musteri.Adi = okuyucu["Adi"].ToString();
                musteri.Soyadi = okuyucu["Soyadi"].ToString();
                musteri.Musteri_Sicil_No =Convert.ToInt16( okuyucu["Musteri_Sicil_No"].ToString());
                musteri.Musteri_Id = Convert.ToInt16(okuyucu["Musteri_Id"].ToString());
                
            }
            baglanti.Close();
            baglanti.Dispose();
        }
    }
}