namespace _39_OOP_Inheritance_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A a = new A();
            //a.MyProperty=10;//sadece miras almış sınıflar protected yapıya erişebilirler onun dışında erişilemez
            //C c = new C();
            //c.b=10;
            //c.c=20;
            D d = new D(); //A sınıfından başlayarak miras alanlardaki ctorlar çalışacaktır.
            d.c = 1;
            d.b = 2;

            d.Yaz();
        }
    }
}
