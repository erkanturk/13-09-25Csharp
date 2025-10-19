namespace _22_Methods_Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Summary Developarların bilgilendirme için kullandığı yapıdır
            /* Params Methods
             * Bir method belirtilen sayıda parametre alır fakat bu yapıyı özelleştirebiliriz
             * Params keywordü ile methodun alacağı parametre sayısı sınırsız olabilir
             * Params keywordü methodun imzasında en son parametre olarak belirtilmelidir
             * Bir methodda sadece bir tane params keywordü kullanılabilir
                
             */
            // Yazdir(10, 20,50);//Hata verir method 2 parametrelidir.
            //YazdirParams(25.5,50,45,35,75,25,4,96,547,68,647,697,147,697,147);
            //Sınırsız sayıda parametre göndermemizi sağlar
            //YazdirParams(30.5);//bu şekilde zorunlu olan double parametreyi vermemiz yeterlidir.
            //YazdirParams();//Bu şekilde de çağırabiliriz.
            //int[] sayilar = { 10, 20, 30, 40, 50 };//params yapısına gönderilen dizi system.int[] diye görünür.
            //ParamsliMethod("Params", DateTime.Today, true, false, 'A', 20.5, 22.5f, 23.6m, 15, sayilar);

            //Kullanıcıdan 10 adet sayı alalalım ve bu sayıları ParamsliMethod a gönderelim
            //Kullanıcının girdiği sayıları toplatalım ve ekrana yazdıralım
            //double[] sayilar = new double[10];

            //for (int i = 0; i<10; i++)
            //{
            //    Console.WriteLine($"{i+1}.Sayıyı giriniz");
            //    double sayi = Convert.ToDouble(Console.ReadLine());
            //    sayilar[i]=sayi;
            //}
            //ParamsliMethod2(sayilar);
            //int[] dizi = { 10, 20, 30, 40, 50 };
            //int[] dizi2 = { 10, 20, 30, 40, 50 };
            //DiziliMethod4(dizi);//Dizi alan method;
            //                    // DiziliMethod4(10, 20, 30, 40, 50, 60);//Bu yapıda her biri birer parametre olarak değerlendirilir.
            //ParamsliMethod5(dizi, dizi2);
            //ParamsliMethod3(dizi);
            //ParamsliMethod3(100, 200, 300, 400, 500, 600);//Bu yapıda her biri birer parametre olarak değerlendirilir.
            // Yazdir(10, 20, 30, 40, 50, 60);
            ParamsliMethod3(100,2000,3333,4444,5555,99999,7777,5555,6666,7777,6666,8888);

        }

        static void Yazdir(int sayi, int sayi2)
        {
            Console.WriteLine(sayi+sayi2);
        }
        static void YazdirParams(double sayi, params int[] paramsli)
        {
            Console.WriteLine(sayi);
            foreach (var item in paramsli)
            {
                Console.WriteLine(item);
            }
        }
        static void YazdirParams(params int[] paramsli)
        {

            foreach (var item in paramsli)
            {
                Console.WriteLine(item);
            }
        }
        
        static void ParamsliMethod(params object[] objeler)
        {
            foreach (var item in objeler)
            {
                Console.WriteLine(item);
            }
        }
        static void ParamsliMethod2(params double[] objeler)
        {
            double toplam = 0;
            foreach (var item in objeler)
            {
                toplam += item;
            }
            Console.WriteLine(toplam);
        }
        /// <summary>
        /// Bu method int dizisi alır ve elemanlarını ekrana yazdırır
        /// </summary>
        /// <param name="dizi"></param>
        static void DiziliMethod4(int[] dizi)
        {
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// Bu method params ile int dizisi alır ve elemanlarını ekrana yazdırır
        /// </summary>
        /// <param name="dizi"></param>
        static void ParamsliMethod3(params int[] dizi)
        {
            for (int i = 0; i<3; i++)
            {
                dizi[i]*=2;
            }
            for (int i = 3; i<6; i++)
            {
                dizi[i]*=3;
            }
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// bu method bir int dizisi ve params ile bir int dizisi alır ve elemanlarını ekrana yazdırır
        ///<see href="Https://www.w3schools.com"/>
        /// </summary>
        /// <param name="dizi"></param>
        /// <param name="dizi2"></param>
        static void ParamsliMethod5(int[] dizi ,params int[] dizi2)
        {
            foreach (var item in dizi2)
            {
                Console.WriteLine(item);
            }
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
