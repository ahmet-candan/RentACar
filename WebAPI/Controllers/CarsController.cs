using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityRepository;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //Attribute
    public class CarsController : ControllerBase
    {

        //naming convension kurallarına uyuyoruz
        // Losely coupled ile bağımlılığımızı azalttık
        // IoC Container -- Inversion of Control(değişimin kontrolü) ==> bellekte bir kutu oluşturur ve içine referanslar koyuyoruz
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public List<Car> Get()
        {
            //Dependency chain 
            ICarService carService = new CarManager(new EfCarDal());
            var result = _carService.GetAll();
            return result.Data;
        }
    }
}
