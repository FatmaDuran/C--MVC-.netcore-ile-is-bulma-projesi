using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Entities.Concrete;

namespace FindJob.Business.Abstract
{
    public interface ICompanyService
    {
      
        List<Company> GetAll();
        void Add(Company company);
        void Update(Company company);
        void Delete(int companyId);
        

    }
}
