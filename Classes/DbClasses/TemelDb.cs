using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; 
using System.Data.SqlClient;
using System.Configuration;

namespace Giyim_Otomasyonu
{
    public abstract class TemelDb
    {
        string yol;
        public SqlConnection baglanti;
        public SqlDataReader okuyucu;
        public SqlDataAdapter adaptor;
        public DataTable tablo;
        public SqlCommand komut;

        public TemelDb()
        {
            yol = @"Data Source=DESKTOP-70OIF6J;Initial Catalog=Giyim Otomasyonu;Integrated Security=True";
        }

        public void Baglan()
        {
            baglanti = new SqlConnection(yol);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

        }
        abstract public void Ekle(IEntity varlik);
        abstract public void Guncelle(IEntity varlik);
        abstract public void Sil(IEntity varlik);
        abstract public void Ara(IEntity varlik);








    }
}