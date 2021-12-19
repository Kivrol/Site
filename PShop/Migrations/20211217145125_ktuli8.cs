using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PShop.Migrations
{
    public partial class ktuli8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "OrderId",
                table: "Item",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_OrderId",
                table: "Item",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Orders_OrderId",
                table: "Item",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Orders_OrderId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_OrderId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Item");
        }
    }
}
