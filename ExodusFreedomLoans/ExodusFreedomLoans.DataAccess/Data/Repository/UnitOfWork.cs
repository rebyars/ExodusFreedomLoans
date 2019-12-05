using ExodusFreedomLoans.DataAccess.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExodusFreedomLoans.DataAccess.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            ExpenseReport = new ExpenseRepository(_db);
            Applicant = new ApplicantRepository(_db);
            User = new UserRepository(_db);
        }

        public IApplicantRepository Applicant { get; private set; }

        public IExpenseRepository ExpenseReport { get; private set; }

        public IUserRepository User { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
