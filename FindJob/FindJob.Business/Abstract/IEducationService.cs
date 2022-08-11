using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Entities.Concrete;

namespace FindJob.Business.Abstract
{
    public interface IEducationService
    {
        List<Education> GetAll();
        void Add(Education education);
        void Update(Education education);
        void Delete(int educationId);
    }
}
