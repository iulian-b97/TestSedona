using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSedona.Entities;

namespace TestSedona.Data
{
    public class SedonaContext : DbContext
    {
        public DbSet<Produs> Produs { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<DetaliiFactura> DetaliiFactura { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "server=.;database=TestSedonaDB;Trusted_Connection=true;MultipleActiveResultSets=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //PK
            modelBuilder.Entity<Produs>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Factura>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<DetaliiFactura>()
                .HasKey(x => x.Id);

            //DetaliiFactura - Produs 
            modelBuilder.Entity<DetaliiFactura>()
                .HasOne(x => x.Produs)
                .WithMany(y => y.DetaliiFactura)
                .HasForeignKey(x => x.IdProdus);

            //DetaliiFactura - Factura 
            modelBuilder.Entity<DetaliiFactura>()
                .HasOne(x => x.Factura)
                .WithMany(y => y.DetaliiFactura)
                .HasForeignKey(x => x.IdFactura); 
        }

        
    }
}
