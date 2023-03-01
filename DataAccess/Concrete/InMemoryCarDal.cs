using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal

    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1, BrandId=1, ColorId=1, DailyPrice=1200, ModelYear=2018, Description="Audi A4"},
                new Car {Id=2, BrandId=1, ColorId=1, DailyPrice=5500, ModelYear=2021, Description="Audi A6"},
                new Car {Id=3, BrandId=3, ColorId=2, DailyPrice=700,  ModelYear=2023, Description="Fiat Egea"},
                new Car {Id=4, BrandId=3, ColorId=3, DailyPrice=700,  ModelYear=2023, Description="Fiat Egea"},
                new Car {Id=5, BrandId=2, ColorId=5, DailyPrice=1500, ModelYear=2020, Description="Merdeces-Benz C200"},
            };

        }
        public void add(Car car)
        {
            _cars.Add(car);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void remove(Car car)
        {
            Car carToDelete=_cars.SingleOrDefault(c => c.Id==car.Id);
        }

        public void update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id= car.Id;
            carToUpdate.BrandId=car.BrandId;    
            carToUpdate.ColorId=car.ColorId;
            carToUpdate.DailyPrice=car.DailyPrice;  
            carToUpdate.Description=car.Description;    
        }
    }

}
