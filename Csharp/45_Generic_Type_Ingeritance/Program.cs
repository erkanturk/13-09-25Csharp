namespace _45_Generic_Type_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChildClass childClass = new ChildClass();
            childClass.Value="merhaba";
            //childClass.Value=10;//tanımlanırken string belirtildi
            childClass.Deger='A';

            ChildClass2<char> childClass2 = new ChildClass2<char>();
            childClass2.Value='A';
            childClass2.Test='A';
            ChildClass2<decimal> childClass3 = new ChildClass2<decimal>();
            childClass3.Value=10.5m;
            childClass3.Test=10.5m;

            ChildClass3<DateTime> childClass4 = new ChildClass3<DateTime>();
            childClass4.Value=50;
            childClass4.Test2=DateTime.Now;
        }
    }
    class BaseClass<T>
    {
        public T Value { get; set; }
    }
    class ChildClass : BaseClass<string>//Base classta bulunan value string bir değer alacağını söyledik
    {
        public char Deger { get; set; }
    }
    class ChildClass2<T> : BaseClass<T>
    {
        public T Test { get; set; }
    }
    class ChildClass3<T> : BaseClass<int>//base class mutlaka int tipinde olacak
    {
        public T Test2 { get; set; }
    }
}
