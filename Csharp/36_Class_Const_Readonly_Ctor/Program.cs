namespace _36_Class_Const_Readonly_Ctor
{
    internal class Program
    {
        public readonly int deger = 50;//readonly ile tanımlanan değişkenlerin değeri sadece tanımlandığı yerde veya constructor içerisinde değiştirilebilir
        static void Main(string[] args)
        {
            //int sayi = 10;
            //sayi=20;
            //Console.WriteLine(sayi);
            //const int sabitSayi = 30;
            ////sabitSayi = 40;//const ile tanımlanan değişkenlerin değeri sonradan değiştirilemez
            //Console.WriteLine(sabitSayi);
            //deger=100;
            //Console.WriteLine(deger);

            ConstTest constTest = new ConstTest();
            //constTest.pi;//Degere nesne üzerinden erişilemez sınıf üzerinden erişilir
            //Console.WriteLine(ConstTest.pi);//Sadece okunabilir 

            ReadOnlyTest readOnlyTest = new ReadOnlyTest();
            //readOnlyTest.Deger;
            //readOnlyTest.deger = 100;//readonly ile tanımlanan değişkenlerin değeri sadece tanımlandığı yerde veya constructor içerisinde değiştirilebilir
            //Console.WriteLine(readOnlyTest.deger);
        }
    }
}
