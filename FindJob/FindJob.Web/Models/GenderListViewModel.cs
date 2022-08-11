using System.Collections.Generic;
using FindJob.Entities.Concrete;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace FindJob.Web.Models
{
    public class GenderListViewModel
    {
        public List<Gender> Genders { get; internal set; }
    }
}
