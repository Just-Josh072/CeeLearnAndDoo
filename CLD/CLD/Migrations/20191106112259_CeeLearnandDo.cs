using Microsoft.EntityFrameworkCore.Migrations;

namespace CLD.Migrations
{
    public partial class CeeLearnandDo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuestionTitle",
                table: "Question",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "QuestionContent",
                table: "Question",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "Question",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Question",
                newName: "QuestionTitle");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Question",
                newName: "QuestionContent");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Question",
                newName: "QuestionId");
        }
    }
}
