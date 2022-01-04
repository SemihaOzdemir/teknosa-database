using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace teknosa
{
    public class AddDbContext :DbContext
    {
        public DbSet<Urunler> Urunler { get; set; }
        public DbSet<Kategoriler> Kategoriler { get; set; }

        public DbSet<Magaza> Magaza { get; set; }
        public DbSet<Siparis> Siparis { get; set; }
        public DbSet<SiparisDetay> SiparisDetay { get; set; }
        public DbSet<Musteri> Musteri { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\sqlexpress;database=teknosa;uid=sa;pwd=123");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Urunler>().ToTable("Tüm Ürünler");
            modelBuilder.Entity<Kategoriler>().ToTable("Kategoriler");
            modelBuilder.Entity<Magaza>().ToTable("Mağazalar");
            modelBuilder.Entity<Siparis>().ToTable("Siparişler");
            modelBuilder.Entity<SiparisDetay>().ToTable("Sipariş Detayı");
            modelBuilder.Entity<Musteri>().ToTable("Müşteri");

            modelBuilder.Entity<Urunler>().HasKey(c => c.UrunID);
            modelBuilder.Entity<Urunler>().Property(c => c.Isim);




            modelBuilder.Entity<Urunler>()
                .HasOne(c => c.Kategoriler)
                .WithMany(c => c.Urunler)
                .HasForeignKey(c => c.KategoriID)
                .HasForeignKey(c => c.MagazaID);

            modelBuilder.Entity<Kategoriler>().HasKey(c => c.KategoriID);

            modelBuilder.Entity<Magaza>().HasKey(c => c.MagazaID);
            modelBuilder.Entity<Magaza>().Property(c => c.MagazaAdi);

            modelBuilder.Entity<Siparis>().HasKey(c => c.SiparisID);
            modelBuilder.Entity<Siparis>().Property(c => c.Tarih);
            
           

            modelBuilder.Entity<SiparisDetay>().Property(c => c.SiparisAdedi);
            modelBuilder.Entity<SiparisDetay>().HasNoKey();

            modelBuilder.Entity<Musteri>().HasKey(c => c.MusteriID);
            modelBuilder.Entity<Musteri>().Property(c => c.Adi);
            modelBuilder.Entity<Musteri>().Property(c => c.SoyAdi);












        }
    }
}
