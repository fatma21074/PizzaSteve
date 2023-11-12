using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaSteve.Migrations
{
    /// <inheritdoc />
    public partial class SignAdminUsertoRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO[Security].[UserRoles] (UserId,RoleId) Select'a7f8e1c4-383c-4349-b469-c3c3692fd814', Id From[Security] .[Roles]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from [Security].[UserRoles] where UserId='a7f8e1c4-383c-4349-b469-c3c3692fd814'");
        }
    }
}
