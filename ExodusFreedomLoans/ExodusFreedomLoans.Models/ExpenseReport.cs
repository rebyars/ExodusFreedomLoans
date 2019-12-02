using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExodusFreedomLoans.Models
{
    public class ExpenseReport
    {
        [Key]
        public int ExpenseReportKey { get; set; }

        [Required]
        [Display(Name = "Full-time Work Income")]
        public int FullTimeIncome { get; set; }

        [Required]
        [Display(Name = "Part-Time Work Income")]
        public int PartTimeIncome { get; set; }

        [Required]
        [Display(Name = "Self Employment Work")]
        public int SelfEmploymentIncome { get; set; }

        [Required]
        [Display(Name = "Other Work Income")]
        public int OtherMonthlyIncome { get; set; }

        [Required]
        [Display(Name = "Retirement (Pension) Payments")]
        public int RetirementIncome { get; set; }

        [Required]
        [Display(Name = "SSA Retirement Payments")]
        public int SSAIncome { get; set; }

        [Required]
        [Display(Name = "IRA Monthly Payments")]
        public int IRAIncome { get; set; }

        [Required]
        [Display(Name = "Inheritance Monthly Payments")]
        public int InheritanceIncome { get; set; }

        [Required]
        [Display(Name = "TANF Income")]
        public int TANFIncome { get; set; }

        [Required]
        [Display(Name = "SNAP Income")]
        public int SNAPIncome { get; set; }

        [Required]
        [Display(Name = "Public Housing Voucher")]
        public int PublicHousingIncome { get; set; }

        [Required]
        [Display(Name = "SS Disability Payments")]
        public int SSDisabilityIncome { get; set; }

        [Required]
        [Display(Name = "Other Public Assistance Payments")]
        public int OtherAssistanceIncome { get; set; }

        [Required]
        [Display(Name = "Alimony")]
        public int AlimonyIncome { get; set; }

        [Required]
        [Display(Name = "Child Support")]
        public int ChildSupportIncome { get; set; }

        [Required]
        [Display(Name = "Onther Monthly Support")]
        public int OtherSupportIncome { get; set; }

        [Required]
        [Display(Name = "Mortgage or Rent Expense")]
        public int MortgageExpense { get; set; }

        [Required]
        [Display(Name = "Phone, Internet, and Mobile Phone Expense")]
        public int TechnologyExpense { get; set; }

        [Required]
        [Display(Name = "Electricity, Gas Expense")]
        public int ElecGasExpense { get; set; }

        [Required]
        [Display(Name = "Water, Sewer, and Trash")]
        public int WaterBillExpense { get; set; }

        [Required]
        [Display(Name = "Cable")]
        public int CableExpense { get; set; }

        [Required]
        [Display(Name = "Home Maintenance and Repairs")]
        public int MaintenanceExpense { get; set; }

        [Required]
        [Display(Name = "Other Monthly Housing Expenses")]
        public int OtherHousingExpense { get; set; }

        [Required]
        [Display(Name = "Cars, Trucks, and Motorcycle Payments")]
        public int CarExpense { get; set; }

        [Required]
        [Display(Name = "Bus, Lyft, Uber and Taxi Expenses")]
        public int AltTransportationExpense { get; set; }

        [Required]
        [Display(Name = "Fuel and Gas")]
        public int FuelExpense { get; set; }

        [Required]
        [Display(Name = "Vehicle Maintenance/ Service")]
        public int VehichleMaintenanceExpense { get; set; }

        [Required]
        [Display(Name = "Other Transportation Expenses")]
        public int OtherTransportationExpense { get; set; }

        [Required]
        [Display(Name = "Home or Rental Insurance")]
        public int HomeInsuranceExpense { get; set; }

        [Required]
        [Display(Name = "Cars, Trucks, and Motorcycle Insurance")]
        public int VehicleInsuranceExpense { get; set; }

        [Required]
        [Display(Name = "Health (Medical) Insurance")]
        public int HealthInsuranceExpense { get; set; }

        [Required]
        [Display(Name = "Life Insurance")]
        public int LifeInsuranceExpense { get; set; }

        [Required]
        [Display(Name = "Long-term Care Payments")]
        public int LongTermCareExpense { get; set; }

        [Required]
        [Display(Name = "Other Insurance")]
        public int OtherInsuranceExpense { get; set; }

        [Required]
        [Display(Name = "Pet Food, Grooming, Medical Care and other Pet Expenses")]
        public int PetExpense { get; set; }

        [Required]
        [Display(Name = "Doctor or Dental Co-pay and Payments")]
        public int DoctorExpense { get; set; }

        [Required]
        [Display(Name = "Prescription Co-pays and Payments")]
        public int PerscriptionExpense { get; set; }

        [Required]
        [Display(Name = "Other Medical Care Expenses")]
        public int MedicalCareExpense { get; set; }

        [Required]
        [Display(Name = "Personal Care (Haircut, Gym, etc.)")]
        public int PersonalCareExpense { get; set; }

        [Required]
        [Display(Name = "All Monthly Charge Accounts")]
        public int ChargeAccountsExpense { get; set; }

        [Required]
        [Display(Name = "All Loans (not house or vehicle)")]
        public int LoanExpense { get; set; }

        [Required]
        [Display(Name = "All Debt or High Interest Payments")]
        public int DebtHighExpense { get; set; }

        [Required]
        [Display(Name = "Monthly Alimony / Child Support")]
        public int AlimonyChildSupportExpense { get; set; }


    }
}
