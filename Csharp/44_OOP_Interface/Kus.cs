using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_OOP_Interface
{
    internal class Kus : Canli, IYuzenNesne, IYuruyenNesne, IUcanNesne
    {
        public override void HareketEt()
        {
            Console.WriteLine("Ben kuşum hareket ederim");
        }

        public void Uc()
        {
            Console.WriteLine("Ben kuşum uçarım");
        }

        public void Yuru()
        {
            Console.WriteLine("Ben kuşum yürürüm");
        }

        public void Yuz()
        {
            Console.WriteLine("Ben kuşum yüzerim");
        }
    }
}
