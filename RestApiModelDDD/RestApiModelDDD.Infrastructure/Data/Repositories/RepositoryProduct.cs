using RestApiModelDDD.Domain.Core.Interfaces.Repositories;
using RestApiModelDDD.Domain.Entities;

namespace RestApiModelDDD.Infrastructure.Data.Repositories
{
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {
        private readonly SqlContext _context;

        public RepositoryProduct(SqlContext context)
            : base(context)
        {
            _context = context;
        }
    }
}