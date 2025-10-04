namespace _13_OdevCozum
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

            Random random = new Random();
            int rasgeleSayi = random.Next(1, 101);
            int girilenSayi = 0;
            int hak = 1;

            do
            {
                Console.WriteLine($"{hak}. hakkınız Lütfen sayı giriniz");
                girilenSayi = Convert.ToInt32(Console.ReadLine());
                if (girilenSayi>rasgeleSayi)
                {
                    Console.WriteLine("Daha küçük bir sayı giriniz");
                }
                else if (girilenSayi<rasgeleSayi)
                {
                    Console.WriteLine("Daha büyük bir sayı giriniz");
                }
                else
                {
                    Console.WriteLine("Doğru tahmin "+rasgeleSayi);
                    Console.WriteLine("Tekrar oynamak ister misin ?");
                    string cevap = Console.ReadLine().ToLower();
                    if (cevap=="e")
                    {
                        hak= 1;
                        rasgeleSayi= random.Next(1, 101);
                        continue;

                    }
                    else if (cevap=="h")
                    {
                        Console.WriteLine("İyi günler");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Yanlış tuşlama");

                    }

                }
                if (hak==5)
                {
                    Console.WriteLine($"Hakkınız Doldu: {rasgeleSayi}");
                    Thread.Sleep(2000);
                    Console.WriteLine("Devam etmek istiyor musunuz");
                    string cevap = Console.ReadLine().ToLower();
                    if (cevap=="e")
                    {
                        hak= 1;
                        rasgeleSayi= random.Next(1, 101);
                        continue;

                    }
                    else if (cevap=="h")
                    {
                        Console.WriteLine("İyi günler");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Yanlış tuşlama");

                    }
                }
                hak++;

            }
            while (true);

        }
    }
}
