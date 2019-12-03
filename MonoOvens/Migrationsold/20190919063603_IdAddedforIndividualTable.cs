using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class IdAddedforIndividualTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DealerId",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "Controller",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientId",
                table: "Client",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DealerId",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "Controller");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Client");
        }
    }
}
