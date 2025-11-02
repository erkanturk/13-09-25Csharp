namespace _34_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Ödev
            //KitapKategori adında  enum oluşturarak içerisine,
            //BilimKurgu=0, DunyaKlasikleri=1, Psikoloji=2 olmak üzere 3 kategori ekleyelim.
            //Kullanıcıdan sayısal veya metinsel olarak   kategori girmesini isteyelim,
            //girilen değeri KitapKategori enum'ına çevirerek switch case ile kontrol edip aşağıda belirtilen şekilde mesajı yazdıran programı yazalım.
            //BilimKurgu ise: "Bilim Kurgu kategorisindeki kitaplar A reyonundadır."
            //DunyaKlasikleri ise:  "Dünya Klasikleri kategorisindeki kitaplar B reyonundadır."
            //Psikoloji ise:  "Psikoloji kategorisindeki kitaplar C reyonundadır."
            #endregion
            /* Sabit sayısal Değerler enumlar
             * Enumlar yani sabitler olarak adlandırılan yapılardır bu veri tipi hem sayısal hem metinsel olarak bize değer dönderir
             * sabit veri yapılarında genelde enum yapısı kullanılır
             * Bir veriyi veritabanında sayısal olarak tutarken program içerisinde ise metinsel olarak kullanmak istediğimizde enum yapısı kullanılır
             * Enumlar varsayılan olarak int tipindedir ve 0'dan başlar 1,1 artarak devam ederler
             * Eğer istenirse enum yapısının başlangıç değeri verilebilir ve veri tipi tam sayı tipi olarak belirtilebiliriz
             * Eğer sayısal değerleri elle veriyorsak her eleman farklı bir sayısal değer almalıdır aksi takdirde hata alırız
             * Aynı sayısal değeri birden fazla eleman alamaz
            
            */
            #region Enum  örnek 1
            Araba araba = new Araba();
            //araba.Marka = Markalar.BMW;
            //araba.Model = "3.20i";
            //araba.Renk = Renkler.Mavi;
            //araba.Vites = Vitesler.Otomatik;
            //araba.Bilgi();

            //Console.WriteLine(Markalar.BMW);

            //Markalar s2 = Markalar.Honda;
            //Console.WriteLine(s2);
            //Console.WriteLine((int)s2);
            //Console.WriteLine((int)Markalar.Audi);

            string[] markalar = Enum.GetNames(typeof(Markalar));//typeof ile enum tipi verilir
            int[] markalar2 = (int[])Enum.GetValues(typeof(Markalar));//enum değerleri int tipine cast edilerek diziye atılır
            //foreach (var item in markalar2)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var deger in markalar)
            //{
            //    Console.WriteLine(deger);
            //}

            //bool sonuc = Enum.IsDefined(typeof(Markalar), 4);//4 değeri Markalar enum yapısında tanımlı mı?
            //bool sonuc2 = Enum.IsDefined(typeof(Markalar), "BMW");//BMW değeri Markalar enum yapısında tanımlı mı?
            //Console.WriteLine(sonuc);
            //Console.WriteLine(sonuc2);

            //for (int i = 0; i<15; i++)
            //{
            //    string backColor = i.ToString();
            //    string foreColor = i.ToString();
            //    //Console.BackgroundColor= (ConsoleColor)Enum.Parse(typeof(ConsoleColor), backColor);
            //    Console.ForegroundColor= (ConsoleColor)Enum.Parse(typeof(ConsoleColor), foreColor);
            //    Console.Clear();
            //    Console.WriteLine("TEst");
            //    Thread.Sleep(1000);
            //    if (i == 14)
            //    {
            //        i=0;
            //        continue;
            //    }
            //}
            Console.WriteLine("Bg rengi giriniz");
            string bg = Console.ReadLine();
            Console.WriteLine("Fr Rengi giriniz");
            string fr = Console.ReadLine();

            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), bg);
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), fr);
            Console.WriteLine("Renk ayarlandı");
            #endregion
        }
    }
    enum Markalar { Ford = 4, Toyota=2, Honda, BMW = 10, Audi }//varsayılan int tipinde tanımlandı
    enum Renkler : byte { Kırmızı, Mavi, Yeşil, Beyaz, Siyah }//byte tipinde tanımlandı
    enum Vitesler : int { Manuel = 1, Otomatik = 2, YarıOtomatik = 3 }//int tipinde tanımlandı
    class Araba
    {
        public string Model;
        public Markalar Marka;
        public Renkler Renk;
        public Vitesler Vites;
        public void Bilgi()
        {
            Console.WriteLine("Marka: " + Marka);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Renk: " + Renk);
            Console.WriteLine("Vites: " + Vites);
        }
    }
}
