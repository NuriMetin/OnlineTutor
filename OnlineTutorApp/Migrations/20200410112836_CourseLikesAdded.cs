using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineTutorApp.Migrations
{
    public partial class CourseLikesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ViewCount",
                table: "Courses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LikeForCourse",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Liked = table.Column<bool>(nullable: false),
                    AppUserId = table.Column<string>(nullable: false),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeForCourse", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LikeForCourse_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LikeForCourse_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LikeForCourse_AppUserId",
                table: "LikeForCourse",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeForCourse_CourseId",
                table: "LikeForCourse",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LikeForCourse");

            migrationBuilder.DropColumn(
                name: "ViewCount",
                table: "Courses");
        }
    }
}
