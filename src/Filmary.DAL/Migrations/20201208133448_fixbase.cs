using Microsoft.EntityFrameworkCore.Migrations;

namespace Filmary.DAL.Migrations
{
    public partial class fixbase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "Films",
                maxLength: 127,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(127)",
                oldMaxLength: 127);

            migrationBuilder.AlterColumn<string>(
                name: "FilmsName",
                table: "Films",
                maxLength: 127,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(127)",
                oldMaxLength: 127);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Films",
                maxLength: 127,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(127)",
                oldMaxLength: 127);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "Films",
                type: "nvarchar(127)",
                maxLength: 127,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 127,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FilmsName",
                table: "Films",
                type: "nvarchar(127)",
                maxLength: 127,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 127,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Films",
                type: "nvarchar(127)",
                maxLength: 127,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 127,
                oldNullable: true);
        }
    }
}