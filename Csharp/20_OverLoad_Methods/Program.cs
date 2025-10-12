namespace _20_OverLoad_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* OverLoad Methods
             * İmza tipleri farklı isimleri aynı olurlar
             * Aynı imza tipinin aynı varyasyonunu barındıramazlar
             * Hangi yapı kullanılacak ise overload method devreye girer 
             * imza tipleri int double decimal bool ArrayList List string int[] Class v.b yapılar imza olarak değerlendirilir
             * OverLoad yapısı aslında OOP Dediğimiz Object Oriented Programing Tarafındaki Polymorphism(Çok biçimcilik) i destekler
             * Yani Statik çok biçimciliğe bir örnektir.

             */
            Kullan();
            Kullan("Merhaba OverLoad");
            Kullan("Merhaba C#", "Merhaba OverLoad");
            Console.WriteLine("Merhaba");
            Console.WriteLine(20+20);
            Console.WriteLine(true);
            /* 4 işlem yapacak bir method yapısı yapalım bu yapıda method ismi aynı olacak
             * 4 adet aynı isimde method biri toplama biri çıkarma biri çarpma biri bölme işlemi yapacak
             * IslemYap(x ,y)
             
             */
            IslemYap(20, 20);//Çıkarma
            IslemYap(20.5, 2);//Bölme
            IslemYap(20, 20.5);//Toplama
            IslemYap(20.5, 20.5);//Çarpma

        }
        static void IslemYap(int s, double s2)
        {
            Console.WriteLine(s+s2);
        }
        static void IslemYap(double s, double s2)
        {
            Console.WriteLine(s*s2);
        }
        static void IslemYap(double s, int s2)
        {
            Console.WriteLine(s/s2);
        }
        static void IslemYap(int s, int s2)
        {
            Console.WriteLine(s-s2);
        }
        static void Kullan()
        {
            Console.WriteLine("Merhaba OverLoad");
        }
        static void Kullan(string metin)
        {
            Console.WriteLine(metin);
        }
        static void Kullan(string metin, string metin2)
        {
            Console.WriteLine(metin+" "+metin2);
        }

    }
}
