using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class Namechanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DealerAddressLine1",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "DealerAddressLine2",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "DealerArea",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "DealerCity",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "DealerCountry",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "DealerEmail",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "DealerId",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Birthdate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "DealerState",
                table: "Dealers",
                newName: "DealerRegion");

            migrationBuilder.RenameColumn(
                name: "RollId",
                table: "AspNetUsers",
                newName: "AccessRole");

            migrationBuilder.AddColumn<string>(
                name: "PostTown",
                table: "Client",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostTown",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "DealerRegion",
                table: "Dealers",
                newName: "DealerState");

            migrationBuilder.RenameColumn(
                name: "AccessRole",
                table: "AspNetUsers",
                newName: "RollId");

            migrationBuilder.AddColumn<string>(
                name: "DealerAddressLine1",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DealerAddressLine2",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DealerArea",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DealerCity",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DealerCountry",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DealerEmail",
                table: "Dealers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DealerId",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthdate",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                nullable: true);
        }
    }
}
