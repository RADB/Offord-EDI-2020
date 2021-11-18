using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2022YearIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YearId",
                schema: "LUData",
                table: "Translations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearId",
                schema: "LUData",
                table: "Provinces",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearId",
                schema: "LUData",
                table: "LookupSetOptions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearId",
                schema: "LUData",
                table: "Genders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearId",
                schema: "LUData",
                table: "Countries",
                type: "int",
                nullable: true);

            
            migrationBuilder.InsertData(
                schema: "LUData",
                table: "FileImportStatus",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "English", "French", "ModifiedBy", "ModifiedDate", "Sequence" },
                values: new object[] { 5, "5", "admin", new DateTime(2021, 11, 18, 1, 13, 21, 518, DateTimeKind.Local).AddTicks(5030), "Invalid Questionnaire", "Questionnaire non valide", "admin", new DateTime(2021, 11, 18, 1, 13, 21, 518, DateTimeKind.Local).AddTicks(5032), 5 });

            
            migrationBuilder.CreateIndex(
                name: "IX_Translations_YearId",
                schema: "LUData",
                table: "Translations",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_YearId",
                schema: "LUData",
                table: "Provinces",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_LookupSetOptions_YearId",
                schema: "LUData",
                table: "LookupSetOptions",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Genders_YearId",
                schema: "LUData",
                table: "Genders",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_YearId",
                schema: "LUData",
                table: "Countries",
                column: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Years_YearId",
                schema: "LUData",
                table: "Countries",
                column: "YearId",
                principalSchema: "LUData",
                principalTable: "Years",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Genders_Years_YearId",
                schema: "LUData",
                table: "Genders",
                column: "YearId",
                principalSchema: "LUData",
                principalTable: "Years",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LookupSetOptions_Years_YearId",
                schema: "LUData",
                table: "LookupSetOptions",
                column: "YearId",
                principalSchema: "LUData",
                principalTable: "Years",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Provinces_Years_YearId",
                schema: "LUData",
                table: "Provinces",
                column: "YearId",
                principalSchema: "LUData",
                principalTable: "Years",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Translations_Years_YearId",
                schema: "LUData",
                table: "Translations",
                column: "YearId",
                principalSchema: "LUData",
                principalTable: "Years",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET YearId = 1 WHERE YearId is null");
            migrationBuilder.Sql("UPDATE [LUData].[Countries] SET YearId = 1 WHERE YearId is null");
            migrationBuilder.Sql("UPDATE [LUData].[Genders] SET YearId = 1 WHERE YearId is null");
            migrationBuilder.Sql("UPDATE [LUData].[LookupSetOptions] SET YearId = 1 WHERE YearId is null");
            migrationBuilder.Sql("UPDATE [LUData].[Provinces] SET YearId = 1 WHERE YearId is null");
            migrationBuilder.Sql("UPDATE [LUData].[Translations] SET YearId = 1 WHERE YearId is null");

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

		-- get the count of lookupsets to add to the ids
		DECLARE @LookupSets int
		SELECT @LookupSets = count(1) FROM [EDI.Service].[LUData].[LookupSets] WHERE YearID = @OldYearId

		-- insert the questionnaires - set the yearid to copy - set the year id 
		INSERT INTO [EDI.Service].[EDI].[Questionnaires] ([YearId],[QuestionnaireName],[English],[French],[DescriptionEnglish],[DescriptionFrench],[ShowProgressBar],[EntityName],[ShowQuestionNumbers],[Sequence],[IsChildQuestionnaire],[IsTeacherQuestionnaire],[QuestionsRequired],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork]) 
		SELECT @NewYearId,[QuestionnaireName],[English],[French],[DescriptionEnglish],[DescriptionFrench],[ShowProgressBar],[EntityName],[ShowQuestionNumbers],[Sequence],[IsChildQuestionnaire],[IsTeacherQuestionnaire],[QuestionsRequired],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork] FROM [EDI.Service].[EDI].[Questionnaires] WHERE Yearid = @OldYearId

		-- insert the questionnaire configurations into the table
		INSERT INTO [EDI.Service].[EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork])
		SELECT [QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],@NewYearId,[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork] FROM [EDI.Service].[EDI].[Questionnaires.Configuration] WHERE YeariD = @OldYearId

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

        UPDATE [dbo].[SystemConfigurations] SET FieldValue = 2022 WHERE FieldName = 'Year'
    END
END";
            // create the stored procedure for migration
            migrationBuilder.Sql(sp);

            // initialize 2022
            migrationBuilder.Sql("EXEC [dbo].[InitializeNewYear] 2021, 2022");            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Years_YearId",
                schema: "LUData",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Genders_Years_YearId",
                schema: "LUData",
                table: "Genders");

            migrationBuilder.DropForeignKey(
                name: "FK_LookupSetOptions_Years_YearId",
                schema: "LUData",
                table: "LookupSetOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Provinces_Years_YearId",
                schema: "LUData",
                table: "Provinces");

            migrationBuilder.DropForeignKey(
                name: "FK_Translations_Years_YearId",
                schema: "LUData",
                table: "Translations");

            migrationBuilder.DropIndex(
                name: "IX_Translations_YearId",
                schema: "LUData",
                table: "Translations");

            migrationBuilder.DropIndex(
                name: "IX_Provinces_YearId",
                schema: "LUData",
                table: "Provinces");

            migrationBuilder.DropIndex(
                name: "IX_LookupSetOptions_YearId",
                schema: "LUData",
                table: "LookupSetOptions");

            migrationBuilder.DropIndex(
                name: "IX_Genders_YearId",
                schema: "LUData",
                table: "Genders");

            migrationBuilder.DropIndex(
                name: "IX_Countries_YearId",
                schema: "LUData",
                table: "Countries");

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "FileImportStatus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "YearId",
                schema: "LUData",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "YearId",
                schema: "LUData",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "YearId",
                schema: "LUData",
                table: "LookupSetOptions");

            migrationBuilder.DropColumn(
                name: "YearId",
                schema: "LUData",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "YearId",
                schema: "LUData",
                table: "Countries");

            migrationBuilder.Sql("DROP Procedure [dbo].[InitializeNewYear]");
            migrationBuilder.Sql("UPDATE [dbo].[SystemConfigurations] SET FieldValue = 2021 WHERE FieldName = 'Year'");            
        }
    }
}
