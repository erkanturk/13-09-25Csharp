namespace _42_OOP_Abstraction_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    abstract class Elektronik
    {
        public double AlisFiyati { get; set; }
        public double KarYuzdesi { get; set; }

        protected Elektronik()//kalıtımla kullanılabilir constructor
        {

        }
        public abstract double FiyatHesapla();
    }
    abstract class Elektirikli : Elektronik
    {
        public abstract int Volt { get; set; }
    }
    abstract class Sarjli : Elektronik
    {
        public abstract int MiliAmper { get; set; }
    }
    class Telefon : Sarjli
    {
        public override int MiliAmper { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override double FiyatHesapla()
        {
            throw new NotImplementedException();
        }
    }
    class Bilgisayar : Elektronik
    {
        public override double FiyatHesapla()
        {
            throw new NotImplementedException();
        }
    }
    class Buzdolabi : Elektirikli
    {
        public override int Volt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override double FiyatHesapla()
        {
            throw new NotImplementedException();
        }
    }
    //class Laptop:Sarjli,Elektirikli//Diamond Problem 
    //{

    //}
}
