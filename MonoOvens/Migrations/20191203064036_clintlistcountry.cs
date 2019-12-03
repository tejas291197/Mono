using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class clintlistcountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostTown",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StoreAddress1",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StoreAddress2",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StoreCode",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StoreName",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StorePostcode",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Dealers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "PostTown",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "StoreAddress1",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "StoreAddress2",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "StoreCode",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "StoreName",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "StorePostcode",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Dealers");
        }
    }
}
