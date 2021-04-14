using Business.Abstract;
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
    }
}
