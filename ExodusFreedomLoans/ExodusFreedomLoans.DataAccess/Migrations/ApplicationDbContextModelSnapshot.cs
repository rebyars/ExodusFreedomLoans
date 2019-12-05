﻿// <auto-generated />
using System;
using ExodusFreedomLoans.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExodusFreedomLoans.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExodusFreedomLoans.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HousingType")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("ExodusFreedomLoans.Models.Applicant", b =>
                {
                    b.Property<int>("ApplicantKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicantCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicantDOB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicantEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ApplicantHousingType")
                        .HasColumnType("int");

                    b.Property<string>("ApplicantMonthlyIncome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ApplicantPayStructure")
                        .HasColumnType("bit");

                    b.Property<string>("ApplicantPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicantPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicantState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicantStreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicantZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<string>("EmployerCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployerPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployerState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployerStreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployerTenure")
                        .HasColumnType("int");

                    b.Property<string>("EmployerZipCode")
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<int>("ExpenseSheetId")
                        .HasColumnType("int");

                    b.Property<string>("NearestRelativeCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NearestRelativeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NearestRelativePhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NearestRelativeRelation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NearestRelativeState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NearestRelativeStreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NearestRelativeZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<string>("PrevApplicantCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrevApplicantHousingType")
                        .HasColumnType("int");

                    b.Property<string>("PrevApplicantMonthlyIncome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PrevApplicantPayStructure")
                        .HasColumnType("bit");

                    b.Property<string>("PrevApplicantPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrevApplicantState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrevApplicantStreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrevApplicantZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<string>("PrevEmployerCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrevEmployerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrevEmployerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrevEmployerPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrevEmployerState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrevEmployerStreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrevEmployerTenure")
                        .HasColumnType("int");

                    b.Property<string>("PrevEmployerZipCode")
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.HasKey("ApplicantKey");

                    b.HasIndex("ExpenseSheetId");

                    b.ToTable("Applicant");
                });

            modelBuilder.Entity("ExodusFreedomLoans.Models.ExpenseReport", b =>
                {
                    b.Property<int>("ExpenseReportKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlimonyChildSupportExpense")
                        .HasColumnType("int");

                    b.Property<int>("AlimonyIncome")
                        .HasColumnType("int");

                    b.Property<int>("AltTransportationExpense")
                        .HasColumnType("int");

                    b.Property<int>("CableExpense")
                        .HasColumnType("int");

                    b.Property<int>("CarExpense")
                        .HasColumnType("int");

                    b.Property<int>("ChargeAccountsExpense")
                        .HasColumnType("int");

                    b.Property<int>("ChildSupportIncome")
                        .HasColumnType("int");

                    b.Property<int>("DebtHighExpense")
                        .HasColumnType("int");

                    b.Property<int>("DoctorExpense")
                        .HasColumnType("int");

                    b.Property<int>("ElecGasExpense")
                        .HasColumnType("int");

                    b.Property<int>("FuelExpense")
                        .HasColumnType("int");

                    b.Property<int>("FullTimeIncome")
                        .HasColumnType("int");

                    b.Property<int>("HealthInsuranceExpense")
                        .HasColumnType("int");

                    b.Property<int>("HomeInsuranceExpense")
                        .HasColumnType("int");

                    b.Property<int>("IRAIncome")
                        .HasColumnType("int");

                    b.Property<int>("InheritanceIncome")
                        .HasColumnType("int");

                    b.Property<int>("LifeInsuranceExpense")
                        .HasColumnType("int");

                    b.Property<int>("LoanExpense")
                        .HasColumnType("int");

                    b.Property<int>("LongTermCareExpense")
                        .HasColumnType("int");

                    b.Property<int>("MaintenanceExpense")
                        .HasColumnType("int");

                    b.Property<int>("MedicalCareExpense")
                        .HasColumnType("int");

                    b.Property<int>("MortgageExpense")
                        .HasColumnType("int");

                    b.Property<int>("OtherAssistanceIncome")
                        .HasColumnType("int");

                    b.Property<int>("OtherHousingExpense")
                        .HasColumnType("int");

                    b.Property<int>("OtherInsuranceExpense")
                        .HasColumnType("int");

                    b.Property<int>("OtherMonthlyIncome")
                        .HasColumnType("int");

                    b.Property<int>("OtherSupportIncome")
                        .HasColumnType("int");

                    b.Property<int>("OtherTransportationExpense")
                        .HasColumnType("int");

                    b.Property<int>("PartTimeIncome")
                        .HasColumnType("int");

                    b.Property<int>("PerscriptionExpense")
                        .HasColumnType("int");

                    b.Property<int>("PersonalCareExpense")
                        .HasColumnType("int");

                    b.Property<int>("PetExpense")
                        .HasColumnType("int");

                    b.Property<int>("PublicHousingIncome")
                        .HasColumnType("int");

                    b.Property<int>("RetirementIncome")
                        .HasColumnType("int");

                    b.Property<int>("SNAPIncome")
                        .HasColumnType("int");

                    b.Property<int>("SSAIncome")
                        .HasColumnType("int");

                    b.Property<int>("SSDisabilityIncome")
                        .HasColumnType("int");

                    b.Property<int>("SelfEmploymentIncome")
                        .HasColumnType("int");

                    b.Property<int>("TANFIncome")
                        .HasColumnType("int");

                    b.Property<int>("TechnologyExpense")
                        .HasColumnType("int");

                    b.Property<int>("VehichleMaintenanceExpense")
                        .HasColumnType("int");

                    b.Property<int>("VehicleInsuranceExpense")
                        .HasColumnType("int");

                    b.Property<int>("WaterBillExpense")
                        .HasColumnType("int");

                    b.HasKey("ExpenseReportKey");

                    b.ToTable("ExpenseReport");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ExodusFreedomLoans.Models.Applicant", b =>
                {
                    b.HasOne("ExodusFreedomLoans.Models.ExpenseReport", "ExpenseReport")
                        .WithMany()
                        .HasForeignKey("ExpenseSheetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
