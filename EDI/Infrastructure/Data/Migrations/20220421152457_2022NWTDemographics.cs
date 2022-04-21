using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2022NWTDemographics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // changing the datatype to an int to accommodate the higher language ids
            migrationBuilder.AlterColumn<int>(
                name: "OtherLanguage",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "int",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "OtherLanguage",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
