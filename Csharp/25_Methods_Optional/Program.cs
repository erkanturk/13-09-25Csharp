namespace _25_Methods_Optional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Optional Parameters methods 
             * Bir methoda parametre vermeden de kullanılabilinir bu yapı isteğe bağlı parametre yapısı ile parametre vererek kullanmamızı sağlar 
             * eğer bir method içindeki parametreye değer verilmez ise method içindeki varsayılan değer kullanılır
             * eğer parametre verilirse varsayılan değer yerine verilen değer kullanılır
             * Sadece optional parametreleri vermek zorunda kalmıyoruz diğer parametreleri vermek zorundayız
             * Optional parametreler gelende en sonda tanımlanır

             */
            // Yaz();//Parametre verilmek zorundadır yoksa hata verir
            // Yaz("Merhaba Dünya");//Parametre verildiğinde verilen parametre kullanılır

            // Optional("Erkan","Türk",31,"İngiltere");//Eğer ülke değeri verilirse methoddaki değeri kullanmaz.
            Console.WriteLine("Ad");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaş");
            int yas = Convert.ToInt32(Console.ReadLine());
            // Insan(ad, soyad, yas);//ülke,meslek,şehir parametreleri verilmediği için methoddaki varsayılan değerler kullanılır
            // Insan(ad, soyad, yas, "", "Yazılım");//istediğim alana değer veremiyorum bunun için method parametresini direkt kullanmak gerekir.
            Insan(adiniz: ad, soyadiniz: soyad, yasiniz: yas, meslek: "Yazılım");
            //MEthod parametrelerini direkt kullanarak istediğimiz alana değer verebiliriz.
            Insan(soyadiniz: soyad, adiniz: ad, yasiniz: yas);
            //istediğim değerleri istediğim parametrelere istediğim sırayla verebilirim.
            //Yaz(metin: ad);

        }
        static void Yaz(string metin)
        {
            Console.WriteLine(metin);
        }
        static void Optional(string ad, string soyad, int yas, string ulke = "Türkiye")//varsayılan değer atandı
        {
            Console.WriteLine(ad+" "+soyad+" "+yas+" "+ulke);
        }
        static void Insan(string adiniz,string soyadiniz,int yasiniz,string ulke="Türkiye",string meslek="Serbest Meslek",string sehir="İstanbul")
        {
            Console.WriteLine($"Ad: {adiniz} Soyad: {soyadiniz} Yaş: {yasiniz} Ülke: {ulke} Meslek: {meslek} Şehir: {sehir}  ");
        }

    }
}
