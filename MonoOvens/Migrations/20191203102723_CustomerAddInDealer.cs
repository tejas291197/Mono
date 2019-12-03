using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class CustomerAddInDealer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerNumber",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Dealers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "CustomerNumber",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Dealers");
        }
    }
}
