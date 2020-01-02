using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class AddHoDetailInStoreGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "StoreGroups",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HOAddress1",
                table: "StoreGroups",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HOAddress2",
                table: "StoreGroups",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HOAddress3",
                table: "StoreGroups",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Postcode",
                table: "StoreGroups",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "StoreGroups");

            migrationBuilder.DropColumn(
                name: "HOAddress1",
                table: "StoreGroups");

            migrationBuilder.DropColumn(
                name: "HOAddress2",
                table: "StoreGroups");

            migrationBuilder.DropColumn(
                name: "HOAddress3",
                table: "StoreGroups");

            migrationBuilder.DropColumn(
                name: "Postcode",
                table: "StoreGroups");
        }
    }
}
