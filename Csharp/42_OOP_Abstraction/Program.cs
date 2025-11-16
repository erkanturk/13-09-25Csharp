namespace _42_OOP_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Abstract nedir ?
             * Abstract class'lar oluştırılması istenen class'ların sadece base class olarak davranması
             * ve üzerinden bir instance(örneklem/nesne) oluşturulmaması istediğimiz durumlarda kullanılır
             * C# da bu fonksiyonaliteyi sağlamak için abstract keywordu kullanımı yeterlidir.
             * Abstract sınıflar içerisinde gövdesiz methodlar tanımlayabiliriz
             * Bu methodlar miras alınan sınıf içerisinde mutlaka gövdeleri doldurulmalıdır.
             * Abstract sınıflar alt sınıdlara abstract olan yapıları kullanmaya zorlarlar
             * Bu işleme biz implemete deriz
             * Abstract olarak işaretlenen yapılar override edilebilirler.
             * Sadece methodlar değil propertylerde abstract olabilirler.
             * .Net 9.0 ile birlikte gövdeli method da tanımlanabiliyor.
            */
            //Insan insan=new Insan();//New Insan diyemeyiz soyut bir yapının nesnesi oluşturulamaz
            Ogrenci ogrenci = new Ogrenci();
            //ogrenci.Create();
            //ogrenci.List();
            //ogrenci.Delete();
            //ogrenci.List();
            //ogrenci.Update();
            //ogrenci.List();
            //ogrenci.Find(50);
            Veli veli = new Veli();
            veli.Create();
            veli.List();
            veli.Update();
            veli.List();
            veli.Delete();
            veli.List();
        }
    }
    abstract class Insan
    {
        public abstract long TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public abstract void Create();//Gövdesiz method.
        public abstract void Update();
        public abstract void Delete();
        public abstract void List();
        public void Find(int id)
        {
            Console.WriteLine(id);//gövdeli method
        }

    }
    class Ogrenci : Insan
    {
        public string DersAdi { get; set; }
        public int DersSayisi { get; set; }
        public int OkulNo { get; set; }
        public override long TC { get; set; }

        public override void Create()
        {
            Console.WriteLine("Tc:");
            TC=long.Parse(Console.ReadLine());
            Console.WriteLine("Ders Sayısı:");
            DersSayisi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ders Adı");
            DersAdi=Console.ReadLine();
            Console.WriteLine("Okul Numarası");
            OkulNo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ad:");
            Ad=Console.ReadLine();
            Console.WriteLine("Soyad:");
            Soyad=Console.ReadLine();

        }

        public override void Delete()
        {
            Ad="";
            Soyad="";
            TC=0;
            DersSayisi = 0;
            DersAdi="";
        }

        public override void List()
        {
            Console.WriteLine($"Ad:{Ad}\nSoyad:{Soyad}\nDers:{DersAdi}\nOkulNo:{OkulNo}\nTc:{TC}\nDers Sayısı:{DersSayisi}");
        }

        public override void Update()
        {
            Create();
        }
    }
    class Veli : Insan
    {
        public string Tel {  get; set; }
        public override long TC { get; set  ; }

        public override void Create()
        {

            Console.WriteLine("Tc:");
            TC=long.Parse(Console.ReadLine());
            Console.WriteLine("Tel");
            Tel=Console.ReadLine();
            Console.WriteLine("Ad:");
            Ad=Console.ReadLine();
            Console.WriteLine("Soyad:");
            Soyad=Console.ReadLine();
        }

        public override void Delete()
        {
            Ad="";
            Soyad="";
            TC=0;
            Tel="";
        }

        public override void List()
        {
            Console.WriteLine($"{Ad}\n{Soyad}\n{Tel}\n{TC}");
        }

        public override void Update()
        {
            Create();
        }
    }
}
