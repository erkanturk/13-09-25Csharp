using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_Class_Object
{
    internal class Urun
    {
        public int Id;
        public string Unvan;
        public string Aciklama;
        public string Degerlendirme;
        public string YorumSayisi;
        public double Fiyat;
        public string Resim;

        public Urun Kaydet()
        {
            Urun urun = new Urun();
            urun.Aciklama="Test";
            urun.Unvan="Gömlek";
            urun.Resim="1.jpg";
            urun.Id=1;
            urun.YorumSayisi="100";
            urun.Degerlendirme="5";
            urun.Fiyat=1200;
            return urun;
        }
    }
}
