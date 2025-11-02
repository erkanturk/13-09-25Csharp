namespace _26_Methods_Recursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Recursive Methods
             * Bir işin tamamını yapmak yerine bir işi parçalı halde tamamlayan bir yapıdır
             * Bu yapıda methodun kendi içerisinde  tekrar kendini çağırması söz konusudur
             * Method bir döngü yapısı gibi bir işi sürekli çalıştırır fakat bu alanda verdiğimiz koşullar 
             * doğrultusunda program bir işin tamamını yapmak yerine parçalı halde tamamlar
             * Bu yapı bir döngü değildir 
             * Yineleyen bir yapıdır.
             * Koşula bağlı olarak method kendini çağırmalıdır.
                
             */
            //Yaz();//Sonsuz döngüye girer ve program kitlenir
            Console.WriteLine("Tekli Form için 1 e basınız Çoklu form için 2 ye basınız");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi==1)
            {
                TekliForm();
            }
            else if (sayi==2)
            {
                int deger = 0;
                Console.WriteLine("Kaç Adet Kayıt Geldi");
                int kayit = Convert.ToInt32(Console.ReadLine());
                //CokluForm(s: kayit, s2: deger);
                CokluForm2(kayit,deger);
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız tekrar deneyiniz");
            }

        }
        static void Yaz()
        {
            Console.WriteLine("Metin");
            Yaz();
        }
        static void TekliForm()
        {
            Console.WriteLine("Ad");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaş");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ad+" "+soyad+" "+yas);
        }
        static void CokluForm(int s, int s2)
        {
            Console.WriteLine("Ad");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaş");
            int yas = Convert.ToInt32(Console.ReadLine());


            if (s>s2)
            {
                CokluForm(s-1, s2);
            }
            Console.WriteLine(ad+" "+soyad+" "+yas);

        }
        static void CokluForm2(int s, int s2)
        {

            string ad="";
            string soyad="";
            int yas=0;
            Console.WriteLine("Ad");
            ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            soyad = Console.ReadLine();
            Console.WriteLine("Yaş");
            yas = Convert.ToInt32(Console.ReadLine());
            if (s>s2)
            {
                CokluForm(s-1, s2);
            }
            //for (int i = s2; i<s; i++)
            //{
            //    Console.WriteLine("Ad");
            //     ad = Console.ReadLine();
            //    Console.WriteLine("Soyad");
            //     soyad = Console.ReadLine();
            //    Console.WriteLine("Yaş");
            //    yas = Convert.ToInt32(Console.ReadLine());
            //}
            Console.WriteLine(ad+" "+soyad+" "+yas);

        }
    }
}
