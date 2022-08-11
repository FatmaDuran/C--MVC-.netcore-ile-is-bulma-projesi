using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Business.Abstract;
using FindJob.Entities.Concrete;
using FindJob.DataAccess.Abstract;

namespace FindJob.Business.Concrete
{
    public class GenderManager : IGenderService
    {
        private IGenderDal _genderDal;

        public GenderManager(IGenderDal genderDal)
        {
            _genderDal = genderDal;
        }

        public void Add(Gender gender)
        {
            _genderDal.Add(gender);
        }

        public void Delete(int genderId)
        {
            _genderDal.Delete(new Gender { Id = genderId });
        }

        public List<Gender> GetAll()
        {
            return _genderDal.GetList();
        }

        public void Update(Gender gender)
        {
            _genderDal.Update(gender);
        }
    }
}
