using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinalProject
{
    internal class FinalDbContext:DbContext
    {

        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ders>Dersler { get; set; }
        public DbSet<Sinif>Siniflar { get; set; }
        public DbSet<StudentStudy> StudentStudies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=FinalProjectEF;Integrated Security=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ogrenci>().Property(o => o.Ad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ogrenci>().Property(o => o.Soyad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ogrenci>().Property(o => o.Numara).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Sinif>().Property(o => o.SinifAd).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Sinif>().Property(o => o.SinifKontejan).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ders>().Property(o => o.DersKod).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ders>().Property(o => o.DersAd).HasColumnType("varchar").HasMaxLength(30).IsRequired();




            modelBuilder.Entity<StudentStudy>().HasKey(od => new { od.OgrenciId, od.DersId });


            modelBuilder.Entity<Ogrenci>()
                .HasOne(i => i.Sinif) 
                .WithMany(i => i.Ogrenciler)   
                .HasForeignKey( i=> i.SinifId);


            modelBuilder.Entity<StudentStudy>()
               .HasOne(a => a.Ders)
               .WithMany(a => a.StudentStudies)
               .HasForeignKey(a => a.DersId);


            modelBuilder.Entity<StudentStudy>()
             .HasOne(a => a.Ogrenci)
             .WithMany(a => a.StudentStudies)
             .HasForeignKey(a => a.OgrenciId);
        }







































    }
}
