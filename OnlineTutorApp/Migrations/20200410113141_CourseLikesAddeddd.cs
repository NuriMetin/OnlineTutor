using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineTutorApp.Migrations
{
    public partial class CourseLikesAddeddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LikeForCourse_AspNetUsers_AppUserId",
                table: "LikeForCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_LikeForCourse_Courses_CourseId",
                table: "LikeForCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LikeForCourse",
                table: "LikeForCourse");

            migrationBuilder.RenameTable(
                name: "LikeForCourse",
                newName: "LikeForCourses");

            migrationBuilder.RenameIndex(
                name: "IX_LikeForCourse_CourseId",
                table: "LikeForCourses",
                newName: "IX_LikeForCourses_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_LikeForCourse_AppUserId",
                table: "LikeForCourses",
                newName: "IX_LikeForCourses_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LikeForCourses",
                table: "LikeForCourses",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_LikeForCourses_AspNetUsers_AppUserId",
                table: "LikeForCourses",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LikeForCourses_Courses_CourseId",
                table: "LikeForCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LikeForCourses_AspNetUsers_AppUserId",
                table: "LikeForCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_LikeForCourses_Courses_CourseId",
                table: "LikeForCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LikeForCourses",
                table: "LikeForCourses");

            migrationBuilder.RenameTable(
                name: "LikeForCourses",
                newName: "LikeForCourse");

            migrationBuilder.RenameIndex(
                name: "IX_LikeForCourses_CourseId",
                table: "LikeForCourse",
                newName: "IX_LikeForCourse_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_LikeForCourses_AppUserId",
                table: "LikeForCourse",
                newName: "IX_LikeForCourse_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LikeForCourse",
                table: "LikeForCourse",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_LikeForCourse_AspNetUsers_AppUserId",
                table: "LikeForCourse",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LikeForCourse_Courses_CourseId",
                table: "LikeForCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
