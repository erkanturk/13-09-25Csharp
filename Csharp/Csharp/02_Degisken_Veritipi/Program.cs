namespace _02_Degisken_Veritipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler
            /* Değişkenler:Program tarafında Data(veri) tutmak,taşımak veya bir işlem uygulamak 
             * için kullanılan yapılardır.
             * kullanıcıdan alınan değerleri geçici olarak içerisinde barındırabilir
             * veya sabit bir değer olarak tutabilir.

            */
            //erkan sistem bu yapıyı algılamaz burada bir veritipi belirmemiz ve bu veri tipine bağlı
            //bir değişken oluşturmamız gerekmektedir.
            //Console.WriteLine("Erkan");
            //string metin = "Erkan";//string Metinsel verileri tutan veri tipidir
            //Console.WriteLine(metin);
            ////string metin aynı isimde birden fazla değişken oluşturmayız zaten olan bir yapı olduğu için hata verir
            //metin="Türk";//Var olan bir değeri güncelliyoruz aynı değeri tekrar tanımlamıyoruz.
            //Console.WriteLine(metin);
            ////!!!!C# büyük küçüğe duyarlı bir dil yapısıdır Büyük A ile a birbirlerine eşit değildir.
            //string Metin = "Yazilim";// metin ve Metin birbirlerinden ayrı değişkenlerdir.

            //char harf = 'A';
            //Console.WriteLine(harf);//Ascii table da A ile a karakterinin değerleri farklıdır
            //Console.WriteLine((int)harf);//burada casting işlemi ile tür dönüşümü yaparak A karakterinin sayısal değerini alıyoruz.

            //Metinsel tipler
            //string,char
            //Sayısal tipler
            /*
             * int tam sayı alan veri yapısı 10 karaktere kadar değer tutabilir
             * long tam sayı tipinde 19 karaktere kadar değer tutabilir
             * byte tam sayı tipinde en küçük değer alan veri yapısıdır 0 ila 255 arasında değer tutar
             * float küçük ondalıklı sayı tipidir 10.5 f ifadesi ile tanımlamamız gerekiyor
             * double 16 haneye kadar ondalıklı sayı tutar 
             * decimal 19 haneye kadar ondalıklı sayı tutabilen en uzun yapıdır.             
             
             */
            // bool karşılaştırma true false olarak değer tutar
            //Datetime tarih zaman değerlerini tutar
            //Object her değeri nesne olarak tutar ve içerisinde her tipi barındırır.
            // var aldığı veri tipine göre şekillenir.

            Console.WriteLine("Value type stack(ram'in sol bölgesinde tutulur.)");
            Console.WriteLine($"int max {int.MaxValue} int min {int.MinValue} ");// $ string interpolation yazım biçimi
            Console.WriteLine($"byte max {byte.MaxValue} byte min {byte.MinValue}");
            Console.WriteLine($"long max {long.MaxValue} long min {long.MinValue}");
            Console.WriteLine($"float max {float.MaxValue} float min {float.MinValue}");
            Console.WriteLine($"double max {double.MaxValue} double min {double.MinValue}");
            Console.WriteLine($"decimal max {decimal.MaxValue} byte min {decimal.MinValue}");

            int sayi = 1234567891;//maksimum 10 karakter alır.
            decimal sayi2 = 10.5m;
            float sayi3 = 10.11f;
            double sayi4 = 11.99;
            long uzunSayi = 123;
            Console.WriteLine("referance type (heap ram'in sağ bölümü)");
            //string,object
            bool dogruMu = true;
            DateTime tarih = DateTime.Now;
            object obj = "test";
            object obj2 = 10;//her değeri nesne olarak tutar

            var deger = 10;
            var deger2 = "Merhaba c#";

            const double Pi = 3.14;//const ile bir değeri değiştirilemez kılarız ilk verilen değer asla güncellenemez

            /*Syntax
             * SnakeCase=>ad_soyad;
             * CamelCase=>adSoyad;
             * PascalCase=>AdSoyad;
             * KebabCase=>ad-soyad;
             * LowerCase=>adsoyad;
             * UpperCase=>ADSOYAD;
             * !!!!Yanlış yazım biçimleri
             * 2sayi ,?sayi,!sayi,ad soyad,ad!soyad,sayi? v.b türkçe karakterlerde kullanmamamız gerekiyor İ,ı,Ü,ü,ö,Ö,ç,Ç,Ğ,ğ,ş,Ş gibi karakterler de kullanmamalıyız.
             * Doğru kullanım
             * sayi2,_sayi,adSoyad,ad_soyad,sayi_
             * Yazılım dillerinde kabul edilen tek özel karakter _ çizgidir.


            */


        }
    }
}
