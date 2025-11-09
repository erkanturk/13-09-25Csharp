namespace _39_OOP_Inheritance_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İçecek diye parrent bir sınıfımız olsun ve bu sınıfın özekliklerini kullanacak child sınıflar yapalım ve program.cs tarafında Hem parrent hem child kendi özelliklerini kullanarak ekrana yazdırma işlemi yapsın.

            Kahve kahve = new Kahve();
            kahve.KahveTuru="Arabica";
            kahve.SutluMu=true;
            kahve.SogukMu=false;
            kahve.AlkolluMu=false;
            kahve.SekerliMi=false;
            kahve.SiseMi=false;
            kahve.Fiyat=150;
            kahve.Bilgi();

            Kola kola = new Kola();
            kola.SogukMu = true;
            kola.SiseMi = true;
            kola.SekerliMi = true;
            kola.AlkolluMu = false;
            kola.GazliMi = true;
            kola.Fiyat=100;
            kola.Ml=330;
            kola.Bilgi();
        }
    }
    class Icecek
    {
        public bool SogukMu { get; set; }
        public bool GazliMi { get; set; }
        public bool SekerliMi { get; set; }
        public bool AlkolluMu { get; set; }
        public bool SiseMi { get; set; }
        public double Fiyat { get; set; }

        public void Bilgi()
        {
            Console.WriteLine($"Soguk mu : {SogukMu} Gazlı mı {GazliMi} Şekerli mi : {SekerliMi} Şişe mi : {SiseMi} Alkollü mü : {AlkolluMu} Fiyat: {Fiyat}");
        }
    }
    class Kahve : Icecek
    {
        public string KahveTuru { get; set; }
        public bool SutluMu { get; set; }

        public new void Bilgi()
        {
            base.Bilgi();
            Console.WriteLine($"Kahve türü {KahveTuru} sütlü mü: {SutluMu}");
        }
    }
    class Cay : Icecek
    {
        public bool KacakMi { get; set; }
        public new void Bilgi()
        {
            base.Bilgi();
            Console.WriteLine($"Çay türü {KacakMi} ");
        }
    }
    class Kola : Icecek
    {
        public int Ml { get; set; }

        public new void Bilgi()
        {
            base.Bilgi();
            Console.WriteLine($"Miktar {Ml}");
        }
    }
}
