using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using FindJob.Business.Abstract;
using FindJob.Entities.Concrete;
using FindJob.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace FindJob.Web.ViewComponents
{
    public class GenderListViewComponent : ViewComponent
    {
        private IGenderService _genderService;
        public GenderListViewComponent(IGenderService genderService)
        {
            _genderService = genderService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new GenderListViewModel
            {
                Genders = _genderService.GetAll()
            };
            return View(model);
        }
    }

}
