using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExodusFreedomLoans.Models
{
    public class VMApplicant
    {
        
        public Applicant Applicant { get; set; }

        public ExpenseReport ExpenseReport { get; set; }
    }
}
