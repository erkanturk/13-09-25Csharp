using PersonelUygulamasi.Dal;
using PersonelUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUygulamasi.BLL
{
    public class BusinessLayer
    {
        DataAccessLayer _dal;
        SqlDataReader _reader;
        public BusinessLayer()
        {
            _dal=new DataAccessLayer();
        }
        public int SistemGirisKontrol(string kullaniciAdi, string sifre)
        {
            if (string.IsNullOrEmpty(kullaniciAdi)||string.IsNullOrEmpty(sifre))
            {
                return -100;
            }
            SistemKullanici sistemKullanici = new SistemKullanici()
            {
                KullaniciAdi = kullaniciAdi,
                Sifre= sifre
            };
            return _dal.SistemGirisKontrol(sistemKullanici);
        }
        public int PersonelKayit(string isim, string soyisim, string email, string telefon)
        {
            if (string.IsNullOrEmpty(isim)||string.IsNullOrEmpty(soyisim)||string.IsNullOrEmpty(email)||string.IsNullOrEmpty(telefon))
            {
                return -100;
            }
            bool uniqueEmail = _dal.UniqueEmailPhone(email, telefon);
            if (uniqueEmail)
            {
                return -101;
            }
            Personel p = new Personel()
            {
                Soyisim =soyisim,
                Isim=isim,
                Email=email,
                Telefon=telefon
            };
            return _dal.PersonelKayit(p);

        }
        public List<Personel> PersonelListele()
        {
            List<Personel> personellerim = new List<Personel>();
            try
            {
                _reader=_dal.PersonelListele();
                while (_reader.Read())
                {
                    personellerim.Add(new Personel()
                    {
                        Id=_reader.GetInt32(0),
                        Isim=_reader.IsDBNull(1) ? string.Empty : _reader.GetString(1),
                        Soyisim=_reader.IsDBNull(2) ? string.Empty : _reader.GetString(2),
                        Email=_reader.IsDBNull(3) ? string.Empty : _reader.GetString(3),
                        Telefon=_reader.IsDBNull(4) ? string.Empty : _reader.GetString(4),
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: "+ex.Message);
                throw;
            }
            finally
            {
                if (_reader!=null&&!_reader.IsClosed)
                {
                    _reader.Close();
                }
                _dal.BaglantiAyarla();
            }
            return personellerim;
        }
        public List<Personel> PersonelListele1()
        {
            List<Personel> personellerim = new List<Personel>();
            try
            {
                _reader=_dal.PersonelListele();
                while (_reader.Read())
                {
                    personellerim.Add(new Personel()
                    {
                        Id=_reader.GetInt32(0),
                        Isim=_reader.IsDBNull(1) ? string.Empty : _reader.GetString(1),
                        Soyisim=_reader.IsDBNull(2) ? string.Empty : _reader.GetString(2),
                        Email=_reader.IsDBNull(3) ? string.Empty : _reader.GetString(3),
                        Telefon=_reader.IsDBNull(4) ? string.Empty : _reader.GetString(4),
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: "+ex.Message);
                throw;
            }
            finally
            {
                if (_reader!=null&&!_reader.IsClosed)
                {
                    _reader.Close();
                }
                _dal.BaglantiAyarla();
            }
            return personellerim;
        }
        public int PersonelGuncelle(int id, string isim, string soyisim, string email, string telefon)
        {
            if (string.IsNullOrEmpty(isim)||string.IsNullOrEmpty(soyisim)||string.IsNullOrEmpty(email)||string.IsNullOrEmpty(telefon))
            {
                return -100;
            }
            Personel p = new Personel()
            {
                Id = id,
                Isim = isim,
                Soyisim = soyisim,
                Email = email,
                Telefon = telefon
            };
            return _dal.PersonelGuncelle(p);
        }
        public int PersonelSil(int id)
        {
            return _dal.PersonelSil(id);
        }
    }
}
