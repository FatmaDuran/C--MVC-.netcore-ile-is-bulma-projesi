using FindJob.Entities.Concrete;
using FindJob.Entities.Concrete.Enumeration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindJob.DataAccess.Concrete.EntityFramework
{
    public class DataContext:DbContext

    {
        public DataContext ()
        {
        
        }

        public DbSet<User> Users;
        public DbSet<Applicant> Applicants;
        public DbSet<Employer> Employers;
        public DbSet<Admin> Admins;
  
        public DbSet<Sector> Sectors;
        public DbSet<Education> Educations;
        public DbSet<Level> Levels;
        public DbSet<WorkingTime> WorkingTimes;
        public DbSet<Gender> Genders;
        public DbSet<City> Cities;
        public DbSet<Company> Companies;
        public DbSet<Advertisement> Advertisements;
        public DbSet<Job> Jobs;

        public DbSet<AdvertisementApplicant> AdvertisementApplicants;


      public DataContext(DbContextOptions options) : base(options)
        {

        }
  //public virtual DbContextOptionsBuilder EnableSensitiveDataLogging(bool sensitiveDataLoggingEnabled = true);???????????????
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\\MSSQLLocalDB;Database=JobApp2;Trusted_Connection=True;MultipleActiveResultSets=true");
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-N2J8RQU;Initial Catalog=FindJobDb;Integrated Security=True;");
       
         }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>()
                .Property(p => p.UserType)
                .IsRequired()
                .HasDefaultValueSql("0")
                .HasDefaultValue(UserTypes.NotSet);

            modelBuilder.Entity<Employer>().ToTable("Employers");
            modelBuilder.Entity<Applicant>().ToTable("Applicants");
            modelBuilder.Entity<Admin>().ToTable("Admins");
         
            modelBuilder.Entity<Sector>().ToTable("Sectors");
            modelBuilder.Entity<Education>().ToTable("Educations");
            modelBuilder.Entity<Level>().ToTable("Levels");
            modelBuilder.Entity<WorkingTime>().ToTable("WorkingTimes");
            modelBuilder.Entity<Gender>().ToTable("Genders");
            modelBuilder.Entity<City>().ToTable("Cities");
            modelBuilder.Entity<Advertisement>().ToTable("Advertisements");
            modelBuilder.Entity<Company>().ToTable("Companies");
            modelBuilder.Entity<Job>().ToTable("Jobs");
            modelBuilder.Entity<AdvertisementApplicant>().ToTable("AdvertisementApplicants");


            modelBuilder.Entity<Employer>().HasOne(x => x.User).WithOne(y => y.Employer).HasForeignKey<Employer>(k => k.UserId);
            modelBuilder.Entity<Applicant>().HasOne(x => x.User).WithOne(y => y.Applicant).HasForeignKey<Applicant>(k => k.UserId);
            modelBuilder.Entity<Admin>().HasOne(x => x.User).WithOne(y => y.Admin).HasForeignKey<Admin>(k => k.UserId);

            modelBuilder.Entity<Company>().HasOne(x => x.City).WithMany(y => y.Companies).HasForeignKey(k => k.CityId).OnDelete(DeleteBehavior.Restrict);//ondelete...->şehir silince firmanın gitmemesi için

            modelBuilder.Entity<Advertisement>().HasOne(x => x.Sector).WithMany(y => y.Advertisements).HasForeignKey(k => k.SectorId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Advertisement>().HasOne(x => x.Education).WithMany(y => y.Advertisements).HasForeignKey(k => k.EducationId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Advertisement>().HasOne(x => x.Level).WithMany(y => y.Advertisements).HasForeignKey(k => k.LevelId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Advertisement>().HasOne(x => x.WorkingTime).WithMany(y => y.Advertisements).HasForeignKey(k => k.WorkingTimeId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Advertisement>().HasOne(x => x.Gender).WithMany(y => y.Advertisements).HasForeignKey(k => k.GenderId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Advertisement>().HasOne(x => x.City).WithMany(y => y.Advertisements).HasForeignKey(k => k.CityId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Advertisement>().HasOne(x => x.Job).WithMany(y => y.Advertisements).HasForeignKey(k => k.JobId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Advertisement>().HasOne(x => x.Company).WithMany(y => y.Advertisements).HasForeignKey(k => k.CompanyId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Job>().HasOne(x => x.Sector).WithMany(y => y.Jobs).HasForeignKey(k => k.SectorId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Applicant>().HasMany(x=>x.AdvertisementApplicants).WithOne(y=>y.Applicant).HasForeignKey(k=>k.ApplicantId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Advertisement>().HasMany(x=>x.AdvertisementApplicants).WithOne(y=>y.Advertisement).HasForeignKey(k => k.AdvertisementId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employer>().HasOne(x => x.Company).WithMany(y => y.Employers).HasForeignKey(k => k.CompanyId).OnDelete(DeleteBehavior.Restrict);

            //veri ekliyor

            modelBuilder.Entity<Sector>().HasData(
                new Sector
                {
                    Id = 1,
                    Name = "Eğitim"
                    
                },
                new Sector
                {
                    Id = 2,
                    Name = "Mühendislik"
                }
               );

            modelBuilder.Entity<Job>().HasData(
                new Job
                {
                    Id = 1,
                    Name = "Matematik Öğretmeni",
                    SectorId = 1
                },
                new Job
                {
                    Id = 2,
                    Name = "İnşaat Mühendisi",
                    SectorId = 2
                },
                new Job
                {
                    Id = 3,
                    Name = "Türkçe Öğretmeni",
                    SectorId = 1
                });

            modelBuilder.Entity<City>().HasData(
                new City
                {
                    Id = 1,
                    Name = "Ankara"
                },
                new City
                {
                    Id = 2,
                    Name="Konya"
                },
                new City
                {
                    Id = 3,
                    Name = "Kayseri"
                }) ;

            modelBuilder.Entity<Education>().HasData(
                new Education
                {
                    Id=1,
                    Name="İlkokul"
                },
                new Education
                {
                    Id=2,
                    Name="Ortaokul"
                },
                new Education
                {
                    Id=3,
                    Name= "Lise"
                },
                  new Education
                  {
                      Id = 4,
                      Name = "Üniversite"
                  }
                );
            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Arven İnşaat",
                    CityId = 3
                },
                new Company
                {
                    Id = 2,
                    Name = "İngiliz Kültür Koleji",
                    CityId = 1
                },
                new Company
                {
                    Id = 3,
                    Name = "Doğa Koleji",
                    CityId=2
                }  );

            modelBuilder.Entity<Gender>().HasData(
                new Gender
                {
                    Id = 1,
                    Name = "Farketmez"
                },
                new Gender
                {
                    Id = 2,
                    Name = "Kadın"
                },
                new Gender
                {
                    Id = 3,
                    Name = "Erkek"
                });

            modelBuilder.Entity<WorkingTime>().HasData(
                new WorkingTime
                {
                    Id =1,
                    Name = "Tam Zamanlı"
                },
                new WorkingTime
                {
                    Id =2,
                    Name = "Part Time"
                },
                new WorkingTime
                {
                    Id =3,
                    Name = "Stajyer"
                });

            modelBuilder.Entity<Level>().HasData(
                new Level
                {
                    Id = 1,
                    Name = "Eleman"
                });

            modelBuilder.Entity<Advertisement>().HasData(
                new Advertisement
                {
                    Id = 1,
                    Name = "Okula Öğretmen ",
                    JobId=2,
                    SectorId=1,
                    GenderId=1,
                    CompanyId=3,
                    CityId=2,
                    WorkingTimeId=1,
                    EducationId=4,
                    LevelId=1

                },
                new Advertisement
                {
                    Id = 2,
                    Name = "Mühendis ",
                    JobId = 1,
                    SectorId = 2,
                    GenderId = 1,
                    CompanyId = 1,
                    CityId = 3,
                    WorkingTimeId = 1,
                    EducationId = 4,
                    LevelId = 1

                }

                );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    UserType = UserTypes.Admin,
                    Password = "1",
                    EMail = "admin@findingjob.com",
                    Username = "admin"

                },
                new User
                {
                    Id = 2,
                    UserType = UserTypes.Employer,
                    Password = "2",
                    EMail = "employer@findingjob.com",
                    Username = "employer"
                },
                new User
                {
                    Id = 3,
                    UserType = UserTypes.Aplicant,
                    Password = "3",
                    EMail = "applicant@findingjob.com",
                    Username = "applicant"
                }
                );


            modelBuilder.Entity<Admin>().HasData(new Admin { Id = 1, UserId = 1, Name = "Admin Bey" });
            modelBuilder.Entity<Employer>().HasData(new Employer { Id = 1, UserId = 2, Name = "Başvuran", Email = "employer@findingjob.com", PhoneNumber = "901234567896" ,CompanyId=1});
            modelBuilder.Entity<Applicant>().HasData(new Applicant { Id = 1, UserId = 3, Name = "İşveren", Surname = "İşverenoğulları" });
         
        }

    }
    }

