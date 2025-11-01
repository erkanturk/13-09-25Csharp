using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Class_Object_Static
{
    internal class BuzDolabi
    {
        public BuzDolabi()//Normal constructor yapısı her new lendiğinde çalışır
        {
            Console.WriteLine("Ctor Çalıştı");
        }
        public int Id; //Id (Identity) kimlik tipi ve benzersiz değer alır
        public string Marka;
        public string Model;
        public string Enerji;
        public double Fiyat;

        public void Kaydet()
        {
            Console.WriteLine("Marka:");
            Marka=Console.ReadLine();
            Console.WriteLine("Model:");
            Model=Console.ReadLine();
            Console.WriteLine("Enerji:");
            Enerji=Console.ReadLine();
            Console.WriteLine("Fiyat:");
            Fiyat=Convert.ToDouble(Console.ReadLine());

        }
        public void Kaydet(List<BuzDolabi> list)
        {
            Console.WriteLine("Marka:");
            Marka=Console.ReadLine();
            Console.WriteLine("Model:");
            Model=Console.ReadLine();
            Console.WriteLine("Enerji:");
            Enerji=Console.ReadLine();
            Console.WriteLine("Fiyat:");
            Fiyat=Convert.ToDouble(Console.ReadLine());
            list.Add(this);//bulunduğu nesneyi listeye ekler

            foreach (var item in list)
            {
                Console.WriteLine(item.Marka+" "+item.Model+" "+item.Enerji+" "+item.Fiyat);
            }
        }
    }
}
