using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_OOP_Encapsulation_3
{
    internal class Islem
    {
        private double Sayi1;
        private double Sayi2;

        public double _Sayi1
        {
            get { return Sayi1; }
            set
            {
                if (value>0)
                {
                    Sayi1 = value;

                }
                else if (value<0)
                {
                    Console.WriteLine("Negatif bir sayı ile bölme işlemi yapamazsın");
                }
                else
                {
                    Console.WriteLine("Sayı sıfırdır bölünen 0 olamaz");
                }
            }
        }
        public double _Sayi2
        {
            get { return Sayi2; }

            set
            {
                if (value>Sayi1)
                {
                    Console.WriteLine("Bölen Bölünenden büyük olamaz");
                }
                else if (value==0)
                {
                    Console.WriteLine("Bölen 0 Olamaz");
                }
                else if (value<0)
                {
                    Console.WriteLine("Bölen Negatif olamaz");
                }
                else
                {
                    Sayi2 = value;
                    Console.WriteLine("Bölme işlemi sonucu: "+Sayi1/Sayi2);
                }
            }
        }
    }
}
