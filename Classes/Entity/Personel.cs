using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Giyim_Otomasyonu
{
    public class Personel : IEntity
    {
        private int personel_Id;
        private string adi;
        private string soyadi;
        private int yasi;
        private string gorevi;

        public int Personel_Id
        {
            get
            {
                return personel_Id;
            }

            set
            {
                personel_Id = value;
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

        public int Yasi
        {
            get
            {
                return yasi;
            }

            set
            {
                yasi = value;
            }
        }

        public string Gorevi
        {
            get
            {
                return gorevi;
            }

            set
            {
                gorevi = value;
            }
        }
        public Personel()
        {
            this.Adi = "";
            this.Gorevi = "";
            this.Personel_Id = 0;
            this.Soyadi = "";
            this.Yasi = 0;
        }



    }
}