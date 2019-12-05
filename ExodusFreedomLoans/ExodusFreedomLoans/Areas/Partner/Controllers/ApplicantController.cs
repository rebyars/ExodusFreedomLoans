using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExodusFreedomLoans.DataAccess.Data.Repository.IRepository;
using ExodusFreedomLoans.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExodusFreedomLoans.Areas.Partner.Controllers
{
    [Area("Partner")]
    public class ApplicantController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApplicantController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            VMApplicant vmApplicant = new VMApplicant
            {
                Applicant = new Applicant(),
                ExpenseReport = new ExpenseReport()
            };

            if (id == null)

            {
                return View(vmApplicant);
            }
            vmApplicant.Applicant = _unitOfWork.Applicant.Get(id.GetValueOrDefault());
            vmApplicant.ExpenseReport = _unitOfWork.ExpenseReport.Get(_unitOfWork.Applicant.Get(id.GetValueOrDefault()).ExpenseSheetId);
            if (vmApplicant.Applicant == null)
            {
                return NotFound();
            }
            return View(vmApplicant);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(VMApplicant vmApplicant)
        {
            if (ModelState.IsValid)
            {
                if(vmApplicant.Applicant.ApplicantKey == 0)
                {
                    _unitOfWork.Applicant.Add(vmApplicant.Applicant);
                    _unitOfWork.ExpenseReport.Add(vmApplicant.ExpenseReport);
                }
                else
                {
                    _unitOfWork.Applicant.Update(vmApplicant.Applicant);
                    _unitOfWork.ExpenseReport.Update(vmApplicant.ExpenseReport);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(vmApplicant);
        }


        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _unitOfWork.Applicant.GetAll() });
        }

        #endregion 
    }
}