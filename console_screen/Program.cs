using System;

namespace console_screen
{
    class Program
    {
        static void Main(string[] args)
        {
            Kimlik kimlik = new Kimlik();
            kimlik.AD = "felat";
            kimlik.SOYAD = "aslan";
            kimlik.MEMLEKET = "diyarbakır";
            kimlik.CİNSİYET = 'E';
            kimlik.YAS = 21;
            Console.WriteLine(kimlik.AD);
            Console.WriteLine(kimlik.SOYAD);
            Console.WriteLine(kimlik.MEMLEKET);
            Console.WriteLine(kimlik.CİNSİYET);
            Console.WriteLine(kimlik.YAS);
           
            
            




            //string ad;
            //Console.Write(" Kisisel Bilgiler: ");
            //ad = Console.ReadLine();
            //string soyad;
            //soyad=Console.ReadLine();
            //string yas;
            //yas = Console.ReadLine();
            //string meslek;

            //meslek = Console.ReadLine();





            //Ogrenci ogrenci = new Ogrenci(ad,soyad,yas,meslek);


            Console.ReadLine();





            //int sayi = 55;
            //Console.WriteLine(sayi);
            //Console.WriteLine("Hello World!");

        }
    }
}
