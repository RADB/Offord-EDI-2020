using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2021DemographicsLanguageTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LookupSet_LookupSetOptions",
                schema: "LUData",
                table: "LookupSetOptions");

            migrationBuilder.AlterColumn<int>(
                name: "FirstLanguage3",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "int",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FirstLanguage2",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "int",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FirstLanguage1",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "int",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(4089), new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(4150) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8070), new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8098), new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8104), new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8106) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8110), new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8112) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8118), new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8123), new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8125) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8129), new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8131) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8135), new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8137) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8141), new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8143) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8182), new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8184) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8188), new DateTime(2021, 6, 28, 17, 14, 51, 111, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 82, DateTimeKind.Local).AddTicks(3912), new DateTime(2021, 6, 28, 17, 14, 51, 82, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 77, DateTimeKind.Local).AddTicks(6846), new DateTime(2021, 6, 28, 17, 14, 51, 82, DateTimeKind.Local).AddTicks(3384) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 82, DateTimeKind.Local).AddTicks(3928), new DateTime(2021, 6, 28, 17, 14, 51, 82, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 82, DateTimeKind.Local).AddTicks(3933), new DateTime(2021, 6, 28, 17, 14, 51, 82, DateTimeKind.Local).AddTicks(3935) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 88, DateTimeKind.Local).AddTicks(3917), new DateTime(2021, 6, 28, 17, 14, 51, 88, DateTimeKind.Local).AddTicks(3960) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 88, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 6, 28, 17, 14, 51, 88, DateTimeKind.Local).AddTicks(3968) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 88, DateTimeKind.Local).AddTicks(3971), new DateTime(2021, 6, 28, 17, 14, 51, 88, DateTimeKind.Local).AddTicks(3973) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 88, DateTimeKind.Local).AddTicks(3976), new DateTime(2021, 6, 28, 17, 14, 51, 88, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 91, DateTimeKind.Local).AddTicks(4068), new DateTime(2021, 6, 28, 17, 14, 51, 91, DateTimeKind.Local).AddTicks(4121) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 91, DateTimeKind.Local).AddTicks(4130), new DateTime(2021, 6, 28, 17, 14, 51, 91, DateTimeKind.Local).AddTicks(4132) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6192), new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6194) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6188), new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6190) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6183), new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6185) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6179), new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6181) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6174), new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6128), new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6130) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6124), new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6119), new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6122) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6115), new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6117) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6106), new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6112) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6102), new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6104) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6097), new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6093), new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6027), new DateTime(2021, 6, 28, 17, 14, 51, 93, DateTimeKind.Local).AddTicks(6087) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2224), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2268) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2274), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2280), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2285), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2289), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2294), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2299), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2301) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2304), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2308), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2313), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2318), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2320) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2322), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2324) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2374), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2377) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2379), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2381) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2384), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2388), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2390) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2393), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2395) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2397), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2401), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2406), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2408) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2410), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2412) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2414), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2419), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2423), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2425) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2427), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2432), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2436), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2440), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2445), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2446) });   

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 100, DateTimeKind.Local).AddTicks(9789), new DateTime(2021, 6, 28, 17, 14, 51, 100, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 100, DateTimeKind.Local).AddTicks(9763), new DateTime(2021, 6, 28, 17, 14, 51, 100, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 130, DateTimeKind.Local).AddTicks(3735), new DateTime(2021, 6, 28, 17, 14, 51, 130, DateTimeKind.Local).AddTicks(3737) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 130, DateTimeKind.Local).AddTicks(3682), new DateTime(2021, 6, 28, 17, 14, 51, 130, DateTimeKind.Local).AddTicks(3729) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 130, DateTimeKind.Local).AddTicks(3740), new DateTime(2021, 6, 28, 17, 14, 51, 130, DateTimeKind.Local).AddTicks(3742) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 130, DateTimeKind.Local).AddTicks(3745), new DateTime(2021, 6, 28, 17, 14, 51, 130, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 146, DateTimeKind.Local).AddTicks(1655), new DateTime(2021, 6, 28, 17, 14, 51, 146, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.AddForeignKey(
                name: "FK_LookupSet_Lookup ",
                schema: "LUData",
                table: "LookupSetOptions",
                column: "LookupSetId",
                principalSchema: "LUData",
                principalTable: "LookupSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LookupSet_Lookup ",
                schema: "LUData",
                table: "LookupSetOptions");

            migrationBuilder.AlterColumn<byte>(
                name: "FirstLanguage3",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "FirstLanguage2",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "FirstLanguage1",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 879, DateTimeKind.Local).AddTicks(6334), new DateTime(2021, 6, 11, 14, 34, 54, 879, DateTimeKind.Local).AddTicks(6369) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 879, DateTimeKind.Local).AddTicks(9957), new DateTime(2021, 6, 11, 14, 34, 54, 879, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(18), new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(26), new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(28) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(33), new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(39), new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(41) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(45), new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(47) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(50), new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(56), new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(62), new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(64) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(68), new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(106), new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(108) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 853, DateTimeKind.Local).AddTicks(4247), new DateTime(2021, 6, 11, 14, 34, 54, 853, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 849, DateTimeKind.Local).AddTicks(4094), new DateTime(2021, 6, 11, 14, 34, 54, 853, DateTimeKind.Local).AddTicks(3814) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 853, DateTimeKind.Local).AddTicks(4262), new DateTime(2021, 6, 11, 14, 34, 54, 853, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 853, DateTimeKind.Local).AddTicks(4267), new DateTime(2021, 6, 11, 14, 34, 54, 853, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 859, DateTimeKind.Local).AddTicks(1015), new DateTime(2021, 6, 11, 14, 34, 54, 859, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 859, DateTimeKind.Local).AddTicks(1042), new DateTime(2021, 6, 11, 14, 34, 54, 859, DateTimeKind.Local).AddTicks(1044) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 859, DateTimeKind.Local).AddTicks(1047), new DateTime(2021, 6, 11, 14, 34, 54, 859, DateTimeKind.Local).AddTicks(1049) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 859, DateTimeKind.Local).AddTicks(1052), new DateTime(2021, 6, 11, 14, 34, 54, 859, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 861, DateTimeKind.Local).AddTicks(6267), new DateTime(2021, 6, 11, 14, 34, 54, 861, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 861, DateTimeKind.Local).AddTicks(6287), new DateTime(2021, 6, 11, 14, 34, 54, 861, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(2075), new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(2077) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(2071), new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(2073) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(2067), new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(2069) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(2062), new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(2057), new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(2013), new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(2008), new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(2004), new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(2006) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(2000), new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(1995), new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(1991), new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(1993) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(1986), new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(1982), new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(1984) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(1962), new DateTime(2021, 6, 11, 14, 34, 54, 863, DateTimeKind.Local).AddTicks(1976) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(2945), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(2977), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(2982), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(2987), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(2991), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(2996), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3001), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3005), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3010), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3014), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3018), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3023), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3027), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3029) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3074), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3077) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3079), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3081) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3084), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3086) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3089), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3093), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3098), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3102), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3106), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3111), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3113) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3115), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3118) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3120), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3122) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3124), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3126) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3129), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3131) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3133), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3137), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3139) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3142), new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 870, DateTimeKind.Local).AddTicks(5153), new DateTime(2021, 6, 11, 14, 34, 54, 870, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 870, DateTimeKind.Local).AddTicks(5092), new DateTime(2021, 6, 11, 14, 34, 54, 870, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 895, DateTimeKind.Local).AddTicks(9842), new DateTime(2021, 6, 11, 14, 34, 54, 895, DateTimeKind.Local).AddTicks(9845) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 895, DateTimeKind.Local).AddTicks(9800), new DateTime(2021, 6, 11, 14, 34, 54, 895, DateTimeKind.Local).AddTicks(9836) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 895, DateTimeKind.Local).AddTicks(9848), new DateTime(2021, 6, 11, 14, 34, 54, 895, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 895, DateTimeKind.Local).AddTicks(9853), new DateTime(2021, 6, 11, 14, 34, 54, 895, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 911, DateTimeKind.Local).AddTicks(2222), new DateTime(2021, 6, 11, 14, 34, 54, 911, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.AddForeignKey(
                name: "FK_LookupSet_LookupSetOptions",
                schema: "LUData",
                table: "LookupSetOptions",
                column: "LookupSetId",
                principalSchema: "LUData",
                principalTable: "LookupSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
