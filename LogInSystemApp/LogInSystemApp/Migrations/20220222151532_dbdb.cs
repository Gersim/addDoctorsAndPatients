using Microsoft.EntityFrameworkCore.Migrations;

namespace LogInSystemApp.Migrations
{
    public partial class dbdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tittle",
                table: "profiles",
                newName: "Symptoms");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "profiles",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "profiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Last_name",
                table: "profiles",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "profiles");

            migrationBuilder.DropColumn(
                name: "Last_name",
                table: "profiles");

            migrationBuilder.RenameColumn(
                name: "Symptoms",
                table: "profiles",
                newName: "Tittle");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "profiles",
                newName: "Description");
        }
    }
}
