using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2026MFCN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        -- get the count of questionnaires
        DECLARE @Questionnaires int
        SELECT @Questionnaires = count(1) FROM [EDI].[Questionnaires] WHERE YearID = @OldYearId

		-- get the count of lookupsets to add to the ids
		DECLARE @LookupSets int
		SELECT @LookupSets = count(1) FROM [EDI.Service].[LUData].[LookupSets] WHERE YearID = @OldYearId

		DECLARE @Countries int
		SELECT @Countries = count(1) FROM [EDI.Service].[LUData].[Countries] WHERE YearID = @OldYearId

        DECLARE @InputTypes int
        SELECT @InputTypes = count(1) FROM [EDI.Service].[LUData].[InputTypes] WHERE YearID = @OldYearId

        DECLARE @Orientations int
        SELECT @Orientations = count(1) FROM [EDI.Service].[LUData].[Orientations] WHERE YearID = @OldYearId

		-- insert the questionnaires - set the yearid to copy - set the year id 
		INSERT INTO [EDI.Service].[EDI].[Questionnaires] ([YearId],[QuestionnaireName],[English],[French],[DescriptionEnglish],[DescriptionFrench],[ShowProgressBar],[EntityName],[ShowQuestionNumbers],[Sequence],[IsChildQuestionnaire],[IsTeacherQuestionnaire],[QuestionsRequired],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork], [FirstNations]) 
		SELECT @NewYearId,[QuestionnaireName],[English],[French],[DescriptionEnglish],[DescriptionFrench],[ShowProgressBar],[EntityName],[ShowQuestionNumbers],[Sequence],[IsChildQuestionnaire],[IsTeacherQuestionnaire],[QuestionsRequired],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],  [FirstNations] FROM [EDI.Service].[EDI].[Questionnaires] WHERE Yearid = @OldYearId


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

		INSERT INTO [EDI].[FAQ] ([YearId],[Question],[Answer],[IsTeacherFaq],[IsAdministratorFaq],[IsCoordinatorFaq],[Sequence],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork], [FirstNations])
		SELECT @NewYearID,[Question],[Answer],[IsTeacherFaq],[IsAdministratorFaq],[IsCoordinatorFaq],[Sequence],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork], [FirstNations] FROM [EDI].[FAQ] WHERE Yearid = @OldYearId

        UPDATE [dbo].[SystemConfigurations] SET FieldValue = @NewYear WHERE FieldName = 'Year'

		-- insert the questionnaire configurations into the table -- - adds the count of oldyear to the id
		INSERT INTO [EDI.Service].[EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork], [FirstNations])
		SELECT [QuestionnaireId]+@Questionnaires,[InputTypeId]+@InputTypes,[OrientationId]+@Orientations,[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId]+@LookupSets,[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],@NewYearId,[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork], [FirstNations] FROM [EDI.Service].[EDI].[Questionnaires.Configuration] WHERE YeariD = @OldYearId
		
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
            migrationBuilder.Sql("UPDATE [LUData].[Years] SET MCFN=1 WHERE ID=6");

            // start with FirstNations - Create Demographics
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires] ([YearId],[QuestionnaireName],[English],[French],[DescriptionEnglish],[DescriptionFrench],[ShowProgressBar],[EntityName],[ShowQuestionNumbers],[Sequence],[IsChildQuestionnaire],[IsTeacherQuestionnaire],[QuestionsRequired],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],[FirstNations],[MCFN]) SELECT [YearId],[QuestionnaireName],[English],[French],[DescriptionEnglish],[DescriptionFrench],[ShowProgressBar],[EntityName],[ShowQuestionNumbers],[Sequence],[IsChildQuestionnaire],[IsTeacherQuestionnaire],[QuestionsRequired],getDate() as [CreatedDate],[CreatedBy],getDate() as [ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],0 as [Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork], 0 as [FirstNations],1 as MCFN FROM [EDI].[Questionnaires] WHERE Yearid=6 AND ID = 126");
            // note the FirstNations as MCFN at the end to copy all removed questions as well - set the ID 128 (next one)
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork],[FirstNations],[MCFN]) SELECT 128 as QuestionnaireID,[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],getDate() as [CreatedDate],'admin' as [CreatedBy],getDate() as [ModifiedDate],'admin' as [ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],0 as [Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork], [FirstNations], [Ontario] as MCFN FROM[EDI].[Questionnaires.Configuration] WHERE YeariD = 6 and QuestionnaireId = 102");

            // Add Questionnaires A-E and Teacher Profile
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires] SET MCFN=1 WHERE yearID=6 AND ID in (104,106,107,108,113,127)"); 
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET MCFN=1 WHERE yearID=6 AND QuestionnaireID in (104,106,107,108,113,127) AND FirstNations = 1");

            /* github 244 FirstNations Demographics - add question to end */
            //migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,FirstNations) VALUES(55,31,5,0,0,'Languages',0,Null,Null,Null,Null,'Does this child have familiarity with Anishinaabemowin/Nishnaabemowin/Lenape (or Indigenous) Language:','Does this child have familiarity with Anishinaabemowin/Nishnaabemowin/Lenape (or Indigenous) Language:','IndigenousLanguage',1,'LookupSets',78,280,5,1,Null ,0,'','',1,0,Null,'','','Questionnaires.Data.Demographics','IndigenousLanguage' ,3,1)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          
        }
    }
}
