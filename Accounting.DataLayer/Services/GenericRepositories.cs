﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Accounting.DataLayer.Services
{
    public class GenericRepositories<TEntity> where TEntity :class
    {
        private Accounting_DBEntities _db;
        private DbSet<TEntity> _dbSet;
        public GenericRepositories(Accounting_DBEntities db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }

        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }


        public virtual TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public virtual void Delete(object Id)
        {
            var entity = GetById(Id);
           Delete(entity);
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity,bool>> where=null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (where !=null)
            {
                query = query.Where(where);
            }
            return query.ToList();
        }
    }
}
