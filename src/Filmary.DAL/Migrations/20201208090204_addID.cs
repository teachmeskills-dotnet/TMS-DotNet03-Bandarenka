using Microsoft.EntityFrameworkCore.Migrations;

namespace Filmary.DAL.Migrations
{
    public partial class addID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FilmsId",
                table: "Films",
                maxLength: 127,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilmsId",
                table: "Films");
        }
    }
}
