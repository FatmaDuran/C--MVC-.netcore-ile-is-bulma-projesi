using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Entities.Concrete;
using FindJob.DataAccess.Abstract;
using FindJob.Core.DataAccess.EntityFramework;

namespace FindJob.DataAccess.Concrete.EntityFramework
{
   public class EfEducationDal : EfEntityRepositoryBase<Education, DataContext>, IEducationDal
    {

    }
}
