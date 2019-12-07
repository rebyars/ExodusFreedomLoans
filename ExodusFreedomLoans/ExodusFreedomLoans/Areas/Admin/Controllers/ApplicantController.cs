using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExodusFreedomLoans.DataAccess.Data.Repository.IRepository;
using ExodusFreedomLoans.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExodusFreedomLoans.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ApplicantController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public ApplicantController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Review(int id)
        {
            VMApplicant vmApplicant = new VMApplicant
            {
                Applicant = new Applicant(),
                ExpenseReport = new ExpenseReport()
            };

            vmApplicant.Applicant = _unitOfWork.Applicant.Get(id);
            vmApplicant.ExpenseReport = _unitOfWork.ExpenseReport.Get(_unitOfWork.Applicant.Get(id).ExpenseSheetId.GetValueOrDefault());

            if(vmApplicant.Applicant == null)
            {
                return NotFound();
            }

            return View(vmApplicant);
        }

        public IActionResult Accept(int id)
        {
            Applicant Applicant = new Applicant();
            Applicant = _unitOfWork.Applicant.Get(id);
            if(Applicant == null)
            {
                return NotFound();
            }
            _unitOfWork.Applicant.Accept(Applicant);
            return RedirectToAction(nameof(Index));
            
        }
        public IActionResult Decline(int id)
        {
            Applicant Applicant = new Applicant();
            Applicant = _unitOfWork.Applicant.Get(id);
            if (Applicant == null)
            {
                return NotFound();
            }
            _unitOfWork.Applicant.Decline(Applicant);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Reopen(int id)
        {
            Applicant Applicant = new Applicant();
            Applicant = _unitOfWork.Applicant.Get(id);
            if (Applicant == null)
            {
                return NotFound();
            }
            _unitOfWork.Applicant.Reopen(Applicant);
            return RedirectToAction(nameof(Index));
        }
    }
}