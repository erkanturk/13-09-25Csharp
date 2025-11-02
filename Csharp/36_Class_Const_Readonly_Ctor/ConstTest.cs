using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Class_Const_Readonly_Ctor
{
    internal class ConstTest
    {
        public const double pi = 3.14;//const ile tanımlanan değişkenlerin değeri sonradan değiştirilemez
        //eğer const ile tanımlanan bir değer var ise initilize edilirken değeri verilmek zorundadır ve bu değer sonradan değiştirilemez
        public ConstTest()
        {
            //pi= 3.1415;//hata verir
            Console.WriteLine(pi);
        }
    }
}
