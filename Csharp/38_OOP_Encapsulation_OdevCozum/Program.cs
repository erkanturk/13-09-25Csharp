namespace _38_OOP_Encapsulation_OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            while (true)
            {
                Console.WriteLine("Muhasebe işlemlerine hoşgeldiniz");
                Console.WriteLine("Muhasabe işlemleri için 1 e basınız Çıkış için Q ya basınız");
                string secim = Console.ReadLine().ToUpper();
                if (secim=="1")
                {
                    Console.WriteLine("Muhasebe Kullanıcı bilgisi giriniz");
                    string kullanici = Console.ReadLine().ToUpper();
                    Console.WriteLine("Şifrenizi giriniz");
                    string sifre = Console.ReadLine().ToUpper();
                    if (kullanici=="ADMİN"&&sifre=="A123")
                    {
                        Console.WriteLine("Yatırılacak miktar");
                        double tutar = Convert.ToDouble(Console.ReadLine());
                        account.Deposit(tutar);
                        Console.WriteLine($"Muhasebe tarafından transfer edilen miktar {tutar}");
                    }
                    continue;
                }
                else if (secim=="Q")
                {
                    Console.WriteLine("İyi günler");
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı işlem");
                }

            }
            while (true)
            {
                Console.WriteLine("Çiftlik banka hoşgeldiniz");
                Console.WriteLine("01-Para Çekme\n02-Güncel Bakiye \n03-Para Yatırma\n04-Kart İade");
                string cevap = Console.ReadLine();
                if (cevap=="1")
                {
                    Console.WriteLine("Çekmek istediğiniz tutarı belirtin");
                    double tutar = Convert.ToDouble(Console.ReadLine());
                    account.WithDraw(tutar);
                    Console.WriteLine($"Güncel Bakiyeniz {account.Balance()}");
                    Thread.Sleep(2000);
                }
                else if (cevap=="2")
                {
                    Console.WriteLine($"Güncel Bakiyeniz {account.Balance()}");
                    Thread.Sleep(2000);
                }
                else if (cevap=="3")
                {
                    Console.WriteLine("Yatırmak istediğiniz tutar");
                    double yatirilacakTutar = Convert.ToDouble(Console.ReadLine());
                    account.Deposit(yatirilacakTutar);
                    Console.WriteLine($"Güncel Bakiyeniz {account.Balance()}");
                    Thread.Sleep(2000);
                }
                else if (cevap=="4")
                {
                    Console.Clear();
                    Console.WriteLine("Yine bekleriz");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama Ana menüye yönlendiriliyorsunuz");
                    Thread.Sleep(2000);
                }
            }
        }
    }
    class BankAccount
    {
        private double hesap = 20000;
        public double _Hesap
        {
            get { return hesap; }
            set
            {
                if (value>0)
                {
                    hesap = value;
                }
                else
                {
                    Console.WriteLine("Hesap bakiyesi 0 veya daha küçük olamaz");
                }
            }
        }
        public void WithDraw(double tutar)
        {
            if (tutar>0&&tutar<=hesap)
            {
                hesap -= tutar;
                Console.WriteLine($"{tutar}  tl çekimi yapıldı güncel hesap {hesap}");
            }
            else
            {
                if (tutar<=0)
                {
                    Console.WriteLine("Geçersiz bakiye işlemi");
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye");
                }
            }

        }
        public void Deposit(double tutar)
        {
            if (tutar>0)
            {
                hesap += tutar;
            }
            else
            {
                Console.WriteLine("negatif işlem yapılamaz");
            }
        }
        public double Balance()
        {
            return hesap;
        }
    }
}
