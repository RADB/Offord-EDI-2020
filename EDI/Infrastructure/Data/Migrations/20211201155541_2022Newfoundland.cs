using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2022Newfoundland : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 151, DateTimeKind.Local).AddTicks(3373), new DateTime(2021, 12, 1, 10, 55, 40, 151, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 151, DateTimeKind.Local).AddTicks(3333), new DateTime(2021, 12, 1, 10, 55, 40, 151, DateTimeKind.Local).AddTicks(3369) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 151, DateTimeKind.Local).AddTicks(3377), new DateTime(2021, 12, 1, 10, 55, 40, 151, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 151, DateTimeKind.Local).AddTicks(3386), new DateTime(2021, 12, 1, 10, 55, 40, 151, DateTimeKind.Local).AddTicks(3387) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(1614), new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(1628) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(1636), new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(1637) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(1639), new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(1641) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(1642), new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(1672), new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(1674) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(6661), new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(6676) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(6680), new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(6681) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9232), new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9233) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9229), new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9230) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9226), new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9227) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9223), new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9220), new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9221) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9217), new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9218) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9213), new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9210), new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9212) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9207), new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9209) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9204), new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9205) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9162), new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9148), new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9145), new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9133), new DateTime(2021, 12, 1, 10, 55, 40, 152, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5874), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5884), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5887), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5890), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5892) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5893), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5897), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5900), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5903), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5916), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5920), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5923), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5926), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5929), "Some coursework towards a Bachelor's degree", new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5931) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5933), "Teaching certificate, diploma, or license", new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5934) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5937), "Bachelor's degree", new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5940), "Bachelor of Education degree", new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5943), "Some post-baccalaureate coursework", new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5944) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5956), "Post-baccalaureate diploma or certificate", new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5960), "Some coursework towards a Master's degree", new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5961) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5963), "Master's degree", new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5966), "Some coursework towards a Doctorate", new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5969), "Doctorate", new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5972), "Other", new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5976), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5977) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5979), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5983), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5986), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5987) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5989), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5992), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5995), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5997) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5998), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(6002), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(6005), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(6008), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(6011), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(6015), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(6018), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(6019) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5075), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5088), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5092), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5095), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5098), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5099) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5101), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5104), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5107), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5110), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5111) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5113), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5116), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5119), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5121) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5122), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5125), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5127) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5129), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5132), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5135), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5138), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5142), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5143) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5145), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5146) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5148), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5149) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5151), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5154), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5165) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5167), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5170), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5173), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5176), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5179), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5183), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5186), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5189), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5206), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5209), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5212), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5215), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5217) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5218), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5221), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5225), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(5226) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(8152), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(8154) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(8130), new DateTime(2021, 12, 1, 10, 55, 40, 153, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3471), new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3481) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3494), new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3496) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3500), new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3501) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3506), new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3508) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3511), new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3512) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3516), new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3517) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3521), new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3522) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3525), new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3526) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3530), new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3534), new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3539), new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3546), new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3548) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3551), new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3552) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3555), new DateTime(2021, 12, 1, 10, 55, 40, 155, DateTimeKind.Local).AddTicks(3557) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 158, DateTimeKind.Local).AddTicks(3066), new DateTime(2021, 12, 1, 10, 55, 40, 158, DateTimeKind.Local).AddTicks(3067) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 158, DateTimeKind.Local).AddTicks(3033), new DateTime(2021, 12, 1, 10, 55, 40, 158, DateTimeKind.Local).AddTicks(3062) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 158, DateTimeKind.Local).AddTicks(3070), new DateTime(2021, 12, 1, 10, 55, 40, 158, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 158, DateTimeKind.Local).AddTicks(3073), new DateTime(2021, 12, 1, 10, 55, 40, 158, DateTimeKind.Local).AddTicks(3074) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 160, DateTimeKind.Local).AddTicks(6603), new DateTime(2021, 12, 1, 10, 55, 40, 160, DateTimeKind.Local).AddTicks(6615) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 55, 40, 160, DateTimeKind.Local).AddTicks(6639), new DateTime(2021, 12, 1, 10, 55, 40, 160, DateTimeKind.Local).AddTicks(6640) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 680, DateTimeKind.Local).AddTicks(7414), new DateTime(2021, 11, 23, 12, 48, 27, 680, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 680, DateTimeKind.Local).AddTicks(7381), new DateTime(2021, 11, 23, 12, 48, 27, 680, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 680, DateTimeKind.Local).AddTicks(7417), new DateTime(2021, 11, 23, 12, 48, 27, 680, DateTimeKind.Local).AddTicks(7419) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 680, DateTimeKind.Local).AddTicks(7420), new DateTime(2021, 11, 23, 12, 48, 27, 680, DateTimeKind.Local).AddTicks(7422) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(3584), new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(3596), new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(3597) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(3599), new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(3602), new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(3605), new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(6798), new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(6810), new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8626), new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8627) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8623), new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8620), new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8621) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8617), new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8618) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8614), new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8611), new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8612) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8608), new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8605), new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8607) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8603), new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8600), new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8597), new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8594), new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8595) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8591), new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8579), new DateTime(2021, 11, 23, 12, 48, 27, 681, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3469), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3474) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3476), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3477) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3479), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3481) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3482), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3484) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3485), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3489), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3490) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3492), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3493) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3495), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3496) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3498), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3499) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3502), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3505), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3508), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3509) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3511), "Some coursework towards a Bachelor's degree?", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3513) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3514), "A teaching certificate, diploma, or license?", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3516) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3517), "A Bachelor's degree?", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3518) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3520), "A Bachelor of Education degree?", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3521) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3524), "Some post-baccalaureate coursework?", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3526) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3527), "A post-baccalaureate diploma or certificate?", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3529) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3530), "Some coursework towards a Master's degree?", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3534), "A Master's degree?", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3537), "Some coursework towards a Doctorate?", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3541), "A Doctorate?", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CreatedDate", "English", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3544), "Other?", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3545) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3547), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3548) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3549), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3551) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3553), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3554) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3557), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3561), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3562) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3564), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3565) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3567), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3568) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3569), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3571) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3572), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3574) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3575), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3578), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3579) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3586), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3587) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3589), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3592), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2891), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2899) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2902), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2903) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2905), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2908), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2909) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2911), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2914), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2915) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2917), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2918) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2920), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2923), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2926), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2928), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2937), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2938) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2940), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2941) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2943), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2944) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2946), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2947) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2949), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2952), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2955), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2957) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2958), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2961), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2964), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2965) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2967), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2968) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2970), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2972), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2975), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2978), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2981), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2984), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2985) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2987), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2990), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2993), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2996), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2997) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(2999), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3002), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3005), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3008), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3009) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3011), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3014), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(5211), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(5201), new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6715), new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6730), new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6735), new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6740), new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6741) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6745), new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6754), new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6758), new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6762), new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6767), new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6771), new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6775), new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6779), new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6783), new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6787), new DateTime(2021, 11, 23, 12, 48, 27, 683, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 686, DateTimeKind.Local).AddTicks(132), new DateTime(2021, 11, 23, 12, 48, 27, 686, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 686, DateTimeKind.Local).AddTicks(120), new DateTime(2021, 11, 23, 12, 48, 27, 686, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 686, DateTimeKind.Local).AddTicks(135), new DateTime(2021, 11, 23, 12, 48, 27, 686, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 686, DateTimeKind.Local).AddTicks(138), new DateTime(2021, 11, 23, 12, 48, 27, 686, DateTimeKind.Local).AddTicks(139) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 687, DateTimeKind.Local).AddTicks(7898), new DateTime(2021, 11, 23, 12, 48, 27, 687, DateTimeKind.Local).AddTicks(7907) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 23, 12, 48, 27, 687, DateTimeKind.Local).AddTicks(7913), new DateTime(2021, 11, 23, 12, 48, 27, 687, DateTimeKind.Local).AddTicks(7915) });
        }
    }
}
