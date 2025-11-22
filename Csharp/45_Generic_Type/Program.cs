namespace _45_Generic_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Generic Mimari
             * Aynı tasarımda farklı objelerin üretilmesine imkan sağlayan
             * C# mimarisi için çok önemli bir yapıdır.
             * Generic mimari olmasa kod yazmak zorlaşırdı ve tekrar eden kodlar artardı 
             * Tip güvenliği çok azalırdı ileride göreceğimiz linq yapısı diye ileri sorgulama yapısı olmazdı.
             * Type safe yapıyı zorunlu kılıyor ve mimarinin daha güvenli çalışmasına olanak tanıyor ve optimizasyon sürecinide destekliyor.

             */

            Test<double> test = new Test<double>();
            test.NonGenericField=20;//generic bir yapı değil o yüzden sadece int değer alır
            test.GenericField=25.5;
            Test<char> test1 = new Test<char>();
            //Generic sınıfı ilk yazarken T olarak bırakırız ve bu sınıf tanımlanırken T yerine gelecek değeri tanımlanırken belirtiriz.
            test1.GenericField='A';

            Urun<int> urun = new Urun<int>(10, 10);
            Urun<string> urun1 = new Urun<string>("Merhaba", "Generic");


        }
    }
}
