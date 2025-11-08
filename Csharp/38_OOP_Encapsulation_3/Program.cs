namespace _38_OOP_Encapsulation_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vatandas vatandas = new Vatandas();
            vatandas._AdSoyad="Erkan Türk";
            vatandas._TcNo=1234567891;

            vatandas._AdSoyad="Ali Yılmaz";
            vatandas._TcNo=12345678910;

            /* İşlem diye bir sınıfımız olsun bu sınıfdaki değerler kontrol edilsin yani kapsülleme yapılsın
             * Kullanıcının girdiği 2. değer 0 ise hata versin eğer 0 değil ve pozitif bir değer ise
             * Kullanıcının girdiği 1. sayı 2. sayıya bölünüp sonuç ekrana yazdırılsın
             
             */
            Islem islem = new Islem();
          
            islem._Sayi1=0;//Sayı sıfırdır bölünen 0 olamaz
            islem._Sayi1=-10;//Negatif bir sayı ile bölme işlemi yapamazsın
            islem._Sayi1=100;
            islem._Sayi2=-10;//Bölen Negatif olamaz
            islem._Sayi2=200;//Bölen Bölünenden büyük olamaz
            islem._Sayi2=0;//Bölen 0 Olamaz
            islem._Sayi2=2;//Bölme işlemi sonucu: 50


        }
    }
}
