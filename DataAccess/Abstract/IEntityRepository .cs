using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    // generic constraint uyguluyoruz
    // class: referans tip olmalı 
    //IEntity: IEntity olabilir veya onu implemente eden başka bir NESENE olabilir
    // new(): newlenebilir olmalıdır. interfaceler newlenemez 
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter =null);// Generic bir IEntityRepository oluşturduk

        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        

    }
}
