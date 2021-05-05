using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Contracts
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> GetAll(bool trackChanges);

        IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression, bool trackChanges);

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}