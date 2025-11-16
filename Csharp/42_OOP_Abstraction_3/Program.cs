namespace _42_OOP_Abstraction_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev
            //Örnek: Bir tane Tasit sınıfı oluşturalım ancak bu sınıftan nesne üretilemesin.
            //İçerisinde Marka, Model, TabanFiyat property'leri  bir de türeyen her sınıfa
            //özel hesaplanacak abstract Fiyat property'si ekleyelim.
            //Tasit'dan türeyen Araba, Ucak, Tren ve Gemi class'larımız olsun.
            //Araba'ya özel fiyat hesabı YakitTuru, VitesTuru bilgilerine göre yapılsın
            //(Dizel'se +5000, Otomatikse'se +10000)
            //Uçak'a özel fiyat hesabı kapasite bilgisine göre yapılsın.
            //(Kapasite başına +100)
            //Trene özel fiyat hesabı vagon sayısı ve sınıf bilgisine göre yapılsın
            //(sınıf A ise + 50000, B ise +10000 vagon sayısı başına + 30000)
            //Gemi'ye özel fiyat hesabı kamara sayısına göre yapılsın
            //(kamara başına +40000)
            #endregion
            Canli canli = new Balik();//Canlı türünden türemiş bir balık
            canli.HareketEt();
            canli=new Kus();
            canli.HareketEt();
            canli=new Yilan();
            canli.HareketEt();
            canli=new Insan();
            canli.HareketEt();
        }
    }
}
