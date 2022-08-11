using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Core.Entities;

namespace FindJob.Entities.Concrete
{
   public class Employer:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public virtual User User { get; set; }
     
        public Company Company { get; set; }
      
    }
}
