using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2022NWT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CentreBasedCare",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 196, DateTimeKind.Local).AddTicks(9543), new DateTime(2022, 1, 11, 14, 57, 52, 196, DateTimeKind.Local).AddTicks(9546) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 196, DateTimeKind.Local).AddTicks(9479), new DateTime(2022, 1, 11, 14, 57, 52, 196, DateTimeKind.Local).AddTicks(9538) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 196, DateTimeKind.Local).AddTicks(9549), new DateTime(2022, 1, 11, 14, 57, 52, 196, DateTimeKind.Local).AddTicks(9552) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 196, DateTimeKind.Local).AddTicks(9563), new DateTime(2022, 1, 11, 14, 57, 52, 196, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 197, DateTimeKind.Local).AddTicks(9585), new DateTime(2022, 1, 11, 14, 57, 52, 197, DateTimeKind.Local).AddTicks(9602) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 197, DateTimeKind.Local).AddTicks(9614), new DateTime(2022, 1, 11, 14, 57, 52, 197, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 197, DateTimeKind.Local).AddTicks(9620), new DateTime(2022, 1, 11, 14, 57, 52, 197, DateTimeKind.Local).AddTicks(9623) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 197, DateTimeKind.Local).AddTicks(9626), new DateTime(2022, 1, 11, 14, 57, 52, 197, DateTimeKind.Local).AddTicks(9667) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 197, DateTimeKind.Local).AddTicks(9670), new DateTime(2022, 1, 11, 14, 57, 52, 197, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(5007), new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(5039), new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(5041) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8283), new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8278), new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8273), new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8275) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8268), new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8263), new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8265) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8258), new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8253), new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8255) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8248), new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8243), new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8245) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8238), new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8172), new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8182) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8166), new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8168) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8144), new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8162) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8129), new DateTime(2022, 1, 11, 14, 57, 52, 198, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7133), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7142) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7146), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7151), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7153) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7156), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7162), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7167), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7172), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7175) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7178), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7180) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7183), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7185) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7188), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7194), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7199), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7205), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7212), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7217), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7222), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7224) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7227), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7233), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7238), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7241) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7243), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7267), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7272), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7274) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7278), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7283), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7288), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7307), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7312), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7315) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7318), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7323), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7326) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7329), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7331) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7335), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7337) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7341), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7347), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7349) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7352), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7358), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7366), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7372), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7376), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7378) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7381), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7386), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7392), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7398), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7399) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7403), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7409), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7413), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7418), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7423), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7441), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7443) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7446), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7448) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7451), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7453) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7456), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7458) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7461), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7467), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5910), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5928), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5933), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5939), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5945), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5948) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5950), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5953) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5956), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5961), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5967), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5973), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5989) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5992), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(5998), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6004), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6010), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6012) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6015), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6034), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6036) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6039), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6041) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6044), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6050), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6053) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6056), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6062), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6067), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6072), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6077), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6083), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6085) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6088), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6094), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6096) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6099), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6101) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6104), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6106) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6170), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6173) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6178), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6180) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6183), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6185) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6189), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6191) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6194), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6197) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6216), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6219) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6222), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6227), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6229) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6232), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6234) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6237), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6243), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6249), new DateTime(2022, 1, 11, 14, 57, 52, 199, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 200, DateTimeKind.Local).AddTicks(163), new DateTime(2022, 1, 11, 14, 57, 52, 200, DateTimeKind.Local).AddTicks(166) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 200, DateTimeKind.Local).AddTicks(148), new DateTime(2022, 1, 11, 14, 57, 52, 200, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9127), new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9164), new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9166) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9172), new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9179), new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9185), new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9188) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9193), new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9201), new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9203) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9223), new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9225) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9230), new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9277), new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9286), new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9293), new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9300), new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9302) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9307), new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9313), new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9320), new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9323) });

            migrationBuilder.InsertData(
                schema: "EDI",
                table: "Questionnaires",
                columns: new[] { "Id", "Alberta", "BritishColumbia", "CreatedBy", "CreatedDate", "DescriptionEnglish", "DescriptionFrench", "English", "EntityName", "French", "IsChildQuestionnaire", "IsTeacherQuestionnaire", "Manitoba", "ModifiedBy", "ModifiedDate", "NewBrunswick", "NewYork", "NewfoundlandandLabrador", "NorthwestTerritories", "NovaScotia", "Nunavut", "Ontario", "PrinceEdwardIsland", "Quebec", "QuestionnaireName", "QuestionsRequired", "Saskatchewan", "Sequence", "ShowProgressBar", "ShowQuestionNumbers", "YearId", "YukonTerritory" },
                values: new object[,]
                {
                    { 31, null, null, "admin", new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9327), "Demographics", "Demographics", "Demographics", "Questionnaires.Data.Demographics", "Demographics", true, false, null, "admin", new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9329), null, null, null, null, null, null, null, true, null, "Demographics", 0, null, 10, true, true, 2, null },
                    { 32, null, null, "admin", new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9334), "Section E", "Section E", "Section E", "Questionnaires.Data.SectionE", "Section E", true, false, null, "admin", new DateTime(2022, 1, 11, 14, 57, 52, 201, DateTimeKind.Local).AddTicks(9337), null, null, null, null, null, null, null, true, null, "Section E", 0, null, 60, true, true, 2, null }
                });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 205, DateTimeKind.Local).AddTicks(6421), new DateTime(2022, 1, 11, 14, 57, 52, 205, DateTimeKind.Local).AddTicks(6423) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 205, DateTimeKind.Local).AddTicks(6359), new DateTime(2022, 1, 11, 14, 57, 52, 205, DateTimeKind.Local).AddTicks(6415) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 205, DateTimeKind.Local).AddTicks(6441), new DateTime(2022, 1, 11, 14, 57, 52, 205, DateTimeKind.Local).AddTicks(6444) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 205, DateTimeKind.Local).AddTicks(6447), new DateTime(2022, 1, 11, 14, 57, 52, 205, DateTimeKind.Local).AddTicks(6449) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 208, DateTimeKind.Local).AddTicks(5263), new DateTime(2022, 1, 11, 14, 57, 52, 208, DateTimeKind.Local).AddTicks(5293) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 57, 52, 208, DateTimeKind.Local).AddTicks(5304), new DateTime(2022, 1, 11, 14, 57, 52, 208, DateTimeKind.Local).AddTicks(5307) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DropColumn(
                name: "CentreBasedCare",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 925, DateTimeKind.Local).AddTicks(911), new DateTime(2021, 12, 13, 23, 36, 20, 925, DateTimeKind.Local).AddTicks(912) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 925, DateTimeKind.Local).AddTicks(880), new DateTime(2021, 12, 13, 23, 36, 20, 925, DateTimeKind.Local).AddTicks(908) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 925, DateTimeKind.Local).AddTicks(914), new DateTime(2021, 12, 13, 23, 36, 20, 925, DateTimeKind.Local).AddTicks(915) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 925, DateTimeKind.Local).AddTicks(917), new DateTime(2021, 12, 13, 23, 36, 20, 925, DateTimeKind.Local).AddTicks(918) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 925, DateTimeKind.Local).AddTicks(7048), new DateTime(2021, 12, 13, 23, 36, 20, 925, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 925, DateTimeKind.Local).AddTicks(7059), new DateTime(2021, 12, 13, 23, 36, 20, 925, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 925, DateTimeKind.Local).AddTicks(7062), new DateTime(2021, 12, 13, 23, 36, 20, 925, DateTimeKind.Local).AddTicks(7063) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 925, DateTimeKind.Local).AddTicks(7065), new DateTime(2021, 12, 13, 23, 36, 20, 925, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 925, DateTimeKind.Local).AddTicks(7068), new DateTime(2021, 12, 13, 23, 36, 20, 925, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(232), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(240) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(242), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(244) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(2003), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(2004) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(2000), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1997), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1998) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1994), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1995) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1991), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1988), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1989) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1985), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1987) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1983), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1984) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1980), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1977), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1978) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1974), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1971), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1968), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1969) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1958), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(1966) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7240), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7256), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7257) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7260), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7266), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7268) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7270), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7272) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7275), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7277) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7279), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7281) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7283), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7288), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7292), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7296), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7300), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7306), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7311), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7313) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7315), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7320), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7325), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7327) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7329), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7331) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7333), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7335) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7338), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7352), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7357), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7361), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7363) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7365), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7367) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7373), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7375) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7377), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7381), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7386), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7390), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7392) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7394), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7399), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7403), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7409), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7413), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7416), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7418) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7421), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7422) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7425), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7427) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7429), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7431) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7433), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7434) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7436), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7438) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7440), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7444), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7448), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7452), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7453) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7455), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7459), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7461) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7463), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7467), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7471), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7474), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7478), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7482), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7484) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7486), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7487) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6247), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6258), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6261), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6264), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6268), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6270), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6273), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6275) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6276), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6285), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6286) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6288), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6289) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6290), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6292) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6293), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6294) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6296), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6299), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6302), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6305), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6306) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6307), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6309) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6310), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6313), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6314) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6316), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6320), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6321) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6323), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6324) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6325), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6328), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6329) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6331), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6332) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6334), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6337), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6340), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6341) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6343), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6344) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6345), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6347) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6348), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6351), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6354), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6355) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6357), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6358) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6360), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6361) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6363), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6365) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6366), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6367) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6369), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6372), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6373) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6375), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6376) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6378), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6379) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(9951), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(9952) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(9940), new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1553), new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1569), new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1570) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1579), new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1584), new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1588), new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1589) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1593), new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1597), new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1598) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1601), new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1605), new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1610), new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1611) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1614), new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1618), new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1627), new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1632), new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1633) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1636), new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1637) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1640), new DateTime(2021, 12, 13, 23, 36, 20, 928, DateTimeKind.Local).AddTicks(1641) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 930, DateTimeKind.Local).AddTicks(2031), new DateTime(2021, 12, 13, 23, 36, 20, 930, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 930, DateTimeKind.Local).AddTicks(2020), new DateTime(2021, 12, 13, 23, 36, 20, 930, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 930, DateTimeKind.Local).AddTicks(2034), new DateTime(2021, 12, 13, 23, 36, 20, 930, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 930, DateTimeKind.Local).AddTicks(2037), new DateTime(2021, 12, 13, 23, 36, 20, 930, DateTimeKind.Local).AddTicks(2039) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 931, DateTimeKind.Local).AddTicks(9343), new DateTime(2021, 12, 13, 23, 36, 20, 931, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 13, 23, 36, 20, 931, DateTimeKind.Local).AddTicks(9363), new DateTime(2021, 12, 13, 23, 36, 20, 931, DateTimeKind.Local).AddTicks(9364) });
        }
    }
}
