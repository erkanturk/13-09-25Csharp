namespace _19_Return_Methods_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ödev
            //Bir dizinin eleman sayısı 10 ile 20 arasında olacak şekilde sistem tarafında otomatik atılmaktadır.
            //Bu dizinin elemanlarını da sistem 0,100 arasında otomatik atmaktadır.
            //Otomatik oluşturulan bu dizinin eleman sayısını ve elemanlarını kullanıcıya gösteriniz
            //Aynı sayılar tekrar atanmayacak
            //Dizideki en büyük ve en küçük sayılar sort() kullanılmadan bulup ekrana yazdırılacak 
            #endregion
            #region Ödev method
            /*
            kullanıcıdan iki adet ürün fiyatı alınacak pahalı olan ürüne 
            %30 indirim uygulanacak 
            kullanıcıya 3. ürünü almak ister misiniz diye soracağız eğer 
            evet derse başka bir methoda yönlendirip 
            3. ürün fiyatı isteyeceğiz 3. ürüne de %50 indirim uygulayıp 
            toplam 1.ürün 2.ürün(%30) 3.ürünün(%50) 
            fiyatlarını toplayıp 
            Ekrana toplam fiyatı yazdıracağız 
            Eğer istemez ise 3. ürünü 2 üründen pahalı olan fiyata indirim 
            uygulayıp toplamı ekranda göstereceğiz.
            
            
            */
            #endregion
            //Kullanıcıdan fiyat alalım ve kdv oranını soralım 
            //Kullanıcının verdiği fiyatı Kdv uygula methodu yazıp ekrana yazdıralım

            //Console.WriteLine("Ürün Fiyatını giriniz");
            //double fiyat = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Kdv oranını belirtiniz");
            //double kdv = Convert.ToDouble(Console.ReadLine());
            ////Kdv(fiyat, kdv);
            ////Kdv2();
            //Console.WriteLine(Kdv3());
            //Console.WriteLine(Kdv4(fiyat,kdv));

            //foreach (var yas in Yaslar())
            //{
            //    Console.WriteLine(yas);
            //}
            //Console.WriteLine("*****************");
            //// Console.WriteLine(Yaslar2(20,30,40,50));int değerler 
            //int[] sayilar = { 10, 20, 30 };
            //Console.WriteLine(Yaslar2(sayilar));//Parametre olarak alacağı diziyi verdik
            //Console.WriteLine(Yaslar2(Yaslar()));//parametre olarak geriye dizi döndüren bir method verdik
            //DiziDondur(sayilar);
            //Console.WriteLine("******************");
            //DiziDondur(Yaslar());

            //Kullanıcıdan bir değer girmesini isteyelim girdiği değeri 
            //Bir methoda parametre olarak göndereceğiz ve girdiği değerin sayısal olarak uzunluğunu bize geri dönderecek
            //bir method yapısı yapalım Örneğin Merhaba yazdık 7 olarak değer dönecek.
            Console.WriteLine("Bir değer giriniz");
            string deneme = Console.ReadLine();
            Console.WriteLine(Donder(deneme)) ;
        }
        static void Kdv(double sayi, double sayi2)
        {
            Console.WriteLine(sayi*=sayi2);
        }
        static void Kdv2()
        {
            Console.WriteLine("Ürün Fiyatını giriniz");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kdv oranını belirtiniz");
            double kdv = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(fiyat*=kdv);
        }
        static double Kdv3()
        {
            Console.WriteLine("Ürün Fiyatını giriniz");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kdv oranını belirtiniz");
            double kdv = Convert.ToDouble(Console.ReadLine());

            return fiyat*=kdv;
        }
        static double Kdv4(double fiyat, double kdv)
        {


            return fiyat*=kdv;
        }
        static int[] Yaslar()//geriye döndereceği değer
        {
            int[] yaslar = { 20, 22, 23, 24, 25, 26, 27, };
            return yaslar;
        }
        static int Yaslar2(int[] yaslar)
        {

            return yaslar[0];
        }
        static void DiziDondur(int[] sayilar)
        {
            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }
        }
        static int Donder(string a)
        {
            return a.Length;
        }

    }
}
