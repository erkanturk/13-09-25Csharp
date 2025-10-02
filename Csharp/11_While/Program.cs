namespace _11_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* While (Loop) döngü yapısı koşul true olduğu sürecede çalışır do while yapısı gibi tek sefer 
             * çalışma mantığı yoktur.

             */
            #region Örnek 1
            //1 den 10 a kadar değerleri yazdırın
            //int sayac = 1;
            //while (sayac<11)
            //{
            //    Console.WriteLine("While: "+sayac);
            //    sayac++;
            //}


            //do//koşul false olsa da do while 1 defa çalışır.
            //{
            //    Console.WriteLine("Do While: "+sayac);
            //    sayac++;
            //}
            //while (sayac<11);
            #endregion

            #region Örnek2
            //1 den 20 ye kadar değerleri ekrana yazdıralım bu değerlerin 15 16 değerlerini ekrana yazdırmasın
            //18 e gelince döngü sonlansın
            //int i = 0;
            //while (true)
            //{
            //    i++;
            //    if (i==15 || i==16)
            //    {
            //        continue;
            //    }
            //    if (i==18)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);

            //}
            #endregion
            #region örnek 3
            //200 den başlayarak 7 nin katlarını ekrana yazdıran while döngüsünü yazın
            //int sayi = 200;
            //while (true)
            //{
            //    if (sayi%7==0)
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //    if (sayi==0)
            //    {
            //        break;
            //    }
            //    sayi--;
            //}
            //Console.WriteLine("******************");
            //sayi = 200;
            //while (sayi>0)
            //{
            //    if (sayi%7==0)
            //    {
            //        Console.WriteLine(sayi);
            //    }

            //    sayi--;
            //}
            #endregion
            #region Örnek4
            //Modem arayüz uygulaması
            //int hak = 3;
            //string kullaniciAdi = "admin";
            //string sifre = "a123";

            //while (hak>0)
            //{
            //    Console.WriteLine("Kullanıcı adınızı giriniz");
            //    string kad = Console.ReadLine().ToLower();
            //    Console.WriteLine("Şifreniz");
            //    string password = Console.ReadLine().ToLower();
            //    hak--;
            //    if (kad==kullaniciAdi&&password==sifre)
            //    {
            //        Console.WriteLine("Sisteme giriş başarılı");
            //        break;
            //    }
            //    else if (hak==0)
            //    {
            //        Console.WriteLine("Hakkınız kalmadı");
            //        Console.WriteLine("Sistem 10 saniye kilitlendi");
            //        Thread.Sleep(10000);//milisaniye tipinde bekleme yaptırır.
            //        hak=3;
            //        Console.WriteLine("Sistem aktif");
            //        continue;

            //    }
            //    else
            //    {
            //        Console.WriteLine("Giriş Başarısız");
            //        Thread.Sleep(2000);
            //        Console.WriteLine("Tekrar Deneyin");
            //    }
            //}
            #endregion
            #region Örnek 5
            //Kullanıcının girdiği sayıları toplayan bir while döngüsü yapacağız 
            //kullanıcı ilk sayıyı 0 girerse tekrardan ilk değer 0 girilemez uyarısı verip tekrar sayı isteyeceğiz
            //kullanıcı ilk değer dışında 0 girerse döngü sonlanacak ve girdiği tüm sayıların toplamını ekrana yazdıracak 

            //int sayac = 0;
            //int toplam = 0;
            //int sayi;
            //while (true)
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi==0 && sayac==0)
            //    {
            //        Console.WriteLine("ilk değer 0 girilemez");
            //        continue;
            //    }
            //    if (sayi==0)
            //    {
            //        break;
            //    }
            //    if (sayi<0)
            //    {
            //        Console.WriteLine("Pozitif değer giriniz");
            //        continue;

            //    }
            //    toplam+=sayi;
            //    sayac++;
            //}
            //Console.WriteLine("Toplam değer: "+toplam);
            //Console.WriteLine("Ortalama: "+(toplam/sayac));
            #endregion

            #region Örnek 6
            //Mod alma kullanmadan 0 dan başlayarak 100 kadar  2 nin katlarını ekrana yazdıran döngü

            int sayi = 0;
            while (sayi<=100)
            {

                Console.WriteLine(sayi);
                sayi+=5;
            }
            #endregion
        }
    }
}
