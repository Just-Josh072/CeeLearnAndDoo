using Microsoft.EntityFrameworkCore.Migrations;

namespace CLD.Migrations
{
    public partial class Consultant_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Expertise",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Expertise",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
