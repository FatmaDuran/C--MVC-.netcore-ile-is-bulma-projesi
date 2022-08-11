using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Core.Entities;

namespace FindJob.Entities.Concrete
{
   public class Applicant:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Description { get; set; }

        public virtual User User { get; set; }
        public ICollection<AdvertisementApplicant> AdvertisementApplicants { get; set; }

    }
}
