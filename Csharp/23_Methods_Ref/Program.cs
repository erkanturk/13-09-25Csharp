namespace _23_Methods_Ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ref Keywordü dışarıda tanımlı olan bir değer method içerisinde güncellemeye tabi tutulur
             * Buradaki mantık şudur benim referans olarak gösterdiğim bir sayı değeri var bu değeri içeride 
             * güncellemek istediğim durumlarda ref keywordü kullanılır
             * Parametre verildikten sonra ref keywordü kullanılır ilk değer ataması yapılır
             * Null bir değer gönderilemez.
            */
            #region örnek 1
            //int sayi = 100;//Compile time da hafızada bir alan açılır ve 100 değeri atanır
            //Console.WriteLine(sayi);
            //Guncelle(ref sayi);//ref tarafından güncellenen değeri bize getirdi.
            //Console.WriteLine(sayi);
            #endregion
            #region örnek 2
            #endregion
            double sayi1 = 200.50;
            double sayi2 = 300.50;
            double sayi3 = 400.55;

            Degistir(ref sayi1, ref sayi2, ref sayi3);
            Console.WriteLine(sayi1+" "+sayi2+" "+sayi3);
            Degistir2(sayi2);

            string metin = "Merhaba";
            bool kontrol = metin.Contains("Ref");
            Degistir3(ref metin);
            bool durum = metin.Contains("Ref");

            Console.WriteLine(kontrol);
            Console.WriteLine(durum);

            Random random = new Random();
            double[] sayilar = new double[10];
            for (int i = 0; i<sayilar.Length; i++)
            {
                double s2 = random.Next(1, 50);
                sayilar[i]=s2;
            }
            Console.WriteLine("********************");
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
            Randoms(ref sayilar);
            Console.WriteLine("Günceleme sonrası");
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
        }
        static void Guncelle(ref int sayi)
        {
            sayi += 20;//ref keywordü ile gelen değer güncellenir ve return den farklı olarak 
            //birden fazla değer dışarıya çıkarabilir.
        }
        static void Degistir(ref double sayi, ref double sayi2, ref double sayi3)
        {
            sayi=sayi+(sayi*1.10);
            sayi2=sayi2+(sayi2*1.20);
            sayi3=sayi3+(sayi3*1.30);
        }
        static void Degistir2(double sayi)
        {
            sayi*=1.10;
            Console.WriteLine(sayi);//sadece ekrana yazdırır dışarıya bir etkisi olmaz
        }
        static void Degistir3(ref string metin)
        {
            metin+=" Merhaba Ref";
        }
        static void Randoms(ref double[] s)
        {
            Thread.Sleep(3000);
            Random random = new Random();
            s=new double[10];
            for (int i = 0; i<s.Length; i++)
            {
                int s2 = random.Next(50, 1000);
                s[i]=s2;
            }
        }
    }
}
