using System;
using System.Collections.Generic;
using System.Text;

using FindJob.Core.Entities;

namespace FindJob.Entities.Concrete
{
   public class Advertisement: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int SectorId { get; set; }
        public int EducationId { get; set; }
        public int LevelId { get; set; }
        public int WorkingTimeId { get; set; }
        public int GenderId { get; set; }
        public int CityId { get; set; }
        public int CompanyId { get; set; }
        public int JobId { get; set; }

      
       
        public  Sector Sector { get; set; }
        public  Education Education { get; set; }
        public  Level Level { get; set; }
        public  WorkingTime WorkingTime { get; set; }
        public  Gender Gender { get; set; }
        public  City City { get; set; }
        public  Company Company { get; set; }
        public Job Job { get; set; }
      
        public ICollection<AdvertisementApplicant> AdvertisementApplicants { get; set; }
    }
}
