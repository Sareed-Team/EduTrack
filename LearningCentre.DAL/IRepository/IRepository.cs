﻿using LearningCentre.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearningCentre.DAL.IRepository
{
    public interface IRepository<TEntity> where TEntity : Auditable
    {
        ValueTask<TEntity> InsertAsync(TEntity entity);
        ValueTask<TEntity> UpdateAsync(TEntity entity);
        ValueTask<bool> DeleteAsync(long id);
        IQueryable<TEntity> SelectAll(
            Expression<Func<TEntity, bool>> expression = null, string[] includes = null, bool isTracking = true);
        ValueTask<TEntity> SelectAsync(Expression<Func<TEntity, bool>> expression, string[] includes = null);
        ValueTask SaveChangesAsync();
    }
}
