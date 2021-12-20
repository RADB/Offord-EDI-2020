﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2022Newfoundland : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			// remove yearid 3 (2020) - reseed the years table
			migrationBuilder.Sql("DELETE FROM[EDI.Service].[EDI].[Coordinators] WHERE Yearid = 3");
			migrationBuilder.Sql("DELETE from[EDI.Service].[LUData].[Years] where id = 3");
			migrationBuilder.Sql("DBCC CHECKIDENT('[EDI.Service].[LUData].[Years]', RESEED, 2)");

            // Insert the orientations
            migrationBuilder.Sql("INSERT INTO[EDI.Service].[LUData].[Orientations]([YearId],[English],[French],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy])	SELECT 2,[English],[French],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy] FROM[EDI.Service].[LUData].[Orientations] WHERE YeariD = 1");

            // data corrections 
            migrationBuilder.Sql("UPDATE[EDI.Service].[LUData].[Provinces] SET CountryID = CountryID + 240 where yearid = 2 AND countryId <= 240");
            migrationBuilder.Sql("UPDATE[EDI.Service].[LUData].[Countries] SET French = 'United States' WHERE code = 840");
            migrationBuilder.Sql("UPDATE[EDI.Service].[LUData].[Countries] SET French = 'Tanzania, United Republic of ' WHERE code = 834");
            migrationBuilder.Sql("UPDATE[EDI.Service].[LUData].[Years] SET [NewfoundlandandLabrador]=1, PrinceEdwardIsland=1 WHERE EDIYear=2022");
            migrationBuilder.Sql("UPDATE[EDI].[Questionnaires.Configuration] SET [LookupEntityId] = [LookupEntityId] + 34 WHERE YearId = 2 AND [LookupEntityId] < 35 ");
            migrationBuilder.Sql("UPDATE[EDI].[Questionnaires.Configuration] SET OrientationId = OrientationID + 2 WHERE YearId = 2 AND [OrientationID] < 3 ");
            migrationBuilder.Sql("UPDATE[EDI].[Questionnaires.Configuration] SET InputTypeId = InputTypeId + 14 WHERE YearId = 2 AND [InputTypeId] < 15 ");

            // adding newfoundland and labrador
            migrationBuilder.Sql("UPDATE [LUData].[Provinces] SET EDICode = 07 WHERE YearId = 2 AND English Like 'Newfoundland%'");

            // adding PEI
            migrationBuilder.Sql("UPDATE [LUData].[Provinces] SET EDICode = 11 WHERE YearId = 2 AND English Like 'Prince%'");


            // add questionnaires for newfoundland and labrador (Teacher Feedback, Section A, B, C, D) and PEI
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires] SET [NewfoundlandandLabrador] = 1, [PrinceEdwardIsland] = 1 WHERE YearId = 2 AND ID IN (15, 17,18,19,24)");
			migrationBuilder.InsertData(
			schema: "EDI",
			table: "Questionnaires",
			columns: new[] { "Id", "Alberta", "BritishColumbia", "CreatedBy", "CreatedDate", "DescriptionEnglish", "DescriptionFrench", "English", "EntityName", "French", "IsChildQuestionnaire", "IsTeacherQuestionnaire", "Manitoba", "ModifiedBy", "ModifiedDate", "NewBrunswick", "NewYork", "NewfoundlandandLabrador", "NorthwestTerritories", "NovaScotia", "Nunavut", "Ontario", "PrinceEdwardIsland", "Quebec", "QuestionnaireName", "QuestionsRequired", "Saskatchewan", "Sequence", "ShowProgressBar", "ShowQuestionNumbers", "YearId", "YukonTerritory" },
			values: new object[,]
			{
					{ 29, null, null, "admin", new DateTime(2021, 12, 1, 11, 46, 46, 18, DateTimeKind.Local).AddTicks(1986), "Demographics", "Demographics", "Demographics", "Questionnaires.Data.Demographics", "Demographics", true, false, null, "admin", new DateTime(2021, 12, 1, 11, 46, 46, 18, DateTimeKind.Local).AddTicks(1987), null, null, true, null, null, null, null, null, null, "Demographics", 0, null, 10, true, true, 2, null },
					{ 30, null, null, "admin", new DateTime(2021, 12, 1, 11, 46, 46, 18, DateTimeKind.Local).AddTicks(1990), "Section E", "Section E", "Section E", "Questionnaires.Data.SectionE", "Section E", true, false, null, "admin", new DateTime(2021, 12, 1, 11, 46, 46, 18, DateTimeKind.Local).AddTicks(1992), null, null, true, null, null, null, null, null, null, "Section E", 0, null, 60, true, true, 2, null },
                    { 31, null, null, "admin", new DateTime(2021, 12, 1, 11, 46, 46, 18, DateTimeKind.Local).AddTicks(1986), "Demographics", "Demographics", "Demographics", "Questionnaires.Data.Demographics", "Demographics", true, false, null, "admin", new DateTime(2021, 12, 1, 11, 46, 46, 18, DateTimeKind.Local).AddTicks(1987), null, null, null, null, null, null, null, true, null, "Demographics", 0, null, 10, true, true, 2, null },
                    { 32, null, null, "admin", new DateTime(2021, 12, 1, 11, 46, 46, 18, DateTimeKind.Local).AddTicks(1990), "Section E", "Section E", "Section E", "Questionnaires.Data.SectionE", "Section E", true, false, null, "admin", new DateTime(2021, 12, 1, 11, 46, 46, 18, DateTimeKind.Local).AddTicks(1992), null, null, null, null, null, null, null, true, null, "Section E", 0, null, 60, true, true, 2, null }
            });

            migrationBuilder.InsertData(
            schema: "LUData",
            table: "LookupSets",
            columns: new[] { "Id", "CreatedBy", "CreatedDate", "LookupName", "ModifiedBy", "ModifiedDate", "YearId" },
            values: new object[,]
            {
                { 73, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6372), "InstructionFormat", "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6373), 2 },
                { 74, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6375), "OnlineChallenges", "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6376), 2 },
                { 75, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6378), "ELL", "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(6379), 2 }
            });

            migrationBuilder.InsertData(
            schema: "LUData",
            table: "LookupSetOptions",
            columns: new[] { "Id", "CreatedBy", "CreatedDate", "English", "French", "LookupSetId", "ModifiedBy", "ModifiedDate", "Sequence", "Value", "YearId" },
            values: new object[,]
            {
                { 610, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7429), "All in person, normal school hours", "En présentiel avec un nombre d'heures de classe normal", 73, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7431), (short)10, (short)1, 2 },
                { 611, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7433), "Hybrid instruction, some in person, some online instruction", "Format hybride avec un certain montant d'enseignement en présentiel et d'autre en virtuel", 73, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7434), (short)20, (short)2, 2 },
                { 612, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7436), "All online instruction, regular online meetings with students (daily or weekly)", "Enseignement virtuel avec des rencontres quotidiennes ou hebdomadaires en ligne avec les élèves", 73, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7438), (short)30, (short)3, 2 },
                { 613, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7440), "All online, independent study student/family paced, no regular virtual meetings", "Enseignement virtuel asynchrone, au rythme de l'élève/la famille, aucune rencontre en ligne sur une base régulière", 73, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7442), (short)40, (short)4, 2 },
                { 614, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7444), "Other", "Autre", 73, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7446), (short)50, (short)5, 2 },
                { 615, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7448), "Not applicable (no online learning took place or child opted out all together)", "Not applicable (no online learning took place or child opted out all together)", 74, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7449), (short)10, (short)1, 2 },
                { 616, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7452), "Limited or no internet access", "Limited or no internet access", 74, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7453), (short)20, (short)2, 2 },
                { 617, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7455), "Limited technology availability (computer/laptop/other devices not owned or being used by parent/siblings)", "Limited technology availability (computer/laptop/other devices not owned or being used by parent/siblings)", 74, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7457), (short)30, (short)3, 2 },
                { 618, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7459), "No adult available to support the child during instruction time", "No adult available to support the child during instruction time", 74, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7461), (short)40, (short)4, 2 },
                { 619, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7463), "Child uninterested in participating/short attention span", "Child uninterested in participating/short attention span", 74, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7465), (short)50, (short)5, 2 },
                { 620, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7467), "Child did not have setting/space appropriate for learning", "Child did not have setting/space appropriate for learning", 74, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7468), (short)60, (short)6, 2 },
                { 621, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7471), "Child did not have access to needed school supplies (other than technology) to fully participate in activities", "Child did not have access to needed school supplies (other than technology) to fully participate in activities", 74, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7472), (short)70, (short)7, 2 },
                { 622, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7474), "Other", "Autre", 74, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7476), (short)80, (short)8, 2 },
                { 623, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7478), "ELL", "ELL", 75, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7480), (short)10, (short)1, 2 },
                { 624, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7482), "FLL", "FLL", 75, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7484), (short)20, (short)2, 2 },
                { 625, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7486), "No", "No", 75, "admin", new DateTime(2021, 12, 13, 23, 36, 20, 926, DateTimeKind.Local).AddTicks(7487), (short)30, (short)3, 2 }
            });

            //schema updates for newfoundland and labrador
            migrationBuilder.AddColumn<byte>(
			   name: "OrganizedPreSchool",
			   schema: "EDI",
			   table: "Questionnaires.Data.SectionE",
			   type: "tinyint",
			   nullable: true);

			migrationBuilder.AddColumn<byte>(
				name: "InstructionFormat",
				schema: "EDI",
				table: "Questionnaires.Data.Demographics",
				type: "tinyint",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "InstructionFormatSpecify",
				schema: "EDI",
				table: "Questionnaires.Data.Demographics",
				type: "nvarchar(max)",
				nullable: true);

			migrationBuilder.AddColumn<byte>(
				name: "OnlineChallenges",
				schema: "EDI",
				table: "Questionnaires.Data.Demographics",
				type: "tinyint",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "OnlineChallengesSpecify",
				schema: "EDI",
				table: "Questionnaires.Data.Demographics",
				type: "nvarchar(max)",
				nullable: true);

            ////NL Demographics
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,23,3,1,0,'Title',0,Null,Null,Null,Null,'Child Demographics','Données personnelles de l’enfant',Null,0,Null,Null,10,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,25,3,1,0,'Status',1,Null,Null,Null,Null,'','',Null,0,Null,NULL,20,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,17,3,0,0,'Status',0,Null,Null,Null,Null,'Student Status','Situation de l’élève','StudentStatus',1,'LookupSets',60,30,1,1,Null ,1,'<p><b>14. Student Status</b></p> <p>· Student must be currently in your class for you to complete the EDI. If the child is currently in your class but has been there for less than one month, do not complete the rest of the form. This applies to children who have entered the class at some time other than the beginning of the year or who have been off sick or travelling.</p> <p>· If the child has moved out of this class/school, do not complete the rest of the questionnaire.</p> <p>· If parents/guardians request that you do not assess their child, mark <b>other </b>and do not fill in the rest of the questionnaire.</p> <p>· If you are unsure who the student record refers to, or have never had this student in your class, select CHILD UNKNOWN TO TEACHER.</p>','<p><b>14. SSituation de l’élève</b></p><p>· Si l’enfant est dans votre classe depuis<b> moins d’un mois</b>, ne remplissez pas le restedu formulaire. Cela s’applique aux enfants qui se sont joints à la classe après la rentrée scolaire, qui ont été malades ou partis en voyage.</p><p>· De même, si l’enfant n’est plus dans cette classe/école ne remplissez pas le reste du formulaire.</p><p>· Si les parents/tuteurs ne veulent pas faire évaluer leur enfant, veuillez sélectionner <b>Autre </b>et ne remplissez pas le reste du questionnaire.</p><p>· Si vous n’êtes pas certaine(e) de quel enfant il s’agît ou si vous n’avez jamais eu cet enfant dans votre classe, veuillez sélectionner ÉLÈVE INCONNU À L’ENSEIGNANT(E).</p>',1,1,'>1','Student must currently be in your class to do the EDI. If the child is in your class but has been there for less than a month, if he/she has changed classes or schools, do not complete the rest of the form. Check for completeness and the finish/sent to McMaster.','Si l’enfant est dans votre classe depuis moins d’un mois, s’il n’est plus dans votre classe ou s’il a quitté l’école, ne complétez pas le reste du formulaire. Vérifiez l’état d’achèvement du questionnaire et faites le parvenir à McMaster.','Questionnaires.Data.Demographics','StudentStatus' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,25,3,1,0,'Demographics',1,Null,Null,Null,Null,'','',Null,0,Null,NULL,40,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,17,4,0,0,'Demographics',0,Null,Null,Null,Null,'Class Assignment:','Niveau d''inscription','ClassAssignment',1,'LookupSets',42,50,1,1,Null ,1,'<p><b>1. Class Assignment</b></p><p>· This question is usually pre-filled. You do not have to enter anything in this field. </p><p>· In the event you do have to answer this question, please answer as follows:</p><p>o Junior Kindergarten: a student turning 4 years by December 31 of the academic year</p><p>o Senior Kindergarten: Refers to a child in a class 1 year before starting Grade 1 or a student turning 5 years by December 31 of the academic year</p>','<p><b>1. Niveau d’inscription</b></p><p>· La réponse à cette question est habituellement remplie de façon automatique, donc dans la plupart des cas, vous n’aurez pas à répondre à cette question.</p><p>· Au cas où vous devez répondre à cette question, veuillez utiliser les désignations suivantes:</p><p>o Pré-maternelle (un élève qui aura 4 ans par le 31 décembre de l''année scolaire en question).</p><p>o Maternelle : correspond à un enfant qui fréquente une classe 1 an avant la 1<sup>ère</sup> année. </p>',1,0,Null,'','','Questionnaires.Data.Demographics','ClassAssignment' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,19,3,0,0,'Demographics',0,Null,Null,Null,Null,'Child''s Date of Birth:','Date de naissance de l''enfant','Dob',0,Null,Null,60,1,1,Null ,1,'<p><b>2. Child’s Date of Birth</b></p> <p>· Please complete only if the date of birth is INCORRECT.</p> <p>· If this information is missing or incorrect be sure to fill in the child’s actual date of birth.</p>','<p><b>2. Date de naissance</b></p><p>· Veuillez compléter seulement si la date de naissance est INEXACTE.</p><p>· Si cette information est manquante ou inexacte, veuillez inscrire la bonne date de naissance de l’enfant.</p>',1,0,Null,'','','Questionnaires.Data.Demographics','Dob' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,17,3,0,0,'Demographics',0,Null,Null,Null,Null,'Sex','Sexe','GenderId',1,'LookupSets',44,70,1,1,Null ,1,'<p><b>3. Child’s Sex</b></p> <p>· Please complete only if the child’s gender is INCORRECT.</p>','<p><b>3. Sexe de l’enfant</b></p><p>· Veuillez compléter seulement si le sexe de l’enfant est INEXACT.</p>',1,0,Null,'','','Questionnaires.Data.Demographics','GenderId' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,22,3,0,0,'Demographics',0,Null,Null,Null,Null,'Postal Code','Code postal','PostalCode',0,Null,Null,80,1,1,Null ,1,'<p><b>4. Child’s Postal Code</b></p> <p>· Please complete only if the child’s postal code is INCORRECT.</p>','<p><b>4. Code postal de l’enfant</b></p><p>· Veuillez compléter seulement si le code postal de l''enfant est INEXACT.</p>',1,0,Null,'','','Questionnaires.Data.Demographics','PostalCode' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,25,3,1,0,'ClassType',1,Null,Null,Null,Null,'','',Null,0,Null,NULL,90,1,1,Null ,0,'','',1,0,Null,'','','Questionnaires.Data.Demographics',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,17,3,0,0,'ClassType',0,Null,Null,Null,Null,'Class Type','Type de classe (Voir Guide)','ClassType',1,'LookupSets',43,100,1,1,Null ,1,'<p><b>5. Class Type</b></p><p>· Please select the type of class the child is in (e.g. kindergarten, kindergarten/grade 1, etc.)</p>','<p><b>5. Type de classe</b></p><p>· Les classes peuvent se composer uniquement d’enfants de maternelle ou de diverses combinaisons d’enfants de maternelle et de 1ère année. Veuillez indiquer la catégorie la plus pertinente.</p><p>· Pour ce qui est des options ne figurant pas dans la liste, p. ex. Maternelle/1/2, veuillez indiquer la catégorie qui correspond le plus étroitement (c.-à-d. Maternelle/1, dans ce cas).</p>',1,0,Null,'','','Questionnaires.Data.Demographics','ClassType' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,17,3,0,0,'ClassType',0,Null,Null,Null,Null,'Does this child have Identified Special Needs?','Besoins particuliers connus','SpecialNeeds',1,'LookupSets',35,110,1,1,Null ,1,'<p><b>1. Identified Special Needs</b></p><p>· This question must <b>not</b> be left blank, otherwise these children will be omitted from the analysis.</p><p>· Please use the general guidelines provided below: </p><p><br /></p><table border=\"1\" cellspacing=\"0\" cellpadding=\"0\" > <tbody><tr><td valign=\"top\" ><p><b>Yes</b></p></td><td valign=\"top\" ><p><b>No</b></p></td></tr><tr><td><p>Child has <b>already</b> been identified as needing special assistance due to chronic medical, physical, or mental disabling conditions, e.g., autism spectrum disorder, Down syndrome</p><p>Child requires special assistance in the classroom</p></td><td><p>* * Gifted or talented * *</p><p>Please mark their special talents in Section B, questions 34-39 – these are <b>NOT</b> special needs</p><p>If you only suspect that the child may be suffering from a disabling condition, or the condition is not severe enough for the child to be classified as “special needs.”</p><p>(Please indicate the problem in Section D of the questionnaire.)</p></td></tr></tbody></table>','<p><b>7. Besoins particuliers connus</b></p><p>· Cette question <b>doit absolument </b>être remplie, faute de quoi l’enfant ne sera pas retenu pour les fins d’analyses.</p><p>· Veuillez vous servir des lignes directrices générales fournies ci-dessous: </p><table border=\"1\" cellspacing=\"0\" cellpadding=\"0\" > <tbody><tr><td><p><b>Oui</b></p></td><td><p><b>Non</b></p></td></tr><tr><td><p>Un enfant qui a <b>déjà</b> été identifié comme ayant besoin d’une aide spéciale en raison d’affections incapacitantes chroniques médicales, physiques ou mentales (par exemple, autisme, syndrome d’alcoolisme fœtal, syndrome de Down)</p><p>L''enfant a besoin d''une aide spéciale dans la classe.</p></td><td><p><b>** Doué</b> ou <b>talentueux</b> **</p><p>Veuillez plutôt inscrire leurs talents spéciaux à la section<b> B</b>, <b>questions</b></p><p><b>34 à 39</b></p><p>Si vous soupçonnez uniquement que l’enfant a une affection incapacitante ou que l’affection n’est pas suffisamment grave pour qu’on le classifie comme ayant des</p><p><b>besoins particuliers </b>:</p><p>Veuillez indiquer le problème à la section <b>D</b> du questionnaire</p></td></tr></tbody></table>',1,0,Null,'','','Questionnaires.Data.Demographics','SpecialNeeds' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,25,3,1,0,'Languages',1,Null,Null,Null,Null,'','',Null,0,Null,NULL,120,1,1,'1' ,0,'','',1,0,Null,'','','Questionnaires.Data.Demographics',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,17,3,0,0,'Languages',0,Null,Null,Null,Null,'Child''s language status','Statut de la langue de l’enfant','EFSL',1,'LookupSets',75,130,1,1,Null ,1,'','',1,0,Null,'','','Questionnaires.Data.Demographics','EFSL' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,17,3,0,0,'Languages',0,Null,Null,Null,Null,'French Immersion','Classe d''immersion en anglais','FrenchImmersion',1,'LookupSets',35,140,1,1,Null ,1,'<p><b>9. French Immersion</b></p><p>· Only for Anglophone communities. </p><p>· Francophone classes/schools are not in this category.</p><p>· Please indicate whether the class is French Immersion or not. </p><br /><img width=575 src=\"images/help/image010.gif\"alt=\"Rounded Rectangle: French Immersion is a program in which kindergarten students are introduced early to French language through immersion, however, the main language of the schools remains to be English. Therefore, French Immersion teachers are asked to respond to the EDI questions based on their observations of the children''s abilities in English.  It would be unfair and inaccurate to measure the children''s ability in French as for most students this is their first exposure to the language and assessing their abilities in French would put them at an unfair disadvantage.&#13;&#10;&#13;&#10;If the teacher does not feel comfortable with the question they can indicate ''I don''t know''.&#13;&#10;&#13;&#10;Acquisition of a second language is strongly based on the success of the child’s acquisition of their first language and many of the skill sets are interchangeable.  The questions on the EDI reflect transferable skills and abilities therefore if the child has mastered these skills in French they have most likely also achieved this in English as well.&#13;&#10;&#13;&#10;Teachers are requested to use their best judgment in answering EDI items regarding skills they had not an opportunity to observe or where it is not part of the philosophy to test/observe the ability or behaviour in English.&#13;&#10;\">','<p><b>9. Classe d’immersion en anglais</b></p><p>· Uniquement pour les collectivités francophones. </p><p>· Les classes/écoles anglophones ne font pas parties de cette catégorie.</p><p>· Veuillez indiquer s’il s’agit d’une classe d’immersion en anglais ou non. </p><br /><p>Les classes d’immersion en anglais font parties d’un programme dans lequel les élèves de la maternelle sont introduits à un jeune âge à l’anglais. La langue principale de l’école, cependant, demeure le français. Donc les enseignant(e)s d’immersion en anglais devraient répondre aux questions de l’IMDPE en fonction des observations des habiletés des enfants en français. Il serait donc injuste et erroné de mesurer les habiletés des enfants en anglais, car la plupart d’entre eux viennent tout juste d’être exposé à la langue. L’évaluation de leurs habiletés en anglais leur mettrait dans une situation désavantageuse.Si l’enseignant(e) ne se sent pas confortable de répondre à une question en particulier, il/elle peut sélectionner « ne sais pas ».L’acquisition d’une langue seconde dépend grandement de la maîtrise de la langue maternelle de l’enfant et un grand nombre de compétences sont interchangeables. Les questions de l’IMDPE reflètent des compétences et des habiletés transférables. Donc, si un enfant a maîtrisé ces compétences en anglais, il y a de très bonnes chances qu’il/elle ait également maîtrisé ces compétences en français.Nous demandons aux enseignant(e)s d’utiliser leur meilleur jugement lorsque viendra le temps de répondre aux questions de l’IMDPE reliées aux compétences qu’ils n’ont pas eu l’occasion d’observer ou lorsque certaines compétences ou certains comportements ne font pas partie de la philosophie de la langue française.</p><!--<img width=575 src=\"images/help/image010.gif\"alt=\"Rounded Rectangle: Les classes d’immersion en anglais font parties d’un programme dans lequel les élèves de la maternelle sont introduits à un jeune âge à l’anglais. La langue principale de l’école, cependant, demeure le français. Donc les enseignant(e)s d’immersion en anglais devraient répondre aux questions de l’IMDPE en fonction des observations des habiletés des enfants en français. Il serait donc injuste et erroné de mesurer les habiletés des enfants en anglais, car la plupart d’entre eux viennent tout juste d’être exposé à la langue. L’évaluation de leurs habiletés en anglais leur mettrait dans une situation désavantageuse.&#13;&#10;&#13;&#10;Si l’enseignant(e) ne se sent pas confortable de répondre à une question en particulier, il/elle peut sélectionner « ne sais pas ».&#13;&#10;&#13;&#10;L’acquisition d’une langue seconde dépend grandement de la maîtrise de la langue maternelle de l’enfant et un grand nombre de compétences sont interchangeables. Les questions de l’IMDPE reflètent des compétences et des habiletés transférables. Donc, si un enfant a maîtrisé ces compétences en anglais, il y a de très bonnes chances qu’il/elle ait également maîtrisé ces compétences en français.&#13;&#10;&#13;&#10:Nous demandons aux enseignant(e)s d’utiliser leur meilleur jugement lorsque viendra le temps de répondre aux questions de l’IMDPE reliées aux compétences qu’ils n’ont pas eu l’occasion d’observer ou lorsque certaines compétences ou certains comportements ne font pas partie de la philosophie de la langue française.&#13;&#10;\">-->',1,0,Null,'','','Questionnaires.Data.Demographics','FrenchImmersion' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,17,3,0,0,'Languages',0,Null,Null,Null,Null,'Other Immersion','Autre langue d''immersion','OtherImmersion',1,'LookupSets',35,150,1,1,Null ,1,'<p><b>10. Other Immersion</b></p><p>· Please indicate if this class is part of an immersion program for a language other than French.</p>','<p><b>10. Autre langue d’immersion</b></p><p>· Veuillez indiquer si cette classe fait partie d’un programme d’immersion dans une langue autre que l’anglais.</p>',1,0,Null,'','','Questionnaires.Data.Demographics','OtherImmersion' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,21,3,0,0,'Languages',0,Null,Null,Null,Null,'Child''s First Language(s)','Langue(s) maternelle(s) de l''enfant','FirstLanguage1',1,'LookupSets',49,160,1,1,Null ,0,'','',1,0,Null,'','','Questionnaires.Data.Demographics','FirstLanguage1' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,21,3,0,0,'Languages',0,Null,Null,Null,Null,'','','FirstLanguage2',1,'LookupSets',49,170,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','FirstLanguage2' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,21,3,0,0,'Languages',0,Null,Null,Null,Null,'','','FirstLanguage3',1,'LookupSets',49,180,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','FirstLanguage3' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,17,3,0,0,'Languages',0,Null,Null,Null,Null,'Communicates adequately in his/her first language','Communique de mani&egravere ad&eacutequate dans sa langue maternelle','Communicates',1,'LookupSets',36,190,1,1,Null ,1,'<p><b>12. Communicates Adequately in his/her First Language</b></p><p>· If the child communicates adequately in his/her native tongue (based on your observation or parent information) please indicate <b>Yes</b>.</p><p>· If not please indicate <b>No</b>.</p><p>· If you are uncertain please indicate <b>Don’t Know</b>.</p>','<p><b>12. Communique de manière adéquate dans sa langue maternelle</b></p><p>· Si l’enfant communique de manière adéquate dans sa langue maternelle (selon vos observations ou selon l’information fournie par les parents), veuillez indiquer <b>Oui</b>.</p><p>· Sinon, veuillez indiquer <b>Non</b>.</p><p>· Si vous n’êtes pas certains, veuillez indiquer <b>Ne Sais Pas.</b></p>',1,0,Null,'','','Questionnaires.Data.Demographics','Communicates' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,17,3,0,0,'Languages',0,Null,Null,Null,Null,'What is the child''s current format of instruction','Quel est le format d''enseignement actuel de l''enfant ?','InstructionFormat',1,'LookupSets',73,200,1,1,Null ,0,'<p><b>5. Class Type</b></p><p>· Please select the type of class the child is in (e.g. kindergarten, kindergarten/grade 1, etc.)</p>','<p><b>5. Type de classe</b></p><p>· Les classes peuvent se composer uniquement d’enfants de maternelle ou de diverses combinaisons d’enfants de maternelle et de 1ère année. Veuillez indiquer la catégorie la plus pertinente.</p><p>· Pour ce qui est des options ne figurant pas dans la liste, p. ex. Maternelle/1/2, veuillez indiquer la catégorie qui correspond le plus étroitement (c.-à-d. Maternelle/1, dans ce cas).</p>',1,0,Null,'','','Questionnaires.Data.Demographics','InstructionFormat' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,22,3,0,0,'Languages',0,Null,Null,Null,Null,'If other, please specify','Si autre, s''il vous plaît précisez:','InstructionFormatSpecify',0,Null,NULL,210,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','InstructionFormatSpecify' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,28,3,0,0,'Languages',0,Null,Null,Null,Null,'','','LanguageCompleted',0,Null,NULL,320,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','LanguageCompleted' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,28,3,0,0,'Languages',0,Null,Null,Null,Null,'','','CompletedQuestions',0,Null,NULL,330,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','CompletedQuestions' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,28,3,0,0,'Languages',0,Null,Null,Null,Null,'','','RequiredQuestions',0,Null,NULL,340,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','RequiredQuestions' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,28,3,0,0,'Languages',0,Null,Null,Null,Null,'','','IsComplete',0,Null,NULL,350,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','IsComplete' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(29,28,3,0,0,'Languages',0,Null,Null,Null,Null,'','','QuestionnaireId',0,Null,NULL,360,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','QuestionnaireId' ,2,1)");





            //// NL - Section E
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,23,3,1,0,'Title',0,Null,Null,Null,Null,'Section E - Additional Questions','Section E – Renseignements supplémentaires',Null,0,Null,NULL,10,1,1,'0' ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,25,3,1,0,'EarlyIntervention',1,Null,Null,Null,Null,'','',Null,0,Null,NULL,20,1,1,'1' ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,16,3,1,0,'EarlyIntervention',0,Null,Null,Null,Null,'To the best of your knowledge, please mark all that apply to this child:','Du meilleur de vos connaissances, veuillez indiquer tout ce qui s''applique à l''enfant:',Null,1,'LookupSets',36,30,5,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,16,3,0,0,'EarlyIntervention',0,Null,Null,Null,Null,'Did this child attend an early intervention program','a bénéficié d’un programme d’intervention précoce. Veuillez préciser lequel (p. ex. orthophonie, ergothérapie)','InterventionProgram',1,'LookupSets',36,40,5,1,Null ,1,'Early intervention is applied to children who have a special need that may impact their development; it includes services usually for the child, and sometimes the whole family. Early intervention services are focused on remediating existing developmental problems such as speech impairment, a physical disability, or behaviour management. A child/family may be receiving early intervention services through centres such as KidsAbility, Mothercraft, Early Words, hospitals, clinics, etc.','',1,0,Null,'','','Questionnaires.Data.SectionE','InterventionProgram' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,22,3,0,0,'EarlyIntervention',0,Null,Null,Null,Null,'Specify if known','Si autre, s''il vous plaît précisez:','InterventionProgramSpecify',0,Null,NULL,50,5,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE','InterventionProgramSpecify' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,25,3,1,0,'NonParental',1,Null,Null,Null,Null,'','',Null,0,Null,NULL,60,1,1,'1' ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,16,3,1,0,'NonParental',0,Null,Null,Null,Null,'','',Null,1,'LookupSets',36,70,5,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,16,3,0,0,'NonParental',0,Null,Null,Null,Null,'On a regular basis, has been in non-parental care on a regular basis prior to kindergarten entry','a été placé régulièrement dans des services de garde avant d’entrer à la maternelle','NonParentalCare',1,'LookupSets',36,80,5,1,'' ,0,'','',1,0,Null,'','','Questionnaires.Data.SectionE','NonParentalCare' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,25,3,1,0,'NonParental2',1,Null,Null,Null,Null,'','',Null,0,Null,NULL,90,1,1,'1' ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,24,3,1,0,'NonParental2',0,Null,Null,Null,Null,'If yes, please specify type of care arrangement (please refer to Guide for examples)','',Null,0,Null,NULL,100,1,1,'2' ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,20,3,0,0,'NonParental2',0,Null,Null,Null,Null,'Centre-based','Service de garde d''enfants','CentreBased',0,Null,Null,110,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE','CentreBased' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,20,3,0,0,'NonParental2',0,Null,Null,Null,Null,'Family home','Family Home','HomeBased',0,Null,Null,120,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE','HomeBased' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,20,3,0,0,'NonParental2',0,Null,Null,Null,Null,'Child''s home, non-parent/relative','Child''s home, non-parent/relative','ChildHomeRelative',0,Null,Null,130,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE','ChildHomeRelative' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,20,3,0,0,'NonParental2',0,Null,Null,Null,Null,'Other/don''t know','Autre/ne sais pas','OtherCare',0,Null,Null,140,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE','OtherCare' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,16,3,1,0,'NonParental2',0,Null,Null,Null,Null,'To the best of your knowledge','D’après vos connaissances',Null,1,'LookupSets',66,150,5,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,16,3,0,0,'NonParental2',0,Null,Null,Null,Null,'prior to the child’s entry to kindergarten, was this arrangement','Si vous avez répondu oui à la question #1, est-ce que cet arrangement était','PriorArrangement',1,'LookupSets',66,160,5,1,Null ,0,'','',1,0,Null,'','','Questionnaires.Data.SectionE','PriorArrangement' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,25,3,1,0,'NonParental3',1,Null,Null,Null,Null,'','',Null,0,Null,NULL,170,1,1,'1' ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,16,3,1,0,'NonParental3',0,Null,Null,Null,Null,'To the best of your knowledge','Du meilleur de vos connaissances, veuillez indiquer tout ce qui s''applique à l''enfant:',Null,1,'LookupSets',36,180,5,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,16,3,0,0,'NonParental3',0,Null,Null,Null,Null,'Did this child attend other community learning programs (e.g. language classes, religion classes, cultural programs, music classes, sports, etc.)','Est-ce que l''enfant a fréquenté des programmes d''apprentissage communautaires (p. ex. cours de langue, cours de religion, programmes culturelles, cours de musique, sports, etc.)?','CommunityLearning',1,'LookupSets',36,190,5,1,Null ,0,'','',1,0,Null,'','','Questionnaires.Data.SectionE','CommunityLearning' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,16,3,0,0,'NonParental3',0,Null,Null,Null,Null,'Attended an organized pre-school/nursery school (If only part-time, and it is was not the main child-care arrangement)','Attended an organized pre-school/nursery school (If only part-time, and it is was not the main child-care arrangement)','OrganizedPreSchool',1,'LookupSets',36,200,5,1,Null ,0,'','',1,0,Null,'','','Questionnaires.Data.SectionE','OrganizedPreSchool' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,25,3,1,0,'Comments',1,Null,Null,Null,Null,'','',Null,0,Null,NULL,210,1,1,'1' ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,24,3,1,0,'Comments',0,Null,Null,Null,Null,'If you have any additional comments about this child and her/his readiness for school, list them below.<br /> *** Please do not use children’s name in any comments. ***','Si vous avez d’autres observations à propos de l’enfant et de son aptitude à apprendre à l''école veuillez les indiquer ci-dessous: <br />*** Veuillez éviter d’utiliser les noms des enfants dans les commentaires. ***',Null,0,Null,NULL,220,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE',Null ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,15,3,0,0,'Comments',0,Null,Null,Null,Null,'','','Comments',0,Null,NULL,230,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE','Comments' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,28,3,0,0,'Comments',0,Null,Null,Null,Null,'','','LanguageCompleted',0,Null,NULL,340,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE','LanguageCompleted' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,28,3,0,0,'Comments',0,Null,Null,Null,Null,'','','CompletedQuestions',0,Null,NULL,350,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE','CompletedQuestions' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,28,3,0,0,'Comments',0,Null,Null,Null,Null,'','','RequiredQuestions',0,Null,NULL,360,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE','RequiredQuestions' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,28,3,0,0,'Comments',0,Null,Null,Null,Null,'','','IsComplete',0,Null,NULL,370,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE','IsComplete' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NewfoundlandandLabrador]) VALUES(30,28,3,0,0,'Comments',0,Null,Null,Null,Null,'','','QuestionnaireId',0,Null,NULL,380,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.SectionE','QuestionnaireId' ,2,1)");


            // Nova Scotia Demographics
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NovaScotia]) VALUES(22,17,3,0,0,'ClassType',0,Null,Null,Null,Null,'What is the child''s current format of instruction','Quel est le format d''enseignement actuel de l''enfant ?','InstructionFormat',1,'LookupSets',73,230,1,1,Null ,0,'<p><b>5. Class Type</b></p><p>· Please select the type of class the child is in (e.g. kindergarten, kindergarten/grade 1, etc.)</p>','<p><b>5. Type de classe</b></p><p>· Les classes peuvent se composer uniquement d’enfants de maternelle ou de diverses combinaisons d’enfants de maternelle et de 1ère année. Veuillez indiquer la catégorie la plus pertinente.</p><p>· Pour ce qui est des options ne figurant pas dans la liste, p. ex. Maternelle/1/2, veuillez indiquer la catégorie qui correspond le plus étroitement (c.-à-d. Maternelle/1, dans ce cas).</p>',1,0,Null,'','','Questionnaires.Data.Demographics','InstructionFormat' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NovaScotia]) VALUES(22,22,3,0,0,'ClassType',0,Null,Null,Null,Null,'If other, please specify','Si autre, s''il vous plaît précisez:','InstructionFormatSpecify',0,Null,NULL,240,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','InstructionFormatSpecify' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NovaScotia]) VALUES(22,17,3,0,0,'ClassType',0,Null,Null,Null,Null,'Are you aware whether this child experienced any challenges with online instruction last year? (e.g. from your experience, told to you by parents or another teacher, etc).  Select all that apply.','Are you aware whether this child experienced any challenges with online instruction last year? (e.g. from your experience, told to you by parents or another teacher, etc).  Select all that apply.','OnlineChallenges',1,'LookupSets',74,250,1,1,Null ,0,'<p><b>5. Class Type</b></p><p>· Please select the type of class the child is in (e.g. kindergarten, kindergarten/grade 1, etc.)</p>','<p><b>5. Type de classe</b></p><p>· Les classes peuvent se composer uniquement d’enfants de maternelle ou de diverses combinaisons d’enfants de maternelle et de 1ère année. Veuillez indiquer la catégorie la plus pertinente.</p><p>· Pour ce qui est des options ne figurant pas dans la liste, p. ex. Maternelle/1/2, veuillez indiquer la catégorie qui correspond le plus étroitement (c.-à-d. Maternelle/1, dans ce cas).</p>',1,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallenges' ,2,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,[NovaScotia]) VALUES(22,22,3,0,0,'ClassType',0,Null,Null,Null,Null,'If other, please specify','Si autre, s''il vous plaît précisez:','OnlineChallengesSpecify',0,Null,NULL,260,1,1,Null ,0,'','',0,0,Null,'','','Questionnaires.Data.Demographics','OnlineChallengesSpecify' ,2,1)");

            // update initialization stored procedure
            var sp = @"ALTER PROCEDURE [dbo].[InitializeNewYear]	
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
		INSERT INTO [EDI.Service].[EDI].[Questionnaires] ([YearId],[QuestionnaireName],[English],[French],[DescriptionEnglish],[DescriptionFrench],[ShowProgressBar],[EntityName],[ShowQuestionNumbers],[Sequence],[IsChildQuestionnaire],[IsTeacherQuestionnaire],[QuestionsRequired],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork]) 
		SELECT @NewYearId,[QuestionnaireName],[English],[French],[DescriptionEnglish],[DescriptionFrench],[ShowProgressBar],[EntityName],[ShowQuestionNumbers],[Sequence],[IsChildQuestionnaire],[IsTeacherQuestionnaire],[QuestionsRequired],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork] FROM [EDI.Service].[EDI].[Questionnaires] WHERE Yearid = @OldYearId


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
		SELECT @NewYearId,[English],[French],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy] FROM [EDI.Service].[LUData].[InputTypes] WHERE YeariD = @OldYearId

		-- insert the lookupsets
		INSERT INTO [EDI.Service].[LUData].[LookupSets] ([YearId],[LookupName],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy] )
		SELECT @NewYearId,[LookupName],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy] FROM [EDI.Service].[LUData].[LookupSets] WHERE YeariD = @OldYearId

		-- insert the lookupsetoptions - adds the count of oldyear to the id
		INSERT INTO [EDI.Service].[LUData].[LookupSetOptions] ([LookupSetId],[English],[French],[Value],[Sequence],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[YearId]) 
		SELECT [LookupSetId]+@LookupSets,[English],[French],[Value],[Sequence],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],@NewYearId FROM [EDI.Service].[LUData].[LookupSetOptions] WHERE YeariD = @OldYearId

        UPDATE [dbo].[SystemConfigurations] SET FieldValue = 2022 WHERE FieldName = 'Year'

		-- insert the questionnaire configurations into the table -- - adds the count of oldyear to the id
		INSERT INTO [EDI.Service].[EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork])
		SELECT [QuestionnaireId]+@Questionnaires,[InputTypeId]+@InputTypes,[OrientationId]+@Orientations,[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId]+@LookupSets,[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],@NewYearId,[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork] FROM [EDI.Service].[EDI].[Questionnaires.Configuration] WHERE YeariD = @OldYearId

    END
