using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class dealerAdded12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "Dealers",
                columns: table => new
                {
                    DealerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DealerName = table.Column<string>(nullable: true),
                    DealerPhone = table.Column<decimal>(nullable: true),
                    DealerEmail = table.Column<string>(nullable: true),
                    DealerAddressLine1 = table.Column<string>(nullable: true),
                    DealerAddressLine2 = table.Column<string>(nullable: true),
                    DealerArea = table.Column<string>(nullable: true),
                    DealerCity = table.Column<string>(nullable: true),
                    DealerState = table.Column<string>(nullable: true),
                    DealerCountry = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealers", x => x.DealerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dealers");

            migrationBuilder.CreateTable(
                name: "Dealer",
                columns: table => new
                {
                    DealerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DealerAddressLine1 = table.Column<string>(nullable: true),
                    DealerAddressLine2 = table.Column<string>(nullable: true),
                    DealerArea = table.Column<string>(nullable: true),
                    DealerCity = table.Column<string>(nullable: true),
                    DealerCountry = table.Column<string>(nullable: true),
                    DealerEmail = table.Column<string>(nullable: true),
                    DealerName = table.Column<string>(nullable: true),
                    DealerPhone = table.Column<decimal>(nullable: true),
                    DealerState = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealer", x => x.DealerId);
                });
        }
    }
}
