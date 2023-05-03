using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace scvApp.Migrations
{
    /// <inheritdoc />
    public partial class SeventhCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birth",
                table: "Submits");

            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "Teachers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "Teachers");

            migrationBuilder.AddColumn<DateOnly>(
                name: "Birth",
                table: "Submits",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }
    }
}
