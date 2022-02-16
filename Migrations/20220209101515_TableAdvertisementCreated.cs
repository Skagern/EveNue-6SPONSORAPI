using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GruppNrSexAPI.Migrations
{
    public partial class TableAdvertisementCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bild",
                table: "Sponsorer");

            migrationBuilder.RenameColumn(
                name: "Namn",
                table: "Sponsorer",
                newName: "Name");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Sponsorer",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Advertisement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Event = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisement", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertisement");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Sponsorer");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Sponsorer",
                newName: "Namn");

            migrationBuilder.AddColumn<byte>(
                name: "Bild",
                table: "Sponsorer",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
