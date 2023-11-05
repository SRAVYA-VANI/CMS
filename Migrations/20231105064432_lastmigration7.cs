using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseManagementSystemFinal.Migrations
{
    public partial class lastmigration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnrollCourse_SignUpModel_UserId",
                table: "EnrollCourse");

            migrationBuilder.DropIndex(
                name: "IX_EnrollCourse_UserId",
                table: "EnrollCourse");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "EnrollCourse");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "EnrollCourse");

            migrationBuilder.AddColumn<string>(
                name: "CourseImageLink",
                table: "EnrollCourse",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseName",
                table: "EnrollCourse",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "EnrollCourse",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "EnrollCourse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseImageLink",
                table: "EnrollCourse");

            migrationBuilder.DropColumn(
                name: "CourseName",
                table: "EnrollCourse");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "EnrollCourse");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "EnrollCourse");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "EnrollCourse",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "EnrollCourse",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EnrollCourse_UserId",
                table: "EnrollCourse",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EnrollCourse_SignUpModel_UserId",
                table: "EnrollCourse",
                column: "UserId",
                principalTable: "SignUpModel",
                principalColumn: "UserId");
        }
    }
}
