using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2023FirstNations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FirstNations",
                schema: "LUData",
                table: "Years",
                type: "bit",
                nullable: true);

            //migrationBuilder.AddColumn<byte>(
            //    name: "PercentComplete",
            //    schema: "EDI",
            //    table: "Teachers",
            //    type: "tinyint",
            //    nullable: false,
            //    defaultValue: (byte)0);

            //migrationBuilder.AddColumn<byte>(
            //    name: "CreeSpeaker",
            //    schema: "EDI",
            //    table: "Questionnaires.Data.SectionE",
            //    type: "tinyint",
            //    nullable: true);

            //migrationBuilder.AddColumn<byte>(
            //    name: "FirstNations",
            //    schema: "EDI",
            //    table: "Questionnaires.Data.SectionE",
            //    type: "tinyint",
            //    nullable: true);

            //migrationBuilder.AddColumn<byte>(
            //    name: "HeadStart",
            //    schema: "EDI",
            //    table: "Questionnaires.Data.SectionE",
            //    type: "tinyint",
            //    nullable: true);

            //migrationBuilder.AddColumn<byte>(
            //    name: "Inuit",
            //    schema: "EDI",
            //    table: "Questionnaires.Data.SectionE",
            //    type: "tinyint",
            //    nullable: true);

            //migrationBuilder.AddColumn<byte>(
            //    name: "Metis",
            //    schema: "EDI",
            //    table: "Questionnaires.Data.SectionE",
            //    type: "tinyint",
            //    nullable: true);

            //migrationBuilder.AddColumn<byte>(
            //    name: "OtherIndigenous",
            //    schema: "EDI",
            //    table: "Questionnaires.Data.SectionE",
            //    type: "tinyint",
            //    nullable: true);

            //migrationBuilder.AddColumn<byte>(
            //    name: "BandMembership",
            //    schema: "EDI",
            //    table: "Questionnaires.Data.Demographics",
            //    type: "tinyint",
            //    nullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "BandOtherSpecify",
            //    schema: "EDI",
            //    table: "Questionnaires.Data.Demographics",
            //    type: "nvarchar(max)",
            //    nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FirstNations",
                schema: "EDI",
                table: "Questionnaires.Configuration",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FirstNations",
                schema: "EDI",
                table: "Questionnaires",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FirstNations",
                schema: "EDI",
                table: "NewsFeed",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FirstNations",
                schema: "EDI",
                table: "Links",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FirstNations",
                schema: "EDI",
                table: "FAQ",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "IndigenousLanguage",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "tinyint",
                nullable: true);

            // add firstnations to this years options
            migrationBuilder.Sql("UPDATE [LUData].[Years] SET FirstNations=1 WHERE ID=3");

            // start with ONTARIO Create Demographics
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires] ([YearId],[QuestionnaireName],[English],[French],[DescriptionEnglish],[DescriptionFrench],[ShowProgressBar],[EntityName],[ShowQuestionNumbers],[Sequence],[IsChildQuestionnaire],[IsTeacherQuestionnaire],[QuestionsRequired],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],[FirstNations]) SELECT [YearId],[QuestionnaireName],[English],[French],[DescriptionEnglish],[DescriptionFrench],[ShowProgressBar],[EntityName],[ShowQuestionNumbers],[Sequence],[IsChildQuestionnaire],[IsTeacherQuestionnaire],[QuestionsRequired],getDate() as [CreatedDate],[CreatedBy],getDate() as [ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],0 as [Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork], 1 as FirstNations FROM [EDI].[Questionnaires] WHERE Yearid=3 AND ID = 43");
            // note the Ontario as Firstnations at the end to copy all removed questions as well
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],[FirstNations]) SELECT 55 as QuestionnaireID,[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],getDate() as [CreatedDate],'admin' as [CreatedBy],getDate() as [ModifiedDate],'admin' as [ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],0 as [Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork], [Ontario] as FirstNations FROM[EDI].[Questionnaires.Configuration] WHERE YeariD = 3 and QuestionnaireId = 43");

            // Add Questionnaires A-E and Teacher Profile
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires] SET FirstNations=1 WHERE yearID=3 AND ID in (33,35,36,37,42,44)");
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET FirstNations=1 WHERE yearID=3 AND QuestionnaireID in (33,35,36,37,42,44) AND Ontario = 1");

            /* github 244 FirstNations Demographics - add question to end */
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,FirstNations) VALUES(55,31,5,0,0,'Languages',0,Null,Null,Null,Null,'Does this child have familiarity with Anishinaabemowin/Nishnaabemowin/Lenape (or Indigenous) Language:','Does this child have familiarity with Anishinaabemowin/Nishnaabemowin/Lenape (or Indigenous) Language:','IndigenousLanguage',1,'LookupSets',78,280,5,1,Null ,0,'','',1,0,Null,'','','Questionnaires.Data.Demographics','IndigenousLanguage' ,3,1)");


            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "ChildStatus",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 139, DateTimeKind.Local).AddTicks(8644), new DateTime(2023, 6, 14, 22, 1, 21, 139, DateTimeKind.Local).AddTicks(8646) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "ChildStatus",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 139, DateTimeKind.Local).AddTicks(8600), new DateTime(2023, 6, 14, 22, 1, 21, 139, DateTimeKind.Local).AddTicks(8641) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "ChildStatus",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 139, DateTimeKind.Local).AddTicks(8648), new DateTime(2023, 6, 14, 22, 1, 21, 139, DateTimeKind.Local).AddTicks(8654) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "ChildStatus",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 139, DateTimeKind.Local).AddTicks(8663), new DateTime(2023, 6, 14, 22, 1, 21, 139, DateTimeKind.Local).AddTicks(8665) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "FileImportStatus",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 140, DateTimeKind.Local).AddTicks(5522), new DateTime(2023, 6, 14, 22, 1, 21, 140, DateTimeKind.Local).AddTicks(5535) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "FileImportStatus",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 140, DateTimeKind.Local).AddTicks(5613), new DateTime(2023, 6, 14, 22, 1, 21, 140, DateTimeKind.Local).AddTicks(5615) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "FileImportStatus",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 140, DateTimeKind.Local).AddTicks(5617), new DateTime(2023, 6, 14, 22, 1, 21, 140, DateTimeKind.Local).AddTicks(5619) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "FileImportStatus",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 140, DateTimeKind.Local).AddTicks(5621), new DateTime(2023, 6, 14, 22, 1, 21, 140, DateTimeKind.Local).AddTicks(5643) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "FileImportStatus",
            //    keyColumn: "Id",
            //    keyValue: 5,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 140, DateTimeKind.Local).AddTicks(5645), new DateTime(2023, 6, 14, 22, 1, 21, 140, DateTimeKind.Local).AddTicks(5647) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "Genders",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 140, DateTimeKind.Local).AddTicks(9493), new DateTime(2023, 6, 14, 22, 1, 21, 140, DateTimeKind.Local).AddTicks(9506) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "Genders",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 140, DateTimeKind.Local).AddTicks(9510), new DateTime(2023, 6, 14, 22, 1, 21, 140, DateTimeKind.Local).AddTicks(9511) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1511), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1512) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1508), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1509) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1504), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1506) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1501), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1502) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 5,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1498), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1499) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 6,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1495), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1496) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 7,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1491), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1493) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 8,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1488), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1489) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 9,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1484), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1486) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 10,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1480), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1482) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 11,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1440), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1448) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 12,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1437), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1438) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 13,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1433), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1435) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 14,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1420), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(1430) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 281,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7250), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7257) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 282,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7259), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7261) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 283,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7263), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7264) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 284,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7266), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7268) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 285,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7269), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7271) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 286,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7273), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7274) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 287,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7276), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7278) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 288,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7280), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7281) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 289,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7283), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7284) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 290,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7286), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7288) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 291,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7303), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7304) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 292,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7306), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7307) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 585,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7310), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7312) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 586,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7314), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7315) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 587,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7317), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7319) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 588,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7321), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7322) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 589,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7324), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7325) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 590,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7327), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7329) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 591,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7331), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7332) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 592,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7334), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7336) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 593,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7337), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7339) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 594,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7341), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7342) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 595,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7345), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7346) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 596,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7349), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7350) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 597,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7352), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7354) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 598,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7356), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7357) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 599,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7359), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7361) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 600,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7412), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7414) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 601,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7416), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7418) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 602,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7421) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 603,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7423), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7424) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 604,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7426), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7428) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 605,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7430), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7431) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 606,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7433), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7435) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 607,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7438), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7440) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 608,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7441), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7443) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 609,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7445), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7446) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 610,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7448), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7450) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 611,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7452), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7453) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 612,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7456), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7457) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 613,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7459), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7460) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 614,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7462), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7464) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 615,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7466), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7467) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 616,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7469), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7471) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 617,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7473), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7474) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 618,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7477), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7479) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 619,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7481), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7482) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 620,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7484), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7486) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 621,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7488), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7489) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 622,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7491), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7492) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 623,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7494), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7496) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 624,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7498), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7499) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 625,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7501), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7503) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 965,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7504), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7506) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 966,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7508), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7509) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 967,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7511), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7513) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 968,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7515), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7517) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 969,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7519), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7520) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 970,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7522), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7524) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 971,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7525), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7527) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 972,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7529), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7530) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 973,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7532), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7534) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 974,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7535), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7537) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 975,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7539), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7540) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 976,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7542), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7544) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 977,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7546), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7548) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 978,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7550), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7551) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 979,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7553), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7554) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 980,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7556), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7558) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 981,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7560), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7561) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 982,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7563), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7564) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 983,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7566), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7568) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 984,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7570), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7571) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 985,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7573), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7575) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 986,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7577), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7578) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 987,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7580), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7582) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 988,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7584), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(7585) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6494), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6505) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6508), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6509) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6511), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6513) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6515), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6517) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 5,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6519), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6520) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 6,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6522), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6523) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 7,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6525), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6527) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 8,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6529), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6530) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 9,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6532), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6534) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 10,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6536), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6537) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 11,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6539), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6541) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 12,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6543), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6544) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 13,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6546), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6547) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 14,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6550), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6552) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 15,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6554), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6555) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 16,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6599), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6601) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 17,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6603), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6605) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 18,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6607), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6608) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 19,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6610), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6612) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 20,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6614), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6615) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 21,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6617), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6619) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 22,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6620), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6622) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 23,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6624), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6625) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 24,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6627), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6629) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 25,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6631), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6632) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 26,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6634), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6635) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 27,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6638), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6639) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 28,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6641), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6642) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 29,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6644), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6646) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 30,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6648), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6650) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 31,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6652), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6653) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 32,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6655), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6657) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 33,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6658), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6660) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 34,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6662), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6663) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 69,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6665), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6667) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 70,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6669), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6670) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 71,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6672), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6674) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 72,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6676), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6678) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 73,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6680), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6681) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 74,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6683), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6684) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 75,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6686), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6688) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 119,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6690), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6691) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 120,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6693), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6694) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 121,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6696), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6698) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 122,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6711), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6712) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 123,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6714), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6716) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 124,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6726), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6728) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 125,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6730), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(6731) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "Orientations",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(9547), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(9550) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "Orientations",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(9467), new DateTime(2023, 6, 14, 22, 1, 21, 141, DateTimeKind.Local).AddTicks(9477) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(4958), new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(4987) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(4995), new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(4997) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5002), new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5003) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5007), new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5008) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 5,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5012), new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5013) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 6,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5017), new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5018) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 7,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5022), new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5023) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 8,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5027), new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5028) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 9,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5115), new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5117) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 10,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5121), new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5123) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 11,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5126), new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5128) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 12,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5131), new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5132) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 13,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5136), new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5138) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 14,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5141), new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5142) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 29,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5145), new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5147) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 30,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5150), new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5152) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 31,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5155), new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5156) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 32,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 6, 14, 22, 1, 21, 143, DateTimeKind.Local).AddTicks(5162) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "TeacherStatus",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 146, DateTimeKind.Local).AddTicks(625), new DateTime(2023, 6, 14, 22, 1, 21, 146, DateTimeKind.Local).AddTicks(627) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "TeacherStatus",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 146, DateTimeKind.Local).AddTicks(601), new DateTime(2023, 6, 14, 22, 1, 21, 146, DateTimeKind.Local).AddTicks(621) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "TeacherStatus",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 146, DateTimeKind.Local).AddTicks(629), new DateTime(2023, 6, 14, 22, 1, 21, 146, DateTimeKind.Local).AddTicks(630) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "TeacherStatus",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 146, DateTimeKind.Local).AddTicks(632), new DateTime(2023, 6, 14, 22, 1, 21, 146, DateTimeKind.Local).AddTicks(634) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "Years",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 148, DateTimeKind.Local).AddTicks(2719), new DateTime(2023, 6, 14, 22, 1, 21, 148, DateTimeKind.Local).AddTicks(2734) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "Years",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 6, 14, 22, 1, 21, 148, DateTimeKind.Local).AddTicks(2742), new DateTime(2023, 6, 14, 22, 1, 21, 148, DateTimeKind.Local).AddTicks(2744) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstNations",
                schema: "LUData",
                table: "Years");

            //migrationBuilder.DropColumn(
            //    name: "PercentComplete",
            //    schema: "EDI",
            //    table: "Teachers");

            //migrationBuilder.DropColumn(
            //    name: "CreeSpeaker",
            //    schema: "EDI",
            //    table: "Questionnaires.Data.SectionE");

            //migrationBuilder.DropColumn(
            //    name: "FirstNations",
            //    schema: "EDI",
            //    table: "Questionnaires.Data.SectionE");

            //migrationBuilder.DropColumn(
            //    name: "HeadStart",
            //    schema: "EDI",
            //    table: "Questionnaires.Data.SectionE");

            //migrationBuilder.DropColumn(
            //    name: "Inuit",
            //    schema: "EDI",
            //    table: "Questionnaires.Data.SectionE");

            //migrationBuilder.DropColumn(
            //    name: "Metis",
            //    schema: "EDI",
            //    table: "Questionnaires.Data.SectionE");

            //migrationBuilder.DropColumn(
            //    name: "OtherIndigenous",
            //    schema: "EDI",
            //    table: "Questionnaires.Data.SectionE");

            //migrationBuilder.DropColumn(
            //    name: "BandMembership",
            //    schema: "EDI",
            //    table: "Questionnaires.Data.Demographics");

            //migrationBuilder.DropColumn(
            //    name: "BandOtherSpecify",
            //    schema: "EDI",
            //    table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "FirstNations",
                schema: "EDI",
                table: "Questionnaires.Configuration");

            migrationBuilder.DropColumn(
                name: "FirstNations",
                schema: "EDI",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "FirstNations",
                schema: "EDI",
                table: "NewsFeed");

            migrationBuilder.DropColumn(
                name: "FirstNations",
                schema: "EDI",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "FirstNations",
                schema: "EDI",
                table: "FAQ");

            migrationBuilder.DropColumn(
                name: "IndigenousLanguage",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "ChildStatus",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 185, DateTimeKind.Local).AddTicks(2215), new DateTime(2023, 1, 5, 14, 5, 4, 185, DateTimeKind.Local).AddTicks(2216) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "ChildStatus",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 185, DateTimeKind.Local).AddTicks(2176), new DateTime(2023, 1, 5, 14, 5, 4, 185, DateTimeKind.Local).AddTicks(2212) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "ChildStatus",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 185, DateTimeKind.Local).AddTicks(2218), new DateTime(2023, 1, 5, 14, 5, 4, 185, DateTimeKind.Local).AddTicks(2219) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "ChildStatus",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 185, DateTimeKind.Local).AddTicks(2221), new DateTime(2023, 1, 5, 14, 5, 4, 185, DateTimeKind.Local).AddTicks(2222) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "FileImportStatus",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 185, DateTimeKind.Local).AddTicks(7777), new DateTime(2023, 1, 5, 14, 5, 4, 185, DateTimeKind.Local).AddTicks(7785) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "FileImportStatus",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 185, DateTimeKind.Local).AddTicks(7858), new DateTime(2023, 1, 5, 14, 5, 4, 185, DateTimeKind.Local).AddTicks(7860) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "FileImportStatus",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 185, DateTimeKind.Local).AddTicks(7863), new DateTime(2023, 1, 5, 14, 5, 4, 185, DateTimeKind.Local).AddTicks(7864) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "FileImportStatus",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 185, DateTimeKind.Local).AddTicks(7866), new DateTime(2023, 1, 5, 14, 5, 4, 185, DateTimeKind.Local).AddTicks(7867) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "FileImportStatus",
            //    keyColumn: "Id",
            //    keyValue: 5,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 185, DateTimeKind.Local).AddTicks(7869), new DateTime(2023, 1, 5, 14, 5, 4, 185, DateTimeKind.Local).AddTicks(7870) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "Genders",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(890), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(899) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "Genders",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(902), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(903) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2624), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2626) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2622), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2623) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2619), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2620) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2616), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2617) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 5,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2613), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2614) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 6,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2611), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2612) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 7,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2608), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2609) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 8,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2605), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2606) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 9,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2602), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2603) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 10,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2599), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2600) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 11,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2596), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2597) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 12,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2593), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2594) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 13,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2590), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2591) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "InputTypes",
            //    keyColumn: "Id",
            //    keyValue: 14,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2579), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(2587) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 281,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7443), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7448) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 282,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7451), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7452) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 283,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7454), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7455) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 284,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7456), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7458) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 285,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7459), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7460) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 286,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7462), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7463) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 287,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7465), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7466) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 288,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7467), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7469) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 289,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7471), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7472) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 290,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7474), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7475) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 291,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7477), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7478) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 292,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7479), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7480) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 585,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7482), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7483) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 586,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7522), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7523) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 587,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7525), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7526) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 588,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7528), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7529) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 589,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7531), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7532) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 590,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7534), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7535) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 591,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7537), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7538) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 592,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7541), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7542) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 593,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7544), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7545) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 594,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7547), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7548) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 595,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7550), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7551) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 596,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7553), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7554) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 597,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7555), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7557) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 598,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7558), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7559) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 599,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7562), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7563) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 600,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7564), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7566) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 601,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7595), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7596) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 602,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7598), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7599) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 603,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7602), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7603) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 604,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7604), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7606) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 605,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7607), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7608) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 606,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7611), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7612) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 607,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7614), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7615) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 608,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7617), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7618) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 609,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7620), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7621) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 610,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7623), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7624) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 611,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7626), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7627) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 612,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7629), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7630) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 613,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7631), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7633) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 614,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7635), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7636) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 615,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7638), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7639) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 616,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7641), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7642) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 617,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7643), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7645) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 618,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7650), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7651) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 619,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7653), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7654) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 620,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7656), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7657) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 621,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7659), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7660) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 622,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7662), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7663) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 623,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7665), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7666) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 624,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7668), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7669) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 625,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7671), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7672) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 965,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7674), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7675) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 966,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7677), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7678) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 967,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7680), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7681) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 968,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7683), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7685) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 969,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7686), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7687) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 970,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7689), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7690) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 971,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7692), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7693) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 972,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7695), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7696) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 973,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7698), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7699) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 974,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7700), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7702) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 975,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7704), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7705) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 976,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7707), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7708) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 977,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7710), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7711) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 978,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7712), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7714) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 979,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7715), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7716) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 980,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7718), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7719) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 981,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7721), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7722) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 982,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7724), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7725) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 983,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7727), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7728) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 984,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7730), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7731) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 985,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7732), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7734) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 986,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7735), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7736) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 987,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7739), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7740) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSetOptions",
            //    keyColumn: "Id",
            //    keyValue: 988,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7742), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7743) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6856), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6865) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6867), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6869) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6870), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6872) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6873), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6874) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 5,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6877), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6878) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 6,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6879), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6881) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 7,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6882), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6883) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 8,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6885), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6886) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 9,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6888), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6889) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 10,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6928), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6930) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 11,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6932), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6933) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 12,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6935), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6936) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 13,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6937), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6939) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 14,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6940), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6941) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 15,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6943), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6944) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 16,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6946), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6947) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 17,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6948), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6950) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 18,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6951), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6952) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 19,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6954), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6955) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 20,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6957), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6958) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 21,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6961), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6962) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 22,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6964), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6965) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 23,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6967), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6968) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 24,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6970), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6971) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 25,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6972), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6974) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 26,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6975), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6976) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 27,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6978), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6979) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 28,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6981), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6982) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 29,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6984), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6985) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 30,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6986), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6987) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 31,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6989), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6990) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 32,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6992), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6993) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 33,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6995), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6996) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 34,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6997), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(6999) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 69,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7000), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7001) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 70,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7003), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7005) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 71,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7007), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7008) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 72,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7010), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7011) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 73,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7013), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7014) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 74,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7015), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7017) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 75,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7018), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7019) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 119,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7021), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7022) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 120,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7024), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7025) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 121,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7026), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7028) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 122,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7029), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7030) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 123,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7062), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7063) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 124,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7065), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7066) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "LookupSets",
            //    keyColumn: "Id",
            //    keyValue: 125,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7068), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(7069) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "Orientations",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(9693), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(9694) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "Orientations",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(9682), new DateTime(2023, 1, 5, 14, 5, 4, 186, DateTimeKind.Local).AddTicks(9691) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1109), new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1119) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1126), new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1127) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1131), new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1132) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1137), new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1138) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 5,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1142), new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1143) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 6,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1147), new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1148) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 7,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1151), new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1152) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 8,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1192), new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1193) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 9,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1196), new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1198) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 10,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1200), new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1202) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 11,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1205), new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1206) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 12,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1213), new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1214) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 13,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1217), new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1219) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 14,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1221), new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1223) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 29,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1226), new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1227) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 30,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1230), new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1231) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 31,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1234), new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1235) });

            //migrationBuilder.UpdateData(
            //    schema: "EDI",
            //    table: "Questionnaires",
            //    keyColumn: "Id",
            //    keyValue: 32,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1269), new DateTime(2023, 1, 5, 14, 5, 4, 188, DateTimeKind.Local).AddTicks(1270) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "TeacherStatus",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 190, DateTimeKind.Local).AddTicks(1040), new DateTime(2023, 1, 5, 14, 5, 4, 190, DateTimeKind.Local).AddTicks(1042) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "TeacherStatus",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 190, DateTimeKind.Local).AddTicks(1028), new DateTime(2023, 1, 5, 14, 5, 4, 190, DateTimeKind.Local).AddTicks(1037) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "TeacherStatus",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 190, DateTimeKind.Local).AddTicks(1043), new DateTime(2023, 1, 5, 14, 5, 4, 190, DateTimeKind.Local).AddTicks(1045) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "TeacherStatus",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 190, DateTimeKind.Local).AddTicks(1046), new DateTime(2023, 1, 5, 14, 5, 4, 190, DateTimeKind.Local).AddTicks(1048) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "Years",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 192, DateTimeKind.Local).AddTicks(190), new DateTime(2023, 1, 5, 14, 5, 4, 192, DateTimeKind.Local).AddTicks(199) });

            //migrationBuilder.UpdateData(
            //    schema: "LUData",
            //    table: "Years",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2023, 1, 5, 14, 5, 4, 192, DateTimeKind.Local).AddTicks(206), new DateTime(2023, 1, 5, 14, 5, 4, 192, DateTimeKind.Local).AddTicks(208) });
        }
    }
}
