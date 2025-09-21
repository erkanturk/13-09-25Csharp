namespace _01_Algoritma//il
{
    internal class Program//ilçe
    {
        static void Main(string[] args)//Ev
        {
            Console.WriteLine("Hello, World!");//Ekrana Çıktı alma yöntemi.
            //Tekli yorum satırı.
            //merhaba c# tarafı bilgisayar ile haberleşmeyi sağlayan bir programlama dilidir.
            //bu yapıda yazdığımız ve yaptırmak istediğimiz işlemleri Ide aracılığı ile
            //Bilgisayarın anlıyacağı bir yapıya çevrilir ve karşılığında bize 
            //bilgisayar cevap verir.
            Console.WriteLine("Merhaba Ben Erkan Türk 31 yaşındayım Uludağ Uni Bil Müh. Mezunuyum 8 Yıldır sektörde aktif olarak Çalışmaktayım ve Yazılım Eğitmeniyim. ");//;Yapmak istediğimiz işlemin bitişini temsil eder.

            /*Çoklu yorumsatırı
             * Kodda derlenebilir bir yapı değildir bilgi not amaçlı kullanılır.
            */

            /*Algoritma  Nedir ?
             * Algoritma Programın ilerleyiş ve akışını sağlayan yapı taşıdır.
             * Başlangıç-Bitiş
             * Sıralı
             * Sonluluk
             * Kesinlik
             * Moduler-Genellenebilir.
            */
            /* Çay demleme Algoritması
             * True olumlu sonuc False olumsuz 
             * 1-Başlangıç
             * 2-Mutafağa git
             * 3-Çaydanlığa Su koy
             * 4-Çaydanlığı Ocağa koy
             * 5-Ocağı Yak
             * 6-Su kaynadı mı ? T>8 F>7
             * 7-Bekle>6
             * 8-Demliğe Çay koy 
             * 9-Çaydanlığa Su koy
             * 10-Ocağa koy
             * 11-Çay demlendi mi ? T>13 F>12
             * 12-Bekle>11
             * 13-Servis et
             * 14-Bitiş
            */
            /*Çay demleme Algoritması Detaylı
             * 1-Başla
             * 2-Mutfağa git
             * 3-Su çay var mı ? T>10 F>4
             * 4-Bakkala git
             * 5-Bakkal Açıkmı ? T>7 F>6 //bir loops (döngü) buradaki koşul true olanakadar yani açık bakkal bulana kadar devam etmeli. 
             * 6-Başka bakkala git >5
             * 7-Eksikleri al
             * 8-Eve dön
             * 9-Mutfağa git
             * 10-Çaydanlığa su koy
             * 11-Ocağa koy
             * 12-Su kaynadı mı ? T>14 F>13
             * 13-Bekle>12
             * 14-Demliğe çay koy
             * 15-Çaydanlığa su koy
             * 16-Ocağa koy
             * 17-Çay demlendi mi ? T>19 F>18
             * 18-Bekle>17
             * 19Servis et
             * 20-Bitiş


            */

            //Üçüncü binyıl akademiye gelirken izlediğiniz adımları algoritmik olarak yazınız
            /*1-Başla
             * 1-Uyan
             * 2-Yataktan Kalk
             * 3-Lavaboya git
             * 4-Elini yüzünü yıka
             * 5-Kahvaltını yap
             * 6-Duşunu al 
             * 7-Ayakkabılarını giy
             * 8-Ev kapısından çık
             * 9-Asansör var mı ? T>13 F>10
             * 10-Merdivenlere yönel
             * 11-Merdivenlerden in
             * 12-Giriş Kata gelene kadar 11.  Adımı tekrar et//Döngü mantığı
             * 13-Asansörü çağır
             * 14-Asansör Geldi mi ?T>16 F>15
             * 15-Bekle
             * 16-Asansöre bin
             * 17-Giriş Katını Tuşla
             * 18-Girişe yönel ve kapıdan çık
             * 19-Otobüs durağına git
             * 20-Akbilimde bakiye var mı ?T>23 F>21
             * 21-Akbile bakiye yükle
             * 22-Otobüs geldi mi ?T>24 F>23
             * 23-Otobüsü bekle
             * 24-Otobüse bin
             * 25-Otobüste boş koltuk var mı ? T>27 F>26
             * 26-Ayakta devam et
             * 27-Boş koltuğa otur
             * 28-İneceğim durağa geldi mi ? T >30 F>29
             * 29-Bekle
             * 30-in Kuruma doğru yürü
             * 31-Kurumun kapısından gir
             * 32-Danışmaya selam ver
             * 33-Ders vereceğin kata çık
             * 34-204 Nolu sınıfta derse başla
             * 35-Bitiş
             
             */

            Console.WriteLine();



            /* Kısayol tuşları
             * cw tab  Console.WriteLine(); getirir
             * ctrl+k+c Seçilen alandaki kodları yorum satırına çevirir.
             * ctrl+k+u Seçilen alandaki yorumsatırı olan yapıyı yorum satırından çıkarır.
             * Ctrl+D imlecin olduğu satırı bir alt satıra kopyalar
             * Ctrl+L imlecin olduğu satırı siler
             * Ctrl+z Yapılan işlemi geri alır
             * Ctrl+Y Yapılan işlemleri ileri alır
             * Alt+Shift+Yön tuşu Çoklu satır işaretleme
             * ctrl +k+d Düzenleme
             * ctrl+r+r
             * shift+enter
             * Run F5 
             * Shift+end Satır sonu
             * Shift+home Satır başı
            
            */

        }//süslü parantez (scope)
    }
}
