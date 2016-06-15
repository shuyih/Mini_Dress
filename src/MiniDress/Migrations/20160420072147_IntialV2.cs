using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace MiniDress.Migrations
{
    public partial class IntialV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Product",
                nullable: true);
            migrationBuilder.AlterColumn<double>(
                name: "Discount",
                table: "Product",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "OrderItem",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Size", table: "OrderItem");
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Product",
                nullable: false);
            migrationBuilder.AlterColumn<double>(
                name: "Discount",
                table: "Product",
                nullable: false);
        }
    }
}
