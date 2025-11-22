using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_OOP_Abstract_OdevCozum
{
    public abstract class Tasit //Base class
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double TabanFiyat { get; set; }
        public abstract double Fiyat { get; }//Var olan değeri göstersin

        protected Tasit(string marka,string model,double tabanFiyat)//sadece kalıtımla çalışan constructor
        {
            Marka=marka;
            Model = model;
            TabanFiyat=tabanFiyat;
        }
    }
}
