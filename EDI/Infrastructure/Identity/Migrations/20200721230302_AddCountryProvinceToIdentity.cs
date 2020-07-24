using Microsoft.EntityFrameworkCore.Migrations;

namespace EDI.Infrastructure.Identity.Migrations
{
    public partial class AddCountryProvinceToIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProvinceID",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProvinceID",
                table: "AspNetUsers");
        }
    }
}
