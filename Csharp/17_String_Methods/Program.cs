namespace _17_String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metin = "C# Dersleri";
            string[] adSoyad = { "Erkan", "Türk" };
            string ad = "Hikmet";
            string soyad = "Yıldız";
            string text = "     String Metinler    ";
            string adlar = "Erkan,Onur,Tahsin,Altan";

            Console.WriteLine($"String Uzunluk: {metin.Length}");
            Console.WriteLine($"String Büyütme: {metin.ToUpper()}");
            Console.WriteLine($"String Küçülme: {metin.ToLower()}");
            bool buldum = metin.Contains("C#");//Varsa true yoksa false dönderir
            Console.WriteLine(buldum);
            string degistirilmisMetin = metin.Replace("C#", "Yazılım");
            //verdiğimiz değişkendeki istediğimiz alanı düzenleriz
            Console.WriteLine(degistirilmisMetin);
            string birlestirilmisDizi = string.Join(" ", adSoyad);
            Console.WriteLine(birlestirilmisDizi);
            string birlestirilmisMetin = string.Concat(ad, " ", soyad);
            Console.WriteLine(birlestirilmisMetin);
            Console.WriteLine("Boşluk temizleme: "+text.Trim());

            string[] adDizisi = adlar.Split(',');
            foreach (string s in adDizisi)
            {
                Console.WriteLine(s);
            }
            string parcalanmisMetin = metin.Substring(0, 5);//başlangıç indexi ve uzunluk gerekmektedir
            Console.WriteLine(parcalanmisMetin);

            string deger = "";

            if (string.IsNullOrEmpty(deger))//true veya fasle değer dönderir
            {
                Console.WriteLine("Değer boş");
            }
            string deger2 = "TR qweqwkejalmsduasdyaısudhyqıwı";
            if (deger2.StartsWith("TR"))//true veya false değer dönderir
            {
                Console.WriteLine("Değer TR ile başlıyor");
            }
            string deger3 = "tr";
            string deger4 = "TR";

            if (!string.Equals(deger3, deger4))
            {
                Console.WriteLine("Değerler aynı değil");
            }

        }
    }
}
