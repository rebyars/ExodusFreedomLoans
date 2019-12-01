using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExodusFreedomLoans.Models
{
    public class Applicant
    {
        [Key]
        public int ApplicantKey { get; set; }

        [Required]
        [Display(Name = "Applicant Name")]
        public string ApplicantName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Applicant Email")]
        public string ApplicantEmail { get; set; }

        [Required]
        [Display(Name = "Applicant DOB")]
        public string ApplicantDOB { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Applicant Phone Number")]
        public string ApplicantPhone { get; set; }


        [Display(Name = "Applicant Address")]
        [ForeignKey("AddressForeignKey")]
        public Address ApplicantAddress { get; set; }


        [Display(Name = "Applicant Previous Address")]
        [ForeignKey("PrevAddressForeignKey")]
        public Address PreviousAddress { get; set; }


        [Display(Name = "Current Employer")]
        public string EmployerName { get; set; }


        [Display(Name = "Current Employer Address")]
        [ForeignKey("EmployerAddressForeignKey")]
        public Address EmployerAddress { get; set; }


        [EmailAddress]
        [Display(Name = "Employer Email")]
        public string EmployerEmail { get; set; }


        [Phone]
        [Display(Name = "Employer Phone Number")]
        public string EmployerPhone { get; set; }


        [Display(Name = "Time with employer: ")]
        public int EmployerTenure { get; set; }


        [Display(Name = "Applicant Position")]
        public string ApplicantPosition { get; set; }


        [Display(Name = "Pay Structure")]
        public bool ApplicantPayStructure { get; set; }


        [Display(Name = "Monthly Income")]
        public string ApplicantMonthlyIncome { get; set; }

        [Display(Name = "Previous Employer")]
        public string PrevEmployerName { get; set; }


        [Display(Name = "Previous Employer Address")]
        [ForeignKey("PreviousAddressForeignKey")]
        public Address PrevEmployerAddress { get; set; }


        [EmailAddress]
        [Display(Name = "Previous Employer Email")]
        public string PrevEmployerEmail { get; set; }


        [Phone]
        [Display(Name = "Previous Employer Phone Number")]
        public string PrevEmployerPhone { get; set; }


        [Display(Name = "Time with previous employer: ")]
        public int PrevEmployerTenure { get; set; }


        [Display(Name = "Applicant Previous Position")]
        public string PrevApplicantPosition { get; set; }


        [Display(Name = "Previous Pay Structure")]
        public bool PrevApplicantPayStructure { get; set; }


        [Display(Name = "Previous Monthly Income")]
        public string PrevApplicantMonthlyIncome { get; set; }

        [Required]
        [Display(Name = "Nearest Relative Name")]
        public string NearestRelativeName { get; set; }


        [Display(Name = "Nearest Relative Address")]
        [ForeignKey("NearestRelativeAddressForeignKey")]
        public Address NearestRelativeAddress { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Nearest Relative Phone Number")]
        public string NearestRelativePhone { get; set; }

        [Required]
        [Display(Name = "Nearest Relative Relation to Applicant")]
        public string NearestRelativeRelation { get; set; }

        private Loan[] listOfLoans;

        [ForeignKey("CoApplicantForeignKey")]
        [Display(Name = "Co-applicant Key")]
        public Applicant CoApplicant { get; set; }



        [ForeignKey("ExpenseSheetForeignKey")]
        [Display(Name = "Expense Foreign Key")]
        public int ExpenseForeignKey { get; set; }

        public Loan[] GetListOfLoans()
        {
            return listOfLoans;
        }


        public void SetListOfLoans(Loan[] value)
        {
            listOfLoans = value;
        }
    }
}
