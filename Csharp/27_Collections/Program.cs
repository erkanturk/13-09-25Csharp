using System.Collections;

namespace _27_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Koleksiyon yapıları
             * Arraylere benzer olarak içerisinde birden fazla veriyi barındırabilen  data yapılarıdır
             * string[], int[] char[] gibi arrayler sadece ilgili data tipini tutarken
             * Collections yapıları daha spesifik ve karmaşık  yapılarıda beraber birden çok data tipini içinde 
             * barındırabilir
             * ICollections=>Koleksiyon yapılarının temel arayüzüdür => System.Collections
             * ArrayList, Hashtable, Queue, Stack, SortedList,List(generic) bu yapılar ICollections arayüzünden türemiştir.
             * Bu yapıların hepsind Dizi yapısı gibi sabit uzunluk değeri verilmesine gerek yoktur
             * 2 üzeri n olarak büyüyebilirler
             * Arraylist yapısı boxing unboxing işlemi yapar bu yüzden performans kaybı yaşanabilir
             * Arraylist yapısı Type Safe değildir (Tip güvenliği yoktur) Her veri tipini içerisinde barındırabilir.
             * Queue ve Stack yapıları FIFO ve LIFO mantığı ile çalışır Queue (First in First out) ilk giren ilk çıkar
             * Stack (Last in First out) son giren ilk çıkar
             * Hastable Dictionary yapısına benzer düzensiz tablo key value mantığı ile çalışır
             * SortedList Düzenli Liste Dictionary yapısındadır sözlük yapısı gibi key value mantığı ile çalışır
             
            */
            #region Ödev SortedList Tr-En Sözlük
            /*
          sözlük uygulaması istenmektedir.Tr - Eng
       sözlük = { "siyah":"black",,,,}
          kullanıcı 4 girene kadar sorulur.
           1 - Arama
           2 - Çıkarma
           3 - Listeleme
           4 - Çıkış

      Kullanıcı 1'e basarsa ->
          - Aranacak olan kelimeyi giriniz:
          -Bu kelime dizide varsa eng karşılığı yazılır.
          -Yoksa uygulamanın gelişmesine yardımcı olmak ister msiniz(E-H):
              -E ise bu kelimenin karşılığı istenir ve sözlüğe eklenir
              -H ise bişey yapılmaz
      Kullanıcı 2'ye basarsa ->
          - Çıkarılmak istenen kelime :
          -Kelime sözlükte varsa çıkartılır
          - Yoksa uyarı verilir.
      Kullanıcı 3'e basarsa ->
          - Tum key value lar listelenir
          -KEY->VALUE
      Kullanıcı 4'e basarsa ->
          - Döngü sonlanır.
           */
            #endregion
            #region Queue Kuyruk çalışma prensibi
            //Queue kuyruk = new Queue();//alt+enter ile using system.collections eklenir
            //kuyruk.Enqueue("Birinci");//İlk giren birinci
            //kuyruk.Enqueue("İkinci");
            //kuyruk.Enqueue("Üçüncü");
            //kuyruk.Enqueue("Dördüncü");//Son giren dördüncü

            //foreach (var item in kuyruk)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("*************");
            //kuyruk.Dequeue();//İlk giren birinci çıkar
            //foreach (var item in kuyruk)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(kuyruk.Peek());//Kuyruğun en başındaki elemanı gösterir

            //kuyruk.Clear();//Kuyruğu temizler

            //Queue queue = new Queue();
            //queue.Enqueue("Erkan");
            //queue.Enqueue("Ali");
            //queue.Enqueue("Veli");
            //queue.Enqueue("Ayşe");
            //queue.Enqueue("Fatma");

            //for (int i = 5; i>=queue.Count; i--)//count bize toplam miktarını getirir.
            //{//Fifo mantığı ile çalışır
            //    Thread.Sleep(2000);
            //    Console.WriteLine($"{i}. sıradasınız");
            //    if (queue.Count==1)
            //    {
            //        Console.WriteLine("Sıra Sizde "+queue.Peek());
            //    }
            //    else
            //    {
            //      queue.Dequeue();

            //    }
            //}

            #endregion

            #region Stack Yığın çalışma prensibi
            //Stack stack = new Stack();
            //stack.Push("Birinci");//Son giren birinci
            //stack.Push("İkinci");
            //stack.Push("Üçüncü");
            //stack.Push("Dördüncü");//İlk giren dördüncü
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //stack.Pop();//Son giren birinci çıkar
            //Console.WriteLine("*************");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("**********");
            //Console.WriteLine(stack.Peek());
            //stack.Clear();//Yığını temizler

            #endregion

            #region SortedList Çalışma Prensibi
            /*Sözlük tabanlı bir koleksiyon yapısıdır  İçerisinde key value mantığı ile çalışır
             * Key değerleri benzersiz olmalıdır aynı değer birden fazla kez kullanılamaz
             * Key değerleri sıralı bir şekilde tutulur
             * Key değerleri null olamaz
             * Value değerleri null olabilir
             * Key değerleri aynı veri tipi üzerinden olmalıdır value'lar için böyle bir kısıtlama yoktur
             */
            //SortedList iller = new SortedList();//A>Z ye yada küçükten büyüğe sıralar
            //iller.Add(01, "Adana");
            //iller.Add(34, "İstanbul");
            //iller.Add(06, "Ankara");
            //iller.Add(35, "İzmir");
            //iller.Add(16, "Bursa");
            //iller.Add(44, "Malatya");
            //iller.Add(10, "Balıkesir");
            //iller.Add(55, "Samsun");
            //iller.Add(61, "Trabzon");
            //iller.Add(52, "Ordu");
            //iller.Add(05, "Amasya");
            //// iller.Add(05, "Test");//Hata verir aynı key değeri kullanılamaz
            ////iller.Add("05", "TEst");//Hata verir key değerleri aynı tipte olmalıdır
            //iller.Add(88, 98);

            //foreach (var item in iller)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("**************");
            //foreach (DictionaryEntry item in iller)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);//Key ve Value olarak ayırır
            //}
            //iller[01]="Adana Şehri";//Key değeri ile value ya ulaşılır ve güncellenir
            //iller[72]="Batman";//Böyle bir key yoksa ekleme yapar
            //Console.WriteLine("***********");
            //foreach (DictionaryEntry item in iller)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);//Key ve Value olarak ayırır
            //}
            //iller.Remove(88);//Key değeri ile silme işlemi yapılır
            //foreach (DictionaryEntry item in iller)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);//Key ve Value olarak ayırır
            //}
            //SortedList<int, string> genericSiraliListe = new SortedList<int, string>();
            //////int key tipi int dışında bir değer alamaz string value tipi string dışında bir değer alamaz
            //genericSiraliListe.Add(34, "İstanbul");
            //genericSiraliListe.Add(06, "Ankara");
            //genericSiraliListe.Add(35, "İzmir");

            ////Console.WriteLine(genericSiraliListe[06]);
            ////Console.WriteLine(genericSiraliListe.ContainsKey(34));//key var mı yok mu
            ////Console.WriteLine(genericSiraliListe.ContainsValue("Ankara"));//value var mı yok mu
            //foreach (var item in genericSiraliListe)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}

            //SortedList liste = new SortedList();
            //liste.Add("siyah", "black");
            //liste.Add("beyaz", "white");
            //liste.Add("kırmızı", "red");
            //liste.Add("mavi", "blue");
            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Hashtable Çalışma Prensibi
            /* Hashtable sözlük tabanlı bir koleksiyon yapısıdır İçerisinde key value mantığı ile çalışır
             * Düzensiz liste yapısıdır
             * Key ve valuelar farklı tiplerde olabilir
             * Bir key sadece bir defa kullanılabilir
             * Key gözetmeksizin bir liste oluşturacağımızda bize daha hızlı mantıksal erişim sağlar
             
             */

            //Hashtable x = new Hashtable();//Sıralama yapmaz random bir şekilde gösterir
            //x.Add(1, "Bir");
            //x.Add("iki", 2);
            //x.Add(true, "Üç");
            //x.Add("07", "Antalya");
            //x.Add(06, "Ankara");

            //foreach (var item in x)
            //{
            //    Console.WriteLine(item);
            //}
            //x.Remove(true);
            //x.Add(34, "İstabul");
            //x.Add('A', 'B');
            //Console.WriteLine("**************");
            //foreach (var item in x)
            //{
            //    Console.WriteLine(item);
            //}
           
            #endregion
        }
    }
}
