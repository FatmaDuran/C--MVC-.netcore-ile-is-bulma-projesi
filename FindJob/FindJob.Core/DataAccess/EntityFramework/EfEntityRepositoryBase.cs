using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using FindJob.Core.Entities;



namespace FindJob.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
         where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);  //addedEntity nesnesi onu set ediyoruz, benim nesnemle ilgili entry oluştur
                addedEntity.State = EntityState.Added;    //onun eklenecek bir nesne oldugunu yakala,(EntityState.Added)
                context.SaveChanges();             //onun artık eklenecek bir nesne oldugunu biliyorsun sen onu savechange et.
            }
         }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;    //onun silinecek bir nesne, delete edilecek bir nesne oldugunu anliyor ef,(EntityState.Deleted)
                context.SaveChanges();                       // sen onu savechange et.
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter )//filtre null olsun istemiyoruz
        {                                                          //repositoryde kalabilir
            using (var context=new TContext())
            { 
                var query = context.Set<TEntity>().AsQueryable();
                // return context.Set<TEntity>().SingleOrDefault();
                return filter == null
                  ? query.FirstOrDefault()
                  : query.Where(filter).FirstOrDefault();
                //filtreye dikkat ederekten bana TEntity i bu nesneyi bana döndür
            }
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter, params string[] includes)//filtre null olsun istemiyoruz
        {                                                          //repositoryde kalabilir
            using (var context = new TContext())
            {
                //return context.Set<TEntity>().SingleOrDefault();
                //filtreye dikkat ederekten bana TEntity i bu nesneyi bana döndür
                var query = context.Set<TEntity>().AsQueryable();

                if (includes.Any())
                    foreach (var include in includes)
                        query = query.Include(include);
                
                return filter == null
                 ? query.FirstOrDefault()
                 : query.Where(filter).FirstOrDefault();
            }
        }
        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter=null )
        {
            using (var context = new TContext())
            {
                var connectionString = context.Database.GetDbConnection().ConnectionString;
                
                return filter == null                  //filtre var mı ilk buna bakmalıyız
                  ? context.Set<TEntity>().ToList()                    //?-->İSE  , parametre yoksa tümünü döndür
                  : context.Set<TEntity>().Where(filter).ToList();     //: ---> DEĞİLSE, parametre varsa filtreli halini döndür
            }      
        }
        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter,params string[] includes)
        {
            using (var context = new TContext())
            {
                var connectionString = context.Database.GetDbConnection().ConnectionString;

                var query = context.Set<TEntity>().AsQueryable();

                if (includes.Any())
                    foreach (var include in includes)
                        query = query.Include(include);


                return filter == null                  
                  ? query.ToList()                    
                  : query.Where(filter).ToList();   
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);  
                updatedEntity.State = EntityState.Modified;    //onun değiştirlen bir nesne, update edilecek bir nesne oldugunu anliyor ef,(EntityState.Modified)
                context.SaveChanges();             //onun artık eklenecek bir nesne oldugunu biliyorsun sen onu savechange et.
            }
        }
    }
}
