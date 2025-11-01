using System.Collections;

namespace _32_ManavOtomasyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Manav Projesi Ödev
            /*
          HAL - Toptancı
         * Manava ürün almaya geliyor. Manava "Meyve mi Sebze mi?"
         * 5 adet meyve listelenecek
         * Meyve seçildikten sonra "Kaç Kilo?"
         * Meyve satıldıktan sonra "Başka bir arzunuz var mı?" 
         * Evet derse tekrar "Meyve mi Sebze mi?" satırına döndüreceğiz
         * Hayır. "iyi günler" diyerek manav kısmına geçeceğiz
         * 
         * 
          MANAV
         * "Meyve mi Sebze mi?" diye müşteriye soracağız.
         * Halden almış olduğumuz meyve veya sebzeleri listeleyeceğiz.
         * Müşteri ürün seçtikten sonra "Kaç Kilo?" sorusunu sorun
         * Girilen kilo bilgisini manavın halden aldığı kilo ile kıyaslayarak ürün satınız.
         * Elde olan ürün var olan kilosu kadar satılırsa, manavın ürünlerinden silin.
         * Ürün satıldıktan sonra "Başka bir arzunuz var mı?"
         * Evet derse tekrar "Meyve mi Sebze mi?" satırına döndüreceğiz
         * Hayır derse "Afiyet olsun" Müşteri kısmına geçiniz

         MÜŞTERİ
         * Alınan ürünleri ekrana yazdırınız.
          */
            #endregion
            ArrayList halMeyveler = new ArrayList() { "ELMA", "ARMUT", "MUZ", "ÇİLEK", "KARPUZ" };
            ArrayList halSebzeler = new ArrayList() { "DOMATES", "BİBER", "PATLICAN", "SALATALIK", "HAVUÇ" };
            ArrayList manavMeyveler = new ArrayList();
            ArrayList manavMeyveKilo = new ArrayList();
            ArrayList manavSebzeler = new ArrayList();
            ArrayList manavSebzeKilo = new ArrayList();
            ArrayList musteri = new ArrayList();

            Console.WriteLine("**** Gel Al Hale Hoşgeldiniz****");
            while (true)
            {
                Console.WriteLine("Meyve mi ? Sebze mi ? (M/S) Çıkış için Q ya basınız");
                string halSecim = Console.ReadLine().ToUpper();
                if (halSecim=="M")
                {
                    try
                    {
                        Console.WriteLine("1-Elma\n2-Armut\n3-Muz\n4-Çilek\n5-Karpuz");
                        int meyve = Convert.ToInt32(Console.ReadLine());
                        if (meyve==1)
                        {
                            UrunAl(manavMeyveler, "ELMA", manavMeyveKilo);
                        }
                        else if (meyve==2)
                        {
                            UrunAl(manavMeyveler, "ARMUT", manavMeyveKilo);
                        }
                        else if (meyve==3)
                        {
                            UrunAl(manavMeyveler, "MUZ", manavMeyveKilo);
                        }
                        else if (meyve==4)
                        {
                            UrunAl(manavMeyveler, "ÇİLEK", manavMeyveKilo);
                        }
                        else if (meyve==5)
                        {
                            UrunAl(manavMeyveler, "KARPUZ", manavMeyveKilo);
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz meyve seçimi");
                        }
                        Console.Clear();
                        Console.WriteLine("Başka bir arzunuz var mı ? (E/H)");
                        string cevap = Console.ReadLine().ToUpper();
                        if (cevap=="E")
                        {
                            continue;
                        }
                        else if (cevap=="H")
                        {
                            Console.Clear();
                            Console.WriteLine("İyi günler");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz cevap");
                            continue;
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Hata: "+ex.Message);
                    }
                }
                else if (halSecim=="S")
                {
                    try
                    {
                        Console.WriteLine("1-Domates\n2-Biber\n3-Patlıcan\n4-Salatalık\n5-Havuç");
                        int sebze = Convert.ToInt32(Console.ReadLine());
                        if (sebze==1)
                        {
                            UrunAl(manavSebzeler, "DOMATES", manavSebzeKilo);
                        }
                        else if (sebze==2)
                        {
                            UrunAl(manavSebzeler, "BİBER", manavSebzeKilo);
                        }
                        else if (sebze==3)
                        {
                            UrunAl(manavSebzeler, "PATLICAN", manavSebzeKilo);
                        }
                        else if (sebze==4)
                        {
                            UrunAl(manavSebzeler, "SALATALIK", manavSebzeKilo);
                        }
                        else if (sebze==5)
                        {
                            UrunAl(manavSebzeler, "HAVUÇ", manavSebzeKilo);
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz meyve seçimi");
                        }
                        Console.Clear();
                        Console.WriteLine("Başka bir arzunuz var mı ? (E/H)");
                        string cevap = Console.ReadLine().ToUpper();
                        if (cevap=="E")
                        {
                            continue;
                        }
                        else if (cevap=="H")
                        {
                            Console.Clear();
                            Console.WriteLine("İyi günler");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz cevap");
                            continue;
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Hata: "+ex.Message);
                    }
                }
                else if (halSecim=="Q")
                {
                    Console.WriteLine("Yine Bekleriz");
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim");
                }
            }
            while (true)
            {
                Console.WriteLine("***Batan Geminin Manavı ***");
                Console.WriteLine("Meyve mi ? Sebze mi ? (M/S) Çıkış için Q ya basınız");
                string manavSecim = Console.ReadLine().ToUpper();
                if (manavSecim=="M")
                {
                    if (manavMeyveler.Count==0)
                    {
                        Console.WriteLine("Elimizde meyve kalmadı");
                        continue;
                    }
                    for (int i = 0; i<manavMeyveler.Count; i++)
                    {
                        Console.WriteLine((i+1)+"-"+manavMeyveler[i]+" "+manavMeyveKilo[i]+"Kilo");
                    }
                    try
                    {
                        Console.WriteLine("Ürün Seçiniz(İsim veya Numara)");
                        string input = Console.ReadLine().ToUpper();
                        string meyve = "";
                        if (int.TryParse(input, out int meyveNo))
                        {
                            if (meyveNo>=1&&meyveNo<=manavMeyveler.Count)
                            {

                                meyve=manavMeyveler[meyveNo-1].ToString();
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz numara");
                                continue;
                            }
                        }
                        else
                        {
                            meyve=input;
                            if (!manavMeyveler.Contains(meyve))
                            {
                                Console.WriteLine("Olmayan Ürün Seçimi");
                                continue;
                            }
                        }
                        if (manavMeyveler.Contains(meyve))
                        {
                            Console.WriteLine("Kaç kilo");
                            int kilo = Convert.ToInt32(Console.ReadLine());
                            int index = manavMeyveler.IndexOf(meyve);
                            int mevcutKilo = (int)manavMeyveKilo[index];
                            if (mevcutKilo>=kilo)
                            {
                                mevcutKilo -= kilo;
                                musteri.Add(meyve+" "+kilo+" Kilo");
                                manavMeyveKilo[index] = mevcutKilo;
                                if (mevcutKilo==0)
                                {
                                    manavMeyveler.RemoveAt(index);
                                    manavMeyveKilo.RemoveAt(index);
                                }
                                Console.WriteLine($"Satış başarılı. {meyve} için kalan stok{mevcutKilo} kilo");
                            }
                            else
                            {
                                Console.WriteLine($"Yeterli stok yok mecut stok {meyve} - {mevcutKilo}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Olmayan ürün seçimi");
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Hatalı işlem: "+ex.Message);
                    }
                }
                else if (manavSecim=="S")
                {
                    if (manavSebzeler.Count==0)
                    {
                        Console.WriteLine("Elimizde Sebze kalmadı");
                        continue;
                    }
                    for (int i = 0; i<manavSebzeler.Count; i++)
                    {
                        Console.WriteLine((i+1)+"-"+manavSebzeler[i]+" "+manavSebzeKilo[i]+"Kilo");
                    }
                    try
                    {
                        Console.WriteLine("Ürün Seçiniz(isim veya numara)");
                        string input = Console.ReadLine().ToUpper();
                        string sebze = "";
                        if (int.TryParse(input, out int sebzeNo))
                        {
                            if (sebzeNo>=1&&sebzeNo<=manavSebzeler.Count)
                            {
                                sebze=manavSebzeler[sebzeNo-1].ToString();

                            }
                            else
                            {
                                Console.WriteLine("Geçersiz işlem");
                                continue;
                            }
                        }
                        else
                        {
                            sebze=input;
                            if (!manavSebzeler.Contains(sebze))
                            {
                                Console.WriteLine("Olmayan Ürün Seçimi");
                                continue;
                            }
                        }
                        if (manavSebzeler.Contains(sebze))
                        {
                            Console.WriteLine("Kaç kilo");
                            int kilo = Convert.ToInt32(Console.ReadLine());
                            int index = manavSebzeler.IndexOf(sebze);
                            int sebzeKilo = (int)manavSebzeKilo[index];
                            if (sebzeKilo>=kilo)
                            {
                                sebzeKilo -= kilo;
                                musteri.Add(sebze+" "+kilo+" Kilo");
                                manavSebzeKilo[index] = sebzeKilo;
                                if (sebzeKilo==0)
                                {
                                    manavSebzeler.RemoveAt(index);
                                    manavSebzeKilo.RemoveAt(index);
                                }
                                Console.WriteLine($"Satış başarılı. {sebze} için kalan stok {sebzeKilo} kilo ");
                            }
                            else
                            {
                                Console.WriteLine($"Yeterli stok yok mecut stok {sebze} - {sebzeKilo}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Olmayan ürün seçimi");
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Hatalı işlem: "+ex.Message);
                    }
                }
                else if (manavSecim=="Q")
                {
                    Console.WriteLine("Yine bekleriz");
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim");
                }
            }
            foreach (var item in musteri)
            {
                Console.WriteLine(item);
            }

        }
        static void UrunAl(ArrayList list, string urun, ArrayList kiloList)
        {
            if (list.Contains(urun)==false)
            {
                list.Add(urun);
                Console.WriteLine("Kaç kilo");
                int kilo = Convert.ToInt32(Console.ReadLine());
                kiloList.Add(kilo);
            }
            else
            {
                Console.WriteLine("Kaç kilo");
                int kilo = Convert.ToInt32(Console.ReadLine());
                int index = list.IndexOf(urun);
                int mevcutKilo = (int)kiloList[index];
                mevcutKilo += kilo;
                kiloList[index] = mevcutKilo;

            }
        }
    }
}
