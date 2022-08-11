using FindJob.Business.Abstract;
using FindJob.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindJob.Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace FindJob.Web.Controllers
{
   
    public class ApplicantController : Controller
    {
        private IUserService _userService;
        private IApplicantService _applicantService;

        public ApplicantController(IUserService userService, IApplicantService applicantService)
        {
            _userService = userService;
            _applicantService = applicantService;
        }

        public IActionResult Index()
        {
            ViewBag.UserId = HttpContext.Session.GetString("UserId");
            return View();
        }

        public async Task<IActionResult> Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register (RegisterViewModel model)
        {
         

            if (model!=null)
            {
              
                _userService.Add(new User {

                    Password = model.Password,
                    Username = model.Username,
                    UserType = Entities.Concrete.Enumeration.UserTypes.Aplicant,
                    EMail = model.EMail
                });

                 var user = _userService.Get(x => x.Username == model.Username );
                 
               _applicantService.Add(new Applicant
                {
                    Name = model.Name,
                    Surname = model.Surname,
                    BirthDate = model.BirthDate,
                    UserId = user.Id

                });
            }
          
            return RedirectToAction("Index");
         
     }

        //public IActionResult ViewDetail(int AdvertisementId)
        //{
        //    var advertisement = _advertisementService.GetById(AdvertisementId);
        //    //  var advertisements = _advertisementService.GetAll("Company", "Sector", "Job", "Education", "Gender", "Level", "WorkingTime");
        //    AdvertisementViewModel model = new AdvertisementViewModel
        //    {
        //        Advertisement = advertisement
        //    };
        //    return View(model);
        //
    }
}