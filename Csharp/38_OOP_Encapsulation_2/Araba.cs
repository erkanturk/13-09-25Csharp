using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_OOP_Encapsulation_2
{
    internal class Araba
    {
        private double hiz;
        private const double maxHiz = 250;

        public double _Hiz
        {
            get { return hiz; }
            
            set
            {
                if (value>=0&&value<=maxHiz)
                {
                    hiz= value;//Kullanıcı doğru bir değer girerse girdiği hız değeri güncellenecek
                }
                else
                {
                    Console.WriteLine($"Hız 0 ila {maxHiz} arasında olmalıdır");
                    hiz=0;
                }
            }
        }

        public void Hizlanma(double artis)
        {
            

            if (hiz>=0&&hiz<=maxHiz)
            {
                hiz+=artis;
                if (hiz!=0&&hiz<=maxHiz)
                {
                    
                    Console.WriteLine($"Hızınız {this.hiz} km/s olarak ayarlandı");
                }
                if (hiz==0)
                {
                    Console.WriteLine("Arabayı çalıştırın");
                    return;
                }
                if (hiz>maxHiz)
                {
                    hiz=maxHiz;
                    Console.WriteLine($"Arabanızda limitör vardır maksimum {this.hiz} km/s olarak ayarlandı");
                }
              
                

            }
           
        }
        public void Yavaslama(double azalis)
        {
            if (hiz>0&&hiz<=maxHiz)
            {
               
                hiz-=azalis;
                Console.WriteLine($"Hızınız {this.hiz} km/s olarak ayarlandı");
            }
            if (hiz==0)
            {
                hiz=0;
                Console.WriteLine($"Arabanız Durdu");
            }
           
        }
    }
}
