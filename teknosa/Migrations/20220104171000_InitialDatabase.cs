using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace teknosa.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urun_Kategori_KategoriID",
                table: "Urun");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kategori",
                table: "Kategori");

            migrationBuilder.RenameTable(
                name: "Kategori",
                newName: "Müşteri");

            migrationBuilder.AddColumn<int>(
                name: "MagazaID",
                table: "Urun",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Müşteri",
                table: "Müşteri",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Magaza",
                columns: table => new
                {
                    MagazaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MagazaAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<int>(type: "int", nullable: false),
                    Telefon = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Magaza", x => x.MagazaID);
                });

            migrationBuilder.CreateTable(
                name: "Musteri",
                columns: table => new
                {
                    MusteriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoyAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteri", x => x.MusteriID);
                });

            migrationBuilder.CreateTable(
                name: "Siparis",
                columns: table => new
                {
                    SiparisID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparis", x => x.SiparisID);
                });

            migrationBuilder.CreateTable(
                name: "SiparisDetay",
                columns: table => new
                {
                    SiparisID = table.Column<int>(type: "int", nullable: false),
                    UrunID = table.Column<int>(type: "int", nullable: false),
                    SiparisAdedi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "IX_Urun_MagazaID",
                table: "Urun",
                column: "MagazaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Urun_Magaza_MagazaID",
                table: "Urun",
                column: "MagazaID",
                principalTable: "Magaza",
                principalColumn: "MagazaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Urun_Müşteri_KategoriID",
                table: "Urun",
                column: "KategoriID",
                principalTable: "Müşteri",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urun_Magaza_MagazaID",
                table: "Urun");

            migrationBuilder.DropForeignKey(
                name: "FK_Urun_Müşteri_KategoriID",
                table: "Urun");

            migrationBuilder.DropTable(
                name: "Magaza");

            migrationBuilder.DropTable(
                name: "Musteri");

            migrationBuilder.DropTable(
                name: "Siparis");

            migrationBuilder.DropTable(
                name: "SiparisDetay");

            migrationBuilder.DropIndex(
                name: "IX_Urun_MagazaID",
                table: "Urun");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Müşteri",
                table: "Müşteri");

            migrationBuilder.DropColumn(
                name: "MagazaID",
                table: "Urun");

            migrationBuilder.RenameTable(
                name: "Müşteri",
                newName: "Kategori");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kategori",
                table: "Kategori",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Urun_Kategori_KategoriID",
                table: "Urun",
                column: "KategoriID",
                principalTable: "Kategori",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
