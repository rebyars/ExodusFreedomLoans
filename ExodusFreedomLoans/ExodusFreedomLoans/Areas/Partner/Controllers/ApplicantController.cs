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
            Applicant applicant = new Applicant();
            if (id == null)
            {
                return View(applicant);
            }
            applicant = _unitOfWork.Applicant.Get(id.GetValueOrDefault());
            if (applicant == null)
            {
                return NotFound();
            }
            return View(applicant);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                if(applicant.ApplicantKey == 0)
                {
                    _unitOfWork.Applicant.Add(applicant);
                }
                else
                {
                    _unitOfWork.Applicant.Update(applicant);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(applicant);
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