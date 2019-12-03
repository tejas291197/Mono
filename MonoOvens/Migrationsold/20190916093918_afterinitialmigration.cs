using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class afterinitialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<string>(maxLength: 10, nullable: false),
                    PrimaryEmail = table.Column<string>(maxLength: 10, nullable: true),
                    PrimaryContactName = table.Column<string>(maxLength: 10, nullable: true),
                    PrimaryContactNumber = table.Column<string>(maxLength: 10, nullable: false),
                    ClientAddressLine_1 = table.Column<string>(maxLength: 10, nullable: true),
                    ClientAddressLine_2 = table.Column<string>(maxLength: 10, nullable: true),
                    ClientAddressLine_3 = table.Column<string>(maxLength: 10, nullable: true),
                    City = table.Column<string>(maxLength: 10, nullable: false),
                    HomePostcode = table.Column<string>(maxLength: 10, nullable: true),
                    Zone = table.Column<string>(maxLength: 10, nullable: true),
                    Region = table.Column<string>(maxLength: 10, nullable: true),
                    Area = table.Column<string>(maxLength: 10, nullable: true),
                    Storecode = table.Column<string>(maxLength: 10, nullable: true),
                    Type = table.Column<string>(maxLength: 10, nullable: false),
                    StoreName = table.Column<string>(maxLength: 10, nullable: true),
                    StoreAddressLine_1 = table.Column<string>(maxLength: 10, nullable: true),
                    StoreAddressLine_2 = table.Column<string>(maxLength: 10, nullable: true),
                    PostTown = table.Column<string>(maxLength: 10, nullable: true),
                    StorePostcode = table.Column<string>(maxLength: 10, nullable: true),
                    DelearID = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "ControllerModule",
                columns: table => new
                {
                    SerialNumber = table.Column<decimal>(type: "numeric(18, 0)", nullable: false),
                    FirmwareVersion = table.Column<string>(maxLength: 10, nullable: true),
                    SoftwareVersion = table.Column<string>(maxLength: 10, nullable: true),
                    RecipeVersion = table.Column<string>(maxLength: 10, nullable: true),
                    Skins = table.Column<string>(maxLength: 10, nullable: true),
                    wallpaper = table.Column<string>(maxLength: 10, nullable: true),
                    SevenDayTimer = table.Column<TimeSpan>(nullable: true),
                    SleepDelay = table.Column<string>(maxLength: 10, nullable: true),
                    ControllerDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    dateTime = table.Column<DateTime>(nullable: false),
                    RemoteKill = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControllerModule", x => x.SerialNumber);
                });

            migrationBuilder.CreateTable(
                name: "Dealer",
                columns: table => new
                {
                    DealerId = table.Column<string>(maxLength: 10, nullable: false),
                    Dealer_Name = table.Column<string>(maxLength: 10, nullable: true),
                    Dealer_Phone = table.Column<decimal>(type: "numeric(18, 0)", nullable: true),
                    Dealer_Email = table.Column<string>(nullable: true),
                    Dealer_AddressLine1 = table.Column<string>(maxLength: 10, nullable: true),
                    Dealer_AddressLine2 = table.Column<string>(maxLength: 10, nullable: true),
                    Dealer_Area = table.Column<string>(maxLength: 10, nullable: true),
                    Dealer_City = table.Column<string>(maxLength: 10, nullable: true),
                    Dealer_State = table.Column<string>(maxLength: 10, nullable: true),
                    Dealer_Country = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealer", x => x.DealerId);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    ManufacturerId = table.Column<string>(maxLength: 10, nullable: false),
                    Sup_Name = table.Column<string>(maxLength: 10, nullable: true),
                    Sup_AddressLine1 = table.Column<string>(maxLength: 50, nullable: true),
                    Sup_AddressLine2 = table.Column<string>(maxLength: 50, nullable: true),
                    Sup_Area = table.Column<string>(maxLength: 10, nullable: true),
                    Sup_City = table.Column<string>(maxLength: 10, nullable: true),
                    Sup_State = table.Column<string>(maxLength: 10, nullable: true),
                    Sup_Phone = table.Column<decimal>(type: "numeric(18, 0)", nullable: true),
                    Sup_Email = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.ManufacturerId);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<string>(maxLength: 10, nullable: false),
                    ShippedDate = table.Column<string>(maxLength: 10, nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    ManufacturerId = table.Column<string>(maxLength: 10, nullable: false),
                    ClientId = table.Column<string>(maxLength: 10, nullable: false),
                    ProductId = table.Column<string>(maxLength: 10, nullable: false),
                    DealerId = table.Column<string>(maxLength: 10, nullable: false),
                    OrderedQuantity = table.Column<string>(maxLength: 10, nullable: true),
                    ShippedQuantity = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<string>(maxLength: 10, nullable: false),
                    ProductDescription = table.Column<string>(maxLength: 50, nullable: true),
                    ProductCategoryId = table.Column<string>(maxLength: 10, nullable: true),
                    ProductSubCategoryId = table.Column<string>(maxLength: 10, nullable: true),
                    ProductTypeId = table.Column<string>(maxLength: 10, nullable: true),
                    ManufacturerId = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ManufacturerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "ControllerModule");

            migrationBuilder.DropTable(
                name: "Dealer");

            migrationBuilder.DropTable(
                name: "Manufacturer");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
