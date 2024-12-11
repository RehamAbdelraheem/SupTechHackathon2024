using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupTechHackathon2024.Repositories.Migrations
{
    public partial class addauditcall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreateBy",
                table: "Call",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Call",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "Call",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Call",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Call",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Call");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Call");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Call");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Call");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Call");
        }
    }
}
