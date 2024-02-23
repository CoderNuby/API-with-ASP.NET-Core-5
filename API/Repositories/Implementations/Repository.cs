using API.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace API.Repositories.Implementations
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private MovieInfoContext _context { get; set; }
        public Repository(MovieInfoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public TEntity Get(int Id)
        {
            var response = _context.Set<TEntity>().Find(Id);

            return response;
        }

        public TEntity Get(Guid Id)
        {
            var response = _context.Set<TEntity>().Find(Id);

            return response;
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            var response = _context.Set<TEntity>().Where(predicate);

            return response.ToList();
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>().Where(predicate);

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return query.ToList();
        }

        public IEnumerable<TEntity> GetAll()
        {
            var response = _context.Set<TEntity>();

            return response.ToList();
        }

        public IEnumerable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return query.ToList();
        }

        public IEnumerable<TEntity> Get(params Expression<Func<TEntity, bool>>[] predicates)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            foreach (var predicate in predicates)
            {
                query = query.Where(predicate);
            }

            return query.ToList();
        }

        public TEntity Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            SaveChange();

            return entity;
        }

        public TEntity Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            SaveChange();

            return entity;
        }

        public void SaveChange()
        {
            _context.SaveChanges();
        }
    }
}
