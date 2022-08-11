using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Business.Abstract;
using FindJob.Entities.Concrete;
using FindJob.DataAccess.Abstract;

namespace FindJob.Business.Concrete
{
    public class EducationManager : IEducationService
    {
        private IEducationDal _educationDal;
        public EducationManager (IEducationDal education)
        {
            _educationDal = education;
        }

        public void Add(Education education)
        {
            _educationDal.Add(education);
        }

        public void Delete(int educationId)
        {
            _educationDal.Delete(new Education { Id = educationId });
        }

        public List<Education> GetAll()
        {
            return _educationDal.GetList();
        }

        public void Update(Education education)
        {
            _educationDal.Update(education);        }
    }
}
