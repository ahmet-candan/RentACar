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
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAllByCategory(2))
            {
                Console.WriteLine(car.DailiyPrice);
            }
        }
    }
}
