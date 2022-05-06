using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Giyim_Otomasyonu
{
    public class Musteri : IEntity
    {
        private int musteri_Id;
        private string adi;
        private string soyadi;
        private int musteri_Sicil_No;

        public int Musteri_Id
        {
            get
            {
                return musteri_Id;
            }

            set
            {
                musteri_Id = value;
            }
        }

        public string Adi
        {
            get
            {
                return adi;
            }

            set
            {
                adi = value;
            }
        }

        public string Soyadi
        {
            get
            {
                return soyadi;
            }

            set
            {
                soyadi = value;
            }
        }

        public int Musteri_Sicil_No
        {
            get
            {
                return musteri_Sicil_No;
            }

            set
            {
                musteri_Sicil_No = value;
            }
        }
        public Musteri()
        {
            this.Adi = "";
            this.Musteri_Id = 0;
            this.Musteri_Sicil_No = 0;
            this.Soyadi = "";
        }


    }
}