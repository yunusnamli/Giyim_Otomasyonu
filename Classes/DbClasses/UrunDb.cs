using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Giyim_Otomasyonu
{
    public class UrunDb : TemelDb
    {
        public override void Ara(IEntity varlik)
        {
            throw new NotImplementedException();
        }

        public override void Ekle(IEntity varlik)
        {
            Urun gelen = (Urun)varlik;
            Baglan();
            komut = new SqlCommand("insert into Tbl_Urun values (@adi,@turu,@adedi,@fiyati,@rengi,@bedeni)",baglanti);
            komut.Parameters.AddWithValue("@adi", gelen.Urun_Adi);
            komut.Parameters.AddWithValue("@turu", gelen.Turu);
            komut.Parameters.AddWithValue("@adedi", gelen.Adedi);
            komut.Parameters.AddWithValue("@fiyati", gelen.Fiyati);
            komut.Parameters.AddWithValue("@rengi", gelen.Rengi);
            komut.Parameters.AddWithValue("@bedeni", gelen.Bedeni);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();





        }

        internal object UrunListele()
        {
            Baglan();
            komut = new SqlCommand("Select * from Tbl_Urun", baglanti);
            komut.ExecuteNonQuery();
            tablo = new DataTable();
            adaptor = new SqlDataAdapter();
            adaptor = new SqlDataAdapter(komut);
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;



        }

        public override void Guncelle(IEntity varlik)
        {
            Urun gelen = (Urun)varlik;
            Baglan();

            komut = new SqlCommand("Update Tbl_Urun Set Urun_Adi=@adi,Turu=@turu,Adedi=@adedi,Fiyati=@fiyati,Rengi=@rengi,Bedeni=@bedeni where Urun_Id =@id ", baglanti);
            komut.Parameters.AddWithValue("@adi", gelen.Urun_Adi);
            komut.Parameters.AddWithValue("@turu", gelen.Turu);
            komut.Parameters.AddWithValue("@adedi", gelen.Adedi);
            komut.Parameters.AddWithValue("@fiyati", gelen.Fiyati);
            komut.Parameters.AddWithValue("@rengi", gelen.Rengi);
            komut.Parameters.AddWithValue("@bedeni", gelen.Bedeni);
            komut.Parameters.AddWithValue("@id", gelen.Urun_Id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();





        }

        public override void Sil(IEntity varlik)
        {
            Urun gelen = (Urun)varlik;
            Baglan();
            komut = new SqlCommand("Delete from Tbl_Urun where Urun_Adi=@adi", baglanti);
            komut.Parameters.AddWithValue("@adi", gelen.Urun_Adi);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();





        }

        internal List<string> TuruGetir()
        {
            List<string> dizi = new List<string>();
            Baglan();
            komut = new SqlCommand("Select Turu from Tbl_Urun", baglanti);
            komut.ExecuteNonQuery();

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                dizi.Add(okuyucu["Turu"].ToString());

            }
            baglanti.Close();
            baglanti.Dispose();
            return dizi;





        }

        internal void TuruGetir(Urun urun)
        {
            Baglan();
            komut = new SqlCommand("Select * from Tbl_Urun where Turu=@turu", baglanti);
            komut.Parameters.AddWithValue("@turu", urun.Turu);
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                urun.Urun_Adi = okuyucu["Urun_Adi"].ToString();
                urun.Turu = okuyucu["Turu"].ToString();
                urun.Adedi = Convert.ToInt16(okuyucu["Adedi"].ToString());
                urun.Fiyati = Convert.ToInt16(okuyucu["Fiyati"].ToString());
                urun.Rengi = okuyucu["Rengi"].ToString();
                urun.Bedeni = okuyucu["Bedeni"].ToString();
                urun.Urun_Id = Convert.ToInt16(okuyucu["Urun_Id"].ToString());
            }
            baglanti.Close();
            baglanti.Dispose();

        }

        internal void Getir(Urun urun)
        {
            Baglan();
            komut = new SqlCommand("Select * from Tbl_Urun where Urun_Adi=@adi", baglanti);
            komut.Parameters.AddWithValue("@adi", urun.Urun_Adi);
            komut.ExecuteNonQuery();

            okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                urun.Urun_Adi = okuyucu["Urun_Adi"].ToString();
                urun.Turu = okuyucu["Turu"].ToString();
                urun.Adedi = Convert.ToInt16(okuyucu["Adedi"].ToString());
                urun.Fiyati = Convert.ToInt16(okuyucu["Fiyati"].ToString());
                urun.Rengi = okuyucu["Rengi"].ToString();
                urun.Bedeni = okuyucu["Bedeni"].ToString();
                urun.Urun_Id =Convert.ToInt16(okuyucu["Urun_Id"].ToString());


            }




        }
    }
}