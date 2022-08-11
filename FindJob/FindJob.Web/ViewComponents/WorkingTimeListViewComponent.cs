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
    public class WorkingTimeListViewComponent : ViewComponent
    {
        private IWorkingTimeService _workingTimeService;

        public WorkingTimeListViewComponent(IWorkingTimeService workingTimeService)
        {
            _workingTimeService = workingTimeService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new WorkingTimeListViewModel
            {
                WorkingTimes = _workingTimeService.GetAll()
            };
            return View(model);
        }
    }
}