using System;
using System.Collections.Generic;
using System.Text;

namespace console_screen
{
    class Kimlik
    {
        string Ad;
        string Soyad;
        string Memleket;
        int yas;
        char cinsiyet;
        public string AD
        {
            get { return Ad; }
            set { Ad = value.ToLower(); }
        }
        public string SOYAD
        {
            get { return Soyad; }
            set { Soyad = value.ToUpper(); }
        }
        public string MEMLEKET
        {
            get { return Memleket; }
            set { Memleket = value.ToUpper(); }
        }

        public int YAS
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }

        public char CİNSİYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }

        public Kimlik()
        {
            Ad = "";
            Soyad = "";
            yas = 18;
            Memleket = "ANKARA";
            cinsiyet = 'K';
        }
    }
}
