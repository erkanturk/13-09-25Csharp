namespace _18_Methods_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DegerAl();

            Console.WriteLine("Bir değer giriniz");
            string deger = Console.ReadLine();

            Console.WriteLine("ikinci değeri giriniz");
            string deger2 = Console.ReadLine();
            DegerAl2(deger,deger2);
        }
        static void DegerAl()
        {
            Console.WriteLine("Bir değer giriniz");
            string deger = Console.ReadLine();

            Console.WriteLine("ikinci değeri giriniz");
            string deger2 = Console.ReadLine();
            int s; int s2;
            if (int.TryParse(deger, out s)&&int.TryParse(deger2, out s2))
            {
                Console.WriteLine(s+s2);
            }
            else
            {
                Console.WriteLine(deger+" "+deger2);
            }

        }

        static void DegerAl2(string deger , string deger2)
        {
          
            int s; int s2;
            if (int.TryParse(deger, out s)&&int.TryParse(deger2, out s2))
            {
                Console.WriteLine(s+s2);
            }
            else
            {
                Console.WriteLine(deger+" "+deger2);
            }

        }
    }
}
