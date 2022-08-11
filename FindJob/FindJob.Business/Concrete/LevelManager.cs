using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Business.Abstract;
using FindJob.Entities.Concrete;
using FindJob.DataAccess.Abstract;

namespace FindJob.Business.Concrete
{
    public class LevelManager : ILevelService
    {
        private ILevelDal _levelDal;

        public LevelManager(ILevelDal levelDal)
        {
            _levelDal = levelDal;
        }

        public void Add(Level level)
        {
            _levelDal.Add(level);
        }

        public void Delete(int levelId)
        {
            _levelDal.Delete(new Level { Id = levelId });
        }

        public List<Level> GetAll()
        {
            return _levelDal.GetList();
        }

        public void Update(Level level)
        {
            _levelDal.Update(level);
        }
    }
}
