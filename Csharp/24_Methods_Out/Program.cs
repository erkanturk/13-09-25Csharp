namespace _24_Methods_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev   
            /* Ödev 
            static void KelimeSayilariniGoster isminde bir method tanımlayın ve parametresi string metin olsun.
           Bu method string türünde verilen metin içindeki kelimeleri ayrıştırarak hangi kelimenin kaç kez tekrar ettiğini ekranda göstersin.
                string[] kelimeler = metin.ToLower().Split(ayracKarakterler, StringSplitOptions.RemoveEmptyEntries);
             Sort,Reverse,Split,
            */

           string metin = "Pohpohçu pinti profesör pofur pofur pofurdayarak hınçla tunç çanak içinde punç içip pulverizatör prospektüsünü papaz balığı biblosunun berisindeki papatya buketinin bu yanına bıraktıktan sonra palas pandıras Pülümürlü Pötürgelinin getirdigi pörsük pötikare pöstekiyi Paluluların pıtırcık pazarında partenogenes pasaparolasını, pertavsız pervasız pervaz peyzajını ve perenospora pesterkerani pestilini posbıyıklı pisboğaz pedegoga Pınarbaşı’nda beş peşkirle peş peşe peşin peşkeş çekti, sonra da pılısmı pırtısmı topladı: ” Pingpong, pingpong, pingpong Piyango pingpong! Pingpong, pingpong! ” diyerek Posof’un pisipisi otundan yapılma pistovsu piposunu tüttüre tüttüre paytak paytak yürüyüp gitti.";
            #endregion
            /*Out keywordu ref keywordüne benzer fakat ref den farkı 
             * ref de methoda gönderilen değişkenin ilk değer ataması yapılmak zorundadır
             * out keywordünde ise methoda gönderilen değişkenin ilk değer ataması yapılması zorunlu değildir
             * method içerisinde mutlaka bir değer atanmalıdır.
             * out keywordü ile birden fazla değer dışarıya çıkarılabilir.
             */
            //int sayi;//ilk değer ataması yapılmadı
            //Degistir(out sayi);//out ile methoda gönderildi
            //Console.WriteLine(sayi);

            //double deger1, deger2, deger3;//3 fidan diktim
            //Degistir2(out deger1, out deger2, out deger3);//3 fidanı methoda gönderdim
            //Console.WriteLine(deger1+" "+deger2+" "+deger3);//fidanlar büyüdü meyve verdi
            //object nesne = 123;//boxing
            //int s = (int)nesne;//unboxing
            //                   //out ile de boxing unboxing işlemi yapılabilir

            //Console.WriteLine(Degistir3(255.5, out deger3));
            //Console.WriteLine(deger3);

            double[] sayilar;//diziyi tanımladık
            Randoms(out sayilar);//diziyi out ile methoda gönderdik
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
        }
        static void Degistir(out int sayi)
        {
            sayi = 100;//out ile gelen değişkene method içerisinde mutlaka bir değer atanmalıdır.
            sayi += 50;
        }
        static void Degistir2(out double sayi, out double deger2, out double deger3)
        {
            sayi = 200.50;
            sayi += 100.25;
            deger2= 300.75;
            deger3= 400.95;
        }
        static double Degistir3(double sayi, out double sayi2)
        {
            sayi2 = 50.5;
            return sayi;//return ile sadece bir değer yada bir işlem sonucu dışarıya çıkarılabilir.
            //out veya ref ile birden fazla değer dışarıya çıkarılabilir.

        }
        static void Randoms(out double[] sayilar)
        {
            Random random = new Random();
            sayilar = new double[random.Next(1, 1000)];
            for (int i = 0; i<sayilar.Length; i++)
            {
                double s2 = random.Next(1, 50000);
                sayilar[i]=s2;
            }
        }

        //Optional Methods ve Recursive Methods yarın işlenecek
#
    }
}
