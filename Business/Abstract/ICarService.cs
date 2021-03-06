using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();

        IDataResult<List<Car>> GetAllByCategory(int id);
        IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<List<CarDetailDto>> GetCarDetails();

        IDataResult<Car> GetById(int carId);

        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);


    }
}
