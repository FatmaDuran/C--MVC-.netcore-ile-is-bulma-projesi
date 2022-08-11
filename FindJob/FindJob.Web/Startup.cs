using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindJob.DataAccess.Concrete.EntityFramework;
using FindJob.DataAccess.Abstract;
using FindJob.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FindJob.Business.Abstract;
using FindJob.Business.Concrete;
using FindJob.Web.MiddleWare;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Mvc;

namespace FindJob.Web
{
    public class Startup
    {


        public IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddScoped < ICategoryService , CategoryManager >();
            //services.AddScoped < ICategoryDal, EfCategoryDal >();

            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserDal, EfUserDal>();

            services.AddScoped<IApplicantService, ApplicantManager>();
            services.AddScoped<IApplicantDal, EfApplicantDal>();

            services.AddScoped<ISectorService,SectorManager>();
            services.AddScoped<ISectorDal,EfSectorDal>();

            services.AddScoped<IGenderService,GenderManager>();
            services.AddScoped<IGenderDal, EfGenderDal>();
          

            services.AddScoped<ICityService,CityManager>();
            services.AddScoped<ICityDal, EfCityDal>();
           
            services.AddScoped<ICompanyService,CompanyManager>();
            services.AddScoped<ICompanyDal, EfCompanyDal>();

            services.AddScoped<IEducationService,EducationManager>();
            services.AddScoped<IEducationDal, EfEducationDal>();

            services.AddScoped<IAdvertisementService,AdvertisementManager>();//arka planda newleme yapıyor bize veriyor
            services.AddScoped<IAdvertisementDal,EfAdvertisementDal>();

            services.AddScoped<ILevelService,LevelManager>();
             services.AddScoped<ILevelDal,EfLevelDal>();

            services.AddScoped<IWorkingTimeService,WorkingTimeManager>();
            services.AddScoped<IWorkingTimeDal,EfWorkingTimeDal>();

            services.AddScoped<IJobService, JobManager>();
            services.AddScoped<IJobDal, EfJobDal>();

            

            services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DataConnection")));
            // services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("TestConnection")));

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            //services.AddDistributedMemoryCache();
            //services.AddSession(options => {
            //    options.IdleTimeout = TimeSpan.FromMinutes(1);//You can set Time   
            //});
            services.AddDistributedMemoryCache(); //sessionu bellekte tutmak için
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSession(options =>
            {
                options.Cookie.Name = ".AdventureWorks.Session";
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.IsEssential = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            

            app.UseStaticFiles();
            app.UseNodeModules(env.ContentRootPath);  //yapılandırıldı middleware dosyasının ApplicationBuilderExtension classında
            app.UseStatusCodePages();           
            app.UseSession(); //session middleware ortakatmanı
            app.UseMvcWithDefaultRoute();
        }
    }
}
