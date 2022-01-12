using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2022NWT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //update demographics for NWT
            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration] SET GroupName = 'Demographics' where NorthwestTerritories = 1 and questionnaireid = 16  and yearid = 2 AND sequence <= 180");
            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration] SET GroupName = 'Languages' where NorthwestTerritories = 1 and questionnaireid = 16  and yearid = 2 AND sequence >= 190");

            // remove group headers NWT
            migrationBuilder.Sql("DELETE FROM[EDI.Service].[EDI].[Questionnaires.Configuration] where NorthwestTerritories = 1 and questionnaireid = 16  and yearid = 2 AND InputTypeId = 25 AND ID NOT IN(918, 921)");
            
            // update the text
            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration] SET English = 'Are you aware whether this child experienced any challenges with online instruction last year? (e.g. from your experience, told to you by parents or another teacher, etc).<br />Select all that apply' where  yearid = 2 AND id in (1107, 1114, 1118)");
            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration] SET HelpTextEnglish = null, HelpTextFrench = null WHERE YEARID = 2 AND ID in (1070, 1139, 1105, 1112, 1116)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
