using Microsoft.EntityFrameworkCore.Migrations;

namespace Filmary.DAL.Migrations
{
    public partial class profilenull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Profile",
                maxLength: 127,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(127)",
                oldMaxLength: 127);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Profile",
                type: "nvarchar(127)",
                maxLength: 127,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 127,
                oldNullable: true);
        }
    }
}