namespace _07_Switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev

            //Ödev switch-case ödev3
            /*
            kullanıcıdan alınan cinsiyet bilgisine göre
         ==> ERKEK ise
            yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, 
            yaş 60'ın altında ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise 
            maaşının 11 katı kadar ikramiye alarak emekli edilecek,    
            6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
            ==> KADIN ise
             yaşı 55 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli 
            edilecek, yaş 55'ın altında ise çalıştığı gün sayısına göre eğer
            5400 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli 
            edilecek, 5400 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
            ==> cinsiyet bilgisi switch-case ile sorgulanacak
             */
            #endregion
            //Switch Case yapısıda if else yapısı gibi bir koşul yapısıdır
            //if else yapısından farklı olarak kışul değeri bir karşılaştırma yapılmaz
            //girilen değer case bloklarında aranır ve o değere uygun case varsa çalışır
            //eğer uygun case yok ise else yapısı gibi default yapısı vardır bu default yapısı çalışır
            //aynı koşul birden fazla case bloğunda bulunamaz.
            //Hangi tipte değer verildi ise case yapısına o değer tipinden devam etmelidir.

            /*
            
                switch(değer)
                {
                    case koşul: yapılacak iş ; break;//iş bitimini break ile belirtiriz.
                    case koşul: yapılacak iş ; break;//iş bitimini break ile belirtiriz.
                    case koşul: yapılacak iş ; break;//iş bitimini break ile belirtiriz.
                    case koşul: yapılacak iş ; break;//iş bitimini break ile belirtiriz.
                    default:geriye kalan her yapı ;break;
                }
            */
            #region örnek1
            //Console.WriteLine("Şehir gir plaka bul");
            //string sehir = Console.ReadLine();
            //switch (sehir)
            //{
            //    case "istanbul": Console.WriteLine($"{sehir} plakası 34"); break;
            //    case "ankara": Console.WriteLine($"{sehir} plakası 06"); break;
            //    case "izmir": Console.WriteLine($"{sehir} plakası 35"); break;
            //    case "bursa": Console.WriteLine($"{sehir} plakası 16"); break;
            //    case "konya": Console.WriteLine($"{sehir} plakası 42"); break;
            //    case "kastamonu": Console.WriteLine($"{sehir} plakası 37"); break;
            //    case "amasya": Console.WriteLine($"{sehir} plakası 05"); break;
            //    case "samsun": Console.WriteLine($"{sehir} plakası 55"); break;
            //    case "adana": Console.WriteLine($"{sehir} plakası 01"); break;
            //    case "antalya": Console.WriteLine($"{sehir} plakası 07"); break;
            //    default:
            //        Console.WriteLine("Sistemde yoğunluk sebebi ile bu bilgiye ulaşılamadı");
            //        break;
            //}
            #endregion

            #region Örnek2 Market
            // \n yapısı enter yani bir alt satıra geç demek
            //goto keyword'ü ile birden fazla case yapısını kullanıyoruz.
            //Console.WriteLine("Yapmak istediğiniz işlem(1-stok eksilt\n2-ürün ekle\n3-satış yap)");
            //int islem = Convert.ToInt32(Console.ReadLine());
            //switch (islem)
            //{
            //    case 1: Console.WriteLine("Stok eksiltme yapıldı"); break;
            //    case 2: Console.WriteLine("Ürün stoğa eklendi"); break;
            //    case 3: Console.WriteLine("Satış başarılı"); goto case 1;//değeri 1 olan case e yönlendiriyoruz.
            //    default: Console.WriteLine("Hatalı seçim"); break;
            //}

            #endregion

            #region Haftanın Günü
            //kullanıcıya haftanın kaçıncı günü diye soralım kullanıcı
            //1.günü diye cevap verirse pazartesi olarak bize case yapısı cevap dönsün
            //1 den 7 ye kadar girilen haftanın günlerini belirleyelim ve eğer 8 0 gibi değerler girilirse
            //1 ila 7 arasında değer giriniz diye uyarı verelim. 
            //Console.WriteLine("Haftanın kaçıncı günü");
            //int gun = Convert.ToInt32(Console.ReadLine());
            //switch (gun)
            //{
            //    case 1: Console.WriteLine("Pazartesi"); break;
            //    case 2: Console.WriteLine("Salı"); break;
            //    case 3: Console.WriteLine("Çarşamba"); break;
            //    case 4: Console.WriteLine("Perşembe"); break;
            //    case 5: Console.WriteLine("Cuma"); break;
            //    case 6: Console.WriteLine("Cumartesi"); break;
            //    case 7: Console.WriteLine("Pazar"); break;
            //    default: Console.WriteLine("1-7 arasında değer giriniz "); break;

            //}
            #endregion
            #region Basit Hesap Makinesi
            //Console.WriteLine("1.Sayıyı giriniz");
            //double sayi = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2.Sayıyı giriniz");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Yapmak istediğiniz işlem \n+\n-\n*\n/");
            //char islem = Convert.ToChar(Console.ReadLine());

            //switch (islem)
            //{
            //    case '+': Console.WriteLine($"Toplama Sonucu: {sayi+sayi2}"); break;
            //    case '-': Console.WriteLine("Çıkarma Sonucu: {0}", sayi-sayi2); break;
            //    case '*': Console.WriteLine("Çarpma Sonucu: "+(sayi*sayi2)); break;
            //    case '/':
            //        if (sayi2!=0)
            //        {
            //            if (sayi2<=sayi)
            //            {
            //                Console.WriteLine($"Bölme Sonucu {sayi/sayi2}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("ikinci değer ilk değerden büyük olamaz");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sayı sıfıra bölünemez");
            //        }
            //        break;
            //    default: Console.WriteLine("Hatalı seçim"); break;

            //}
            #endregion
            #region Kitaplık uygulaması
            Console.WriteLine("Kategori giriniz");
            string kategori = Console.ReadLine();
            switch (kategori)
            {
                case "Aksiyon": Console.WriteLine($"{kategori} reyonu A Reyonundadır"); break;
                case "Macera": Console.WriteLine($"{kategori} reyonu B Reyonundadır"); break;
                case "Bilim kurgu": Console.WriteLine($"{kategori} reyonu C Reyonundadır"); break;
                default: Console.WriteLine("Girdiğiniz kategori mevcut değildir"); break;
            }


            #endregion

        }
    }
}
