using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class ExternallyAddedFieldsintheAssets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
            table: "Assets");

            migrationBuilder.DropColumn(
            name: "ModifiedBy",
            table: "Assets");
        }
    }
}
