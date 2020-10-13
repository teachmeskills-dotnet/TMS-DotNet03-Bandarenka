using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Filmary.DAL.Migrations
{
    public partial class contextandconfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtistFilm_Artist_ArtistId",
                table: "ArtistFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtistFilm_Films_FilmsId",
                table: "ArtistFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_Compilation_Profile_ProfileId",
                table: "Compilation");

            migrationBuilder.DropForeignKey(
                name: "FK_CompilationFilm_Compilation_CompilationId1",
                table: "CompilationFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_CompilationFilm_Films_FilmsId",
                table: "CompilationFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryFilm_Country_CountryId",
                table: "CountryFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryFilm_Films_FilmsId",
                table: "CountryFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreFilm_Films_FilmsId",
                table: "GenreFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreFilm_Genre_GenreId",
                table: "GenreFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_ProducerFilm_Films_FilmsId",
                table: "ProducerFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_ProducerFilm_Producer_ProducerId",
                table: "ProducerFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_Status_Films_FilmsId",
                table: "Status");

            migrationBuilder.DropForeignKey(
                name: "FK_Status_Profile_ProfileId",
                table: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Status_FilmsId",
                table: "Status");

            migrationBuilder.DropIndex(
                name: "IX_ProducerFilm_FilmsId",
                table: "ProducerFilm");

            migrationBuilder.DropIndex(
                name: "IX_GenreFilm_FilmsId",
                table: "GenreFilm");

            migrationBuilder.DropIndex(
                name: "IX_CountryFilm_FilmsId",
                table: "CountryFilm");

            migrationBuilder.DropIndex(
                name: "IX_CompilationFilm_CompilationId1",
                table: "CompilationFilm");

            migrationBuilder.DropIndex(
                name: "IX_CompilationFilm_FilmsId",
                table: "CompilationFilm");

            migrationBuilder.DropIndex(
                name: "IX_ArtistFilm_FilmsId",
                table: "ArtistFilm");

            migrationBuilder.DropColumn(
                name: "FilmsId",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "FilmsId",
                table: "ProducerFilm");

            migrationBuilder.DropColumn(
                name: "FilmsId",
                table: "GenreFilm");

            migrationBuilder.DropColumn(
                name: "FilmsId",
                table: "CountryFilm");

            migrationBuilder.DropColumn(
                name: "CompilationId1",
                table: "CompilationFilm");

            migrationBuilder.DropColumn(
                name: "FilmsId",
                table: "CompilationFilm");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Compilation");

            migrationBuilder.DropColumn(
                name: "FilmsId",
                table: "ArtistFilm");

            migrationBuilder.AddColumn<int>(
                name: "FilmId",
                table: "ProducerFilm",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ProducerName",
                table: "Producer",
                maxLength: 127,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FilmId",
                table: "GenreFilm",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "GenreName",
                table: "Genre",
                maxLength: 127,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Year",
                table: "Films",
                maxLength: 127,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Scenario",
                table: "Films",
                maxLength: 127,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Films",
                maxLength: 127,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Producer",
                table: "Films",
                maxLength: 127,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Premiere",
                table: "Films",
                maxLength: 127,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "Films",
                maxLength: 127,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FilmsName",
                table: "Films",
                maxLength: 127,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "Films",
                maxLength: 127,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Films",
                maxLength: 127,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Budget",
                table: "Films",
                maxLength: 127,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FilmId",
                table: "CountryFilm",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CountryName",
                table: "Country",
                maxLength: 127,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FilmId",
                table: "CompilationFilm",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompilationId",
                table: "CompilationFilm",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompilationName",
                table: "Compilation",
                maxLength: 127,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FilmId",
                table: "ArtistFilm",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ArtistName",
                table: "Artist",
                maxLength: 127,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Status_FilmId",
                table: "Status",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_ProducerFilm_FilmId",
                table: "ProducerFilm",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreFilm_FilmId",
                table: "GenreFilm",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryFilm_FilmId",
                table: "CountryFilm",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_CompilationFilm_CompilationId",
                table: "CompilationFilm",
                column: "CompilationId");

            migrationBuilder.CreateIndex(
                name: "IX_CompilationFilm_FilmId",
                table: "CompilationFilm",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistFilm_FilmId",
                table: "ArtistFilm",
                column: "FilmId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistFilm_Artist_ArtistId",
                table: "ArtistFilm",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistFilm_Films_FilmId",
                table: "ArtistFilm",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Compilation_Profile_ProfileId",
                table: "Compilation",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompilationFilm_Compilation_CompilationId",
                table: "CompilationFilm",
                column: "CompilationId",
                principalTable: "Compilation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompilationFilm_Films_FilmId",
                table: "CompilationFilm",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryFilm_Country_CountryId",
                table: "CountryFilm",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryFilm_Films_FilmId",
                table: "CountryFilm",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreFilm_Films_FilmId",
                table: "GenreFilm",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreFilm_Genre_GenreId",
                table: "GenreFilm",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProducerFilm_Films_FilmId",
                table: "ProducerFilm",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProducerFilm_Producer_ProducerId",
                table: "ProducerFilm",
                column: "ProducerId",
                principalTable: "Producer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Status_Films_FilmId",
                table: "Status",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Status_Profile_ProfileId",
                table: "Status",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtistFilm_Artist_ArtistId",
                table: "ArtistFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtistFilm_Films_FilmId",
                table: "ArtistFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_Compilation_Profile_ProfileId",
                table: "Compilation");

            migrationBuilder.DropForeignKey(
                name: "FK_CompilationFilm_Compilation_CompilationId",
                table: "CompilationFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_CompilationFilm_Films_FilmId",
                table: "CompilationFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryFilm_Country_CountryId",
                table: "CountryFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryFilm_Films_FilmId",
                table: "CountryFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreFilm_Films_FilmId",
                table: "GenreFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreFilm_Genre_GenreId",
                table: "GenreFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_ProducerFilm_Films_FilmId",
                table: "ProducerFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_ProducerFilm_Producer_ProducerId",
                table: "ProducerFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_Status_Films_FilmId",
                table: "Status");

            migrationBuilder.DropForeignKey(
                name: "FK_Status_Profile_ProfileId",
                table: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Status_FilmId",
                table: "Status");

            migrationBuilder.DropIndex(
                name: "IX_ProducerFilm_FilmId",
                table: "ProducerFilm");

            migrationBuilder.DropIndex(
                name: "IX_GenreFilm_FilmId",
                table: "GenreFilm");

            migrationBuilder.DropIndex(
                name: "IX_CountryFilm_FilmId",
                table: "CountryFilm");

            migrationBuilder.DropIndex(
                name: "IX_CompilationFilm_CompilationId",
                table: "CompilationFilm");

            migrationBuilder.DropIndex(
                name: "IX_CompilationFilm_FilmId",
                table: "CompilationFilm");

            migrationBuilder.DropIndex(
                name: "IX_ArtistFilm_FilmId",
                table: "ArtistFilm");

            migrationBuilder.DropColumn(
                name: "FilmId",
                table: "ProducerFilm");

            migrationBuilder.DropColumn(
                name: "FilmId",
                table: "GenreFilm");

            migrationBuilder.DropColumn(
                name: "FilmId",
                table: "CountryFilm");

            migrationBuilder.DropColumn(
                name: "CompilationName",
                table: "Compilation");

            migrationBuilder.DropColumn(
                name: "FilmId",
                table: "ArtistFilm");

            migrationBuilder.AddColumn<int>(
                name: "FilmsId",
                table: "Status",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FilmsId",
                table: "ProducerFilm",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ProducerName",
                table: "Producer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 127);

            migrationBuilder.AddColumn<int>(
                name: "FilmsId",
                table: "GenreFilm",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "GenreName",
                table: "Genre",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 127);

            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "Films",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldMaxLength: 127);

            migrationBuilder.AlterColumn<string>(
                name: "Scenario",
                table: "Films",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 127,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Films",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 127,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Producer",
                table: "Films",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 127,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Premiere",
                table: "Films",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldMaxLength: 127);

            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "Films",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 127);

            migrationBuilder.AlterColumn<string>(
                name: "FilmsName",
                table: "Films",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 127);

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "Films",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 127,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Films",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 127);

            migrationBuilder.AlterColumn<string>(
                name: "Budget",
                table: "Films",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 127,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FilmsId",
                table: "CountryFilm",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CountryName",
                table: "Country",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 127);

            migrationBuilder.AlterColumn<string>(
                name: "FilmId",
                table: "CompilationFilm",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "CompilationId",
                table: "CompilationFilm",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CompilationId1",
                table: "CompilationFilm",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FilmsId",
                table: "CompilationFilm",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Compilation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FilmsId",
                table: "ArtistFilm",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ArtistName",
                table: "Artist",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 127);

            migrationBuilder.CreateIndex(
                name: "IX_Status_FilmsId",
                table: "Status",
                column: "FilmsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProducerFilm_FilmsId",
                table: "ProducerFilm",
                column: "FilmsId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreFilm_FilmsId",
                table: "GenreFilm",
                column: "FilmsId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryFilm_FilmsId",
                table: "CountryFilm",
                column: "FilmsId");

            migrationBuilder.CreateIndex(
                name: "IX_CompilationFilm_CompilationId1",
                table: "CompilationFilm",
                column: "CompilationId1");

            migrationBuilder.CreateIndex(
                name: "IX_CompilationFilm_FilmsId",
                table: "CompilationFilm",
                column: "FilmsId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistFilm_FilmsId",
                table: "ArtistFilm",
                column: "FilmsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistFilm_Artist_ArtistId",
                table: "ArtistFilm",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistFilm_Films_FilmsId",
                table: "ArtistFilm",
                column: "FilmsId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Compilation_Profile_ProfileId",
                table: "Compilation",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompilationFilm_Compilation_CompilationId1",
                table: "CompilationFilm",
                column: "CompilationId1",
                principalTable: "Compilation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompilationFilm_Films_FilmsId",
                table: "CompilationFilm",
                column: "FilmsId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryFilm_Country_CountryId",
                table: "CountryFilm",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryFilm_Films_FilmsId",
                table: "CountryFilm",
                column: "FilmsId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreFilm_Films_FilmsId",
                table: "GenreFilm",
                column: "FilmsId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreFilm_Genre_GenreId",
                table: "GenreFilm",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProducerFilm_Films_FilmsId",
                table: "ProducerFilm",
                column: "FilmsId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProducerFilm_Producer_ProducerId",
                table: "ProducerFilm",
                column: "ProducerId",
                principalTable: "Producer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Status_Films_FilmsId",
                table: "Status",
                column: "FilmsId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Status_Profile_ProfileId",
                table: "Status",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
