namespace _06_Random_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sansliSayi = random.Next(1, 30);
            Basla:
            Console.WriteLine("Lütfen Tahmininizi yapınız");
            int tahmin = Convert.ToInt32(Console.ReadLine());
            if (tahmin==sansliSayi)
            {
                Console.WriteLine("Tebrikler doğru tahmin Hocanızla milli piyango oynayın");
            }
            else
            {

                Console.WriteLine("Lütfen tekrar deneyiniz " +sansliSayi);
                goto Basla;
            }
        }
    }
}
