using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.GeneralRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        
        
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        TEntity Get(int? id);
        IEnumerable<TEntity> GetAll();
        void Edit(TEntity entity);
        void Remove(TEntity entity);
    }
}
