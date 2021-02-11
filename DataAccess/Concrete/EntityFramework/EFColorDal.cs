using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFColorDal : IColorDal
    {
        public void add(Color entity)
        {
            throw new NotImplementedException();
        }

        public void delete(Color entity)
        {
            throw new NotImplementedException();
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
