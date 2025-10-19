using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2025Notification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
              name: "Notification",
              schema: "EDI",
              table: "Questionnaires.Configuration",
              type: "nvarchar(max)",              
              nullable: true,
              oldClrType: typeof(string),
              oldType: "nvarchar(500)",
              oldMaxLength: 500,
              oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
              name: "Notification",
              schema: "EDI",
              table: "Questionnaires.Configuration",
              type: "nvarchar(500)",
              maxLength: 500,
              nullable: true,
              oldClrType: typeof(string),
              oldType: "nvarchar(max)",              
              oldNullable: true);
        }
    }
}
