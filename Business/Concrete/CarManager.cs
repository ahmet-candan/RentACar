using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public IResult Add(Car car)
        {
            
            _carDar.Add(car);
            return new Result(true,Messages.ProductAdded);
        }

        public IResult Delete(Car car)
        {
            _carDar.Delete(car);
            return new SuccessResult(Messages.CarDeletedMessage);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 12)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDar.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<List<Car>> GetAllByCategory(int id)
        {

            return new SuccessDataResult<List<Car>>(_carDar.GetAll(p => p.CarId == id));
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDar.Get(p => p.CarId == carId));
        }

        public IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDar.GetAll(p => p.DailiyPrice>= min && p.DailiyPrice <= max));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDar.GetCarDetails());
        }

        public IResult Update(Car car)
        {
            _carDar.Update(car);
            return new SuccessResult(Messages.CarUpdatedMessage);

        }
    }
}
