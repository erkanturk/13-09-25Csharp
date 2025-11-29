using _46_Ado.Net.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_Ado.Net.Data
{
    public class Execute
    {
        private readonly SqlConnection con;
        SqlCommand cmd;
        public Execute()
        {
            con=new SqlConnection//Dependency injection Dışa bağımlılık
                (@"Server=202-HOCAPC\SQLDERS;Database=OkulDb;uid=sa;pwd=1;TrustServerCertificate=true");
        }
        public int OgretmenEkle()
        {
            var eks = 0;
            try
            {
                SqlCommand cmd = new SqlCommand($"Insert into Ogretmenler (Ad,Soyad,Yas,Brans) Values ('Erkan','Türk','31','Yazılım Mühendisi')", con);
                con.Open();
                eks=cmd.ExecuteNonQuery();//Crud r haricinde işlemleri gerçekleştirir
                //Create Update Delete 
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata: "+ex.Message);
            }
            finally
            {
                con.Close();
            }
            return eks;
        }
        public void OgretmenEkle(Ogretmen ogretmen)
        {

            SqlCommand cmd = new SqlCommand($"Insert into Ogretmenler (Ad,Soyad,Yas,Brans) Values ('{ogretmen.Ad}','{ogretmen.Soyad}','{ogretmen.Yas}','{ogretmen.Brans}')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public SqlDataReader Listele()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Ogretmenler", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();//Read işlemi crud daki
                return reader;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
               
            }

           
            
        }
        public SqlDataReader Listele(string ad)
        {
            if (ad==null)
            {
                Console.WriteLine("Aradığınız kullanıcı bilgisine ulaşılamadı");
            }
            else
            {
                cmd= new SqlCommand($"Select * from Ogretmenler where Ad like '%{ad}%' ", con);
            }
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

    }
}
