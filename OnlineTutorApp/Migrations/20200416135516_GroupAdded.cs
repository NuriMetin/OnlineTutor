using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineTutorApp.Migrations
{
    public partial class GroupAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupRoles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupRoles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GroupsUsersCourses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    GroupRoleID = table.Column<int>(nullable: true),
                    UserId = table.Column<string>(nullable: false),
                    AppUserId = table.Column<string>(nullable: true),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupsUsersCourses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GroupsUsersCourses_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupsUsersCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupsUsersCourses_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupsUsersCourses_GroupRoles_GroupRoleID",
                        column: x => x.GroupRoleID,
                        principalTable: "GroupRoles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "P405" },
                    { 2, "686a2" },
                    { 3, "P407" },
                    { 4, "P403" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupsUsersCourses_AppUserId",
                table: "GroupsUsersCourses",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupsUsersCourses_CourseId",
                table: "GroupsUsersCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupsUsersCourses_GroupId",
                table: "GroupsUsersCourses",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupsUsersCourses_GroupRoleID",
                table: "GroupsUsersCourses",
                column: "GroupRoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupsUsersCourses");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "GroupRoles");
        }
    }
}
