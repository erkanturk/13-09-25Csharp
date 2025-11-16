namespace _44_OOP_Interface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
    public interface ICalisan
    {
        int SgkNo { get; set; }
        int Maas { get; set; }

        int MaasHesapla();
    }
    public interface IOzelIsci : ICalisan
    {
        public DateTime SozlesmeTarihi { get; set; }
    }
    public class Ogretmen : Insan, ICalisan
    {
        public int SgkNo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Maas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int MaasHesapla()
        {
            throw new NotImplementedException();
        }
    }
    public class Hizmetli : Insan, IOzelIsci
    {
        public DateTime SozlesmeTarihi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SgkNo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Maas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int MaasHesapla()
        {
            throw new NotImplementedException();
        }
    }
}
