using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_OOP_Inheritance_2
{
     internal sealed class D:C
    {
       
        public D()
        {
            Console.WriteLine("D sınıfı ctor");
            MyProperty = 1;
        }
    }
}
