namespace _12_For_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* For (Loop)
             * for(veritipi=değişken;koşul<değer;artış azalış)
             * {
             *      Yapılacak işlem
             * }
            */
            #region For örnek1
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Erkan");
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion
            #region for örnek2
            //for (string i = "A"; i < "Z"; i++)
            //{

            //}
            //Alfabetik olarak A dan z ye kadar tüm değerleri yazdırma 
            //ascii table https://www.ascii-code.com/
            //for (char i = 'A'; i<=200; i++)
            //{
            //    Console.WriteLine(i +" :sayısal değeri: "+(int)i);
            //}
            #endregion
            #region For örnek3
            //for (int i = 1; i <= 10; i++)//10
            //{
            //    for (int j = 1; j <=10; j++)//100
            //    {
            //        Console.WriteLine($"i: {i} X j: {j} = {i * j}");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("**************************************");
            //int k = 1;
            //int l = 1;
            //while (k<=10)
            //{
            //    while (l<=10)
            //    {

            //        Console.WriteLine($"k: {k} X l: {l} = {k * l}");
            //        l++;
            //    }

            //    k++;
            //    l= 1;
            //    Console.WriteLine();
            //}


            #endregion

            #region For örnek4
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (j==5)
            //        {
            //            continue;//Hangi döngü yapısının içinde tanımlandı ise o döngüye yönlendirir
            //        }
            //        if (j==8)
            //        {
            //            break;//Hangi döngü yapısının içinde kırma işlemi yapıldı ise o döngüyü kırar.
            //        }
            //        Console.WriteLine("j:"+j);
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine("i:"+i);
            //}
            #endregion

            #region For örnek 5
            //for (int i = 0; i < 10; i+=2)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i < 10;)
            //{
            //    Console.WriteLine(i);
            //    i+=2;
            //}
            //for (; ; )//Sonsuz döngü
            //{
            //    Console.WriteLine("Sonsuz Döngü");
            //}
            //for (int i = 0; i<10;)//Sonsuz döngü
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Metin giriniz");
            //string metin = Console.ReadLine();

            //for (int i = 0; i < metin.Length; i++)
            //{
            //    Console.WriteLine(Convert.ToChar(metin[i]));
            //    Console.WriteLine(i);

            //}

            #endregion

            #region  For örnek 5
            //sistem tarafından oluşturulan değerin uzunluğu kadar 1 ila 101 arasında sayı oluşturan for yapısı
            //Random random = new Random();

            //for (int i = 0; i <= random.Next(1, 101); i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Random sayıların çiftlerini ve teklerini ayrı ayrı toplayıp ekrana yazdırın
            #endregion
        }
    }
}
