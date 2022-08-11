using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using FindJob.Entities.Concrete;

namespace FindJob.Business.Abstract
{
  public  interface IApplicantService
    {
        List<Applicant> GetAll();
        List<Applicant> GetAll(params string[] includes);
        Applicant Get(Expression<Func<Applicant,bool>> filter);
        void Add(Applicant applicant);
        void Update(Applicant applicant);
        void Delete(int applicantId);

    }
}
