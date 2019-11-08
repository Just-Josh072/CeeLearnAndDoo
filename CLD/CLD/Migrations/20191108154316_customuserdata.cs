using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CLD.Migrations
{
    public partial class customuserdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleComment_AspNetUsers_UserId1",
                table: "ArticleComment");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_AspNetUsers_UserId1",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "IsConsultant",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "Question",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Question_UserId1",
                table: "Question",
                newName: "IX_Question_ApplicationUserId");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "ArticleComment",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleComment_UserId1",
                table: "ArticleComment",
                newName: "IX_ArticleComment_ApplicationUserId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleComment_AspNetUsers_ApplicationUserId",
                table: "ArticleComment",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_AspNetUsers_ApplicationUserId",
                table: "Question",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleComment_AspNetUsers_ApplicationUserId",
                table: "ArticleComment");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_AspNetUsers_ApplicationUserId",
                table: "Question");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Question",
                newName: "UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_Question_ApplicationUserId",
                table: "Question",
                newName: "IX_Question_UserId1");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "ArticleComment",
                newName: "UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleComment_ApplicationUserId",
                table: "ArticleComment",
                newName: "IX_ArticleComment_UserId1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<bool>(
                name: "IsConsultant",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleComment_AspNetUsers_UserId1",
                table: "ArticleComment",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_AspNetUsers_UserId1",
                table: "Question",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
