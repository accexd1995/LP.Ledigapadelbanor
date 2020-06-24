using Microsoft.EntityFrameworkCore.Migrations;

namespace LP.API.Migrations
{
    public partial class NewColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "PadelCourts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "PadelCourts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zipcode",
                table: "PadelCourts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "PadelCourts");

            migrationBuilder.DropColumn(
                name: "City",
                table: "PadelCourts");

            migrationBuilder.DropColumn(
                name: "Zipcode",
                table: "PadelCourts");
        }
    }
}
