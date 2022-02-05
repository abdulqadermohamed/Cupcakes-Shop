using Microsoft.EntityFrameworkCore.Migrations;

namespace Cupcakes.Migrations
{
    public partial class shopping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pieId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Pies_pieId",
                        column: x => x.pieId,
                        principalTable: "Pies",
                        principalColumn: "pieId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_pieId",
                table: "ShoppingCartItems",
                column: "pieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");
        }
    }
}
