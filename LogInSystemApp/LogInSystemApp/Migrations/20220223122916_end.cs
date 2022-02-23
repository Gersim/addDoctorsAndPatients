using Microsoft.EntityFrameworkCore.Migrations;

namespace LogInSystemApp.Migrations
{
    public partial class end : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor");

            migrationBuilder.RenameTable(
                name: "Doctor",
                newName: "doctor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_doctor",
                table: "doctor",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_doctor",
                table: "doctor");

            migrationBuilder.RenameTable(
                name: "doctor",
                newName: "Doctor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor",
                column: "Id");
        }
    }
}
