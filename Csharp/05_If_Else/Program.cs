namespace _05_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ödev
            /* ödev 1 if else
           Kullanıcıdan isim, yaş, maaş ve çocuk sayısı alınsın.

            Eğer kulanıcının yaşı 45'in altındaysa;
            Çocuk sayısına bakılacak. Ve çocuk sayısı 3'ten az ise çocuk başına 2500₺,
                                                      3'ten çok ise çocuk başına 2000₺ 
                                                            maaşa ekleme yapılacak.
            45'in üzerinde ise çocuk başına para verilmeyecek ancak 5000₺ ekleme yapılacak.
            Son olarak ekrana : "Nesrin Yılmaz, Maaşınız: 40000₺" yazılacak. 
            */

            //Ödev 2 if else
            // Kullanıcıdan 3 adet sayı alınız ve bu sayıları şekil A görüldüğü gibi 
            //büyükten küçüğe sıralı bir şekilde ekrana yazdırınız
            //Şekil a: 15 13 5
            #endregion
            /* if else koşul yapıları
             * switch case 
             * Bir programın akışını koşullara göre hareket edecek ise if else yapısı kullanılır if veya else if
             * bloklarından biri çalışırsa diğer bloklar kontrol edilmez
             * Eğer hiçbir blok çalışmazsa geriye kalan tüm koşullar için else yapısı çalışır
             * bir if else yapısında bir if  bir else bulunabilir fakat birden fazla else if yapısı olabilir
             * bu yapılardan sadece birtanesi çalışır.
             * if (eğer)
             * else if(değilse eğer)
             * else (değilse)
            
            */
            #region Örnek 1
            //Kullanıcıdan 2 veya 2 den büyük sayı isteyelim ve bu sayıların tek mi çift mi olduğunu söyleyen programı yazalım

            //Console.WriteLine("Bir sayı giriniz çift mi tekmi Öğrenin");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi%2==0)//Eğer
            //{// if else blokları true olduğu sürece içindeki kod bloğunu çalıştırır.
            //    Console.WriteLine("Çift sayı");
            //}
            //else//değilse else yapısı geriye kalan tüm koşulları kapsadığı için bir koşul yapısı veremeyiz.
            //{
            //    Console.WriteLine("Sayı tektir");
            //}
            #endregion
            #region Örnek 2
            //Kullanıcıdan sayı girmesini isteyelim ve girilen sayı değerinin negatif yada pozitif olduğunu bulan programı yazalım.
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi>0)//tek bir koşulda tek bir if else if else blokları ile devam etmek gerekir
            //{
            //    Console.WriteLine("Pozitiftir");
            //}
            //else if (sayi<0)
            //{
            //    Console.WriteLine("Sayı negatiftir");
            //}
            //else
            //{
            //    Console.WriteLine("sayınız 0 dır.");
            //}
            //if (sayi>0)//birden fazla farklı koşullar için ifler açılmalıdır.
            //{
            //    Console.WriteLine("Sayı Pozitiftir");
            //}
            //if (sayi<0)
            //{
            //    Console.WriteLine("sayı negatiftir");
            //}
            //if (sayi==0)
            //{
            //    Console.WriteLine("sayı 0 dır");
            //}
            #endregion

            #region Örnek3 
            //string kad = "erkan";
            //string password = "A123";

            //Console.WriteLine("Kullanıcı Adınızı giriniz");
            //string kullaniciAdi = Console.ReadLine().ToLower();//ToLower yapısı girilen değerleri küçültür.
            //Console.WriteLine("Şifreniz");
            //string pass = Console.ReadLine().ToUpper();//Girilen değerleri büyültür.

            //if ((kullaniciAdi==kad||kullaniciAdi=="e"||kullaniciAdi=="erkanturk@hotmail.com")&&pass==password)
            //{
            //    Console.WriteLine("sisteme giriş başarılı");
            //}
            //else
            //{
            //    if (kullaniciAdi!=kad&&kullaniciAdi!="e"&&kullaniciAdi!="erkanturk@hotmail.com")
            //    {
            //        if (pass!=password)
            //        {
            //            Console.WriteLine("Şifre hatalıdı");
            //        }
            //        Console.WriteLine("Kullanıcı adı hatalıdır");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Şifre hatalıdır.");
            //    }
            //}
            #endregion
            #region Örnek 4
            //kullanıcıdan iki kardeşin yaşını isteyelim ve büyük olan yaşı ekrana yazdıralım
            //Console.WriteLine("1. değeri giriniz");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2. değeri giriniz");
            //int yas2 = Convert.ToInt32(Console.ReadLine());
            //if (yas>yas2)
            //{
            //    Console.WriteLine($"{yas} > {yas2}");
            //}
            //else if (yas2>yas)
            //{
            //    Console.WriteLine($"{yas2} > {yas} ");
            //}
            //else
            //{
            //    Console.WriteLine($"{yas} eşittir {yas2}");
            //}

            #endregion
            #region Örnek5
            //Kullanıcıdan aylık geliri istenecek ve aylık geliri 40000 in üzerinde ise %12 vergi kesilip vergi uygulanmış fiyat ekrana yazılacak
            //eğer 40000 ve altında ise %9 vergi kesimi yapılıp alacağı tutar ekrana yazılacak
            //Console.WriteLine("Aylık gelirinizi giriniz");
            //double gelir = Convert.ToDouble(Console.ReadLine());
            //if (gelir>40000)
            //{
            //    Console.WriteLine($"Vergi uygulanmış geliriniz {gelir*0.88}");
            //}
            //else
            //{
            //    Console.WriteLine($"Vergi uygulanmış geliriniz {gelir*0.91}");
            //}
            #endregion

            #region örnek 6
            /* Kullanıcıdan harcama miktarı isteyelim
             * Eğer harcama miktarı 0-1000 arasında ise fiyatlandırma 0.35 olarak hesaplanacak
             * 1001-2500 arasında ise 0.38
             * 2501-4000 arası 0.41
             * 4001-6000 arası 0.42
             * 6001 üstü için 1200 tl indirip yapıp 0.43 üzerinden hesaplanacak.  
             
             */
            //Console.WriteLine("Harcama Miktarı");
            //double miktar = Convert.ToDouble(Console.ReadLine());
            //if (miktar>0&&miktar<1001)
            //{
            //    Console.WriteLine(miktar*0.35);
            //}
            //else if (miktar>1000&&miktar<2501)
            //{
            //    Console.WriteLine(miktar*0.38);
            //}
            //else if (miktar>2500&&miktar<4001)
            //{
            //    Console.WriteLine(miktar*0.41);
            //}
            //else if (miktar>4001&&miktar<6001)
            //{
            //    Console.WriteLine(miktar*0.32);
            //}
            //else if (miktar>6000)
            //{
            //    Console.WriteLine((miktar*0.43)-1200);
            //}
            #endregion
            #region örnek 7
            /*1-100 arasındaki sayıların 7 ye tam bölünen değerleri ekrana teker teker yazdıran yapıyı yazalım
            */
            //int sayi = 1;
            //test://bu satıra konuşlandı ve : nokta ile tanımladım
            //if (sayi%7==0)
            //{
            //    Console.WriteLine(sayi);
            //}
            //sayi++;//Sayıyı 1 artırma işlemi
            //if (sayi<=100)
            //{//goto bir loops (döngü) yapısı değildir bir satıra konuşlanma keywordudür
            //    goto test;//gideceği değeri belirtim ve ; ile tanımladım
            //}
            #endregion
            #region örnek 8
            //Kullanıcıdan 200 den başlayarak 3 tam bölünen sayıları sadece ekrana yazdıran programı yazınız.
            int sayi = 200;
            int toplam = 0;
            test://bu satıra konuşlandı ve : nokta ile tanımladım
            if (sayi%3==0)
            {
                toplam+=sayi;//aldığı değeri depolayarak artırır.
                Console.WriteLine(sayi);
            }
            sayi--;//Sayıyı 1 azaltma işlemi
            if (sayi>=0)
            {//goto bir loops (döngü) yapısı değildir bir satıra konuşlanma keywordudür
                goto test;//gideceği değeri belirtim ve ; ile tanımladım
            }
            Console.WriteLine(toplam);
            #endregion


        }
    }
}
