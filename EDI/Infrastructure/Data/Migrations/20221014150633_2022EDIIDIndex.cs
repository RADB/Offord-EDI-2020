using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

// This has been deferred - code is checking for the duplicates at the current time.
// SELECT [Ediid],COUNT(1)    FROM [EDI.Service].[EDI].[Children]GROUP BY ediid HAVING COUNT(1) > 1 -- check DB for duplicates
namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2022EDIIDIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
            name: "IX_Children_EDIId",
            schema: "EDI",
            table: "Children",
            column: "EDIID",
            unique: true)
              ;

			//https://www.entityframeworktutorial.net/efcore/working-with-stored-procedure-in-ef-core.aspx
			var sp = @"CREATE PROCEDURE [dbo].[InitializeNewYear]	
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

		-- insert the questionnaires - set the yearid to copy - set the year id 
		INSERT INTO [EDI.Service].[EDI].[Questionnaires] ([YearId],[QuestionnaireName],[English],[French],[DescriptionEnglish],[DescriptionFrench],[ShowProgressBar],[EntityName],[ShowQuestionNumbers],[Sequence],[IsChildQuestionnaire],[IsTeacherQuestionnaire],[QuestionsRequired],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork]) 
		SELECT @NewYearId,[QuestionnaireName],[English],[French],[DescriptionEnglish],[DescriptionFrench],[ShowProgressBar],[EntityName],[ShowQuestionNumbers],[Sequence],[IsChildQuestionnaire],[IsTeacherQuestionnaire],[QuestionsRequired],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork] FROM [EDI.Service].[EDI].[Questionnaires] WHERE Yearid = @OldYearId

		-- insert the questionnaire configurations into the table -- - adds the count of oldyear to the id
		INSERT INTO [EDI.Service].[EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork])
		SELECT [QuestionnaireId]+@Questionnaires,[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],@NewYearId,[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork] FROM [EDI.Service].[EDI].[Questionnaires.Configuration] WHERE YeariD = @OldYearId

		--Insert the countries
		INSERT INTO [EDI.Service].[LUData].[Countries] ([Code],[English],[French],[ISO2CountryCode],[ISO3CountryCode],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[YearId])
		SELECT [Code],[English],[French],[ISO2CountryCode],[ISO3CountryCode],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],@NewYearId FROM [EDI.Service].[LUData].[Countries] WHERE YeariD = @OldYearId

		--Insert the provinces
		INSERT INTO [EDI.Service].[LUData].[Provinces]([English],[French],[Code],[EDICode],[CountryID],[ProvinceTypeId],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[YearId])
		SELECT [English],[French],[Code],[EDICode],[CountryID],[ProvinceTypeId],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],@NewYearId FROM [EDI.Service].[LUData].[Provinces] WHERE YeariD = @OldYearId

		--Insert the Genders
		INSERT INTO [EDI.Service].[LUData].[Genders] ([Code],[English],[French],[Sequence],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[YearId])
		SELECT [Code],[English],[French],[Sequence],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],@NewYearId FROM [EDI.Service].[LUData].[Genders] WHERE YearId = @OldYearId

		--Insert the input types
		INSERT INTO [EDI.Service].[LUData].[InputTypes] ([YearId],[English],[French],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy])
		SELECT @NewYearId,[English],[French],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy] FROM [EDI.Service].[LUData].[InputTypes] WHERE YeariD = @OldYearId

		-- insert the lookupsets
		INSERT INTO [EDI.Service].[LUData].[LookupSets] ([YearId],[LookupName],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy] )
		SELECT @NewYearId,[LookupName],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy] FROM [EDI.Service].[LUData].[LookupSets] WHERE YeariD = @OldYearId

		-- insert the lookupsetoptions - adds the count of oldyear to the id
		INSERT INTO [EDI.Service].[LUData].[LookupSetOptions] ([LookupSetId],[English],[French],[Value],[Sequence],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[YearId]) 
		SELECT [LookupSetId]+@LookupSets,[English],[French],[Value],[Sequence],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],@NewYearId FROM [EDI.Service].[LUData].[LookupSetOptions] WHERE YeariD = @OldYearId

        UPDATE [dbo].[SystemConfigurations] SET FieldValue = @NewYearId WHERE FieldName = 'Year'
    END
END";
			// create the stored procedure for migration
			migrationBuilder.Sql(sp);

			// initialize 2022
			migrationBuilder.Sql("EXEC [dbo].[InitializeNewYear] 2022, 2023");
		}

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
