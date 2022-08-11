using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Entities.Concrete;
using FindJob.Core.DataAccess;

namespace FindJob.DataAccess.Abstract
{
  public  interface IUserDal: IEntityRepository<User>
    {
    }
}
