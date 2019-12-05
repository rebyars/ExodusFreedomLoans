using System;
using System.Collections.Generic;
using System.Text;

namespace ExodusFreedomLoans.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IApplicantRepository Applicant { get; }


        IExpenseRepository ExpenseReport { get; }

        IUserRepository User { get; }

        void Save();
    }
}
