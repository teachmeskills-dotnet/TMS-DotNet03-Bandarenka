using Microsoft.EntityFrameworkCore.Migrations;

namespace Filmary.DAL.Migrations
{
    public partial class updateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Profile");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Profile",
                maxLength: 127,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Profile");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Profile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Profile",
                type: "nvarchar(127)",
                maxLength: 127,
                nullable: false,
                defaultValue: "");
        }
    }
}
