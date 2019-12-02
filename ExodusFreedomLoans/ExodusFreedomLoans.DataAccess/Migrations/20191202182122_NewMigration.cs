using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExodusFreedomLoans.DataAccess.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetAddress = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    ZipCode = table.Column<string>(nullable: false),
                    HousingType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseReport",
                columns: table => new
                {
                    ExpenseReportKey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullTimeIncome = table.Column<int>(nullable: false),
                    PartTimeIncome = table.Column<int>(nullable: false),
                    SelfEmploymentIncome = table.Column<int>(nullable: false),
                    OtherMonthlyIncome = table.Column<int>(nullable: false),
                    RetirementIncome = table.Column<int>(nullable: false),
                    SSAIncome = table.Column<int>(nullable: false),
                    IRAIncome = table.Column<int>(nullable: false),
                    InheritanceIncome = table.Column<int>(nullable: false),
                    TANFIncome = table.Column<int>(nullable: false),
                    SNAPIncome = table.Column<int>(nullable: false),
                    PublicHousingIncome = table.Column<int>(nullable: false),
                    SSDisabilityIncome = table.Column<int>(nullable: false),
                    OtherAssistanceIncome = table.Column<int>(nullable: false),
                    AlimonyIncome = table.Column<int>(nullable: false),
                    ChildSupportIncome = table.Column<int>(nullable: false),
                    OtherSupportIncome = table.Column<int>(nullable: false),
                    MortgageExpense = table.Column<int>(nullable: false),
                    TechnologyExpense = table.Column<int>(nullable: false),
                    ElecGasExpense = table.Column<int>(nullable: false),
                    WaterBillExpense = table.Column<int>(nullable: false),
                    CableExpense = table.Column<int>(nullable: false),
                    MaintenanceExpense = table.Column<int>(nullable: false),
                    OtherHousingExpense = table.Column<int>(nullable: false),
                    CarExpense = table.Column<int>(nullable: false),
                    AltTransportationExpense = table.Column<int>(nullable: false),
                    FuelExpense = table.Column<int>(nullable: false),
                    VehichleMaintenanceExpense = table.Column<int>(nullable: false),
                    OtherTransportationExpense = table.Column<int>(nullable: false),
                    HomeInsuranceExpense = table.Column<int>(nullable: false),
                    VehicleInsuranceExpense = table.Column<int>(nullable: false),
                    HealthInsuranceExpense = table.Column<int>(nullable: false),
                    LifeInsuranceExpense = table.Column<int>(nullable: false),
                    LongTermCareExpense = table.Column<int>(nullable: false),
                    OtherInsuranceExpense = table.Column<int>(nullable: false),
                    PetExpense = table.Column<int>(nullable: false),
                    DoctorExpense = table.Column<int>(nullable: false),
                    PerscriptionExpense = table.Column<int>(nullable: false),
                    MedicalCareExpense = table.Column<int>(nullable: false),
                    PersonalCareExpense = table.Column<int>(nullable: false),
                    ChargeAccountsExpense = table.Column<int>(nullable: false),
                    LoanExpense = table.Column<int>(nullable: false),
                    DebtHighExpense = table.Column<int>(nullable: false),
                    AlimonyChildSupportExpense = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseReport", x => x.ExpenseReportKey);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Applicant",
                columns: table => new
                {
                    ApplicantKey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicantName = table.Column<string>(nullable: false),
                    ApplicantEmail = table.Column<string>(nullable: false),
                    ApplicantDOB = table.Column<string>(nullable: false),
                    ApplicantPhone = table.Column<string>(nullable: false),
                    ApplicantStreetAddress = table.Column<string>(nullable: false),
                    ApplicantCity = table.Column<string>(nullable: false),
                    ApplicantState = table.Column<string>(nullable: false),
                    ApplicantZipCode = table.Column<string>(maxLength: 5, nullable: false),
                    ApplicantHousingType = table.Column<int>(nullable: false),
                    PrevApplicantStreetAddress = table.Column<string>(nullable: false),
                    PrevApplicantCity = table.Column<string>(nullable: false),
                    PrevApplicantState = table.Column<string>(nullable: false),
                    PrevApplicantZipCode = table.Column<string>(maxLength: 5, nullable: false),
                    PrevApplicantHousingType = table.Column<int>(nullable: false),
                    EmployerName = table.Column<string>(nullable: true),
                    EmployerStreetAddress = table.Column<string>(nullable: true),
                    EmployerCity = table.Column<string>(nullable: true),
                    EmployerState = table.Column<string>(nullable: true),
                    EmployerZipCode = table.Column<string>(maxLength: 5, nullable: true),
                    EmployerEmail = table.Column<string>(nullable: true),
                    EmployerPhone = table.Column<string>(nullable: true),
                    EmployerTenure = table.Column<int>(nullable: false),
                    ApplicantPosition = table.Column<string>(nullable: true),
                    ApplicantPayStructure = table.Column<bool>(nullable: false),
                    ApplicantMonthlyIncome = table.Column<string>(nullable: true),
                    PrevEmployerName = table.Column<string>(nullable: true),
                    PrevEmployerStreetAddress = table.Column<string>(nullable: true),
                    PrevEmployerCity = table.Column<string>(nullable: true),
                    PrevEmployerState = table.Column<string>(nullable: true),
                    PrevEmployerZipCode = table.Column<string>(maxLength: 5, nullable: true),
                    PrevEmployerEmail = table.Column<string>(nullable: true),
                    PrevEmployerPhone = table.Column<string>(nullable: true),
                    PrevEmployerTenure = table.Column<int>(nullable: false),
                    PrevApplicantPosition = table.Column<string>(nullable: true),
                    PrevApplicantPayStructure = table.Column<bool>(nullable: false),
                    PrevApplicantMonthlyIncome = table.Column<string>(nullable: true),
                    NearestRelativeName = table.Column<string>(nullable: false),
                    NearestRelativeStreetAddress = table.Column<string>(nullable: false),
                    NearestRelativeCity = table.Column<string>(nullable: false),
                    NearestRelativeState = table.Column<string>(nullable: false),
                    NearestRelativeZipCode = table.Column<string>(maxLength: 5, nullable: false),
                    NearestRelativePhone = table.Column<string>(nullable: false),
                    NearestRelativeRelation = table.Column<string>(nullable: false),
                    ExpenseSheetId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicant", x => x.ApplicantKey);
                    table.ForeignKey(
                        name: "FK_Applicant_ExpenseReport_ExpenseSheetId",
                        column: x => x.ExpenseSheetId,
                        principalTable: "ExpenseReport",
                        principalColumn: "ExpenseReportKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applicant_ExpenseSheetId",
                table: "Applicant",
                column: "ExpenseSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Applicant");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ExpenseReport");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
