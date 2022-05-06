using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Giyim_Otomasyonu
{
    public class Kullanici : IEntity
    {
        private int kullanici_Id;
        private string kullanici_Adi;
        private string gorevi;
        private string sifre;

        public int Kullanici_Id
        {
            get
            {
                return kullanici_Id;
            }

            set
            {
                kullanici_Id = value;
            }
        }

        public string Kullanici_Adi
        {
            get
            {
                return kullanici_Adi;
            }

            set
            {
                kullanici_Adi = value;
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

        public string Sifre
        {
            get
            {
                return sifre;
            }

            set
            {
                sifre = value;
            }
        }

        public Kullanici()
        {
            this.Gorevi = "";
            this.Kullanici_Adi = "";
            this.Kullanici_Id = 0;
            this.Sifre = "";
        }

    }
}