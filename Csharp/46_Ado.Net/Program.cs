using _46_Ado.Net.Data;
using _46_Ado.Net.Model;
using System.Data.SqlClient;

namespace _46_Ado.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogretmen ogretmen = new Ogretmen();
            Execute execute = new Execute();
            //execute.OgretmenEkle();
            //Console.WriteLine("Ad");
            //ogretmen.Ad=Console.ReadLine();
            //Console.WriteLine("Soyad");
            //ogretmen.Soyad=Console.ReadLine();
            //Console.WriteLine("Yaş");
            //ogretmen.Yas=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Branş");
            //ogretmen.Brans=Console.ReadLine();
            //execute.OgretmenEkle(ogretmen);


            Console.WriteLine("Ad");
            string ad = Console.ReadLine();
            //SqlDataReader reader = execute.Listele();
            //while (reader.Read())
            //{
            //    Console.WriteLine(reader[0].ToString());
            //    Console.WriteLine(reader[1].ToString());
            //    Console.WriteLine(reader[2].ToString());
            //    Console.WriteLine(reader[3].ToString());
            //    Console.WriteLine(reader[4].ToString());
            //}

            SqlDataReader reader2 = execute.Listele(ad);
            while (reader2.Read())
            {
                Console.WriteLine(reader2[0].ToString());
                Console.WriteLine(reader2[1].ToString());
                Console.WriteLine(reader2[2].ToString());
                Console.WriteLine(reader2[3].ToString());
                Console.WriteLine(reader2[4].ToString());
            }
        }
    }
}
