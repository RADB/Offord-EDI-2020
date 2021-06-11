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

            migrationBuilder.EnsureSchema(
                name: "LUData");

            migrationBuilder.EnsureSchema(
                name: "Staging");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "ChildStatus",
                schema: "LUData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    English = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    French = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                schema: "LUData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    English = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    French = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ISO2CountryCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    ISO3CountryCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
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
                    Day = table.Column<byte>(type: "tinyint", nullable: false),
                    DaySuffix = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    Weekday = table.Column<byte>(type: "tinyint", nullable: false),
                    WeekDayName = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    IsWeekend = table.Column<bool>(type: "bit", nullable: false),
                    IsHoliday = table.Column<bool>(type: "bit", nullable: false),
                    HolidayText = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: true),
                    DOWInMonth = table.Column<byte>(type: "tinyint", nullable: false),
                    DayOfYear = table.Column<short>(type: "smallint", nullable: false),
                    WeekOfMonth = table.Column<byte>(type: "tinyint", nullable: false),
                    WeekOfYear = table.Column<byte>(type: "tinyint", nullable: false),
                    ISOWeekOfYear = table.Column<byte>(type: "tinyint", nullable: false),
                    Month = table.Column<byte>(type: "tinyint", nullable: false),
                    MonthName = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Quarter = table.Column<byte>(type: "tinyint", nullable: false),
                    QuarterName = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    YearMonth = table.Column<int>(type: "int", nullable: false),
                    FirstDayOfMonth = table.Column<DateTime>(type: "date", nullable: false),
                    LastDayOfMonth = table.Column<DateTime>(type: "date", nullable: false),
                    FirstDayOfQuarter = table.Column<DateTime>(type: "date", nullable: false),
                    LastDayOfQuarter = table.Column<DateTime>(type: "date", nullable: false),
                    FirstDayOfYear = table.Column<DateTime>(type: "date", nullable: false),
                    LastDayOfYear = table.Column<DateTime>(type: "date", nullable: false),
                    FirstDayOfNextMonth = table.Column<DateTime>(type: "date", nullable: false),
                    FirstDayOfNextYear = table.Column<DateTime>(type: "date", nullable: false),
                    FiscalYear = table.Column<int>(type: "int", nullable: false),
                    FiscalYearMonth = table.Column<int>(type: "int", nullable: false),
                    FiscalYearMonthOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateDimension", x => x.Date);
                });

            migrationBuilder.CreateTable(
                name: "FileImportStatus",
                schema: "LUData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    English = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    French = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileImportStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormConfigurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    FieldName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormConfigurations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                schema: "LUData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    English = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    French = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuConfigurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NodeId = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    English = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    French = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    URL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IconCss = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ForAdmin = table.Column<bool>(type: "bit", nullable: false),
                    ForTeacher = table.Column<bool>(type: "bit", nullable: false),
                    ForCoordinator = table.Column<bool>(type: "bit", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    HasChild = table.Column<bool>(type: "bit", nullable: false),
                    PID = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuConfigurations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProvinceType",
                schema: "LUData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvinceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemConfigurations",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    FieldValue = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemConfigurations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeacherStatus",
                schema: "LUData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    English = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    French = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Translations",
                schema: "LUData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    English = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    French = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSessions",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    FieldValue = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    UserID = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    FieldObject = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Years",
                schema: "LUData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ediyear = table.Column<short>(type: "smallint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    Alberta = table.Column<bool>(type: "bit", nullable: true),
                    BritishColumbia = table.Column<bool>(type: "bit", nullable: true),
                    Manitoba = table.Column<bool>(type: "bit", nullable: true),
                    NewBrunswick = table.Column<bool>(type: "bit", nullable: true),
                    NewfoundlandandLabrador = table.Column<bool>(type: "bit", nullable: true),
                    NovaScotia = table.Column<bool>(type: "bit", nullable: true),
                    Nunavut = table.Column<bool>(type: "bit", nullable: true),
                    Ontario = table.Column<bool>(type: "bit", nullable: true),
                    PrinceEdwardIsland = table.Column<bool>(type: "bit", nullable: true),
                    Quebec = table.Column<bool>(type: "bit", nullable: true),
                    Saskatchewan = table.Column<bool>(type: "bit", nullable: true),
                    YukonTerritory = table.Column<bool>(type: "bit", nullable: true),
                    NorthwestTerritories = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Years", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FileImports",
                schema: "Staging",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    SiteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoordinatorName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CoordinatorEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TeacherEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LocalId = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    ChildDob = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ChildPostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ChildEdiid = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    FileImportStatusId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileImports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileImportStatus_FileImports",
                        column: x => x.FileImportStatusId,
                        principalSchema: "LUData",
                        principalTable: "FileImportStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gender_FileImports",
                        column: x => x.GenderId,
                        principalSchema: "LUData",
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                schema: "LUData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    English = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    French = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EDICode = table.Column<byte>(type: "tinyint", nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    ProvinceTypeId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Country_Provinces",
                        column: x => x.CountryID,
                        principalSchema: "LUData",
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProvinceType_Provinces",
                        column: x => x.ProvinceTypeId,
                        principalSchema: "LUData",
                        principalTable: "ProvinceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Coordinators",
                schema: "EDI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    YearId = table.Column<int>(type: "int", nullable: true, comment: "Year of the EDI implementation"),
                    CoordinatorName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    Description = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Years_Coordinators",
                        column: x => x.YearId,
                        principalSchema: "LUData",
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FAQ",
                schema: "EDI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearId = table.Column<int>(type: "int", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsTeacherFaq = table.Column<bool>(type: "bit", nullable: true),
                    IsAdministratorFaq = table.Column<bool>(type: "bit", nullable: true),
                    IsCoordinatorFaq = table.Column<bool>(type: "bit", nullable: true),
                    Sequence = table.Column<short>(type: "smallint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    Alberta = table.Column<bool>(type: "bit", nullable: true),
                    BritishColumbia = table.Column<bool>(type: "bit", nullable: true),
                    Manitoba = table.Column<bool>(type: "bit", nullable: true),
                    NewBrunswick = table.Column<bool>(type: "bit", nullable: true),
                    NewfoundlandandLabrador = table.Column<bool>(type: "bit", nullable: true),
                    NovaScotia = table.Column<bool>(type: "bit", nullable: true),
                    Nunavut = table.Column<bool>(type: "bit", nullable: true),
                    Ontario = table.Column<bool>(type: "bit", nullable: true),
                    PrinceEdwardIsland = table.Column<bool>(type: "bit", nullable: true),
                    Quebec = table.Column<bool>(type: "bit", nullable: true),
                    Saskatchewan = table.Column<bool>(type: "bit", nullable: true),
                    YukonTerritory = table.Column<bool>(type: "bit", nullable: true),
                    NorthwestTerritories = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQ", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Years_FAQ",
                        column: x => x.YearId,
                        principalSchema: "LUData",
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InputTypes",
                schema: "LUData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearId = table.Column<int>(type: "int", nullable: false),
                    English = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    French = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Years_InputTypes",
                        column: x => x.YearId,
                        principalSchema: "LUData",
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                schema: "EDI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsTeacherLink = table.Column<bool>(type: "bit", nullable: true),
                    IsAdminLink = table.Column<bool>(type: "bit", nullable: true),
                    IsCoordinatorLink = table.Column<bool>(type: "bit", nullable: true),
                    Sequence = table.Column<short>(type: "smallint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    Alberta = table.Column<bool>(type: "bit", nullable: true),
                    BritishColumbia = table.Column<bool>(type: "bit", nullable: true),
                    Manitoba = table.Column<bool>(type: "bit", nullable: true),
                    NewBrunswick = table.Column<bool>(type: "bit", nullable: true),
                    NewfoundlandandLabrador = table.Column<bool>(type: "bit", nullable: true),
                    NovaScotia = table.Column<bool>(type: "bit", nullable: true),
                    Nunavut = table.Column<bool>(type: "bit", nullable: true),
                    Ontario = table.Column<bool>(type: "bit", nullable: true),
                    PrinceEdwardIsland = table.Column<bool>(type: "bit", nullable: true),
                    Quebec = table.Column<bool>(type: "bit", nullable: true),
                    Saskatchewan = table.Column<bool>(type: "bit", nullable: true),
                    YukonTerritory = table.Column<bool>(type: "bit", nullable: true),
                    NorthwestTerritories = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Years_Links",
                        column: x => x.YearId,
                        principalSchema: "LUData",
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LookupSets",
                schema: "LUData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearId = table.Column<int>(type: "int", nullable: false),
                    LookupName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Years_LookupSets",
                        column: x => x.YearId,
                        principalSchema: "LUData",
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewsFeed",
                schema: "EDI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearId = table.Column<int>(type: "int", nullable: false),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Alberta = table.Column<bool>(type: "bit", nullable: true),
                    BritishColumbia = table.Column<bool>(type: "bit", nullable: true),
                    Manitoba = table.Column<bool>(type: "bit", nullable: true),
                    NewBrunswick = table.Column<bool>(type: "bit", nullable: true),
                    NewfoundlandandLabrador = table.Column<bool>(type: "bit", nullable: true),
                    NovaScotia = table.Column<bool>(type: "bit", nullable: true),
                    Nunavut = table.Column<bool>(type: "bit", nullable: true),
                    Ontario = table.Column<bool>(type: "bit", nullable: true),
                    PrinceEdwardIsland = table.Column<bool>(type: "bit", nullable: true),
                    Quebec = table.Column<bool>(type: "bit", nullable: true),
                    Saskatchewan = table.Column<bool>(type: "bit", nullable: true),
                    YukonTerritory = table.Column<bool>(type: "bit", nullable: true),
                    NorthwestTerritories = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsFeed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Years_NewsFeeds",
                        column: x => x.YearId,
                        principalSchema: "LUData",
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orientations",
                schema: "LUData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearId = table.Column<int>(type: "int", nullable: true),
                    English = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    French = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orientations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Years_Orientations",
                        column: x => x.YearId,
                        principalSchema: "LUData",
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questionnaires",
                schema: "EDI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearId = table.Column<int>(type: "int", nullable: false),
                    QuestionnaireName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    English = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    French = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionFrench = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowProgressBar = table.Column<bool>(type: "bit", nullable: true, comment: "Answered x of y Questions"),
                    EntityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowQuestionNumbers = table.Column<bool>(type: "bit", nullable: true),
                    Sequence = table.Column<int>(type: "int", nullable: false),
                    IsChildQuestionnaire = table.Column<bool>(type: "bit", nullable: false),
                    IsTeacherQuestionnaire = table.Column<bool>(type: "bit", nullable: false),
                    QuestionsRequired = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    Alberta = table.Column<bool>(type: "bit", nullable: true),
                    BritishColumbia = table.Column<bool>(type: "bit", nullable: true),
                    Manitoba = table.Column<bool>(type: "bit", nullable: true),
                    NewBrunswick = table.Column<bool>(type: "bit", nullable: true),
                    NewfoundlandandLabrador = table.Column<bool>(type: "bit", nullable: true),
                    NovaScotia = table.Column<bool>(type: "bit", nullable: true),
                    Nunavut = table.Column<bool>(type: "bit", nullable: true),
                    Ontario = table.Column<bool>(type: "bit", nullable: true),
                    PrinceEdwardIsland = table.Column<bool>(type: "bit", nullable: true),
                    Quebec = table.Column<bool>(type: "bit", nullable: true),
                    Saskatchewan = table.Column<bool>(type: "bit", nullable: true),
                    YukonTerritory = table.Column<bool>(type: "bit", nullable: true),
                    NorthwestTerritories = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaires", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Years_Questionnaires",
                        column: x => x.YearId,
                        principalSchema: "LUData",
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sites",
                schema: "EDI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteNumber = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    YearId = table.Column<int>(type: "int", nullable: true, comment: "Year of the EDI implementation"),
                    SiteName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Description = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CoordinatorId = table.Column<int>(type: "int", unicode: false, nullable: true),
                    IsTestSite = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coordinators_Sites",
                        column: x => x.CoordinatorId,
                        principalSchema: "EDI",
                        principalTable: "Coordinators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Years_Sites",
                        column: x => x.YearId,
                        principalSchema: "LUData",
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LookupSetOptions",
                schema: "LUData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LookupSetId = table.Column<int>(type: "int", nullable: false),
                    English = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    French = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Value = table.Column<short>(type: "smallint", nullable: false),
                    Sequence = table.Column<short>(type: "smallint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupSetOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LookupSet_LookupSetOptions",
                        column: x => x.LookupSetId,
                        principalSchema: "LUData",
                        principalTable: "LookupSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questionnaires.Configuration",
                schema: "EDI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionnaireId = table.Column<int>(type: "int", nullable: false),
                    InputTypeId = table.Column<int>(type: "int", nullable: false),
                    OrientationId = table.Column<int>(type: "int", nullable: true),
                    QuestionNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    IsHeader = table.Column<bool>(type: "bit", nullable: false),
                    ShowGroupName = table.Column<bool>(type: "bit", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsCollapsible = table.Column<bool>(type: "bit", nullable: false),
                    English = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    French = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VariableName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Variable Name for data dictionary"),
                    EntityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EntityField = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HasLookupEntity = table.Column<bool>(type: "bit", nullable: false),
                    LookupEntity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LookupEntityId = table.Column<int>(type: "int", nullable: true),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    IsReadOnly = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((0))"),
                    IsConditional = table.Column<bool>(type: "bit", nullable: true),
                    Condition = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    HasNotification = table.Column<bool>(type: "bit", nullable: true),
                    NotificationCondition = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Notification = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NotificationFrench = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasHelp = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    HelpTextEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HelpTextFrench = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mask = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MaxLength = table.Column<byte>(type: "tinyint", nullable: true),
                    Columns = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "((10))"),
                    ColumnSpan = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((1))"),
                    Sequence = table.Column<int>(type: "int", nullable: false),
                    YearId = table.Column<int>(type: "int", nullable: true),
                    Min = table.Column<int>(type: "int", nullable: true),
                    Max = table.Column<int>(type: "int", nullable: true),
                    NumberStep = table.Column<double>(type: "float", nullable: true),
                    NumberFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false, defaultValueSql: "('Renner')"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false, defaultValueSql: "('Renner')"),
                    Alberta = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    BritishColumbia = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Manitoba = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    NewBrunswick = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    NewfoundlandandLabrador = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    NovaScotia = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Nunavut = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Ontario = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    PrinceEdwardIsland = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Quebec = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Saskatchewan = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    YukonTerritory = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    NorthwestTerritories = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaires.Configuration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InputType_QuestionnairesConfigurations",
                        column: x => x.InputTypeId,
                        principalSchema: "LUData",
                        principalTable: "InputTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LookupSet_QuestionnaireConfiguration",
                        column: x => x.LookupEntityId,
                        principalSchema: "LUData",
                        principalTable: "LookupSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orientation_QuestionnairesConfigurations",
                        column: x => x.OrientationId,
                        principalSchema: "LUData",
                        principalTable: "Orientations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Questionnaire_QuestionnairesConfigurations",
                        column: x => x.QuestionnaireId,
                        principalSchema: "EDI",
                        principalTable: "Questionnaires",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Years_Questionnaires.Configurations",
                        column: x => x.YearId,
                        principalSchema: "LUData",
                        principalTable: "Years",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                schema: "EDI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolNumber = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    YearId = table.Column<int>(type: "int", nullable: true, comment: "Year of the EDI implementation"),
                    SchoolName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Description = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Country_Schools",
                        column: x => x.CountryId,
                        principalSchema: "LUData",
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schools_Provinces",
                        column: x => x.ProvinceId,
                        principalSchema: "LUData",
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sites_Schools",
                        column: x => x.SiteId,
                        principalSchema: "EDI",
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Years_Schools",
                        column: x => x.YearId,
                        principalSchema: "LUData",
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                schema: "EDI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true, comment: "Links to user in EDI.Identity database"),
                    TeacherNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    YearId = table.Column<int>(type: "int", nullable: true, comment: "Year of the EDI implementation"),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    TeacherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    TeacherStatusId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schools_Teachers",
                        column: x => x.SchoolId,
                        principalSchema: "EDI",
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherStatus_Children",
                        column: x => x.TeacherStatusId,
                        principalSchema: "LUData",
                        principalTable: "TeacherStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Years_Teachers",
                        column: x => x.YearId,
                        principalSchema: "LUData",
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Children",
                schema: "EDI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ediid = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    LocalId = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    YearId = table.Column<int>(type: "int", nullable: true, comment: "Year of the EDI implementation"),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    ChildStatusId = table.Column<int>(type: "int", nullable: true),
                    Dob = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ChildNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PercentComplete = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "((0))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChildStatus_Children",
                        column: x => x.ChildStatusId,
                        principalSchema: "LUData",
                        principalTable: "ChildStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gender_Children",
                        column: x => x.GenderId,
                        principalSchema: "LUData",
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teachers_Children",
                        column: x => x.TeacherId,
                        principalSchema: "EDI",
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Years_Children",
                        column: x => x.YearId,
                        principalSchema: "LUData",
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Questionnaires.Data.TeacherProfile",
                schema: "EDI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    FirstTimeCompletingEdi = table.Column<byte>(type: "tinyint", nullable: true),
                    TimesCompletedEdi = table.Column<byte>(type: "tinyint", nullable: true),
                    PreviouslyAttendedTeacherTraining = table.Column<byte>(type: "tinyint", nullable: true),
                    TimesAttendedTeacherTraining = table.Column<byte>(type: "tinyint", nullable: true),
                    TeacherTrainingForThisImplementation = table.Column<byte>(type: "tinyint", nullable: true),
                    TeacherTrainingUsefulness = table.Column<byte>(type: "tinyint", nullable: true),
                    GuideUsefulness = table.Column<byte>(type: "tinyint", nullable: true),
                    GuideOtherComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<byte>(type: "tinyint", nullable: true),
                    AgeCategory = table.Column<byte>(type: "tinyint", nullable: true),
                    ExperienceInYears = table.Column<short>(type: "smallint", nullable: true),
                    ExperienceSchoolInYears = table.Column<short>(type: "smallint", nullable: true),
                    ExperienceGradeInYears = table.Column<short>(type: "smallint", nullable: true),
                    EducationSomeCoursesBachelors = table.Column<byte>(type: "tinyint", nullable: true),
                    EducationTeachingCertificate = table.Column<byte>(type: "tinyint", nullable: true),
                    EducationBachelorDegree = table.Column<byte>(type: "tinyint", nullable: true),
                    EducationBachelorEducationDegree = table.Column<byte>(type: "tinyint", nullable: true),
                    EducationPostBachelorCourses = table.Column<byte>(type: "tinyint", nullable: true),
                    EducationPostBachelorCertificate = table.Column<byte>(type: "tinyint", nullable: true),
                    EducationMastersCourses = table.Column<byte>(type: "tinyint", nullable: true),
                    EducationMastersDegree = table.Column<byte>(type: "tinyint", nullable: true),
                    EducationPhdcourses = table.Column<byte>(type: "tinyint", nullable: true),
                    EducationPhd = table.Column<byte>(type: "tinyint", nullable: true),
                    EducationOther = table.Column<byte>(type: "tinyint", nullable: true),
                    EducationOtherComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false, defaultValueSql: "('admin')"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false, defaultValueSql: "('admin')"),
                    LanguageCompleted = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    YearId = table.Column<int>(type: "int", nullable: true),
                    QuestionnaireId = table.Column<int>(type: "int", nullable: false),
                    CompletedQuestions = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))"),
                    RequiredQuestions = table.Column<int>(type: "int", nullable: false),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaires.Data.TeacherProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questionnaires_Questionnaires.Data.TeacherProfiles",
                        column: x => x.QuestionnaireId,
                        principalSchema: "EDI",
                        principalTable: "Questionnaires",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Teachers_QuestionnairesDataTeacherProfiles",
                        column: x => x.TeacherId,
                        principalSchema: "EDI",
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Years_Questionnaires.Data.TeacherProfile",
                        column: x => x.YearId,
                        principalSchema: "LUData",
                        principalTable: "Years",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Questionnaires.Data.Demographics",
                schema: "EDI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChildId = table.Column<int>(type: "int", nullable: false),
                    StudentStatus = table.Column<byte>(type: "tinyint", nullable: true),
                    ClassAssignment = table.Column<byte>(type: "tinyint", nullable: true),
                    Dob = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    AttendedJk = table.Column<byte>(type: "tinyint", nullable: true),
                    Jkteacher = table.Column<byte>(type: "tinyint", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ClassType = table.Column<byte>(type: "tinyint", nullable: true),
                    SpecialNeeds = table.Column<byte>(type: "tinyint", nullable: true),
                    ConsideredEsl = table.Column<byte>(type: "tinyint", nullable: true),
                    IPRC = table.Column<bool>(type: "bit", nullable: true),
                    IEP = table.Column<bool>(type: "bit", nullable: true),
                    SpecialEducation = table.Column<bool>(type: "bit", nullable: true),
                    Gifted = table.Column<bool>(type: "bit", nullable: true),
                    EFSL = table.Column<byte>(type: "tinyint", nullable: true),
                    FrenchImmersion = table.Column<byte>(type: "tinyint", nullable: true),
                    OtherImmersion = table.Column<byte>(type: "tinyint", nullable: true),
                    EthnicStatus = table.Column<byte>(type: "tinyint", nullable: true),
                    Communicates = table.Column<byte>(type: "tinyint", nullable: true),
                    Chipewyan = table.Column<bool>(type: "bit", nullable: true),
                    Cree = table.Column<bool>(type: "bit", nullable: true),
                    English = table.Column<bool>(type: "bit", nullable: true),
                    French = table.Column<bool>(type: "bit", nullable: true),
                    Gwichin = table.Column<bool>(type: "bit", nullable: true),
                    Inuinnaqtun = table.Column<bool>(type: "bit", nullable: true),
                    Inuktitut = table.Column<bool>(type: "bit", nullable: true),
                    Inuvialuktun = table.Column<bool>(type: "bit", nullable: true),
                    NorthSlavey = table.Column<bool>(type: "bit", nullable: true),
                    SouthSlavey = table.Column<bool>(type: "bit", nullable: true),
                    Tlicho = table.Column<bool>(type: "bit", nullable: true),
                    OtherLanguage = table.Column<byte>(type: "tinyint", nullable: true),
                    IndigenousAncestry = table.Column<byte>(type: "tinyint", nullable: true),
                    AfricanDescent = table.Column<byte>(type: "tinyint", nullable: true),
                    FirstLanguage1 = table.Column<byte>(type: "tinyint", nullable: true),
                    FirstLanguage2 = table.Column<byte>(type: "tinyint", nullable: true),
                    FirstLanguage3 = table.Column<byte>(type: "tinyint", nullable: true),
                    LandAgreement = table.Column<byte>(type: "tinyint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false, defaultValueSql: "('admin')"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false, defaultValueSql: "('admin')"),
                    LanguageCompleted = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    YearId = table.Column<int>(type: "int", nullable: true),
                    QuestionnaireId = table.Column<int>(type: "int", nullable: false),
                    CompletedQuestions = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))"),
                    RequiredQuestions = table.Column<int>(type: "int", nullable: false),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaires.Data.Demographics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Children_Questionnaires.Data.Demographics",
                        column: x => x.ChildId,
                        principalSchema: "EDI",
                        principalTable: "Children",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gender_QuestionnaireDemographics",
                        column: x => x.GenderId,
                        principalSchema: "LUData",
                        principalTable: "Genders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Questionnaires_Questionnaires.Data.Demographics",
                        column: x => x.QuestionnaireId,
                        principalSchema: "EDI",
                        principalTable: "Questionnaires",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Years_Questionnaires.Data.Demographics",
                        column: x => x.YearId,
                        principalSchema: "LUData",
                        principalTable: "Years",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Questionnaires.Data.SectionA",
                schema: "EDI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChildId = table.Column<int>(type: "int", nullable: false),
                    Days = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UnderDressed = table.Column<byte>(type: "tinyint", nullable: true),
                    Tired = table.Column<byte>(type: "tinyint", nullable: true),
                    Late = table.Column<byte>(type: "tinyint", nullable: true),
                    Hungry = table.Column<byte>(type: "tinyint", nullable: true),
                    WashroomHabits = table.Column<byte>(type: "tinyint", nullable: true),
                    HandPreference = table.Column<byte>(type: "tinyint", nullable: true),
                    Coordinated = table.Column<byte>(type: "tinyint", nullable: true),
                    Holding = table.Column<byte>(type: "tinyint", nullable: true),
                    Manipulating = table.Column<byte>(type: "tinyint", nullable: true),
                    ClimbingStairs = table.Column<byte>(type: "tinyint", nullable: true),
                    Energy = table.Column<byte>(type: "tinyint", nullable: true),
                    PhysicalDevelopment = table.Column<byte>(type: "tinyint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false, defaultValueSql: "('admin')"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false, defaultValueSql: "('admin')"),
                    LanguageCompleted = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    YearId = table.Column<int>(type: "int", nullable: true),
                    QuestionnaireId = table.Column<int>(type: "int", nullable: false),
                    CompletedQuestions = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))"),
                    RequiredQuestions = table.Column<int>(type: "int", nullable: false),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaires.Data.SectionA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Children_Questionnaires.Data.SectionAs",
                        column: x => x.ChildId,
                        principalSchema: "EDI",
                        principalTable: "Children",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questionnaires_Questionnaires.Data.SectionAs",
                        column: x => x.QuestionnaireId,
                        principalSchema: "EDI",
                        principalTable: "Questionnaires",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Years_Questionnaires.Data.SectionA",
                        column: x => x.YearId,
                        principalSchema: "LUData",
                        principalTable: "Years",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Questionnaires.Data.SectionB",
                schema: "EDI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChildId = table.Column<int>(type: "int", nullable: false),
                    Effective = table.Column<byte>(type: "tinyint", nullable: true),
                    Listens = table.Column<byte>(type: "tinyint", nullable: true),
                    Tells = table.Column<byte>(type: "tinyint", nullable: true),
                    Imagines = table.Column<byte>(type: "tinyint", nullable: true),
                    Communicates = table.Column<byte>(type: "tinyint", nullable: true),
                    Understands = table.Column<byte>(type: "tinyint", nullable: true),
                    Articulates = table.Column<byte>(type: "tinyint", nullable: true),
                    Handles = table.Column<byte>(type: "tinyint", nullable: true),
                    Books = table.Column<byte>(type: "tinyint", nullable: true),
                    Reading = table.Column<byte>(type: "tinyint", nullable: true),
                    Letters10 = table.Column<byte>(type: "tinyint", nullable: true),
                    Sounds = table.Column<byte>(type: "tinyint", nullable: true),
                    Rhyming = table.Column<byte>(type: "tinyint", nullable: true),
                    GroupReading = table.Column<byte>(type: "tinyint", nullable: true),
                    SimpleWords = table.Column<byte>(type: "tinyint", nullable: true),
                    ComplexWords = table.Column<byte>(type: "tinyint", nullable: true),
                    SimpleSentences = table.Column<byte>(type: "tinyint", nullable: true),
                    Writing = table.Column<byte>(type: "tinyint", nullable: true),
                    WritingDirections = table.Column<byte>(type: "tinyint", nullable: true),
                    Voluntarily = table.Column<byte>(type: "tinyint", nullable: true),
                    WritesName = table.Column<byte>(type: "tinyint", nullable: true),
                    WriteSimpleWords = table.Column<byte>(type: "tinyint", nullable: true),
                    WriteSimpleSentences = table.Column<byte>(type: "tinyint", nullable: true),
                    Remembers = table.Column<byte>(type: "tinyint", nullable: true),
                    Mathematics = table.Column<byte>(type: "tinyint", nullable: true),
                    NumberGames = table.Column<byte>(type: "tinyint", nullable: true),
                    Sorting = table.Column<byte>(type: "tinyint", nullable: true),
                    OneToOne = table.Column<byte>(type: "tinyint", nullable: true),
                    Count20 = table.Column<byte>(type: "tinyint", nullable: true),
                    Recognize10 = table.Column<byte>(type: "tinyint", nullable: true),
                    Bigger = table.Column<byte>(type: "tinyint", nullable: true),
                    Shapes = table.Column<byte>(type: "tinyint", nullable: true),
                    TimeConcepts = table.Column<byte>(type: "tinyint", nullable: true),
                    SpecialNumSkills = table.Column<byte>(type: "tinyint", nullable: true),
                    SpecialLitSkills = table.Column<byte>(type: "tinyint", nullable: true),
                    SpecialArtSkills = table.Column<byte>(type: "tinyint", nullable: true),
                    SpecialMusSkills = table.Column<byte>(type: "tinyint", nullable: true),
                    SpecialAthSkills = table.Column<byte>(type: "tinyint", nullable: true),
                    SpecialPblskills = table.Column<byte>(type: "tinyint", nullable: true),
                    SpecialOthSkills = table.Column<byte>(type: "tinyint", nullable: true),
                    OtherSkills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false, defaultValueSql: "('admin')"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false, defaultValueSql: "('admin')"),
                    LanguageCompleted = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearId = table.Column<int>(type: "int", nullable: true),
                    QuestionnaireId = table.Column<int>(type: "int", nullable: false),
                    CompletedQuestions = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))"),
                    RequiredQuestions = table.Column<int>(type: "int", nullable: false),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaires.Data.SectionB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Children_Questionnaires.Data.SectionBs",
                        column: x => x.ChildId,
                        principalSchema: "EDI",
                        principalTable: "Children",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questionnaires_Questionnaires.Data.SectionBs",
                        column: x => x.QuestionnaireId,
                        principalSchema: "EDI",
                        principalTable: "Questionnaires",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Years_Questionnaires.Data.SectionB",
                        column: x => x.YearId,
                        principalSchema: "LUData",
                        principalTable: "Years",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Questionnaires.Data.SectionC",
                schema: "EDI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChildId = table.Column<int>(type: "int", nullable: false),
                    Social = table.Column<byte>(type: "tinyint", nullable: true),
                    Peers = table.Column<byte>(type: "tinyint", nullable: true),
                    Cooperative = table.Column<byte>(type: "tinyint", nullable: true),
                    Play = table.Column<byte>(type: "tinyint", nullable: true),
                    Rules = table.Column<byte>(type: "tinyint", nullable: true),
                    RespectsProperty = table.Column<byte>(type: "tinyint", nullable: true),
                    SelfControl = table.Column<byte>(type: "tinyint", nullable: true),
                    SelfConfidence = table.Column<byte>(type: "tinyint", nullable: true),
                    RespectsAdults = table.Column<byte>(type: "tinyint", nullable: true),
                    RespectsChildren = table.Column<byte>(type: "tinyint", nullable: true),
                    Responsible = table.Column<byte>(type: "tinyint", nullable: true),
                    Listens = table.Column<byte>(type: "tinyint", nullable: true),
                    Directions = table.Column<byte>(type: "tinyint", nullable: true),
                    WorkOnTime = table.Column<byte>(type: "tinyint", nullable: true),
                    Independent = table.Column<byte>(type: "tinyint", nullable: true),
                    TakesCard = table.Column<byte>(type: "tinyint", nullable: true),
                    Neat = table.Column<byte>(type: "tinyint", nullable: true),
                    Curious = table.Column<byte>(type: "tinyint", nullable: true),
                    EagerNewToy = table.Column<byte>(type: "tinyint", nullable: true),
                    EagerNewGame = table.Column<byte>(type: "tinyint", nullable: true),
                    EagerRead = table.Column<byte>(type: "tinyint", nullable: true),
                    SolvesProblem = table.Column<byte>(type: "tinyint", nullable: true),
                    FollowInstruction1Step = table.Column<byte>(type: "tinyint", nullable: true),
                    Routines = table.Column<byte>(type: "tinyint", nullable: true),
                    RoutineChanges = table.Column<byte>(type: "tinyint", nullable: true),
                    AnswersQuestions = table.Column<byte>(type: "tinyint", nullable: true),
                    Tolerance = table.Column<byte>(type: "tinyint", nullable: true),
                    HelpHurt = table.Column<byte>(type: "tinyint", nullable: true),
                    MessCleanup = table.Column<byte>(type: "tinyint", nullable: true),
                    Mediate = table.Column<byte>(type: "tinyint", nullable: true),
                    AssistOthers = table.Column<byte>(type: "tinyint", nullable: true),
                    Comforting = table.Column<byte>(type: "tinyint", nullable: true),
                    HelpPickUpObjects = table.Column<byte>(type: "tinyint", nullable: true),
                    IncludesOthers = table.Column<byte>(type: "tinyint", nullable: true),
                    HelpSick = table.Column<byte>(type: "tinyint", nullable: true),
                    Separation = table.Column<byte>(type: "tinyint", nullable: true),
                    Fights = table.Column<byte>(type: "tinyint", nullable: true),
                    Bullies = table.Column<byte>(type: "tinyint", nullable: true),
                    KicksHits = table.Column<byte>(type: "tinyint", nullable: true),
                    Takes = table.Column<byte>(type: "tinyint", nullable: true),
                    LaughsAtOthers = table.Column<byte>(type: "tinyint", nullable: true),
                    Restless = table.Column<byte>(type: "tinyint", nullable: true),
                    Distactable = table.Column<byte>(type: "tinyint", nullable: true),
                    Fidgets = table.Column<byte>(type: "tinyint", nullable: true),
                    Disobedient = table.Column<byte>(type: "tinyint", nullable: true),
                    Temper = table.Column<byte>(type: "tinyint", nullable: true),
                    Impulsive = table.Column<byte>(type: "tinyint", nullable: true),
                    TakingTurns = table.Column<byte>(type: "tinyint", nullable: true),
                    Settle = table.Column<byte>(type: "tinyint", nullable: true),
                    Inattentive = table.Column<byte>(type: "tinyint", nullable: true),
                    Unhappy = table.Column<byte>(type: "tinyint", nullable: true),
                    Fearful = table.Column<byte>(type: "tinyint", nullable: true),
                    Worried = table.Column<byte>(type: "tinyint", nullable: true),
                    Cries = table.Column<byte>(type: "tinyint", nullable: true),
                    Nervous = table.Column<byte>(type: "tinyint", nullable: true),
                    NoDecisions = table.Column<byte>(type: "tinyint", nullable: true),
                    Shy = table.Column<byte>(type: "tinyint", nullable: true),
                    SucksThumb = table.Column<byte>(type: "tinyint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false, defaultValueSql: "('admin')"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false, defaultValueSql: "('admin')"),
                    LanguageCompleted = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    YearId = table.Column<int>(type: "int", nullable: true),
                    QuestionnaireId = table.Column<int>(type: "int", nullable: false),
                    CompletedQuestions = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))"),
                    RequiredQuestions = table.Column<int>(type: "int", nullable: false),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaires.Data.SectionC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Children_Questionnaires.Data.SectionCs",
                        column: x => x.ChildId,
                        principalSchema: "EDI",
                        principalTable: "Children",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questionnaires_Questionnaires.Data.SectionCs",
                        column: x => x.QuestionnaireId,
                        principalSchema: "EDI",
                        principalTable: "Questionnaires",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Years_Questionnaires.Data.SectionC",
                        column: x => x.YearId,
                        principalSchema: "LUData",
                        principalTable: "Years",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Questionnaires.Data.SectionD",
                schema: "EDI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChildId = table.Column<int>(type: "int", nullable: false),
                    Problem = table.Column<byte>(type: "tinyint", nullable: true),
                    Physical = table.Column<byte>(type: "tinyint", nullable: true),
                    Visual = table.Column<byte>(type: "tinyint", nullable: true),
                    Hearing = table.Column<byte>(type: "tinyint", nullable: true),
                    Speech = table.Column<byte>(type: "tinyint", nullable: true),
                    Learning = table.Column<byte>(type: "tinyint", nullable: true),
                    Emotional = table.Column<byte>(type: "tinyint", nullable: true),
                    Behavioural = table.Column<byte>(type: "tinyint", nullable: true),
                    Language = table.Column<byte>(type: "tinyint", nullable: true),
                    Chronic = table.Column<byte>(type: "tinyint", nullable: true),
                    Dental = table.Column<byte>(type: "tinyint", nullable: true),
                    Other = table.Column<byte>(type: "tinyint", nullable: true),
                    OtherSpecify = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialProblem1 = table.Column<byte>(type: "tinyint", nullable: true),
                    SpecialProblem2 = table.Column<byte>(type: "tinyint", nullable: true),
                    SpecialProblem3 = table.Column<byte>(type: "tinyint", nullable: true),
                    OtherSpecialProblem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Support = table.Column<byte>(type: "tinyint", nullable: true),
                    Further = table.Column<byte>(type: "tinyint", nullable: true),
                    WaitList = table.Column<byte>(type: "tinyint", nullable: true),
                    NeedsAssess = table.Column<byte>(type: "tinyint", nullable: true),
                    AssessSpecify = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false, defaultValueSql: "('admin')"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false, defaultValueSql: "('admin')"),
                    LanguageCompleted = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    YearId = table.Column<int>(type: "int", nullable: true),
                    QuestionnaireId = table.Column<int>(type: "int", nullable: false),
                    CompletedQuestions = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))"),
                    RequiredQuestions = table.Column<int>(type: "int", nullable: false),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaires.Data.SectionD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Children_Questionnaires.Data.SectionDs",
                        column: x => x.ChildId,
                        principalSchema: "EDI",
                        principalTable: "Children",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questionnaires_Questionnaires.Data.SectionDs",
                        column: x => x.QuestionnaireId,
                        principalSchema: "EDI",
                        principalTable: "Questionnaires",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Years_Questionnaires.Data.SectionD",
                        column: x => x.YearId,
                        principalSchema: "LUData",
                        principalTable: "Years",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Questionnaires.Data.SectionE",
                schema: "EDI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChildId = table.Column<int>(type: "int", nullable: false),
                    Birth1 = table.Column<byte>(type: "tinyint", nullable: true),
                    One2 = table.Column<byte>(type: "tinyint", nullable: true),
                    Two3 = table.Column<byte>(type: "tinyint", nullable: true),
                    Three4 = table.Column<byte>(type: "tinyint", nullable: true),
                    Four5 = table.Column<byte>(type: "tinyint", nullable: true),
                    FamilyLiteracy = table.Column<byte>(type: "tinyint", nullable: true),
                    FamilyResource = table.Column<byte>(type: "tinyint", nullable: true),
                    LibraryReading = table.Column<byte>(type: "tinyint", nullable: true),
                    MusicArts = table.Column<byte>(type: "tinyint", nullable: true),
                    Sports = table.Column<byte>(type: "tinyint", nullable: true),
                    Clubs = table.Column<byte>(type: "tinyint", nullable: true),
                    Cultural = table.Column<byte>(type: "tinyint", nullable: true),
                    Langauges = table.Column<byte>(type: "tinyint", nullable: true),
                    Religion = table.Column<byte>(type: "tinyint", nullable: true),
                    Other = table.Column<byte>(type: "tinyint", nullable: true),
                    OtherSpecify = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NSECDIS = table.Column<byte>(type: "tinyint", nullable: true),
                    EIBI = table.Column<byte>(type: "tinyint", nullable: true),
                    NSHS = table.Column<byte>(type: "tinyint", nullable: true),
                    OtherServices = table.Column<byte>(type: "tinyint", nullable: true),
                    OtherServicesSpecify = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrePrimary = table.Column<byte>(type: "tinyint", nullable: true),
                    CentreBased = table.Column<byte>(type: "tinyint", nullable: true),
                    DaycareName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeDaycare = table.Column<byte>(type: "tinyint", nullable: true),
                    HomeDaycareName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NonParentInHome = table.Column<byte>(type: "tinyint", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false, defaultValueSql: "('admin')"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false, defaultValueSql: "('admin')"),
                    LanguageCompleted = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    YearId = table.Column<int>(type: "int", nullable: true),
                    QuestionnaireId = table.Column<int>(type: "int", nullable: false),
                    CompletedQuestions = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))"),
                    RequiredQuestions = table.Column<int>(type: "int", nullable: false),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaires.Data.SectionE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Children_Questionnaires.Data.SectionEs",
                        column: x => x.ChildId,
                        principalSchema: "EDI",
                        principalTable: "Children",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questionnaires_Questionnaires.Data.SectionEs",
                        column: x => x.QuestionnaireId,
                        principalSchema: "EDI",
                        principalTable: "Questionnaires",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Years_Questionnaires.Data.SectionE",
                        column: x => x.YearId,
                        principalSchema: "LUData",
                        principalTable: "Years",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "ChildStatus",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "English", "French", "ModifiedBy", "ModifiedDate", "Sequence" },
                values: new object[,]
                {
                    { 2, "1", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 536, DateTimeKind.Local).AddTicks(506), "New", "Nouveau", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 539, DateTimeKind.Local).AddTicks(9763), 1 },
                    { 1, "2", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 540, DateTimeKind.Local).AddTicks(255), "In Progress", "En cours", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 540, DateTimeKind.Local).AddTicks(266), 2 },
                    { 3, "3", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 540, DateTimeKind.Local).AddTicks(269), "Complete", "Achevé", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 540, DateTimeKind.Local).AddTicks(272), 3 },
                    { 4, "4", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 540, DateTimeKind.Local).AddTicks(274), "Locked", "Fermé à clé", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 540, DateTimeKind.Local).AddTicks(276), 4 }
                });

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "FileImportStatus",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "English", "French", "ModifiedBy", "ModifiedDate", "Sequence" },
                values: new object[,]
                {
                    { 1, "1", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 546, DateTimeKind.Local).AddTicks(2442), "Imported", "Importé", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 546, DateTimeKind.Local).AddTicks(2504), 1 },
                    { 2, "2", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 546, DateTimeKind.Local).AddTicks(2512), "Processed", "Traité", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 546, DateTimeKind.Local).AddTicks(2514), 2 },
                    { 3, "3", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 546, DateTimeKind.Local).AddTicks(2518), "Duplicate", "Dupliquer", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 546, DateTimeKind.Local).AddTicks(2520), 3 },
                    { 4, "4", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 546, DateTimeKind.Local).AddTicks(2523), "Invalid Province", "Province non valide", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 546, DateTimeKind.Local).AddTicks(2525), 4 }
                });

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "Genders",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "English", "French", "ModifiedBy", "ModifiedDate", "Sequence" },
                values: new object[,]
                {
                    { 1, "1", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 550, DateTimeKind.Local).AddTicks(1877), "Male", "Mâle", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 550, DateTimeKind.Local).AddTicks(1917), 1 },
                    { 2, "2", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 550, DateTimeKind.Local).AddTicks(1924), "Female", "Femelle", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 550, DateTimeKind.Local).AddTicks(1926), 2 }
                });

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "TeacherStatus",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "English", "French", "ModifiedBy", "ModifiedDate", "Sequence" },
                values: new object[,]
                {
                    { 2, "1", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 586, DateTimeKind.Local).AddTicks(6367), "New", "Nouveau", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 586, DateTimeKind.Local).AddTicks(6406), 1 },
                    { 1, "2", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 586, DateTimeKind.Local).AddTicks(6412), "In Progress", "En cours", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 586, DateTimeKind.Local).AddTicks(6414), 2 },
                    { 3, "3", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 586, DateTimeKind.Local).AddTicks(6418), "Complete", "Achevé", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 586, DateTimeKind.Local).AddTicks(6420), 3 },
                    { 4, "4", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 586, DateTimeKind.Local).AddTicks(6422), "Locked", "Fermé à clé", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 586, DateTimeKind.Local).AddTicks(6424), 4 }
                });

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "Years",
                columns: new[] { "Id", "Alberta", "BritishColumbia", "CreatedBy", "CreatedDate", "Ediyear", "Manitoba", "ModifiedBy", "ModifiedDate", "NewBrunswick", "NewfoundlandandLabrador", "NorthwestTerritories", "NovaScotia", "Nunavut", "Ontario", "PrinceEdwardIsland", "Quebec", "Saskatchewan", "YukonTerritory" },
                values: new object[] { 1, null, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 601, DateTimeKind.Local).AddTicks(5245), (short)2021, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 601, DateTimeKind.Local).AddTicks(5285), null, null, true, true, null, null, null, null, null, null });

            migrationBuilder.InsertData(
                schema: "EDI",
                table: "Questionnaires",
                columns: new[] { "Id", "Alberta", "BritishColumbia", "CreatedBy", "CreatedDate", "DescriptionEnglish", "DescriptionFrench", "English", "EntityName", "French", "IsChildQuestionnaire", "IsTeacherQuestionnaire", "Manitoba", "ModifiedBy", "ModifiedDate", "NewBrunswick", "NewfoundlandandLabrador", "NorthwestTerritories", "NovaScotia", "Nunavut", "Ontario", "PrinceEdwardIsland", "Quebec", "QuestionnaireName", "QuestionsRequired", "Saskatchewan", "Sequence", "ShowProgressBar", "ShowQuestionNumbers", "YearId", "YukonTerritory" },
                values: new object[,]
                {
                    { 13, null, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1675), "Section E", "Section E", "Section E", "Questionnaires.Data.SectionE", "Section E", true, false, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1677), null, null, null, null, null, true, null, null, "Section E", 0, null, 60, true, true, 1, null },
                    { 11, null, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1662), "Demographics", "Demographics", "Demographics", "Questionnaires.Data.Demographics", "Demographics", true, false, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1665), null, null, null, null, null, true, null, null, "Demographics", 0, null, 10, true, true, 1, null },
                    { 10, null, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1614), "Section D", "Section D", "Section D", "Questionnaires.Data.SectionD", "Section D", true, false, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1616), null, null, null, true, null, null, null, null, "Section D", 0, null, 50, true, true, 1, null },
                    { 9, null, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1607), "Section E", "Section E", "Section E", "Questionnaires.Data.SectionE", "Section E", true, false, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1609), null, null, null, true, null, null, null, null, "Section E", 0, null, 60, true, true, 1, null },
                    { 8, null, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1592), "Demographics", "Demographics", "Demographics", "Questionnaires.Data.Demographics", "Demographics", true, false, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1604), null, null, null, true, null, null, null, null, "Demographics", 0, null, 10, true, true, 1, null },
                    { 7, null, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1586), "Section E", "Section E", "Section E", "Questionnaires.Data.SectionE", "Section E", true, false, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1588), null, null, true, null, null, null, null, null, "Section E", 0, null, 60, true, true, 1, null },
                    { 6, null, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1580), "Section D", "Section D", "Section D", "Questionnaires.Data.SectionD", "Section D", true, false, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1582), null, null, true, null, null, null, null, null, "Section D", 0, null, 50, true, true, 1, null },
                    { 5, null, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1574), "Section C", "Section C", "Section C", "Questionnaires.Data.SectionC", "Section C", true, false, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1576), null, null, true, true, null, true, null, null, "Section C", 0, null, 40, true, true, 1, null },
                    { 4, null, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1559), "Section B", "Section B", "Section B", "Questionnaires.Data.SectionB", "Section B", true, false, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1568), null, null, true, true, null, true, null, null, "Section B", 0, null, 30, true, true, 1, null },
                    { 3, null, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1059), "Section A", "Section A", "Section A", "Questionnaires.Data.SectionA", "Section A", true, false, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1061), null, null, true, true, null, true, null, null, "Section A", 0, null, 20, true, true, 1, null },
                    { 2, null, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1029), "Demographics", "Demographics", "Demographics", "Questionnaires.Data.Demographics", "Demographics", true, false, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1051), null, null, true, null, null, null, null, null, "Demographics", 0, null, 10, true, true, 1, null },
                    { 1, null, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 567, DateTimeKind.Local).AddTicks(6751), "Teacher Feedback", "Teacher Feedback", "Teacher Feedback", "Questionnaires.Data.TeacherProfile", "Teacher Feedback", false, true, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 567, DateTimeKind.Local).AddTicks(6792), null, null, true, true, null, null, null, null, "Teacher Feedback", 0, null, 10, true, true, 1, null },
                    { 12, null, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1669), "Section D", "Section D", "Section D", "Questionnaires.Data.SectionD", "Section D", true, false, null, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 568, DateTimeKind.Local).AddTicks(1671), null, null, null, null, null, true, null, null, "Section D", 0, null, 50, true, true, 1, null }
                });

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "InputTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "English", "French", "ModifiedBy", "ModifiedDate", "YearId" },
                values: new object[,]
                {
                    { 14, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8537), "Hidden", "Hidden", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8560), 1 },
                    { 5, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8646), "DatePicker", "DatePicker", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8648), 1 },
                    { 2, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8659), "RadioMatrix", "RadioMatrix", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8661), 1 },
                    { 3, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8655), "RadioButtons", "RadioButtons", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8657), 1 },
                    { 4, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8650), "NumberBox", "NumberBox", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8652), 1 },
                    { 6, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8641), "CheckBox", "CheckBox", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8643), 1 },
                    { 7, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8637), "SelectBox", "SelectBox", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8639), 1 },
                    { 1, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8664), "TextArea", "TextArea", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8665), 1 },
                    { 9, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8628), "Header", "Header", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8630), 1 },
                    { 10, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8624), "QuestionHeader", "QuestionHeader", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8626), 1 },
                    { 11, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8619), "GroupHeader", "GroupHeader", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8621), 1 },
                    { 12, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8614), "Toggle", "Toggle", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8616), 1 },
                    { 13, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8608), "NumberBoxDouble", "NumberBoxDouble", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8611), 1 },
                    { 8, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8632), "TextBox", "TextBox", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 551, DateTimeKind.Local).AddTicks(8634), 1 }
                });

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSets",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LookupName", "ModifiedBy", "ModifiedDate", "YearId" },
                values: new object[,]
                {
                    { 22, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(236), "VerySomewhatNot", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(238), 1 },
                    { 27, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(259), "EFSL", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(261), 1 },
                    { 26, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(255), "StatusNS", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(257), 1 },
                    { 25, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(250), "ClassTypeNS", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(252), 1 },
                    { 24, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(245), "ClassAssignmentNS", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(247), 1 },
                    { 23, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(241), "GuideUsefulness", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(243), 1 },
                    { 1, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(22), "YesNo", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(53), 1 },
                    { 21, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(232), "TeacherGender", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(234), 1 },
                    { 19, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(223), "Participation", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(225), 1 },
                    { 2, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(59), "YesNoDontKnow", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(61), 1 },
                    { 3, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(64), "GoodAvgPoorDontKnow", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(66), 1 },
                    { 4, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(69), "OftenSometimesNeverDontKnow", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(71), 1 },
                    { 5, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(74), "ObservedDiagnosisBoth", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(76), 1 },
                    { 6, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(79), "FullPartDontknowNO", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(80), 1 },
                    { 7, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(83), "Status", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(85), 1 }
                });

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSets",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LookupName", "ModifiedBy", "ModifiedDate", "YearId" },
                values: new object[,]
                {
                    { 8, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(87), "ClassAssignment", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(89), 1 },
                    { 9, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(174), "ClassType", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(177), 1 },
                    { 20, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(227), "AgeRange", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(229), 1 },
                    { 10, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(180), "Gender", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(182), 1 },
                    { 12, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(191), "EthnicStatus", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(193), 1 },
                    { 13, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(195), "NWTLanguages", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(197), 1 },
                    { 15, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(204), "Languages", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(206), 1 },
                    { 16, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(208), "SpecialProblems", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(210), 1 },
                    { 17, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(213), "MainCare", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(215), 1 },
                    { 18, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(217), "MainCareJK", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(220), 1 },
                    { 11, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(185), "ConsideredESL", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(188), 1 },
                    { 14, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(199), "LandAgreements", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 557, DateTimeKind.Local).AddTicks(202), 1 }
                });

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "Orientations",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "English", "French", "ModifiedBy", "ModifiedDate", "YearId" },
                values: new object[,]
                {
                    { 1, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 558, DateTimeKind.Local).AddTicks(8239), "Vertical", "Vertical", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 558, DateTimeKind.Local).AddTicks(8242), 1 },
                    { 2, "admin", new DateTime(2021, 6, 11, 0, 14, 16, 558, DateTimeKind.Local).AddTicks(8201), "Horizontal", "Horizontal", "admin", new DateTime(2021, 6, 11, 0, 14, 16, 558, DateTimeKind.Local).AddTicks(8233), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Children_ChildStatusId",
                schema: "EDI",
                table: "Children",
                column: "ChildStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Children_GenderId",
                schema: "EDI",
                table: "Children",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Children_TeacherId",
                schema: "EDI",
                table: "Children",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Children_YearId",
                schema: "EDI",
                table: "Children",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordinators_YearId",
                schema: "EDI",
                table: "Coordinators",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_FAQ_YearId",
                schema: "EDI",
                table: "FAQ",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_FileImports_FileImportStatusId",
                schema: "Staging",
                table: "FileImports",
                column: "FileImportStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_FileImports_GenderId",
                schema: "Staging",
                table: "FileImports",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_InputTypes_YearId",
                schema: "LUData",
                table: "InputTypes",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_YearId",
                schema: "EDI",
                table: "Links",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_LookupSetOptions_LookupSetId",
                schema: "LUData",
                table: "LookupSetOptions",
                column: "LookupSetId");

            migrationBuilder.CreateIndex(
                name: "IX_LookupSets_YearId",
                schema: "LUData",
                table: "LookupSets",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsFeed_YearId",
                schema: "EDI",
                table: "NewsFeed",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Orientations_YearId",
                schema: "LUData",
                table: "Orientations",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_CountryID",
                schema: "LUData",
                table: "Provinces",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_ProvinceTypeId",
                schema: "LUData",
                table: "Provinces",
                column: "ProvinceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires_YearId",
                schema: "EDI",
                table: "Questionnaires",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Configuration_InputTypeId",
                schema: "EDI",
                table: "Questionnaires.Configuration",
                column: "InputTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Configuration_LookupEntityId",
                schema: "EDI",
                table: "Questionnaires.Configuration",
                column: "LookupEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Configuration_OrientationId",
                schema: "EDI",
                table: "Questionnaires.Configuration",
                column: "OrientationId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Configuration_QuestionnaireId",
                schema: "EDI",
                table: "Questionnaires.Configuration",
                column: "QuestionnaireId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Configuration_YearId",
                schema: "EDI",
                table: "Questionnaires.Configuration",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.Demographics_ChildId",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.Demographics_GenderId",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.Demographics_QuestionnaireId",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                column: "QuestionnaireId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.Demographics_YearId",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.SectionA_ChildId",
                schema: "EDI",
                table: "Questionnaires.Data.SectionA",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.SectionA_QuestionnaireId",
                schema: "EDI",
                table: "Questionnaires.Data.SectionA",
                column: "QuestionnaireId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.SectionA_YearId",
                schema: "EDI",
                table: "Questionnaires.Data.SectionA",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.SectionB_ChildId",
                schema: "EDI",
                table: "Questionnaires.Data.SectionB",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.SectionB_QuestionnaireId",
                schema: "EDI",
                table: "Questionnaires.Data.SectionB",
                column: "QuestionnaireId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.SectionB_YearId",
                schema: "EDI",
                table: "Questionnaires.Data.SectionB",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.SectionC_ChildId",
                schema: "EDI",
                table: "Questionnaires.Data.SectionC",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.SectionC_QuestionnaireId",
                schema: "EDI",
                table: "Questionnaires.Data.SectionC",
                column: "QuestionnaireId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.SectionC_YearId",
                schema: "EDI",
                table: "Questionnaires.Data.SectionC",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.SectionD_ChildId",
                schema: "EDI",
                table: "Questionnaires.Data.SectionD",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.SectionD_QuestionnaireId",
                schema: "EDI",
                table: "Questionnaires.Data.SectionD",
                column: "QuestionnaireId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.SectionD_YearId",
                schema: "EDI",
                table: "Questionnaires.Data.SectionD",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.SectionE_ChildId",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.SectionE_QuestionnaireId",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                column: "QuestionnaireId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.SectionE_YearId",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.TeacherProfile_QuestionnaireId",
                schema: "EDI",
                table: "Questionnaires.Data.TeacherProfile",
                column: "QuestionnaireId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.TeacherProfile_TeacherId",
                schema: "EDI",
                table: "Questionnaires.Data.TeacherProfile",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires.Data.TeacherProfile_YearId",
                schema: "EDI",
                table: "Questionnaires.Data.TeacherProfile",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_CountryId",
                schema: "EDI",
                table: "Schools",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_ProvinceId",
                schema: "EDI",
                table: "Schools",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_SiteId",
                schema: "EDI",
                table: "Schools",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_YearId",
                schema: "EDI",
                table: "Schools",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Sites_CoordinatorId",
                schema: "EDI",
                table: "Sites",
                column: "CoordinatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Sites_YearId",
                schema: "EDI",
                table: "Sites",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SchoolId",
                schema: "EDI",
                table: "Teachers",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_TeacherStatusId",
                schema: "EDI",
                table: "Teachers",
                column: "TeacherStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_YearId",
                schema: "EDI",
                table: "Teachers",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Years",
                schema: "LUData",
                table: "Years",
                column: "Ediyear",
                unique: true,
                filter: "[Ediyear] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DateDimension");

            migrationBuilder.DropTable(
                name: "FAQ",
                schema: "EDI");

            migrationBuilder.DropTable(
                name: "FileImports",
                schema: "Staging");

            migrationBuilder.DropTable(
                name: "FormConfigurations");

            migrationBuilder.DropTable(
                name: "Links",
                schema: "EDI");

            migrationBuilder.DropTable(
                name: "LookupSetOptions",
                schema: "LUData");

            migrationBuilder.DropTable(
                name: "MenuConfigurations");

            migrationBuilder.DropTable(
                name: "NewsFeed",
                schema: "EDI");

            migrationBuilder.DropTable(
                name: "Questionnaires.Configuration",
                schema: "EDI");

            migrationBuilder.DropTable(
                name: "Questionnaires.Data.Demographics",
                schema: "EDI");

            migrationBuilder.DropTable(
                name: "Questionnaires.Data.SectionA",
                schema: "EDI");

            migrationBuilder.DropTable(
                name: "Questionnaires.Data.SectionB",
                schema: "EDI");

            migrationBuilder.DropTable(
                name: "Questionnaires.Data.SectionC",
                schema: "EDI");

            migrationBuilder.DropTable(
                name: "Questionnaires.Data.SectionD",
                schema: "EDI");

            migrationBuilder.DropTable(
                name: "Questionnaires.Data.SectionE",
                schema: "EDI");

            migrationBuilder.DropTable(
                name: "Questionnaires.Data.TeacherProfile",
                schema: "EDI");

            migrationBuilder.DropTable(
                name: "SystemConfigurations",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Translations",
                schema: "LUData");

            migrationBuilder.DropTable(
                name: "UserSessions",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "FileImportStatus",
                schema: "LUData");

            migrationBuilder.DropTable(
                name: "InputTypes",
                schema: "LUData");

            migrationBuilder.DropTable(
                name: "LookupSets",
                schema: "LUData");

            migrationBuilder.DropTable(
                name: "Orientations",
                schema: "LUData");

            migrationBuilder.DropTable(
                name: "Children",
                schema: "EDI");

            migrationBuilder.DropTable(
                name: "Questionnaires",
                schema: "EDI");

            migrationBuilder.DropTable(
                name: "ChildStatus",
                schema: "LUData");

            migrationBuilder.DropTable(
                name: "Genders",
                schema: "LUData");

            migrationBuilder.DropTable(
                name: "Teachers",
                schema: "EDI");

            migrationBuilder.DropTable(
                name: "Schools",
                schema: "EDI");

            migrationBuilder.DropTable(
                name: "TeacherStatus",
                schema: "LUData");

            migrationBuilder.DropTable(
                name: "Provinces",
                schema: "LUData");

            migrationBuilder.DropTable(
                name: "Sites",
                schema: "EDI");

            migrationBuilder.DropTable(
                name: "Countries",
                schema: "LUData");

            migrationBuilder.DropTable(
                name: "ProvinceType",
                schema: "LUData");

            migrationBuilder.DropTable(
                name: "Coordinators",
                schema: "EDI");

            migrationBuilder.DropTable(
                name: "Years",
                schema: "LUData");
        }
    }
}
