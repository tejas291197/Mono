using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class trayWidthAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TraySize_inch",
                table: "Assets",
                newName: "TrayWidth_inch");

            migrationBuilder.AlterColumn<string>(
                name: "DealerEmail",
                table: "Dealers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrayHeight_inch",
                table: "Assets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrayHeight_inch",
                table: "Assets");

            migrationBuilder.RenameColumn(
                name: "TrayWidth_inch",
                table: "Assets",
                newName: "TraySize_inch");

            migrationBuilder.AlterColumn<string>(
                name: "DealerEmail",
                table: "Dealers",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
