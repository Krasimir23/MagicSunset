using Microsoft.EntityFrameworkCore.Migrations;

namespace MagicSunset.Migrations
{
    public partial class Nz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Reser");

            migrationBuilder.DropColumn(
                name: "Hour",
                table: "Reser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Date",
                table: "Reser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Hour",
                table: "Reser",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
