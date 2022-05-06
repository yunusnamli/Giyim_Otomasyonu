using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Giyim_Otomasyonu
{
    public class Urun : IEntity
    {
        private int urun_Id;
        private string turu;
        private int adedi;
        private int fiyati;
        private string rengi;
        private string bedeni;
        private string urun_Adi;

        public int Urun_Id
        {
            get
            {
                return urun_Id;
            }

            set
            {
                urun_Id = value;
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

        public string Urun_Adi
        {
            get
            {
                return urun_Adi;
            }

            set
            {
                urun_Adi = value;
            }
        }

        public Urun()
        {
            this.Adedi = 0;
            this.Bedeni = "";
            this.Fiyati = 0;
            this.Rengi = "";
            this.Turu = "";
            this.Urun_Adi = "";
            this.Urun_Id = 0;

        }


    }
}