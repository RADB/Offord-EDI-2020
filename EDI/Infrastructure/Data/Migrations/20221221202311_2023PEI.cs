using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2023PEI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /* Github #158 */
            // remove existing questionnaire
            migrationBuilder.Sql("DELETE FROM [EDI.Service].[EDI].[Questionnaires.Configuration] WHERE yearid=3 and questionnaireid = 49");
            // start with NFLD
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork]) SELECT 49 as QuestionnaireID,[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],getDate() as [CreatedDate],'admin' as [CreatedBy],getDate() as [ModifiedDate],'admin' as [ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],0 as [NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],1 as [PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork] FROM[EDI].[Questionnaires.Configuration] WHERE YeariD = 3 and QuestionnaireId = 47 and NewfoundlandandLabrador = 1");

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSets",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LookupName", "ModifiedBy", "ModifiedDate", "YearId" },
                values: new object[] { 123, "admin", new DateTime(2022, 12, 21, 23, 47, 16, 944, DateTimeKind.Local).AddTicks(6677), "PEIClassType", "admin", new DateTime(2022, 12, 21, 23, 47, 16, 944, DateTimeKind.Local).AddTicks(6678), 3 });
                

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSetOptions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "English", "French", "LookupSetId", "ModifiedBy", "ModifiedDate", "Sequence", "Value", "YearId" },
                values: new object[,]
                {
                    { 977, "admin", new DateTime(2022, 12, 21, 23, 47, 16, 944, DateTimeKind.Local).AddTicks(7426), "JK", "JK", 123, "admin", new DateTime(2022, 12, 21, 23, 47, 16, 944, DateTimeKind.Local).AddTicks(7427), (short)10, (short)1, 3 },
                    { 978, "admin", new DateTime(2022, 12, 21, 23, 47, 16, 944, DateTimeKind.Local).AddTicks(7429), "SK", "SK", 123, "admin", new DateTime(2022, 12, 21, 23, 47, 16, 944, DateTimeKind.Local).AddTicks(7430), (short)20, (short)2, 3 },
                    { 979, "admin", new DateTime(2022, 12, 21, 23, 47, 16, 944, DateTimeKind.Local).AddTicks(7432), "JK/SK", "JK/SK", 123, "admin", new DateTime(2022, 12, 21, 23, 47, 16, 944, DateTimeKind.Local).AddTicks(7434), (short)30, (short)3, 3 },
                    { 980, "admin", new DateTime(2022, 12, 21, 23, 47, 16, 944, DateTimeKind.Local).AddTicks(7435), "JK/SK/q", "JK/SK/q", 123, "admin", new DateTime(2022, 12, 21, 23, 47, 16, 944, DateTimeKind.Local).AddTicks(7437), (short)40, (short)4, 3 },
                    { 981, "admin", new DateTime(2022, 12, 21, 23, 47, 16, 944, DateTimeKind.Local).AddTicks(7439), "SK/1", "SK/1", 123, "admin", new DateTime(2022, 12, 21, 23, 47, 16, 944, DateTimeKind.Local).AddTicks(7440), (short)50, (short)5, 3 },
                    { 982, "admin", new DateTime(2022, 12, 21, 23, 47, 16, 944, DateTimeKind.Local).AddTicks(7442), "Other", "Other", 123, "admin", new DateTime(2022, 12, 21, 23, 47, 16, 944, DateTimeKind.Local).AddTicks(7443), (short)60, (short)6, 3 }
                });

            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET LookupEntityId=86 WHERE id=1887 AND QuestionnaireID=49 AND YearID=3");
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET LookupEntityId=123 WHERE id=1890 AND QuestionnaireID=49 AND YearID=3");
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET English='Exceptional / Special Needs', French='Exceptional / Special Needs' WHERE id=1891 AND QuestionnaireID=49 AND YearID=3");
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET English='Child considered EAL/FAL', French='Child considered EAL/FAL', lookupentityid=77 WHERE id=1893 AND QuestionnaireID=49 AND YearID=3");

            /* Github #159 */
            migrationBuilder.AddColumn<bool>(
               name: "CentreBasedLicensed",
               schema: "EDI",
               table: "Questionnaires.Data.SectionE",
               type: "bit",
               nullable: true);

            migrationBuilder.AddColumn<bool>(
               name: "HomeUnlicensedNonRelative",
               schema: "EDI",
               table: "Questionnaires.Data.SectionE",
               type: "bit",
               nullable: true);

            migrationBuilder.AddColumn<bool>(
               name: "Relative",
               schema: "EDI",
               table: "Questionnaires.Data.SectionE",
               type: "bit",
               nullable: true);
 
        migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET English='Has this child been in non - parental care on a regular basis prior to kindergarten entry?<br/>Note: ''Regular'' refers to consistent basis, full or part time, for greater than 6 months.', French='Has this child been in non - parental care on a regular basis prior to kindergarten entry?<br/>Note: ''Regular'' refers to consistent basis, full or part time, for greater than 6 months.' WHERE id=1823 AND QuestionnaireID=50 AND YearID=3");
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET Manitoba=0 WHERE questionnaireid = 50 and yearid=3 and id in(1826,1827,1828)");
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET sequence = sequence +10 WHERE Sequence >100 AND Yearid=3 AND QuestionnaireID=50");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,Manitoba) VALUES(50,34,5,0,0,'NonParental2',0,Null,Null,Null,'Null','Centre-based, licensed','Centre-based, licensed','CentreBasedLicensed',0,'Null',Null,110,1,1,'Null' ,0,'','',1,0,'Null','','','Questionnaires.Data.SectionE','CentreBasedLicensed' ,3,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,Manitoba) VALUES(50,34,5,0,0,'NonParental2',0,Null,Null,Null,'Null','Other Home-based, licensed','Other Home-based, licensed','OtherHomeLicensed',0,'Null',Null,120,1,1,'Null' ,0,'','',1,0,'Null','','','Questionnaires.Data.SectionE','OtherHomeLicensed' ,3,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,Manitoba) VALUES(50,34,5,0,0,'NonParental2',0,Null,Null,Null,'Null','Home-based, unlicensed, non-relative','Home-based, unlicensed, non-relative','HomeLicensedNonRelative',0,'Null',Null,130,1,1,'Null' ,0,'','',1,0,'Null','','','Questionnaires.Data.SectionE','HomeLicensedNonRelative' ,3,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,Manitoba) VALUES(50,34,5,0,0,'NonParental2',0,Null,Null,Null,'Null','Relative','Relative','Relative',0,'Null',Null,140,1,1,'Null' ,0,'','',1,0,'Null','','','Questionnaires.Data.SectionE','Relative' ,3,1)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
              name: "CentreBasedLicensed",
              schema: "EDI",
              table: "Questionnaires.Data.SectionE");
            migrationBuilder.DropColumn(
              name: "HomeUnlicensedNonRelative",
              schema: "EDI",
              table: "Questionnaires.Data.SectionE");
            migrationBuilder.DropColumn(
              name: "Relative",
              schema: "EDI",
              table: "Questionnaires.Data.SectionE");
        }
    }
}
