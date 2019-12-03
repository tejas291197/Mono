using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class AssetAddedmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssetCategory = table.Column<string>(nullable: true),
                    AssetType = table.Column<string>(nullable: true),
                    ControllerType = table.Column<string>(nullable: true),
                    Controllers = table.Column<int>(nullable: false),
                    Trays = table.Column<int>(nullable: false),
                    TraySize_inch = table.Column<string>(nullable: true),
                    Handed = table.Column<string>(nullable: true),
                    Format = table.Column<string>(nullable: true),
                    Power = table.Column<string>(nullable: true),
                    PowerConsumption = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");
        }
    }
}
