using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindJob.Entities.Concrete;

namespace FindJob.Web.Models
{
    public class JobListViewModel
    {
        public List<Job> Jobs { get; internal set; }
    }
}
