using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Business.Abstract;
using FindJob.Entities.Concrete;
using FindJob.DataAccess.Abstract;

namespace FindJob.Business.Concrete
{
    public class WorkingTimeManager : IWorkingTimeService
    {
        private IWorkingTimeDal _workingTimeDal;

        public WorkingTimeManager(IWorkingTimeDal workingTimeDal)
        {
            _workingTimeDal = workingTimeDal;
        }

        public void Add(WorkingTime workingTime)
        {
            _workingTimeDal.Add(workingTime);
        }

        public void Delete(int workingTimeId)
        {
            _workingTimeDal.Delete(new WorkingTime { Id = workingTimeId });
        }

        public List<WorkingTime> GetAll()
        {
            return _workingTimeDal.GetList();
        }

        public void Update(WorkingTime workingTime)
        {
            _workingTimeDal.Update(workingTime);
        }
    }
}
