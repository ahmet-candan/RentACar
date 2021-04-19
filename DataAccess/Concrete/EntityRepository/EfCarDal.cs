using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityRepository
{
    public class EfCarDal : ICarDal
    {


        public void Add(Car entity)
        {

            // IDsposable pattern implemetation 
            using (RentACarContext context = new RentACarContext())
            {
                var addedEntity = context.Entry(entity); //referansı yakala
                addedEntity.State = EntityState.Added;  //ekle
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var deletedEntity = context.Entry(entity); //referansı yakala
                deletedEntity.State = EntityState.Deleted;  //ekle
                context.SaveChanges();
            }
        }

        public Car Get()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return filter == null ? 
                         context.Set<Product>().ToList(): context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var updatedEntity = context.Entry(entity); //referansı yakala
                updatedEntity.State = EntityState.Modified;  //ekle
                context.SaveChanges();
            }
        }
    }
}
