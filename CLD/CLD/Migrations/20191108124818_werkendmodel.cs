using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CLD.Migrations
{
    public partial class werkendmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Category_CategoryId",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_Article_Question_QuestionId",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultant_AspNetUsers_UserId",
                table: "Consultant");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Category_CategoryId",
                table: "Question");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Consultant_UserId",
                table: "Consultant");

            migrationBuilder.DropIndex(
                name: "IX_Article_CategoryId",
                table: "Article");

            migrationBuilder.DropIndex(
                name: "IX_Article_QuestionId",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Article");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Question",
                newName: "ExpertiseId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Question",
                newName: "QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Question_CategoryId",
                table: "Question",
                newName: "IX_Question_ExpertiseId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Expertise",
                newName: "ExpretiseName");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "AspNetUsers",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Article",
                newName: "ArticleId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Answer",
                newName: "AnswerId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Consultant",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsConsultant",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnswerContent",
                table: "Answer",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Expertise_ExpertiseId",
                table: "Question",
                column: "ExpertiseId",
                principalTable: "Expertise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_Expertise_ExpertiseId",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "IsConsultant",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AnswerContent",
                table: "Answer");

            migrationBuilder.RenameColumn(
                name: "ExpertiseId",
                table: "Question",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "Question",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Question_ExpertiseId",
                table: "Question",
                newName: "IX_Question_CategoryId");

            migrationBuilder.RenameColumn(
                name: "ExpretiseName",
                table: "Expertise",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "AspNetUsers",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "ArticleId",
                table: "Article",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AnswerId",
                table: "Answer",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Consultant",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "Article",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consultant_UserId",
                table: "Consultant",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Article_CategoryId",
                table: "Article",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Article_QuestionId",
                table: "Article",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Category_CategoryId",
                table: "Article",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Question_QuestionId",
                table: "Article",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultant_AspNetUsers_UserId",
                table: "Consultant",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Category_CategoryId",
                table: "Question",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
