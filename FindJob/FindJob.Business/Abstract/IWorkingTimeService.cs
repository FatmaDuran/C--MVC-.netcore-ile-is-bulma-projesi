using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Entities.Concrete;

namespace FindJob.Business.Abstract
{
    public interface IWorkingTimeService
    {
        List<WorkingTime> GetAll();
        void Add(WorkingTime workingTime);
        void Update(WorkingTime workingTime);
        void Delete(int workingTimeId);
    }
}
