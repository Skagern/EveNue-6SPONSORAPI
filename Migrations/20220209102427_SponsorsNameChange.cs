using Microsoft.EntityFrameworkCore.Migrations;

namespace GruppNrSexAPI.Migrations
{
    public partial class SponsorsNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sponsorer",
                table: "Sponsorer");

            migrationBuilder.RenameTable(
                name: "Sponsorer",
                newName: "Sponsors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sponsors",
                table: "Sponsors",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sponsors",
                table: "Sponsors");

            migrationBuilder.RenameTable(
                name: "Sponsors",
                newName: "Sponsorer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sponsorer",
                table: "Sponsorer",
                column: "Id");
        }
    }
}
