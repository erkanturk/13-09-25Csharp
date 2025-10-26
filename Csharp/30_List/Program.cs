namespace _30_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* List
             * Generic Typlar barındıran ve bu tiplere göre içinde elemanlar tutan bir koleksiyon yapısıdır.
             * Çalışma prensibi Fifo
             * ArrayList gibi her tipi içerisinde barındıramaz Type safe bir yapıdadır
             * DataProtected bir yapıdır
             * hangi tipte olması gerektiğini belirtmemiz gerekmektedir
             * Bir sınırı yoktur
             * <> Generic yapılarda kullanılır ve tanımlama sırasında hangi veri tipi ile çalışacağını belirtmemiz gerekmektedir.

             */
            #region Örnekler ve Linq
            //List<string> liste = new List<string>();//Boş bir liste yapısı
            //liste.Add("Öğrenci 1");
            //liste.Add("Öğrenci 2");
            //liste.Add("Öğrenci 3");
            //liste.Add("Öğrenci 4");
            //liste.Add("Öğrenci 5");
            //liste.Add("Öğrenci 6");
            //liste.Add("Öğrenci 7");
            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}
            //List<int> ints = new List<int>() { 1, 2, 4, 5, 7, 10, 15, 20 };

            //foreach (var item in ints)
            //{
            //    Console.WriteLine(item);
            //}

            //int bul = ints.Find(x => x == 20);//Find ile koşullu bir şekilde arama yaparız =>lambda ile her bir elemana bakarız ve eşit olan değer varsa find yapısı bulur ve bize getirir Linq arama yapısıdır.

            //Console.WriteLine(bul);

            // List<int> yaslar = new List<int>() { 30, 40, 50, 60, 25, 18, 19, 20, 21, 20, 22, 23, 24, 25, 26, 27 };

            //Where bir koşul yapısıdır =>Lambda ise her bir değeri koşula uygun bir biçimde sorgulamamızı sağlar
            //Eğer yaşı 30 dan büyük bir değer varsa bu kayıtlar birden fazlada olabilir
            //Bu kayıtları bana liste halinde getirmesi için .ToList yapısını kullanırız.
            //List<int> otuzdanBuyukYaslar = yaslar.Where(x => x>=30).ToList();

            //foreach (var item in otuzdanBuyukYaslar)
            //{
            //    Console.WriteLine(item);
            //}


            //double ortalama = yaslar.Average();//yaşlar listesinin ortalaması
            //double toplam = yaslar.Sum();
            //Console.WriteLine(toplam);//Toplam değeri
            //Console.WriteLine(ortalama);
            //yaslar.Sort();
            //yaslar.ForEach(x => Console.WriteLine(x));

            //int index = yaslar.FindIndex(y => y==20);
            //Console.WriteLine(index);
            //int deger = yaslar.FirstOrDefault(y => y==20);//İlkini veya varsayılanını getir.
            //Console.WriteLine(deger);
            //var deger2 = yaslar.Max();//Maksimum değer
            //int deger3 = yaslar.Min(x => x);//Minimum değer
            //int deger4 = yaslar.Count();//Toplam eleman sayısı
            //Console.WriteLine(deger2);
            //Console.WriteLine(deger3);
            //Console.WriteLine(deger4);
            //Console.WriteLine(yaslar.Count);
            //int[] sayilar = new int[yaslar.Count];
            //sayilar.Count();
            //int[] sayi2 = new int[sayilar.Length];
            #endregion
            #region Örnek2
            //Kisi kisi = new Kisi();//Instance örneklem nesne oluşturma
            //kisi.Ad="Erkan";
            //kisi.Soyad="Türk";
            //kisi.Yas=31;

            //Console.WriteLine(kisi.Ad+" "+kisi.Soyad);
            //Kisi kisi2 = new Kisi();//Instance örneklem nesne oluşturma
            //kisi2.Ad="Tahsin";
            //kisi2.Soyad="Canpolat";
            //kisi2.Yas=34;

            //Kisi kisi3 = new Kisi();//Instance örneklem nesne oluşturma
            //kisi3.Ad="Altan Emre";
            //kisi3.Soyad="Demirci";
            //kisi3.Yas=36;

            //List<string> list = new List<string>();
            //list.Add(kisi.Ad);
            //list.Add(kisi.Soyad);
            ////list.Add(kisi.Yas); string bir liste olduğu için hata verir

            //list.Add(kisi2.Ad);
            //list.Add(kisi2.Soyad);

            //list.Add(kisi3.Ad);
            //list.Add(kisi3.Soyad);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Kisi> kisiler = new List<Kisi>();//Kişi sınıfını temsil eden bir liste olduğu için 
            ////her bir niteliği bana dönderir yani int datetime bool farketmeksizin her veriyi kişi olarak bize dönderecektir.
            //kisiler.Add(kisi);
            //kisiler.Add(kisi2);
            //kisiler.Add(kisi3);

            //foreach (Kisi item in kisiler)//Kişi tipinde kişi dönderen bir döngü
            //{
            //    Console.WriteLine(item.Ad+" "+item.Soyad+" "+item.Yas);
            //}

            //foreach (var item in kisiler)//var olarak değişken değerler döndüren bir döngü
            //{
            //    Console.WriteLine(item.Ad+" "+item.Soyad+" "+item.Yas);
            //}
            //List<Kisi> kisis = new List<Kisi>()
            //{
            //    new Kisi(){Ad="Onur",Soyad="Yağız",Yas=32},
            //    new Kisi(){Ad="Baki",Soyad="Yaılmazer",Yas=33},
            //    new Kisi(){Ad="Furkan",Soyad="Uçan",Yas=25},
            //    new Kisi(){Ad="Hüseyin",Soyad="Polat",Yas=32},

            //};
            //kisis.ForEach(x => Console.WriteLine(x.Ad+" "+x.Soyad+" "+x.Yas));

            Kisi kisi = new Kisi();
            Console.WriteLine("Adınız");
            kisi.Ad=Console.ReadLine();
            Console.WriteLine("Soyadınız");
            kisi.Soyad=Console.ReadLine();
            Console.WriteLine("Yaşınız");
            kisi.Yas=Convert.ToInt32(Console.ReadLine());

            List<Kisi> list = new List<Kisi>();
            list.Add(kisi);

            foreach (var item in list)
            {
                Console.WriteLine(item.Ad+" "+item.Soyad+" "+item.Yas);
            }

            #endregion
        }

    }
    class Kisi
    {
        public string Ad;//nitelik Property
        public string Soyad;
        public int Yas;
    }
}
