using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Business.Abstract;
using FindJob.Entities.Concrete;
using FindJob.DataAccess.Abstract;

namespace FindJob.Business.Concrete
{
    public class AdvertisementManager : IAdvertisementService

    {
        private IAdvertisementDal _advertisementDal;
        public AdvertisementManager(IAdvertisementDal advertisementDal)
        {
            _advertisementDal = advertisementDal;
        }
        public void Add(Advertisement advertisement)
        {
            _advertisementDal.Add(advertisement);
        }
        public void Delete(int advertisementId)
        {
            _advertisementDal.Delete(new Advertisement { Id = advertisementId });
        }
        public List<Advertisement> GetAll()
        {
           return _advertisementDal.GetList();
        }
        public List<Advertisement> GetAll(params string[] includes)
        {
            return _advertisementDal.GetList(includes:includes);
        }
        public void Update(Advertisement advertisement)
        {
            _advertisementDal.Update(advertisement);
        }



        //TEK BİR FONKSİYONDA TOPLANACAK MI?

        public List<Advertisement> GetsByCity(int CityId)
        {
                 
            return _advertisementDal.GetList(p => p.CityId == CityId|| CityId==0,"City", "Company");
        }
        public List<Advertisement> GetsBySector(int sectorId)
        {
            return _advertisementDal.GetList(p => p.SectorId == sectorId || sectorId==0,"City","Company");
        }
        public List<Advertisement> GetsByCompany(int CompanyId)
        {
            return _advertisementDal.GetList(a=>a.CompanyId == CompanyId || CompanyId==0, "City", "Company");
        }
        public List<Advertisement> GetsByEducation(int EducationId)
        {
            return _advertisementDal.GetList(k=>k.EducationId==EducationId || EducationId==0, "City", "Company");
        }
        public List<Advertisement> GetsByGender(int GenderId)
        {
            return _advertisementDal.GetList(m=>m.GenderId==GenderId || GenderId==0, "City", "Company");
        }
        public List<Advertisement> GetsByJob(int JobId)
        {
            return _advertisementDal.GetList(k=>k.JobId==JobId || JobId==0, "City", "Company");
        }
        public List<Advertisement> GetsByLevel(int LevelId)
        {
            return _advertisementDal.GetList(n=>n.LevelId==LevelId || LevelId==0, "City", "Company");
        }
        public List<Advertisement> GetsByWorkingTime(int WorkingTimeId)
        {
            return _advertisementDal.GetList(b=>b.WorkingTimeId==WorkingTimeId || WorkingTimeId==0, "City", "Company");
        }
        public Advertisement GetById(int AdvertisementId)
        {
            return _advertisementDal.Get(b => b.Id == AdvertisementId || AdvertisementId == 0, "Company", "Sector", "Job", "Education", "Gender", "Level", "WorkingTime");
        }
    }
}
