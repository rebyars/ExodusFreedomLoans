using Microsoft.EntityFrameworkCore.Migrations;

namespace ExodusFreedomLoans.DataAccess.Migrations
{
    public partial class EditApplicantFk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applicant_ExpenseReport_ExpenseSheetId",
                table: "Applicant");

            migrationBuilder.DropIndex(
                name: "IX_Applicant_ExpenseSheetId",
                table: "Applicant");

            migrationBuilder.AddColumn<int>(
                name: "ApplicantId",
                table: "ExpenseReport",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExpenseSheetId",
                table: "Applicant",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Applicant_ExpenseSheetId",
                table: "Applicant",
                column: "ExpenseSheetId",
                unique: true,
                filter: "[ExpenseSheetId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Applicant_ExpenseReport_ExpenseSheetId",
                table: "Applicant",
                column: "ExpenseSheetId",
                principalTable: "ExpenseReport",
                principalColumn: "ExpenseReportKey",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applicant_ExpenseReport_ExpenseSheetId",
                table: "Applicant");

            migrationBuilder.DropIndex(
                name: "IX_Applicant_ExpenseSheetId",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "ApplicantId",
                table: "ExpenseReport");

            migrationBuilder.AlterColumn<int>(
                name: "ExpenseSheetId",
                table: "Applicant",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Applicant_ExpenseSheetId",
                table: "Applicant",
                column: "ExpenseSheetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applicant_ExpenseReport_ExpenseSheetId",
                table: "Applicant",
                column: "ExpenseSheetId",
                principalTable: "ExpenseReport",
                principalColumn: "ExpenseReportKey",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
