using System;
using System.Collections.Generic;
using System.Text;
using FindJob.DataAccess.Abstract;
using FindJob.Business.Abstract;
using FindJob.Entities.Concrete;

namespace FindJob.Business.Concrete
{
   public class JobManager:IJobService
    {
        private IJobDal _jobDal;

        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }
        public void Add(Job job)
        {
            _jobDal.Add(job);
        }

        public void Delete(int jobId)
        {
           
            _jobDal.Delete(new Job { Id = jobId });
        }

        public List<Job> GetAll()
        {
            return _jobDal.GetList();
        }

        public void Update(Job job)
        {
            _jobDal.Update(job);
        }
    }
}
