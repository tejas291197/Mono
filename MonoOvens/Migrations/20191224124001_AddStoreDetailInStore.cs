using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class AddStoreDetailInStore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Stores",
                newName: "Zone");

            migrationBuilder.RenameColumn(
                name: "CustomerPhone",
                table: "Stores",
                newName: "StorePhone");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Stores",
                newName: "StoreContact");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Zone",
                table: "Stores",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "StorePhone",
                table: "Stores",
                newName: "CustomerPhone");

            migrationBuilder.RenameColumn(
                name: "StoreContact",
                table: "Stores",
                newName: "CustomerName");
        }
    }
}
