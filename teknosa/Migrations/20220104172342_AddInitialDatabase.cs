using Microsoft.EntityFrameworkCore.Migrations;

namespace teknosa.Migrations
{
    public partial class AddInitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urun_Magaza_MagazaID",
                table: "Urun");

            migrationBuilder.DropForeignKey(
                name: "FK_Urun_Müşteri_KategoriID",
                table: "Urun");

            migrationBuilder.DropIndex(
                name: "IX_Urun_KategoriID",
                table: "Urun");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Müşteri",
                newName: "KategoriID");

            migrationBuilder.AddColumn<int>(
                name: "MagazaID1",
                table: "Urun",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Urun_MagazaID1",
                table: "Urun",
                column: "MagazaID1");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urun_Magaza_MagazaID1",
                table: "Urun");

            migrationBuilder.DropForeignKey(
                name: "FK_Urun_Müşteri_MagazaID",
                table: "Urun");

            migrationBuilder.DropIndex(
                name: "IX_Urun_MagazaID1",
                table: "Urun");

            migrationBuilder.DropColumn(
                name: "MagazaID1",
                table: "Urun");

            migrationBuilder.RenameColumn(
                name: "KategoriID",
                table: "Müşteri",
                newName: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Urun_KategoriID",
                table: "Urun",
                column: "KategoriID");

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
    }
}
