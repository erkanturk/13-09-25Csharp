using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Class_Constructor
{
    internal class Ogrenci
    {
        public int ogrenciNo;
        public string AdSoyad;

        public void Bilgi()
        {
            Console.WriteLine("Öğrenci No: " + ogrenciNo);
            Console.WriteLine("Ad Soyad: " + AdSoyad);
        }
        public Ogrenci()
        {
            Console.WriteLine("Ctor çalıştı");
        }
        public Ogrenci(int ogrenciNo, string AdSoyad)
        {
            this.ogrenciNo = ogrenciNo;//this bulunduğu nesneyi temsil eder sınıfın üyesine erişmemizi sağlar
            this.AdSoyad = AdSoyad;
        }
    }
}
