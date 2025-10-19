using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;
using EDI.ApplicationCore.Entities;
using Humanizer;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Newtonsoft.Json;
using static Humanizer.In;
using static Humanizer.On;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2026MFCN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "MCFN",
                schema: "LUData",
                table: "Years",
                type: "bit",
                nullable: true);

            // add default value to first nations column
            migrationBuilder.Sql(
                "ALTER TABLE [EDI].[Questionnaires.Configuration] ADD CONSTRAINT DF_Questionnaires_Configuration_FirstNations DEFAULT 0 FOR [FirstNations]");

            migrationBuilder.AddColumn<bool>(
                name: "MCFN",
                schema: "EDI",
                table: "Questionnaires.Configuration",
                type: "bit",
                nullable: true,
                defaultValueSql: "((0))");

            migrationBuilder.AddColumn<bool>(
                name: "MCFN",
                schema: "EDI",
                table: "Questionnaires",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MCFN",
                schema: "EDI",
                table: "NewsFeed",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MCFN",
                schema: "EDI",
                table: "Links",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MCFN",
                schema: "EDI",
                table: "FAQ",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "ResistsTransitions",
                schema: "EDI",
                table: "Questionnaires.Data.SectionC",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "EarlyTransitions",
                schema: "EDI",
                table: "Questionnaires.Data.SectionA",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
               name: "MCFNActivities",
               schema: "EDI",
               table: "Questionnaires.Data.SectionE",
               type: "tinyint",
               nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "MCFNCare",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "MCFNCommunicates",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "MCFNCreate",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "MCFNDrumming",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "MCFNIdentify",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "MCFNImaginative",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "MCFNImprove",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "MCFNInitiative",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "MCFNInterest",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "MCFNLearning",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "MCFNQuestions",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "MCFNReplaces",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "MCFNRespond",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "MCFNSeeksInfo",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "MCFNSpeaking",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "MCFNStewardship",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "MCFNWears",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);
            // update initialization stored procedure
            var sp = @"USE [EDI.Service]
