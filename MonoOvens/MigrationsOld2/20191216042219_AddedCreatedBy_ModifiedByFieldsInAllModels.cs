using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class AddedCreatedBy_ModifiedByFieldsInAllModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Stores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Stores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "StoreGroups",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "StoreGroups",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Importers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Importers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Controller",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Controller",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Assets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Assets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "StoreGroups");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "StoreGroups");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Importers");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Importers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Controller");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Controller");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AspNetUsers");
        }
    }
}
