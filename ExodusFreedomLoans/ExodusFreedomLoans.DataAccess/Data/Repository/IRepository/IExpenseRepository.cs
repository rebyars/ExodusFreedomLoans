using ExodusFreedomLoans.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExodusFreedomLoans.DataAccess.Data.Repository.IRepository
{
    public interface IExpenseRepository : IRepository<ExpenseReport>
    { 
        void Update(ExpenseReport expenseReport);
    }
}
