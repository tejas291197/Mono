using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class clientadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientName = table.Column<string>(nullable: true),
                    HOAddress1 = table.Column<string>(nullable: true),
                    HOAddress2 = table.Column<string>(nullable: true),
                    HOAddress3 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Postcode = table.Column<int>(nullable: false),
                    PrimaryContactName = table.Column<string>(nullable: true),
                    PrimaryContactNumber = table.Column<string>(nullable: true),
                    PrimaryContactEmail = table.Column<string>(nullable: true),
                    Zone = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    StoreCode = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    StoreName = table.Column<string>(nullable: true),
                    StoreAddress1 = table.Column<string>(nullable: true),
                    StoreAddress2 = table.Column<string>(nullable: true),
                    StorePostcode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
