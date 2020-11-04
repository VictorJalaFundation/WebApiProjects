using CarsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsWebAPI.Data
{
    interface ICarRespository
    {
        public Car createCar(Car car);
        public Car getCarById(int id);
        public List<Car> getCarsList();
        public Car updateCar(int id, Car car);
        public void deleteCar(int id);
    }
}
