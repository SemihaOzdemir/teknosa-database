using Microsoft.EntityFrameworkCore.Migrations;

namespace teknosa.Migrations
{
    public partial class addIsimler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Siparişler_Müşteri_MusteriID",
                table: "Siparişler");

            migrationBuilder.DropForeignKey(
                name: "FK_Tüm Ürünler_Kategoriler_MagazaID",
                table: "Tüm Ürünler");

         

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tüm Ürünler",
                table: "Tüm Ürünler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Siparişler",
                table: "Siparişler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Müşteri",
                table: "Müşteri");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mağazalar",
                table: "Mağazalar");

            migrationBuilder.RenameTable(
                name: "Tüm Ürünler",
                newName: "Urunler");

            migrationBuilder.RenameTable(
                name: "Siparişler",
                newName: "Siparisler");

            migrationBuilder.RenameTable(
                name: "Sipariş Detayı",
                newName: "SiparisDetayı");

            migrationBuilder.RenameTable(
                name: "Müşteri",
                newName: "Musteri");

            migrationBuilder.RenameTable(
                name: "Mağazalar",
                newName: "Magazalar");

            migrationBuilder.RenameIndex(
                name: "IX_Tüm Ürünler_MagazaID1",
                table: "Urunler",
                newName: "IX_Urunler_MagazaID1");

            migrationBuilder.RenameIndex(
                name: "IX_Tüm Ürünler_MagazaID",
                table: "Urunler",
                newName: "IX_Urunler_MagazaID");

            migrationBuilder.RenameIndex(
                name: "IX_Siparişler_MusteriID",
                table: "Siparisler",
                newName: "IX_Siparisler_MusteriID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Urunler",
                table: "Urunler",
                column: "UrunID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Siparisler",
                table: "Siparisler",
                column: "SiparisID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Musteri",
                table: "Musteri",
                column: "MusteriID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Magazalar",
                table: "Magazalar",
                column: "MagazaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Siparisler_Musteri_MusteriID",
                table: "Siparisler",
                column: "MusteriID",
                principalTable: "Musteri",
                principalColumn: "MusteriID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Urunler_Kategoriler_MagazaID",
                table: "Urunler",
                column: "MagazaID",
                principalTable: "Kategoriler",
                principalColumn: "KategoriID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Urunler_Magazalar_MagazaID1",
                table: "Urunler",
                column: "MagazaID1",
                principalTable: "Magazalar",
                principalColumn: "MagazaID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Siparisler_Musteri_MusteriID",
                table: "Siparisler");

            migrationBuilder.DropForeignKey(
                name: "FK_Urunler_Kategoriler_MagazaID",
                table: "Urunler");

            migrationBuilder.DropForeignKey(
                name: "FK_Urunler_Magazalar_MagazaID1",
                table: "Urunler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Urunler",
                table: "Urunler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Siparisler",
                table: "Siparisler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Musteri",
                table: "Musteri");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Magazalar",
                table: "Magazalar");

            migrationBuilder.RenameTable(
                name: "Urunler",
                newName: "Tüm Ürünler");

            migrationBuilder.RenameTable(
                name: "Siparisler",
                newName: "Siparişler");

            migrationBuilder.RenameTable(
                name: "SiparisDetayı",
                newName: "Sipariş Detayı");

            migrationBuilder.RenameTable(
                name: "Musteri",
                newName: "Müşteri");

            migrationBuilder.RenameTable(
                name: "Magazalar",
                newName: "Mağazalar");

            migrationBuilder.RenameIndex(
                name: "IX_Urunler_MagazaID1",
                table: "Tüm Ürünler",
                newName: "IX_Tüm Ürünler_MagazaID1");

            migrationBuilder.RenameIndex(
                name: "IX_Urunler_MagazaID",
                table: "Tüm Ürünler",
                newName: "IX_Tüm Ürünler_MagazaID");

            migrationBuilder.RenameIndex(
                name: "IX_Siparisler_MusteriID",
                table: "Siparişler",
                newName: "IX_Siparişler_MusteriID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tüm Ürünler",
                table: "Tüm Ürünler",
                column: "UrunID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Siparişler",
                table: "Siparişler",
                column: "SiparisID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Müşteri",
                table: "Müşteri",
                column: "MusteriID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mağazalar",
                table: "Mağazalar",
                column: "MagazaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Siparişler_Müşteri_MusteriID",
                table: "Siparişler",
                column: "MusteriID",
                principalTable: "Müşteri",
                principalColumn: "MusteriID",
                onDelete: ReferentialAction.Cascade);

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
    }
}
