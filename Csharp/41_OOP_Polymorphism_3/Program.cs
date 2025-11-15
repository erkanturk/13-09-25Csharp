namespace _41_OOP_Polymorphism_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insan insan = new Insan();
            insan.HareketEt();
            Balik balik = new Balik();
            balik.HareketEt();
            Yilan yilan = new Yilan();
            yilan.HareketEt();
            Kus kus = new Kus();
            kus.HareketEt();
        }
    }
}
