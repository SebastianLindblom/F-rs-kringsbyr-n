using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Data;
using System.Collections.Concurrent;

namespace Business.GeneralRepository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DataModel Context;
        public Repository(Data.DataModel context)
        {
            Context = context;
        }

        public TEntity Get(int? id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate).ToList();
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().SingleOrDefault(predicate);
        }
        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().FirstOrDefault(predicate);
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void Edit(TEntity entity)
        {
            Context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

    }
}
