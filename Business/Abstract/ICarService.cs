using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public class ICarService
    {
        List<Car> GetAll();
        Car GetCarsByCarId(int id);
        void add (Car car);
        void update(Car car);
        void delete(Car car);
    }
}
