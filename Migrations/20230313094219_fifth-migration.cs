using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseManagementSystemFinal.Migrations
{
    public partial class fifthmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoLinks",
                table: "EnrollCourse",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoLinks",
                table: "EnrollCourse");
        }
    }
}
