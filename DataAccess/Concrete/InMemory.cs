using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemory : ICarDal
    {
        List<Car> _Cars;
        _Cars = new List<Car>
            new Car {id=1, BrandId=1, ColorId=1, ModelYear=2018 ,DailyPrice=740000, Description="AUDİ A6"},
            new Car {id=2, BrandId=2, ColorId=2, ModelYear=2018 ,DailyPrice=240000, Description="Skoda Superb"},
            new Car {id=3, BrandId=3, ColorId=3, ModelYear=2020 ,DailyPrice=142000, Description="Fiat Egea"}
            public List<Car> GetById(int id)
        {
            return _Cars.Where(p => p.id == car.id).ToList;
        }

        public List<Car> GetAll()
        {
            return _Cars;
        }

        public void Add(Car car)
        {
          _Cars.Add(Car);
        }

        public void Delete(Car car)
        {
         var CarToDelete = _Cars.SingleOrDefault(p => p.id == car.id);
         _Cars.Remove(CarToDelete);
        }

        public void update(Car car)
        {
    var CarToUpdate = _Cars.SingleOrDefault(p => p.id == car.id);
    CarToUpdate.id = car.id;
    CarToUpdate.BrandId = Brand.Id;
    CarToUpdate.ColorId = Color.Id;
    CarToUpdate.ModelYear = ModelYear;
    CarToUpdate.DailyPrice = DailyPrice;
    CarToUpdate.Description = Description;
       }
    
            
       

       

      

       

      






