using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class CreatedDateFieldstoSiteModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Site",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Site",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Site",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Site",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Site");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Site");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Site");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Site",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
