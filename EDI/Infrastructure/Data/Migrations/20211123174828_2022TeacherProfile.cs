using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2022TeacherProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "EducationLevel",
                schema: "EDI",
                table: "Questionnaires.Data.TeacherProfile",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "ImpactedWellBeing",
                schema: "EDI",
                table: "Questionnaires.Data.TeacherProfile",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "SkillsAcademic",
                schema: "EDI",
                table: "Questionnaires.Data.TeacherProfile",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "SkillsOverall",
                schema: "EDI",
                table: "Questionnaires.Data.TeacherProfile",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "SkillsPhysical",
                schema: "EDI",
                table: "Questionnaires.Data.TeacherProfile",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "SkillsSocioEmotional",
                schema: "EDI",
                table: "Questionnaires.Data.TeacherProfile",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "WellBeing",
                schema: "EDI",
                table: "Questionnaires.Data.TeacherProfile",
                type: "tinyint",
                nullable: true);

           
            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSets",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LookupName", "ModifiedBy", "ModifiedDate", "YearId" },
                values: new object[,]
                {
                    { 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3005), "Education", "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3006), 2 },
                    { 70, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3008), "YesNoWellBeing", "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3009), 2 },
                    { 71, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3011), "NegativePositive", "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3012), 2 },
                    { 72, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3014), "BetterWorse", "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3015), 2 }
                });

            
            migrationBuilder.InsertData(
                schema: "LUData",
                table: "LookupSetOptions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "English", "French", "LookupSetId", "ModifiedBy", "ModifiedDate", "Sequence", "Value", "YearId" },
                values: new object[,]
                {
                    { 585, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3511), "Some coursework towards a Bachelor's degree", "Quelques cours en vue de l'obtention d'un baccalauréat", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3513), (short)10, (short)1, 2 },
                    { 586, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3514), "Teaching certificate, diploma, or license?", "Un certi􀁼cat, un diplômeu une license d'enseignement", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3516), (short)20, (short)2, 2 },
                    { 587, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3517), "Bachelor's degree", "Un baccalauréat", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3518), (short)30, (short)3, 2 },
                    { 588, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3520), "Bachelor of Education degree", "Un baccalauréat en éducation", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3521), (short)40, (short)4, 2 },
                    { 589, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3524), "Some post-baccalaureate coursework", "Quelques cours après le baccalauréat", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3526), (short)50, (short)5, 2 },
                    { 590, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3527), "Post-baccalaureate diploma or certificate", "Un diplômeu un certi􀁼cat supérieur au baccalauréat", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3529), (short)60, (short)6, 2 },
                    { 591, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3530), "Some coursework towards a Master's degree", "Quelques cours en vue de l'obtention d'une maîtrise", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3531), (short)70, (short)7, 2 },
                    { 592, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3534), "Master's degree", "Une maîtrise", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3535), (short)80, (short)8, 2 },
                    { 593, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3537), "Some coursework towards a Doctorate", "Quelques cours en vue de l'obtention d'un doctorat", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3538), (short)90, (short)9, 2 },
                    { 594, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3541), "Doctorate", "Un doctorat", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3542), (short)100, (short)10, 2 },
                    { 595, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3544), "Other", "Autre", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3545), (short)110, (short)11, 2 },
                    { 596, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3547), "Yes", "Oui", 70, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3548), (short)10, (short)1, 2 },
                    { 597, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3549), "No - my overall well-being was about the same", "Non, mon bien-être général fut à peu près pareil", 70, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3551), (short)20, (short)2, 2 },
                    { 598, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3553), "Negatively", "Négativement", 71, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3554), (short)10, (short)1, 2 },
                    { 599, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3557), "Somewhat negatively", "Un peu négativement", 71, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3559), (short)20, (short)2, 2 },
                    { 600, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3561), "Both negatively and positively", "Négativement et positivement", 71, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3562), (short)30, (short)3, 2 },
                    { 601, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3564), "Somewhat positively", "Un peu positivement", 71, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3565), (short)40, (short)4, 2 },
                    { 602, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3567), "Positively", "Positivement", 71, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3568), (short)50, (short)5, 2 },
                    { 603, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3569), "Much better than earlier cohorts", "Beaucoup meilleures que les cohortes précédentes", 72, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3571), (short)10, (short)1, 2 },
                    { 604, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3572), "Better than earlier cohorts", "Meilleures que les cohortes précédentes", 72, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3574), (short)20, (short)2, 2 },
                    { 605, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3575), "About the same", "À peu près pareilles", 72, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3577), (short)30, (short)3, 2 },
                    { 606, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3578), "Lower than earlier cohorts", "Moins bonnes que les cohortes précédentes", 72, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3579), (short)40, (short)4, 2 },
                    { 607, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3586), "Much lower than earlier cohorts", "Beaucoup moins bonnes que les cohortes précédentes", 72, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3587), (short)50, (short)5, 2 },
                    { 608, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3589), "Don't know ", "Je ne le sais [as", 72, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3590), (short)60, (short)6, 2 },
                    { 609, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3592), "Not applicable", "Not applicable", 72, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3593), (short)70, (short)7, 2 }
                });

            // remove education questions
            migrationBuilder.Sql("DELETE FROM[EDI.Service].[EDI].[Questionnaires.Configuration] WHERE ID >= 761 AND ID <= 771");
            // update sequence and text to one question
            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration] SET English = 'Other Education - Please Specify', Sequence = 200 WHERE ID = 866");

            // insert new questions
            migrationBuilder.Sql("INSERT INTO[EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber], HasHelp, HelpTextEnglish, HelpTextFrench, IsRequired, HasNotification, NotificationCondition,[Notification], NotificationFrench, Yearid, EntityName, EntityField, NovaScotia, NorthWestTerritories, Ontario, NewYork)VALUES(15, 7, 1, 0, 0, 'Education', 0, Null, Null, Null, 'Null', 'Highest level of education', 'Plus haut niveau de scolarité', 'EducationLevel', 1, 'LookupSets', 69, 190, 1, 1, 'NULL', 0, '', '', 1, 0, 'null', '', '', 2, 'Questionnaires.Data.TeacherProfile', 'EducationLevel', 1, 1, 1, 1)");
            migrationBuilder.Sql("INSERT INTO[EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber], HasHelp, HelpTextEnglish, HelpTextFrench, IsRequired, HasNotification, NotificationCondition,[Notification], NotificationFrench, Yearid, EntityName, EntityField, NovaScotia, NorthWestTerritories, Ontario, NewYork)VALUES(15, 3, 1, 0, 0, 'Education', 0, Null, Null, Null, 'Null', 'Do you think that the COVID-19 pandemic affected your overall well-being?', 'Pensez-vous que la pandémie de la COVID-19 a affecté votre bien-être en général (soit de façon personnelle ou professionnelle)?', 'WellBeing', 1, 'LookupSets', 70, 210, 1, 1, 'NULL', 0, '', '', 1, 0, 'null', '', '', 2, 'Questionnaires.Data.TeacherProfile', 'WellBeing', 1, 1, 1, 1)");
            migrationBuilder.Sql("INSERT INTO[EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber], HasHelp, HelpTextEnglish, HelpTextFrench, IsRequired, HasNotification, NotificationCondition,[Notification], NotificationFrench, Yearid, EntityName, EntityField, NovaScotia, NorthWestTerritories, Ontario, NewYork)VALUES(15, 2, 1, 0, 0, 'Education', 0, Null, Null, Null, 'Null', 'If yes', 'Si oui', 'ImpactedWellBeing', 1, 'LookupSets', 71, 220, 5, 1, 'NULL', 1, '<p><b>1. ability to use language effectively in English</b></p><p>· Refers to the child’s use of appropriate words/expressions at appropriate times and the child’s contribution to conversations.</p>', '<p><b>1. utilisation efficace du français parlé</b></p><p>· L’enfant utilise convenablement les termes/expressions lorsqu''il le faut et participe aux conversations.</p>', 1, 0, 'null', '', '', 2, 'Questionnaires.Data.TeacherProfile', 'ImpactedWellBeing', 1, 1, 1, 1)");

            migrationBuilder.Sql("INSERT INTO[EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber], HasHelp, HelpTextEnglish, HelpTextFrench, IsRequired, HasNotification, NotificationCondition,[Notification], NotificationFrench, Yearid, EntityName, EntityField, NovaScotia, NorthWestTerritories, Ontario, NewYork)VALUES(15, 11, 1, 1, 0, 'Skills', 1, Null, Null, Null, 'Null', '', '', 'NULL', 0, 'NULL', NULL, 230, 1, 1, 'NULL', 0, '', '', 0, 0, 'null', '', '', 2, 'Questionnaires.Data.TeacherProfile', 'NULL', 1, 1, 1, 1)");
            migrationBuilder.Sql("INSERT INTO[EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber], HasHelp, HelpTextEnglish, HelpTextFrench, IsRequired, HasNotification, NotificationCondition,[Notification], NotificationFrench, Yearid, EntityName, EntityField, NovaScotia, NorthWestTerritories, Ontario, NewYork)VALUES(15, 10, 1, 1, 0, 'Skills', 0, Null, Null, Null, 'Null', 'Please rate the general developmental skills of children in your current classroom in relation to your observation of children the same age in cohorts prior to 2020. <br /><br />Children in this class demonstrate…', 'Veuillez évaluer les habiletés développementales générales des enfants dans votre salle de classe actuelle en comparaison à vos observations des enfants du même âge dans vos cohortes d''élèves avant 2020.<br /><br />Les enfants dans cette classe démontrent...', 'NULL', 0, 'NULL', NULL, 240, 1, 1, 'NULL', 0, '', '', 0, 0, 'null', '', '', 2, 'Questionnaires.Data.TeacherProfile', 'NULL', 1, 1, 1, 1)");
            migrationBuilder.Sql("INSERT INTO[EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber], HasHelp, HelpTextEnglish, HelpTextFrench, IsRequired, HasNotification, NotificationCondition,[Notification], NotificationFrench, Yearid, EntityName, EntityField, NovaScotia, NorthWestTerritories, Ontario, NewYork)VALUES(15, 2, 1, 1, 0, 'Skills', 0, Null, Null, Null, 'Null', '', '', 'NULL', 1, 'LookupSets', 72, 250, 7, 1, 'NULL', 0, '', '', 0, 0, 'null', '', '', 2, 'Questionnaires.Data.TeacherProfile', 'NULL', 1, 1, 1, 1)");
            migrationBuilder.Sql("INSERT INTO[EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber], HasHelp, HelpTextEnglish, HelpTextFrench, IsRequired, HasNotification, NotificationCondition,[Notification], NotificationFrench, Yearid, EntityName, EntityField, NovaScotia, NorthWestTerritories, Ontario, NewYork)VALUES(15, 2, 1, 0, 0, 'Skills', 0, Null, Null, Null, 'Null', 'Overall skills that are:', 'des habiletés générales qui sont:', 'SkillsOverall', 1, 'LookupSets', 72, 260, 7, 1, 'NULL', 0, '<p><b>2a. physical disability</b></p>', '<p><b>2a) incapacité physique</b></p>', 1, 0, 'null', '', '', 2, 'Questionnaires.Data.TeacherProfile', 'SkillsOverall', 1, 1, 1, 1)");
            migrationBuilder.Sql("INSERT INTO[EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber], HasHelp, HelpTextEnglish, HelpTextFrench, IsRequired, HasNotification, NotificationCondition,[Notification], NotificationFrench, Yearid, EntityName, EntityField, NovaScotia, NorthWestTerritories, Ontario, NewYork)VALUES(15, 2, 1, 0, 0, 'Skills', 0, Null, Null, Null, 'Null', 'Academic skills that are:', 'des habiletés académiques qui sont:', 'SkillsAcademic', 1, 'LookupSets', 72, 270, 7, 1, 'NULL', 0, '<p><b>2b. visual impairment</b></p>', '<p><b>2b) déficience visuelle</b></p>', 1, 0, 'null', '', '', 2, 'Questionnaires.Data.TeacherProfile', 'SkillsAcademic', 1, 1, 1, 1)");
            migrationBuilder.Sql("INSERT INTO[EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber], HasHelp, HelpTextEnglish, HelpTextFrench, IsRequired, HasNotification, NotificationCondition,[Notification], NotificationFrench, Yearid, EntityName, EntityField, NovaScotia, NorthWestTerritories, Ontario, NewYork)VALUES(15, 2, 1, 0, 0, 'Skills', 0, Null, Null, Null, 'Null', 'Physical skills that are:', 'des habiletés physiques qui sont:', 'SkillsPhysical', 1, 'LookupSets', 72, 280, 7, 1, 'NULL', 0, '<p><b>2c. hearing impairment</b></p>', '<p><b>2c) déficience auditive</b></p>', 1, 0, 'null', '', '', 2, 'Questionnaires.Data.TeacherProfile', 'SkillsPhysical', 1, 1, 1, 1)");
            migrationBuilder.Sql("INSERT INTO[EDI].[Questionnaires.Configuration]([QuestionnaireID],[InputTypeId],[OrientationID],[IsHeader],[ShowGroupName],[GroupName],[IsCollapsible],[min],[max],[numberstep],[Label],[English],[French],[VariableName],[HasLookupEntity],[LookupEntity],[LookupEntityID],[Sequence],[Columns],[ColumnSpan],[QuestionNumber], HasHelp, HelpTextEnglish, HelpTextFrench, IsRequired, HasNotification, NotificationCondition,[Notification], NotificationFrench, Yearid, EntityName, EntityField, NovaScotia, NorthWestTerritories, Ontario, NewYork)VALUES(15, 2, 1, 0, 0, 'Skills', 0, Null, Null, Null, 'Null', 'Soci-emotional skills that are:', 'des habiletés socioémotionnelles qui sont:', 'SkillsSocioEmotional', 1, 'LookupSets', 72, 290, 7, 1, 'NULL', 0, '<p><b>2d. speech impairment</b></p>', '<p><b>2d) trouble de la parole</b></p>', 1, 0, 'null', '', '', 2, 'Questionnaires.Data.TeacherProfile', 'SkillsSocioEmotional', 1, 1, 1, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSetOptions",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                schema: "LUData",
                table: "LookupSets",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DropColumn(
                name: "EducationLevel",
                schema: "EDI",
                table: "Questionnaires.Data.TeacherProfile");

            migrationBuilder.DropColumn(
                name: "ImpactedWellBeing",
                schema: "EDI",
                table: "Questionnaires.Data.TeacherProfile");

            migrationBuilder.DropColumn(
                name: "SkillsAcademic",
                schema: "EDI",
                table: "Questionnaires.Data.TeacherProfile");

            migrationBuilder.DropColumn(
                name: "SkillsOverall",
                schema: "EDI",
                table: "Questionnaires.Data.TeacherProfile");

            migrationBuilder.DropColumn(
                name: "SkillsPhysical",
                schema: "EDI",
                table: "Questionnaires.Data.TeacherProfile");

            migrationBuilder.DropColumn(
                name: "SkillsSocioEmotional",
                schema: "EDI",
                table: "Questionnaires.Data.TeacherProfile");

            migrationBuilder.DropColumn(
                name: "WellBeing",
                schema: "EDI",
                table: "Questionnaires.Data.TeacherProfile");            
        }
    }
}
