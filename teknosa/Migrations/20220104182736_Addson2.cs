using Microsoft.EntityFrameworkCore.Migrations;

namespace teknosa.Migrations
{
    public partial class Addson2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Siparişler_MusteriID",
                table: "Siparişler",
                column: "MusteriID");

            migrationBuilder.AddForeignKey(
                name: "FK_Siparişler_Müşteri_MusteriID",
                table: "Siparişler",
                column: "MusteriID",
                principalTable: "Müşteri",
                principalColumn: "MusteriID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Siparişler_Müşteri_MusteriID",
                table: "Siparişler");

            migrationBuilder.DropIndex(
                name: "IX_Siparişler_MusteriID",
                table: "Siparişler");
        }
    }
}
