using ExodusFreedomLoans.DataAccess.Data.Repository.IRepository;
using ExodusFreedomLoans.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExodusFreedomLoans.DataAccess.Data.Repository
{
    public class ExpenseRepository : Repository<ExpenseReport>, IExpenseRepository
    {
        private readonly ApplicationDbContext _db;

        public ExpenseRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(ExpenseReport expenseReport)
        {
            var objFromDb = _db.ExpenseReport.FirstOrDefault(s => s.ExpenseReportKey == expenseReport.ExpenseReportKey);

            objFromDb.FullTimeIncome = expenseReport.FullTimeIncome;
            objFromDb.PartTimeIncome = expenseReport.PartTimeIncome;
            objFromDb.SelfEmploymentIncome = expenseReport.SelfEmploymentIncome;
            objFromDb.OtherMonthlyIncome = expenseReport.OtherMonthlyIncome;
            objFromDb.RetirementIncome = expenseReport.RetirementIncome;
            objFromDb.SSAIncome = expenseReport.SSAIncome;
            objFromDb.IRAIncome = expenseReport.IRAIncome;
            objFromDb.InheritanceIncome = expenseReport.InheritanceIncome;
            objFromDb.TANFIncome = expenseReport.TANFIncome;
            objFromDb.SNAPIncome = expenseReport.SNAPIncome;
            objFromDb.PublicHousingIncome = expenseReport.PublicHousingIncome;
            objFromDb.SSDisabilityIncome = expenseReport.SSDisabilityIncome;
            objFromDb.OtherAssistanceIncome = expenseReport.OtherAssistanceIncome;
            objFromDb.AlimonyIncome = expenseReport.AlimonyIncome;
            objFromDb.ChildSupportIncome = expenseReport.ChildSupportIncome;
            objFromDb.OtherSupportIncome = expenseReport.OtherSupportIncome;
            objFromDb.MortgageExpense = expenseReport.MortgageExpense;
            objFromDb.TechnologyExpense = expenseReport.TechnologyExpense;
            objFromDb.ElecGasExpense = expenseReport.ElecGasExpense;
            objFromDb.WaterBillExpense = expenseReport.WaterBillExpense;
            objFromDb.CableExpense = expenseReport.CableExpense;
            objFromDb.MaintenanceExpense = expenseReport.MaintenanceExpense;
            objFromDb.OtherHousingExpense = expenseReport.OtherHousingExpense;
            objFromDb.CarExpense = expenseReport.CarExpense;
            objFromDb.AltTransportationExpense = expenseReport.AltTransportationExpense;
            objFromDb.FuelExpense = expenseReport.FuelExpense;
            objFromDb.VehichleMaintenanceExpense = expenseReport.VehichleMaintenanceExpense;
            objFromDb.OtherTransportationExpense = expenseReport.OtherTransportationExpense;
            objFromDb.HomeInsuranceExpense = expenseReport.HomeInsuranceExpense;
            objFromDb.VehicleInsuranceExpense = expenseReport.VehicleInsuranceExpense;
            objFromDb.HealthInsuranceExpense = expenseReport.HealthInsuranceExpense;
            objFromDb.LifeInsuranceExpense = expenseReport.LifeInsuranceExpense;
            objFromDb.LongTermCareExpense = expenseReport.LongTermCareExpense;
            objFromDb.OtherInsuranceExpense = expenseReport.OtherInsuranceExpense;
            objFromDb.PetExpense = expenseReport.PetExpense;
            objFromDb.DoctorExpense = expenseReport.DoctorExpense;
            objFromDb.PerscriptionExpense = expenseReport.PerscriptionExpense;
            objFromDb.MedicalCareExpense = expenseReport.MedicalCareExpense;
            objFromDb.PersonalCareExpense = expenseReport.PersonalCareExpense;
            objFromDb.ChargeAccountsExpense = expenseReport.ChargeAccountsExpense;
            objFromDb.LoanExpense = expenseReport.LoanExpense;
            objFromDb.DebtHighExpense = expenseReport.DebtHighExpense;
            objFromDb.AlimonyChildSupportExpense = expenseReport.AlimonyChildSupportExpense;

            _db.SaveChanges();
        }
    }
}
