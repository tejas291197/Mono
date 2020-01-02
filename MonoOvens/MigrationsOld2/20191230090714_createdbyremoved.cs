using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class createdbyremoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
               name: "CreatedBy",
               table: "AspNetUsers",
               nullable: true);
           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.DropColumn(
             name: "CreatedBy",
             table: "AspNetUsers");

            
        }
    }
}
