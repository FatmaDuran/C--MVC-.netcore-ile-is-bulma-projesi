using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FindJob.Business.Abstract;
using FindJob.Web.Models;

namespace FindJob.Web.Controllers
{
    public class AdvertisementController : Controller
    {
        private IAdvertisementService _advertisementService;
        private ISectorService _sectorService;
        private ICityService _cityService;
        private IJobService _jobService;
        private IGenderService _genderService;
        private ICompanyService _companyService;
        private IEducationService _educationService;
        private ILevelService _levelService;
        private IWorkingTimeService _workingTimeService;

        public AdvertisementController(IAdvertisementService advertisementService,
                                       ISectorService sectorService,
                                       ICityService cityService,
                                       IJobService jobService,
                                       IGenderService genderService,
                                       ICompanyService companyService,
                                       IEducationService educationService,
                                       ILevelService levelService,
                                       IWorkingTimeService workingTimeService)
        {
            _sectorService = sectorService;
            _advertisementService = advertisementService;
            _cityService = cityService;
            _jobService = jobService;
            _genderService = genderService;
            _companyService = companyService;
            _educationService = educationService;
            _levelService = levelService;
            _workingTimeService = workingTimeService;

        }


        public IActionResult Index()
        {
            var advertisements = _advertisementService.GetAll("City", "Company");
            AdvertisementListViewModel model = new AdvertisementListViewModel
            {
                Advertisements = advertisements
            };
            return View(model);
        }
        public IActionResult ViewDetail(int AdvertisementId)
        {
            var advertisement = _advertisementService.GetById(AdvertisementId);
            //  var advertisements = _advertisementService.GetAll("Company", "Sector", "Job", "Education", "Gender", "Level", "WorkingTime");
            AdvertisementViewModel model = new AdvertisementViewModel
            {
                Advertisement = advertisement
            };
            return View(model);
        }
        //public IActionResult ViewDetail()
        //{
        //    var advertisements = _advertisementService.GetAll("Company", "Sector", "Job", "Education", "Gender", "Level", "WorkingTime");
        //    AdvertisementListViewModel model = new AdvertisementListViewModel
        //    {
        //        Advertisements = advertisements
        //    };
        //    return View(model);
        //}

        //İLANLARI SEÇİLEN SEKTÖRE GÖRE LİSTELER
        public IActionResult FilterBySector(int sector)
        {
              var advertisement = _advertisementService.GetsBySector(sector);

            AdvertisementListViewModel model = new AdvertisementListViewModel
            {
                Advertisements = advertisement
            };
            return View(model);
        }
        //İLANLARI SEÇİLEN ŞEHİRE GÖRE LİSTELER
        public IActionResult FilterByCity(int city)
        {
            var advertisemennt = _advertisementService.GetsByCity(city);

            AdvertisementListViewModel model = new AdvertisementListViewModel
            {
                Advertisements = advertisemennt
            };
            return View(model);
        }

        public IActionResult FilterByCompany(int company)
        {
            var advertisemennt = _advertisementService.GetsByCompany(company);

            AdvertisementListViewModel model = new AdvertisementListViewModel
            {
                Advertisements = advertisemennt
            };
            return View(model);
        }

        public IActionResult FilterByEducation(int education)
        {
            var advertisemennt = _advertisementService.GetsByEducation(education);

            AdvertisementListViewModel model = new AdvertisementListViewModel
            {
                Advertisements = advertisemennt
            };
            return View(model);
        }
        public IActionResult FilterByGender(int gender)
        {
            var advertisemennt = _advertisementService.GetsByGender(gender);

            AdvertisementListViewModel model = new AdvertisementListViewModel
            {
                Advertisements = advertisemennt
            };
            return View(model);
        }
        public IActionResult FilterByJob(int job)
        {
            var advertisemennt = _advertisementService.GetsByJob(job);

            AdvertisementListViewModel model = new AdvertisementListViewModel
            {
                Advertisements = advertisemennt
            };
            return View(model);
        }
        public IActionResult FilterByLevel(int level)
        {
            var advertisemennt = _advertisementService.GetsByLevel(level);

            AdvertisementListViewModel model = new AdvertisementListViewModel
            {
                Advertisements = advertisemennt
            };
            return View(model);
        }
        public IActionResult FilterByWorkingTime(int workingTime)
        {
            var advertisemennt = _advertisementService.GetsByWorkingTime(workingTime);

            AdvertisementListViewModel model = new AdvertisementListViewModel
            {
                Advertisements = advertisemennt
            };
            return View(model);
        }






        //Listeleme İŞlemleri
        public IActionResult ListSector()
        {
            var sectors = _sectorService.GetAll();
            SectorListViewModel model = new SectorListViewModel
            {
                Sectors = sectors
            };
            return View(model);

        }
        public IActionResult ListCity()
        {
            var cities = _cityService.GetAll();
            CityListViewModel model = new CityListViewModel
            {
                Cities = cities
            };
            return View(model);


        }
        public IActionResult ListJob()
        {
            var jobs = _jobService.GetAll();
            JobListViewModel model = new JobListViewModel
            {
                Jobs = jobs

            };
            return View(model);
        }
        public IActionResult ListGender()
        {
            var genders = _genderService.GetAll();
            GenderListViewModel model = new GenderListViewModel
            {
                Genders = genders
            };
            return View(model);
        }
        public IActionResult ListCompany()
        {
            var companies = _companyService.GetAll();
            CompanyListViewModel model = new CompanyListViewModel
            {
                Companies = companies
            };
            return View(model);
        }
        public IActionResult ListEducation()
        {
            var educations = _educationService.GetAll();
            EducationListViewModel model = new EducationListViewModel
            {
                Educations = educations
            };
            return View(model);

            //level
            //workingTime

        }
        public IActionResult ListLevel()
        {
            var levels = _levelService.GetAll();
            LevelListViewModel model = new LevelListViewModel
            {
                Levels = levels
            };
            return View(model);
        }
        public IActionResult ListWorkingTime()
        {
            var workingTimes = _workingTimeService.GetAll();
            WorkingTimeListViewModel model = new WorkingTimeListViewModel
            {
                WorkingTimes = workingTimes
            };
            return View(model);
        }

       
    }
}