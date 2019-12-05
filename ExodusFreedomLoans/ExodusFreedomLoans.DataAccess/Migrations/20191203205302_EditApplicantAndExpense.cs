using Microsoft.EntityFrameworkCore.Migrations;

namespace ExodusFreedomLoans.DataAccess.Migrations
{
    public partial class EditApplicantAndExpense : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "PrevApplicantCity",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PrevApplicantHousingType",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PrevApplicantMonthlyIncome",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PrevApplicantPayStructure",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PrevApplicantPosition",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PrevApplicantState",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PrevApplicantStreetAddress",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PrevApplicantZipCode",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PrevEmployerCity",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PrevEmployerEmail",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PrevEmployerName",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PrevEmployerPhone",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PrevEmployerState",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PrevEmployerStreetAddress",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PrevEmployerTenure",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PrevEmployerZipCode",
                table: "Applicant");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PrevApplicantCity",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PrevApplicantHousingType",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PrevApplicantMonthlyIncome",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PrevApplicantPayStructure",
                table: "Applicant",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PrevApplicantPosition",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrevApplicantState",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PrevApplicantStreetAddress",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PrevApplicantZipCode",
                table: "Applicant",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PrevEmployerCity",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrevEmployerEmail",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrevEmployerName",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrevEmployerPhone",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrevEmployerState",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrevEmployerStreetAddress",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrevEmployerTenure",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PrevEmployerZipCode",
                table: "Applicant",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HousingType = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });
        }
    }
}
