using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Core.DataAccess.EntityFramework;
using FindJob.DataAccess.Abstract;
using FindJob.Entities.Concrete;


namespace FindJob.DataAccess.Concrete.EntityFramework
{
   public class EfWorkingTimeDal:EfEntityRepositoryBase<WorkingTime,DataContext>,IWorkingTimeDal
    {

    }
}
