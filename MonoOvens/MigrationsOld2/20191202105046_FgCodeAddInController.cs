using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class FgCodeAddInController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FG_Code",
                table: "Controller",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FG_Code",
                table: "Controller");
        }
    }
}
