using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Business.Abstract;
using FindJob.Entities.Concrete;
using FindJob.DataAccess.Abstract;


namespace FindJob.Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public void Add(Company company)
        {
            _companyDal.Add(company);
        }

        public void Delete(int companyId)
        {
            _companyDal.Delete(new Company { Id = companyId });
        }

        public List<Company> GetAll()
        {
           return _companyDal.GetList();
        }

        public void Update(Company company)
        {
            _companyDal.Update(company);
        }
    }
}
