using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindJob.Entities.Concrete;

namespace FindJob.Web.Models
{
    public class AdvertisementListViewModel
    {
        public List<Advertisement> Advertisements { get; internal set; }
    }
}
