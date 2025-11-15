using System.Collections;
using System.Text;

namespace _40_Partial_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Partial class Fiziksel olarak Personel ve Personel1 adında oluşturulan 2 farklı classın adını Personel olarak
             * verip Partial keywordünü kullanarak birleştirip tek bir sınıf gibi davranmasını sağlamak
             * bu yapıda büyük sınıf yapılarını bölerek aynı işlemi gerçekleştiren 2 sınıf yapısı haline geriririz büyük dosyaları 
             * daha az yer ve yük alması adına kullanıluıır her ikisinde bulunan üyeler derleyici tarafından birleştirilip tek bir değer olarak
             * bize cevap verir
             
             */
            Personel personel = new Personel();
            personel.Id= 1;
            personel.Soyad="Türk";
            personel.Name="Erkan";
            personel.Yas=31;
            personel.Bilgi();
            personel.Bilgi("Değer");
            Personel personel1 = new Personel("Erkan");
            personel1.Id= 2;
            personel1.Soyad="Canpolat";
            personel1.Name="Tahsin";
            personel1.Yas=34;
            personel1.Bilgi();
            personel1.Bilgi("Değer");
            personel.Test();

            List<Personel> list = new List<Personel>();
            list.Add(personel1);
            list.Add(personel);
            foreach (var item in list)
            {
                Console.WriteLine(item.Id+" "+item.Name+" "+item.Soyad+" "+item.Yas);
            }
             
        }
    }
}
