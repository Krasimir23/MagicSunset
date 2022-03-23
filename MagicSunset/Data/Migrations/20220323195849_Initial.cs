using Microsoft.EntityFrameworkCore.Migrations;

namespace MagicSunset.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Tables_TablesId",
                table: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Tables_TablesId",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "TablesId",
                table: "Tables");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TablesId",
                table: "Tables",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tables_TablesId",
                table: "Tables",
                column: "TablesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Tables_TablesId",
                table: "Tables",
                column: "TablesId",
                principalTable: "Tables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
