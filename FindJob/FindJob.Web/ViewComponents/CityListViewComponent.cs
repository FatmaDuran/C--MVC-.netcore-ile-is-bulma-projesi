using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  Microsoft.AspNetCore.Mvc;
using FindJob.Business.Abstract;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using FindJob.Web.Models;

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
