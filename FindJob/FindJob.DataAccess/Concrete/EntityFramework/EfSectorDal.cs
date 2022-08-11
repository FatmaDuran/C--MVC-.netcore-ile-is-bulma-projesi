using FindJob.Core.DataAccess.EntityFramework;
using FindJob.DataAccess.Abstract;
using FindJob.Entities.Concrete;


namespace FindJob.DataAccess.Concrete.EntityFramework
{
    public class EfSectorDal : EfEntityRepositoryBase<Sector, DataContext>, ISectorDal
    {

    }
}
