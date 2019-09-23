using Solution.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Solution.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        T Get(Expression<Func<T,bool>>filter=null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        int Add(T entity);
        int Update(T entity);

        int Delete(T entity);

    }
}
