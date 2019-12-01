using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExodusFreedomLoans.Models
{
    public class Loan
    {
        [Key]
        public int LoanKey { get; set; }

        [Required]
        [Display(Name = "Loan Name")]
        public string LoanName { get; set; }

        [Required]
        [Display(Name = "Loan Type")]
        public int LoanType { get; set; }

        [Required]
        [Display(Name = "Account Number")]
        public int AccountNumber { get; set; }

        [Required]
        [Display(Name = "Current Balance")]
        public float CurrentBalance { get; set; }

        [Required]
        [Display(Name = "Payment")]
        public float Payment { get; set; }

        [Required]
        [Display(Name = "Interest Rate")]
        public float InterestRate { get; set; }

        
        [ForeignKey("ApplicantKey")]
        public int ApplicantKey { get; set; }
    }
}
