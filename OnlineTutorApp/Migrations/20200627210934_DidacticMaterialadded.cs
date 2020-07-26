using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineTutorApp.Migrations
{
    public partial class DidacticMaterialadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "DidacticMaterials");

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "DidacticMaterials",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishDate",
                table: "DidacticMaterials",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "DidacticMaterials",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Path",
                table: "DidacticMaterials");

            migrationBuilder.DropColumn(
                name: "PublishDate",
                table: "DidacticMaterials");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "DidacticMaterials");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "DidacticMaterials",
                nullable: true);
        }
    }
}
