using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2021OntarioDemographics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "EFSL",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Gifted",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IEP",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IPRC",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SpecialEducation",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
             schema: "EDI",
             table: "Questionnaires",
             keyColumn: "Id",
             keyValue: 1,
             columns: new[] { "CreatedDate", "ModifiedDate", "Ontario" },
             values: new object[] { new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(1474), new DateTime(2021, 6, 11, 1, 3, 38, 683, DateTimeKind.Local).AddTicks(1511), true });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(6844), new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(6854) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "Ontario" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(6861), new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(6865), true });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "Ontario" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(7229), new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(7237), true });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate", "Ontario" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(7251), new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(7257), true });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(7262), new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(7264) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(7312), new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(7315) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(7319), new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(7321) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(7324), new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(7326) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate", "Ontario" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(7335), new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(7337), true });

            migrationBuilder.InsertData(
                schema: "EDI",
                table: "Questionnaires",
                columns: new[] { "Id", "Alberta", "BritishColumbia", "CreatedBy", "CreatedDate", "DescriptionEnglish", "DescriptionFrench", "English", "EntityName", "French", "IsChildQuestionnaire", "IsTeacherQuestionnaire", "Manitoba", "ModifiedBy", "ModifiedDate", "NewBrunswick", "NewfoundlandandLabrador", "NorthwestTerritories", "NovaScotia", "Nunavut", "Ontario", "PrinceEdwardIsland", "Quebec", "QuestionnaireName", "QuestionsRequired", "Saskatchewan", "Sequence", "ShowProgressBar", "ShowQuestionNumbers", "YearId", "YukonTerritory" },
                values: new object[,]
                {
                    { 12, null, null, "admin", new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(7353), "Section E", "Section E", "Section E", "Questionnaires.Data.SectionE", "Section E", true, false, null, "admin", new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(7355), null, null, null, null, null, true, null, null, "Section E", 0, null, 60, true, true, 1, null },
                    { 11, null, null, "admin", new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(7342), "Demographics", "Demographics", "Demographics", "Questionnaires.Data.Demographics", "Demographics", true, false, null, "admin", new DateTime(2021, 6, 10, 21, 9, 40, 570, DateTimeKind.Local).AddTicks(7344), null, null, null, null, null, true, null, null, "Demographics", 0, null, 10, true, true, 1, null },                    
                });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 546, DateTimeKind.Local).AddTicks(4441), new DateTime(2021, 6, 10, 21, 9, 40, 546, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 542, DateTimeKind.Local).AddTicks(7569), new DateTime(2021, 6, 10, 21, 9, 40, 546, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 546, DateTimeKind.Local).AddTicks(4455), new DateTime(2021, 6, 10, 21, 9, 40, 546, DateTimeKind.Local).AddTicks(4457) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 546, DateTimeKind.Local).AddTicks(4459), new DateTime(2021, 6, 10, 21, 9, 40, 546, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 551, DateTimeKind.Local).AddTicks(8849), new DateTime(2021, 6, 10, 21, 9, 40, 551, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 551, DateTimeKind.Local).AddTicks(8873), new DateTime(2021, 6, 10, 21, 9, 40, 551, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 551, DateTimeKind.Local).AddTicks(8877), new DateTime(2021, 6, 10, 21, 9, 40, 551, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 551, DateTimeKind.Local).AddTicks(8882), new DateTime(2021, 6, 10, 21, 9, 40, 551, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 554, DateTimeKind.Local).AddTicks(3970), new DateTime(2021, 6, 10, 21, 9, 40, 554, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 554, DateTimeKind.Local).AddTicks(4002), new DateTime(2021, 6, 10, 21, 9, 40, 554, DateTimeKind.Local).AddTicks(4004) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9833), new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9834) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9829), new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9824), new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9826) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9820), new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9822) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9815), new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9811), new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9807), new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9802), new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9798), new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9794), new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9790), new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9792) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9785), new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9780), new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9760), new DateTime(2021, 6, 10, 21, 9, 40, 555, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(16), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(32) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(37), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(42), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(44) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(47), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(49) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(51), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(56), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(60), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(64), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(69), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(73), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(77), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(79) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(81), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(86), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(88) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(90), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(94), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(96) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(98), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(103), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(107), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(111), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(113) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(115), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(117) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(120), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(124), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(131) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(134), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(135) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(138), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(185), new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(188) });

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSets",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LookupName", "ModifiedBy", "ModifiedDate", "YearId" },
                values: new object[] { 27, "admin", new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(190), "EFSL", "admin", new DateTime(2021, 6, 10, 21, 9, 40, 561, DateTimeKind.Local).AddTicks(192), 1 });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 562, DateTimeKind.Local).AddTicks(6163), new DateTime(2021, 6, 10, 21, 9, 40, 562, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 562, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 6, 10, 21, 9, 40, 562, DateTimeKind.Local).AddTicks(6157) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 587, DateTimeKind.Local).AddTicks(988), new DateTime(2021, 6, 10, 21, 9, 40, 587, DateTimeKind.Local).AddTicks(991) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 587, DateTimeKind.Local).AddTicks(946), new DateTime(2021, 6, 10, 21, 9, 40, 587, DateTimeKind.Local).AddTicks(982) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 587, DateTimeKind.Local).AddTicks(993), new DateTime(2021, 6, 10, 21, 9, 40, 587, DateTimeKind.Local).AddTicks(995) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 587, DateTimeKind.Local).AddTicks(998), new DateTime(2021, 6, 10, 21, 9, 40, 587, DateTimeKind.Local).AddTicks(999) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 9, 40, 602, DateTimeKind.Local).AddTicks(8848), new DateTime(2021, 6, 10, 21, 9, 40, 602, DateTimeKind.Local).AddTicks(8894) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 12); 

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DropColumn(
                name: "EFSL",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "Gifted",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "IEP",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "IPRC",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "SpecialEducation",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "Ontario" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 724, DateTimeKind.Local).AddTicks(6954), new DateTime(2021, 2, 2, 11, 20, 41, 724, DateTimeKind.Local).AddTicks(6992), true });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 725, DateTimeKind.Local).AddTicks(323), new DateTime(2021, 2, 2, 11, 20, 41, 725, DateTimeKind.Local).AddTicks(334) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "Ontario" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 725, DateTimeKind.Local).AddTicks(339), new DateTime(2021, 2, 2, 11, 20, 41, 725, DateTimeKind.Local).AddTicks(342), null });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "Ontario" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 725, DateTimeKind.Local).AddTicks(347), new DateTime(2021, 2, 2, 11, 20, 41, 725, DateTimeKind.Local).AddTicks(349), null });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate", "Ontario" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 725, DateTimeKind.Local).AddTicks(353), new DateTime(2021, 2, 2, 11, 20, 41, 725, DateTimeKind.Local).AddTicks(355), null });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 725, DateTimeKind.Local).AddTicks(360), new DateTime(2021, 2, 2, 11, 20, 41, 725, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 725, DateTimeKind.Local).AddTicks(366), new DateTime(2021, 2, 2, 11, 20, 41, 725, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 725, DateTimeKind.Local).AddTicks(374), new DateTime(2021, 2, 2, 11, 20, 41, 725, DateTimeKind.Local).AddTicks(376) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 725, DateTimeKind.Local).AddTicks(380), new DateTime(2021, 2, 2, 11, 20, 41, 725, DateTimeKind.Local).AddTicks(382) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate", "Ontario" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 725, DateTimeKind.Local).AddTicks(431), new DateTime(2021, 2, 2, 11, 20, 41, 725, DateTimeKind.Local).AddTicks(434), true });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 699, DateTimeKind.Local).AddTicks(3187), new DateTime(2021, 2, 2, 11, 20, 41, 699, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 695, DateTimeKind.Local).AddTicks(7067), new DateTime(2021, 2, 2, 11, 20, 41, 699, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 699, DateTimeKind.Local).AddTicks(3202), new DateTime(2021, 2, 2, 11, 20, 41, 699, DateTimeKind.Local).AddTicks(3204) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 699, DateTimeKind.Local).AddTicks(3207), new DateTime(2021, 2, 2, 11, 20, 41, 699, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 705, DateTimeKind.Local).AddTicks(1259), new DateTime(2021, 2, 2, 11, 20, 41, 705, DateTimeKind.Local).AddTicks(1337) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 705, DateTimeKind.Local).AddTicks(1343), new DateTime(2021, 2, 2, 11, 20, 41, 705, DateTimeKind.Local).AddTicks(1346) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 705, DateTimeKind.Local).AddTicks(1349), new DateTime(2021, 2, 2, 11, 20, 41, 705, DateTimeKind.Local).AddTicks(1351) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 705, DateTimeKind.Local).AddTicks(1354), new DateTime(2021, 2, 2, 11, 20, 41, 705, DateTimeKind.Local).AddTicks(1355) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 708, DateTimeKind.Local).AddTicks(1587), new DateTime(2021, 2, 2, 11, 20, 41, 708, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 708, DateTimeKind.Local).AddTicks(1642), new DateTime(2021, 2, 2, 11, 20, 41, 708, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8623), new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8625) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8619), new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8621) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8616), new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8611), new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8613) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8607), new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8609) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8603), new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8605) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8599), new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8595), new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8591), new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8586), new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8589) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8582), new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8578), new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8573), new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8540), new DateTime(2021, 2, 2, 11, 20, 41, 709, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9090), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9183), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9189), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9191) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9194), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9196) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9198), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9200) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9202), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9207), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9208) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9213), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9217), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9219) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9222), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9226), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9227) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9230), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9234), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9236) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9238), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9242), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9246), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9253), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9257), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9261), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9263) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9265), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9269), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9273), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9277), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9279) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9281), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9283) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9286), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9290), new DateTime(2021, 2, 2, 11, 20, 41, 714, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 716, DateTimeKind.Local).AddTicks(6244), new DateTime(2021, 2, 2, 11, 20, 41, 716, DateTimeKind.Local).AddTicks(6246) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 716, DateTimeKind.Local).AddTicks(6224), new DateTime(2021, 2, 2, 11, 20, 41, 716, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 742, DateTimeKind.Local).AddTicks(7469), new DateTime(2021, 2, 2, 11, 20, 41, 742, DateTimeKind.Local).AddTicks(7471) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 742, DateTimeKind.Local).AddTicks(7419), new DateTime(2021, 2, 2, 11, 20, 41, 742, DateTimeKind.Local).AddTicks(7462) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 742, DateTimeKind.Local).AddTicks(7474), new DateTime(2021, 2, 2, 11, 20, 41, 742, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 742, DateTimeKind.Local).AddTicks(7478), new DateTime(2021, 2, 2, 11, 20, 41, 742, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 2, 2, 11, 20, 41, 758, DateTimeKind.Local).AddTicks(1303), new DateTime(2021, 2, 2, 11, 20, 41, 758, DateTimeKind.Local).AddTicks(1344) });
        }
    }
}
