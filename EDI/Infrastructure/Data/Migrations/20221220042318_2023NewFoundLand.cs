using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2023NewFoundLand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "AttendedNature",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);
    
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET sequence = sequence +10 WHERE questionnaireid = 48 and yearid=3 and sequence >210");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(48,30,5,0,0,'NonParental3',0,Null,Null,Null,'Null','Attended Nature/Forest School Program','Attended Nature/Forest School Program','AttendedNature',1,'LookupSets',78,220,5,1,'NULL' ,0,'','',1,0,'null','','','Questionnaires.Data.SectionE','AttendedNature' ,3,1)");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {         
        }
    }
}
