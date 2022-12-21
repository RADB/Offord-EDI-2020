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

            migrationBuilder.AddColumn<string>(
           name: "TrainingOther",
           schema: "EDI",
           table: "Questionnaires.Data.TeacherProfile",
           type: "nvarchar(max)",
           nullable: true);

            // Lookup Data
            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSets",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LookupName", "ModifiedBy", "ModifiedDate", "YearId" },
                values: new object[] { 119, "admin", new DateTime(2022, 12, 16, 15, 4, 3, 182, DateTimeKind.Local).AddTicks(6748), "TimesCompleted", "admin", new DateTime(2022, 12, 16, 15, 4, 3, 182, DateTimeKind.Local).AddTicks(6749), 3 });

            migrationBuilder.InsertData(
                 schema: "LUData",
                 table: "LookupSets",
                 columns: new[] { "Id", "CreatedBy", "CreatedDate", "LookupName", "ModifiedBy", "ModifiedDate", "YearId" },
                 values: new object[] { 120, "admin", new DateTime(2022, 12, 16, 16, 36, 8, 808, DateTimeKind.Local).AddTicks(7562), "YesNoDidntUse", "admin", new DateTime(2022, 12, 16, 16, 36, 8, 808, DateTimeKind.Local).AddTicks(7564), 3 });

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

            migrationBuilder.InsertData(
               schema: "LUData",
               table: "LookupSetOptions",
               columns: new[] { "Id", "CreatedBy", "CreatedDate", "English", "French", "LookupSetId", "ModifiedBy", "ModifiedDate", "Sequence", "Value", "YearId" },
               values: new object[] { 968, "admin", new DateTime(2022, 12, 16, 16, 36, 8, 808, DateTimeKind.Local).AddTicks(8266), "Yes", "Oui", 120, "admin", new DateTime(2022, 12, 16, 16, 36, 8, 808, DateTimeKind.Local).AddTicks(8267), (short)10, (short)1, 3 });

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSetOptions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "English", "French", "LookupSetId", "ModifiedBy", "ModifiedDate", "Sequence", "Value", "YearId" },
                values: new object[] { 969, "admin", new DateTime(2022, 12, 16, 16, 36, 8, 808, DateTimeKind.Local).AddTicks(8269), "No", "Non", 120, "admin", new DateTime(2022, 12, 16, 16, 36, 8, 808, DateTimeKind.Local).AddTicks(8270), (short)20, (short)2, 3 });

            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSetOptions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "English", "French", "LookupSetId", "ModifiedBy", "ModifiedDate", "Sequence", "Value", "YearId" },
                values: new object[] { 970, "admin", new DateTime(2022, 12, 16, 16, 36, 8, 808, DateTimeKind.Local).AddTicks(8272), "Didn't Use", "Didn't Use", 120, "admin", new DateTime(2022, 12, 16, 16, 36, 8, 808, DateTimeKind.Local).AddTicks(8273), (short)30, (short)3, 3 });


            // update the question type
            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration]  SET inputtypeid=31  WHERE id=1713");

            // remove highest level of education options 
            migrationBuilder.Sql("DELETE FROM [LUData].[LookupSetOptions] WHERE LookupSetId = 111 and id in(921, 925, 927, 929)");

            // correct orientations data
            migrationBuilder.Sql("DELETE FROM[LUData].[Orientations] WHERE ID > 6");
            migrationBuilder.Sql("UPDATE[LUData].[Orientations] SET English = 'Vertical', French = 'Vertical' WHERE id = 5");
            migrationBuilder.Sql("UPDATE[LUData].[Orientations] SET English = 'Horizontal', French = 'Horizontal' WHERE id = 6");
            migrationBuilder.Sql("DBCC CHECKIDENT('[LUData].[Orientations]', Reseed,6)");

            // update the text of this option
            migrationBuilder.Sql("UPDATE [LUData].[LookupSetOptions] SET English='Teaching certificate, diploma, or license' WHERE LookupSetId = 111 and id=922");

            // setup the 2023 questionnaire
            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration]  SET Sequence = Sequence + 1000 WHERE yearid = 3 and questionnaireid = 33 AND sequence > 10");

            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration] SET Manitoba = 1, newyork = 0 WHERE yearid = 3 and questionnaireid = 33");
            // demographics
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 20, isrequired = 0 WHERE ID = 1600 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET English = 'Do you identify as:', French = 'Vous identifiez-vous comme:', sequence = 30 WHERE ID = 1448 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 40 WHERE ID = 1507 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 50, GroupName = 'Demographics' WHERE ID = 1711 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 60, GroupName = 'Demographics' WHERE ID = 1539 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 70, GroupName = 'Demographics' WHERE ID = 1468 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 80, GroupName = 'Demographics' WHERE ID = 1470 and questionnaireid = 33");

            // experience
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 100 WHERE ID = 1604 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 110 WHERE ID = 1450 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET InputTypeID = 31,sequence = 120, HasLookupEntity = 1, LookupEntity = 'LookupSets', LookupEntityId = 119, English = 'How many times have you completed the EDI?' WHERE ID = 1467 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 130, English = 'Have you ever received EDI teacher training?' WHERE ID = 1447 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 140  WHERE ID = 1446 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET OrientationId = 5,sequence = 150, LookupEntityId=120,English = 'Did you find the EDI Guide or Help icons helpful?',InputTypeID=31  WHERE ID = 1508 and questionnaireid = 33");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId) VALUES(33,31,5,0,0,'Experience',0,Null,Null,Null,'Null','Did you find the EDI Training Video helpful?','Did you find the EDI Training Video helpful?','VideoUsefulness',1,'LookupSets',120,160,1,1,'NULL' ,0,'','',1,0,'null','','','Questionnaires.Data.TeacherProfile','VideoUsefulness' ,3)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId) VALUES(33,29,5,0,0,'Experience',0,Null,Null,Null,'Null','Any additional comments about training, resources, etc.',' Tout commentaire supplémentaire sur la formation, les ressources, etc.','TrainingOther',0,'NULL',NULL,170,1,1,'NULL' ,0,'','',0,0,'null','','','Questionnaires.Data.TeacherProfile','TrainingOther' ,3)");

            //Pandemic  
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 200, GroupName = 'Pandemic', English = 'Impact of COVID-19 pandemic'  WHERE ID = 1714 and questionnaireid = 33");
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 210, GroupName = 'Pandemic' WHERE ID = 1712 and questionnaireid = 33");
            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration]  SET hashelp= 0, helptextEnglish=null, helptextFrench = null, inputtypeid = 31, sequence = 220, GroupName = 'Pandemic', isrequired = 0 WHERE id = 1713 and questionnaireid = 33");

            // since 2020
            migrationBuilder.Sql("Update[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = 300, GroupName = 'Since2020', English = 'GeneralDevelopment', isrequired = 0  WHERE ID = 1601 and questionnaireid = 33");
            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration]  SET sequence = sequence - 930, GroupName = 'Since2020' WHERE sequence > 1230 and questionnaireid = 33");

            //remove extra questions
            migrationBuilder.Sql("DELETE FROM [EDI.Service].[EDI].[Questionnaires.Configuration] WHERE sequence > 1000 and questionnaireid = 33");

            // update the included provinces
            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration] SET Ontario=1,Manitoba = 1, novascotia=1,NewfoundlandandLabrador=1,PrinceEdwardIsland=1,NorthwestTerritories=1,newyork = 0 WHERE yearid = 3 and questionnaireid = 33");



            var sp = @"USE[EDI.Service]
