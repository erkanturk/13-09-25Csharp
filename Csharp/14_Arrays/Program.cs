namespace _14_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Array(Dizi) 
             * Değişkenlerin aksine index adı verilen numaralandırma sistemi ile tutulan birden fazla yapı tutan  koleksiyon yapısıdır.
             * string veri tipide aslıda bir array yapısıdır burada tutulan her karakter bir index numarası ile tutulur
             * Veritipi[] diziadi =new veritipi[dizi boyutu];//boş dizi tanımı
             * Veritpi[] diziAdi={değerler,değerler}//Dolu dizi tanımı
             * Index'ler 0 dan başlar ve 1'er 1'er artarak devam eder 

             */
            #region DiziYapısı
            //Boş dizi tanımı
            //string[] isimler = new string[5];//5 Eleman sayısını temsil eder index ise eleman sayısının -1 i dir.
            //isimler[0]= "Erkan";
            //isimler[1]="Kaan";
            //isimler[2]="Ömer";
            //isimler[3]="Aleyna";
            //isimler[4]="Rugiya";
            //isimler[5]="Süreyya"; hata verir eleman sayısı 5 fakat index sayısı 4 dür 5. index yok System.IndexOutOfRangeException

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}
            // string isim ="Erkan","Ali","Veli";//Hata verir

            //int index = 0;
            //while (index<isimler.Length)
            //{
            //    Console.WriteLine(isimler[index]);
            //    index++;
            //}
            //int index2 = 0;
            //do
            //{
            //    Console.WriteLine(isimler[index2]);
            //    index2++;
            //}
            //while (index2<isimler.Length);
            // Console.WriteLine(isimler[3]);//Tekli yazdırma işlemi

            //foreach (string isim in isimler)//koleksiyon döngü yapısı
            //{
            //    Console.WriteLine(isim);
            //}
            #endregion

            #region örnekler
            //int[] sayilar = new int[5];
            //sayilar[0] = 10;
            //sayilar[1] = 20;
            //sayilar[2] = 30;
            //sayilar[3] = 40;
            //sayilar[4] = 50;
            //Console.WriteLine(sayilar[0]);
            //sayilar[0]=100;//0. indexdeki elemanı güncelledik.

            //for (int i = 0; i<sayilar.Length; i++)//sayilar.Length dizinin eleman sayısını alır
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //int[] sayi = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            //sayi[5]=600;
            //foreach (int item in sayi)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Örnek 2
            //Kullanıcıdan sayılar dizisinin 1 den başlayıp kaça kadar devam edeceğini soralım ve bu uzunluğa göre 
            //her bir değeri kullanıcıdan alıp dizinin içine atalım

            //Console.WriteLine("Dizi Eleman sayısı belirtin");
            ////int[] sayi = new int[Convert.ToInt32(Console.ReadLine())]; 
            //int deger = Convert.ToInt32(Console.ReadLine());
            //int[] sayi = new int[deger];

            ////sayi[0]=Convert.ToInt32(Console.ReadLine());
            ////sayi[1]=Convert.ToInt32(Console.ReadLine());
            ////sayi[2]=Convert.ToInt32(Console.ReadLine());
            ////sayi[3]=Convert.ToInt32(Console.ReadLine());
            ////sayi[4]=Convert.ToInt32(Console.ReadLine());
            ////sayi[5]=Convert.ToInt32(Console.ReadLine());
            ////sayi[6]=Convert.ToInt32(Console.ReadLine());
            ////sayi[7]=Convert.ToInt32(Console.ReadLine());
            //int s = 0;
            //for (int i = 0; i<sayi.Length; i++)
            //{
            //    // sayi[i]=Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"Sayılar dizisine {i+1}. sayıyı giriniz");
            //    s=Convert.ToInt32(Console.ReadLine());
            //    sayi[i]=s;
            //}
            //Console.WriteLine("***************");
            //foreach (int item in sayi)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Kullanıcıdan Kaç adet personeli olduğunu soralım
            //Verilen cevaba göre her bir personelin adını alıp diziye aktaralım
            //Sonrasında personel isimlerini ekrana yazdıralım
            //Console.WriteLine("Personel sayısı");
            //int personelSayisi = Convert.ToInt32(Console.ReadLine());
            //string[] personeller = new string[personelSayisi];//personel sayısından gelen değere göre dizi yapısı oluşturduk

            //for (int i = 0; i<personeller.Length; i++)
            //{
            //    Console.WriteLine("Personel Adı");
            //    string ad = Console.ReadLine();
            //    personeller[i]=ad;

            //}
            //Console.WriteLine("*********");
            //for (int i = 0; i<personeller.Length; i++)
            //{
            //    Console.WriteLine(personeller[i]);
            //}

            //Kullanıcıdan kaç ürün aldığını soralım 
            //aldığı her bir ürünün fiyatını ve adını alıp diziye aktaralım 
            //aldığı ürünleri ekrana yazdıralım

            //Console.WriteLine("Kaç adet ürün aldınız");
            //int urunSayisi = Convert.ToInt32(Console.ReadLine());

            //string[] urunler = new string[urunSayisi];
            //int[] fiyatlar = new int[urunSayisi];

            //for (int i = 0; i<urunSayisi; i++)
            //{
            //    Console.WriteLine($"{i+1}.Ürün Adı");
            //    string urunAdi = Console.ReadLine();
            //    urunler[i]=urunAdi;
            //    Console.WriteLine($"{urunAdi}nın Fiyatını giriniz");
            //    int fiyat = Convert.ToInt32(Console.ReadLine());
            //    fiyatlar[i]=fiyat;
            //}
            //Console.WriteLine("Toplam ödenecek miktar hesaplanıyor");
            //Thread.Sleep(2000);
            //int toplam = 0;
            //for (int i = 0; i<urunSayisi; i++)
            //{
            //    Console.WriteLine($"Urun adı {urunler[i]} => Fiyatı: {fiyatlar[i]} ");
            //    toplam+=fiyatlar[i];


            //}
            //Console.WriteLine("Toplam ödenecek Tutar "+toplam);


            #endregion

            #region 
            //Kullanıcıdan en az 10 elemanlı int bir dizi oluşturmasını isteyelim
            //bu dizinin içindeki değerleri tek ve çift olarak ayrı ayrı toplayıp ekrana yazdıralım 
            //Console.WriteLine("Lütfen en az 10 elemanlı dizi oluşturun");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi<10)
            //{
            //    sayi = 10;
            //}
            //int[] sayilar = new int[sayi];
            //int tekToplam = 0;
            //int ciftToplam = 0;

            //for (int i = 0; i<sayilar.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}.Sayı");
            //    int deger = Convert.ToInt32(Console.ReadLine());
            //    sayilar[i]=deger;

            //}
            //foreach (int deger in sayilar)
            //{
            //    if (deger%2==0)
            //    {
            //        ciftToplam+=deger;
            //    }
            //    else
            //    {
            //        tekToplam+=deger;
            //    }

            //}
            //Console.WriteLine("Tek sayılar toplamı: "+tekToplam);
            //Console.WriteLine("Çift sayılar toplamı: "+ciftToplam);
            #endregion

            #region ArrayMethods
            //string[] adlar = { "Ali", "Veli", "Eren", "Mehmet", "Kerem", "Veli", "Mahmut", "Veli" };

            //foreach (string ad in adlar)
            //{
            //    Console.WriteLine(ad);
            //}
            /*Clear*/
            //Array.Clear(adlar);//Tüm dizinin elemanlarını siler
            //Array.Clear(adlar, 1, 3);//Sileceği index değeri ve uzunluk belirtiyoruz.
            //foreach (string ad in adlar)
            //{
            //    Console.WriteLine(ad);
            //}
            /*Copy*/
            //string[] adlar2 = new string[adlar.Length];
            ////Array.Copy(adlar, adlar2, 3);
            ////Array.Copy(adlar, adlar2, adlar.Length);
            //Array.Copy(adlar,1, adlar2, 0,5);//ilk değer kopyalanacak yapıdaki index
            ////bu indexi al ve benim 0.indeximden başlayarak 5 elemanını kopyala


            //foreach (string ad in adlar2)
            //{
            //    Console.WriteLine(ad);
            //}
            /*IndexOf*/

            //int index = Array.IndexOf(adlar, "Veli");//indexof sadece ilk bulduğu değeri getirir
            //int index2 = Array.IndexOf(adlar, "Veli",2);
            //Console.WriteLine(index);//ilk bulduğu index değeri
            //Console.WriteLine(index2);//başlangıç index değerini verdiğimiz için sonrasında bulduğu index değeri
            /*LastIndexOf*/
            //int index = Array.LastIndexOf(adlar, "Veli");//Sondan arayarak ilk bulduğu değeri getirir
            //int index2 = Array.LastIndexOf(adlar,"Veli", index-1);//ilk bulduğun değerin bir düşüğünden aramaya başla
            //Console.WriteLine(index);
            //Console.WriteLine(index2);
            /*Sort ve Reverse*/
            //string[] iller = { "Zonguldak", "Amasya", "Bursa", "Adana", "Kars", "Giresun", "Ordu", "Van" };
            //Array.Sort(iller);//A>Z ye sıralama yapar.
            //Array.Reverse(iller);//Tersine çevirme işlemi yapar 
            //foreach (string il in iller)
            //{
            //    Console.WriteLine(il);
            //}
            //Console.WriteLine("***************");
            //int[] sayilar = { 1000, 99, 5456, 327, 1, 68, 73, 877 };
            //Array.Sort(sayilar);//Küçükten büyüğe
            //foreach (int sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}
            /*ReSize*/
            //int[] sayilar = new int[5];
            //sayilar[0]= 1;
            //sayilar[1]= 2;
            //sayilar[2]= 3;
            //sayilar[3]= 4;
            //sayilar[4]= 5;
            //string[] adlar = { "Ali", "Veli", "Ahmet", "Berat", "Enes" };
            //Console.WriteLine("Hangi Değeri  görmek istiyorsun");
            //string sayi = Console.ReadLine();
            //if (int.TryParse(sayi, out int s))
            //{
            //    Console.WriteLine(adlar[s]);
            //}
            //else
            //{
            //    int index = Array.IndexOf(adlar, sayi);
            //    Console.WriteLine(adlar[index]);
            //}


            /*Ref Daha önce tanımlanmış bir değeri revize etmek güncellemek için kullandığımız bir keyword'dür
             * Out:Daha önce tanımlanmamış null olan bir değere veri ataması yapmak için kullandığımız bir keyword'dür
             
             */
            // Array.Resize(ref sayilar, 8);
            //Array.Resize(ref sayilar,sayilar.Length+1);//Sayılar dizisinin boyutunu uzunluğunun 1 fazlası olarak ayarla

            // sayilar[5]= 6;
            // //Array.Resize(ref sayilar, 3);//sayılar dizisinin boyutunu düşür
            // Array.Resize(ref sayilar, sayilar.Length-1);
            // foreach (int sayi in sayilar)
            // {
            //     Console.WriteLine(sayi);
            // }
            //Console.WriteLine("Lütfen bir sayı giriniz");
            //string sayi = Console.ReadLine();


            ////if (int.TryParse(sayi, out int s))
            ////{
            ////    Console.WriteLine(s+10);
            ////}
            ////else
            ////{
            ////    Console.WriteLine(sayi+10);
            ////}
            //int s;
            //if (int.TryParse(sayi, out s))
            //{
            //    s=100;
            //    Console.WriteLine(s);
            //}
            //else
            //{
            //    Console.WriteLine(sayi);
            //}

            //Console.WriteLine("Kategori giriniz");
            //string kategori = Console.ReadLine();
            //if (int.TryParse(kategori, out int s))
            //{
            //    switch (s)
            //    {
            //        case 1: Console.WriteLine($"Aksiyon reyonu A Reyonundadır"); break;
            //        case 2: Console.WriteLine($"Macera reyonu B Reyonundadır"); break;
            //        case 3: Console.WriteLine($"Bilim Kurgu reyonu C Reyonundadır"); break;
            //        default: Console.WriteLine("Girdiğiniz kategori mevcut değildir"); break;
            //    }
            //}
            //else
            //{
            //    switch (kategori)
            //    {
            //        case "Aksiyon": Console.WriteLine($"{kategori} reyonu A Reyonundadır"); break;
            //        case "Macera": Console.WriteLine($"{kategori} reyonu B Reyonundadır"); break;
            //        case "Bilim kurgu": Console.WriteLine($"{kategori} reyonu C Reyonundadır"); break;
            //        default: Console.WriteLine("Girdiğiniz kategori mevcut değildir"); break;
            //    }
            //}
          
          
            #endregion

            //https://roadmap.sh/
            //https://www.w3schools.com/
        }
    }
}
