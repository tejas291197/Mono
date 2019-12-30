using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class removedExtraCreatedModifiedInAssets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModifiedBy",
                table: "Assets",
                newName: "modifiedby");

            //migrationBuilder.AddColumn<string>(
            //    name: "CreatedBy",
            //    table: "Controller",
            //    nullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "ModifiedBy",
            //    table: "Controller",
            //    nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "CreatedBy",
            //    table: "Controller");

            //migrationBuilder.DropColumn(
            //    name: "ModifiedBy",
            //    table: "Controller");

            migrationBuilder.RenameColumn(
                name: "modifiedby",
                table: "Assets",
                newName: "ModifiedBy");
        }
    }
}
