using PersonelUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUygulamasi.Dal
{
    public class DataAccessLayer
    {
        private readonly SqlConnection  _connect;
        SqlCommand _cmd;
        SqlDataReader _reader;
        int sonuc = 0;
        public DataAccessLayer()
        {
            /*_connect =new SqlConnection("Data Source=202-HOCAPC\\SQLDERS;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0");*/
            _connect=new SqlConnection("Data Source=202-HOCAPC\\SQLDERS;Initial Catalog=PersonelUygulama;Integrated Security=True;TrustServerCertificate=True");
            _cmd=new SqlCommand();
        }
        public void BaglantiAyarla()
        {
            if (_connect.State==System.Data.ConnectionState.Closed)
            {
                _connect.Open();
                Console.WriteLine("ok");
            }
            else
            {
                _connect.Close();
            }
        }
        public int SistemGirisKontrol(SistemKullanici s)
        {
            try
            {
                _cmd=new SqlCommand($"Select * from SistemKullanici where KullaniciAdi='{s.KullaniciAdi}' and Sifre='{s.Sifre}'", _connect);
                _connect.Open();
                _reader=_cmd.ExecuteReader();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (_reader.Read())
                {
                    sonuc=1;
                }
                _connect.Close();
            }
            return sonuc;
        }
        public int PersonelKayit(Personel p)
        {
            _cmd=new SqlCommand($"Insert into Personel (Isim,Soyisim,Email,Telefon) values ('{p.Isim}','{p.Soyisim}','{p.Email}','{p.Telefon}')", _connect);
            BaglantiAyarla();
            sonuc=_cmd.ExecuteNonQuery();//insert update delete C.U.D 
            BaglantiAyarla();
            return sonuc;
        }
        public bool UniqueEmailPhone(string email, string telefon)
        {
            _cmd=new SqlCommand($"Select * from Personel where Email = '{email}' or Telefon='{telefon}'", _connect);
            BaglantiAyarla();
            _reader=_cmd.ExecuteReader();//Select sorguları Read işlemi
            //_cmd.ExecuteScaler();//Tek değer döndüren bir yapı 
            if (_reader.Read())
            {
                BaglantiAyarla();
                return true;//eğer kayıt varsa true dönecek ve bize kayıtlı olan değer olduğu için tekrar kayıt işlemi yaptırmayacak.
            }
            else
            {

                BaglantiAyarla();
                return false;//Böyle bir kayıt yok email ve tel e ait
            }

        }
        public int PersonelGuncelle(Personel p)
        {
            try
            {
                _cmd=new SqlCommand($"Update Personel set Isim=@isim,Soyisim=@soyisim,Email=@email,Telefon=@telefon where Id=@id", _connect);
                _cmd.Parameters.AddWithValue("@isim", p.Isim);
                _cmd.Parameters.AddWithValue("@soyisim", p.Soyisim);
                _cmd.Parameters.AddWithValue("@email", p.Email);
                _cmd.Parameters.AddWithValue("@telefon", p.Telefon);
                _cmd.Parameters.AddWithValue("@id", p.Id);
                BaglantiAyarla();
                return _cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: "+ex.Message);
                throw;
            }
            finally
            {
                BaglantiAyarla();
            }
        }
        public int PersonelSil(int id)
        {
            try
            {
                _cmd=new SqlCommand("Delete from Personel where Id=@Id", _connect);
                _cmd.Parameters.AddWithValue("@Id", id);
                BaglantiAyarla();
                return _cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: "+ex.Message);
                throw;
            }
            finally
            {
                BaglantiAyarla();
            }
        }
        public SqlDataReader PersonelListele()
        {
            try
            {
                _cmd=new SqlCommand($"Select * from Personel", _connect);
                BaglantiAyarla();
                return _cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: "+ex.Message);
                throw;
            }
        }

    }
}
