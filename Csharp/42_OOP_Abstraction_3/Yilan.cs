using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_OOP_Abstraction_3
{
    internal class Yilan : Canli
    {
        public override void HareketEt()
        {
            //base.HareketEt();abstract ve polymorphism arasındaki farklardan biri abstract de base yapısı kullanılamaz.
            Console.WriteLine("Yılan Sürünür");
        }
    }
}
