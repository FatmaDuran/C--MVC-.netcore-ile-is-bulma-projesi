using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Entities.Concrete;

namespace FindJob.Business.Abstract
{
    public interface IGenderService
    {
        List<Gender> GetAll();
        void Add(Gender gender);
        void Update(Gender gender);
        void Delete(int genderId);
    }
}
