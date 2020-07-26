using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineTutorApp.Migrations
{
    public partial class SillabusAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Sillabus",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Sillabus",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishDate",
                table: "Sillabus",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Path",
                table: "Sillabus");

            migrationBuilder.DropColumn(
                name: "PublishDate",
                table: "Sillabus");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Sillabus",
                newName: "Name");
        }
    }
}
