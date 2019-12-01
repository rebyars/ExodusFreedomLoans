using System;
using System.Collections.Generic;
using System.Text;

namespace ExodusFreedomLoans.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IApplicantRepository Applicant { get; }
        void Save();
    }
}
