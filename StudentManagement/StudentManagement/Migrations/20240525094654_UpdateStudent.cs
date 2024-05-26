using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagement.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Students",
                newName: "RegistrationNo");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Students",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Students",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Students",
                newName: "EmailAddress");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DOB",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_CountryId",
                table: "Students",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GenderId",
                table: "Students",
                column: "GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Countries_CountryId",
                table: "Students",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_SystemCodeDetails_GenderId",
                table: "Students",
                column: "GenderId",
                principalTable: "SystemCodeDetails",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Countries_CountryId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_SystemCodeDetails_GenderId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_CountryId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_GenderId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DOB",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "RegistrationNo",
                table: "Students",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Students",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "Students",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Students",
                newName: "City");
        }
    }
}
