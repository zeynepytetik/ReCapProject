using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Data;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : ICarDal
    {
        public void Add(Car car)
        {
            using (CarContext context = new CarContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState
                    context.SaveChanges();
            }
        }

        public void Delete(Car car)
        {
            using (CarContext context = new CarContext())
            {
                var addedEntity = CarContext.Entry(entity);
                NewMethod();
                CarContext.SaveChanges();
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (var context = new CarContext())
            {
                return filter == null
                    ? context.Set<CarContext>().ToList()
                    : context.Set<CarContext>().Where(filter).ToList();
            }

        public void update(Car car)
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
          }
    }
}
