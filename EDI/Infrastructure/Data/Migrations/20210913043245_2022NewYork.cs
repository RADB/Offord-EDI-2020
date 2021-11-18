using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2022NewYork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "NewYork",
                schema: "LUData",
                table: "Years",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "HomeworkAssistance",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "OneOnOneConference",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "ParentTeacherConference",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "US_CentreBased",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "US_ChildHome",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "US_DontKnow",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "US_Other",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "US_OtherHomeBased",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "US_OtherSpecify",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Volunteered",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VolunteeredSpecify",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "ClassTime",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClassTimeSpecify",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "ELL",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ethnicity",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "SpecialNeedsReferral",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "NewYork",
                schema: "EDI",
                table: "Questionnaires.Configuration",
                type: "bit",
                nullable: true,
                defaultValueSql: "((0))");

            migrationBuilder.AddColumn<bool>(
                name: "NewYork",
                schema: "EDI",
                table: "Questionnaires",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "NewYork",
                schema: "EDI",
                table: "NewsFeed",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "NewYork",
                schema: "EDI",
                table: "Links",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "NewYork",
                schema: "EDI",
                table: "FAQ",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "NewYork" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 704, DateTimeKind.Local).AddTicks(5854), new DateTime(2021, 9, 13, 0, 32, 44, 704, DateTimeKind.Local).AddTicks(5893), true });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(221), new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(234) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "NewYork" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(240), new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(243), true });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "NewYork" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(248), new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(250), true });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate", "NewYork" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(255), new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(256), true });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(260), new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(267), new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(269) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(375), new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(383), new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(385) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate", "NewYork" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(389), new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(391), true });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(395), new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(401), new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(403) });

            migrationBuilder.InsertData(
                schema: "EDI",
                table: "Questionnaires",
                columns: new[] { "Id", "Alberta", "BritishColumbia", "CreatedBy", "CreatedDate", "DescriptionEnglish", "DescriptionFrench", "English", "EntityName", "French", "IsChildQuestionnaire", "IsTeacherQuestionnaire", "Manitoba", "ModifiedBy", "ModifiedDate", "NewBrunswick", "NewYork", "NewfoundlandandLabrador", "NorthwestTerritories", "NovaScotia", "Nunavut", "Ontario", "PrinceEdwardIsland", "Quebec", "QuestionnaireName", "QuestionsRequired", "Saskatchewan", "Sequence", "ShowProgressBar", "ShowQuestionNumbers", "YearId", "YukonTerritory" },
                values: new object[,]
                {
                    { 13, null, null, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(407), "Demographics", "Demographics", "Demographics", "Questionnaires.Data.Demographics", "Demographics", true, false, null, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(409), null, true, null, null, null, null, null, null, null, "Demographics", 0, null, 10, true, true, 1, null },
                    { 14, null, null, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(412), "Section E", "Section E", "Section E", "Questionnaires.Data.SectionE", "Section E", true, false, null, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 705, DateTimeKind.Local).AddTicks(414), null, true, null, null, null, null, null, null, null, "Section E", 0, null, 60, true, true, 1, null }
                });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 675, DateTimeKind.Local).AddTicks(8587), new DateTime(2021, 9, 13, 0, 32, 44, 675, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 669, DateTimeKind.Local).AddTicks(4443), new DateTime(2021, 9, 13, 0, 32, 44, 675, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 675, DateTimeKind.Local).AddTicks(8601), new DateTime(2021, 9, 13, 0, 32, 44, 675, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "ChildStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 675, DateTimeKind.Local).AddTicks(8606), new DateTime(2021, 9, 13, 0, 32, 44, 675, DateTimeKind.Local).AddTicks(8608) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 682, DateTimeKind.Local).AddTicks(5226), new DateTime(2021, 9, 13, 0, 32, 44, 682, DateTimeKind.Local).AddTicks(5270) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 682, DateTimeKind.Local).AddTicks(5281), new DateTime(2021, 9, 13, 0, 32, 44, 682, DateTimeKind.Local).AddTicks(5288) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 682, DateTimeKind.Local).AddTicks(5353), new DateTime(2021, 9, 13, 0, 32, 44, 682, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 682, DateTimeKind.Local).AddTicks(5368), new DateTime(2021, 9, 13, 0, 32, 44, 682, DateTimeKind.Local).AddTicks(5374) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 685, DateTimeKind.Local).AddTicks(3211), new DateTime(2021, 9, 13, 0, 32, 44, 685, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 685, DateTimeKind.Local).AddTicks(3239), new DateTime(2021, 9, 13, 0, 32, 44, 685, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9454), new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9450), new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9445), new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9441), new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9443) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9437), new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9432), new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9434) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9428), new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9430) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9423), new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9419), new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9415), new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9410), new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9412) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9406), new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9408) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9401), new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9403) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "InputTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9381), new DateTime(2021, 9, 13, 0, 32, 44, 686, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3372), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3402) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3408), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3413), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3418), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3420) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3422), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3425) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3427), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3432), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3434) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3436), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3438) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3440), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3445), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3449), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3454), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3456) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3458), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3462), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3467), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3471), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3475), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3477) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3480), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3482) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3534), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3536) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3539), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3543), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3545) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3547), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3549) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3552), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3554) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3556), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3558) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3560), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3562) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3565), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3567) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3569), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3571) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3574), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3578), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3582), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3587), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3589) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3591), new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSets",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LookupName", "ModifiedBy", "ModifiedDate", "YearId" },
                values: new object[,]
                {
                    { 33, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3596), "RaceEthnicity", "admin", new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3598), 1 },
                    { 34, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3600), "ClassTime", "admin", new DateTime(2021, 9, 13, 0, 32, 44, 692, DateTimeKind.Local).AddTicks(3602), 1 }
                });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 694, DateTimeKind.Local).AddTicks(8530), new DateTime(2021, 9, 13, 0, 32, 44, 694, DateTimeKind.Local).AddTicks(8532) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Orientations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 694, DateTimeKind.Local).AddTicks(8510), new DateTime(2021, 9, 13, 0, 32, 44, 694, DateTimeKind.Local).AddTicks(8524) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 722, DateTimeKind.Local).AddTicks(7961), new DateTime(2021, 9, 13, 0, 32, 44, 722, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 722, DateTimeKind.Local).AddTicks(7914), new DateTime(2021, 9, 13, 0, 32, 44, 722, DateTimeKind.Local).AddTicks(7955) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 722, DateTimeKind.Local).AddTicks(7967), new DateTime(2021, 9, 13, 0, 32, 44, 722, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "TeacherStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 722, DateTimeKind.Local).AddTicks(7971), new DateTime(2021, 9, 13, 0, 32, 44, 722, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "NewYork", "Ontario" },
                values: new object[] { new DateTime(2021, 9, 13, 0, 32, 44, 743, DateTimeKind.Local).AddTicks(4304), new DateTime(2021, 9, 13, 0, 32, 44, 743, DateTimeKind.Local).AddTicks(4354), true, true });

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "Years",
                columns: new[] { "Id", "Alberta", "BritishColumbia", "CreatedBy", "CreatedDate", "Ediyear", "Manitoba", "ModifiedBy", "ModifiedDate", "NewBrunswick", "NewYork", "NewfoundlandandLabrador", "NorthwestTerritories", "NovaScotia", "Nunavut", "Ontario", "PrinceEdwardIsland", "Quebec", "Saskatchewan", "YukonTerritory" },
                values: new object[] { 2, null, null, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 743, DateTimeKind.Local).AddTicks(4487), (short)2022, null, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 743, DateTimeKind.Local).AddTicks(4492), null, true, null, true, true, null, true, null, null, null, null });

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSetOptions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "English", "French", "LookupSetId", "ModifiedBy", "ModifiedDate", "Sequence", "Value" },
                values: new object[,]
                {
                    { 281, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(5998), "Multiracial", "Multiracial", 33, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6015), (short)10, (short)1 },
                    { 282, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6020), "American Indian/Alaskan Native", "American Indian/Alaskan Native", 33, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6022), (short)20, (short)2 },
                    { 283, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6025), "African American/Black", "African American/Black", 33, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6027), (short)30, (short)3 },
                    { 284, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6030), "Asian", "Asian", 33, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6032), (short)40, (short)4 },
                    { 285, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6034), "Native Hawaiian or other Pacific Islander", "Native Hawaiian or other Pacific Islander", 33, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6036), (short)50, (short)5 },
                    { 286, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6038), "Hispanic, Latino/a", "Hispanic, Latino/a", 33, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6040), (short)60, (short)6 },
                    { 287, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6043), "White", "White", 33, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6044), (short)70, (short)7 },
                    { 288, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6047), "Other", "Other", 33, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6049), (short)80, (short)8 },
                    { 289, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6051), "AM", "AM", 34, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6053), (short)10, (short)1 },
                    { 290, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6055), "PM", "PM", 34, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6057), (short)20, (short)2 },
                    { 291, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6060), "All Day", "All Day", 34, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6062), (short)30, (short)3 },
                    { 292, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6064), "Other", "Other", 34, "admin", new DateTime(2021, 9, 13, 0, 32, 44, 693, DateTimeKind.Local).AddTicks(6066), (short)40, (short)4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "Years",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DropColumn(
                name: "NewYork",
                schema: "LUData",
                table: "Years");

            migrationBuilder.DropColumn(
                name: "HomeworkAssistance",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "OneOnOneConference",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "ParentTeacherConference",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "US_CentreBased",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "US_ChildHome",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "US_DontKnow",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "US_Other",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "US_OtherHomeBased",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "US_OtherSpecify",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "Volunteered",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "VolunteeredSpecify",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "ClassTime",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "ClassTimeSpecify",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "ELL",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "Ethnicity",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "SpecialNeedsReferral",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "NewYork",
                schema: "EDI",
                table: "Questionnaires.Configuration");

            migrationBuilder.DropColumn(
                name: "NewYork",
                schema: "EDI",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "NewYork",
                schema: "EDI",
                table: "NewsFeed");

            migrationBuilder.DropColumn(
                name: "NewYork",
                schema: "EDI",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "NewYork",
                schema: "EDI",
                table: "FAQ");

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
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2449), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2451) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2453), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2455) });

            migrationBuilder.UpdateData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2458), new DateTime(2021, 6, 28, 17, 14, 51, 99, DateTimeKind.Local).AddTicks(2460) });

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
                columns: new[] { "CreatedDate", "ModifiedDate", "Ontario" },
                values: new object[] { new DateTime(2021, 6, 28, 17, 14, 51, 146, DateTimeKind.Local).AddTicks(1655), new DateTime(2021, 6, 28, 17, 14, 51, 146, DateTimeKind.Local).AddTicks(1703), null });
        }
    }
}
