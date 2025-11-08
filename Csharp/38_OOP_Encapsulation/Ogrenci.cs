using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_OOP_Encapsulation
{
    internal class Ogrenci
    {
        private int vize;//bu feild yapısı private olarak tanımlandığı için dışarıdan erişilemez
        private int final;//dışarıdan erişmek için kapsülleme yapısı ile kontrollü bir erişim sağlarız

        public int _Vize//
        {
            get { return vize; }
            set
            {
                if (value>=0&&value<=100)
                {
                    vize = value;
                }
                else
                {
                    Console.WriteLine("0-100 arasında bir değer giriniz");
                    vize = 0;
                }
            }
        }
        public int _Final
        {
            get { return final; }
            set
            {
                if (value>=0&&value<=100)
                {
                    final= value;
                }
                else
                {
                    Console.WriteLine("0-100 arasında bir değer giriniz");
                    final= 0;
                }
            }
        }

        public double Ortalama
        {
            get { return vize* 0.4+final*0.6; }//sadece var olan değeri okur
        }
    }
}
