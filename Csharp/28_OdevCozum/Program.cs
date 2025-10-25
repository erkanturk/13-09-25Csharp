namespace _28_OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev cozum
            /* Ödev 
            static void KelimeSayilariniGoster isminde bir method tanımlayın ve parametresi string metin olsun. 
           Bu method string türünde verilen metin içindeki kelimeleri ayrıştırarak hangi kelimenin kaç kez tekrar ettiğini ekranda göstersin.
               string[] kelimeler = metin.ToLower().Split(ayracKarakterler, StringSplitOptions.RemoveEmptyEntries);
            */
            //string metin = "Pohpohçu pinti profesör pofur pofur pofurdayarak hınçla tunç çanak içinde punç içip pulverizatör prospektüsünü papaz balığı biblosunun berisindeki papatya buketinin bu yanına bıraktıktan sonra palas pandıras Pülümürlü Pötürgelinin getirdigi pörsük pötikare pöstekiyi Paluluların pıtırcık pazarında partenogenes pasaparolasını, pertavsız pervasız pervaz peyzajını ve perenospora pesterkerani pestilini posbıyıklı pisboğaz pedegoga Pınarbaşı’nda beş peşkirle peş peşe peşin peşkeş çekti, sonra da pılısmı pırtısmı topladı: ” Pingpong, pingpong, pingpong Piyango pingpong! Pingpong, pingpong! ” diyerek Posof’un pisipisi otundan yapılma pistovsu piposunu tüttüre tüttüre paytak paytak yürüyüp gitti.";
            //KelimeSayiLariniGoster(metin);
            #endregion
            #region Ödev 2 Sözlük Uygulaması
            SortedList<string,string> sozluk = new SortedList<string,string>();
            sozluk.Add("siyah", "black");
            sozluk.Add("beyaz", "white");
            sozluk.Add("kırmızı", "red");
            sozluk.Add("mavi", "blue");
            sozluk.Add("turuncu", "orange");
            sozluk.Add("yesil", "green");
            sozluk.Add("sari", "yellow");
            sozluk.Add("pembe", "pink");
            while (true)
            {
                Console.WriteLine("01-Arama\n02-Çıkarma\n03-Listeleme\n04-Çıkış");
                string secim = Console.ReadLine();
                if (secim=="1")
                {
                    Console.WriteLine("Aranacak Kelime:");
                    string kelime = Console.ReadLine().ToLower();
                    if (sozluk.ContainsKey(kelime))
                    {
                        Console.WriteLine(sozluk[kelime]);
                    }
                    else
                    {
                        Console.WriteLine("Sözlükte kelime bulunamadı eklemek ister misiniz (E/H)");
                        string cevap = Console.ReadLine().ToUpper();
                        if (cevap=="E")
                        {
                            Console.WriteLine($"{kelime} kelimesinin ingilizcesini giriniz.");
                            sozluk[kelime]=Console.ReadLine().ToLower();

                        }
                        else
                        {
                            Console.WriteLine("Sen bilirsin !!!!");
                        }
                    }
                }
                else if (secim=="2")
                {
                    Console.WriteLine("Çıkarılacak Kelime");
                    string kelime = Console.ReadLine().ToLower();
                    if (sozluk.ContainsKey(kelime))
                    {
                        sozluk.Remove(kelime);
                    }
                    else
                    {
                        Console.WriteLine("Sözlükte böyle bir kelime ekli değil");
                    }
                }
                else if (secim=="3")
                {
                    foreach (KeyValuePair<string, string> item in sozluk)
                    {
                        Console.WriteLine(item.Value+"=>"+item.Key);
                    }
                }
                else if (secim=="4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı seçim");
                }
            }
            #endregion

        }
        static void  KelimeSayiLariniGoster(string metin)
        {
            char[] ayracKarakterler = { ' ', ',', '.', '!', '?', ';', ':' };
            string[] kelimeler = metin.ToLower().Split(ayracKarakterler, StringSplitOptions.RemoveEmptyEntries);
            string[] benzersizKelimeler = new string[kelimeler.Length];
            int[] kelimeSayilari = new int[kelimeler.Length];
            int benzersizIndex = 0;
            foreach (var kelime in kelimeler)
            {
                bool bulundu = false;
                for (int i = 0; i<benzersizIndex; i++)
                {
                    if (benzersizKelimeler[i]==kelime)
                    {
                        kelimeSayilari[i]++;
                        bulundu=true;
                        break;
                    }
                }
                if (!bulundu)
                {
                    benzersizKelimeler[benzersizIndex]=kelime;
                    kelimeSayilari[benzersizIndex]=1;
                    benzersizIndex++;
                }

            }
            Array.Sort(kelimeSayilari, benzersizKelimeler, 0, benzersizIndex);
            Array.Reverse(kelimeSayilari, 0, benzersizIndex);
            Array.Reverse(benzersizKelimeler, 0, benzersizIndex);
            Console.WriteLine("Metindeki kelime sayıları (En çok geçenlerden başlayacak):");
            for (int i = 0; i<benzersizIndex; i++)
            {
                Console.WriteLine($"{benzersizKelimeler[i]}' kelimesi: {kelimeSayilari[i]} kez geçiyor ");
            }
        }
    }
}
