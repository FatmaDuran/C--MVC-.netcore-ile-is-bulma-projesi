using FindJob.Business.Abstract;
using FindJob.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindJob.Web.ViewComponents
{
    public class AdvertisementListViewComponent : ViewComponent
    {
        IAdvertisementService _advertisementService;
        public AdvertisementListViewComponent(IAdvertisementService advertisementService)
        {
            _advertisementService = advertisementService;
        }
        public ViewViewComponentResult  Invoke()
        {
            var model = new AdvertisementListViewModel
            {
                Advertisements = _advertisementService.GetAll()
            };
            return View(model);
        }
    }
}
