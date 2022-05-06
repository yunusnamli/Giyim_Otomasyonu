using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Giyim_Otomasyonu
{
    public class Satin_Alma : IEntity
    {
        private int satin_Alma_Id;
        private Personel personel_No;
        private Urun urun_No;
        private string turu;
        private int adedi;
        private int fiyati;
        private int sirket_Adi;

        public int Satin_Alma_Id
        {
            get
            {
                return satin_Alma_Id;
            }

            set
            {
                satin_Alma_Id = value;
            }
        }

        public Personel Personel_No
        {
            get
            {
                return personel_No;
            }

            set
            {
                personel_No = value;
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

        public int Sirket_Adi
        {
            get
            {
                return sirket_Adi;
            }

            set
            {
                sirket_Adi = value;
            }
        }


        public Satin_Alma()
        {
            this.Adedi = 0;
            this.Fiyati = 0;
            this.Personel_No = new Personel();
            this.Satin_Alma_Id = 0;
            this.Sirket_Adi = 0;
            this.Turu = "";
            this.Urun_No = new Urun();



        }


    }
}