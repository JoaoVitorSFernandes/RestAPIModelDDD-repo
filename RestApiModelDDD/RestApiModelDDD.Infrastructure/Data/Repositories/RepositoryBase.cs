using Microsoft.EntityFrameworkCore;
using RestApiModelDDD.Domain.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModelDDD.Infrastructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext _context;

        public RepositoryBase(SqlContext context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsNoTracking().ToList();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Add(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Add(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity obj)
        {
            try
            {
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remove(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Remove(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}