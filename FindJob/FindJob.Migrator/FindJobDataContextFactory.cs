using System;
using System.Collections.Generic;
using System.Text;
using FindJob.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using FindJob.Entities;
using FindJob.DataAccess.Concrete.EntityFramework;


namespace FindJob.Migrator
{
    class FindJobDataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            //optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=JobApp2;Trusted_Connection=True;MultipleActiveResultSets=true",
            //    x => x.MigrationsAssembly("FindJob.Migrator"));
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-N2J8RQU;Initial Catalog=FindJobDb;Integrated Security=True;",

                x => x.MigrationsAssembly("FindJob.Migrator"));

            return new DataContext(optionsBuilder.Options);
        }

    }
}
