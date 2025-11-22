using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_Generic_Type
{
    internal class Test<T> //T generic bir yapı olduğunu temsil ediyor
    {
        public int NonGenericField;
        public T GenericField;//T yapısı tanimlandığı zaman tipi belirtilmek zorundadır.

    }
}
