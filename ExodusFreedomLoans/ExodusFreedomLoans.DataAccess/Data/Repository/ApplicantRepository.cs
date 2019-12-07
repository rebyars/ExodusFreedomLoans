using ExodusFreedomLoans.DataAccess.Data.Repository.IRepository;
using ExodusFreedomLoans.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using ExodusFreedomLoans.Utility;
using System.Text;

namespace ExodusFreedomLoans.DataAccess.Data.Repository
{
    public class ApplicantRepository : Repository<Applicant>, IApplicantRepository
    {
        private readonly ApplicationDbContext _db;

        public ApplicantRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Accept(Applicant applicant)
        {
            var userFromDb = _db.Applicant.FirstOrDefault(u => u.ApplicantKey == applicant.ApplicantKey);
            userFromDb.ApplicationStatus = SD.Approved;
            _db.SaveChanges();
        }

        public void Decline(Applicant applicant)
        {
            var userFromDb = _db.Applicant.FirstOrDefault(u => u.ApplicantKey == applicant.ApplicantKey);
            userFromDb.ApplicationStatus = SD.Declined;
            _db.SaveChanges();
        }

        public IEnumerable<SelectListItem> GetApplicantListForDropDown()
        {
            return _db.Applicant.Select(i => new SelectListItem()
            {
                Text = i.ApplicantName,
                Value = i.ApplicantKey.ToString()
            });
        }

        public void Reopen(Applicant applicant)
        {
            var userFromDb = _db.Applicant.FirstOrDefault(u => u.ApplicantKey == applicant.ApplicantKey);
            userFromDb.ApplicationStatus = SD.Pending;
            _db.SaveChanges();
        }

        public void Update(Applicant applicant)
        {
            var objFromDb = _db.Applicant.FirstOrDefault(s => s.ApplicantKey == applicant.ApplicantKey);

            objFromDb.ApplicantName = applicant.ApplicantName;
            objFromDb.ApplicantEmail = applicant.ApplicantEmail;
            objFromDb.ApplicantDOB = applicant.ApplicantDOB;
            objFromDb.ApplicantPhone = applicant.ApplicantPhone;
            objFromDb.ApplicantStreetAddress = applicant.ApplicantStreetAddress;
            objFromDb.ApplicantCity = applicant.ApplicantCity;
            objFromDb.ApplicantState = applicant.ApplicantState;
            objFromDb.ApplicantZipCode = applicant.ApplicantZipCode;
            objFromDb.ApplicantHousingType = applicant.ApplicantHousingType;
            /*
            objFromDb.PrevApplicantStreetAddress = applicant.PrevApplicantStreetAddress;
            objFromDb.PrevApplicantCity = applicant.PrevApplicantCity;
            objFromDb.PrevApplicantState = applicant.PrevApplicantState;
            objFromDb.PrevApplicantZipCode = applicant.PrevApplicantZipCode;
            objFromDb.PrevApplicantHousingType = applicant.PrevApplicantHousingType;
            */
            objFromDb.EmployerName = applicant.EmployerName;
            objFromDb.EmployerStreetAddress = applicant.EmployerStreetAddress;
            objFromDb.EmployerCity = applicant.EmployerCity;
            objFromDb.EmployerState = applicant.EmployerState;
            objFromDb.EmployerZipCode = applicant.EmployerZipCode;
            objFromDb.EmployerEmail = applicant.EmployerEmail;
            objFromDb.EmployerPhone = applicant.EmployerPhone;
            objFromDb.EmployerTenure = applicant.EmployerTenure;
            objFromDb.ApplicantPosition = applicant.ApplicantPosition;
            objFromDb.ApplicantPayStructure = applicant.ApplicantPayStructure;
            objFromDb.ApplicantMonthlyIncome = applicant.ApplicantMonthlyIncome;
            /*
            objFromDb.PrevEmployerName = applicant.PrevEmployerName;
            objFromDb.PrevEmployerStreetAddress = applicant.PrevEmployerStreetAddress;
            objFromDb.PrevEmployerCity = applicant.PrevEmployerCity;
            objFromDb.PrevEmployerState = applicant.PrevEmployerState;
            objFromDb.PrevEmployerZipCode = applicant.PrevEmployerZipCode;
            objFromDb.PrevEmployerEmail = applicant.PrevEmployerEmail;
            objFromDb.PrevEmployerPhone = applicant.PrevEmployerPhone;
            objFromDb.PrevEmployerTenure = applicant.PrevEmployerTenure;
            objFromDb.PrevApplicantPosition = applicant.PrevApplicantPosition;
            objFromDb.PrevApplicantPayStructure = applicant.PrevApplicantPayStructure;
            */
            objFromDb.NearestRelativeName = applicant.NearestRelativeName;
            objFromDb.NearestRelativeStreetAddress = applicant.NearestRelativeStreetAddress;
            objFromDb.NearestRelativeCity = applicant.NearestRelativeCity;
            objFromDb.NearestRelativeState = applicant.NearestRelativeState;
            objFromDb.NearestRelativeZipCode = applicant.NearestRelativeZipCode;
            objFromDb.NearestRelativePhone = applicant.NearestRelativePhone;
            objFromDb.NearestRelativeRelation = applicant.NearestRelativeRelation;
            /*
            objFromDb.SetListOfLoans(applicant.GetListOfLoans());
            */
            objFromDb.ExpenseSheetId = applicant.ExpenseSheetId;
            objFromDb.HowWhenText = applicant.HowWhenText;
            objFromDb.DoReferredText = applicant.DoReferredText;
            objFromDb.ApplicationStatus = applicant.ApplicationStatus;

            _db.SaveChanges();

        }
    }
}
