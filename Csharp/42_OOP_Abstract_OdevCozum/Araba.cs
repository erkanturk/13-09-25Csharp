using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_OOP_Abstract_OdevCozum
{
    public class Araba : Tasit
    {
        public string VitesTuru { get; set; }
        public string YakitTuru { get; set; }
        //DI (Dependency injection) dışa bağımlılık
        public Araba(string marka, string model, double tabanFiyat, string vitesTuru, string yakitTuru) : base(marka, model, tabanFiyat)
        {
            VitesTuru=vitesTuru;
            YakitTuru=yakitTuru;
        }

        public override double Fiyat
        {
            get
            {
                if (YakitTuru=="Dizel")
                {
                    TabanFiyat+=5000;
                }
                if (VitesTuru=="Otomatik")
                {
                    TabanFiyat+=10000;
                }
                return TabanFiyat;
            }
        }

    }
}
