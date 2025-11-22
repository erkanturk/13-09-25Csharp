using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_OOP_Abstract_OdevCozum
{
    internal class Ucak : Tasit
    {
        public int Kapasite { get; set; }
        public Ucak(string marka, string model, double tabanFiyat, int kapasite) : base(marka, model, tabanFiyat)
        {
            Kapasite=kapasite;
        }

        public override double Fiyat
        {
            get { return TabanFiyat+(Kapasite*100); }
        }
    }
}
