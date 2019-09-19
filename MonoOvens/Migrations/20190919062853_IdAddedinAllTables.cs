using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class IdAddedinAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Product_Product_InverseManufacturerProductId",
            //    table: "Product");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Product",
            //    table: "Product");

            //migrationBuilder.DropIndex(
            //    name: "IX_Product_InverseManufacturerProductId",
            //    table: "Product");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Order",
            //    table: "Order");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Manufacturer",
            //    table: "Manufacturer");

            //migrationBuilder.DropColumn(
            //    name: "InverseManufacturerProductId",
            //    table: "Product");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "Controller");

            migrationBuilder.RenameColumn(
                name: "DealerId",
                table: "Dealers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Client",
                newName: "Id");

            //migrationBuilder.AlterColumn<string>(
            //    name: "ProductId",
            //    table: "Product",
            //    nullable: true,
            //    oldClrType: typeof(string));

            //migrationBuilder.AddColumn<int>(
            //    name: "Id",
            //    table: "Product",
            //    nullable: false,
            //    defaultValue: 0)
            //    .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            //migrationBuilder.AddColumn<int>(
            //    name: "InverseManufacturerId",
            //    table: "Product",
            //    nullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "OrderId",
            //    table: "Order",
            //    nullable: true,
            //    oldClrType: typeof(string));

            //migrationBuilder.AddColumn<int>(
            //    name: "Id",
            //    table: "Order",
            //    nullable: false,
            //    defaultValue: 0)
            //    .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            //migrationBuilder.AlterColumn<string>(
            //    name: "ManufacturerId",
            //    table: "Manufacturer",
            //    nullable: true,
            //    oldClrType: typeof(string));

            //migrationBuilder.AddColumn<int>(
            //    name: "Id",
            //    table: "Manufacturer",
            //    nullable: false,
            //    defaultValue: 0)
            //    .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Product",
            //    table: "Product",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Order",
            //    table: "Order",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Manufacturer",
            //    table: "Manufacturer",
            //    column: "Id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Product_InverseManufacturerId",
            //    table: "Product",
            //    column: "InverseManufacturerId",
            //    unique: true,
            //    filter: "[InverseManufacturerId] IS NOT NULL");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Product_Product_InverseManufacturerId",
            //    table: "Product",
            //    column: "InverseManufacturerId",
            //    principalTable: "Product",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Product_Product_InverseManufacturerId",
            //    table: "Product");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Product",
            //    table: "Product");

            //migrationBuilder.DropIndex(
            //    name: "IX_Product_InverseManufacturerId",
            //    table: "Product");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Order",
            //    table: "Order");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Manufacturer",
            //    table: "Manufacturer");

            //migrationBuilder.DropColumn(
            //    name: "Id",
            //    table: "Product");

            //migrationBuilder.DropColumn(
            //    name: "InverseManufacturerId",
            //    table: "Product");

            //migrationBuilder.DropColumn(
            //    name: "Id",
            //    table: "Order");

            //migrationBuilder.DropColumn(
            //    name: "Id",
            //    table: "Manufacturer");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Dealers",
                newName: "DealerId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Client",
                newName: "ClientId");

            //migrationBuilder.AlterColumn<string>(
            //    name: "ProductId",
            //    table: "Product",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldNullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "InverseManufacturerProductId",
            //    table: "Product",
            //    nullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "OrderId",
            //    table: "Order",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "ManufacturerId",
            //    table: "Manufacturer",
            //    nullable: false,
            //    oldClrType: typeof(string),
               // oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SerialNumber",
                table: "Controller",
                nullable: false,
                defaultValue: 0m);

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Product",
            //    table: "Product",
            //    column: "ProductId");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Order",
            //    table: "Order",
            //    column: "OrderId");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Manufacturer",
            //    table: "Manufacturer",
            //    column: "ManufacturerId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Product_InverseManufacturerProductId",
            //    table: "Product",
            //    column: "InverseManufacturerProductId",
            //    unique: true,
            //    filter: "[InverseManufacturerProductId] IS NOT NULL");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Product_Product_InverseManufacturerProductId",
            //    table: "Product",
            //    column: "InverseManufacturerProductId",
            //    principalTable: "Product",
            //    principalColumn: "ProductId",
            //    onDelete: ReferentialAction.Restrict);
        }
    }
}
