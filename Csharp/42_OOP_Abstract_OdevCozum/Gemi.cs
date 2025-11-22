using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_OOP_Abstract_OdevCozum
{
    internal class Gemi : Tasit
    {
        public int KaramaSayisi { get; set; }
        public Gemi(string marka, string model, double tabanFiyat, int karamaSayisi) : base(marka, model, tabanFiyat)
        {
            KaramaSayisi=karamaSayisi;
        }

        public override double Fiyat {
            get { return TabanFiyat+(KaramaSayisi*40000); }
        }
    }
}
