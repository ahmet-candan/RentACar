using Core.Entities;
using DataAccess.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity:class,IEntity,new()
        where TContext:DbContext,new()
    {
        public void Add(TEntity entity)
        {

            // IDsposable pattern implemetation 
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); //referansı yakala
                addedEntity.State = EntityState.Added;  //ekle
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); //referansı yakala
                deletedEntity.State = EntityState.Deleted;  //ekle
                context.SaveChanges();
            }
        }



        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() :
                    context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); //referansı yakala
                updatedEntity.State = EntityState.Modified;  //ekle
                context.SaveChanges();
            }
        }
    }
}
