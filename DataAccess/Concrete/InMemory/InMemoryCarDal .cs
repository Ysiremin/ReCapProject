using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{carId=1, brandId=1, colorId=1, modelYear=2005, dailyPrice= 250, description="Araba 1"},
                new Car{carId=2, brandId=1, colorId=2, modelYear=2012, dailyPrice= 350, description="Araba 2"},
                new Car{carId=3, brandId=2, colorId=3, modelYear=2019, dailyPrice= 400, description="Araba 3"},
                new Car{carId=4, brandId=3, colorId=4, modelYear=2009, dailyPrice= 290, description="Araba 4"},
                new Car{carId=5, brandId=5, colorId=1, modelYear=2010, dailyPrice= 300, description="Araba 5"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.carId == car.carId);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c => c.carId == CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.carId == car.carId);

            carToUpdate.brandId = car.brandId;
            carToUpdate.colorId = car.colorId;
            carToUpdate.dailyPrice = car.dailyPrice;
            carToUpdate.modelYear = car.modelYear;
            carToUpdate.description = car.description;   
        }
    }
}