GO
/****** Object:  StoredProcedure [Reports].[GetTeacherDataBySite]    Script Date: 12/16/2022 5:30:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
--Author:		< Author,,Name >
--Create date: < Create Date,,>
--Description:	< Description,,>
-- =============================================
ALTER PROCEDURE[Reports].[GetTeacherDataBySite]
    -- Add the parameters for the stored procedure here

    @SiteId int
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.

    SET NOCOUNT ON;
            --declare @siteid int

    --set @Siteid = 925
    DECLARE @Columns NVARCHAR(MAX)

    DECLARE @SQL NVARCHAR(MAX)

    DECLARE @YearId INT
    DECLARE @Year NVARCHAR(4)

	SELECT @Year = fieldvalue FROM[dbo].[SystemConfigurations] WHERE FieldName = 'Year'


    SELECT @YearId = ID FROM[LUData].[Years] WHERE EDIYear = @Year

   -- get the columnnames from the config table
   SET @Columns = (SELECT
     ',[EDI].[' + [Config].[EntityName] + '].[' +  [EntityField] + '] as ' + [Config].[VariableName]--AS[data()]

    FROM[EDI].[Questionnaires.Configuration] config
   LEFT JOIN[EDI].[Questionnaires] q ON q.Id = config.QuestionnaireId

    WHERE config.EntityField is not null AND len(trim(config.EntityField)) > 0 AND Config.EntityField NOT IN('CompletedQuestions', 'requiredQuestions', 'isComplete', 'QuestionnaireID', 'LanguageCompleted', 'TrainingOther')
   -- add the next years questionnaire id

    AND config.QuestionnaireID IN(1,15,33) AND config.YearId = @YearId-- 1 is the teacher questionnaire
   FOR XML PATH(''))
	
	--PRINT @Columns

    --LEFT JOIN[LUData].[Years] y ON t.YearId = y.[Id]
   -- 2022 - 09 - 14 changed t.schoolid to sc.SchoolNumber
       SET @SQL = 'SELECT ' + CAST(@SiteId as varchar(4)) + ' as SiteId, sc.SchoolNumber, t.TeacherNumber,dbo.StripHTML([EDI].[Questionnaires.Data.TeacherProfile].[TrainingOther]) as TrainingOther ' + @Columns + '

    FROM[EDI].[Teachers] t
   LEFT JOIN[EDI].[Questionnaires.Data.TeacherProfile] ON[EDI].[Questionnaires.Data.TeacherProfile].teacherID = t.id

    LEFT JOIN[EDI].[Schools] sc ON t.SchoolId = sc.Id

    LEFT JOIN[EDI].[Sites] s ON sc.SiteId = s.Id

    WHERE s.SiteNumber = ' + CAST(@SiteId as varchar(4)) + ' AND t.YearId = ' + CAST(@YearId as varchar)

     --print @SQL

    EXEC sp_executesql @sql;
            END";

            //	Update the teacher data SP
            migrationBuilder.Sql(sp);


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

            migrationBuilder.DropColumn(
             name: "TrainingOther",
             schema: "EDI",
             table: "Questionnaires.Data.TeacherProfile");
        }
    }
}