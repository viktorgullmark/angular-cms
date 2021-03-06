﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NgCmsBackend.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IList<T>> List();
        Task<T> Insert(T entity);
        Task<T> Delete(T entity);
        Task<T> Update(T entity);
        Task<bool> SaveAsync();
        Task<T> FindAsync(Expression<Func<T, bool>> predicate);
    }
}
