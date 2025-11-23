namespace _45_Generic_Type_Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun<double> urun = new Urun<double>(15.5, 22.2);
            Console.WriteLine(urun.Value+" "+urun.Value2);

            Urun<string, char> urun1 = new Urun<string, char>("Merhaba Char", 'A');
            Console.WriteLine(urun1.Value+" "+urun1.Value2);

            Urun<decimal, string> urun2 = new Urun<decimal, string>(10.5m, "Sayısı");

            Console.WriteLine(urun2.Value+" "+urun2.Value2);

            Urun<DateTime, string> urun3 = new Urun<DateTime, string>(DateTime.Now, "Gün saat Bilgisi");
            Console.WriteLine(urun3.Value+" "+urun3.Value2);

            Urun<DateTime, DateTime> urun4 = new Urun<DateTime, DateTime>(DateTime.Now, DateTime.Today);
            Console.WriteLine(urun4.Value+" "+urun4.Value2);
        }
    }
}
