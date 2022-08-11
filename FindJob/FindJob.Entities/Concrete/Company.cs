
using FindJob.Core.Entities;
using System.Collections.Generic;

namespace FindJob.Entities.Concrete
{
    public class Company:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }

        //public ICollection<Post> Posts { get; set; }
        public City City { get; set; }
        public ICollection<Advertisement> Advertisements { get; set; }
        public ICollection<Employer> Employers { get; set; }
    }
}
