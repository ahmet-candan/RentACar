using Business.Abstract;
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
            if (car.Description.Length < 2)
            {
                return new ErrorResult("Araba açıklaması en az 2 karekter olmalıdır");
            }
            _carDar.Add(car);
            return new Result(true,"Araba eklendi");
        }

        public List<Car> GetAll()
        {
            return _carDar.GetAll();
        }

        public List<Car> GetAllByCategory(int id)
        {
            return _carDar.GetAll(p => p.CarId == id);
        }

        public Car GetById(int carId)
        {
            return _carDar.Get(p => p.CarId == carId);
        }

        public List<Car> GetByUnitPrice(decimal min, decimal max)
        {
            return _carDar.GetAll(p => p.DailiyPrice>= min && p.DailiyPrice <= max);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDar.GetCarDetails();
        }
    }
}
