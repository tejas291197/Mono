using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class updatedTraySize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrayHeight_inch",
                table: "Assets");

            migrationBuilder.RenameColumn(
                name: "TrayWidth_inch",
                table: "Assets",
                newName: "TraySize");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TraySize",
                table: "Assets",
                newName: "TrayWidth_inch");

            migrationBuilder.AddColumn<string>(
                name: "TrayHeight_inch",
                table: "Assets",
                nullable: true);
        }
    }
}
