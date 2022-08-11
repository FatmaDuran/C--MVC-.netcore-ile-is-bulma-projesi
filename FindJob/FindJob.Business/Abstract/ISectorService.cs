using FindJob.Entities.Concrete;
using System.Collections.Generic;

namespace FindJob.Business.Abstract
{
    public interface ISectorService
    {
        List<Sector> GetAll();
        void Add(Sector sector);
        void Update(Sector sector);
        void Delete(int sectorId);
    }
}
