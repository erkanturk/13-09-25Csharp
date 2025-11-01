using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _33_Class_Object_Static
{
    internal static class SeedClass
    {
        //public int id;//Static sınıflar static olmayan üyeleri barındıramaz
        public static int id;//Static sınıflarda static üyeler barındırılabilir

        //public static SeedClass()//Static sınıflar new lenemezler bu yüzden constructor kullanılamaz sadece static constructor kullanılabilir
        //{

        //}
        //static SeedClass()//Static constructor sadece bir defa çalışır program ayağa kalktığında bellekte yer alır
        //{
        //    id = 1;
        //}
        public static void Ekle(List<BuzDolabi> list)
        {
            BuzDolabi buzDolabi = new BuzDolabi();//Seed sınıfı static olduğu için new ile örneklenemez
            //Ekle methodunda BuzDolabı nesnesi oluşturup listeye ekliyoruz
            //Bu sayede SeedClass sınıfını new ile örneklememize gerek kalmıyor
            Console.WriteLine("Marka:");
            buzDolabi.Marka=Console.ReadLine();
            Console.WriteLine("Model:");
            buzDolabi.Model=Console.ReadLine();
            Console.WriteLine("Enerji:");
            buzDolabi.Enerji=Console.ReadLine();
            Console.WriteLine("Fiyat:");
            buzDolabi.Fiyat=Convert.ToDouble(Console.ReadLine());

            list.Add(buzDolabi);
            foreach (var item in list)
            {
                Console.WriteLine(item.Marka+" "+item.Model+" "+item.Enerji+" "+item.Fiyat);
            }

        }
        public static BuzDolabi Ekle()
        {
            BuzDolabi buzDolabi = new BuzDolabi();//Seed sınıfı static olduğu için new ile örneklenemez
            //Ekle methodunda BuzDolabı nesnesi oluşturup listeye ekliyoruz
            //Bu sayede SeedClass sınıfını new ile örneklememize gerek kalmıyor
            Console.WriteLine("Marka:");
            buzDolabi.Marka=Console.ReadLine();
            Console.WriteLine("Model:");
            buzDolabi.Model=Console.ReadLine();
            Console.WriteLine("Enerji:");
            buzDolabi.Enerji=Console.ReadLine();
            Console.WriteLine("Fiyat:");
            buzDolabi.Fiyat=Convert.ToDouble(Console.ReadLine());

            return buzDolabi;


        }
        public static void Ekle2()
        {
            List<BuzDolabi> buzDolabis = new List<BuzDolabi>();
            BuzDolabi buzDolabi = new BuzDolabi();//Seed sınıfı static olduğu için new ile örneklenemez
            //Ekle methodunda BuzDolabı nesnesi oluşturup listeye ekliyoruz
            //Bu sayede SeedClass sınıfını new ile örneklememize gerek kalmıyor
            Console.WriteLine("Marka:");
            buzDolabi.Marka=Console.ReadLine();
            Console.WriteLine("Model:");
            buzDolabi.Model=Console.ReadLine();
            Console.WriteLine("Enerji:");
            buzDolabi.Enerji=Console.ReadLine();
            Console.WriteLine("Fiyat:");
            buzDolabi.Fiyat=Convert.ToDouble(Console.ReadLine());

            foreach (var item in buzDolabis)
            {
                Console.WriteLine(item.Marka+" "+item.Model+" "+item.Enerji+" "+item.Fiyat);
            }
        }
    }
}
