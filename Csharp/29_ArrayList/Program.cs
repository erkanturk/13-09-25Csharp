using System.Collections;

namespace _29_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ArrayList
             * Arraylistler içerisinde sınırsız sayıda veri tutabilen koleksiyon yapılarıdır
             * Uzunluk miktarı 2 üzeri n olarak artabilir bir sınırlandırma yoktur
             * Yapıyı tanımlarken bir veri tipi belirtmeye gerek yoktur veya bir uzunluk değeri vermeye gerek yoktur
             * Tüm veri tiplerini içerisinde barındırabilir (boxing unboxing işlemi yapar) bu yüzden performans kaybı yaşanabilir type safe değildir
             * System.Collections namespace i altında tanımlanmıştır

             */
            #region Boş ArrayList Tanımlama
            ArrayList arrayList = new ArrayList();//boş arraylist tanımlandı
            arrayList.Add(100);//int veri tipi eklendi
            arrayList.Add("Merhaba");//string veri tipi eklendi
            arrayList.Add(45.5);//double veri tipi eklendi
            arrayList.Add('A');//char veri tipi eklendi
            arrayList.Add(true);//bool veri tipi eklendi
            arrayList.Add(DateTime.Now);//DateTime veri tipi eklendi
            object obj = 1234;//Boxing işlemi
            int sayi=obj is int ? (int)obj : 0;//Unboxing işlemi
            int sayi2 = (int)obj;//Unboxing işlemi


            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region Dolu ArrayList Tanımlama
            //ArrayList arrayList = new ArrayList() { 100, "Merhaba", 45.5, 'A', true, DateTime.Now };
            //arrayList.Add("Erkan");
            //arrayList.Add("TEst");
            //arrayList.Add("TEst2");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(arrayList.Count);//ArrayList içerisindeki eleman sayısını verir
            //Console.WriteLine(arrayList.Capacity);//ArrayList in kapasitesini verir bir sınırı yoktur 2 üzeri n olarak artar
            //arrayList[0]=175000;//İndex ile erişim sağlanabilir ve değer değiştirilebilir
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Bir array list yapın bu yapıya 'A' dan başlayarak 'z' eşit olana kadar tüm yapıları ekleyin ve döndürün
            //ArrayList liste = new ArrayList();
            //for (char i = 'A'; i<='z'; i++)
            //{
            //    liste.Add(i);//Tekli ekleme yöntemi 
            //    int sayi = Convert.ToInt32(i);//unicode karşılığını alıyoruz
            //    liste.Add(sayi);
            //}
            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}
            /* liste.AddRange(new ArrayList { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' });*///Çoklu ekleme yöntemi
                                                                                                                                                                                    //foreach (var item in liste)
                                                                                                                                                                                    //{
                                                                                                                                                                                    //    Console.WriteLine(item);
                                                                                                                                                                                    //}
                                                                                                                                                                                    // int[] sayilar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                                                                                                                                                                                    //liste.AddRange(sayilar);//Dizi ekleme yöntemi
                                                                                                                                                                                    //foreach (var item in liste)
                                                                                                                                                                                    //{
                                                                                                                                                                                    //    Console.WriteLine(item);
                                                                                                                                                                                    //}
                                                                                                                                                                                    // liste.AddRange(new ArrayList { sayilar[5], sayilar[8], sayilar[3] });
                                                                                                                                                                                    //foreach (var item in liste)
                                                                                                                                                                                    //{
                                                                                                                                                                                    //    Console.WriteLine(item);
                                                                                                                                                                                    //}
            #endregion
            #region Arraylist Methodları
            //ArrayList list = new ArrayList();
            //list.Add(10);//Tekli ekleme yöntemi
            //list.AddRange(new ArrayList() { 20, 30, 40 });//Çoklu ekleme yöntemi
            ////!!!Insert!!!
            //list.Insert(0, 50);
            ////foreach (var item in list)
            ////{
            ////    Console.WriteLine(item);
            ////}
            ////list.Clear();//Tüm listeyi temizler
            ////foreach (var item in list)
            ////{
            ////    Console.WriteLine(item);
            ////}
            ////!!InsertRange!!
            //list.InsertRange(1, new ArrayList() { "Erkan", "Tahsin", "Altan", "Onur", "Furkan", "Furkan", "Erkan" });
            ////Dondur(list);
            ////!!Remove!!
            ////list.Remove("Erkan");//Value ya göre siler
            ////Dondur(list);
            ////list.RemoveAt(0);//index e göre siler
            ////Dondur(list);
            ////list.RemoveRange(1, 3);//1.indexden başla 3 eleman sil
            ////Dondur(list);

            ////IndexOf
            //int index = list.IndexOf("Erkan");//ilk bulduğu indexi getirir
            //int index3 = list.IndexOf("Erkan", 2);//başlangıç değerinden sonra ilk bulduğu indexi getirir
            //Console.WriteLine(index);
            //Console.WriteLine(index3);
            //int index2 = list.LastIndexOf("Erkan");//Sondan bakarak ilk bulduğunu getirir
            //int index4 = list.LastIndexOf("Erkan", 6);//Sondan bakarak ilk bulduğunu getirir
            //Console.WriteLine(index2);
            //Console.WriteLine(index4);
            //ArrayList list2 = new ArrayList() { 100, 20, 30, 40 };
            //list.Reverse();
            ////list2.Sort();//ArrayList yapısı type safe olmadığı için neye göre sıralayacağını karıştırıyor stringe göremi metne göre mi sıralayacak

            //Dondur(list2);
            //Dondur(list);
            //Console.WriteLine(list.GetType().ToString()); //tip gösterme  
            //Console.WriteLine(list.Contains("Erkan"));

            ////Console.WriteLine(list2);

            #endregion
            /*Kullanıcıdan sayı isteyelim Sayı verdiği sürecede toplama işlemi yapalım  sayı yerine Q ya basarsa çıkış işlemi yapalım girilen sayıların yoplamını ekrana yazdırsın*/
            //ArrayList list = new ArrayList();
            //int toplam = 0;

            //while (true)
            //{
            //    Console.WriteLine("Sayı giriniz Çıkmak için Q ya basınız");
            //    string sayi = Console.ReadLine();
            //    if (int.TryParse(sayi, out int s))
            //    {
            //        toplam+=s;
            //        list.Add(s);
            //    }
            //    else if (sayi=="Q")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı işlem");
            //    }
            //}
            //Console.WriteLine("Sayıların toplamı: "+toplam);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            // Scopsuz if ve kısa if else kullanımı

            //if (true)
            //    Console.WriteLine("Merhaba");//if içi
            //Console.WriteLine("İf dışı");

            //ArrayList arrayList = new ArrayList() { "Ahmet", "Erkan", 10, 'A', true };
            //Console.WriteLine(arrayList.Contains("Tahsin")?"Var":"Yok");//? Eğer (if) :değilse(else) ternary operators


        }
        static void Dondur(ArrayList list)
        {
            Console.WriteLine("*********");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
