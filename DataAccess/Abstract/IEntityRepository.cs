using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository <T> where T: class, IEntity,new()
    {
        List<T> GetAll(Expression <Func<T, bool>> filter = null);
        T Get(Expression <Func <T, bool>> filter);
        void add(T entity);
        void delete(T entity);
        void update(T entity);

    }

    
}
