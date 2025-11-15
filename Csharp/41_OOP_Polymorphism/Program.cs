namespace _41_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* PolyMorphism (çok biçimcilik)
             * bir nesnenin farklı amaçlarla kullanılabileceği anlamına gelir ve static dinamik olmak üzere ikiye ayrılır
             * statik çok biçimcilik; method ve operatörlerin aşırı yüklenmesi (overload) olarak belirtilir.
             * dinamik çok biçimcilik: çzel sınıflardan miras alma yoluyla işlemlerin gerçekleştirilmesine verilen isimdir
             * 
             * Static polymorphism türünden methodların aşırı yüklenmesine yönelik bir çalışma biçimidir.
             * Dynamic polymorphism türünden methodların virtual(sanallaştırma) olarak işaretlenmesi sonucunda child sınıflar override (ezme) işlemi gerçekleştirir
             * 
             * Temel sınıfa ait bir methodun bazen türemiş sınıftan farklı bir şekilde kullanılması gerekebilir
             * bu durum temel sınıfın söz konusu methodu türemiş sınıfın değiştirip kullanabileceği
             * yönünde izin vermesi gerekir.Bu izin methodun temel sınıfta 'virtual' olarak tanımlanması sonucu verilmektedir
             * diğer bir ifade ile temel sınıfta virtual olarak tanımlanmış bir methodun türemiş sınıfta yeniden yazılabileceğini belirtmiş oluyoruz
             * 
             * Methodu override etmek
             * Temel sınıfta virtual olarak tanımlanmış bir yapı türemiş sınıfta yeniden yazılması base classtakini gecersiz kılma ezme işlemi
             * Temel sınıfta virtual method eğer public ise child sınıfta da public olur eğer protected ise protected olarak gelir
             
             
             */
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Kaydet();
            ogretmen.Yaz();
        }
    }
    class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public virtual void Kaydet()
        {
            //base yapısı 
            Console.WriteLine("Ad:");
            Ad=Console.ReadLine();
            Console.WriteLine("Soyad:");
            Soyad=Console.ReadLine();
            Console.WriteLine("Yaş");
            Yas=Convert.ToInt32(Console.ReadLine());
        }
        public virtual void Yaz()
        {
            Console.WriteLine(Ad+" "+Soyad+" "+Yas);
        }
    }
    class Ogretmen:Insan
    {
        public string Brans { get; set; }
        //public void Kaydet()
        //{
        //    //base yapısı 
        //    Console.WriteLine("Ad:");
        //    Ad=Console.ReadLine();
        //    Console.WriteLine("Soyad:");
        //    Soyad=Console.ReadLine();
        //    Console.WriteLine("Yaş");
        //    Yas=Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Brans");
        //    Brans=Console.ReadLine();
        //}
        public override void Kaydet()
        {
            Console.WriteLine("Brans");
            Brans=Console.ReadLine();
        }
        public override void Yaz()
        {
            base .Yaz();
            Console.WriteLine(Brans);
        }
    }
}
