using System;
using System.Collections.Generic;
using System.Text;
using FindJob.DataAccess.Abstract;
using FindJob.Business.Abstract;
using FindJob.Entities.Concrete;

namespace FindJob.Business.Concrete
{
    public class CityManager : ICityService
    {
        private ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public void Add(City city)
        {
            _cityDal.Add(city);
        }

        public void Delete(int cityId)
        {
            _cityDal.Delete(new City { Id = cityId });
        }

        public List<City> GetAll()
        {
            return _cityDal.GetList();
        }

        public void Update(City city)
        {
            _cityDal.Update(city);
        }
    }
}