END";
			// alter the stored procedure for initiallization
			migrationBuilder.Sql(sp);


		}

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // revert lookupsetid data 
            migrationBuilder.Sql("UPDATE[EDI].[Questionnaires.Configuration] SET [LookupEntityId] = [LookupEntityId] - 34 WHERE YearId = 2 AND [LookupEntityId] > 35 AND [LookupEntityId] < 69");

            // remove questionnaires for newfoundland and labrador (Teacher Feedback, Section A, B, C, D)
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires] SET [NewfoundlandandLabrador] = 0, PrinceEdwardIsland = 0 WHERE YearId = 2 AND ID IN (15, 17,18,19,24)");

            // Remove Section E NS Additions
            migrationBuilder.Sql("DELETE FROM [EDI].[Questionnaires.Configuration] WHERE YearID =2 AND QuestionnairesID = 22 AND Sequence >=230 AND Sequence <=260");
            migrationBuilder.Sql("DELETE FROM [EDI.Service].[LUData].[Orientations] WHERE YeariD = 2");

            migrationBuilder.DeleteData(
               schema: "EDI",
               table: "Questionnaires.Configuration",
               keyColumn: "QuestionnaireID",
               keyValue: 29);
            
            migrationBuilder.DeleteData(
               schema: "EDI",
               table: "Questionnaires.Configuration",
               keyColumn: "QuestionnaireID",
               keyValue: 30);

            migrationBuilder.DeleteData(
           schema: "EDI",
           table: "Questionnaires.Configuration",
           keyColumn: "QuestionnaireID",
           keyValue: 31);

            migrationBuilder.DeleteData(
               schema: "EDI",
               table: "Questionnaires.Configuration",
               keyColumn: "QuestionnaireID",
               keyValue: 32);

            migrationBuilder.DeleteData(
			   schema: "EDI",
			   table: "Questionnaires",
			   keyColumn: "Id",
			   keyValue: 29);

			migrationBuilder.DeleteData(
				schema: "EDI",
				table: "Questionnaires",
				keyColumn: "Id",
				keyValue: 30);
            migrationBuilder.DeleteData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 31);
            migrationBuilder.DeleteData(
                schema: "EDI",
                table: "Questionnaires",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DropColumn(
                name: "OrganizedPreSchool",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "InstructionFormat",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "InstructionFormatSpecify",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "OnlineChallenges",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

            migrationBuilder.DropColumn(
                name: "OnlineChallengesSpecify",
                schema: "EDI",
                table: "Questionnaires.Data.Demographics");

        }
    }
}
