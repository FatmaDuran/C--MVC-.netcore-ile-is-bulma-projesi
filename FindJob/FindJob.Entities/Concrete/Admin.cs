using System;
using System.Collections.Generic;
using System.Text;

using FindJob.Core.Entities;

namespace FindJob.Entities.Concrete
{
   public class Admin:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public string Name { get; set; }

        public virtual User User { get; set; }
    }
}
