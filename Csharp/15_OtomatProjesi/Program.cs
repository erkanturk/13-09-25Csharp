namespace _15_OtomatProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OtomatProje Ödev
            /* 

      Müşteri Daha önceden tanımlanmış bir ürün listesinden bir ürün seçecek. 
     Para girişi yapacak. Girilen para seçilen ürünün fiyatını karşılar ise ürün alındı, 
         aksi durumda para ekle seçeneği ile tekrar para girmesi sağlanacak.

      // Admin => Ürün Ekleyecek, Ürün Silecek, Fiyat Güncelleyecek aynı ürün liste de 
         var ise eklenmeyecek yok ise eklenecek
        Admin şifresi 3 defa yanlış girilince 10 saniye bekletecek hesap kitlenmiştir 
         uyarısı veririp açıldığında bilgilendirecek
      */
            #endregion

            #region Ödev Çözüm
            bool admin = false;
            string password = "123";
            string girilenPass;
            int hataliGiris = 0;
            bool kilitli = false;
            string[] urunler = { "kola", "fanta", "büsküvi", "çikolata", "su" };
            double[] fiyatlar = { 60, 60, 40, 30, 20 };
            double bakiye = 0;
            while (true)
            {
                try
                {
                    for (int i = 0; i<urunler.Length; i++)
                    {
                        Console.WriteLine($"{i}-{urunler[i]}:{fiyatlar[i]}");
                    }
                    Console.WriteLine("Ürün Numarasını Seçiniz (Admin girişi için -1 e basınız)");
                    int urunNo = Convert.ToInt32(Console.ReadLine());
                    if (urunNo==-1)
                    {
                        Console.Clear();
                        if (!kilitli)//Kitli değilse
                        {
                            while (hataliGiris<3)
                            {
                                Console.WriteLine("Admin Şifrenizi Giriniz");
                                girilenPass = Console.ReadLine();
                                if (girilenPass==password)
                                {
                                    admin = true;
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    hataliGiris++;
                                    Console.WriteLine("Yanlış Şifre! Kalan Hakkınız: "+(3-hataliGiris));
                                }
                                if (hataliGiris==3)
                                {
                                    Console.WriteLine("Yanlış giriş yapıldı Hesap 10 Sayine Kitlendi");
                                    kilitli = true;
                                    Thread.Sleep(10000);
                                    kilitli=false;
                                    hataliGiris=0;
                                }
                            }
                           
                        }
                        else
                        {
                            Console.WriteLine("Hesap Kitlendi Lütfen Bekleyin");
                            Thread.Sleep(10000);
                            kilitli=false;
                        }
                        continue;
                    }
                    Console.WriteLine("Para Girişi Yapınız:");
                    bakiye=Convert.ToDouble(Console.ReadLine());
                    if (bakiye>=fiyatlar[urunNo])
                    {
                        Console.WriteLine("Ürünü aldınız.\nAfiyet Olsun\nPara Üstü: "+(bakiye-fiyatlar[urunNo]));
                        Thread.Sleep(2000);
                        bakiye=0;
                        Console.Clear();
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("Yetersiz Bakiye!");
                            Console.WriteLine("Para Ekle 1 \nPara İade 2");
                            int secim = Convert.ToInt32(Console.ReadLine());
                            if (secim==1)
                            {
                                Console.WriteLine("Para Ekle");
                                bakiye+=Convert.ToDouble(Console.ReadLine());
                                if (bakiye>=fiyatlar[urunNo])
                                {
                                    Console.WriteLine("Ürünü aldınız.\nAfiyet Olsun\nPara Üstü: "+(bakiye-fiyatlar[urunNo]));
                                    Thread.Sleep(2000);
                                    bakiye=0;
                                    Console.Clear();
                                    break;
                                }
                            }
                            else if (secim==2)
                            {
                                Console.WriteLine("Para İade Edildi");
                                Thread.Sleep(2000);
                                bakiye=0;
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Tuşlama");
                                Thread.Sleep(2000);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: "+ex.Message);

                }
                if (admin)
                {
                    Console.Clear();
                    while (true)
                    {
                        Console.WriteLine("Admin Paneli");
                        Console.WriteLine("1 Ürün Ekleme\n2 Ürün Güncelleme\n3 Ürün Silme\n4 Ürün Listeleme\n5 Çıkış");
                        int secim = Convert.ToInt32(Console.ReadLine());
                        if (secim==1)
                        {
                            Console.WriteLine("Ürün Adınızı Giriniz:");
                            string urunAdi = Console.ReadLine().ToLower();
                            bool kontrol = false;
                            for (int i = 0; i<urunAdi.Length; i++)
                            {
                                if (urunler[i].ToLower()==urunAdi)
                                {
                                    kontrol = true;
                                    break;
                                }
                            }
                            if (kontrol)
                            {
                                Console.WriteLine("Ürün Zaten Mevcut");
                                Thread.Sleep(2000);
                                continue;
                            }
                            Console.WriteLine("Ürün Fiyatı Giriniz");
                            double fiyat = Convert.ToDouble(Console.ReadLine());
                            Array.Resize(ref urunler, urunler.Length+1);//uzunluk 6
                            Array.Resize(ref fiyatlar, fiyatlar.Length+1);
                            urunler[urunler.Length-1]=urunAdi;//uzunluğun -1 = index değeri
                            fiyatlar[fiyatlar.Length-1]=fiyat;
                            Console.WriteLine("Ürün eklendi.");
                            Thread.Sleep(2000);

                        }
                        else if (secim==2)
                        {
                            for (int i = 0; i<urunler.Length; i++)
                            {
                                Console.WriteLine($"{i}-{urunler[i]}:{fiyatlar[i]}");
                            }
                            Console.WriteLine("Güncellenecek ürün numarası");
                            int guncellenecekNo = Convert.ToInt32(Console.ReadLine());
                            if (guncellenecekNo>=0&&guncellenecekNo<urunler.Length)
                            {
                                Console.WriteLine("Yeni ürün adı:");
                                string yeniUrun = Console.ReadLine().ToLower();
                                Console.WriteLine("Yeni Fiyat");
                                double yeniFiyat = Convert.ToDouble(Console.ReadLine());
                                urunler[guncellenecekNo]=yeniUrun;
                                fiyatlar[guncellenecekNo]=yeniFiyat;
                                Console.WriteLine("Ürün Güncellendi");
                                Thread.Sleep(2000);


                            }
                            else
                            {
                                Console.WriteLine("Hatalı Değer");
                            }
                        }
                        else if (secim==3)
                        {
                            for (int i = 0; i<urunler.Length; i++)
                            {
                                Console.WriteLine($"{i}-{urunler[i]}:{fiyatlar[i]}");
                            }
                            Console.WriteLine("Silinecek Ürün Numarası");
                            int silinecekNo = Convert.ToInt32(Console.ReadLine());
                            if (silinecekNo>=0&&silinecekNo<urunler.Length)
                            {
                                for (int i = silinecekNo; i<urunler.Length-1; i++)
                                {
                                    urunler[i]=urunler[i+1];
                                    fiyatlar[i]=fiyatlar[i+1];
                                }
                                Array.Resize(ref urunler, urunler.Length-1);
                                Array.Resize(ref fiyatlar, fiyatlar.Length-1);
                                Console.WriteLine("Ürün Silindi");
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Seçim");
                            }
                        }
                        else if (secim==4)
                        {
                            for (int i = 0; i<urunler.Length; i++)
                            {
                                Console.WriteLine($"{i}-{urunler[i]}:{fiyatlar[i]}");
                            }
                            Thread.Sleep(3000);
                        }
                        else if (secim==5)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Tuşlama");
                        }


                    }
                    admin=false;
                }
            }
            #endregion

        }
    }
}
