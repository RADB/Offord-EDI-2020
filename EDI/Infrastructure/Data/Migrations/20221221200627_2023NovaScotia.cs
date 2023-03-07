using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2023NovaScotia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /* Github #166 */
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET English ='Child''s language status:',French ='Child''s language status:', LookupEntityId = 121 WHERE questionnaireid = 40 and yearid=3 and id =1437");
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET English='Language Immersion Program',French='Language Immersion Program', VariableName='LanguageImmersion',EntityField='LanguageImmersion',lookupEntityId=122 WHERE questionnaireid = 40 and yearid=3 and id =1438");

            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET NovaScotia=0 WHERE questionnaireid = 40 and yearid=3 and id = 1439");

            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,NovaScotia) VALUES(40,31,5,0,0,'Languages',0,Null,Null,Null,'Null','Child has immigrated to Canada within the last 2 years:','Child has immigrated to Canada within the last 2 years:','Immigrated',1,'LookupSets',78,230,5,1,'NULL' ,0,'','',1,0,'null','','','Questionnaires.Data.Demographics','Immigrated' ,3,1)");

            migrationBuilder.InsertData(
              schema: "LUData",
              table: "LookupSets",
              columns: new[] { "Id", "CreatedBy", "CreatedDate", "LookupName", "ModifiedBy", "ModifiedDate", "YearId" },
              values: new object[,]
              {
                    { 126, "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(7614), "NSLanguageStatus", "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(7616), 3 }
              });

            migrationBuilder.InsertData(
       schema: "LUData",
       table: "LookupSetOptions",
       columns: new[] { "Id", "CreatedBy", "CreatedDate", "English", "French", "LookupSetId", "ModifiedBy", "ModifiedDate", "Sequence", "Value", "YearId" },
       values: new object[,]
       {
                    { 989, "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(8390), "ESL", "ALS", 126, "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(8392), (short)10, (short)1, 3 },
                    { 990, "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(8394), "FSL", "FLS", 126, "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(8395), (short)20, (short)2, 3 },
                    { 991, "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(8397), "No", "Non", 126, "admin", new DateTime(2022, 12, 21, 13, 56, 34, 119, DateTimeKind.Local).AddTicks(8398), (short)30, (short)3, 3 }                    
       });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
