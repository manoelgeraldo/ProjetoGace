using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Data.Migrations
{
    public partial class AdicionandoColunaEvoluiuSaude : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EVOLUIU",
                schema: "SDS_SIMIP_USU",
                table: "SAUDE",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EVOLUIU",
                schema: "SDS_SIMIP_USU",
                table: "SAUDE");
        }
    }
}
