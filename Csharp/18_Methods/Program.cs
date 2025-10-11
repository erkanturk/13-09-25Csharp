namespace _18_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Method Tanım
            /* Methodlar(Fonksiyonlar) 
             * Methodlar yapacağımız bir işi modüler hale getirmemizi sağlar. Her method bir iş yapar
             * Bu iş sonucu bir değer de dönderebilir veya döndermeye bilir 
             * Aynı zamanda parametreli veya parametresiz olarak kullanılabilir.
             * Methodlar içinde method tanımlaması yapılamaz çağırma işlemi yapılabilir.
             * Methodlar temel olarak 2 ye ayrılırlar
             * 1.Geriye değer döndürmeyen (void)
             * 2.Geriye değer döndüren methodlar(int,double,char,int[] ,bool class , list vb.) yapılar alır
             * Methodlar sadece çağırıldığı zaman çalışırlar çağırılmadığında kod olarak geçerliliği yoktur.
             * Method isimleri benzersiz olmalıdır. aynı isme sahip methodların imza tipleri (parametre tipi ve sayısı) farklı olmalıdır.
             * Tanım
             * void MethodAdi() iş yapan method 
             * {
             * Yapılacak iş
             * }
             * 
             * int MethodAdi()
             * {
             * Yapılacak iş
             * return işlem sonucu veya iş sonucu
             * }//return sadece ve sadece 1 değer dönderir birden fazla değeri dışarıya çıkaramaz.
             *          
             */
            #endregion

            #region Örnek1
            //int[] dizi = { 1, 2, 3 };
            //foreach (var item in dizi)
            //{
            //    Console.WriteLine(item);
            //}
            //Yaz();
            //for (int i = 0; i<dizi.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Örnek2
            //Console.WriteLine("Bir değer giriniz");
            //string deger=Console.ReadLine();
            //Yaz2(deger);
            //Yaz();
            //Yaz2("Merhaba");
            #endregion
            #region Örnek3
            //Console.WriteLine("Adınız");
            //string ad = Console.ReadLine();
            //Console.WriteLine("Soyadınız");
            //string soyad = Console.ReadLine();
            //Console.WriteLine("Yaşınız");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //BilgiAl(ad, soyad, yas);
            //Bilgi2();
            #endregion
            #region Soru
            //4 Matematiksel işlem methodu olacak  bu methodlar IslemYap() adlı methodda tanımlanacak
            //Kullanıcıdan IslemYap adlı methoddan 2 sayı girmesini isteyeceğiz
            //Ve girdiği sayı değerleri ile yapmak istediği matematiksel işleme yönlendireceğiz
            //Topla,Cikart,Carp,Bol diye 4 matematiksel methodumuz olacak 
            //kullanıcının yapmak istediği işleme göre hangi method ise girilen sayılara işlem yapacak
            IslemYap();
            #endregion

        }
        static void Yaz()// iş yapan parametresiz method
        {
            Console.WriteLine("******************");
        }
        static void Yaz2(string metin)//string metin kısmı bir parametredir değişken değildir.
        {
            Console.WriteLine(metin);
        }
        static void BilgiAl(string ad, string soyad, int yas)
        {
            Console.WriteLine(ad);
            Console.WriteLine(soyad);
            Console.WriteLine(yas);
        }
        static void Bilgi2()
        {
            Console.WriteLine("Adınız");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınız");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaşınız");
            int yas = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(ad);
            Console.WriteLine(soyad);
            Console.WriteLine(yas);
        }
        static void IslemYap()
        {
            Console.WriteLine("1.Sayıyı Giriniz");
            double sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayıyı Giriniz");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz işlem:\n+\n-\n*\n/");
            string islem = Console.ReadLine();
            if (islem=="+")
            {
                Topla(sayi, sayi2);
            }
            else if (islem=="-")
            {
                Cikart(sayi, sayi2);
            }
            else if (islem=="*")
            {
                Carp(sayi, sayi2);
            }
            else if (islem=="/")
            {
                Bol(sayi, sayi2);
            }
            else
            {
                Console.WriteLine("Hatalı Tuşlama");
            }
        }
        static void Topla(double sayi, double sayi2)
        {
            Console.WriteLine($"Toplama Sonuc => {sayi+sayi2}");
        }
        static void Carp(double sayi, double sayi2)
        {
            Console.WriteLine($"Çarpma Sonuc => {sayi*sayi2}");
        }
        static void Cikart(double sayi, double sayi2)
        {
            Console.WriteLine($"Çıkartma Sonuc => {sayi-sayi2}");
        }
        static void Bol(double sayi, double sayi2)
        {
            if (sayi2==0)
            {
                Console.WriteLine("Sayı sıfıra bölünemez");
            }
            else if (sayi2>sayi)
            {
                Console.WriteLine("bölen bölünenden büyük olamaz");
            }
            else if (sayi>sayi2&&sayi2!=0)
            {
                Console.WriteLine($"Bölme Sonuc => {sayi/sayi2}");
            }
            
        }


    }
}
