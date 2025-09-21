namespace _04_Tur_donusumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödevler
            //Ödevler
            //Kullanıcıdan 2 sayı alınız bu sayının toplamı çarpımı bölümü ve çıkarma işlemini yapınız
            //kullanıcıdan 4 sayı alıp bu sayıların ortalamasını ekrana yazdırınız
            #endregion

            /*Bilinçsiz tür dönüşümü */
            //int sayi = 12345;
            //double sayi2 = sayi;//bilinçsiz tür dönüşümü
            //Console.WriteLine(sayi2);//int olarak tanımladığımız değeri double değişkenin içerisine aktararak bu değerin double türünde kullanılmasını sağladık.
            //double s = 10;
            //int s2 = s;
            // int s2 = (int)s;//binlinçli tür dönüşümü

            //double sayi = 10.99;
            //int sayi2 = (int)sayi;//int sayıya tür dönüşümü yaptığımızda küsürat kısmını almaz.
            //Console.WriteLine(sayi2);

            //string metin = "10";
            //// int sayi = (int)metin;//hata verir convert etmemiz gerekiyor.
            //int sayi = Convert.ToInt32(metin);//burada ise metinsel bir değerin içinde gerçekten sayı var ise bu yapıyı sayi değişkenine aktarma işlemi yapıyoruz.

            //Console.WriteLine(sayi);

            //int sayi = 10;
            //int sayi2 = 20;
            //string metin = "10";
            ////Console.WriteLine(sayi+sayi2);
            //Console.WriteLine(sayi2+metin);//+birleştirme işlemi de yapar eğer sayı ile metin + operatörü ile işleme tabi tutulursa birleştirme işlemi yapar. 
            //char harf = 'B';
            ////int sayi = Convert.ToInt32(harf);
            //int sayi = 20;
            //Console.WriteLine(harf+sayi);
            //Console.WriteLine(sayi);
            //int sayi2 = 126;
            //char harf2 = Convert.ToChar(sayi2);
            //Console.WriteLine(harf2);

            //bool sonuc = false;//0
            //bool sonuc2 = true;//1


            //int sonuc3 = Convert.ToInt32(sonuc);
            //Console.WriteLine(sonuc3);

            //string ad = "erkan";
            //string Ad = "Erkan";

            //bool karsilastir = ad==Ad;//f
            //Kullanıcıdan gelen her değer metinseldir.
            //Console.WriteLine(karsilastir);

            //Tarih zaman yapıları
            //DateTime zaman = DateTime.Now;//Şimdiki zaman
            //Console.WriteLine(zaman);
            //Console.WriteLine(zaman.Year);
            //Console.WriteLine(zaman.Month);
            //Console.WriteLine(zaman.Day);
            //Console.WriteLine(zaman.Hour);
            //Console.WriteLine(zaman.Minute);
            //Console.WriteLine(zaman.Second);
            //zaman.ToString("yyyy-MM-dd HH:mm:ss");
            //Console.WriteLine(zaman);

            //Console.WriteLine(zaman.ToString("yyyy-MM-dd HH:mm:ss"));//Formatlı getirme biçimi.

            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());//Console.ReadLine Satırdaki değeri oku
            ////kullanıcıdan değer alacağımızda kullanıcının girdiği değeri almak için kullanırız.
            //Console.WriteLine("İkinci sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //int toplam = sayi+sayi2;
            //Console.WriteLine(toplam);

            //Console.WriteLine("Adınız");
            //string ad = Console.ReadLine();//kullanıcının girdiği her değer metinsel olduğu için 
            ////bir tür dönüşümü yapmamıza gerek yok
            //Console.WriteLine(ad);

            //Herkes adını soyadını yaşını ve nereli olduğunu ekrana yazdırsın.

            //Console.WriteLine("Adınız:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Soyad");
            //string surname = Console.ReadLine();
            //Console.WriteLine("Yaşınız");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Nereli");
            //string country = Console.ReadLine();

            //Console.WriteLine($"Ad: {name} Soyad: {surname} Yaş: {age} Nereli: {country} ");

            #region Ödev Çözüm
            //Ödevler
            //Kullanıcıdan 2 sayı alınız bu sayının toplamı çarpımı bölümü ve çıkarma işlemini yapınız
            //kullanıcıdan 4 sayı alıp bu sayıların ortalamasını ekrana yazdırınız

            //Console.WriteLine("1.sayi");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.sayi");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Toplama Sonucu:{sayi+sayi2}");
            //Console.WriteLine($"Çıkarma Sonucu:{sayi-sayi2}");
            //Console.WriteLine($"Çarpma Sonucu:{sayi*sayi2}");
            //Console.WriteLine($"Bölme Sonucu:{sayi/sayi2}");


            //Console.WriteLine("1.sayi");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.sayi");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("3.sayi");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("4.sayi");
            //int sayi4 = Convert.ToInt32(Console.ReadLine());

            //int sonuc = (sayi+sayi2+sayi3+sayi4)/4;

            //Console.WriteLine(sonuc);
            #endregion






        }
    }
}
