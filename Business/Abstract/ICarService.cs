﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        List<Car> GetAllByCategory(int id);
        List<Car> GetByUnitPrice(decimal min, decimal max);

        List<CarDetailDto> GetCarDetails();

        Car GetById(int carId);

        void Add(Car car);


    }
}
