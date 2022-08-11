using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Entities.Concrete;

namespace FindJob.Business.Abstract
{
   public interface IJobService
    {
   
        List<Job> GetAll();
        void Add(Job job);
        void Update(Job job);
        void Delete(int jobId);


    }
}
