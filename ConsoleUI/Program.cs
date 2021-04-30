using Business.Concrete;
using DataAccess.Concrete.EntityRepository;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.DailiyPrice + "/" + car.BrandName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }

            
        }
    }
}
