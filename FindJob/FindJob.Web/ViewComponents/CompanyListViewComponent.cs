using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindJob.Business.Abstract;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using FindJob.Web.Models;

namespace FindJob.Web.ViewComponents
{
    public class CompanyListViewComponent:ViewComponent
    {
        private ICompanyService _companyService;

        public CompanyListViewComponent(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new CompanyListViewModel
            {
                Companies=_companyService.GetAll()
            };
            return View(model);
           
        }

    }
}
