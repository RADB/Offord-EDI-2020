using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2023NewFoundLand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /* github 169*/
            migrationBuilder.AddColumn<byte>(
                name: "AttendedNature",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET sequence = sequence +10 WHERE questionnaireid = 48 and yearid=3 and sequence >210");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(48,30,5,0,0,'NonParental3',0,Null,Null,Null,'Null','Attended Nature/Forest School Program','Attended Nature/Forest School Program','AttendedNature',1,'LookupSets',78,220,5,1,'NULL' ,0,'','',1,0,'null','','','Questionnaires.Data.SectionE','AttendedNature' ,3,1)");

            /* github 167*/
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

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSets",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LookupName", "ModifiedBy", "ModifiedDate", "YearId" },
                values: new object[,]
                {
                    { 121, "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(7614), "NFLDLanguageStatus", "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(7616), 3 },
                    { 122, "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(7618), "LanguageImmersion", "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(7620), 3 }
                });

            migrationBuilder.InsertData(
            schema: "LUData",
            table: "LookupSetOptions",
            columns: new[] { "Id", "CreatedBy", "CreatedDate", "English", "French", "LookupSetId", "ModifiedBy", "ModifiedDate", "Sequence", "Value", "YearId" },
            values: new object[,]
            {
                    { 971, "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(8390), "ESL", "ESL", 121, "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(8392), (short)10, (short)1, 3 },
                    { 972, "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(8394), "FSL", "FSL", 121, "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(8395), (short)20, (short)2, 3 },
                    { 973, "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(8397), "No", "Non", 121, "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(8398), (short)30, (short)3, 3 },
                    { 974, "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(8400), "French Immersion", "Immersion française", 122, "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(8402), (short)10, (short)1, 3 },
                    { 975, "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(8404), "Other Immersion", "Autre langue d’immersion", 122, "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(8405), (short)20, (short)2, 3 },
                    { 976, "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(8407), "No", "Non (aucune immersion)", 122, "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(8408), (short)30, (short)3, 3 }
            });

            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET NewfoundlandandLabrador=0 WHERE questionnaireid = 47 and yearid=3 and id in(1735,1740,1741)");
            

            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET LookupEntityId = 121 WHERE questionnaireid = 47 and yearid=3 and id =1733");
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET English='Does this child have Identified Exceptionalities' WHERE questionnaireid = 47 and yearid=3 and id =1731");
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET English='Language Immersion Program', VariableName='LanguageImmersion',EntityField='LanguageImmersion',lookupEntityId=122 WHERE questionnaireid = 47 and yearid=3 and id =1734");
     
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(47,31,5,0,0,'Languages',0,Null,Null,Null,Null,'Aboriginal Status:','Aboriginal Status:','AboriginalStatus',1,'LookupSets',78,150,5,1,'NULL' ,0,'','',1,0,'null','','','Questionnaires.Data.Demographics','AboriginalStatus' ,3,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(47,31,5,0,0,'Languages',0,Null,Null,Null,Null,'Child has immigrated to Canada within the last 2 years:','Child has immigrated to Canada within the last 2 years:','Immigrated',1,'LookupSets',78,220,5,1,'NULL' ,0,'','',1,0,'null','','','Questionnaires.Data.Demographics','Immigrated' ,3,1)");

            /* github 157 */
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET PrinceEdwardIsland=0 WHERE questionnaireid = 49 and yearid=3 and id in(1809,1810)");
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET NovaScotia=0 WHERE questionnaireid = 40 and yearid=3 and id in(1775,1776,1777,1864,1865,1866,1867,1868,1869,1870,1871,1872,1873,1778)");
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET NorthwestTerritories=0 WHERE questionnaireid = 34 and yearid=3 and id in(1782,1783,1784,1854,1855,1856,1857,1858,1859,1860,1861,1862,1863,1785)");
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET Ontario=0 WHERE questionnaireid = 43 and yearid=3 and id in(1786,1787,1788,1844,1845,1846,1847,1848,1849,1850,1851,1852,1853,1789)");


            /* github 196 */
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(48,34,5,0,0,'NonParental3',0,Null,Null,Null,Null,'Other/don''t know','Autre/ne sais pas','OtherCare',0,Null,Null,180,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE','OtherCare' ,3,1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
