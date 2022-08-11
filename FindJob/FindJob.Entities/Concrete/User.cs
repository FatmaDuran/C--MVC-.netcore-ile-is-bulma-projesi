using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Entities.Concrete.Enumeration;
using FindJob.Core.Entities;

namespace FindJob.Entities.Concrete
{
   public class User:IEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public UserTypes UserType { get; set; }

        public virtual Employer Employer { get; set; }
        public virtual Applicant Applicant { get; set; }
        public virtual Admin Admin { get; set; }
    }
}
