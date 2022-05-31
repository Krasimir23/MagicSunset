using Microsoft.EntityFrameworkCore.Migrations;

namespace MagicSunset.Migrations
{
    public partial class Magic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dishkind",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishkind", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drinkkind",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrinkKind = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinkkind", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dishess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dishname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dishkind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DishekindId = table.Column<int>(type: "int", nullable: true),
                    Gram = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dishess_Dishkind_DishekindId",
                        column: x => x.DishekindId,
                        principalTable: "Dishkind",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Drinkname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrinkindId = table.Column<int>(type: "int", nullable: false),
                    DrinkKindId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drinks_Drinkkind_DrinkKindId",
                        column: x => x.DrinkKindId,
                        principalTable: "Drinkkind",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dishess_DishekindId",
                table: "Dishess",
                column: "DishekindId");

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_DrinkKindId",
                table: "Drinks",
                column: "DrinkKindId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dishess");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Dishkind");

            migrationBuilder.DropTable(
                name: "Drinkkind");
        }
    }
}
