using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, new()
        where TContext : DbContext,new()

    {
        
        public void Add(TEntity entity)
        {
            using (TContext context=new TContext())
            {
                var addedEntity= context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void UpDate(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
