using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_OOP_Inheritance_2
{
    internal class B:A
    {
        public int b { get; set; }

        public B()
        {
            Console.WriteLine("B Sınıfı Ctor ");
            //MyProperty = 1; a sınıfından miras aldığı için Mypropertye erişebilirim
        }

    }
}
