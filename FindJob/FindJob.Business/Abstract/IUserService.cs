using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using FindJob.Entities.Concrete;
using FindJob.Entities.Concrete.Enumeration;
namespace FindJob.Business.Abstract
{
   public interface IUserService
    {
        List<User> GetAll();
        List<User> GetAll(params string[] includes);

         User Get(Expression<Func<User, bool>> filter);

        void Add(User user);
        void Update(User user);
        void Delete(int userId);
    }
}
