﻿using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Core.DataAccess;
using FindJob.Entities.Concrete;

namespace FindJob.DataAccess.Abstract
{
   public interface IGenderDal:IEntityRepository<Gender>
    {
    }
}
