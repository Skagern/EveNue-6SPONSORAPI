using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GruppNrSexAPI.Migrations
{
    public partial class FixedMsitake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Advertisements");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Sponsors",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Sponsors");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Advertisements",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
