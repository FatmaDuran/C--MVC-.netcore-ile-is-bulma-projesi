using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Core.Entities;


namespace FindJob.Entities.Concrete
{
    public class AdvertisementApplicant: IEntity
    {
        public int Id { get; set; }
        public int AdvertisementId { get; set; }
        public int ApplicantId { get; set; }

        public Advertisement Advertisement { get; set; }
        public Applicant Applicant { get; set; }
    }
}
