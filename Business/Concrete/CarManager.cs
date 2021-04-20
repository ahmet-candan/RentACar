﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        ICarDal _carDar;

        public CarManager(ICarDal carDar)
        {
            _carDar = carDar;
        }

        public List<Car> GetAll()
        {
            return _carDar.GetAll();
        }

        public List<Car> GetAllByCategory(int id)
        {
            return _carDar.GetAll(p => p.CategoryId == id);
        }

        public List<Car> GetByUnitPrice(decimal min, decimal max)
        {
            return _carDar.GetAll(p => p.DailiyPrice>= min && p.DailiyPrice <= max);
        }
    }
}
