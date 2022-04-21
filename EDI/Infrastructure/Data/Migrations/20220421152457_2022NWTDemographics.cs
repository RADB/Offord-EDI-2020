using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2022NWTDemographics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OtherLanguage",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "int",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 954, DateTimeKind.Local).AddTicks(9490), new DateTime(2022, 4, 21, 11, 24, 55, 954, DateTimeKind.Local).AddTicks(9491) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 954, DateTimeKind.Local).AddTicks(9448), new DateTime(2022, 4, 21, 11, 24, 55, 954, DateTimeKind.Local).AddTicks(9487) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 954, DateTimeKind.Local).AddTicks(9494), new DateTime(2022, 4, 21, 11, 24, 55, 954, DateTimeKind.Local).AddTicks(9499) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 954, DateTimeKind.Local).AddTicks(9506), new DateTime(2022, 4, 21, 11, 24, 55, 954, DateTimeKind.Local).AddTicks(9508) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 955, DateTimeKind.Local).AddTicks(6355), new DateTime(2022, 4, 21, 11, 24, 55, 955, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 955, DateTimeKind.Local).AddTicks(6375), new DateTime(2022, 4, 21, 11, 24, 55, 955, DateTimeKind.Local).AddTicks(6377) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 955, DateTimeKind.Local).AddTicks(6379), new DateTime(2022, 4, 21, 11, 24, 55, 955, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 955, DateTimeKind.Local).AddTicks(6382), new DateTime(2022, 4, 21, 11, 24, 55, 955, DateTimeKind.Local).AddTicks(6405) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 955, DateTimeKind.Local).AddTicks(6407), new DateTime(2022, 4, 21, 11, 24, 55, 955, DateTimeKind.Local).AddTicks(6408) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 955, DateTimeKind.Local).AddTicks(9903), new DateTime(2022, 4, 21, 11, 24, 55, 955, DateTimeKind.Local).AddTicks(9913) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 955, DateTimeKind.Local).AddTicks(9915), new DateTime(2022, 4, 21, 11, 24, 55, 955, DateTimeKind.Local).AddTicks(9916) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1884), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1886) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1881), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1882) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1878), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1879) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1875), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1872), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1869), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1865), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1867) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1862), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1864) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1859), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1856), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1857) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1817), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1828) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1814), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1815) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1811), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1812) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1798), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(1808) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7133), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7142), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7146), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7149), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7152), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7153) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7155), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7158), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7161), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7165), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7166) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7168), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7171), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7172) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7175), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7178), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7180) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7181), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7183) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7185), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7186) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7188), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7191), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7194), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7197), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7199) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7201), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7202) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7204), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7207), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7211), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7214), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7217), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7220), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7224), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7225) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7227), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7228) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7231), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7232) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7234), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7237), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7238) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7240), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7243), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7245) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7247), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7251), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7252) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7254), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7257), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7260), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7261) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7263), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7265) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7267), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7268) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7270), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7273), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7274) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7276), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7277) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7279), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7281) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7282), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7286), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7287) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7289), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7292), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7293) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7295), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7297) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7298), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7301), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7305), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7308), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6461), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6474), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6477), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6479) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6481), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6482) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6484), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6485) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6487), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6488) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6490), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6492) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6493), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6496), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6498) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6500), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6503), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6505) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6506), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6510), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6511) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6513), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6515) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6517), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6518) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6520), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6522) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6523), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6527), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6531), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6534), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6537), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6538) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6540), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6543), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6545) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6547), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6550), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6553), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6556), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6559), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6563), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6571), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6572) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6574), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6576) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6578), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6579) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6581), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6582) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6585), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6586) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6588), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6589) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6591), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6592) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6594), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6596) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6597), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6599) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6601), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6602) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6604), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6608), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(9017), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(9004), new DateTime(2022, 4, 21, 11, 24, 55, 956, DateTimeKind.Local).AddTicks(9014) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1917), new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1926) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1938), new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1943), new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1944) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1948), new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1949) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1957), new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1959) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1962), new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1967), new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1973), new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1974) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1977), new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1979) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1982), new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1983) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1986), new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1991), new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1995), new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(1996) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(2003), new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(2004) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(2008), new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(2013), new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(2017), new DateTime(2022, 4, 21, 11, 24, 55, 958, DateTimeKind.Local).AddTicks(2019) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 960, DateTimeKind.Local).AddTicks(7148), new DateTime(2022, 4, 21, 11, 24, 55, 960, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 960, DateTimeKind.Local).AddTicks(7134), new DateTime(2022, 4, 21, 11, 24, 55, 960, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 960, DateTimeKind.Local).AddTicks(7152), new DateTime(2022, 4, 21, 11, 24, 55, 960, DateTimeKind.Local).AddTicks(7153) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 960, DateTimeKind.Local).AddTicks(7155), new DateTime(2022, 4, 21, 11, 24, 55, 960, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 962, DateTimeKind.Local).AddTicks(6542), new DateTime(2022, 4, 21, 11, 24, 55, 962, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 4, 21, 11, 24, 55, 962, DateTimeKind.Local).AddTicks(6559), new DateTime(2022, 4, 21, 11, 24, 55, 962, DateTimeKind.Local).AddTicks(6561) });
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

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 276, DateTimeKind.Local).AddTicks(3909), new DateTime(2022, 2, 18, 1, 3, 6, 276, DateTimeKind.Local).AddTicks(3911) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 276, DateTimeKind.Local).AddTicks(3881), new DateTime(2022, 2, 18, 1, 3, 6, 276, DateTimeKind.Local).AddTicks(3906) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 276, DateTimeKind.Local).AddTicks(3913), new DateTime(2022, 2, 18, 1, 3, 6, 276, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 276, DateTimeKind.Local).AddTicks(3916), new DateTime(2022, 2, 18, 1, 3, 6, 276, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 276, DateTimeKind.Local).AddTicks(9498), new DateTime(2022, 2, 18, 1, 3, 6, 276, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 276, DateTimeKind.Local).AddTicks(9510), new DateTime(2022, 2, 18, 1, 3, 6, 276, DateTimeKind.Local).AddTicks(9511) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 276, DateTimeKind.Local).AddTicks(9513), new DateTime(2022, 2, 18, 1, 3, 6, 276, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 276, DateTimeKind.Local).AddTicks(9516), new DateTime(2022, 2, 18, 1, 3, 6, 276, DateTimeKind.Local).AddTicks(9517) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 276, DateTimeKind.Local).AddTicks(9519), new DateTime(2022, 2, 18, 1, 3, 6, 276, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(2561), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(2569) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(2572), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4315), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4316) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4312), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4313) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4309), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4306), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4303), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4300), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4298), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4295), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4292), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4293) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4289), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4286), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4287) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4283), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4280), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4281) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4270), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9129), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9135), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9136) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9138), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9139) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9141), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9182), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9184) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9186), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9187) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9188), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9191), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9193) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9194), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9197), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9200), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9201) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9203), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9206), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9209), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9212), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9214), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9216) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9218), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9219) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9221), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9224), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9225) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9227), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9228) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9230), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9233), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9234) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9236), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9238), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9241), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9243) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9244), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9247), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9251), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9253), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9256), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9257) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9259), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9262), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9263) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9265), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9268), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9269) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9271), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9272) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9274), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9277), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9278) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9279), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9283), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9284) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9286), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9287) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9289), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9292), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9295), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9296) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9298), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9299) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9301), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9302) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9304), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9305) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9307), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9309), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9312), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9313) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9315), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9318), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9319) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9321), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9322) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9324), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(9325) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8576), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8587), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8590), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8591) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8593), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8594) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8596), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8598), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8601), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8604), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8605) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8607), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8609) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8611), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8612) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8614), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8616), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8618) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8619), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8621) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8622), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8625), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8628), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8631), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8632) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8634), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8635) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8637), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8642), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8644) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8645), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8646) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8648), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8649) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8651), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8654), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8656) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8657), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8658) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8660), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8661) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8663), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8664) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8666), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8669), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8672), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8675), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8676) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8677), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8712), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8716), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8719), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8722), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8724), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8727), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8728) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8734), new DateTime(2022, 2, 18, 1, 3, 6, 277, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 278, DateTimeKind.Local).AddTicks(887), new DateTime(2022, 2, 18, 1, 3, 6, 278, DateTimeKind.Local).AddTicks(888) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 278, DateTimeKind.Local).AddTicks(877), new DateTime(2022, 2, 18, 1, 3, 6, 278, DateTimeKind.Local).AddTicks(885) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2089), new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2097) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2104), new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2105) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2109), new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2113), new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2115) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2118), new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2123), new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2124) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2127), new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2128) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2131), new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2133) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2136), new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2140), new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2141) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2199), new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2204), new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2209), new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2213), new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2217), new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2218) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2222), new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2223) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2226), new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2230), new DateTime(2022, 2, 18, 1, 3, 6, 279, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 281, DateTimeKind.Local).AddTicks(1660), new DateTime(2022, 2, 18, 1, 3, 6, 281, DateTimeKind.Local).AddTicks(1662) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 281, DateTimeKind.Local).AddTicks(1649), new DateTime(2022, 2, 18, 1, 3, 6, 281, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 281, DateTimeKind.Local).AddTicks(1663), new DateTime(2022, 2, 18, 1, 3, 6, 281, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 281, DateTimeKind.Local).AddTicks(1667), new DateTime(2022, 2, 18, 1, 3, 6, 281, DateTimeKind.Local).AddTicks(1668) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 282, DateTimeKind.Local).AddTicks(9350), new DateTime(2022, 2, 18, 1, 3, 6, 282, DateTimeKind.Local).AddTicks(9359) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 18, 1, 3, 6, 282, DateTimeKind.Local).AddTicks(9365), new DateTime(2022, 2, 18, 1, 3, 6, 282, DateTimeKind.Local).AddTicks(9367) });
        }
    }
}
