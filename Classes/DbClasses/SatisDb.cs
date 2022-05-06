using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Giyim_Otomasyonu
{
    public class SatisDb : TemelDb
    {
        public override void Ara(IEntity varlik)
        {
            throw new NotImplementedException();
        }

        public override void Ekle(IEntity varlik)
        {
            Satis gelen = (Satis)varlik;
            Baglan();
            komut = new SqlCommand("insert into Tbl_Urun_Satis values(@adedi,@fiyati,@turu,@rengi,@bedeni,@müsteri,@urun) ", baglanti);
            komut.Parameters.AddWithValue("@adedi", gelen.Adedi);
            komut.Parameters.AddWithValue("@fiyati", gelen.Fiyati);
            komut.Parameters.AddWithValue("@turu", gelen.Turu);
            komut.Parameters.AddWithValue("@rengi", gelen.Rengi);
            komut.Parameters.AddWithValue("@bedeni", gelen.Bedeni);
            komut.Parameters.AddWithValue("@müsteri", gelen.Musteri_No.Musteri_Id);
            komut.Parameters.AddWithValue("@urun", gelen.Urun_No.Urun_Id);
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
            throw new NotImplementedException();
        }
    }
}