using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Products");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Products",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Products",
                type: "varbinary(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
