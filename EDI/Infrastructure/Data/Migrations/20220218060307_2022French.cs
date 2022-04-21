using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2022French : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "OnlineChallengesLimitedTech",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OnlineChallengesNA",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OnlineChallengesNoAdultSupport",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OnlineChallengesNoInternet",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OnlineChallengesNoLearningSpace",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OnlineChallengesNoSupplies",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OnlineChallengesOther",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OnlineChallengesUninterested",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics",
                type: "bit",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "French",
                schema: "LUData",
                table: "LookupSetOptions",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "English",
                schema: "LUData",
                table: "LookupSetOptions",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            // update the lookupsetoption french after the column is expanded
            migrationBuilder.Sql("UPDATE [LUData].[LookupSetOptions] SET French = 'Disponibilité limitée des technologies(ne possède pas d’ordinateur / de portable / d’autre appareil électronique ou les appareils sont utilisés par les parents ou leurs frères ou soeurs)' WHERE Id = 617");

            // update existing reponses into checkboxes
            migrationBuilder.Sql("UPDATE[EDI].[Questionnaires.Data.Demographics] SET OnlineChallengesNA = 1  WHERE [OnlineChallenges] = 1");
            migrationBuilder.Sql("UPDATE[EDI].[Questionnaires.Data.Demographics] SET OnlineChallengesNoInternet = 1  WHERE [OnlineChallenges] = 2");
            migrationBuilder.Sql("UPDATE[EDI].[Questionnaires.Data.Demographics] SET OnlineChallengesLimitedTech = 1  WHERE [OnlineChallenges] = 3");
            migrationBuilder.Sql("UPDATE[EDI].[Questionnaires.Data.Demographics] SET OnlineChallengesNoAdultSupport = 1  WHERE [OnlineChallenges] = 4");
            migrationBuilder.Sql("UPDATE[EDI].[Questionnaires.Data.Demographics] SET OnlineChallengesNoSupplies = 1  WHERE [OnlineChallenges] = 7");
            migrationBuilder.Sql("UPDATE[EDI].[Questionnaires.Data.Demographics] SET OnlineChallengesOther = 1  WHERE [OnlineChallenges] = 8");

            // ONTARIO NWT NS - Make room for new questions and update the group name
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence = Sequence+100, GroupName = 'Challenges' WHERE YearId = 2 AND QuestionnaireId IN (25,16) AND Sequence > 370");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence = Sequence+220, GroupName = 'Challenges' WHERE YearId = 2 AND QuestionnaireId IN (22) AND Sequence > 250");

            // add new ontario questions
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[Ontario]) VALUES(25,25,3,1,0,'Challenges',1,Null,Null,Null,Null,'','',Null,0,Null,NULL,380,1,1,'1' ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[Ontario]) VALUES(25,24,3,1,0,'Challenges',0,Null,Null,Null,Null,'Are you aware whether this child experienced any challenges with online instruction last year? (e.g. from your experience, told to you by parents or another teacher, etc).<br />Select all that apply','Savez-vous si l''enfant a fait face à des défis avec l''enseignement en ligne l''année passée ? (p. ex. d''après votre expérience, d''après l''information reçue des parents ou d''un autre enseignant, etc.). Veuillez sélectionner toutes les options qui s''appliquent.',Null,0,Null,NULL,390,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[Ontario]) VALUES(25,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'Not applicable (no online learning took place or child opted out all together)','Sans objet (il n''y a pas eu d''enseignement en ligne ou l''enfant n''a pas participé)','OnlineChallengesNA',0,Null,Null,400,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesNA' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[Ontario]) VALUES(25,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'Limited or no internet access','Manque d''accès à l''internet ou un accès limité','OnlineChallengesNoInternet',0,Null,Null,410,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesNoInternet' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[Ontario]) VALUES(25,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'Limited technology availability (computer/laptop/other devices not owned or being used by parent/siblings)','Disponibilité limitée des technologies (ne possède pas d''ordinateur / de portable / d''autre appareil électronique ou les appareils sont utilisés par les parents ou leurs frères ou soeurs)','OnlineChallengesLimitedTech',0,Null,Null,420,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesLimitedTech' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[Ontario]) VALUES(25,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'No adult available to support the child during instruction time','Aucun adulte n''était disponible pour soutenir l''enfant durant le temps d''enseignement en ligne','OnlineChallengesNoAdultSupport',0,Null,Null,430,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesNoAdultSupport' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[Ontario]) VALUES(25,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'Child uninterested in participating/short attention span','Un manque d''intérêt de la part de l''enfant à participer  / capacité d''attention limitée','OnlineChallengesUninterested',0,Null,Null,440,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesUninterested' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[Ontario]) VALUES(25,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'Child did not have setting/space appropriate for learning','L''enfant n''avait pas d''endroit ou d''espace approprié pour l''apprentissage','OnlineChallengesNoLearningSpace',0,Null,Null,450,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesNoLearningSpace' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[Ontario]) VALUES(25,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'Child did not have access to needed school supplies (other than technology) to fully participate in activities','L''enfant n''avait pas accès aux fournitures scolaires nécessaires (autre que la technologie) afin de participer aux activités','OnlineChallengesNoSupplies',0,Null,Null,460,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesNoSupplies' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[Ontario]) VALUES(25,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'Other','Autre (veuillez préciser)','OnlineChallengesOther',0,Null,Null,470,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesOther' ,2,1)");

            // add new NWT questions
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,Northwestterritories) VALUES(16,25,3,1,0,'Challenges',1,Null,Null,Null,Null,'','',Null,0,Null,NULL,380,1,1,'1' ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,Northwestterritories) VALUES(16,24,3,1,0,'Challenges',0,Null,Null,Null,Null,'Are you aware whether this child experienced any challenges with online instruction last year? (e.g. from your experience, told to you by parents or another teacher, etc).<br />Select all that apply','Savez-vous si l''enfant a fait face à des défis avec l''enseignement en ligne l''année passée ? (p. ex. d''après votre expérience, d''après l''information reçue des parents ou d''un autre enseignant, etc.). Veuillez sélectionner toutes les options qui s''appliquent.',Null,0,Null,NULL,390,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,Northwestterritories) VALUES(16,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'Not applicable (no online learning took place or child opted out all together)','Sans objet (il n''y a pas eu d''enseignement en ligne ou l''enfant n''a pas participé)','OnlineChallengesNA',0,Null,Null,400,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesNA' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,Northwestterritories) VALUES(16,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'Limited or no internet access','Manque d''accès à l''internet ou un accès limité','OnlineChallengesNoInternet',0,Null,Null,410,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesNoInternet' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,Northwestterritories) VALUES(16,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'Limited technology availability (computer/laptop/other devices not owned or being used by parent/siblings)','Disponibilité limitée des technologies (ne possède pas d''ordinateur / de portable / d''autre appareil électronique ou les appareils sont utilisés par les parents ou leurs frères ou soeurs)','OnlineChallengesLimitedTech',0,Null,Null,420,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesLimitedTech' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,Northwestterritories) VALUES(16,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'No adult available to support the child during instruction time','Aucun adulte n''était disponible pour soutenir l''enfant durant le temps d''enseignement en ligne','OnlineChallengesNoAdultSupport',0,Null,Null,430,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesNoAdultSupport' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,Northwestterritories) VALUES(16,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'Child uninterested in participating/short attention span','Un manque d''intérêt de la part de l''enfant à participer  / capacité d''attention limitée','OnlineChallengesUninterested',0,Null,Null,440,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesUninterested' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,Northwestterritories) VALUES(16,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'Child did not have setting/space appropriate for learning','L''enfant n''avait pas d''endroit ou d''espace approprié pour l''apprentissage','OnlineChallengesNoLearningSpace',0,Null,Null,450,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesNoLearningSpace' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,Northwestterritories) VALUES(16,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'Child did not have access to needed school supplies (other than technology) to fully participate in activities','L''enfant n''avait pas accès aux fournitures scolaires nécessaires (autre que la technologie) afin de participer aux activités','OnlineChallengesNoSupplies',0,Null,Null,460,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesNoSupplies' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,Northwestterritories) VALUES(16,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'Other','Autre (veuillez préciser)','OnlineChallengesOther',0,Null,Null,470,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesOther' ,2,1)");

            // add new NS questions
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NovaScotia]) VALUES(22,25,3,1,0,'Challenges',1,Null,Null,Null,Null,'','',Null,0,Null,NULL,380,1,1,'1' ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NovaScotia]) VALUES(22,24,3,1,0,'Challenges',0,Null,Null,Null,Null,'Are you aware whether this child experienced any challenges with online instruction last year? (e.g. from your experience, told to you by parents or another teacher, etc).<br />Select all that apply','Savez-vous si l''enfant a fait face à des défis avec l''enseignement en ligne l''année passée ? (p. ex. d''après votre expérience, d''après l''information reçue des parents ou d''un autre enseignant, etc.). Veuillez sélectionner toutes les options qui s''appliquent.',Null,0,Null,NULL,390,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NovaScotia]) VALUES(22,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'Not applicable (no online learning took place or child opted out all together)','Sans objet (il n''y a pas eu d''enseignement en ligne ou l''enfant n''a pas participé)','OnlineChallengesNA',0,Null,Null,400,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesNA' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NovaScotia]) VALUES(22,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'Limited or no internet access','Manque d''accès à l''internet ou un accès limité','OnlineChallengesNoInternet',0,Null,Null,410,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesNoInternet' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NovaScotia]) VALUES(22,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'Limited technology availability (computer/laptop/other devices not owned or being used by parent/siblings)','Disponibilité limitée des technologies (ne possède pas d''ordinateur / de portable / d''autre appareil électronique ou les appareils sont utilisés par les parents ou leurs frères ou soeurs)','OnlineChallengesLimitedTech',0,Null,Null,420,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesLimitedTech' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NovaScotia]) VALUES(22,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'No adult available to support the child during instruction time','Aucun adulte n''était disponible pour soutenir l''enfant durant le temps d''enseignement en ligne','OnlineChallengesNoAdultSupport',0,Null,Null,430,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesNoAdultSupport' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NovaScotia]) VALUES(22,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'Child uninterested in participating/short attention span','Un manque d''intérêt de la part de l''enfant à participer  / capacité d''attention limitée','OnlineChallengesUninterested',0,Null,Null,440,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesUninterested' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NovaScotia]) VALUES(22,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'Child did not have setting/space appropriate for learning','L''enfant n''avait pas d''endroit ou d''espace approprié pour l''apprentissage','OnlineChallengesNoLearningSpace',0,Null,Null,450,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesNoLearningSpace' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NovaScotia]) VALUES(22,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'Child did not have access to needed school supplies (other than technology) to fully participate in activities','L''enfant n''avait pas accès aux fournitures scolaires nécessaires (autre que la technologie) afin de participer aux activités','OnlineChallengesNoSupplies',0,Null,Null,460,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesNoSupplies' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NovaScotia]) VALUES(22,20,3,0,0,'Challenges',0,Null,Null,Null,Null,'Other','Autre (veuillez préciser)','OnlineChallengesOther',0,Null,Null,470,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesOther' ,2,1)");

            // Hide the old question from the 3 provinces            
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET ONTARIO = 0, Northwestterritories = 0, NovaScotia = 0 WHERE ID IN(1107,1114,1118)"); 
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OnlineChallengesLimitedTech",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "OnlineChallengesNA",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "OnlineChallengesNoAdultSupport",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "OnlineChallengesNoInternet",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "OnlineChallengesNoLearningSpace",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "OnlineChallengesNoSupplies",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "OnlineChallengesOther",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "OnlineChallengesUninterested",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.AlterColumn<string>(
                name: "French",
                schema: "LUData",
                table: "LookupSetOptions",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "English",
                schema: "LUData",
                table: "LookupSetOptions",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET ONTARIO = 0, Northwestterritories = 0, NovaScotia = 1 WHERE ID IN(1107)");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET ONTARIO = 0, Northwestterritories = 1, NovaScotia = 0 WHERE ID IN(1114)");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET ONTARIO = 1, Northwestterritories = 0, NovaScotia = 0 WHERE ID IN(1118)");
        }
    }
}
