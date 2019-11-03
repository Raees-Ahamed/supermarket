using Microsoft.EntityFrameworkCore;
using MySuperMarket.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MySuperMarket.DAL.Implementation
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DbContext context = null; //object for database context
        private readonly DbSet<TEntity> dbSet = null; // object for entity set

        public GenericRepository(DbContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        public void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null) //The code in the Get method creates an IQueryable object and then applies the filter expression if there is one
            {
                query = query.Where(filter);
            }
            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }
            if (orderBy != null) ///applies the orderBy expression if there is one and returns the results; otherwise it returns the results from the unordered query
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
