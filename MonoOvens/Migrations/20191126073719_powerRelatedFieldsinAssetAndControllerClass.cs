using Microsoft.EntityFrameworkCore.Migrations;

namespace MonoOvens.Migrations
{
    public partial class powerRelatedFieldsinAssetAndControllerClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PowerConsumption",
                table: "Assets",
                newName: "LightType");

            migrationBuilder.AddColumn<int>(
                name: "Elements",
                table: "Controller",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fans",
                table: "Controller",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LightType",
                table: "Controller",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Lights",
                table: "Controller",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "kWh_Rating_Damper",
                table: "Controller",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "kWh_Rating_Element",
                table: "Controller",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "kWh_Rating_Fan",
                table: "Controller",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "kWh_Rating_Light",
                table: "Controller",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "kWh_Rating_WaterSolenoid",
                table: "Controller",
                nullable: false,
                defaultValue: 0f);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Elements",
                table: "Controller");

            migrationBuilder.DropColumn(
                name: "Fans",
                table: "Controller");

            migrationBuilder.DropColumn(
                name: "LightType",
                table: "Controller");

            migrationBuilder.DropColumn(
                name: "Lights",
                table: "Controller");

            migrationBuilder.DropColumn(
                name: "kWh_Rating_Damper",
                table: "Controller");

            migrationBuilder.DropColumn(
                name: "kWh_Rating_Element",
                table: "Controller");

            migrationBuilder.DropColumn(
                name: "kWh_Rating_Fan",
                table: "Controller");

            migrationBuilder.DropColumn(
                name: "kWh_Rating_Light",
                table: "Controller");

            migrationBuilder.DropColumn(
                name: "kWh_Rating_WaterSolenoid",
                table: "Controller");

            migrationBuilder.DropColumn(
                name: "Elements",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "Fans",
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

            migrationBuilder.RenameColumn(
                name: "LightType",
                table: "Assets",
                newName: "PowerConsumption");
        }
    }
}
