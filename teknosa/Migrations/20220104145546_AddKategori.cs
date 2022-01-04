using Microsoft.EntityFrameworkCore.Migrations;

namespace teknosa.Migrations
{
    public partial class AddKategori : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urun_Kategori_MarkaID",
                table: "Urun");

            migrationBuilder.RenameColumn(
                name: "MarkaID",
                table: "Urun",
                newName: "KategoriID");

            migrationBuilder.RenameIndex(
                name: "IX_Urun_MarkaID",
                table: "Urun",
                newName: "IX_Urun_KategoriID");

            migrationBuilder.AddForeignKey(
                name: "FK_Urun_Kategori_KategoriID",
                table: "Urun",
                column: "KategoriID",
                principalTable: "Kategori",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urun_Kategori_KategoriID",
                table: "Urun");

            migrationBuilder.RenameColumn(
                name: "KategoriID",
                table: "Urun",
                newName: "MarkaID");

            migrationBuilder.RenameIndex(
                name: "IX_Urun_KategoriID",
                table: "Urun",
                newName: "IX_Urun_MarkaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Urun_Kategori_MarkaID",
                table: "Urun",
                column: "MarkaID",
                principalTable: "Kategori",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
