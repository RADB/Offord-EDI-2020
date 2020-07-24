using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EDI.Infrastructure.DaEDI.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
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
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DateDimension",
                columns: table => new
                {
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Day = table.Column<byte>(nullable: false),
                    DaySuffix = table.Column<string>(unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    Weekday = table.Column<byte>(nullable: false),
                    WeekDayName = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    IsWeekend = table.Column<bool>(nullable: false),
                    IsHoliday = table.Column<bool>(nullable: false),
                    HolidayText = table.Column<string>(unicode: false, maxLength: 64, nullable: true),
                    DOWInMonth = table.Column<byte>(nullable: false),
                    DayOfYear = table.Column<short>(nullable: false),
                    WeekOfMonth = table.Column<byte>(nullable: false),
                    WeekOfYear = table.Column<byte>(nullable: false),
                    ISOWeekOfYear = table.Column<byte>(nullable: false),
                    Month = table.Column<byte>(nullable: false),
                    MonthName = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Quarter = table.Column<byte>(nullable: false),
                    QuarterName = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    Year = table.Column<int>(nullable: false),
                    YearMonth = table.Column<int>(nullable: false),
                    FirstDayOfMonth = table.Column<DateTime>(type: "date", nullable: false),
                    LastDayOfMonth = table.Column<DateTime>(type: "date", nullable: false),
                    FirstDayOfQuarter = table.Column<DateTime>(type: "date", nullable: false),
                    LastDayOfQuarter = table.Column<DateTime>(type: "date", nullable: false),
                    FirstDayOfYear = table.Column<DateTime>(type: "date", nullable: false),
                    LastDayOfYear = table.Column<DateTime>(type: "date", nullable: false),
                    FirstDayOfNextMonth = table.Column<DateTime>(type: "date", nullable: false),
                    FirstDayOfNextYear = table.Column<DateTime>(type: "date", nullable: false),
                    FiscalYear = table.Column<int>(nullable: false),
                    FiscalYearMonth = table.Column<int>(nullable: false),
                    FiscalYearMonthOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateDimension", x => x.Date);
                });

            migrationBuilder.CreateTable(
                name: "FormConfigurations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormName = table.Column<string>(unicode: false, nullable: true),
                    FieldName = table.Column<string>(unicode: false, nullable: true),
                    Order = table.Column<int>(nullable: false),
                    IsRequired = table.Column<bool>(nullable: false),
                    IsVisible = table.Column<bool>(nullable: false),
                    IsEnabled = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormConfigurations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProvinceType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 64, nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvinceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemConfigurations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldName = table.Column<string>(unicode: false, nullable: true),
                    FieldValue = table.Column<string>(unicode: false, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemConfigurations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Province",
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

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Contact1 = table.Column<string>(nullable: true),
                    Contact2 = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(maxLength: 50, nullable: true),
                    CurrencyID = table.Column<int>(nullable: true),
                    BillingCountryID = table.Column<int>(nullable: true),
                    BillingProvinceID = table.Column<int>(nullable: true),
                    BillingAddress1 = table.Column<string>(unicode: false, nullable: true),
                    BillingAddress2 = table.Column<string>(unicode: false, nullable: true),
                    BillingCity = table.Column<string>(unicode: false, nullable: true),
                    BillingPostal = table.Column<string>(maxLength: 50, nullable: true),
                    HasShippingAddress = table.Column<bool>(nullable: true),
                    ShippingContact = table.Column<string>(nullable: true),
                    ShippingCountryID = table.Column<int>(nullable: true),
                    ShippingProvinceID = table.Column<int>(nullable: true),
                    ShippingAddress1 = table.Column<string>(unicode: false, nullable: true),
                    ShippingAddress2 = table.Column<string>(unicode: false, nullable: true),
                    ShippingCity = table.Column<string>(unicode: false, nullable: true),
                    ShippingPostal = table.Column<string>(maxLength: 50, nullable: true),
                    ShippingPhone = table.Column<string>(maxLength: 50, nullable: true),
                    DeliveryInstructions = table.Column<string>(unicode: false, nullable: true),
                    AccountNumber = table.Column<string>(maxLength: 50, nullable: true),
                    Fax = table.Column<string>(maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(maxLength: 50, nullable: true),
                    TollFree = table.Column<string>(maxLength: 50, nullable: true),
                    Website = table.Column<string>(maxLength: 50, nullable: true),
                    InternalNotes = table.Column<string>(unicode: false, nullable: true),
                    LastSentDate = table.Column<DateTime>(type: "date", nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Country_BillingCountryID",
                        column: x => x.BillingCountryID,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_Province_BillingProvinceID",
                        column: x => x.BillingProvinceID,
                        principalTable: "Province",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_Currency_CurrencyID",
                        column: x => x.CurrencyID,
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_Country_ShippingCountryID",
                        column: x => x.ShippingCountryID,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_Province_ShippingProvinceID",
                        column: x => x.ShippingProvinceID,
                        principalTable: "Province",
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
                name: "IX_Customers_CurrencyID",
                table: "Customers",
                column: "CurrencyID");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "DateDimension");

            migrationBuilder.DropTable(
                name: "FormConfigurations");

            migrationBuilder.DropTable(
                name: "SystemConfigurations");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "ProvinceType");
        }
    }
}
