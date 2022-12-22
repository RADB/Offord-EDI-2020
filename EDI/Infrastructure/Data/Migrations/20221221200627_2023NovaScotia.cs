using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2023NovaScotia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "AttendedNature",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "AboriginalStatus",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Immigrated",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "LanguageImmersion",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "tinyint",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 176, DateTimeKind.Local).AddTicks(1837), new DateTime(2022, 12, 21, 15, 6, 26, 176, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 176, DateTimeKind.Local).AddTicks(1799), new DateTime(2022, 12, 21, 15, 6, 26, 176, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 176, DateTimeKind.Local).AddTicks(1841), new DateTime(2022, 12, 21, 15, 6, 26, 176, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 176, DateTimeKind.Local).AddTicks(1851), new DateTime(2022, 12, 21, 15, 6, 26, 176, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 176, DateTimeKind.Local).AddTicks(8244), new DateTime(2022, 12, 21, 15, 6, 26, 176, DateTimeKind.Local).AddTicks(8255) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 176, DateTimeKind.Local).AddTicks(8262), new DateTime(2022, 12, 21, 15, 6, 26, 176, DateTimeKind.Local).AddTicks(8264) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 176, DateTimeKind.Local).AddTicks(8311), new DateTime(2022, 12, 21, 15, 6, 26, 176, DateTimeKind.Local).AddTicks(8312) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 176, DateTimeKind.Local).AddTicks(8314), new DateTime(2022, 12, 21, 15, 6, 26, 176, DateTimeKind.Local).AddTicks(8331) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 176, DateTimeKind.Local).AddTicks(8333), new DateTime(2022, 12, 21, 15, 6, 26, 176, DateTimeKind.Local).AddTicks(8335) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(2167), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(2182), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(2183) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4300), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4297), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4298) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4294), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4295) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4291), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4292) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4288), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4284), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4280), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4277), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4273), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4270), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4272) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4230), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4227), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4228) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4224), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4225) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4212), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(195), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(202) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(204), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(205) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(207), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(209) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(210), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(212) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(214), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(217), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(218) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(220), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(223), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(225) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(228), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(229) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(231), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(232) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(234), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(235) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(237), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(240), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(242) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(244), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(245) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(247), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(248) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(250), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(251) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(253), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(255) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(256), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(258) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(260), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(261) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(263), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(264) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(266), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(270), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(273), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(276), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(318), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(322), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(327), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(328) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(331), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(333) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(334), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(338), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(339) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(341), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(343) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(344), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(346) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(347), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(351), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(352) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(354), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(357), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(358) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(361), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(364), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(365) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(367), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(370), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(373), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(375) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(377), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(380), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(381) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(383), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(384) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(386), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(387) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(389), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(392), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(396), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(399), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(401) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(403), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(406), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(409), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(412), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(415), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(418), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(422), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(425), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(426) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(428), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(432), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9520), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9530) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9532), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9534) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9536), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9537) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9539), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9540) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9542), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9544) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9545), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9547) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9549), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9552), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9556), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9557) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9559), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9560) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9562), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9606), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9610), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9611) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9613), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9616), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9617) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9619), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9620) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9622), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9625), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9627) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9629), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9632), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9633) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9635), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9638), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9641), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9645), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9646) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9648), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9649) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9652), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9653) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9655), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9656) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9658), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9661), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9662) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9664), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9668), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9671), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9674), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9675) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9677), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9678) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9680), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9682) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9683), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9687), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9690), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9693), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9696), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9699), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9702), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9704) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9706), new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSets",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LookupName", "ModifiedBy", "ModifiedDate", "YearId" },
                values: new object[,]
                {
                    { 121, "admin", new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9709), "NFLDLanguageStatus", "admin", new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9710), 3 },
                    { 122, "admin", new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9712), "LanguageImmersion", "admin", new DateTime(2022, 12, 21, 15, 6, 26, 177, DateTimeKind.Local).AddTicks(9713), 3 }
                });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(2425), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(2413), new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5848), new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5858) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5867), new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5869) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5873), new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5878), new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5883), new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5888), new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5893), new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5897), new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5901), new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5907), new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5945), new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5947) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5950), new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5952) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5955), new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5956) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5960), new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5961) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5964), new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5965) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5969), new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5973), new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5978), new DateTime(2022, 12, 21, 15, 6, 26, 179, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 182, DateTimeKind.Local).AddTicks(5190), new DateTime(2022, 12, 21, 15, 6, 26, 182, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 182, DateTimeKind.Local).AddTicks(5166), new DateTime(2022, 12, 21, 15, 6, 26, 182, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 182, DateTimeKind.Local).AddTicks(5193), new DateTime(2022, 12, 21, 15, 6, 26, 182, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 182, DateTimeKind.Local).AddTicks(5197), new DateTime(2022, 12, 21, 15, 6, 26, 182, DateTimeKind.Local).AddTicks(5198) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 184, DateTimeKind.Local).AddTicks(9560), new DateTime(2022, 12, 21, 15, 6, 26, 184, DateTimeKind.Local).AddTicks(9588) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 6, 26, 184, DateTimeKind.Local).AddTicks(9597), new DateTime(2022, 12, 21, 15, 6, 26, 184, DateTimeKind.Local).AddTicks(9599) });

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSetOptions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "English", "French", "LookupSetId", "ModifiedBy", "ModifiedDate", "Sequence", "Value", "YearId" },
                values: new object[,]
                {
                    { 971, "admin", new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(435), "ESL", "ESL", 121, "admin", new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(436), (short)10, (short)1, 3 },
                    { 972, "admin", new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(438), "FSL", "FSL", 121, "admin", new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(439), (short)20, (short)2, 3 },
                    { 973, "admin", new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(441), "No", "Non", 121, "admin", new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(443), (short)30, (short)3, 3 },
                    { 974, "admin", new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(444), "French Immersion", "French Immersion", 122, "admin", new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(446), (short)10, (short)1, 3 },
                    { 975, "admin", new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(448), "Other Immersion", "Other Immersion", 122, "admin", new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(449), (short)20, (short)2, 3 },
                    { 976, "admin", new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(451), "No", "Non", 122, "admin", new DateTime(2022, 12, 21, 15, 6, 26, 178, DateTimeKind.Local).AddTicks(452), (short)30, (short)3, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DropColumn(
                name: "AttendedNature",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "AboriginalStatus",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "Immigrated",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "LanguageImmersion",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 201, DateTimeKind.Local).AddTicks(937), new DateTime(2022, 12, 19, 23, 23, 17, 201, DateTimeKind.Local).AddTicks(938) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 201, DateTimeKind.Local).AddTicks(895), new DateTime(2022, 12, 19, 23, 23, 17, 201, DateTimeKind.Local).AddTicks(933) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 201, DateTimeKind.Local).AddTicks(940), new DateTime(2022, 12, 19, 23, 23, 17, 201, DateTimeKind.Local).AddTicks(942) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 201, DateTimeKind.Local).AddTicks(949), new DateTime(2022, 12, 19, 23, 23, 17, 201, DateTimeKind.Local).AddTicks(950) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 201, DateTimeKind.Local).AddTicks(7301), new DateTime(2022, 12, 19, 23, 23, 17, 201, DateTimeKind.Local).AddTicks(7312) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 201, DateTimeKind.Local).AddTicks(7320), new DateTime(2022, 12, 19, 23, 23, 17, 201, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 201, DateTimeKind.Local).AddTicks(7324), new DateTime(2022, 12, 19, 23, 23, 17, 201, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 201, DateTimeKind.Local).AddTicks(7327), new DateTime(2022, 12, 19, 23, 23, 17, 201, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 201, DateTimeKind.Local).AddTicks(7347), new DateTime(2022, 12, 19, 23, 23, 17, 201, DateTimeKind.Local).AddTicks(7348) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(616), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(625) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(629), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2602), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2599), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2596), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2593), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2594) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2590), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2591) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2587), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2584), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2585) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2580), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2582) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2577), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2574), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2576) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2544), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2540), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2495), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2482), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(2492) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7858), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7865) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7867), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7868) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7870), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7872) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7874), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7875) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7877), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7880), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7883), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7925), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7927) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7930), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7933), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7934) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7936), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7939), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7943), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7944) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7947), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7950), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7952) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7954), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7955) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7957), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7960), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7962) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7964), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7965) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7967), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7970), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7973), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7977), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7978) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7980), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7981) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7984), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7987), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7988) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7990), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7994), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7997), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7999) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8001), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8002) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8004), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8006) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8008), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8011), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8013) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8014), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8016) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8018), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8022), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8024) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8026), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8027) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8029), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8032), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8034) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8036), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8039), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8042), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8046), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8049), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8050) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8052), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8055), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8057) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8059), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8063), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8064) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8066), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8067) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8069), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8071) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8072), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8074) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8076), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8077) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8079), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8082), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8086), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8087) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8089), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8092), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8096), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8097) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8099), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7153), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7166), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7170), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7173), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7176), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7179), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7183), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7185) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7187), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7188) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7190), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7193), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7196), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7198) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7199), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7202), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7204) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7206), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7209), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7212), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7216), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7217) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7219), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7222), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7223) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7225), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7228), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7232), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7233) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7235), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7239), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7242), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7245), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7248), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7251), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7254), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7258), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7259) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7261), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7264), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7267), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7270), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7272) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7274), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7275) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7277), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7279) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7280), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7337), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7341), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7343) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7344), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7346) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7348), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7349) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7351), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7354), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(9744), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(9731), new DateTime(2022, 12, 19, 23, 23, 17, 202, DateTimeKind.Local).AddTicks(9741) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(1930), new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(1949), new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(1954), new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(1959), new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(1964), new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(1969), new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(1971) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(1974), new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(1978), new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(1983), new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(1985) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(1988), new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(1989) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(2024), new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(2026) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(2030), new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(2031) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(2036), new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(2041), new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(2042) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(2046), new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(2051), new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(2055), new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(2057) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(2060), new DateTime(2022, 12, 19, 23, 23, 17, 204, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 206, DateTimeKind.Local).AddTicks(5646), new DateTime(2022, 12, 19, 23, 23, 17, 206, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 206, DateTimeKind.Local).AddTicks(5615), new DateTime(2022, 12, 19, 23, 23, 17, 206, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 206, DateTimeKind.Local).AddTicks(5650), new DateTime(2022, 12, 19, 23, 23, 17, 206, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 206, DateTimeKind.Local).AddTicks(5653), new DateTime(2022, 12, 19, 23, 23, 17, 206, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 208, DateTimeKind.Local).AddTicks(9562), new DateTime(2022, 12, 19, 23, 23, 17, 208, DateTimeKind.Local).AddTicks(9594) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 23, 23, 17, 208, DateTimeKind.Local).AddTicks(9602), new DateTime(2022, 12, 19, 23, 23, 17, 208, DateTimeKind.Local).AddTicks(9604) });
        }
    }
}
