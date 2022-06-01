using Microsoft.EntityFrameworkCore.Migrations;

namespace MagicSunset.Migrations
{
    public partial class thelast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DrinkindId",
                table: "Drinks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DrinkindId",
                table: "Drinks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
