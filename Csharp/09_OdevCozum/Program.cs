namespace _09_OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev1
            //Console.WriteLine("Adınız:");
            //string ad = Console.ReadLine();
            //Console.WriteLine("Yaşınız:");
            //int yas =Convert.ToInt32( Console.ReadLine());
            //Console.WriteLine("Çocuk sayısı");
            //int cocukSayisi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Maaşınız");
            //double maas = Convert.ToDouble(Console.ReadLine());
            //if (yas>0&&yas<45)
            //{
            //    if (cocukSayisi>=3)
            //    {
            //        maas=maas+(cocukSayisi*2000);
            //        Console.WriteLine($"Sayın {ad} alacağınız maaş {maas}");
            //    }
            //    else
            //    {
            //        maas=maas+(cocukSayisi*2500);
            //        Console.WriteLine($"Sayın {ad} alacağınız maaş {maas}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"Sayın {ad} alacağınız maaş {maas+5000}");
            //}
            #endregion
            #region Ödev 2

            //Console.WriteLine("1.Sayı");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayi");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("3. sayi");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //if (sayi>sayi2&&sayi>sayi3)
            //{
            //    Console.WriteLine("En büyük sayı "+sayi);
            //    if (sayi2>sayi3)
            //    {
            //        Console.WriteLine("Ortanca Sayı "+sayi2);
            //        Console.WriteLine("En küçük sayı "+sayi3);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ortanca Sayı "+sayi3);
            //        Console.WriteLine("En küçük sayı "+sayi2);
            //    }
            //}
            //else if (sayi2>sayi&&sayi2>sayi3)
            //{
            //    Console.WriteLine("En büyük sayı "+sayi2);
            //    if (sayi>sayi3)
            //    {
            //        Console.WriteLine("Ortanca Sayı "+sayi);
            //        Console.WriteLine("En küçük sayı "+sayi3);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ortanca Sayı "+sayi3);
            //        Console.WriteLine("En küçük sayı "+sayi);
            //    }
            //}
            //else if (sayi3>sayi2&&sayi3>sayi)
            //{
            //    Console.WriteLine("En büyük sayı "+sayi3);
            //    if (sayi>sayi2)
            //    {
            //        Console.WriteLine("Ortanca Sayı "+sayi);
            //        Console.WriteLine("En küçük sayı "+sayi2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ortanca Sayı "+sayi2);
            //        Console.WriteLine("En küçük sayı "+sayi);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Sayılar birbirine eşittir.");
            //}

            #endregion
            #region Ödev 3 Switch Case
            //Console.WriteLine("Cinsiyetinizi giriniz");
            //string cinsiyet = Console.ReadLine().ToUpper();
            //try
            //{
            //    switch (cinsiyet)
            //    {
            //        case "ERKEK":
            //            Console.WriteLine("Yaş");
            //            int yas = Convert.ToInt32(Console.ReadLine());
            //            if (yas>=60)
            //            {
            //                Console.WriteLine("Maaş");
            //                double maas = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine("Emeklilik ikramiyeniz "+(maas*10));


            //            }
            //            else
            //            {
            //                Console.WriteLine("Prim gün sayınız");
            //                int prim = Convert.ToInt32(Console.ReadLine());
            //                if (prim>=6000)
            //                {
            //                    Console.WriteLine("Maaş");
            //                    double maas = Convert.ToDouble(Console.ReadLine());
            //                    Console.WriteLine("Emeklilik ikramiyeniz "+(maas*11));
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Emeklilik yalan oldu çalışmaya devam");
            //                }
            //            }
            //            break;
            //        case "E":
            //            Console.WriteLine("Yaş");
            //            int yas1 = Convert.ToInt32(Console.ReadLine());
            //            if (yas1>=60)
            //            {
            //                Console.WriteLine("Maaş");
            //                double maas = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine("Emeklilik ikramiyeniz "+(maas*10));


            //            }
            //            else
            //            {
            //                Console.WriteLine("Prim gün sayınız");
            //                int prim = Convert.ToInt32(Console.ReadLine());
            //                if (prim>=6000)
            //                {
            //                    Console.WriteLine("Maaş");
            //                    double maas = Convert.ToDouble(Console.ReadLine());
            //                    Console.WriteLine("Emeklilik ikramiyeniz "+(maas*11));
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Emeklilik yalan oldu çalışmaya devam");
            //                }
            //            }
            //            break;
            //        case "KADIN":
            //            Console.WriteLine("Yaş");
            //            int yas2 = Convert.ToInt32(Console.ReadLine());
            //            if (yas2>=55)
            //            {
            //                Console.WriteLine("Maaş");
            //                double maas = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine("Emeklilik ikramiyeniz "+(maas*10));


            //            }
            //            else
            //            {
            //                Console.WriteLine("Prim gün sayınız");
            //                int prim = Convert.ToInt32(Console.ReadLine());
            //                if (prim>=5400)
            //                {
            //                    Console.WriteLine("Maaş");
            //                    double maas = Convert.ToDouble(Console.ReadLine());
            //                    Console.WriteLine("Emeklilik ikramiyeniz "+(maas*11));
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Emeklilik yalan oldu çalışmaya devam");
            //                }
            //            }
            //            break;
            //        case "K":
            //            Console.WriteLine("Yaş");
            //            int yas3 = Convert.ToInt32(Console.ReadLine());
            //            if (yas3>=55)
            //            {
            //                Console.WriteLine("Maaş");
            //                double maas = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine("Emeklilik ikramiyeniz "+(maas*10));


            //            }
            //            else
            //            {
            //                Console.WriteLine("Prim gün sayınız");
            //                int prim = Convert.ToInt32(Console.ReadLine());
            //                if (prim>=5400)
            //                {
            //                    Console.WriteLine("Maaş");
            //                    double maas = Convert.ToDouble(Console.ReadLine());
            //                    Console.WriteLine("Emeklilik ikramiyeniz "+(maas*11));
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Emeklilik yalan oldu çalışmaya devam");
            //                }
            //            }
            //            break;
            //            default : Console.WriteLine("Hatalı işlem "); break;
            //    }
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Hata "+ex.Message);
            //}
          
            #endregion
        }
    }
}
