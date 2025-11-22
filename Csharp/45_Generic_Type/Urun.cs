using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_Generic_Type
{
    internal class Urun<T>
    {
        public T Fiyat { get; set; }
        public T Kdv { get; set; }
        public Urun(T fiyat,T kdv)
        {
            Fiyat = fiyat;
            Kdv = kdv;
        }
    }
}
