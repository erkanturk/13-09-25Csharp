using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Class_Constructor
{
    internal class Kisi
    {
        public string Ad;
        public string Soyad;
        public int Yas;
        public Kisi()//Parametresiz constructor
        {
            Console.WriteLine("Constructor çalıştı");
        }
        public Kisi(string ad, string soyad, int yas)//overload edilmiş constructor Bu yapıda parametre verilmeden kullanılamaz
        {
            Ad = ad;
            Soyad = soyad;
            Yas = yas;
        }
        public void Bilgi()
        {
            Console.WriteLine("Ad: " + Ad);
            Console.WriteLine("Soyad: " + Soyad);
            Console.WriteLine("Yaş: " + Yas);
        }
    }
}
