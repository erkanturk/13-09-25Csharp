namespace _39_OOP_Inheritance_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            Araba araba = new Araba();
            araba.Marka="Bmw";
            araba.Model="320d";
            araba.Renk="Siyah";
            araba.Vites="Otomatik";
            araba.Yakit="Benzin";
            araba.UretimYili="2025";
            araba.Motor="2000";
            araba.Bilgi();
            Console.WriteLine("***************");
            Ucak ucak = new Ucak();
              ucak.Marka="Boeng";
              ucak.Model="747";
              ucak.Kapasite=100;
              ucak.Yakit="Jet Yakıtı";
              ucak.UretimYili="2025";
            ucak.Motor="Uçak motoru";
            ucak.Bilgi();
            Console.WriteLine("***************");
            Tren tren = new Tren();
            tren.Marka="Siemens";
            tren.Model="b150";
            tren.VagonSayisi=10;
            tren.Yakit="Elektrik";
            tren.UretimYili="2025";
            tren.Motor="Tren Motoru";
            tren.Bilgi();
        }
    }
    class Arac
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Motor { get; set; }
        public string UretimYili { get; set; }
        public string Yakit { get; set; }
        public void Bilgi()
        {
            Console.WriteLine($"Marka:{Marka}\nModel:{Model}\nMotor Hacmi:{Motor}\nÜretim Yılı:{UretimYili}\nYakıt Tipi:{Yakit}");
        }

    }
    class Araba : Arac
    {
        public string Renk { get; set; }
        public string Vites { get; set; }
        public new void Bilgi()
        {
            base.Bilgi();
            Console.WriteLine($"Renk:{Renk}\nVites:{Vites}");
        }

    }
    class Tren : Arac
    {

        public int VagonSayisi { get; set; }
        public new void Bilgi()
        {
            base.Bilgi();
            Console.WriteLine($"Vagon:{VagonSayisi}");
        }
    }
    class Ucak : Arac
    {
        public int Kapasite { get; set; }
        public new void Bilgi()
        {
            base.Bilgi();
            Console.WriteLine($"Kapasite:{Kapasite}");
        }
    }
}
