using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_OOP_Diamond_Problem
{
    internal class Insan : YuruyenNesne//insan yüzede bilir fakat burada miras alamaz. muthable inheritance yoktur classlarda
    {
        public override void HareketEt()
        {
            Console.WriteLine("Insanım Hareket ederim");
        }

        public override void Yuru()
        {
            Console.WriteLine("Insan Yürüyor");
        }
    }
}
