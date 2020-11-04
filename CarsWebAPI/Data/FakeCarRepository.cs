using CarsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsWebAPI.Data
{
    public class FakeCarRepository : ICarRespository
    {
        private static List<Car> localcars = new List<Car>
        {
            new Car()
            {
                Id=1,
                Brand = "Toyota",
                Name = "Cressida",
                Condition = "new",
                Miles= 150.00,
                FuelType = "Fuel"
            },
            new Car()
            {
                Id=2,
                Brand = "Mitsubishi",
                Name = "Montero",
                Condition = "used",
                Miles= 150000.00,
                FuelType = "Hybrid"
            }
        };

        public Car createCar(Car car)
        {
            localcars.Add(car);
            return car;
        }

        public void deleteCar(int id)
        {
            localcars.Remove(getCarById(id));       
        }

        public Car getCarById(int id)
        {
            return localcars.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Car> getCarsList()
        {
            return localcars;
        }

        public Car updateCar(int id, Car car)
        {
            Car selectedCar= localcars.FirstOrDefault(x => id == car.Id);
            if (selectedCar != null)
            {
                selectedCar.Brand = car.Brand;
                selectedCar.Name = car.Name;
                selectedCar.Condition = car.Condition;
                selectedCar.Miles = car.Miles;
                selectedCar.FuelType = selectedCar.FuelType;
            }
            return selectedCar;
        }
    }
}
