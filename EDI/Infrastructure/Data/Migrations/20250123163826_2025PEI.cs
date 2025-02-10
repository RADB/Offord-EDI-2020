using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2025PEI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "ParentalEngagement",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);
           
            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSets",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LookupName", "ModifiedBy", "ModifiedDate", "YearId" },
                values: new object[] { 243, "admin", new DateTime(2025, 1, 23, 11, 38, 24, 765, DateTimeKind.Local).AddTicks(3558), "ParentalEngagement", "admin", new DateTime(2025, 1, 23, 11, 38, 24, 765, DateTimeKind.Local).AddTicks(3561), 5 });
                        
            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSetOptions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "English", "French", "LookupSetId", "ModifiedBy", "ModifiedDate", "Sequence", "Value", "YearId" },
                values: new object[] { 1966, "admin", new DateTime(2025, 1, 23, 11, 38, 24, 765, DateTimeKind.Local).AddTicks(4779), "Too Low", "Trop bas", 243, "admin", new DateTime(2025, 1, 23, 11, 38, 24, 765, DateTimeKind.Local).AddTicks(4782), (short)10, (short)1, 5 });

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSetOptions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "English", "French", "LookupSetId", "ModifiedBy", "ModifiedDate", "Sequence", "Value", "YearId" },
                values: new object[] { 1967, "admin", new DateTime(2025, 1, 23, 11, 38, 24, 765, DateTimeKind.Local).AddTicks(4785), "Adequate", "Adéquat", 243, "admin", new DateTime(2025, 1, 23, 11, 38, 24, 765, DateTimeKind.Local).AddTicks(4788), (short)20, (short)2, 5 });

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSetOptions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "English", "French", "LookupSetId", "ModifiedBy", "ModifiedDate", "Sequence", "Value", "YearId" },
                values: new object[] { 1968, "admin", new DateTime(2025, 1, 23, 11, 38, 24, 765, DateTimeKind.Local).AddTicks(4791), "Too High", "Trop haut", 243, "admin", new DateTime(2025, 1, 23, 11, 38, 24, 765, DateTimeKind.Local).AddTicks(4794), (short)30, (short)3, 5 });

            // move everything down
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET sequence = sequence +30 WHERE Sequence >210 AND Yearid=5 AND QuestionnaireID=97");

            // github #259 - insert question
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[PrinceEdwardIsland]) VALUES(97,67,9,1,0,'NonParental4',1,Null,Null,Null,'Null','','','NULL',0,'NULL',NULL,220,1,1,'1' ,0,'','',0,0,'null','','','Questionnaires.Data.SectionE','NULL' ,5,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[PrinceEdwardIsland]) VALUES(97,58,9,1,0,'NonParental4',0,Null,Null,Null,'Null','To the best of your knowledge','D’après vos connaissances','NULL',1,'LookupSets',243,230,5,1,'NULL' ,0,'','',0,0,'null','','','Questionnaires.Data.SectionE','NULL' ,5,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[PrinceEdwardIsland]) VALUES(97,58,9,0,0,'NonParental4',0,Null,Null,Null,'Null',' For this child’s needs, the amount of parental engagement is:','Pour les besoins de cet enfant, le montant de l’engagement parental est de :','ParentalEngagement',1,'LookupSets',243,240,5,1,'NULL' ,1,'<table><tr><tr> <td>  Engagement is too low </td> <td>  Parental engagement is absent or not enough to support this child.  Child''s parent(s)/guardian(s) rarely or never engage with classroom teacher. </td></tr> <td>  Engagement is adequate </td> <td>  Parental engagement is appropriate for supporting this child.  Child''s parent(s)/guardian(s) regularly engage with classroom teacher. </td></tr><tr> <td>  Engagement is too high </td> <td>  Parental engagement is too strong for supporting this child.  Child''s parent(s)/guardian(s) engage with classroom teacher much more regularly than is required. </td></tr></table>','<table><tr><tr> <td>  Engagement is too low </td> <td>  Parental engagement is absent or not enough to support this child.  Child''s parent(s)/guardian(s) rarely or never engage with classroom teacher. </td></tr> <td>  Engagement is adequate </td> <td>  Parental engagement is appropriate for supporting this child.  Child''s parent(s)/guardian(s) regularly engage with classroom teacher. </td></tr><tr> <td>  Engagement is too high </td> <td>  Parental engagement is too strong for supporting this child.  Child''s parent(s)/guardian(s) engage with classroom teacher much more regularly than is required. </td></tr></table>',1,0,'null','','','Questionnaires.Data.SectionE','ParentalEngagement' ,5,1)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 1966);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 1967);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 1968);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DropColumn(
                name: "ParentalEngagement",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            
        }
    }
}
