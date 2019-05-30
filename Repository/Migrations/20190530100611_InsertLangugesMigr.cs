using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class InsertLangugesMigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "IF (NOT EXISTS(SELECT * FROM [Languages]))" +
                " BEGIN" +
                " INSERT INTO [Languages](LanguageName, CreatedDate, CreatedBy)" +
                " VALUES(\'English\', SYSUTCDATETIME(), 0)" +
                " INSERT INTO [Languages](LanguageName, CreatedDate, CreatedBy)" +
                " VALUES(\'Russian\', SYSUTCDATETIME(), 0)" +
                " INSERT INTO [Languages](LanguageName, CreatedDate, CreatedBy)" +
                " VALUES(\'Poland\', SYSUTCDATETIME(), 0)" +
                " END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}