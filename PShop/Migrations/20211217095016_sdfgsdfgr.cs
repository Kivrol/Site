using Microsoft.EntityFrameworkCore.Migrations;

namespace PShop.Migrations
{
    public partial class sdfgsdfgr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Keys",
                table: "Item");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Keys",
                table: "Item",
                type: "TEXT",
                nullable: true);
        }
    }
}
