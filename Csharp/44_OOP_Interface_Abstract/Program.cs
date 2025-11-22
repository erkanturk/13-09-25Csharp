namespace _44_OOP_Interface_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir parrent sınıfımız olsun ve bu sınıfta ortak özellikler olsun
            //bu parrent sınıflar child sınıflara miras verecek fakat 
            //Birden fazla yapıdan miras alabilmesi için ortak olarak diamond problemin önüne geçilecek 
            //Yani 2 adet interface tanımlanacak ve bu interfaceler de child sınıflarda 
            //implemente edilecek.
            Insan insan = new Insan();
            insan.Tur="Türk";
            insan.Ad="Mahmut";
            insan.Boy="170";
            insan.VahsiMi=false;
            insan.SaldırganMi=false;
            insan.Kilo="70";
            insan.Tc="165464";
        }
    }
}
