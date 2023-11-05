using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseManagementSystemFinal.Migrations
{
    public partial class fourthmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CourseImage",
                table: "FindCourse",
                newName: "CourseImageLink");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CourseImageLink",
                table: "FindCourse",
                newName: "CourseImage");
        }
    }
}
