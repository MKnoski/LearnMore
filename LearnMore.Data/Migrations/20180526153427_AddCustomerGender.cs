using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LearnMore.Data.Migrations
{
    public partial class AddCustomerGender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Locale",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Locale",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Customers",
                nullable: true);
        }
    }
}
