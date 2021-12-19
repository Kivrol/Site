using Microsoft.EntityFrameworkCore.Migrations;

namespace PShop.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tag2",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Tag3",
                table: "Item");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tag2",
                table: "Item",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tag3",
                table: "Item",
                type: "TEXT",
                nullable: true);
        }
    }
}
