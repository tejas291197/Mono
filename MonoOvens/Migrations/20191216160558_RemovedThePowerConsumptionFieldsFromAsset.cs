using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class RemovedThePowerConsumptionFieldsFromAsset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Elements",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "Fans",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "LightType",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "Lights",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "kWh_Rating_Damper",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "kWh_Rating_Element",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "kWh_Rating_Fan",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "kWh_Rating_Light",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "kWh_Rating_WaterSolenoid",
                table: "Assets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Elements",
                table: "Assets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fans",
                table: "Assets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LightType",
                table: "Assets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Lights",
                table: "Assets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "kWh_Rating_Damper",
                table: "Assets",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "kWh_Rating_Element",
                table: "Assets",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "kWh_Rating_Fan",
                table: "Assets",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "kWh_Rating_Light",
                table: "Assets",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "kWh_Rating_WaterSolenoid",
                table: "Assets",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
