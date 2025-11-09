namespace _39_OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Inheritance (Kalıtım)
             * Ortak özelliklere sahip classların tek bir class üzerinden miras alma yöntemi ile ortak olan
             * özelliklerin yazılmadan çekmesine ve sadece kendisine özel olan özellikleri tanımlamasını sağlar
            */
            Muh muh = new Muh();
            muh.Ad="Erkan";
            muh.Soyad="Türk";
            muh.Tc="123456789011";
            muh.Adres="Cafer ağa mahallesi mühürdar caddesi no 50 kadıköy/istanbul";
            muh.Maas=4000;
            muh.PersonelBilgi();
            Console.WriteLine("************************");
            Ik ik = new Ik();
            ik.Ad="Erkan";
            ik.Soyad="Türk";
            ik.Tc="123456789011";
            ik.Adres="Cafer ağa mahallesi mühürdar caddesi no 50 kadıköy/istanbul";
            ik.Maas=4000;
            ik.PersonelSayisi=50;
            ik.PersonelBilgi();

        }

    }
    class Personel//Parrent class
    {
        public string Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public double Maas { get; set; }

        public void PersonelBilgi()
        {
            Console.WriteLine($"Ad:{Ad} Soyad: {Soyad} Adres: {Adres} Maaş: {Maas}");
        }
    }
    class Ik : Personel //: ile kalıtım yani Inheritance miras alma işlemi yapılmaktadır
    {
        public int PersonelSayisi { get; set; }
        public new void PersonelBilgi()//Base sınıftaki Personel yapısını kullanarak kendi eklentisini de kullanabiliyor
        {
            Console.WriteLine($"Ad:{Ad} Soyad: {Soyad} Adres: {Adres} Maaş: {Maas} Personel Sayısı: {PersonelSayisi}");
        }

    }
    class Paz : Personel//child class
    {
        public int MusteriSayisi { get; set; }

    }
    class Muh : Personel
    {
        public DateTime IseGirisTarihi { get; set; }
        public Muh()
        {
            IseGirisTarihi = DateTime.Now;//işe giriş tarihi şimdiki zaman olarak ayarlansın 
        }
    }
}
