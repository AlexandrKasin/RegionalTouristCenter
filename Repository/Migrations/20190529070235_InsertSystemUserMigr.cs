using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class InsertSystemUserMigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "IF (NOT EXISTS(SELECT * FROM [User] WHERE Email = \'system@system.com\'))" +
                " BEGIN" +
                " INSERT INTO [User](Name, Email, CreatedDate, PhoneNumber, CreatedBy, Surname, Password, DateOfBirth)" +
                $" VALUES(\'system\', \'system@system.com\',SYSUTCDATETIME(),  \'+111111111111\', 0, \'system\', \'system\',\'{DateTime.Now}\')" +
                " END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}