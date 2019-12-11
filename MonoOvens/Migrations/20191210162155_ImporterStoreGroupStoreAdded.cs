using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class ImporterStoreGroupStoreAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "CustomerNumber",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "PostTown",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "StoreAddress1",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "StoreAddress2",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "StoreCode",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "StoreName",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "StorePostcode",
                table: "Dealers");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Dealers",
                newName: "ImporterName");

            migrationBuilder.CreateTable(
                name: "Importers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImporterName = table.Column<string>(nullable: true),
                    ImporterPhone = table.Column<string>(nullable: true),
                    ImporterRegion = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Importers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoreGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImporterName = table.Column<string>(nullable: true),
                    DealerName = table.Column<string>(nullable: true),
                    StoreGroupName = table.Column<string>(nullable: true),
                    StoreGroupPhone = table.Column<string>(nullable: true),
                    StoreGroupRegion = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImporterName = table.Column<string>(nullable: true),
                    DealerName = table.Column<string>(nullable: true),
                    StoreGroupName = table.Column<string>(nullable: true),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerPhone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    StoreCode = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    StoreName = table.Column<string>(nullable: true),
                    StoreAddress1 = table.Column<string>(nullable: true),
                    StoreAddress2 = table.Column<string>(nullable: true),
                    PostTown = table.Column<string>(nullable: true),
                    StorePostcode = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Importers");

            migrationBuilder.DropTable(
                name: "StoreGroups");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.RenameColumn(
                name: "ImporterName",
                table: "Dealers",
                newName: "Type");

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerNumber",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostTown",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StoreAddress1",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StoreAddress2",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StoreCode",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StoreName",
                table: "Dealers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StorePostcode",
                table: "Dealers",
                nullable: true);
        }
    }
}
