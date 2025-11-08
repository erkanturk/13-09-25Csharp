namespace _38_OOP_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OOP Nedir 
            /*Object Oriented Programming - Nesne Yönelimli Programlama
             * İlk yazılım sıralı satırlar olarak geliştiriliyordu
             * Sonrasında Class yapısı üzerinden geliştirilmeye başlandı fakat hala büyük çaplı projeler yazılamıyordu
             * C dili => Oop geliştirilmesi ile C++ dili ortaya çıktı
             * C++ gün geçtikçe popüleritesini kaybeden ama önceki yıllarda yazılmış projeler üzerinden hala çok güçlü bir dil olarak kullanılmaya devam ediyor
             * Makine diline en yatkın dildir  siber güvenlik otomobil beyni vb işlemler için hala kullanılıyor
             * İnternetin icadı ile birlikte Java ve C# dilleri ortaya çıktı
             * Bize sağladığı kolaylıklardan biri Oop yapısı ve Garbage collector yapısıdır
             * Oop nin 4 temel yapısı vardır 
             * 
             * Encapsulation(Kapsülleme)
             * Inheritance(Miras alma/Kalıtım)
             * Polymorphism(Çok biçimcilik)
             * Abstraction(Soyutlama)
                         
             */
            #endregion
            #region Encapsulation(Kapsülleme)
            /* Nesnenin iç detaylarını gizleyerek dışarıdan erişimini kontrollü hale getirmektir.
             * Bu sayede veri bütünlüğü korunur ve nesnenin kullanımı daha kolay daha güvenli hale gelir.
             * Doğrudan propertye erişimi engellenerek istenmeyen değer atanmalarının önüne geçilir.
             * Özellikler aracılığıyla değer ataması yaparken gerekli kontrolleri  gerçekleştirebiliriz
             * Property(özellik)
             * Sınıf içerisindeki özel alanlara kontrollü erişim sağlar
             * Propertylerin get ve set blokları vardır bu bloklar 
             * Get=> var olan değeri okumak görüntülemek (getirmek) için kullanılır
             * Set=> var olan değeri yada olmayan bir değeri eklemek güncellemek için kullanılır.
             */
            #endregion
            #region Örnek1
            Ogrenci ogrenci = new Ogrenci();
            //ogrenci.Ortalama=70; sadece get olduğu için içerisinde olan değeri sadece okuyacak 
            //biz dışarıdan bir güncelleme işlemi yapamayız set kısmı eklenmediği için sadece get property
            //ogrenci.vize;//hata verir çünkü feild yapısı private olarak işaretlendi
            Console.WriteLine("Öğretmen girişi bilgilerinizi giriniz");
            string kullanici = Console.ReadLine();
            Console.WriteLine("Şifreniz");
            string sifre = Console.ReadLine();
            if (kullanici=="admin"&&sifre=="123")
            {
                Console.WriteLine("Öğrenci vize notunu giriniz");
                ogrenci._Vize=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Öğrencinin final notunu giriniz");
                ogrenci._Final=Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Öğrenci girişi için kullanıcı adı şifrenizi giriniz");
            string kad = Console.ReadLine();
            Console.WriteLine("Şifreniz");
            string pass = Console.ReadLine();
            if (kad=="Ogr"&&pass=="1")
            {
                Console.WriteLine($"Finalden aldığınız not: {ogrenci._Final}");
                Console.WriteLine($"Vize aldığınız not: {ogrenci._Vize}");
                Console.WriteLine($"Ortalama not: {ogrenci.Ortalama}");
            }
            #endregion
        }
    }
}
