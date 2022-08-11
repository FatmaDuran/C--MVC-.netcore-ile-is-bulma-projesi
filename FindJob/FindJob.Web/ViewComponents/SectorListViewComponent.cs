using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindJob.Business.Abstract;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using FindJob.Web.Models;
using Microsoft.AspNetCore.Mvc;
using FindJob.Entities.Concrete;

namespace FindJob.Web.ViewComponents
{
    public class SectorListViewComponent : ViewComponent
    {
        ISectorService _sectorService;
        public SectorListViewComponent(ISectorService sectorService)
        {
            _sectorService = sectorService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new SectorListViewModel
            {
                Sectors = _sectorService.GetAll()
            };
            return View(model);
        }

    }
}
