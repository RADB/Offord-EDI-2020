using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _202301Modifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /* github 170 PEI E */
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET PrinceEdwardIsland = 1 WHERE yearid = 3 and Manitoba =1 and questionnaireid = 50");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET InputTypeId = 38, HasLookupEntity = 0, lookupEntity = Null, LookupEntityId = null WHERE yearid = 3 and id = 1818 and QuestionnaireId = 50");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET isHeader = 1, VariableName = null, EntityField = null, IsRequired = 0 WHERE yearid = 3 and id = 1819 and QuestionnaireId = 50");

            /* github 171 PEI Demographics */
            migrationBuilder.Sql("UPDATE [EDI.Service].[LUData].[LookupSetOptions] SET English = 'JK/SK/1', French = 'JK/SK/1' WHERE ID = 980 AND Lookupsetid = 123");

            /* github 175 NS Demographics */
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET groupname = 'ClassType' WHERE yearid = 3 and id = 1880 and QuestionnaireId = 40");

            /* github 174 NWT Demographics */
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET NorthwestTerritories = 0 WHERE yearid = 3 and id = 1430 and QuestionnaireId = 34");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET English = 'Language Immersion Program', VariableName = 'LanguageImmersion', EntityField = 'LanguageImmersion', lookupEntityId = 122 WHERE questionnaireid = 34 and yearid = 3 and id = 1429");

            /* github 178 ONT Demographics */
            migrationBuilder.Sql("DELETE FROM[EDI.Service].[LUData].[LookupSetOptions] WHERE ID = 892 AND Lookupsetid = 104");
            migrationBuilder.Sql("UPDATE [EDI.Service].[LUData].[LookupSetOptions] SET Sequence = 60 WHERE ID = 893 AND Lookupsetid = 104");
            migrationBuilder.Sql("UPDATE [EDI.Service].[LUData].[LookupSetOptions] SET Value = Sequence / 10 WHERE Lookupsetid = 104");

            /* github 176 NFL Demographics */
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET LookupEntityId = 86 WHERE yearid = 3 and id = 1727 and QuestionnaireId = 47");

            /* github 177 NFL Section E */
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET English = 'Centre-based, licensed, for profit' WHERE yearid = 3 and id = 1757 and QuestionnaireId = 48");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET English = 'Other home-based, license', French = 'Other home-based, license', VariableName = 'OtherHomeLicensed', EntityField = 'OtherHomeLicensed' WHERE yearid = 3 and id = 1758 and QuestionnaireId = 48");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET English = 'Other home-based, unlicensed, non-relative', French = 'Other home-based, unlicensed, non-relative', VariableName = 'OtherHomeUnlicensedNonRelative', EntityField = 'OtherHomeUnlicensedNonRelative' WHERE yearid = 3 and id = 1759 and QuestionnaireId = 48");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence = sequence + 10 WHERE yearid = 3 and Sequence> 130 and sequence<260 and QuestionnaireId = 48");
            migrationBuilder.Sql("INSERT INTO [EDI.Service].[EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,Yearid,EntityName,EntityField,NewfoundlandandLabrador)VALUES(48, 34, 5, 0, 0, 'NonParental2', 0, Null, Null, Null, 'Null', 'Other home-based, unlicensed, relative', 'Other home-based, unlicensed, relative', 'OtherHomeUnlicensedRelative', 0, 'Null', Null, 140, 1, 1, 'Null', 0, '', '', 1, 0, 'Null', '', '', 3, 'Questionnaires.Data.SectionE', 'OtherHomeUnlicensedRelative', 1)");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET English = 'Child''s home, non-relative' WHERE yearid = 3 and id = 1874 and QuestionnaireId = 48");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence = sequence + 10 WHERE yearid = 3 and Sequence> 150 and sequence<260 and QuestionnaireId = 48");
            migrationBuilder.Sql("INSERT INTO [EDI.Service].[EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,Yearid,EntityName,EntityField,NewfoundlandandLabrador)VALUES(48, 34, 5, 0, 0, 'NonParental2', 0, Null, Null, Null, 'Null', 'Child''s home, relative', 'Child''s home, relative', 'ChildHomeRelative', 0, 'Null', Null, 160, 1, 1, 'Null', 0, '', '', 1, 0, 'Null', '', '', 3, 'Questionnaires.Data.SectionE', 'ChildHomeRelative', 1)");

            /* github 172 MB Demographics */
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET LookupEntityId = 102 WHERE yearid = 3 and id = 1915 and QuestionnaireId = 51");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET LookupEntityId = 86 WHERE yearid = 3 and id = 1919 and QuestionnaireId = 51");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET LookupEntityId = 124 WHERE yearid = 3 and id = 1922 and QuestionnaireId = 51");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence = 240, groupname = 'Languages' WHERE yearid = 3 and id = 1930 and QuestionnaireId = 51");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Manitoba = 0 WHERE id = 1936 AND Yearid = 3 AND QuestionnaireID = 51");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Manitoba = 1 WHERE id = 1929 AND Yearid = 3 AND QuestionnaireID = 51");
            migrationBuilder.Sql("INSERT INTO [EDI.Service].[EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,Yearid,EntityName,EntityField,Manitoba)VALUES(51, 35, 5, 0, 0, 'Languages', 0, Null, Null, Null, Null, '', '', 'FirstLanguage2', 1, 'LookupSets', 91, 180, 1, 1, 'NULL', 0, '', '', 0, 0, 'null', '', '', 3, 'Questionnaires.Data.Demographics', 'FirstLanguage2', 1)");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET English = 'Child Considered EAL/FAL:', French = 'Child Considered EAL/FAL:', LookupEntityId = 125 WHERE id = 1925 AND Yearid = 3 AND QuestionnaireID = 51");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET English = 'Child''s Date of Birth:',French = 'Date de naissance de l''enfant:' WHERE id = 1918 AND Yearid = 3 AND QuestionnaireID = 51");

            /* github 173 MB Section E */
            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration] SET Manitoba = 1 WHERE id in (1941, 1942) AND Yearid = 3 AND QuestionnaireID = 52");
            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration] SET English = 'Has been in non-parental care on a regular basis prior to kindergarten entry' WHERE id = 1945 AND Yearid = 3 AND QuestionnaireID = 52");
            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration] SET Manitoba = 0 WHERE id in (1950, 1966, 1967) AND Yearid = 3 AND QuestionnaireID = 52");
            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration] SET English = 'If you have any additional comments about this child and her/his readiness for school, list them below.<br /> *** Please do not use children''s name in any comments. ***' WHERE id = 1959 AND Yearid = 3 AND QuestionnaireID = 52");
            migrationBuilder.AddColumn<byte>(
                name: "FirstNations",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Inuit",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Metis",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "OtherIndigenous",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "tinyint",
                nullable: true);
            
            migrationBuilder.Sql("INSERT INTO [EDI.Service].[EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,Yearid,EntityName,EntityField,Manitoba)VALUES(52, 34, 5, 0, 0, 'NonParental2', 0, Null, Null, Null, 'Null', 'Other home-based, unlicensed, relative', 'Other home-based, unlicensed, relative', 'OtherHomeUnlicensedRelative', 0, 'Null', Null, 150, 1, 1, 'Null', 0, '', '', 1, 0, 'Null', '', '', 3, 'Questionnaires.Data.SectionE', 'OtherHomeUnlicensedRelative', 1)");
            migrationBuilder.Sql("INSERT INTO [EDI.Service].[EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,Yearid,EntityName,EntityField,Manitoba)VALUES(52, 39, 5, 1, 0, 'NonParental4', 1, Null, Null, Null, 'Null', '', '', 'NULL', 0, 'NULL', NULL, 260, 1, 1, 'NULL', 0, '', '', 0, 0, 'null', '', '', 3, 'Questionnaires.Data.SectionE', 'NULL', 1)");
            migrationBuilder.Sql("INSERT INTO [EDI.Service].[EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,Yearid,EntityName,EntityField,Manitoba)VALUES(52, 30, 5, 1, 0, 'NonParental4', 0, Null, Null, Null, 'Null', 'If you answered ''yes'' to Indigenous status (page 1) please elaborate (check all that apply)', 'Si vous avez répondu « oui » à la question sur le statut d''Autochtone (page 1), veuillez préciser (cochez tout ce qui s''applique)', 'NULL', 1, 'LookupSets', 78, 270, 5, 1, 'NULL', 0, '', '', 0, 0, 'null', '', '', 3, 'Questionnaires.Data.SectionE', 'NULL', 1)");
            migrationBuilder.Sql("INSERT INTO [EDI.Service].[EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,Yearid,EntityName,EntityField,Manitoba)VALUES(52, 30, 5, 0, 0, 'NonParental4', 0, Null, Null, Null, 'Null', 'First Nations', 'Premières nations', 'FirstNations', 1, 'LookupSets', 78, 280, 5, 1, 'Null', 0, '', '', 1, 0, 'Null', '', '', 3, 'Questionnaires.Data.SectionE', 'FirstNations', 1)");
            migrationBuilder.Sql("INSERT INTO [EDI.Service].[EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,Yearid,EntityName,EntityField,Manitoba)VALUES(52, 30, 5, 0, 0, 'NonParental4', 0, Null, Null, Null, 'Null', 'Inuit', 'Inuits', 'Inuit', 1, 'LookupSets', 78, 290, 5, 1, 'Null', 0, '', '', 1, 0, 'Null', '', '', 3, 'Questionnaires.Data.SectionE', 'Inuit', 1)");
            migrationBuilder.Sql("INSERT INTO [EDI.Service].[EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,Yearid,EntityName,EntityField,Manitoba)VALUES(52, 30, 5, 0, 0, 'NonParental4', 0, Null, Null, Null, 'Null', 'Metis', 'Métis', 'Metis', 1, 'LookupSets', 78, 300, 5, 1, 'Null', 0, '', '', 1, 0, 'Null', '', '', 3, 'Questionnaires.Data.SectionE', 'Metis', 1)");
            migrationBuilder.Sql("INSERT INTO [EDI.Service].[EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,Yearid,EntityName,EntityField,Manitoba)VALUES(52, 30, 5, 0, 0, 'NonParental4', 0, Null, Null, Null, 'Null', 'Other', 'Autre', 'OtherIndigenous', 1, 'LookupSets', 78, 310, 5, 1, 'Null', 0, '', '', 1, 0, 'Null', '', '', 3, 'Questionnaires.Data.SectionE', 'OtherIndigenous', 1)");


            /* github 179 Gender PreFill */
            migrationBuilder.Sql("UPDATE [EDI.Service].[LUData].[LookupSetOptions] SET Value = 6 WHERE yearid = 3 and id in(665, 862, 963)");
            migrationBuilder.Sql("UPDATE [EDI.Service].[LUData].[LookupSetOptions] SET Value = 7 WHERE yearid = 3 and id in(664, 863, 964)");
            migrationBuilder.Sql("UPDATE [EDI.Service].[LUData].[LookupSetOptions] SET Value = 8 WHERE yearid = 3 and id in(861, 962)");

            /* github 181 Immigatrated */
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence = sequence + 10  WHERE QuestionnaireId = 34 and Yearid = 3 and sequence > 180 and sequence<500");
            migrationBuilder.Sql("INSERT INTO [EDI.Service].[EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber], HasHelp, HelpTextEnglish, HelpTextFrench, IsRequired, HasNotification, NotificationCondition,[Notification], NotificationFrench, Yearid, EntityName, EntityField, NorthwestTerritories)VALUES(34, 31, 5, 0, 0, 'Demographics', 0, Null, Null, Null, Null, 'Child has immigrated to Canada within the last 2 years:', 'Child has immigrated to Canada within the last 2 years:', 'Immigrated', 1, 'LookupSets', 78, 190, 5, 1, Null, 0, '', '', 1, 0, Null, '', '', 3, 'Questionnaires.Data.Demographics', 'Immigrated', 1)");

            /* github 197 Ethnic Status */
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET isrequired = 1 WHERE QuestionnaireId = 34 and Yearid = 3 and English = 'Ethnic Status'");

            /* github 212 ChildrenBySite Report - adding Manitoba*/
            var sp = @"USE [EDI.Service]
