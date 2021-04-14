using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _product;
        public InMemoryCarDal()
        {
            _product = new List<Car>
            {
                new Car{BrandId=1,CarId=1,ColorId=1,DailiyPrice=100,Description="reno",ModelYear="2000"},
                new Car{BrandId=1,CarId=1,ColorId=1,DailiyPrice=200,Description="audi",ModelYear="2000"},
                new Car{BrandId=1,CarId=1,ColorId=1,DailiyPrice=300,Description="bmw",ModelYear="2000"},
                new Car{BrandId=1,CarId=1,ColorId=1,DailiyPrice=50,Description="tofaş",ModelYear="2000"}

            };
        }
        public void Add(Car car)
        {
            _product.Add(car);
        }

        public void Delete(Car car)
        {
            Car cartoDelete;
            cartoDelete = _product.SingleOrDefault(p => p.CarId == car.CarId);
            _product.Remove(cartoDelete);
        }

        public List<Car> GetAll()
        {
            return _product;
        }

        public List<Car> GetById(int carid)
        {
            return _product.Where(p => p.CarId == carid).ToList();
        }

        public void Update(Car car)
        {
            Car cartoUpdate = _product.SingleOrDefault(p => p.CarId == car.CarId);
            cartoUpdate.DailiyPrice = car.DailiyPrice;
            cartoUpdate.ModelYear = car.ModelYear;
        }
    }
}
