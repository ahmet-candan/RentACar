using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        List<T> GetAll(Expression<Func<T,bool>> filter =null);// Generic bir IEntityRepository oluşturduk

        T Get();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        

    }
}
