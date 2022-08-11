using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Business.Abstract;
using FindJob.Entities.Concrete;
using FindJob.DataAccess.Abstract;
using System.Linq.Expressions;

namespace FindJob.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Delete(int userId)
        {
            _userDal.Delete(new User { Id=userId});
        }
        public void Update(User user)
        {
            _userDal.Update(user);
        }


        public List<User> GetAll()
        {
            return _userDal.GetList();
        }

        public List<User> GetAll(params string[] includes)
        {
            /*return _advertisementDal.GetList(includes:includes);*/
            return _userDal.GetList(includes: includes);
        }

    
        public User Get(Expression<Func<User, bool>> filter)
        {
            return _userDal.Get(filter);
        }

        /* public Advertisement GetById(int AdvertisementId)
{
    return _advertisementDal.Get(b => b.Id == AdvertisementId || AdvertisementId == 0, "Company", "Sector", "Job", "Education", "Gender", "Level", "WorkingTime");
}*/
    }
}
