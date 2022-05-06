using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Giyim_Otomasyonu
{
    public class Satis : IEntity
    {
        private int satis_Id;
        private Urun urun_No;
        private string turu;
        private int adedi;
        private int fiyati;
        private Musteri musteri_No;
        private string rengi;
        private string bedeni;

        public int Satis_Id
        {
            get
            {
                return satis_Id;
            }

            set
            {
                satis_Id = value;
            }
        }

        public Urun Urun_No
        {
            get
            {
                return urun_No;
            }

            set
            {
                urun_No = value;
            }
        }

        public string Turu
        {
            get
            {
                return turu;
            }

            set
            {
                turu = value;
            }
        }

        public int Adedi
        {
            get
            {
                return adedi;
            }

            set
            {
                adedi = value;
            }
        }

        public int Fiyati
        {
            get
            {
                return fiyati;
            }

            set
            {
                fiyati = value;
            }
        }

        public Musteri Musteri_No
        {
            get
            {
                return musteri_No;
            }

            set
            {
                musteri_No = value;
            }
        }

        public string Rengi
        {
            get
            {
                return rengi;
            }

            set
            {
                rengi = value;
            }
        }

        public string Bedeni
        {
            get
            {
                return bedeni;
            }

            set
            {
                bedeni = value;
            }
        }

        public Satis()
        {
            this.Satis_Id = 0;
            this.Adedi = 0;
            this.Fiyati = 0;
            this.Turu = "";
            this.Rengi = "";
            this.Bedeni = "";
            this.Musteri_No = new Musteri();
            this.Urun_No = new Urun();
        }

    }
}