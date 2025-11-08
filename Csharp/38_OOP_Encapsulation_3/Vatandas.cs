using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_OOP_Encapsulation_3
{
    internal class Vatandas
    {
        private string AdSoyad;
        private long TcNo;

        public string _AdSoyad
        {
            get { return AdSoyad; }
            set
            {
                if (value.Length>0&&value.StartsWith("A"))
                {
                    AdSoyad = value;
                    Console.WriteLine(AdSoyad);
                }
                else
                {
                    Console.WriteLine("Ad a ile başlamalıdır ve minimum uzunluğu 1 olmalıdır");
                }
            }
        }
        public long _TcNo
        {
            get { return TcNo; }
            set
            {
                if (value.ToString().Length==11)
                {
                    TcNo = value;
                    Console.WriteLine(TcNo);
                }
                else
                {
                    Console.WriteLine("Tc no 11 haneli olmalıdır");
                }
            }
        }
    }
}
