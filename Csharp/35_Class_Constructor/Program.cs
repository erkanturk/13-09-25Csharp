namespace _35_Class_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Constructor (Yapıcı Metot)
             * Constructor ctor olarakda tanımlanır 
             * instance oluşturulduğunda ilk çalışan metottur
             * Eğer bir sınıfta constructor tanımlanmazsa derleyici tarafından default (parametresiz) constructor oluşturulur
             * biz bu yapıyı görmeyiz fakat her new lendiğinde default constructor çalışır
             * this keywordu constructor yapısını tetikler
             * Constructorların geri dönüş tipi yoktur void ifadesi kullanılmaz
             * Constructorların adı sınıf adı ile aynı olmak zorundadır
             * Constructorlar overload edilebilir
             * Garbage Collector tarafından yönetilirler
             * Garbage collector yapısı sistem çağırıldığı anda tüm bilgileri ram belleğe atar
             * Constructor yapısıda bu bilgiler arasında yer alır
             * C C++ gibi dillerde desctructor yapısı kullanılır bu yapı  yıkıcı method olarak geçer 
             * Garbage collector yapısı destructor yapısını otomatik olarak yönetir en kolay tanımlanan en eski  veya en az kullanılan yapıları bellekten temizler
             * Constructor yapısının kullanım amacı nesne ilk oluşturulduğunda bazı başlangıç değerlerini atamak veya bazı işlemleri yapmaktır
             * Yani aslında bir nevi init (initialize) etme işlemidir DI (Dependency injection) dışa bağımlılık için kullanılır

             */

            //Kisi kisi = new Kisi();
            //kisi.Ad = "Ahmet";
            //kisi.Soyad = "Yılmaz";
            //kisi.Yas = 25;
            //kisi.Bilgi();
            //Kisi kisi1 = new Kisi("Erkan", "Türk", 31);
            //kisi1.Bilgi();
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.ogrenciNo = 1001;
            ogrenci.AdSoyad = "Mehmet Ak";
            ogrenci.Bilgi();
        }
    }
}
