using Microsoft.EntityFrameworkCore.Migrations;

namespace PShop.Migrations.Users
{
    public partial class popop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WishList",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WishList",
                table: "AspNetUsers");
        }
    }
}
