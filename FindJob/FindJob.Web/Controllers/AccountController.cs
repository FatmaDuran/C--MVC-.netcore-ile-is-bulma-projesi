using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindJob.Business.Abstract;
using FindJob.DataAccess.Concrete.EntityFramework;
using FindJob.Entities;
using FindJob.Entities.Concrete;
using FindJob.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace FindJob.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        //user manager?

        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {

            //   //_userService.get.Users.Where(x => x.Username == user.Username && x.Password == user.Password);
            User user = null;
            user = _userService.Get(x => x.Username == model.Username && x.Password == model.Password);


            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }
            HttpContext.Session.SetString("UserId", user.Id.ToString());
            switch (user.UserType)
            {
                case Entities.Concrete.Enumeration.UserTypes.Admin://admin ise index e Yönlendiriyor
                    return RedirectToAction("Index", "Admin");

                case Entities.Concrete.Enumeration.UserTypes.Aplicant:
                    return RedirectToAction("Index", "Applicant");

                case Entities.Concrete.Enumeration.UserTypes.Employer:
                    return RedirectToAction("Index", "Employer"); ;

                default:
                    return RedirectToAction("Login", "Account");
            }

        }


    }
}
