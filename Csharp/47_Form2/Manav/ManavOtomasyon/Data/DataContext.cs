using ManavOtomasyon.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManavOtomasyon.Data
{
    public class DataContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=202-HOCAPC\\SQLDERS;Database=ManavDb;uid=sa;pwd=1;TrustServerCertificate=true");

        }
        public DbSet<Manav> Manavlar { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<Urun> Urunler { get; set; }
    }
}
