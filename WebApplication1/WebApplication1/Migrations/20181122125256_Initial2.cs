using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "User",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "User",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "GivenAnswer",
                table: "OpenAnswer",
                newName: "_OpenAnswer");

            migrationBuilder.RenameColumn(
                name: "Answer",
                table: "OpenAnswer",
                newName: "UserResponse");

            migrationBuilder.RenameColumn(
                name: "Answer",
                table: "ClosedAnswer",
                newName: "_ClosedAnswer");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Sex",
                table: "User",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "User",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "User",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "_OpenAnswer",
                table: "OpenAnswer",
                newName: "GivenAnswer");

            migrationBuilder.RenameColumn(
                name: "UserResponse",
                table: "OpenAnswer",
                newName: "Answer");

            migrationBuilder.RenameColumn(
                name: "_ClosedAnswer",
                table: "ClosedAnswer",
                newName: "Answer");
        }
    }
}
