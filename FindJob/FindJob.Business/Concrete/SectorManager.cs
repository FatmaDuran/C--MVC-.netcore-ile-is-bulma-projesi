using FindJob.Business.Abstract;
using FindJob.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using FindJob.DataAccess.Abstract;



namespace FindJob.Business.Concrete
{
    public class SectorManager : ISectorService
    {
        private ISectorDal _sectorDal;

        public SectorManager(ISectorDal sectorDal)
        {
            _sectorDal = sectorDal;
        }
        //constructor
        public void Add(Sector sector)
        {
            _sectorDal.Add(sector);
        }

        public void Delete(int sectorId)
        {
            _sectorDal.Delete(new Sector {Id = sectorId });
        }

        public List<Sector> GetAll()
        {
            return _sectorDal.GetList();
        }

        public void Update(Sector sector)
        {
            _sectorDal.Update(sector);
        }
    }
}
