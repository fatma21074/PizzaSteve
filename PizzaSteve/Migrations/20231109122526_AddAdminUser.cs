using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaSteve.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [Security].[Users] ([Id], [FirstName], [LastName], [ProfilePicture], [City], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'a7f8e1c4-383c-4349-b469-c3c3692fd814', N'Amr', N'Mohamed', NULL, N'Alexand', N'Admin', N'ADMIN', N'Amr-Mohamed@gmail.com', N'AMR-MOHAMED@GMAIL.COM', 0, N'AQAAAAIAAYagAAAAEPMZ3vnWA6iivq2dFGoXxsMu0XP/v9FZiwTbV7a3Gdz7A1bdSh9Xl1OAzF+DTbXVfg==', N'BAEEOPSRSX5ZPQ2WKDCVFKAXN22NL4GM', N'5109fe94-e2bd-4854-84d7-793127ad44a3', N'0123454', 0, 0, NULL, 1, 0)\r\n");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("DELETE FROM [Security].[Users] WHERE Id='a7f8e1c4-383c-4349-b469-c3c3692fd814' ");
        }
    }
}
