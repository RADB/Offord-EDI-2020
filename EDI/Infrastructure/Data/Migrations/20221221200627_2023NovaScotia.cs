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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
