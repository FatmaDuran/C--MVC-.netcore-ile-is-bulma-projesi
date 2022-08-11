using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindJob.Business.Abstract;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using FindJob.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace FindJob.Web.ViewComponents
{
    public class EducationListViewComponent : ViewComponent
    {
        IEducationService _educationService;

        public EducationListViewComponent(IEducationService educationService)
        {
            _educationService = educationService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new EducationListViewModel
            {
                Educations=_educationService.GetAll()
            };
            return View(model);
        }
    
    }
}

/*

namespace FindJob.Web.ViewComponents
{
    public class CityListViewComponent:ViewComponent
    {
        ICityService _cityService;

        public CityListViewComponent(ICityService cityService)
        {
            _cityService = cityService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CityListViewModel
            {
                Cities = _cityService.GetAll()

            };
            return View(model);

        }
       
    }
}
*/
