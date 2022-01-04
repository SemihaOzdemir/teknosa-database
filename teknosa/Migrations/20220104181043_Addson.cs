using Microsoft.EntityFrameworkCore.Migrations;

namespace teknosa.Migrations
{
    public partial class Addson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urun_Magaza_MagazaID1",
                table: "Urun");

            migrationBuilder.DropForeignKey(
                name: "FK_Urun_Müşteri_MagazaID",
                table: "Urun");

            migrationBuilder.DropTable(
                name: "Musteri");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Urun",
                table: "Urun");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Siparis",
                table: "Siparis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Magaza",
                table: "Magaza");

            migrationBuilder.RenameTable(
                name: "Urun",
                newName: "Tüm Ürünler");

            migrationBuilder.RenameTable(
                name: "SiparisDetay",
                newName: "Sipariş Detayı");

            migrationBuilder.RenameTable(
                name: "Siparis",
                newName: "Siparişler");

            migrationBuilder.RenameTable(
                name: "Magaza",
                newName: "Mağazalar");

            migrationBuilder.RenameColumn(
                name: "Isim",
                table: "Müşteri",
                newName: "SoyAdi");

            migrationBuilder.RenameColumn(
                name: "Descriptions",
                table: "Müşteri",
                newName: "Adi");

            migrationBuilder.RenameColumn(
                name: "KategoriID",
                table: "Müşteri",
                newName: "MusteriID");

            migrationBuilder.RenameIndex(
                name: "IX_Urun_MagazaID1",
                table: "Tüm Ürünler",
                newName: "IX_Tüm Ürünler_MagazaID1");

            migrationBuilder.RenameIndex(
                name: "IX_Urun_MagazaID",
                table: "Tüm Ürünler",
                newName: "IX_Tüm Ürünler_MagazaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tüm Ürünler",
                table: "Tüm Ürünler",
                column: "UrunID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Siparişler",
                table: "Siparişler",
                column: "SiparisID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mağazalar",
                table: "Mağazalar",
                column: "MagazaID");

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descriptions = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.KategoriID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Tüm Ürünler_Kategoriler_MagazaID",
                table: "Tüm Ürünler",
                column: "MagazaID",
                principalTable: "Kategoriler",
                principalColumn: "KategoriID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tüm Ürünler_Mağazalar_MagazaID1",
                table: "Tüm Ürünler",
                column: "MagazaID1",
                principalTable: "Mağazalar",
                principalColumn: "MagazaID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tüm Ürünler_Kategoriler_MagazaID",
                table: "Tüm Ürünler");

            migrationBuilder.DropForeignKey(
                name: "FK_Tüm Ürünler_Mağazalar_MagazaID1",
                table: "Tüm Ürünler");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tüm Ürünler",
                table: "Tüm Ürünler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Siparişler",
                table: "Siparişler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mağazalar",
                table: "Mağazalar");

            migrationBuilder.RenameTable(
                name: "Tüm Ürünler",
                newName: "Urun");

            migrationBuilder.RenameTable(
                name: "Siparişler",
                newName: "Siparis");

            migrationBuilder.RenameTable(
                name: "Sipariş Detayı",
                newName: "SiparisDetay");

            migrationBuilder.RenameTable(
                name: "Mağazalar",
                newName: "Magaza");

            migrationBuilder.RenameColumn(
                name: "SoyAdi",
                table: "Müşteri",
                newName: "Isim");

            migrationBuilder.RenameColumn(
                name: "Adi",
                table: "Müşteri",
                newName: "Descriptions");

            migrationBuilder.RenameColumn(
                name: "MusteriID",
                table: "Müşteri",
                newName: "KategoriID");

            migrationBuilder.RenameIndex(
                name: "IX_Tüm Ürünler_MagazaID1",
                table: "Urun",
                newName: "IX_Urun_MagazaID1");

            migrationBuilder.RenameIndex(
                name: "IX_Tüm Ürünler_MagazaID",
                table: "Urun",
                newName: "IX_Urun_MagazaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Urun",
                table: "Urun",
                column: "UrunID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Siparis",
                table: "Siparis",
                column: "SiparisID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Magaza",
                table: "Magaza",
                column: "MagazaID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Urun_Magaza_MagazaID1",
                table: "Urun",
                column: "MagazaID1",
                principalTable: "Magaza",
                principalColumn: "MagazaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Urun_Müşteri_MagazaID",
                table: "Urun",
                column: "MagazaID",
                principalTable: "Müşteri",
                principalColumn: "KategoriID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
