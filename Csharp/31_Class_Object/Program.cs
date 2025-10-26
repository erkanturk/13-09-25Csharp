namespace _31_Class_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Erişim belirleyiciler
            /*Access modifiers
             * ****Private (Özel)****
             * Private=>Yalnızca tanımlandığı sınıf tarafından erişilen dış erişimlere kapalı olan bir erişim belirleyicidir.
             * Kalıtım yolu dahi olsa kalıtım alan sınıf içerisinde private değere erişilemez.
             * Bir niteliğe erişim belirleyici yapı vermezsek varsayılan olarak private olur.
             * ****Public****
             * Public=>Hiçbir erişim kısıtlaması yoktur proje özelindeki her yapı bu yapıya erişim sağlayabilir.
             * ****Internal ****
             * Internal=>aynı proje içerisinde yer alan yapılar erişir diğer yapılar erişemez
             * ****Protected**** 
             * Protected=>Tanımlandığı tip ve o tipden kalıtım(miras alınmış) tiplerin içerisinden erişilebilinir.
             * Tanımlandığı sınıfta veya o sınıfın türetilmiş sınıflarından erişilebilir.
             * ***Sealed**** Mühürlü sınıf olarak geçer bu yapı ile işaretlenmiş bir sınıf 
             * Miras alınamaz miras alınma işlemini durdurmak için sealed ile işaretlenir.
             
             */
            #endregion
            #region Class Örnek
            //Urun urun = new Urun();
            //urun.Aciklama="Test";
            //urun.Unvan="Gömlek";
            //urun.Resim="1.jpg";
            //urun.Id=1;
            //urun.YorumSayisi="100";
            //urun.Degerlendirme="5";
            //urun.Fiyat=1200;


            //Urun urun2 = new Urun();
            //urun2.Aciklama="Test";
            //urun2.Unvan="Ayakkabı";
            //urun2.Resim="2.jpg";
            //urun2.Id=2;
            //urun2.YorumSayisi="50";
            //urun2.Degerlendirme="4";
            //urun2.Fiyat=2000;

            //Urun urun3 = new Urun()
            //{
            //    Aciklama = "Test",
            //    Fiyat=3300,
            //    Degerlendirme = "5",
            //    Resim="3.jpg",
            //    Id=3,
            //    YorumSayisi="100",
            //    Unvan="Klavye"
            //};
            //List<Urun> urunlerListesi = new List<Urun>();
            //urunlerListesi.Add(urun);
            //urunlerListesi.Add(urun2);
            //urunlerListesi.Add(urun3);

            //foreach (var item in urunlerListesi)
            //{
            //    Console.WriteLine(item.Id+"\n"+item.Aciklama+"\n"+item.Unvan+"\n"+item.Resim+"\n"+item.Fiyat+"\n"+item.Degerlendirme+"\n"+item.YorumSayisi);
            //    Console.WriteLine();
            //}
            List<Urun> uruns = new List<Urun>();
            Urun urun = new Urun();
            uruns.Add(urun.Kaydet());

            foreach (var item in uruns)
            {
                Console.WriteLine(item.Id+" "+item.Fiyat);
            }

            //List<BuzDolabi> buzdolabi = new List<BuzDolabi>()
            //{
            //    new BuzDolabi(){Id=1,Marka="Arçelik",Model="B150",Fiyat=14000,Enerji="E" ,Renk="Gri"},
            //    new BuzDolabi(){Id=2,Marka="Beko",Model="B150",Fiyat=14000,Enerji="E" ,Renk="Gri"},
            //    new BuzDolabi(){Id=3,Marka="Phlips",Model="B150",Fiyat=14000,Enerji="E" ,Renk="Gri"},
            //    new BuzDolabi(){Id=4,Marka="Profilo",Model="B150",Fiyat=14000,Enerji="E" ,Renk="Gri"}
            //};
            //foreach (var item in buzdolabi)
            //{
            //    Console.WriteLine(item.Id+"\n"+item.Model+"\n"+item.Marka+"\n"+item.Renk+"\n"+item.Fiyat+"\n"+item.Enerji);
            //    Console.WriteLine();
            //}
            #endregion
        }
        
    }
}
