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
                    { 585, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3511), "Some coursework towards a Bachelor's degree?", "Quelques cours en vue de l'obtention d'un baccalauréat", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3513), (short)10, (short)1, 2 },
                    { 586, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3514), "A teaching certificate, diploma, or license?", "Un certi􀁼cat, un diplômeu une license d'enseignement", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3516), (short)20, (short)2, 2 },
                    { 587, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3517), "A Bachelor's degree?", "Un baccalauréat", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3518), (short)30, (short)3, 2 },
                    { 588, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3520), "A Bachelor of Education degree?", "Un baccalauréat en éducation", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3521), (short)40, (short)4, 2 },
                    { 589, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3524), "Some post-baccalaureate coursework?", "Quelques cours après le baccalauréat", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3526), (short)50, (short)5, 2 },
                    { 590, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3527), "A post-baccalaureate diploma or certificate?", "Un diplômeu un certi􀁼cat supérieur au baccalauréat", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3529), (short)60, (short)6, 2 },
                    { 591, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3530), "Some coursework towards a Master's degree?", "Quelques cours en vue de l'obtention d'une maîtrise", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3531), (short)70, (short)7, 2 },
                    { 592, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3534), "A Master's degree?", "Une maîtrise", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3535), (short)80, (short)8, 2 },
                    { 593, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3537), "Some coursework towards a Doctorate?", "Quelques cours en vue de l'obtention d'un doctorat", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3538), (short)90, (short)9, 2 },
                    { 594, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3541), "A Doctorate?", "Un doctorat", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3542), (short)100, (short)10, 2 },
                    { 595, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3544), "Other?", "Autre", 69, "admin", new DateTime(2021, 11, 23, 12, 48, 27, 682, DateTimeKind.Local).AddTicks(3545), (short)110, (short)11, 2 },
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
