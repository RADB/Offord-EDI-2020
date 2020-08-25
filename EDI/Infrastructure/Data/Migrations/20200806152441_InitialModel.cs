using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "EDI");

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
                name: "Languages",
                schema: "EDI",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(maxLength: 3, nullable: false),
                    English = table.Column<string>(maxLength: 50, nullable: false),
                    French = table.Column<string>(maxLength: 50, nullable: true),
                    Sequence = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sites",
                schema: "EDI",
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
                name: "SpecialProblems",
                schema: "EDI",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(maxLength: 3, nullable: false),
                    English = table.Column<string>(maxLength: 150, nullable: true),
                    French = table.Column<string>(maxLength: 150, nullable: true),
                    Sequence = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialProblems", x => x.Id);
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
                schema: "EDI",
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
                    ModifiedBy = table.Column<string>(unicode: false, nullable: true)
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
                        name: "FK_Schools_Sites_SiteId",
                        column: x => x.SiteId,
                        principalSchema: "EDI",
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
                schema: "EDI",
                table: "Schools",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_SiteId",
                schema: "EDI",
                table: "Schools",
                column: "SiteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DateDimension");

            migrationBuilder.DropTable(
                name: "FormConfigurations");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "SystemConfigurations");

            migrationBuilder.DropTable(
                name: "Languages",
                schema: "EDI");

            migrationBuilder.DropTable(
                name: "Schools",
                schema: "EDI");

            migrationBuilder.DropTable(
                name: "SpecialProblems",
                schema: "EDI");

            migrationBuilder.DropTable(
                name: "ProvinceType");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Sites",
                schema: "EDI");
        }
    }
}
