using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2023TeacherProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
               name: "VideoUsefulness",
               schema: "EDI",
               table: "Questionnaires.Data.TeacherProfile",
               type: "tinyint",
               nullable: true);

            // Lookup Data
            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSets",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LookupName", "ModifiedBy", "ModifiedDate", "YearId" },
                values: new object[] { 119, "admin", new DateTime(2022, 12, 16, 15, 4, 3, 182, DateTimeKind.Local).AddTicks(6748), "TimesCompleted", "admin", new DateTime(2022, 12, 16, 15, 4, 3, 182, DateTimeKind.Local).AddTicks(6749), 3 });

            migrationBuilder.InsertData(
               schema: "LUData",
               table: "LookupSetOptions",
               columns: new[] { "Id", "CreatedBy", "CreatedDate", "English", "French", "LookupSetId", "ModifiedBy", "ModifiedDate", "Sequence", "Value", "YearId" },
               values: new object[] { 965, "admin", new DateTime(2022, 12, 16, 15, 4, 3, 182, DateTimeKind.Local).AddTicks(7466), "No previous experience", " No previous experience", 119, "admin", new DateTime(2022, 12, 16, 15, 4, 3, 182, DateTimeKind.Local).AddTicks(7467), (short)10, (short)1, 3 });

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSetOptions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "English", "French", "LookupSetId", "ModifiedBy", "ModifiedDate", "Sequence", "Value", "YearId" },
                values: new object[] { 966, "admin", new DateTime(2022, 12, 16, 15, 4, 3, 182, DateTimeKind.Local).AddTicks(7469), "1-2 times", "1-2 times", 119, "admin", new DateTime(2022, 12, 16, 15, 4, 3, 182, DateTimeKind.Local).AddTicks(7470), (short)20, (short)2, 3 });

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSetOptions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "English", "French", "LookupSetId", "ModifiedBy", "ModifiedDate", "Sequence", "Value", "YearId" },
                values: new object[] { 967, "admin", new DateTime(2022, 12, 16, 15, 4, 3, 182, DateTimeKind.Local).AddTicks(7472), "3 or more times", "3 or more times", 119, "admin", new DateTime(2022, 12, 16, 15, 4, 3, 182, DateTimeKind.Local).AddTicks(7474), (short)30, (short)3, 3 });

            // update the included provinces
            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration] SET Manitoba = 1, newyork = 0 WHERE yearid = 3 and questionnaireid = 33");

            // update the question type
            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration]  SET inputtypeid=31  WHERE id=1713");

            // remove highest level of education options 
            migrationBuilder.Sql("DELETE FROM [LUData].[LookupSetOptions] WHERE LookupSetId = 111 and id in(921, 925, 927, 929)");

            // update the text of this option
            migrationBuilder.Sql("UPDATE [LUData].[LookupSetOptions] SET English='Teaching certificate, diploma, or license' WHERE LookupSetId = 111 and id=922");

            // setup the 2023 questionnaire
            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration]  SET Sequence = Sequence + 1000 WHERE yearid = 3 and questionnaireid = 33 AND sequence > 10");

            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration] SET Manitoba = 1, newyork = 0 WHERE yearid = 3 and questionnaireid = 33");
            // demographics
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 20 WHERE ID = 1600 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET English = 'Do you identify as:', French = 'Vous identifiez-vous comme:', sequence = 30 WHERE ID = 1448 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 40 WHERE ID = 1507 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 50, GroupName = 'Demographics' WHERE ID = 1711 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 60, GroupName = 'Demographics' WHERE ID = 1539 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 70, GroupName = 'Demographics' WHERE ID = 1468 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 80, GroupName = 'Demographics' WHERE ID = 1470 and questionnaireid = 33");

            // experience
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 100 WHERE ID = 1604 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 110 WHERE ID = 1450 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 120, HasLookupEntity = 1, LookupEntity = 'LookupSets', LookupEntityId = 119, English = 'How many times have you completed the EDI?' WHERE ID = 1467 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 130, English = 'Have you ever received EDI teacher training?' WHERE ID = 1447 and questionnaireid = 33");
            migrationBuilder.Sql(" Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 140  WHERE ID = 1446 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 150, English = 'Did you find the EDI Guide or Help icons helpful?'  WHERE ID = 1508 and questionnaireid = 33");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NovaScotia]) VALUES(33,35,1,0,0,'Experience',0,Null,Null,Null,'Null','Did you find the EDI Training Video helpful?','Did you find the EDI Training Video helpful?','VideoUsefulness',1,'LookupSets',99,160,1,1,'NULL' ,0,'','',1,0,'null','','','','VideoUsefulness' ,3,1)");



            //move questions down 
            //migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration]  SET Sequence = Sequence + 10  WHERE yearid = 3 and questionnaireid = 33 AND sequence > 210");
            // insert header
            //migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NovaScotia]) VALUES(33,30,1,0,0,'Education',0,Null,Null,Null,'Null','','','Null',1,'LookupSets',113,220,5,1,'NULL' ,0,'','',0,0,'null','','','','Null' ,3,1)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                  schema: "LUData",
                  table: "LookupSetOptions",
                  keyColumn: "Id",
                  keyValue: 965);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DropColumn(
                name: "VideoUsefulness",
                schema: "EDI",
                table: "Questionnaires.Data.TeacherProfile");
        }
    }
}