GO
/****** Object:  StoredProcedure [dbo].[InitializeNewYear]    Script Date: 9/24/2025 11:33:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[InitializeNewYear]	
	@OldYear int, 
	@NewYear int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	Declare @OldYearId int
	DECLARE @NewYearId int
	
	IF NOT EXISTS (SELECT * FROM [LUData].[Years] WHERE Ediyear = @OldYear)                   
	BEGIN
		PRINT 'The old year does not exist.  Please specify the correct year to migrate from.'
	END
	ELSE
	BEGIN
		IF NOT EXISTS (SELECT * FROM [LUData].[Years] WHERE Ediyear = @NewYear)                   
		BEGIN    
			INSERT INTO [LUData].[Years]([Ediyear],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy])VALUES(@NewYear,CURRENT_TIMESTAMP,'Admin',CURRENT_TIMESTAMP,'Admin')
		END

		-- get the year ids
		SELECT @OldYearID=id FROM [LUData].[Years] WHERE Ediyear = @OldYear
		SELECT @NewYearID=id FROM [LUData].[Years] WHERE Ediyear = @NewYear	

        -- get the count of questionnaires -- 2026 added 6 2025 after so need to add 6 additional in 2027 only then it will be fine again
        DECLARE @Questionnaires int
        IF @OldYear = 2026
	        SELECT @Questionnaires = count(1) + 6 FROM [EDI].[Questionnaires] WHERE YearID = @OldYearId
        ELSE
	        SELECT @Questionnaires = count(1) FROM [EDI].[Questionnaires] WHERE YearID = @OldYearId

		-- get the count of lookupsets to add to the ids
		DECLARE @LookupSets int
        IF @OldYear = 2026
            SELECT @LookupSets = count(1) + 1 FROM [EDI.Service].[LUData].[LookupSets] WHERE YearID = @OldYearId
        ELSE
		    SELECT @LookupSets = count(1) FROM [EDI.Service].[LUData].[LookupSets] WHERE YearID = @OldYearId

		DECLARE @Countries int
		SELECT @Countries = count(1) FROM [EDI.Service].[LUData].[Countries] WHERE YearID = @OldYearId

        DECLARE @InputTypes int
        SELECT @InputTypes = count(1) FROM [EDI.Service].[LUData].[InputTypes] WHERE YearID = @OldYearId

        DECLARE @Orientations int
        SELECT @Orientations = count(1) FROM [EDI.Service].[LUData].[Orientations] WHERE YearID = @OldYearId

		-- insert the questionnaires - set the yearid to copy - set the year id 
		INSERT INTO [EDI.Service].[EDI].[Questionnaires] ([YearId],[QuestionnaireName],[English],[French],[DescriptionEnglish],[DescriptionFrench],[ShowProgressBar],[EntityName],[ShowQuestionNumbers],[Sequence],[IsChildQuestionnaire],[IsTeacherQuestionnaire],[QuestionsRequired],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork], [FirstNations],[MCFN]) 
		SELECT @NewYearId,[QuestionnaireName],[English],[French],[DescriptionEnglish],[DescriptionFrench],[ShowProgressBar],[EntityName],[ShowQuestionNumbers],[Sequence],[IsChildQuestionnaire],[IsTeacherQuestionnaire],[QuestionsRequired],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],  [FirstNations],[MCFN] FROM [EDI.Service].[EDI].[Questionnaires] WHERE Yearid = @OldYearId

		--Insert the countries
		INSERT INTO [EDI.Service].[LUData].[Countries] ([Code],[English],[French],[ISO2CountryCode],[ISO3CountryCode],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[YearId])
		SELECT [Code],[English],[French],[ISO2CountryCode],[ISO3CountryCode],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],@NewYearId FROM [EDI.Service].[LUData].[Countries] WHERE YeariD = @OldYearId

		--Insert the provinces
		INSERT INTO [EDI.Service].[LUData].[Provinces]([English],[French],[Code],[EDICode],[CountryID],[ProvinceTypeId],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[YearId])
		SELECT [English],[French],[Code],[EDICode],[CountryID]+@Countries,[ProvinceTypeId],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],@NewYearId FROM [EDI.Service].[LUData].[Provinces] WHERE YeariD = @OldYearId

		--Insert the Genders
		INSERT INTO [EDI.Service].[LUData].[Genders] ([Code],[English],[French],[Sequence],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[YearId])
		SELECT [Code],[English],[French],[Sequence],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],@NewYearId FROM [EDI.Service].[LUData].[Genders] WHERE YearId = @OldYearId

		--Insert the input types
		INSERT INTO [EDI.Service].[LUData].[InputTypes] ([YearId],[English],[French],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy])
		SELECT @NewYearId,[English],[French],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy] FROM [EDI.Service].[LUData].[InputTypes] WHERE YeariD = @OldYearId

        --Insert the orientations
		INSERT INTO [EDI.Service].[LUData].[Orientations] ([YearId],[English],[French],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy])
		SELECT @NewYearId,[English],[French],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy] FROM [EDI.Service].[LUData].[Orientations] WHERE YeariD = @OldYearId

		-- insert the lookupsets
		INSERT INTO [EDI.Service].[LUData].[LookupSets] ([YearId],[LookupName],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy] )
		SELECT @NewYearId,[LookupName],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy] FROM [EDI.Service].[LUData].[LookupSets] WHERE YeariD = @OldYearId

		-- insert the lookupsetoptions - adds the count of oldyear to the id
		INSERT INTO [EDI.Service].[LUData].[LookupSetOptions] ([LookupSetId],[English],[French],[Value],[Sequence],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[YearId]) 
		SELECT [LookupSetId]+@LookupSets,[English],[French],[Value],[Sequence],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],@NewYearId FROM [EDI.Service].[LUData].[LookupSetOptions] WHERE YeariD = @OldYearId

		INSERT INTO [EDI].[FAQ] ([YearId],[Question],[Answer],[IsTeacherFaq],[IsAdministratorFaq],[IsCoordinatorFaq],[Sequence],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork], [FirstNations],[MCFN])
		SELECT @NewYearID,[Question],[Answer],[IsTeacherFaq],[IsAdministratorFaq],[IsCoordinatorFaq],[Sequence],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork], [FirstNations],[MCFN] FROM [EDI].[FAQ] WHERE Yearid = @OldYearId

        UPDATE [dbo].[SystemConfigurations] SET FieldValue = @NewYear WHERE FieldName = 'Year'

		-- insert the questionnaire configurations into the table -- - adds the count of oldyear to the id
    	INSERT INTO [EDI.Service].[EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork], [FirstNations],[MCFN])
		SELECT [QuestionnaireId]+@Questionnaires,[InputTypeId]+@InputTypes,[OrientationId]+@Orientations,[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId]+@LookupSets,[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],@NewYearId,[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork], [FirstNations],[MCFN] FROM [EDI.Service].[EDI].[Questionnaires.Configuration] WHERE YeariD = @OldYearId
		
		--PRINT 'UPDATE LOOKUPSETOPTIONS FOR THE 3 Gender Values. value+3  (Gender, TeacherGender,ChildGender'		
		--SELECT id, 'Update these gender values in LookupSetOptions' from [LUData].[LookupSets] WHERE LookupName in ('Gender', 'TeacherGender','ChildGender') and yearID = @NewYearId
		--Update the gender options in lookupset options
		UPDATE [LUData].[LookupSetOptions] SET [value] = [value]+3 
		WHERE LookupsetID IN(SELECT id from [LUData].[LookupSets] WHERE LookupName in ('Gender', 'TeacherGender','ChildGender') and yearID = @NewYearId)
    END
END
";
            // alter the stored procedure for initiallization
            migrationBuilder.Sql(sp);

            // add MCFN to this years options
            migrationBuilder.Sql("UPDATE [LUData].[Years] SET [MCFN]=1 WHERE ID IN (5,6)");
            
            // add MCFN to the provinces 
            migrationBuilder.Sql("INSERT INTO [LUData].[Provinces]([English],[French],[Code],[EDICode],[CountryID],[ProvinceTypeId],[CreatedBy],[CreatedDate],[ModifiedBy],[ModifiedDate],[YearId]) VALUES('MCFN', 'MCFN', 'MCFN', 25, 1180, 6, 'Andrew@Renner.ca', getDate(), 'Andrew@Renner.ca', getDate(), 5)");
            migrationBuilder.Sql("INSERT INTO [LUData].[Provinces]([English],[French],[Code],[EDICode],[CountryID],[ProvinceTypeId],[CreatedBy],[CreatedDate],[ModifiedBy],[ModifiedDate],[YearId]) VALUES('MCFN', 'MCFN', 'MCFN', 25, 1420, 6, 'Andrew@Renner.ca', getDate(), 'Andrew@Renner.ca', getDate(), 6)");

            // add the lookup sets for Section E
            migrationBuilder.Sql("INSERT INTO [LUData].[LookupSets] (LookupName,YearID,CreatedBy, CreatedDate, ModifiedBy,ModifiedDate) VALUES ('MCFNInterests',5 ,'Andrew@Renner.ca',getDate(),'Andrew@Renner.ca',getDate())");
            
            migrationBuilder.Sql("INSERT INTO [LUData].[LookupSetOptions] (LookupSetID,English,French,Value,Sequence,YearID,CreatedBy, CreatedDate, ModifiedBy,ModifiedDate) VALUES (301,'Initiates','Initiates',1,10,5,'Andrew@Renner.ca',getDate(),'Andrew@Renner.ca',getDate())");
            migrationBuilder.Sql("INSERT INTO [LUData].[LookupSetOptions] (LookupSetID,English,French,Value,Sequence,YearID,CreatedBy, CreatedDate, ModifiedBy,ModifiedDate) VALUES (301,'Participates','Participates',2,20,5,'Andrew@Renner.ca',getDate(),'Andrew@Renner.ca',getDate())");
            migrationBuilder.Sql("INSERT INTO [LUData].[LookupSetOptions] (LookupSetID,English,French,Value,Sequence,YearID,CreatedBy, CreatedDate, ModifiedBy,ModifiedDate) VALUES (301,'Both','Both',3,30,5,'Andrew@Renner.ca',getDate(),'Andrew@Renner.ca',getDate())");
            migrationBuilder.Sql("INSERT INTO [LUData].[LookupSetOptions] (LookupSetID,English,French,Value,Sequence,YearID,CreatedBy, CreatedDate, ModifiedBy,ModifiedDate) VALUES (301,'Neither','Neither',4,40,5,'Andrew@Renner.ca',getDate(),'Andrew@Renner.ca',getDate())");
            migrationBuilder.Sql("INSERT INTO [LUData].[LookupSetOptions] (LookupSetID,English,French,Value,Sequence,YearID,CreatedBy, CreatedDate, ModifiedBy,ModifiedDate) VALUES (301,'Don''t Know','Don''t Know',5,50,5,'Andrew@Renner.ca',getDate(),'Andrew@Renner.ca',getDate())");

            migrationBuilder.Sql("INSERT INTO [LUData].[LookupSets] (LookupName,YearID,CreatedBy, CreatedDate, ModifiedBy,ModifiedDate) VALUES ('MCFNInterests',6 ,'Andrew@Renner.ca',getDate(),'Andrew@Renner.ca',getDate())");

            migrationBuilder.Sql("INSERT INTO [LUData].[LookupSetOptions] (LookupSetID,English,French,Value,Sequence,YearID,CreatedBy, CreatedDate, ModifiedBy,ModifiedDate) VALUES (302,'Initiates','Initiates',1,10,6,'Andrew@Renner.ca',getDate(),'Andrew@Renner.ca',getDate())");
            migrationBuilder.Sql("INSERT INTO [LUData].[LookupSetOptions] (LookupSetID,English,French,Value,Sequence,YearID,CreatedBy, CreatedDate, ModifiedBy,ModifiedDate) VALUES (302,'Participates','Participates',2,20,6,'Andrew@Renner.ca',getDate(),'Andrew@Renner.ca',getDate())");
            migrationBuilder.Sql("INSERT INTO [LUData].[LookupSetOptions] (LookupSetID,English,French,Value,Sequence,YearID,CreatedBy, CreatedDate, ModifiedBy,ModifiedDate) VALUES (302,'Both','Both',3,30,6,'Andrew@Renner.ca',getDate(),'Andrew@Renner.ca',getDate())");
            migrationBuilder.Sql("INSERT INTO [LUData].[LookupSetOptions] (LookupSetID,English,French,Value,Sequence,YearID,CreatedBy, CreatedDate, ModifiedBy,ModifiedDate) VALUES (302,'Neither','Neither',4,40,6,'Andrew@Renner.ca',getDate(),'Andrew@Renner.ca',getDate())");
            migrationBuilder.Sql("INSERT INTO [LUData].[LookupSetOptions] (LookupSetID,English,French,Value,Sequence,YearID,CreatedBy, CreatedDate, ModifiedBy,ModifiedDate) VALUES (302,'Don''t Know','Don''t Know',5,50,6,'Andrew@Renner.ca',getDate(),'Andrew@Renner.ca',getDate())");

            //remove 3rd option from class assignment -- DEMOGRAPHICS 
            migrationBuilder.Sql("DELETE FROM [LUData].[LookupSetOptions] WHERE ID IN(2451, 1965)");

            // TODO update the queries to include MCFN in exports


            // start with FirstNations - Create all questionnaires Demo A-E and Teacher (7 in total) - create MCFN for 2025 and 2026
            // 2026 128-134
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires] ([YearId],[QuestionnaireName],[English],[French],[DescriptionEnglish],[DescriptionFrench],[ShowProgressBar],[EntityName],[ShowQuestionNumbers],[Sequence],[IsChildQuestionnaire],[IsTeacherQuestionnaire],[QuestionsRequired],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],[FirstNations],[MCFN]) SELECT [YearId],[QuestionnaireName],[English],[French],[DescriptionEnglish],[DescriptionFrench],[ShowProgressBar],[EntityName],[ShowQuestionNumbers],[Sequence],[IsChildQuestionnaire],[IsTeacherQuestionnaire],[QuestionsRequired],getDate() as [CreatedDate],[CreatedBy],getDate() as [ModifiedDate],[ModifiedBy],0 as [Alberta],0 as [BritishColumbia],0 as [Manitoba],0 as [NewBrunswick],0 as [NewfoundlandandLabrador],0 as [NovaScotia],0 as [Nunavut],0 as [Ontario],0 as [PrinceEdwardIsland],0 as [Quebec],0 as [Saskatchewan],0 as [YukonTerritory],0 as [NorthwestTerritories],0 as [NewYork], 0 as [FirstNations],1 as MCFN FROM [EDI].[Questionnaires] WHERE Yearid=6 AND FirstNations=1");
            // 2025 135-141
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires] ([YearId],[QuestionnaireName],[English],[French],[DescriptionEnglish],[DescriptionFrench],[ShowProgressBar],[EntityName],[ShowQuestionNumbers],[Sequence],[IsChildQuestionnaire],[IsTeacherQuestionnaire],[QuestionsRequired],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],[FirstNations],[MCFN]) SELECT [YearId],[QuestionnaireName],[English],[French],[DescriptionEnglish],[DescriptionFrench],[ShowProgressBar],[EntityName],[ShowQuestionNumbers],[Sequence],[IsChildQuestionnaire],[IsTeacherQuestionnaire],[QuestionsRequired],getDate() as [CreatedDate],[CreatedBy],getDate() as [ModifiedDate],[ModifiedBy],0 as [Alberta],0 as [BritishColumbia],0 as [Manitoba],0 as [NewBrunswick],0 as [NewfoundlandandLabrador],0 as [NovaScotia],0 as [Nunavut],0 as [Ontario],0 as [PrinceEdwardIsland],0 as [Quebec],0 as [Saskatchewan],0 as [YukonTerritory],0 as [NorthwestTerritories],0 as [NewYork], 0 as [FirstNations],1 as MCFN FROM [EDI].[Questionnaires] WHERE Yearid=5 AND FirstNations=1");

            // NO CHANGES TO TEACHER 
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],[FirstNations],[MCFN]) SELECT 128 as QuestionnaireID,[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],getDate() as [CreatedDate],'admin' as [CreatedBy],getDate() as [ModifiedDate],'admin' as [ModifiedBy],0 as [Alberta],0 as [BritishColumbia],0 as [Manitoba],0 as [NewBrunswick],0 as [NewfoundlandandLabrador],0 as [NovaScotia],0 as [Nunavut],0 as [Ontario],0 as [PrinceEdwardIsland],0 as [Quebec],0 as [Saskatchewan],0 as [YukonTerritory],0 as [NorthwestTerritories],0 as [NewYork], 0 as [FirstNations], [FirstNations] as MCFN FROM[EDI].[Questionnaires.Configuration] WHERE YeariD = 6 and QuestionnaireId = 104");
            
            // SECTION A
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],[FirstNations],[MCFN]) SELECT 129 as QuestionnaireID,[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],getDate() as [CreatedDate],'admin' as [CreatedBy],getDate() as [ModifiedDate],'admin' as [ModifiedBy],0 as [Alberta],0 as [BritishColumbia],0 as [Manitoba],0 as [NewBrunswick],0 as [NewfoundlandandLabrador],0 as [NovaScotia],0 as [Nunavut],0 as [Ontario],0 as [PrinceEdwardIsland],0 as [Quebec],0 as [Saskatchewan],0 as [YukonTerritory],0 as [NorthwestTerritories],0 as [NewYork], 0 as [FirstNations], [FirstNations] as MCFN FROM[EDI].[Questionnaires.Configuration] WHERE YeariD = 6 and QuestionnaireId = 106");
                // remove QA5 Hungry
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET MCFN = 0 WHERE ID IN (4863)");
                // update QA9
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'ability to hold a pen, crayons, or brush' WHERE ID = (4865)");
                // INSERT QA14
                migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[MCFN]) VALUES(129,72,11,0,0,'Rating',0,Null,Null,Null,null,'easily transitions from one activity to another throughout the day','','Qa14',1,'LookupSets',246,245,4,1,'14' ,0,'','',1,0,null,'','','Questionnaires.Data.SectionA','EarlyTransitions' ,6,1)");                

            // SECTION B
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],[FirstNations],[MCFN]) SELECT 130 as QuestionnaireID,[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],getDate() as [CreatedDate],'admin' as [CreatedBy],getDate() as [ModifiedDate],'admin' as [ModifiedBy],0 as [Alberta],0 as [BritishColumbia],0 as [Manitoba],0 as [NewBrunswick],0 as [NewfoundlandandLabrador],0 as [NovaScotia],0 as [Nunavut],0 as [Ontario],0 as [PrinceEdwardIsland],0 as [Quebec],0 as [Saskatchewan],0 as [YukonTerritory],0 as [NorthwestTerritories],0 as [NewYork], 0 as [FirstNations], [FirstNations] as MCFN FROM[EDI].[Questionnaires.Configuration] WHERE YeariD = 6 and QuestionnaireId = 107");
                //QB3 Guide
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET HelpTextEnglish= '<p><b>3. ability to tell a story</b></p><ul><li>Refers to the child’s skill in retelling a story heard before, using appropriate vocabulary in matching events with words.</li><li>Retells experiences to other children or adults about discoveries or experiences that they encountered on the land</li></ul>' WHERE ID = (4892)");
                //qb15
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'shows interest in reading simple words' WHERE ID = (4905)");
                //qb16
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'shows interest in reading complex words' WHERE ID = (4906)");
                //qb17
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'shows interest in reading simple sentences' WHERE ID = (4907)");
                //qb22
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'shows an interest in writing simple words' WHERE ID = (4912)");
                //qb23
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'shows an interest in writing simple sentences' WHERE ID = (4913)");

            // SECTION C
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],[FirstNations],[MCFN]) SELECT 131 as QuestionnaireID,[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],getDate() as [CreatedDate],'admin' as [CreatedBy],getDate() as [ModifiedDate],'admin' as [ModifiedBy],0 as [Alberta],0 as [BritishColumbia],0 as [Manitoba],0 as [NewBrunswick],0 as [NewfoundlandandLabrador],0 as [NovaScotia],0 as [Nunavut],0 as [Ontario],0 as [PrinceEdwardIsland],0 as [Quebec],0 as [Saskatchewan],0 as [YukonTerritory],0 as [NorthwestTerritories],0 as [NewYork], 0 as [FirstNations], [FirstNations] as MCFN FROM[EDI].[Questionnaires.Configuration] WHERE YeariD = 6 and QuestionnaireId = 108");
                // remove qc14, qc17, qc42, qc44
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET MCFN = 0 WHERE ID IN (4957,4960,4985,4987)");
                // qc18 guide
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET HelpTextEnglish= '<p><b>18. is curious about the world</b></p><p>Child demonstrates curiosity and inquiry. This may be demonstrated in a variety of ways:</p><ul><li>the child asks lots of questions</li><li>the child participates in discussions about a variety of topics.</li></ul>' WHERE ID = (4961)");
                // qc22 guide
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET HelpTextEnglish= '<p><b>22. is able to solve day-to-day problems by him/herself</b></p><p>Refers to the child’s finding appropriate solutions to day-to-day problems such as: </p><ul><li>when his/her selected centre is “full,” another student chooses the book he/she had wanted, when a pencil breaks, water spills, etc. the child chooses an alternative, uses words to express choices, finds a way to “fix” something/the situation.</li><li>Uses the available materials to aid in problem solving</li></ul><p>Answer&nbsp;<strong>Never&nbsp;</strong>or&nbsp;<strong>Not True&nbsp;</strong>if the child usually requires assistance from the teacher is such situations.</p>' WHERE ID = (4965)");
                // qc24 guide
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET HelpTextEnglish= '<p><b>24. is able to follow class routines without reminders</b></p><ul><li>Following class routines means that the child can successfully move between regular activities without individual prompting by the teacher. For instance, the child finds their way to and from the outdoor learning space without adult support.</li></ul>' WHERE ID = (4967)");
                // qc26 guide
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET HelpTextEnglish= '<p><b>26. answers questions showing knowledge about the world (e.g., leaves fall in the autumn, apple is a fruit, dogs bark, etc.)</b></p><p>Recognize the same area in different seasons</p><ul><li>Identifies the current season and describes one characteristic of that season in the outdoor environment? (e.g., “It''s summer, the sun is warm”</li></ul><p>Demonstrates an understanding of the connections between themselves and the natural world</p><ul><li>Knowledge of the world can include knowledge of the purpose of objects/animals (e.g. animals can be pets or food) knowledge of when events occur and knowledge of what objects do (e.g., boats float in water).</li><li>Questions may be answered through various means, including demonstration of knowledge and understanding through pointing, stories, drawings, play-acting or modeling how things work or what things are.</li></ul>' WHERE ID = (4969)");
                //qc38
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'is intentionally unkind' WHERE ID = (4981)");
                // insert qc59
                migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(131,72,11,0,0,'Describe',0,Null,Null,Null,null,'is resistant to transitions','','Qc59',1,'LookupSets',247,655,4,1,'59' ,1,'Resists or refuses to go to the outdoor classroom. Requests to leave prior to when the group normally leaves.','',1,0,null,'','','Questionnaires.Data.SectionC','ResistsTransitions' ,6,1)");

            // SECTION D
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],[FirstNations],[MCFN]) SELECT 132 as QuestionnaireID,[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],getDate() as [CreatedDate],'admin' as [CreatedBy],getDate() as [ModifiedDate],'admin' as [ModifiedBy],0 as [Alberta],0 as [BritishColumbia],0 as [Manitoba],0 as [NewBrunswick],0 as [NewfoundlandandLabrador],0 as [NovaScotia],0 as [Nunavut],0 as [Ontario],0 as [PrinceEdwardIsland],0 as [Quebec],0 as [Saskatchewan],0 as [YukonTerritory],0 as [NorthwestTerritories],0 as [NewYork], 0 as [FirstNations], [FirstNations] as MCFN FROM[EDI].[Questionnaires.Configuration] WHERE YeariD = 6 and QuestionnaireId = 113");
                //qd1
                migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration] SET InputTypeId = 73, OrientationId = 12, isheader = 0, english = 'Does the student experience learning differences or challenges that may influence his/her ability to do school work in a regular classroom? <br />(based on parent information, medical diagnosis, and/or teacher observation)'  WHERE id = 5031");
                // fix question 1   
                migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration] SET MCFN = 0  WHERE id in(5030, 5039)");
                //qd2f
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'emotional regulation' WHERE ID = (5018)");
                //qd2g
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'behavioural regulation' WHERE ID = (5019)");
                //qd2h
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'complex home life' WHERE ID = (5020)");              

            // DEMOGRAPHICS
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],[FirstNations],[MCFN]) SELECT 133 as QuestionnaireID,[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],getDate() as [CreatedDate],'admin' as [CreatedBy],getDate() as [ModifiedDate],'admin' as [ModifiedBy],0 as [Alberta],0 as [BritishColumbia],0 as [Manitoba],0 as [NewBrunswick],0 as [NewfoundlandandLabrador],0 as [NovaScotia],0 as [Nunavut],0 as [Ontario],0 as [PrinceEdwardIsland],0 as [Quebec],0 as [Saskatchewan],0 as [YukonTerritory],0 as [NorthwestTerritories],0 as [NewYork], 0 as [FirstNations], [FirstNations] as MCFN FROM[EDI].[Questionnaires.Configuration] WHERE YeariD = 6 and QuestionnaireId = 126");                
                // remove membership question
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET MCFN = 0 WHERE ID IN(5095, 5096, 5097)");
       
            
            // SECTION E
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],[FirstNations],[MCFN]) SELECT 134 as QuestionnaireID,[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],getDate() as [CreatedDate],'admin' as [CreatedBy],getDate() as [ModifiedDate],'admin' as [ModifiedBy],0 as [Alberta],0 as [BritishColumbia],0 as [Manitoba],0 as [NewBrunswick],0 as [NewfoundlandandLabrador],0 as [NovaScotia],0 as [Nunavut],0 as [Ontario],0 as [PrinceEdwardIsland],0 as [Quebec],0 as [Saskatchewan],0 as [YukonTerritory],0 as [NorthwestTerritories],0 as [NewYork], 0 as [FirstNations], [FirstNations] as MCFN FROM[EDI].[Questionnaires.Configuration] WHERE YeariD = 6 and QuestionnaireId = 127");
                // centrebasedlicensed
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'MCFN licensed child care' WHERE ID = (5098)");
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'If yes to question #2, please specify the type of care arrangement (refer to Guide for examples):' WHERE ID = (5108)");
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'If yes to question #2, was this arrangement' WHERE ID = (5141)");
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = '5. Did this child attend an EarlyON Child & Family program?' WHERE ID = (5131)");

                // add 250 to sequence to make room for new questions
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET sequence = sequence + 250 WHERE questionnaireid = 134 and mcfn = 1 and sequence > 280");

                // new questions
                migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,81,11,1,0,'CultureLanguage',1,NULL,NULL,NULL,NULL,'','',NULL,0,NULL,NULL,300,1,1,'1' ,0,'','',0,0,NULL,'','','Questionnaires.Data.SectionE','' ,6,1)");
                migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,72,11,1,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'','',NULL,1,'LookupSets',247,310,4,1,'7' ,0,'','',0,0,NULL,'','','Questionnaires.Data.SectionE','' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,72,11,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'identifies living creatures discovered on the land and shows care for them (ie. ""We don''t pick the flowers,"" ""We are gentle with bugs,"" ""We take our garbage with us"")','','MCFNCare',1,'LookupSets',247,320,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNCare' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,72,11,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'demonstrates an understanding of living habitats and stewardship (leaving the land as it was found)','','MCFNStewardship',1,'LookupSets',247,330,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNStewardship' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,72,11,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'if given natural materials, the child can create something that represents how they feel about nature or what they learned about a specific natural element','','MCFNCreate',1,'LookupSets',247,340,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNCreate' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,72,11,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'shows an interest in speaking Aanishnaabemowin without prompts','','MCFNSpeaking',1,'LookupSets',247,350,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNSpeaking' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,72,11,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'uses Aanishnaabemowin with adults who the child knows can speak/understand','','MCFNCommunicates',1,'LookupSets',247,360,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNCommunicates' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,72,11,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'replaces frequently used words with Aanishnaabemowin word rather than English','','MCFNReplaces',1,'LookupSets',247,370,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNReplaces' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,72,11,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'attempts to use Aanishnaabemowin on their own initiative, even if just a few words or phrases?','','MCFNInitiative',1,'LookupSets',247,380,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNInitiative' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,72,11,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'ask questions about the Aanishnaabemowin language (e.g., ""What does this mean ? "", ""How do you say...?"")','','MCFNQuestions',1,'LookupSets',247,390,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNQuestions' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,72,11,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'show a willingness to repeat words or phrases to improve pronunciation','','MCFNImprove',1,'LookupSets',247,400,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNImprove' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,72,11,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'when given a simple instruction in Aanishnaabemowin (e.g., ""Stand up,"" ""Point to the book""), does the child respond appropriately?','','MCFNRespond',1,'LookupSets',247,410,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNRespond' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,72,11,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'identifies objects, colors, or numbers when named in Aanishnaabemowin','','MCFNIdentify',1,'LookupSets',247,420,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNIdentify' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,72,11,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'enjoys the process of learning and using Aanishnaabemowin','','MCFNLearning',1,'LookupSets',247,430,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNLearning' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,81,11,1,0,'Interest',1,NULL,NULL,NULL,NULL,'','',NULL,0,NULL,NULL,440,1,1,'8' ,0,'','',0,0,NULL,'','','Questionnaires.Data.SectionE','' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,72,11,1,0,'Interest',0,NULL,NULL,NULL,NULL,'Child shows an interest in:','',NULL,1,'LookupSets',302,450,5,1,'8' ,0,'','',0,0,NULL,'','','Questionnaires.Data.SectionE','' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,72,11,0,0,'Interest',0,NULL,NULL,NULL,NULL,'Drumming','','MCFNDrumming',1,'LookupSets',302,460,5,1,'8' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNDrumming' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,72,11,0,0,'Interest',0,NULL,NULL,NULL,NULL,'Cultural activities such as smudge or sharing circle','','MCFNActivities',1,'LookupSets',302,470,5,1,'8' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNActivities' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,81,11,1,0,'Culture',1,NULL,NULL,NULL,NULL,'','',NULL,0,NULL,NULL,480,1,1,'9' ,0,'','',0,0,NULL,'','','Questionnaires.Data.SectionE','' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,72,11,1,0,'Culture',0,NULL,NULL,NULL,NULL,'','',NULL,1,'LookupSets',247,490,4,1,'9' ,0,'','',0,0,NULL,'','','Questionnaires.Data.SectionE','' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,72,11,0,0,'Culture',0,NULL,NULL,NULL,NULL,'if has an opportunity, wears regalia for cultural events','','MCFNWears',1,'LookupSets',247,500,4,1,'9' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNWears' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,72,11,0,0,'Culture',0,NULL,NULL,NULL,NULL,'engages in imaginative play that incorporates cultural elements?','','MCFNImaginative',1,'LookupSets',247,510,4,1,'9' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNImaginative' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,72,11,0,0,'Culture',0,NULL,NULL,NULL,NULL,'independently seeks out information or experiences related to the culture','','MCFNSeeksInfo',1,'LookupSets',247,520,4,1,'9' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNSeeksInfo' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(134,72,11,0,0,'Culture',0,NULL,NULL,NULL,NULL,'shows an interest in cultural items, practices, or traditions','','MCFNInterest',1,'LookupSets',247,530,4,1,'9' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNInterest' ,6,1)");

            //2025 NO CHANGES TO TEACHER 
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],[FirstNations],[MCFN]) SELECT 135 as QuestionnaireID,[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],getDate() as [CreatedDate],'admin' as [CreatedBy],getDate() as [ModifiedDate],'admin' as [ModifiedBy],0 as [Alberta],0 as [BritishColumbia],0 as [Manitoba],0 as [NewBrunswick],0 as [NewfoundlandandLabrador],0 as [NovaScotia],0 as [Nunavut],0 as [Ontario],0 as [PrinceEdwardIsland],0 as [Quebec],0 as [Saskatchewan],0 as [YukonTerritory],0 as [NorthwestTerritories],0 as [NewYork], 0 as [FirstNations], [FirstNations] as MCFN FROM[EDI].[Questionnaires.Configuration] WHERE YeariD = 5 and QuestionnaireId = 80");

            // SECTION A
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],[FirstNations],[MCFN]) SELECT 136 as QuestionnaireID,[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],getDate() as [CreatedDate],'admin' as [CreatedBy],getDate() as [ModifiedDate],'admin' as [ModifiedBy],0 as [Alberta],0 as [BritishColumbia],0 as [Manitoba],0 as [NewBrunswick],0 as [NewfoundlandandLabrador],0 as [NovaScotia],0 as [Nunavut],0 as [Ontario],0 as [PrinceEdwardIsland],0 as [Quebec],0 as [Saskatchewan],0 as [YukonTerritory],0 as [NorthwestTerritories],0 as [NewYork], 0 as [FirstNations], [FirstNations] as MCFN FROM[EDI].[Questionnaires.Configuration] WHERE YeariD = 5 and QuestionnaireId = 82");
                // remove QA5 Hungry
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET MCFN = 0 WHERE ID IN (5201)");
                // update QA9
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'ability to hold a pen, crayons, or brush' WHERE ID = (5203)");
                // INSERT QA14
                migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[MCFN]) VALUES(136,58,9,0,0,'Rating',0,Null,Null,Null,null,'easily transitions from one activity to another throughout the day','','Qa14',1,'LookupSets',189,245,4,1,'14' ,0,'','',1,0,null,'','','Questionnaires.Data.SectionA','EarlyTransitions' ,6,1)");

            // SECTION B
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],[FirstNations],[MCFN]) SELECT 137 as QuestionnaireID,[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],getDate() as [CreatedDate],'admin' as [CreatedBy],getDate() as [ModifiedDate],'admin' as [ModifiedBy],0 as [Alberta],0 as [BritishColumbia],0 as [Manitoba],0 as [NewBrunswick],0 as [NewfoundlandandLabrador],0 as [NovaScotia],0 as [Nunavut],0 as [Ontario],0 as [PrinceEdwardIsland],0 as [Quebec],0 as [Saskatchewan],0 as [YukonTerritory],0 as [NorthwestTerritories],0 as [NewYork], 0 as [FirstNations], [FirstNations] as MCFN FROM[EDI].[Questionnaires.Configuration] WHERE YeariD = 5 and QuestionnaireId = 83");
                //QB3 Guide
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET HelpTextEnglish= '<p><b>3. ability to tell a story</b></p><ul><li>Refers to the child’s skill in retelling a story heard before, using appropriate vocabulary in matching events with words.</li><li>Retells experiences to other children or adults about discoveries or experiences that they encountered on the land</li></ul>' WHERE ID = (5275)");
                //qb15
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'shows interest in reading simple words' WHERE ID = (5245)");
                //qb16
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'shows interest in reading complex words' WHERE ID = (5246)");
                //qb17
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'shows interest in reading simple sentences' WHERE ID = (5247)");
                //qb22
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'shows an interest in writing simple words' WHERE ID = (5252)");
                //qb23
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'shows an interest in writing simple sentences' WHERE ID = (5253)");

            // SECTION C
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],[FirstNations],[MCFN]) SELECT 138 as QuestionnaireID,[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],getDate() as [CreatedDate],'admin' as [CreatedBy],getDate() as [ModifiedDate],'admin' as [ModifiedBy],0 as [Alberta],0 as [BritishColumbia],0 as [Manitoba],0 as [NewBrunswick],0 as [NewfoundlandandLabrador],0 as [NovaScotia],0 as [Nunavut],0 as [Ontario],0 as [PrinceEdwardIsland],0 as [Quebec],0 as [Saskatchewan],0 as [YukonTerritory],0 as [NorthwestTerritories],0 as [NewYork], 0 as [FirstNations], [FirstNations] as MCFN FROM[EDI].[Questionnaires.Configuration] WHERE YeariD = 5 and QuestionnaireId = 84");
                // remove qc14, qc17, qc42, qc44
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET MCFN = 0 WHERE ID IN (5305,5308,5333,5335)");
                // qc18 guide
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET HelpTextEnglish= '<p><b>18. is curious about the world</b></p><p>Child demonstrates curiosity and inquiry. This may be demonstrated in a variety of ways:</p><ul><li>the child asks lots of questions</li><li>the child participates in discussions about a variety of topics.</li></ul>' WHERE ID = (5309)");
                // qc22 guide
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET HelpTextEnglish= '<p><b>22. is able to solve day-to-day problems by him/herself</b></p><p>Refers to the child’s finding appropriate solutions to day-to-day problems such as: </p><ul><li>when his/her selected centre is “full,” another student chooses the book he/she had wanted, when a pencil breaks, water spills, etc. the child chooses an alternative, uses words to express choices, finds a way to “fix” something/the situation.</li><li>Uses the available materials to aid in problem solving</li></ul><p>Answer&nbsp;<strong>Never&nbsp;</strong>or&nbsp;<strong>Not True&nbsp;</strong>if the child usually requires assistance from the teacher is such situations.</p>' WHERE ID = (5313)");
                // qc24 guide
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET HelpTextEnglish= '<p><b>24. is able to follow class routines without reminders</b></p><ul><li>Following class routines means that the child can successfully move between regular activities without individual prompting by the teacher. For instance, the child finds their way to and from the outdoor learning space without adult support.</li></ul>' WHERE ID = (5315)");
                // qc26 guide
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET HelpTextEnglish= '<p><b>26. answers questions showing knowledge about the world (e.g., leaves fall in the autumn, apple is a fruit, dogs bark, etc.)</b></p><p>Recognize the same area in different seasons</p><ul><li>Identifies the current season and describes one characteristic of that season in the outdoor environment? (e.g., “It''s summer, the sun is warm”</li></ul><p>Demonstrates an understanding of the connections between themselves and the natural world</p><ul><li>Knowledge of the world can include knowledge of the purpose of objects/animals (e.g. animals can be pets or food) knowledge of when events occur and knowledge of what objects do (e.g., boats float in water).</li><li>Questions may be answered through various means, including demonstration of knowledge and understanding through pointing, stories, drawings, play-acting or modeling how things work or what things are.</li></ul>' WHERE ID = (5317)");
                //qc38
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'is intentionally unkind' WHERE ID = (5329)");
                // insert qc59
                migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(138,58,9,0,0,'Describe',0,Null,Null,Null,null,'is resistant to transitions','','Qc59',1,'LookupSets',190,655,4,1,'59' ,1,'Resists or refuses to go to the outdoor classroom. Requests to leave prior to when the group normally leaves.','',1,0,null,'','','Questionnaires.Data.SectionC','ResistsTransitions' ,6,1)");

            // SECTION D
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],[FirstNations],[MCFN]) SELECT 139 as QuestionnaireID,[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],getDate() as [CreatedDate],'admin' as [CreatedBy],getDate() as [ModifiedDate],'admin' as [ModifiedBy],0 as [Alberta],0 as [BritishColumbia],0 as [Manitoba],0 as [NewBrunswick],0 as [NewfoundlandandLabrador],0 as [NovaScotia],0 as [Nunavut],0 as [Ontario],0 as [PrinceEdwardIsland],0 as [Quebec],0 as [Saskatchewan],0 as [YukonTerritory],0 as [NorthwestTerritories],0 as [NewYork], 0 as [FirstNations], [FirstNations] as MCFN FROM[EDI].[Questionnaires.Configuration] WHERE YeariD = 5 and QuestionnaireId = 89");
                //qd1
                migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration] SET InputTypeId = 59, OrientationId = 10, isheader = 0, english = 'Does the student experience learning differences or challenges that may influence his/her ability to do school work in a regular classroom? <br />(based on parent information, medical diagnosis, and/or teacher observation)' WHERE id = 5370");
                // fix question 1                 
                migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration] SET MCFN = 0  WHERE id in(5352, 5369)");
                //qd2f
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'emotional regulation' WHERE ID = (5377)");
                //qd2g
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'behavioural regulation' WHERE ID = (5378)");
                //qd2h
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'complex home life' WHERE ID = (5379)");                               

            // DEMOGRAPHICS
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],[FirstNations],[MCFN]) SELECT 140 as QuestionnaireID,[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],getDate() as [CreatedDate],'admin' as [CreatedBy],getDate() as [ModifiedDate],'admin' as [ModifiedBy],0 as [Alberta],0 as [BritishColumbia],0 as [Manitoba],0 as [NewBrunswick],0 as [NewfoundlandandLabrador],0 as [NovaScotia],0 as [Nunavut],0 as [Ontario],0 as [PrinceEdwardIsland],0 as [Quebec],0 as [Saskatchewan],0 as [YukonTerritory],0 as [NorthwestTerritories],0 as [NewYork], 0 as [FirstNations], [FirstNations] as MCFN FROM[EDI].[Questionnaires.Configuration] WHERE YeariD = 5 and QuestionnaireId = 102");            
                // remove membership question
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET MCFN = 0 WHERE ID IN(5418, 5424, 5419)");


            // SECTION E
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],[FirstNations],[MCFN]) SELECT 141 as QuestionnaireID,[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],getDate() as [CreatedDate],'admin' as [CreatedBy],getDate() as [ModifiedDate],'admin' as [ModifiedBy],0 as [Alberta],0 as [BritishColumbia],0 as [Manitoba],0 as [NewBrunswick],0 as [NewfoundlandandLabrador],0 as [NovaScotia],0 as [Nunavut],0 as [Ontario],0 as [PrinceEdwardIsland],0 as [Quebec],0 as [Saskatchewan],0 as [YukonTerritory],0 as [NorthwestTerritories],0 as [NewYork], 0 as [FirstNations], [FirstNations] as MCFN FROM[EDI].[Questionnaires.Configuration] WHERE YeariD = 5 and QuestionnaireId = 103");
                // centrebasedlicensed
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'MCFN licensed child care' WHERE ID = (5436)");
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'If yes to question #2, please specify the type of care arrangement (refer to Guide for examples):' WHERE ID = (5446)");
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = 'If yes to question #2, was this arrangement' WHERE ID = (5479)");
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET ENGLISH = '5. Did this child attend an EarlyON Child & Family program?' WHERE ID = (5469)");

                // add 250 to sequence to make room for new questions
                migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET sequence = sequence + 250 WHERE questionnaireid = 141 and mcfn = 1 and sequence > 280");

                // new questions
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,67,9,1,0,'CultureLanguage',1,NULL,NULL,NULL,NULL,'','',NULL,0,NULL,NULL,300,1,1,'1' ,0,'','',0,0,NULL,'','','Questionnaires.Data.SectionE','' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,58,9,1,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'','',NULL,1,'LookupSets',190,310,4,1,'7' ,0,'','',0,0,NULL,'','','Questionnaires.Data.SectionE','' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,58,9,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'identifies living creatures discovered on the land and shows care for them (ie. ""We don''t pick the flowers,"" ""We are gentle with bugs,"" ""We take our garbage with us"")','','MCFNCare',1,'LookupSets',190,320,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNCare' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,58,9,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'demonstrates an understanding of living habitats and stewardship (leaving the land as it was found)','','MCFNStewardship',1,'LookupSets',190,330,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNStewardship' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,58,9,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'if given natural materials, the child can create something that represents how they feel about nature or what they learned about a specific natural element','','MCFNCreate',1,'LookupSets',190,340,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNCreate' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,58,9,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'shows an interest in speaking Aanishnaabemowin without prompts','','MCFNSpeaking',1,'LookupSets',190,350,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNSpeaking' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,58,9,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'uses Aanishnaabemowin with adults who the child knows can speak/understand','','MCFNCommunicates',1,'LookupSets',190,360,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNCommunicates' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,58,9,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'replaces frequently used words with Aanishnaabemowin word rather than English','','MCFNReplaces',1,'LookupSets',190,370,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNReplaces' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,58,9,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'attempts to use Aanishnaabemowin on their own initiative, even if just a few words or phrases?','','MCFNInitiative',1,'LookupSets',190,380,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNInitiative' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,58,9,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'ask questions about the Aanishnaabemowin language (e.g., ""What does this mean ?"", ""How do you say...?"")','','MCFNQuestions',1,'LookupSets',190,390,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNQuestions' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,58,9,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'show a willingness to repeat words or phrases to improve pronunciation','','MCFNImprove',1,'LookupSets',190,400,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNImprove' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,58,9,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'when given a simple instruction in Aanishnaabemowin (e.g., ""Stand up,"" ""Point to the book""), does the child respond appropriately?','','MCFNRespond',1,'LookupSets',190,410,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNRespond' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,58,9,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'identifies objects, colors, or numbers when named in Aanishnaabemowin','','MCFNIdentify',1,'LookupSets',190,420,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNIdentify' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,58,9,0,0,'CultureLanguage',0,NULL,NULL,NULL,NULL,'enjoys the process of learning and using Aanishnaabemowin','','MCFNLearning',1,'LookupSets',190,430,4,1,'7' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNLearning' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,67,9,1,0,'Interest',1,NULL,NULL,NULL,NULL,'','',NULL,0,NULL,NULL,440,1,1,'8' ,0,'','',0,0,NULL,'','','Questionnaires.Data.SectionE','' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,58,9,1,0,'Interest',0,NULL,NULL,NULL,NULL,'Child shows an interest in:','',NULL,1,'LookupSets',301,450,5,1,'8' ,0,'','',0,0,NULL,'','','Questionnaires.Data.SectionE','' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,58,9,0,0,'Interest',0,NULL,NULL,NULL,NULL,'Drumming','','MCFNDrumming',1,'LookupSets',301,460,5,1,'8' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNDrumming' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,58,9,0,0,'Interest',0,NULL,NULL,NULL,NULL,'Cultural activities such as smudge or sharing circle','','MCFNActivities',1,'LookupSets',301,470,5,1,'8' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNActivities' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,67,9,1,0,'Culture',1,NULL,NULL,NULL,NULL,'','',NULL,0,NULL,NULL,480,1,1,'9' ,0,'','',0,0,NULL,'','','Questionnaires.Data.SectionE','' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,58,9,1,0,'Culture',0,NULL,NULL,NULL,NULL,'','',NULL,1,'LookupSets',190,490,4,1,'9' ,0,'','',0,0,NULL,'','','Questionnaires.Data.SectionE','' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,58,9,0,0,'Culture',0,NULL,NULL,NULL,NULL,'if has an opportunity, wears regalia for cultural events','','MCFNWears',1,'LookupSets',190,500,4,1,'9' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNWears' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,58,9,0,0,'Culture',0,NULL,NULL,NULL,NULL,'engages in imaginative play that incorporates cultural elements?','','MCFNImaginative',1,'LookupSets',190,510,4,1,'9' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNImaginative' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,58,9,0,0,'Culture',0,NULL,NULL,NULL,NULL,'independently seeks out information or experiences related to the culture','','MCFNSeeksInfo',1,'LookupSets',190,520,4,1,'9' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNSeeksInfo' ,6,1)");
                migrationBuilder.Sql(@"INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,MCFN) VALUES(141,58,9,0,0,'Culture',0,NULL,NULL,NULL,NULL,'shows an interest in cultural items, practices, or traditions','','MCFNInterest',1,'LookupSets',190,530,4,1,'9' ,0,'','',1,0,NULL,'','','Questionnaires.Data.SectionE','MCFNInterest' ,6,1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                  name: "MCFN",
                  schema: "LUData",
                  table: "Years");

            migrationBuilder.DropColumn(
                name: "MCFN",
                schema: "EDI",
                table: "Questionnaires.Configuration");

            migrationBuilder.DropColumn(
                name: "MCFN",
                schema: "EDI",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "MCFN",
                schema: "EDI",
                table: "NewsFeed");

            migrationBuilder.DropColumn(
                name: "MCFN",
                schema: "EDI",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "MCFN",
                schema: "EDI",
                table: "FAQ");

            migrationBuilder.DropColumn(
                name: "EarlyTransitions",
                schema: "EDI",
                table: "Questionnaires.Data.SectionA");

            migrationBuilder.DropColumn(
                name: "ResistsTransitions",
                schema: "EDI",
                table: "Questionnaires.Data.SectionC");

            migrationBuilder.DropColumn(
                name: "MCFNActivities",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "MCFNCare",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "MCFNCommunicates",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "MCFNCreate",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "MCFNDrumming",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "MCFNIdentify",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "MCFNImaginative",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "MCFNImprove",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "MCFNInitiative",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "MCFNInterest",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "MCFNLearning",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "MCFNQuestions",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "MCFNReplaces",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "MCFNRespond",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "MCFNSeeksInfo",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "MCFNSpeaking",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "MCFNStewardship",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "MCFNWears",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");
        }
    }
}
