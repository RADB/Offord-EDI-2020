using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDI.Infrastructure.Data.Migrations
{
    public partial class _2023Ontario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {            
            /* Github #168 */
            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET English='Language Immersion Program', VariableName='LanguageImmersion',EntityField='LanguageImmersion',lookupEntityId=122 WHERE questionnaireid = 43 and yearid=3 and id =1453");

            migrationBuilder.Sql("UPDATE [EDI].[Questionnaires.Configuration] SET Ontario=0 WHERE questionnaireid = 43 and yearid=3 and id = 1454");

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
