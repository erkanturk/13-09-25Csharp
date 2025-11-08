namespace _37_Class_Enum_OdevCozum
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
            Console.WriteLine("Kategori Seçiniz");
            string kategori = Console.ReadLine();
            KitapKategori kitapKategori = (KitapKategori)Enum.Parse(typeof(KitapKategori), kategori);
            switch (kitapKategori)
            {
                case KitapKategori.BilimKurgu:
                    Console.WriteLine("Bilim kurgu kategorisi A Reyonundadır");
                    break;
                case KitapKategori.DunyaKlasikleri:
                    Console.WriteLine("Dünya klasikleri kategorisi B Reyonundadır");
                    break;
                case KitapKategori.Psikoloji:
                    Console.WriteLine("Psikoloji kategorisi C Reyonundadır");
                    break;
                case KitapKategori.Aksiyon:
                    Console.WriteLine("Aksiyon kategorisi D Reyonundadır");
                    break;
                case KitapKategori.Macera:
                    Console.WriteLine("Macera kategorisi E Reyonundadır");
                    break;
                default:
                    Console.WriteLine("Hatalı seçim");
                    break;
            }

        }
    }
}
