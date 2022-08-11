using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Entities.Concrete;

namespace FindJob.Business.Abstract
{
  public  interface IAdvertisementService
    {
        List<Advertisement> GetAll();
        List<Advertisement> GetAll(params string[] includes);
      

        void Add(Advertisement advertisement);
        void Update(Advertisement advertisement);
        void Delete(int advertisementId);


        Advertisement GetById(int AdvertisementId);//bir tane döndereceği için list olmaz
        List<Advertisement> GetsBySector(int SectorId);//birden fazla döndereceği için list, gets olur
        List<Advertisement> GetsByCity(int CityId);
        List<Advertisement> GetsByCompany(int CompanyId);
        List<Advertisement> GetsByEducation(int EducationId);
        List<Advertisement> GetsByGender(int GenderId);
        List<Advertisement> GetsByJob(int JobId);
        List<Advertisement> GetsByLevel(int LevelId);
        List<Advertisement> GetsByWorkingTime(int WorkingTimeId);



    }
}