GO
/****** Object:  StoredProcedure [Reports].[GetChildrenDataByProvince]    Script Date: 2/22/2023 2:30:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [Reports].[GetChildrenDataByProvince] 
	-- Add the parameters for the stored procedure here
	@ProvinceId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DECLARE @Columns NVARCHAR(MAX) 
	DECLARE @SQL NVARCHAR(MAX) 
	DECLARE @Province nvarchar(100)
	DECLARE @Questionnaires nvarchar(max)
	DECLARE @YearId INT
	DECLARE @Year NVARCHAR(4)

	SELECT @Year = fieldvalue FROM [dbo].[SystemConfigurations] WHERE FieldName = 'Year'

	SELECT @YearId = ID FROM [LUData].[Years] WHERE EDIYear = @Year

	-- get the province of the site 
	SELECT @Province = replace(p.English,' ','')
	FROM LUData.Provinces p 
	WHERE p.EDICode = @ProvinceId AND p.YearId = @YearId
	--Print @Province		
	
	-- get the columnnames from the config table
		SET @Columns = 
		Case @Province
			WHEN 'NorthwestTerritories' THEN 
				(SELECT ',[EDI].[' + [Config].[EntityName] + '].[' +  [EntityField] + '] as ' + [Config].[VariableName]   --AS [data()] 
				FROM [EDI].[Questionnaires.Configuration] config
				LEFT JOIN [EDI].[Questionnaires] q ON q.Id = config.QuestionnaireId
				WHERE config.EntityField is not null AND len(trim(config.EntityField)) > 0 AND Config.EntityField NOT IN ('CompletedQuestions', 'requiredQuestions','isComplete','QuestionnaireID','LanguageCompleted') 
				AND config.QuestionnaireID in (SELECT ID 	
						FROM [EDI].[Questionnaires]
						WHERE [NorthwestTerritories] =1 AND IsChildQuestionnaire=1 AND YearId = @YearId)
				FOR XML PATH(''))		 
			WHEN 'NovaScotia' THEN 
				(SELECT ',[EDI].[' + [Config].[EntityName] + '].[' +  [EntityField] + '] as ' + [Config].[VariableName]   --AS [data()] 
				FROM [EDI].[Questionnaires.Configuration] config
				LEFT JOIN [EDI].[Questionnaires] q ON q.Id = config.QuestionnaireId
				WHERE config.EntityField is not null AND len(trim(config.EntityField)) > 0 AND Config.EntityField NOT IN ('CompletedQuestions', 'requiredQuestions','isComplete','QuestionnaireID','LanguageCompleted') 
				AND config.QuestionnaireID in (SELECT ID 	
						FROM [EDI].[Questionnaires]
						WHERE [NovaScotia] =1 AND IsChildQuestionnaire=1 AND YearId = @YearId)
				FOR XML PATH(''))
			WHEN 'Ontario' THEN 
				(SELECT ',[EDI].[' + [Config].[EntityName] + '].[' +  [EntityField] + '] as ' + [Config].[VariableName]   --AS [data()] 
				FROM [EDI].[Questionnaires.Configuration] config
				LEFT JOIN [EDI].[Questionnaires] q ON q.Id = config.QuestionnaireId
				WHERE config.EntityField is not null AND len(trim(config.EntityField)) > 0 AND Config.EntityField NOT IN ('CompletedQuestions', 'requiredQuestions','isComplete','QuestionnaireID','LanguageCompleted') 
				AND config.QuestionnaireID in (SELECT ID 	
						FROM [EDI].[Questionnaires]
						WHERE [Ontario] =1 AND IsChildQuestionnaire=1 AND YearId = @YearId)
				FOR XML PATH(''))
			WHEN 'NewYork' THEN 
				(SELECT ',[EDI].[' + [Config].[EntityName] + '].[' +  [EntityField] + '] as ' + [Config].[VariableName]   --AS [data()] 
				FROM [EDI].[Questionnaires.Configuration] config
				LEFT JOIN [EDI].[Questionnaires] q ON q.Id = config.QuestionnaireId
				WHERE config.EntityField is not null AND len(trim(config.EntityField)) > 0 AND Config.EntityField NOT IN ('CompletedQuestions', 'requiredQuestions','isComplete','QuestionnaireID','LanguageCompleted') 
				AND config.QuestionnaireID in (SELECT ID 	
						FROM [EDI].[Questionnaires]
						WHERE [NewYork] =1 AND IsChildQuestionnaire=1 AND YearId = @YearId)
				FOR XML PATH(''))			
			WHEN 'NewfoundlandandLabrador' THEN 
				(SELECT ',[EDI].[' + [Config].[EntityName] + '].[' +  [EntityField] + '] as ' + [Config].[VariableName]   --AS [data()] 
				FROM [EDI].[Questionnaires.Configuration] config
				LEFT JOIN [EDI].[Questionnaires] q ON q.Id = config.QuestionnaireId
				WHERE config.EntityField is not null AND len(trim(config.EntityField)) > 0 AND Config.EntityField NOT IN ('CompletedQuestions', 'requiredQuestions','isComplete','QuestionnaireID','LanguageCompleted') 
				AND config.QuestionnaireID in (SELECT ID 	
						FROM [EDI].[Questionnaires]
						WHERE NewfoundlandandLabrador =1 AND IsChildQuestionnaire=1 AND YearId = @YearId)
				FOR XML PATH(''))
			WHEN 'PrinceEdwardIsland' THEN 
				(SELECT ',[EDI].[' + [Config].[EntityName] + '].[' +  [EntityField] + '] as ' + [Config].[VariableName]   --AS [data()] 
				FROM [EDI].[Questionnaires.Configuration] config
				LEFT JOIN [EDI].[Questionnaires] q ON q.Id = config.QuestionnaireId
				WHERE config.EntityField is not null AND len(trim(config.EntityField)) > 0 AND Config.EntityField NOT IN ('CompletedQuestions', 'requiredQuestions','isComplete','QuestionnaireID','LanguageCompleted') 
				AND config.QuestionnaireID in (SELECT ID 	
						FROM [EDI].[Questionnaires]
						WHERE PrinceEdwardIsland =1 AND IsChildQuestionnaire=1 AND YearId = @YearId)
				FOR XML PATH(''))
			WHEN 'Manitoba' THEN 
				(SELECT ',[EDI].[' + [Config].[EntityName] + '].[' +  [EntityField] + '] as ' + [Config].[VariableName]   --AS [data()] 
				FROM [EDI].[Questionnaires.Configuration] config
				LEFT JOIN [EDI].[Questionnaires] q ON q.Id = config.QuestionnaireId
				WHERE config.EntityField is not null AND len(trim(config.EntityField)) > 0 AND Config.EntityField NOT IN ('CompletedQuestions', 'requiredQuestions','isComplete','QuestionnaireID','LanguageCompleted') 
				AND config.QuestionnaireID in (SELECT ID 	
						FROM [EDI].[Questionnaires]
						WHERE Manitoba =1 AND IsChildQuestionnaire=1 AND YearId = @YearId)
				FOR XML PATH(''))
			END 
	--PRINT @Columns 

		SET @SQL = 'SELECT child.Ediid as edi_id,left(child.Ediid,2) as Year,left(child.Ediid,4) as ProvinceId,p.English as Province,left(child.Ediid,7) as SiteID,left(child.Ediid,10) as SchoolId,sc.SchoolName,left(child.Ediid,13) as ClassTimeId,left(child.Ediid,15) as StudentId,child.LocalId,cs.English as StudentStatus,child.CreatedBy,child.ModifiedDate, [EDI].[Questionnaires.Data.Demographics].[LanguageCompleted] LanguageCompleted_Demographics
	,[EDI].[Questionnaires.Data.SectionA].[LanguageCompleted] LanguageCompleted_A,[EDI].[Questionnaires.Data.SectionB].[LanguageCompleted] LanguageCompleted_B ,[EDI].[Questionnaires.Data.SectionC].[LanguageCompleted] LanguageCompleted_C,[EDI].[Questionnaires.Data.SectionD].[LanguageCompleted] LanguageCompleted_D,[EDI].[Questionnaires.Data.SectionE].[LanguageCompleted] LanguageCompleted_E ' + @Columns + '	
	FROM [EDI].[Children] child 
	LEFT JOIN [EDI].[Questionnaires.Data.Demographics] ON [EDI].[Questionnaires.Data.Demographics].ChildId = child.id 
	LEFT JOIN [EDI].[Questionnaires.Data.SectionA] ON [EDI].[Questionnaires.Data.SectionA].childID= child.id 
	LEFT JOIN [EDI].[Questionnaires.Data.SectionB] ON [EDI].[Questionnaires.Data.SectionB].childID = child.id 
	LEFT JOIN [EDI].[Questionnaires.Data.SectionC] ON [EDI].[Questionnaires.Data.SectionC].childID = child.id 
	LEFT JOIN [EDI].[Questionnaires.Data.SectionD] ON [EDI].[Questionnaires.Data.SectionD].childID = child.id  
	LEFT JOIN [EDI].[Questionnaires.Data.SectionE] ON [EDI].[Questionnaires.Data.SectionE].childID = child.id  	
	LEFT JOIN [LUData].[Years] y ON child.YearId = y.[Id]
	LEFT JOIN [EDI].[Teachers] t ON child.TeacherId = t.Id
	LEFT JOIN [EDI].[Schools] sc ON t.SchoolId = sc.Id
	LEFT JOIN [EDI].[Sites] s ON sc.SiteId = s.Id
	LEFT JOIN LUData.Provinces p ON p.Id = sc.ProvinceId
	LEFT JOIN [LUData].[ChildStatus] cs ON child.ChildStatusId = cs.Id
	WHERE p.EDICode =' + CAST(@ProvinceId as varchar(2)) + ' AND child.YearId = ' + CAST(@YearId as varchar)
	
	EXEC sp_executesql @sql;
END
";

            //	Update the teacher data SP
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstNations",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "Inuit",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "Metis",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "OtherIndigenous",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

        }
    }
}
