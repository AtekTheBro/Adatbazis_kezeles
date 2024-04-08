using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkoloHazSzimulacio.Models
{
    public class Parkolohaz_Szimulacio_Adatbazis:DbContext
    {
        public DbSet<Auto> autok { get; set; }
        public DbSet<Parkolas> parkolasok { get; set; }
        public DbSet<Dij> dijak { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("SERVER=127.0.0.1;USERNAME=root;PASSWORD=;DATABASE=parkolohazszimulacioadatbazis");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Dij>()
                .HasKey(pk => new { pk.Rendszam, pk.Vege });
        }
    }
}
