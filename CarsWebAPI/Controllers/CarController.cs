using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsWebAPI.Data;
using CarsWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CarsWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;
        private FakeCarRepository fcr = new FakeCarRepository();

        public CarController(ILogger<CarController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Car> GetCars()
        {
            return fcr.getCarsList();
        }
    

        [HttpGet("{id}")]
        public Car GetCarbyId(int id)
        {
            return fcr.getCarById(id);
        }


        [HttpPost]
        public Car CreateCar(Car car)
        {
            return fcr.createCar(car);
        }

        [HttpPut("{id}")]
        public Car UpdateCar(int id,Car car)
        {
            return fcr.updateCar(id,car);
        }

        [HttpDelete("{id}")]
        public void DeleteCars(int id)
        {
            fcr.deleteCar(id);
        }

    }
}
