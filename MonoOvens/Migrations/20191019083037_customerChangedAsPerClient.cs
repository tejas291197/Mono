using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class customerChangedAsPerClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Customers",
                newName: "Zone");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Customers",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "FirmName",
                table: "Customers",
                newName: "StorePostcode");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Customers",
                newName: "StoreName");

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HOAddress1",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HOAddress2",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HOAddress3",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostTown",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Postcode",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimaryContactName",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimaryContactNumber",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimaryEmail",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StoreAddress1",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StoreAddress2",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StoreCode",
                table: "Customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "HOAddress1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "HOAddress2",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "HOAddress3",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PostTown",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Postcode",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PrimaryContactName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PrimaryContactNumber",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PrimaryEmail",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "StoreAddress1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "StoreAddress2",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "StoreCode",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "Zone",
                table: "Customers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Customers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "StorePostcode",
                table: "Customers",
                newName: "FirmName");

            migrationBuilder.RenameColumn(
                name: "StoreName",
                table: "Customers",
                newName: "Address");
        }
    }
}
