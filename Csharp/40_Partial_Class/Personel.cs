using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Partial_Class
{
    internal partial class Personel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Personel()
        {
            Console.WriteLine("Personel yapısı çalıştı");
        }

        public void Bilgi()
        {
            Console.WriteLine("TEst PErsonel");
        }
        public void Deneme()
        {
            Console.WriteLine("Deneme");
        }
    }
}
