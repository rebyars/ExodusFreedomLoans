using ExodusFreedomLoans.DataAccess.Data.Repository.IRepository;
using ExodusFreedomLoans.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<SelectListItem> GetApplicantListForDropDown()
        {
            return _db.Applicant.Select(i => new SelectListItem()
            {
                Text = i.ApplicantName,
                Value = i.ApplicantKey.ToString()
            });
        }

        public void Update(Applicant applicant)
        {
            var objFromDb = _db.Applicant.FirstOrDefault(s => s.ApplicantKey == applicant.ApplicantKey);

            objFromDb.ApplicantName = applicant.ApplicantName;
            objFromDb.ApplicantEmail = applicant.ApplicantEmail;
            objFromDb.ApplicantDOB = applicant.ApplicantDOB;
            objFromDb.ApplicantPhone = applicant.ApplicantPhone;
            objFromDb.ApplicantAddress = applicant.ApplicantAddress;
            objFromDb.PreviousAddress = applicant.PreviousAddress;
            objFromDb.EmployerName = applicant.EmployerName;
            objFromDb.EmployerAddress = applicant.EmployerAddress;
            objFromDb.EmployerEmail = applicant.EmployerEmail;
            objFromDb.EmployerPhone = applicant.EmployerPhone;
            objFromDb.EmployerTenure = applicant.EmployerTenure;
            objFromDb.ApplicantPosition = applicant.ApplicantPosition;
            objFromDb.ApplicantPayStructure = applicant.ApplicantPayStructure;
            objFromDb.ApplicantMonthlyIncome = applicant.ApplicantMonthlyIncome;
            objFromDb.PrevEmployerName = applicant.PrevEmployerName;
            objFromDb.PrevEmployerAddress = applicant.PrevEmployerAddress;
            objFromDb.PrevEmployerEmail = applicant.PrevEmployerEmail;
            objFromDb.PrevEmployerPhone = applicant.PrevEmployerPhone;
            objFromDb.PrevEmployerTenure = applicant.PrevEmployerTenure;
            objFromDb.PrevApplicantPosition = applicant.PrevApplicantPosition;
            objFromDb.PrevApplicantPayStructure = applicant.PrevApplicantPayStructure;
            objFromDb.NearestRelativeName = applicant.NearestRelativeName;
            objFromDb.NearestRelativeAddress = applicant.NearestRelativeAddress;
            objFromDb.NearestRelativePhone = applicant.NearestRelativePhone;
            objFromDb.NearestRelativeRelation = applicant.NearestRelativeRelation;
            objFromDb.SetListOfLoans(applicant.GetListOfLoans());

            _db.SaveChanges();

        }
    }
}
