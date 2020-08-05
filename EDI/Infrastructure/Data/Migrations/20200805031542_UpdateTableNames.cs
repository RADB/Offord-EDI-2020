using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class UpdateTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Country_BillingCountryID",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Province_BillingProvinceID",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Country_ShippingCountryID",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Province_ShippingProvinceID",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Customers_BillingCountryID",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_BillingProvinceID",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ShippingCountryID",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ShippingProvinceID",
                table: "Customers");

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISO3DigitCountry = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    ISO2CountryCode = table.Column<string>(maxLength: 2, nullable: false),
                    ISO3CountryCode = table.Column<string>(maxLength: 3, nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sites",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteNumber = table.Column<string>(unicode: false, nullable: true),
                    SiteName = table.Column<string>(unicode: false, nullable: true),
                    Description = table.Column<string>(unicode: false, nullable: true),
                    CoordinatorId = table.Column<string>(unicode: false, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Code = table.Column<string>(maxLength: 50, nullable: false),
                    CountryID = table.Column<int>(nullable: false),
                    ProvinceTypeId = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 64, nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Provinces_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Provinces_ProvinceType_ProvinceTypeId",
                        column: x => x.ProvinceTypeId,
                        principalTable: "ProvinceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolNumber = table.Column<string>(unicode: false, nullable: true),
                    SchoolName = table.Column<string>(unicode: false, nullable: true),
                    CountryId = table.Column<int>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: false),
                    SiteId = table.Column<int>(nullable: false),
                    City = table.Column<string>(unicode: false, nullable: true),
                    Elpschool = table.Column<bool>(nullable: true),
                    Description = table.Column<string>(unicode: false, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(unicode: false, nullable: true),
                    ProvincesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schools_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schools_Provinces_ProvincesId",
                        column: x => x.ProvincesId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schools_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_CountryID",
                table: "Provinces",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_ProvinceTypeId",
                table: "Provinces",
                column: "ProvinceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_CountryId",
                table: "Schools",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_ProvincesId",
                table: "Schools",
                column: "ProvincesId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_SiteId",
                table: "Schools",
                column: "SiteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Sites");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ISO2CountryCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    ISO3CountryCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    ISO3DigitCountry = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProvinceTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Province_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Province_ProvinceType_ProvinceTypeId",
                        column: x => x.ProvinceTypeId,
                        principalTable: "ProvinceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_BillingCountryID",
                table: "Customers",
                column: "BillingCountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_BillingProvinceID",
                table: "Customers",
                column: "BillingProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ShippingCountryID",
                table: "Customers",
                column: "ShippingCountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ShippingProvinceID",
                table: "Customers",
                column: "ShippingProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_Province_CountryID",
                table: "Province",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Province_ProvinceTypeId",
                table: "Province",
                column: "ProvinceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Country_BillingCountryID",
                table: "Customers",
                column: "BillingCountryID",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Province_BillingProvinceID",
                table: "Customers",
                column: "BillingProvinceID",
                principalTable: "Province",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Country_ShippingCountryID",
                table: "Customers",
                column: "ShippingCountryID",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Province_ShippingProvinceID",
                table: "Customers",
                column: "ShippingProvinceID",
                principalTable: "Province",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
