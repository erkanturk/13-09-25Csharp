namespace _06_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();//Instance (Örneklem Nesne oluşturma)
            //Random bir sınıf yapısı ve bu sınıfa ait hazır yapılar var
            //bu yapılar genelde simülasyon oyun vb. uygulamalarda kullanılır.
            int sayi = random.Next(1, 20);//1-19 20 yi dahil etmeden 1 ila 19 arasında rasgele bilgisayar tarafından üretilen sayılar oluşturacak
            Console.WriteLine(sayi);
        }
    }
}
