using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_OOP_Interface
{
    internal class Balik : Canli,IYuzenNesne
    {
        public override void HareketEt()
        {
            Console.WriteLine("Ben balığım hareket ederim");
        }

        public void Yuz()
        {
            Console.WriteLine("Ben balığım yüzerim");
        }
    }
}
