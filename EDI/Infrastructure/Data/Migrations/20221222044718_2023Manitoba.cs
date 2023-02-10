using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2023Manitoba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
               name: "CentreBasedLicensedNonProfit",
               schema: "EDI",
               table: "Questionnaires.Data.SectionE",
               type: "bit",
               nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CentreBasedLicensedProfit",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OtherHomeLicensed",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OtherHomeUnlicensedNonRelative",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OtherHomeUnlicensedRelative",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE",
                type: "bit",
                nullable: true);

            // add questionnaires A-D
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires] SET Manitoba=1 WHERE yearID=3 AND ID in (33,35,36,37,42)");
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET Manitoba=1 WHERE yearID=3 AND QuestionnaireID in (33,35,36,37,42)");
            //Insert Questionnaire Demographics and E
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires] ([YearId],[QuestionnaireName],[English],[French],[DescriptionEnglish],[DescriptionFrench],[ShowProgressBar],[EntityName],[ShowQuestionNumbers],[Sequence],[IsChildQuestionnaire],[IsTeacherQuestionnaire],[QuestionsRequired],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork]) SELECT [YearId],[QuestionnaireName],[English],[French],[DescriptionEnglish],[DescriptionFrench],[ShowProgressBar],[EntityName],[ShowQuestionNumbers],[Sequence],[IsChildQuestionnaire],[IsTeacherQuestionnaire],[QuestionsRequired],getDate() as [CreatedDate],[CreatedBy],getDate() as [ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],1 as [Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],0 as [Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork] FROM [EDI].[Questionnaires] WHERE Yearid=3 AND ID IN (43,44)");

            // Insert Questions for Section Demographics
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork]) SELECT 51 as QuestionnaireID,[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],getDate() as [CreatedDate],'admin' as [CreatedBy],getDate() as [ModifiedDate],'admin' as [ModifiedBy],[Alberta],[BritishColumbia],1 as [Manitoba],[NewBrunswick],0 as [NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork] FROM[EDI].[Questionnaires.Configuration] WHERE YeariD = 3 and QuestionnaireId = 47 and NewfoundlandandLabrador = 1");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration] ([QuestionnaireId],[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],[CreatedDate],[CreatedBy],[ModifiedDate],[ModifiedBy],[Alberta],[BritishColumbia],[Manitoba],[NewBrunswick],[NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork]) SELECT 52 as QuestionnaireID,[InputTypeId],[OrientationId],[QuestionNumber],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[English],[French],[VariableName],[EntityName],[EntityField],[HasLookupEntity],[LookupEntity],[LookupEntityId],[IsRequired],[IsReadOnly],[IsConditional],[Condition],[HasNotification],[NotificationCondition],[Notification],[NotificationFrench],[HasHelp],[HelpTextEnglish],[HelpTextFrench],[Mask],[MaxLength],[Columns],[ColumnSpan],[Sequence],[YearId],[Min],[Max],[NumberStep],[NumberFormat],[Label],getDate() as [CreatedDate],'admin' as [CreatedBy],getDate() as [ModifiedDate],'admin' as [ModifiedBy],[Alberta],[BritishColumbia],1 as [Manitoba],[NewBrunswick],0 as [NewfoundlandandLabrador],[NovaScotia],[Nunavut],[Ontario],[PrinceEdwardIsland],[Quebec],[Saskatchewan],[YukonTerritory],[NorthwestTerritories],[NewYork] FROM[EDI].[Questionnaires.Configuration] WHERE YeariD = 3 and QuestionnaireId = 48 and NewfoundlandandLabrador = 1");

            /* Github 160*/
            // move everything down
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET sequence = sequence +10 WHERE Sequence >80 AND Yearid=3 AND QuestionnaireID=51");
            // move Question Up
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET sequence = 90, GroupName = 'Demographics' WHERE id=1930 AND Yearid=3 AND QuestionnaireID=51");
            //remove aboriginal
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET Manitoba=0 WHERE id=1929 AND Yearid=3 AND QuestionnaireID=51");

            migrationBuilder.InsertData(
                        schema: "LUData",
                        table: "LookupSets",
                        columns: new[] { "Id", "CreatedBy", "CreatedDate", "LookupName", "ModifiedBy", "ModifiedDate", "YearId" },
                        values: new object[,]
                        {
                    { 124, "admin", new DateTime(2022, 12, 22, 1, 17, 28, 118, DateTimeKind.Local).AddTicks(7117), "MBClassType", "admin", new DateTime(2022, 12, 22, 1, 17, 28, 118, DateTimeKind.Local).AddTicks(7118), 3 },
                    { 125, "admin", new DateTime(2022, 12, 22, 1, 17, 28, 118, DateTimeKind.Local).AddTicks(7120), "MBAdditionalLanguage", "admin", new DateTime(2022, 12, 22, 1, 17, 28, 118, DateTimeKind.Local).AddTicks(7121), 3 }
               });

            migrationBuilder.InsertData(
               schema: "LUData",
               table: "LookupSetOptions",
               columns: new[] { "Id", "CreatedBy", "CreatedDate", "English", "French", "LookupSetId", "ModifiedBy", "ModifiedDate", "Sequence", "Value", "YearId" },
               values: new object[,]
               {
                    { 983, "admin", new DateTime(2022, 12, 22, 1, 17, 28, 118, DateTimeKind.Local).AddTicks(7932), "K", "K", 124, "admin", new DateTime(2022, 12, 22, 1, 17, 28, 118, DateTimeKind.Local).AddTicks(7933), (short)10, (short)1, 3 },
                    { 984, "admin", new DateTime(2022, 12, 22, 1, 17, 28, 118, DateTimeKind.Local).AddTicks(7935), "K/1", "K/1", 124, "admin", new DateTime(2022, 12, 22, 1, 17, 28, 118, DateTimeKind.Local).AddTicks(7936), (short)20, (short)2, 3 },
                    { 985, "admin", new DateTime(2022, 12, 22, 1, 17, 28, 118, DateTimeKind.Local).AddTicks(7938), "Other", "Other", 124, "admin", new DateTime(2022, 12, 22, 1, 17, 28, 118, DateTimeKind.Local).AddTicks(7940), (short)30, (short)3, 3 },
                    { 986, "admin", new DateTime(2022, 12, 22, 1, 17, 28, 118, DateTimeKind.Local).AddTicks(7942), "EAL", "EAL", 125, "admin", new DateTime(2022, 12, 22, 1, 17, 28, 118, DateTimeKind.Local).AddTicks(7943), (short)10, (short)1, 3 },
                    { 987, "admin", new DateTime(2022, 12, 22, 1, 17, 28, 118, DateTimeKind.Local).AddTicks(7945), "FAL", "FAL", 125, "admin", new DateTime(2022, 12, 22, 1, 17, 28, 118, DateTimeKind.Local).AddTicks(7946), (short)20, (short)2, 3 },
                    { 988, "admin", new DateTime(2022, 12, 22, 1, 17, 28, 118, DateTimeKind.Local).AddTicks(7948), "No", "Non", 125, "admin", new DateTime(2022, 12, 22, 1, 17, 28, 118, DateTimeKind.Local).AddTicks(7949), (short)30, (short)3, 3 }
               });

            //class type
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET LookupEntityID=124 WHERE id=1915 AND Yearid=3 AND QuestionnaireID=51");
            //language status
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET English='English/French as Additional Language:',French='English/French as Additional Language:',LookupEntityId=125 WHERE id=1918 AND Yearid=3 AND QuestionnaireID=51");
            //Indigenous
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET English='Indigenous (First Nations, Metis, or Inuit):',French='Indigenous (First Nations, Metis, or Inuit):',LookupEntityId=78,VariableName='IndigenousAncestry',EntityField='IndigenousAncestry',sequence=160,inputtypeid=31,haslookupentity=1,lookupentity='LookupSets' WHERE id=1928 AND Yearid=3 AND QuestionnaireID=51");

            /* GitHub #161 */
            //remove top two care options
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET Manitoba=0 WHERE questionnaireid = 52 and yearid=3 and id in(1941,1942)");
            // move everything down
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET sequence = sequence +30 WHERE Sequence >100 AND Yearid=3 AND QuestionnaireID=52");

            //insert options
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,Manitoba) VALUES(52,34,5,0,0,'NonParental2',0,Null,Null,Null,'Null','Centre-based, licensed, non-profit','Centre-based, licensed, non-profit','CentreBasedLicensedNonProfit',0,'Null',Null,110,1,1,'Null' ,0,'','',1,0,'Null','','','Questionnaires.Data.SectionE','CentreBasedLicensedNonProfit' ,3,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,Manitoba) VALUES(52,34,5,0,0,'NonParental2',0,Null,Null,Null,'Null','Centre-based, licensed, for profit','Centre-based, licensed, for profit','CentreBasedLicensedProfit',0,'Null',Null,120,1,1,'Null' ,0,'','',1,0,'Null','','','Questionnaires.Data.SectionE','CentreBasedLicensedProfit' ,3,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,Manitoba) VALUES(52,34,5,0,0,'NonParental2',0,Null,Null,Null,'Null','Other home-based, licensed','Other home-based, licensed','OtherHomeLicensed',0,'Null',Null,130,1,1,'Null' ,0,'','',1,0,'Null','','','Questionnaires.Data.SectionE','OtherHomeLicensed' ,3,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,Manitoba) VALUES(52,34,5,0,0,'NonParental2',0,Null,Null,Null,'Null','Other home-based, unlicensed, non-relative','Other home-based, unlicensed, non-relative','OtherHomeUnlicensedNonRelative',0,'Null',Null,140,1,1,'Null' ,0,'','',1,0,'Null','','','Questionnaires.Data.SectionE','OtherHomeUnlicensedNonRelative' ,3,1)");
            migrationBuilder.Sql("INSERT INTO [EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID] ,[IsHeader] ,[ShowGroupName] ,[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber],HasHelp,HelpTextEnglish,HelpTextFrench,IsRequired,HasNotification,NotificationCondition,[Notification],NotificationFrench,EntityName,EntityField,YearId,Manitoba) VALUES(52,34,5,0,0,'NonParental2',0,Null,Null,Null,'Null','Other home-based, unlicensed, relative','Other home-based, unlicensed, relative','OtherHomeUnlicensedRelative',0,'Null',Null,150,1,1,'Null' ,0,'','',1,0,'Null','','','Questionnaires.Data.SectionE','OtherHomeUnlicensedRelative' ,3,1)");


            //Update Text
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET English='Child''s home, relative' WHERE id=1943 AND Yearid=3 AND QuestionnaireID=52");
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET English='Child''s home, non-relative' WHERE id=1959 AND Yearid=3 AND QuestionnaireID=52");

            /* Github #185 */
            //remove indigenous question
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET Manitoba = 0 WHERE id=1928 AND Yearid=3 AND QuestionnaireID=51");

            /* Github #192 */
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET English = dbo.[StripHTML](English), French = dbo.[StripHTML](French) WHERE questionnaireid = 52 and yearid = 3 and id in (1968, 1969, 1970, 1971, 1948, 1949, 1972, 1976, 1950, 1966)");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET VariableName = 'OtherCare', EntityField = 'OtherCare' WHERE questionnaireid = 52 and yearid = 3 and id in (1976)");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET VariableName = 'OtherHomeUnlicensedRelative', EntityField = 'OtherHomeUnlicensedRelative' WHERE questionnaireid = 52 and yearid = 3 and id in (1948)");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET VariableName = 'ChildHomeRelative', EntityField = 'ChildHomeRelative' WHERE questionnaireid = 52 and yearid = 3 and id in (1972)");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET VariableName = 'ChildHomeNonRelative', EntityField = 'ChildHomeNonRelative' WHERE questionnaireid = 52 and yearid = 3 and id in (1949)");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET English = '' WHERE questionnaireid = 52 and yearid = 3 and id in (1943)");

            // update to sequence numbers
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=150 WHERE questionnaireid = 52 and yearid =3 AND ID =1948");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=160 WHERE questionnaireid = 52 and yearid =3 AND ID =1949");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=170 WHERE questionnaireid = 52 and yearid =3 AND ID =1972");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=180 WHERE questionnaireid = 52 and yearid =3 AND ID =1976");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=210 WHERE questionnaireid = 52 and yearid =3 AND ID =1952");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=220 WHERE questionnaireid = 52 and yearid =3 AND ID =1953");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=230 WHERE questionnaireid = 52 and yearid =3 AND ID =1954");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=240 WHERE questionnaireid = 52 and yearid =3 AND ID =1955");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=250 WHERE questionnaireid = 52 and yearid =3 AND ID =1956");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=260 WHERE questionnaireid = 52 and yearid =3 AND ID =1957");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=280 WHERE questionnaireid = 52 and yearid =3 AND ID =1977");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=400 WHERE questionnaireid = 52 and yearid =3 AND ID =1958");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=410 WHERE questionnaireid = 52 and yearid =3 AND ID =1959");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=290 WHERE questionnaireid = 52 and yearid =3 AND ID =1978");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=300 WHERE questionnaireid = 52 and yearid =3 AND ID =1979");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=420 WHERE questionnaireid = 52 and yearid =3 AND ID =1960");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=310 WHERE questionnaireid = 52 and yearid =3 AND ID =1980");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=320 WHERE questionnaireid = 52 and yearid =3 AND ID =1981");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=330 WHERE questionnaireid = 52 and yearid =3 AND ID =1982");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=430 WHERE questionnaireid = 52 and yearid =3 AND ID =1961");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=440 WHERE questionnaireid = 52 and yearid =3 AND ID =1962");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=450 WHERE questionnaireid = 52 and yearid =3 AND ID =1963");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=460 WHERE questionnaireid = 52 and yearid =3 AND ID =1964");
            migrationBuilder.Sql("UPDATE [EDI.Service].[EDI].[Questionnaires.Configuration] SET Sequence=470 WHERE questionnaireid = 52 and yearid =3 AND ID =1965");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
               name: "CentreBasedLicensedNonProfit",
               schema: "EDI",
               table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "CentreBasedLicensedProfit",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "OtherHomeLicensed",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "OtherHomeUnlicensedNonRelative",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");

            migrationBuilder.DropColumn(
                name: "OtherHomeUnlicensedRelative",
                schema: "EDI",
                table: "Questionnaires.Data.SectionE");
        }
    }
}
