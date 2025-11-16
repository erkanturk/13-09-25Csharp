namespace _44_OOP_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Interface (arabirim) soyut yapılardır içerisinde gövdesiz methodlar tanımlanır 
             * Erişim belirleyicisi public olmalıdır.
             * Interfaceler diamond problem sonucunda ortaya çıkmış yapılardır 
             * Bir sınıf birden fazla interface'i implemente edebilir.
             * Interfaceler inheritance vermez implemente edilmek için kullanılan arayüzlerdir.
             * Interfaceler sınıflardan miras alamaz
             * Interfacelerin içerisinde constructor tanımlanamaz
             * Interfacelerden nesne oluşturulamaz
             * Interfaceler I ile başlayarak tanımlanır.
             
             */
            //IYuruyenNesne yuruyenNesne = new IYuruyenNesne();//nesnesi oluşturulamaz.
            //IYuruyenNesne yuruyen = new Insan();
            //yuruyen.Yuru();
            Kus kus = new Kus();
            kus.Yuru();
            kus.Yuz();
            kus.Uc();
            kus.HareketEt();
            Insan insan = new Insan();
            insan.HareketEt();
            insan.Yuz();
            insan.Yuru();

            Balik balik = new Balik();
            balik.HareketEt();
            balik.Yuz();

        }
    }
}
