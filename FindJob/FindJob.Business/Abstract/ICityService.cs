using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Entities.Concrete;

namespace FindJob.Business.Abstract
{
    public interface ICityService
    {
        List<City> GetAll();
        void Add(City city);
        void Update(City city);
        void Delete(int cityId);
      //  List<City> Get(int cityId);
    }
}
