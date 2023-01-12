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
            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration] SET InputTypeId = 38, HasLookupEntity = 0, lookupEntity = Null, LookupEntityId = null WHERE yearid = 3 and id = 1818 and QuestionnaireId = 50");
            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration] SET isHeader = 1, VariableName = null, EntityField = null, IsRequired = 0 WHERE yearid = 3 and id = 1819 and QuestionnaireId = 50");

            /* github 171 PEI Demographics */
            migrationBuilder.Sql("UPDATE[EDI.Service].[LUData].[LookupSetOptions] SET English = 'JK/SK/1', French = 'JK/SK/1' WHERE ID = 980 AND Lookupsetid = 123");

            /* github 175 NS Demographics */
            migrationBuilder.Sql("UPDATE[EDI.Service].[EDI].[Questionnaires.Configuration] SET groupname = 'ClassType' WHERE yearid = 3 and id = 1880 and QuestionnaireId = 40");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
