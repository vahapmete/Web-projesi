﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void UpDate(T entity);
        void Delete(T entity); 
    }
}
