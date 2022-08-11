using FindJob.Core.Entities;
using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Text;

namespace FindJob.Core.DataAccess
{                                        //generic kısıtlamaları
  public interface IEntityRepository <T> where T:class, IEntity ,new()
    {

        T Get(Expression<Func<T, bool>> filter=null); //parametre geçmeyebilir kullanıcı o zaman default deger, deger girmezse ona göre bir çalışma gerçekleştirilir.
        T Get(Expression<Func<T, bool>> filter = null, params string[] includes);
        List<T> GetList(Expression<Func<T, bool>> filter=null); //expressiona uygun olan mesela müşterileri(başvuranları getir) ama hiçbir şey yazmazsam tümünü getir.
        List<T> GetList(Expression<Func<T, bool>> filter=null, params string[] includes);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
   }
}
