﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PShop.Migrations.Users
{
    public partial class asdfasd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_AspNetUsers_UserId1",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_UserId1",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Item");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Item",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_UserId1",
                table: "Item",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_AspNetUsers_UserId1",
                table: "Item",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
