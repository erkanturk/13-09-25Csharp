using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUygulamasi.Entities
{
    public class Personel
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public override string ToString()
        {
            return $"{Isim} {Soyisim}";
        }

    }
    public class Personel1 : Personel
    {
        public override string ToString()
        {
            return $"{Isim} {Soyisim} {Email} {Telefon} {Adres}";
        }
    }
}
