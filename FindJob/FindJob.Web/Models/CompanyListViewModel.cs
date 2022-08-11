using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindJob.Entities.Concrete;

namespace FindJob.Web.Models
{
    public class CompanyListViewModel
    {
        public List<Company> Companies { get; internal set; }
    }
}
