using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace scvApp.Migrations
{
    /// <inheritdoc />
    public partial class SixthCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Submits",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SchoolTitle",
                table: "Submits",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Submits");

            migrationBuilder.DropColumn(
                name: "SchoolTitle",
                table: "Submits");
        }
    }
}
