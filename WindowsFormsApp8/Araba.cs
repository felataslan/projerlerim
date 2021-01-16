using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    class Araba:ArabaDetay
    {
        public string renk;
        public int hız;
        public double motor;
        public int fiyat;
        public char durum;
        private int yil;
        private string Marka;


        public int YIL
        {
            get { return yil; }
            set { yil = Math.Abs(value); }
        }
        public string MARKA
        {
            get { return Marka; }

            set { Marka = value.ToUpper(); }

        }


    }
}
