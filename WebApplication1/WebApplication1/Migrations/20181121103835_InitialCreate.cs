using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClosedAnswer_Answer_AnswerId",
                table: "ClosedAnswer");

            migrationBuilder.DropForeignKey(
                name: "FK_OpenAnswer_Answer_Answer",
                table: "OpenAnswer");

            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_Company_ComapnyId",
                table: "Surveys");

            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropIndex(
                name: "IX_OpenAnswer_Answer",
                table: "OpenAnswer");

            migrationBuilder.RenameColumn(
                name: "ComapnyId",
                table: "Surveys",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Surveys_ComapnyId",
                table: "Surveys",
                newName: "IX_Surveys_CompanyId");

            migrationBuilder.RenameColumn(
                name: "_Answer",
                table: "OpenAnswer",
                newName: "GivenAnswer");

            migrationBuilder.RenameColumn(
                name: "_Answer",
                table: "ClosedAnswer",
                newName: "Answer");

            migrationBuilder.RenameColumn(
                name: "AnswerId",
                table: "ClosedAnswer",
                newName: "QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_ClosedAnswer_AnswerId",
                table: "ClosedAnswer",
                newName: "IX_ClosedAnswer_QuestionId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Surveys",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Surveys",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Surveys",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Answer",
                table: "OpenAnswer",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Question",
                table: "OpenAnswer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OpenAnswer_Question",
                table: "OpenAnswer",
                column: "Question",
                unique: true,
                filter: "[Question] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ClosedAnswer_Question_QuestionId",
                table: "ClosedAnswer",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OpenAnswer_Question_Question",
                table: "OpenAnswer",
                column: "Question",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_Company_CompanyId",
                table: "Surveys",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClosedAnswer_Question_QuestionId",
                table: "ClosedAnswer");

            migrationBuilder.DropForeignKey(
                name: "FK_OpenAnswer_Question_Question",
                table: "OpenAnswer");

            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_Company_CompanyId",
                table: "Surveys");

            migrationBuilder.DropIndex(
                name: "IX_OpenAnswer_Question",
                table: "OpenAnswer");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "Question",
                table: "OpenAnswer");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Surveys",
                newName: "ComapnyId");

            migrationBuilder.RenameIndex(
                name: "IX_Surveys_CompanyId",
                table: "Surveys",
                newName: "IX_Surveys_ComapnyId");

            migrationBuilder.RenameColumn(
                name: "GivenAnswer",
                table: "OpenAnswer",
                newName: "_Answer");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "ClosedAnswer",
                newName: "AnswerId");

            migrationBuilder.RenameColumn(
                name: "Answer",
                table: "ClosedAnswer",
                newName: "_Answer");

            migrationBuilder.RenameIndex(
                name: "IX_ClosedAnswer_QuestionId",
                table: "ClosedAnswer",
                newName: "IX_ClosedAnswer_AnswerId");

            migrationBuilder.AlterColumn<int>(
                name: "Answer",
                table: "OpenAnswer",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    AnswerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuestionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_Answer_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OpenAnswer_Answer",
                table: "OpenAnswer",
                column: "Answer",
                unique: true,
                filter: "[Answer] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_QuestionId",
                table: "Answer",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClosedAnswer_Answer_AnswerId",
                table: "ClosedAnswer",
                column: "AnswerId",
                principalTable: "Answer",
                principalColumn: "AnswerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OpenAnswer_Answer_Answer",
                table: "OpenAnswer",
                column: "Answer",
                principalTable: "Answer",
                principalColumn: "AnswerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_Company_ComapnyId",
                table: "Surveys",
                column: "ComapnyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
