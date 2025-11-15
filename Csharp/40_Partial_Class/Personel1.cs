using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Partial_Class
{
    internal partial class Personel
    {
        public int Yas { get; set; }
        public string Soyad { get; set; }
        public Personel(string name)
        {
            Console.WriteLine(name);
        }
        public void Bilgi(string deger)
        {
            Console.WriteLine(deger);
        }
        public void Test()
        {
            Console.WriteLine("Test Personel1");
        }
    }
}
