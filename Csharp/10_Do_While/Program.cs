namespace _10_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev
            //1 ila 101 arasında sistem tarafından random sayı üretilecek 
            // üretilen bu değeri kullanıcı tahmin etmeye çalışacak 
            //kullanıcı örneğin 50 değeri girdi girilen sayı üretilen sayıdan büyüktür veya küçüktür olarak bize bir cevap verecek kullanıcı 5 hakta random sayıyı bulamazsa hakkınız bitmiştir deyim üretilen sayıyı gösterip döngü sonlanacak.
            //kullanılacak yapı do while döngüsü ve if else koşul yapısı.
            //Kullanıcı devam etmek isterse yeni sayı üretilip tekrardan tahmin hakkı 5 olacak ve yeni sayı değerini bulmaya çalışacak.

            #endregion
            /* Loops(Döngüler) Do while , While , For, Foreach
             * Do while sadece c# a özgü bir yapıdır 
             * Mantığı Yap kontrol et
             * Döngüler if yapısındaki gibi koşul true ise çalışan yapılardır.
             * Fakat do while yapısı koşul false olsa dahi bir defa işlemi yapar
             * Eğer koşul false değil ise koşul tamamlanana kadar devam eder
             * False ise bir defa çalışır sonra sonlanır
             * Gerçek hayattan örnek verdiğimizde biz bir iş yaptık sonra bu işin yanlış olduğunu öğrendik daha devam etmedik
             * Bir defa yaptığımız işlemle kalmış oldu
             * Eğer yaptığım işlem doğruysa devam edebilirim demektir.
            Çalışma yapısı
             *
             *Do
             *{
             *   Yapılacak işlem
             *}
             *while(koşul);
             */
            #region Döngüsüz Örnek
            //Kullanıcıdan 6 sayı alalım ve bu sayıların çift olanlarını ayrı tek olanlarınını ayrı toplayalım
            //int ciftToplam = 0;
            //int tekToplam = 0;
            //Console.WriteLine("1.Sayı");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayı");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("3.Sayı");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("4.Sayı");
            //int sayi4 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("5.Sayı");
            //int sayi5 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("6.Sayı");
            //int sayi6 = Convert.ToInt32(Console.ReadLine());
            //if (sayi%2==0)
            //{
            //    ciftToplam+=sayi;
            //}
            //else
            //{
            //    tekToplam+=sayi;
            //}
            //if (sayi2%2==0)
            //{
            //    ciftToplam+=sayi2;
            //}
            //else
            //{
            //    tekToplam+=sayi2;
            //}
            //if (sayi3%2==0)
            //{
            //    ciftToplam+=sayi3;
            //}
            //else
            //{
            //    tekToplam+=sayi3;
            //}
            //if (sayi4%2==0)
            //{
            //    ciftToplam+=sayi4;
            //}
            //else
            //{
            //    tekToplam+=sayi4;
            //}
            //if (sayi5%2==0)
            //{
            //    ciftToplam+=sayi5;
            //}
            //else
            //{
            //    tekToplam+=sayi5;
            //}
            //if (sayi6%2==0)
            //{
            //    ciftToplam+=sayi6;
            //}
            //else
            //{
            //    tekToplam+=sayi6;
            //}
            //Console.WriteLine($"Tek Toplamlar {tekToplam} Çift Toplamlar {ciftToplam}");
            #endregion
            #region Örnek1
            //int i = 0;
            //int tekToplam = 0;
            //int ciftToplam = 0;
            //do//ilk işlemi yapar sonra kontrol eder.
            //{
            //    Console.WriteLine($"{i+1} sayıyı giriniz");//i+1 birinci sayı olarak görünsün fakat 0. sayı değeri girilsin.
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi%2==0)
            //    {
            //        ciftToplam+=sayi;
            //    }
            //    else
            //    {
            //        tekToplam+=sayi;
            //    }
            //    i++;//sayıyı 1 artırarak burada koşoşul değerinin sonlanmasını sağlıyoruz.
            //} while (false);
            //Console.WriteLine($"Tek toplam {tekToplam} Çift Toplam {ciftToplam}");
            #endregion

            #region Örnek 2
            //0 dan 20 a kadar sayıları ekrana yazdıran do while döngüsünü yazın
            //0 da dahil 20 de dahil olsun ve 21 e geldiğinde yapı sonlansın.
            //int sayi = 0;
            //do
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}
            //while (sayi<=20);//true ise yapı çalışır false ise yapı bir defa çalışacak do while da
            #endregion
            #region örnek 3
            //int degisken = 1;//1 den başla
            //do
            //{
            //    Console.WriteLine("Merhaba");
            //    degisken++;//her döngü içerisine geldiğinde değeri bir arttır.
            //}
            //while (degisken<=100);//100 e kadar devam et
            #endregion
            #region Örnek 4
            //200 den başlayarak 3 katlarını ekrana yazdıran program 
            //int sayi = 200;
            //do
            //{
            //    if (sayi%3==0)
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //    sayi--;
            //}
            //while (sayi>0);
            #endregion

            #region Örnek 5 
            //Kullanıcının her girdiği sayıyı toplayalım kullanıcı 0 a basarsa toplam ekrana yazdırılsın 
            //int sayi;
            //int toplam = 0;
            //do
            //{
            //    Console.Write("Bir sayı girin (toplam için 0'a basın): ");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;
            //} while (sayi != 0);
            ////Sayı sıfır girildiğinde döngü yapısındaki koşul artık false olur bu yapı döngüyü sonlandırır fakat 0 dışında girilen her değer true olarak döner ve döngü devam eder.

            //Console.WriteLine("Girilen sayıların toplamı: " + toplam);
            #endregion
            #region Örnek 6 
            //Random random = new Random();

            //int i = 0;
            //int deger = random.Next(1, 101);
            //do
            //{

            //    Console.WriteLine("Sayı tahmini");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    if (deger==sayi)
            //    {
            //        Console.WriteLine("Tebrikler doğru tahmin");
            //    }
            //    else if (sayi!=deger)
            //    {
            //        Console.WriteLine("Tekrar deneyiniz");
            //    }
            //    if (i==3)
            //    {
            //        Console.WriteLine("Tahmin hakkı doldu "+deger);
            //    }
            //    i++;

            //}
            //while (true);
            #endregion

            #region Continue;
            //1-20 arasında sayıları 15 değeri olmadan yazdıran döngü
            //int i = 0;
            //do
            //{
            //    i++;
            //    if (i==15||i==14)
            //    {
            //        continue;//sıra değerini atlatmak ve döngüye tekrar devam etmek için kullanılır.
            //    }
            //    Console.WriteLine(i);

            //}
            //while (i<=20);
            //1-20 arasında 10 11 değerleri yazmasın fakat 20 ye gelmeden döngü 15 de kırılsın
            //int i = 0;
            //do
            //{
            //    i++;
            //    if (i==10||i==11)
            //    {
            //        continue;//sıra değerini atlatmak ve döngüye tekrar devam etmek için kullanılır.
            //    }
            //    if (i==15)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);

            //}
            //while (i<=20);
            //int i = 0;

            //do
            //{
            //    Console.WriteLine("c#");
            //    if (i==5)
            //    {
            //        Console.WriteLine("Döngü sonlandı");
            //        break;
            //    }
            //    i++;
            //}
            //while (true);
            //Console.WriteLine("Merhaba");

            int sayi;
            int toplam = 0;
            do
            {
                Console.Write("Bir sayı girin (toplam için 0'a basın): ");
                sayi = Convert.ToInt32(Console.ReadLine());
                
                if (sayi%2==0)
                {
                    toplam+=sayi;
                }
                else
                {
                    continue;
                }

                if (sayi == 0)
                {
                    break;
                }
            } while (true);
            Console.WriteLine(toplam);
            #endregion
        }
    }
}
