using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExodusFreedomLoans.DataAccess.Data.Repository.IRepository;
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

        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _unitOfWork.Applicant.GetAll() });
        }

        #endregion 
    }
}