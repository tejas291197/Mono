using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class clientedited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimaryContactEmail",
                table: "Client");

            migrationBuilder.AddColumn<int>(
                name: "PrimaryEmail",
                table: "Client",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimaryEmail",
                table: "Client");

            migrationBuilder.AddColumn<string>(
                name: "PrimaryContactEmail",
                table: "Client",
                nullable: true);
        }
    }
}
