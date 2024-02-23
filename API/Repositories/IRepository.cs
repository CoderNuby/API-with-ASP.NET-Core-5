using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace API.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int Id);
        TEntity Get(Guid Id);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);
        IEnumerable<TEntity> Get(params Expression<Func<TEntity, bool>>[] predicates);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] include);
        TEntity Create(TEntity entity);
        TEntity Delete(TEntity entity);
        void SaveChange();
    }
}
