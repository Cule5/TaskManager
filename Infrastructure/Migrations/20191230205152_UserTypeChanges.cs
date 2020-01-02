using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class UserTypeChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserType",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "UserType",
                table: "Accounts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserType",
                table: "Accounts");

            migrationBuilder.AddColumn<int>(
                name: "UserType",
                table: "Users",
                nullable: false,
                defaultValue: 0);
        }
    }
}
