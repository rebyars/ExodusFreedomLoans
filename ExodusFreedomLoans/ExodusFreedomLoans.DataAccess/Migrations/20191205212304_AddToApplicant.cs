using Microsoft.EntityFrameworkCore.Migrations;

namespace ExodusFreedomLoans.DataAccess.Migrations
{
    public partial class AddToApplicant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "ApplicationStatus",
                table: "Applicant",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DoReferredText",
                table: "Applicant",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HowWhenText",
                table: "Applicant",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Company",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationStatus",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "DoReferredText",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "HowWhenText",
                table: "Applicant");
        }
    }
}
