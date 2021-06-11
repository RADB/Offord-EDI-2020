using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2021OntarioSectionE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "CareArrangementAfter",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "CareArrangementBefore",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CentreBasedCommunity",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CentreBasedSchool",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ChildHomeNonRelative",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ChildHomeRelative",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "CommunityLearning",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommunityLearningSpecify",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "DroppedOff",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HomeBased",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "InterventionProgram",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InterventionProgramSpecify",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "NonParentCareAfter",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "NonParentCareBefore",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "NonParentalCare",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OtherCare",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "PickedUp",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PreSchool",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "PriorArrangement",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Year1JK",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

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
                columns: new[] { "CreatedDate", "ModifiedDate", "Ontario" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(62), new DateTime(2021, 6, 11, 14, 34, 54, 880, DateTimeKind.Local).AddTicks(64), true });

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
                columns: new[] { "CreatedDate", "ModifiedDate"},
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

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSets",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LookupName", "ModifiedBy", "ModifiedDate", "YearId" },
                values: new object[,]
                {
                    { 28, "admin", new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3137), "CareArrangement", "admin", new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3139), 1 },
                    { 29, "admin", new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3142), "Transportation", "admin", new DateTime(2021, 6, 11, 14, 34, 54, 868, DateTimeKind.Local).AddTicks(3143), 1 }
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DropColumn(
                name: "CareArrangementAfter",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "CareArrangementBefore",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "CentreBasedCommunity",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "CentreBasedSchool",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "ChildHomeNonRelative",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "ChildHomeRelative",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "CommunityLearning",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "CommunityLearningSpecify",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "DroppedOff",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "HomeBased",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "InterventionProgram",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "InterventionProgramSpecify",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "NonParentCareAfter",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "NonParentCareBefore",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "NonParentalCare",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "OtherCare",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "PickedUp",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "PreSchool",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "PriorArrangement",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "Year1JK",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(1474), new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(1511) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5726), new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5739) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5744), new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5757) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5761), new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5763) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5767), new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5838), new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5841) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5845), new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5851), new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5853) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5856), new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5858) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate", "Ontario" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5862), new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5864), null });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5868), new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate"},
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5874), new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(5875) });
    
            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 656, DateTimeKind.Local).AddTicks(9247), new DateTime(2021, 6, 11, 1, 3, 38, 656, DateTimeKind.Local).AddTicks(9258) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 653, DateTimeKind.Local).AddTicks(711), new DateTime(2021, 6, 11, 1, 3, 38, 656, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 656, DateTimeKind.Local).AddTicks(9262), new DateTime(2021, 6, 11, 1, 3, 38, 656, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 656, DateTimeKind.Local).AddTicks(9266), new DateTime(2021, 6, 11, 1, 3, 38, 656, DateTimeKind.Local).AddTicks(9268) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 662, DateTimeKind.Local).AddTicks(6323), new DateTime(2021, 6, 11, 1, 3, 38, 662, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 662, DateTimeKind.Local).AddTicks(6345), new DateTime(2021, 6, 11, 1, 3, 38, 662, DateTimeKind.Local).AddTicks(6347) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 662, DateTimeKind.Local).AddTicks(6350), new DateTime(2021, 6, 11, 1, 3, 38, 662, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 662, DateTimeKind.Local).AddTicks(6354), new DateTime(2021, 6, 11, 1, 3, 38, 662, DateTimeKind.Local).AddTicks(6356) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 665, DateTimeKind.Local).AddTicks(1994), new DateTime(2021, 6, 11, 1, 3, 38, 665, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 665, DateTimeKind.Local).AddTicks(2018), new DateTime(2021, 6, 11, 1, 3, 38, 665, DateTimeKind.Local).AddTicks(2020) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8391), new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8387), new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8389) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8383), new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8379), new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8374), new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8376) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8370), new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8366), new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8361), new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8357), new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8359) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8353), new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8348), new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8344), new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8346) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8339), new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8318), new DateTime(2021, 6, 11, 1, 3, 38, 666, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9613), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9648), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9654), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9656) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9659), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9665) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9668), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9672), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9676), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9678) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9681), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9685), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9687) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9689), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9694), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9698), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9702), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9704) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9706), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9708) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9711), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9713) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9715), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9717) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9720), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9724), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9726) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9728), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9733), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9737), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9739) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9806), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9811), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9816), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9820), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9822) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9824), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9826) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9829), new DateTime(2021, 6, 11, 1, 3, 38, 671, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 673, DateTimeKind.Local).AddTicks(6572), new DateTime(2021, 6, 11, 1, 3, 38, 673, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 673, DateTimeKind.Local).AddTicks(6550), new DateTime(2021, 6, 11, 1, 3, 38, 673, DateTimeKind.Local).AddTicks(6566) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 699, DateTimeKind.Local).AddTicks(5980), new DateTime(2021, 6, 11, 1, 3, 38, 699, DateTimeKind.Local).AddTicks(5983) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 699, DateTimeKind.Local).AddTicks(5937), new DateTime(2021, 6, 11, 1, 3, 38, 699, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 699, DateTimeKind.Local).AddTicks(5985), new DateTime(2021, 6, 11, 1, 3, 38, 699, DateTimeKind.Local).AddTicks(5987) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 699, DateTimeKind.Local).AddTicks(5990), new DateTime(2021, 6, 11, 1, 3, 38, 699, DateTimeKind.Local).AddTicks(5991) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 714, DateTimeKind.Local).AddTicks(3270), new DateTime(2021, 6, 11, 1, 3, 38, 714, DateTimeKind.Local).AddTicks(3305) });
        }
    }
}
