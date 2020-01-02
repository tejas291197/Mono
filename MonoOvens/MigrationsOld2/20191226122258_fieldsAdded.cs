using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class fieldsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModifiedBy",
                table: "Assets",
                newName: "modifiedby");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Assets",
                newName: "createdby");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "modifiedby",
                table: "Assets",
                newName: "ModifiedBy");

            migrationBuilder.RenameColumn(
                name: "createdby",
                table: "Assets",
                newName: "CreatedBy");
        }
    }
}
