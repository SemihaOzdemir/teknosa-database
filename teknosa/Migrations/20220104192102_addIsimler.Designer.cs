// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using teknosa;

namespace teknosa.Migrations
{
    [DbContext(typeof(AddDbContext))]
    [Migration("20220104192102_addIsimler")]
    partial class addIsimler
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("teknosa.Kategoriler", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descriptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Isim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("teknosa.Magaza", b =>
                {
                    b.Property<int>("MagazaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MagazaAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefon")
                        .HasColumnType("int");

                    b.HasKey("MagazaID");

                    b.ToTable("Magazalar");
                });

            modelBuilder.Entity("teknosa.Musteri", b =>
                {
                    b.Property<int>("MusteriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoyAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MusteriID");

                    b.ToTable("Musteri");
                });

            modelBuilder.Entity("teknosa.Siparis", b =>
                {
                    b.Property<int>("SiparisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MusteriID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("SiparisID");

                    b.HasIndex("MusteriID");

                    b.ToTable("Siparisler");
                });

            modelBuilder.Entity("teknosa.SiparisDetay", b =>
                {
                    b.Property<int>("SiparisAdedi")
                        .HasColumnType("int");

                    b.Property<int>("SiparisID")
                        .HasColumnType("int");

                    b.Property<int>("UrunID")
                        .HasColumnType("int");

                    b.ToTable("SiparisDetayı");
                });

            modelBuilder.Entity("teknosa.Urunler", b =>
                {
                    b.Property<int>("UrunID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Isim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<int>("MagazaID")
                        .HasColumnType("int");

                    b.Property<int>("MagazaID1")
                        .HasColumnType("int");

                    b.Property<string>("Renk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stok")
                        .HasColumnType("int");

                    b.HasKey("UrunID");

                    b.HasIndex("MagazaID");

                    b.HasIndex("MagazaID1");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("teknosa.Siparis", b =>
                {
                    b.HasOne("teknosa.Musteri", "Musteri")
                        .WithMany()
                        .HasForeignKey("MusteriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("teknosa.Urunler", b =>
                {
                    b.HasOne("teknosa.Kategoriler", "Kategoriler")
                        .WithMany("Urunler")
                        .HasForeignKey("MagazaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("teknosa.Magaza", null)
                        .WithMany("Urunler")
                        .HasForeignKey("MagazaID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategoriler");
                });

            modelBuilder.Entity("teknosa.Kategoriler", b =>
                {
                    b.Navigation("Urunler");
                });

            modelBuilder.Entity("teknosa.Magaza", b =>
                {
                    b.Navigation("Urunler");
                });
#pragma warning restore 612, 618
        }
    }
}
