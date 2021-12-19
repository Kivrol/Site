using Microsoft.EntityFrameworkCore.Migrations;

namespace PShop.Migrations
{
    public partial class asijdalsnf3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Characteristics",
                table: "Item",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Characteristics",
                table: "Item");
        }
    }
}
