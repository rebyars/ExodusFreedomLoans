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

        [Required]
        [Display(Name = ("Street Address"))]
        public string ApplicantStreetAddress { get; set; }

        [Required]
        [Display(Name = "City")]
        public string ApplicantCity { get; set; }

        [Required]
        [Display(Name = "State")]
        public string ApplicantState { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        [MinLength(5)]
        [MaxLength(5)]
        public string ApplicantZipCode { get; set; }

        [Required]
        [Display(Name="Rent Or Own")]
        public int ApplicantHousingType { get; set; }

        /*
        [Required]
        [Display(Name = ("Street Address"))]
        public string PrevApplicantStreetAddress { get; set; } 

        [Required]
        [Display(Name = "City")]
        public string PrevApplicantCity { get; set; }

        [Required]
        [Display(Name = "State")]
        public string PrevApplicantState { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        [MinLength(5)]
        [MaxLength(5)]
        public string PrevApplicantZipCode { get; set; }

        
        [Required]
        [Display(Name = "Rent Or Own")]
        public int PrevApplicantHousingType { get; set; }
        */

        [Display(Name = "Current Employer Name")]
        public string EmployerName { get; set; }


        [Display(Name = ("Street Address"))]
        public string EmployerStreetAddress { get; set; }


        [Display(Name = "City")]
        public string EmployerCity { get; set; }


        [Display(Name = "State")]
        public string EmployerState { get; set; }


        [Display(Name = "Zip Code")]
        [MinLength(5)]
        [MaxLength(5)]
        public string EmployerZipCode { get; set; }


        [EmailAddress]
        [Display(Name = "Employer Email")]
        public string EmployerEmail { get; set; }


        [Phone]
        [Display(Name = "Employer Phone Number")]
        public string EmployerPhone { get; set; }


        [Display(Name = "Time with employer: ")]
        public int EmployerTenure { get; set; }


        [Display(Name = "Applicant Position/Role")]
        public string ApplicantPosition { get; set; }


        [Display(Name = "Pay Structure")]
        public bool ApplicantPayStructure { get; set; }


        [Display(Name = "Monthly Income")]
        public string ApplicantMonthlyIncome { get; set; }

        /*
        [Display(Name = "Previous Employer")]
        public string PrevEmployerName { get; set; }

      
        [Display(Name = ("Street Address"))]
        public string PrevEmployerStreetAddress { get; set; }

   
        [Display(Name = "City")]
        public string PrevEmployerCity { get; set; }

   
        [Display(Name = "State")]
        public string PrevEmployerState { get; set; }


        [Display(Name = "Zip Code")]
        [MinLength(5)]
        [MaxLength(5)]
        public string PrevEmployerZipCode { get; set; }


        [EmailAddress]
        [Display(Name = "Previous Employer Email")]
        public string PrevEmployerEmail { get; set; }


        [Phone]
        [Display(Name = "Previous Employer Phone Number")]
        public string PrevEmployerPhone { get; set; }


        [Display(Name = "Time with previous employer: ")]
        public int PrevEmployerTenure { get; set; }


        [Display(Name = "Applicant Previous Position/Role")]
        public string PrevApplicantPosition { get; set; }


        [Display(Name = "Previous Pay Structure")]
        public bool PrevApplicantPayStructure { get; set; }


        [Display(Name = "Previous Monthly Income")]
        public string PrevApplicantMonthlyIncome { get; set; }
        */

        [Required]
        [Display(Name = "Nearest Relative Name")]
        public string NearestRelativeName { get; set; }
        
        [Required]
        [Display(Name = ("Street Address"))]
        public string NearestRelativeStreetAddress { get; set; }

        [Required]
        [Display(Name = "City")]
        public string NearestRelativeCity { get; set; }

        [Required]
        [Display(Name = "State")]
        public string NearestRelativeState { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(5)]
        [Display(Name = "Zip Code")]
        public string NearestRelativeZipCode { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Nearest Relative Phone Number")]
        public string NearestRelativePhone { get; set; }

        [Required]
        [Display(Name = "Nearest Relative Relation to Applicant")]
        public string NearestRelativeRelation{ get; set; }

       /* private Loan[] listOfLoans;

        insert partner key */

        
        public int? ExpenseSheetId { get; set; }

        [ForeignKey("ExpenseSheetId")]
        public virtual ExpenseReport ExpenseReport { get; set; }

        /*
        public Loan[] GetListOfLoans()
        {
            return listOfLoans;
        }


        public void SetListOfLoans(Loan[] value)
        {
            listOfLoans = value;
        }*/
    }
}
