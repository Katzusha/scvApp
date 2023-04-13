using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace scvApp.Migrations
{
    /// <inheritdoc />
    public partial class FifthCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostNumber",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Schools");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostNumber",
                table: "Schools",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Schools",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
