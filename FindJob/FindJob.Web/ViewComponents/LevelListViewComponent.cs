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
    public class LevelListViewComponent:ViewComponent
    {
        private ILevelService _levelService;

        public LevelListViewComponent(ILevelService levelService)
        {
            _levelService = levelService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new LevelListViewModel
            {
                Levels = _levelService.GetAll()
            };
            return View(model);
        }
    }
}
