using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    interface ICarDal
    {
        List<Car> GetById(int id);
        List<Car> GetAll();
        void Add(Car car);
        void Delete(Car car);
        void update(Car car);

    }

   
}

