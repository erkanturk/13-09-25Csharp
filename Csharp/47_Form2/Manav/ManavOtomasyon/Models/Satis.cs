using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManavOtomasyon.Models
{
    public class Satis
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public double Miktar { get; set; }
        public DateTime SatisTarih { get; set; }
    }
}
