using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Entities.Concrete;

namespace FindJob.Business.Abstract
{
   public interface ILevelService
    {
        List<Level> GetAll();
        void Add(Level level);
        void Update(Level level);
        void Delete(int levelId);
    }
}
