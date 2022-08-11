using System;
using System.Collections.Generic;
using System.Text;

using FindJob.Core.Entities;

namespace FindJob.Entities.Concrete
{
    public class City:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Company> Companies { get; set; }
        public ICollection<Advertisement> Advertisements { get; set; }
    }
}
