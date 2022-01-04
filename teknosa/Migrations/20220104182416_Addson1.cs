using Microsoft.EntityFrameworkCore.Migrations;

namespace teknosa.Migrations
{
    public partial class Addson1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MusteriID",
                table: "Siparişler",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MusteriID",
                table: "Siparişler");
        }
    }
}
