using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineTutorApp.Migrations
{
    public partial class VideoChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Videos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Path",
                table: "Videos");
        }
    }
}
