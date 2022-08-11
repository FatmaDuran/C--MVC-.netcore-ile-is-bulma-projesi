using FindJob.Business.Abstract;
using FindJob.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using FindJob.DataAccess.Abstract;
using FindJob.DataAccess.Concrete.EntityFramework;

namespace FindJob.Business.Concrete
{
    public class ApplicantManager : IApplicantService
    {
        private IApplicantDal _applicantDal;

        public ApplicantManager(IApplicantDal applicantDal)
        {
            _applicantDal = applicantDal;
        }

        public void Add(Applicant applicant)
        {
            _applicantDal.Add(applicant);
        }

        public void Delete(int applicantId)
        {
            _applicantDal.Delete(new Applicant { Id = applicantId });
        }
        public void Update(Applicant applicant)
        {
            _applicantDal.Update(applicant);
        }
        public Applicant Get(Expression<Func<Applicant, bool>> filter)
        {
            return _applicantDal.Get(filter);
        }

        public List<Applicant> GetAll()
        {
            return _applicantDal.GetList();
        }

        public List<Applicant> GetAll(params string[] includes)
        {
            return _applicantDal.GetList(includes: includes);
        }

        
    }
}
