using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_OOP_Inheritance_2
{
    internal class A
    {
        protected int MyProperty { get; set; }

        public A()
        {
            Console.WriteLine("A sınıfının Yapıcı methodu");
        }
        public void Yaz()
        {
            Console.WriteLine("Parrent Sınıf A");
        }
    }
}
