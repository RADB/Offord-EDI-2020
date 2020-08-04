using Microsoft.EntityFrameworkCore.Migrations;

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class ChangeSchemaForSite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Site",
                table: "Site");

            migrationBuilder.EnsureSchema(
                name: "EDI");

            migrationBuilder.RenameTable(
                name: "Site",
                newName: "Sites",
                newSchema: "EDI");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sites",
                schema: "EDI",
                table: "Sites",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sites",
                schema: "EDI",
                table: "Sites");

            migrationBuilder.RenameTable(
                name: "Sites",
                schema: "EDI",
                newName: "Site");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Site",
                table: "Site",
                column: "Id");
        }
    }
}
