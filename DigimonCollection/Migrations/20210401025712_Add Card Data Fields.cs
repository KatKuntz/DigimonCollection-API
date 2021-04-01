using Microsoft.EntityFrameworkCore.Migrations;

namespace DigimonCollection.Migrations
{
    public partial class AddCardDataFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DP",
                table: "Cards",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EvoCost",
                table: "Cards",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Cards",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlayCost",
                table: "Cards",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimaryEffect",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondaryEffect",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DP",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "EvoCost",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "PlayCost",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "PrimaryEffect",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "SecondaryEffect",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Cards");
        }
    }
}
