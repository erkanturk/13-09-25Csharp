using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Class_Const_Readonly_Ctor
{
    internal class ReadOnlyTest
    {
        private readonly int deger= 10;

        public ReadOnlyTest()
        {
            deger= 20;//readonly ile tanımlanan değişkenlerin değeri sadece tanımlandığı yerde veya constructor içerisinde değiştirilebilir
            Console.WriteLine(deger);
        }
        //deger=100;//hata verir readonly ile tanımlanan değişkenlerin değeri sadece tanımlandığı yerde veya constructor içerisinde değiştirilebilir
    }
}
