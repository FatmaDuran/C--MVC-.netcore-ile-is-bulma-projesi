using System;
using System.Collections.Generic;
using System.Text;

using FindJob.Core.Entities;

namespace FindJob.Entities.Concrete
{
   public class Job:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SectorId { get; set; }

        public Sector Sector { get; set; }
        public ICollection<Advertisement> Advertisements { get; set; }

    }
}
