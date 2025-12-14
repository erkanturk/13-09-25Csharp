using Microsoft.EntityFrameworkCore;
using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Data
{
    public class DataContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=202-HOCAPC\\SQLDERS;Database=RentACarDb;uid=sa;pwd=1;TrustServerCertificate=true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Bir arabanın bir markası varken bir markada birden fazla araba bulunabilir.
            modelBuilder.Entity<Araba>()
                .HasOne(a => a.Marka)
                .WithMany(m => m.Arabalar)
                .HasForeignKey(z => z.MarkaId);
            modelBuilder.Entity<Kiralama>()
                .HasOne(k => k.Musteri)
                .WithMany(m => m.Kiralamas)
                .HasForeignKey(a => a.MusteriId);
            modelBuilder.Entity<Kiralama>()
                 .HasOne(k => k.Araba)
                 .WithMany(m => m.Kiralamalar)
                 .HasForeignKey(a => a.ArabaId);
        }
        public DbSet<Araba> Arabalar { get; set; }
        public DbSet<Kiralama> Kiralamalar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Marka> Markalar { get; set; }

    }
}
