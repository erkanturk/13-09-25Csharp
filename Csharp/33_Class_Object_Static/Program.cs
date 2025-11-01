namespace _33_Class_Object_Static
{
    internal class Program
    {
        int nonStaticFeild;
        static int staticFeild;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.nonStaticFeild = 10;//non static yapıya erişim için nesne oluşturulmalı
           // program.staticFeild;//static yapıya nesne oluşturmadan erişim sağlanabilir
           Program.staticFeild=20;
            /* Static sınıflar sadece static yapılar barındırır
             * Static olarak tanımlanan sınıfların methodları da static olmak zorundadır
             * Program çalıştığı sürece static yapılar bellekte kalır
             * Program çalışır çalışmaz static yapılar ayağa kalkar Yani arkaplanda sürekli çalışır
             * Static sınıflar new lenemezler yani nesne oluşturulamazlar
             * Direkt sınıf üzerinden erişimi sağlanır
             * Static sınıfların arka planında yine constructor yapısı vardır fakat static constructor yapısıdır.
             * Static sınıflarda property tanımlanırken static olarak tanımlanır
             
            */
            //BuzDolabi buzDolabi = new BuzDolabi();//nonStatic sınıf 
            //BuzDolabi buzDolabi1 = new BuzDolabi();//nonStatic sınıf 
            //BuzDolabi buzDolabi2 = new BuzDolabi();//nonStatic sınıf 
            //BuzDolabi buzDolabi3 = new BuzDolabi();//nonStatic sınıf 
            //BuzDolabi buzDolabi4 = new BuzDolabi();//nonStatic sınıf 
            //BuzDolabi buzDolabi5 = new BuzDolabi();//nonStatic sınıf 
            ////buzDolabi.Marka = "Beko";
            ////buzDolabi.Model = "X123";
            ////buzDolabi.Enerji="A++";
            ////buzDolabi.Fiyat=15000;


            //List<BuzDolabi> buzDolabis = new List<BuzDolabi>();
            //buzDolabi.Kaydet();
            // buzDolabis.Add(buzDolabi);
            // buzDolabi.Kaydet(buzDolabis);

            // foreach (var item in buzDolabis)
            // {
            //     Console.WriteLine(item.Marka+" "+item.Model+" "+item.Enerji+" "+item.Fiyat);
            // }
            //// SeedClass seedClass = new SeedClass();//Burası static bir sınıf olduğu için nesne oluşturulamaz

            // //SeedClass.Ekle2();//Bu alanda sınıf içerisinde new keywordu ile tanımlandı program çalışır çalışmaz bellekte yer alır ve bir defa kullanılır çağırılmadığı sürece tekrar etmez
            // //SeedClass.Ekle();
            // //SeedClass.Ekle();
            // List<BuzDolabi> dolap = new List<BuzDolabi>();
            // // SeedClass.Ekle(dolap);

            // BuzDolabi dolaplar = SeedClass.Ekle();

            // dolap.Add(dolaplar);

            // foreach (var item in dolap)
            // {
            //     Console.WriteLine(item.Marka+" "+item.Model+" "+item.Enerji+" "+item.Fiyat);
            // }

            // SeedClass.id=10;
            // BuzDolabi buz = new BuzDolabi();
            // buz.Id=10;
            // Console.WriteLine();
            //Random random = new Random();

            Console.WriteLine("Merhaba");//hata vermez çünkü Console sınıfı static bir sınıftır ve static methodlara erişim sağlanabilir
            //Console console = new Console();//hata verir çünkü Console sınıfı static bir sınıftır new lenemez
            //console.WriteLine("Merhaba Dünya");
        }
    }
}
