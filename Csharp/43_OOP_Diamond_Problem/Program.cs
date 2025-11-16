namespace _43_OOP_Diamond_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Bir sınıfın birden fazla sınıftan miras alamamasına diamond problem denir buradaki örnekte insan yüzen ve yürüyen bir canlı fakat sadece bir sınıftan miras almaktadır.
             */
            Insan insan = new Insan();
            insan.Yuru();
            insan.HareketEt();
            //insan.Yuz();
        }
    }
}
