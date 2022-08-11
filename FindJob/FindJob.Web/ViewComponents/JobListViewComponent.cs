using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FindJob.Business.Abstract;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using FindJob.Web.Models;

namespace FindJob.Web.ViewComponents
{
    public class JobListViewComponent : ViewComponent
    {
        IJobService _jobService;

        public JobListViewComponent(IJobService jobService)
        {
            _jobService = jobService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new JobListViewModel
            {
                Jobs = _jobService.GetAll()
            };
            return View(model);
        }
    

        
    }
}
