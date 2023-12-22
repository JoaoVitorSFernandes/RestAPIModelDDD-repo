using System.Collections.Generic;

namespace RestApiModelDDD.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);
    }
}