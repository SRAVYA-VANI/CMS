using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseManagementSystemFinal.Migrations
{
    public partial class lastmigration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnrollCourse_FindCourse_CourseId",
                table: "EnrollCourse");

            migrationBuilder.DropTable(
                name: "FindCourse");

            migrationBuilder.DropIndex(
                name: "IX_EnrollCourse_CourseId",
                table: "EnrollCourse");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FindCourse",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseImageLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FindCourse", x => x.CourseId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnrollCourse_CourseId",
                table: "EnrollCourse",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_EnrollCourse_FindCourse_CourseId",
                table: "EnrollCourse",
                column: "CourseId",
                principalTable: "FindCourse",
                principalColumn: "CourseId");
        }
    }
}
