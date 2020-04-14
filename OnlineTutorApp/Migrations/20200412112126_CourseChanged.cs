using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineTutorApp.Migrations
{
    public partial class CourseChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Courses",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "img1.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "img2.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3,
                column: "Image",
                value: "img3.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 4,
                column: "Image",
                value: "img4.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 5,
                column: "Image",
                value: "img5.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 6,
                column: "Image",
                value: "img6.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Courses");
        }
    }
}
