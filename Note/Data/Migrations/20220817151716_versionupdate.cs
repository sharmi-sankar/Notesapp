using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Note.Data.Migrations
{
    public partial class versionupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Versions");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Versions");

            migrationBuilder.DropColumn(
                name: "VersionId",
                table: "Magazines");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Versions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "VersionCode",
                table: "Versions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Versions");

            migrationBuilder.DropColumn(
                name: "VersionCode",
                table: "Versions");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Versions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Versions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "VersionId",
                table: "Magazines",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
