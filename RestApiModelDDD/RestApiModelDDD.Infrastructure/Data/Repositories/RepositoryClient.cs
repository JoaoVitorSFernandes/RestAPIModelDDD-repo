using RestApiModelDDD.Domain.Core.Interfaces.Repositories;
using RestApiModelDDD.Domain.Entities;

namespace RestApiModelDDD.Infrastructure.Data.Repositories
{
    internal class RepositoryClient : RepositoryBase<Client>, IRepositoryClient
    {
        private readonly SqlContext _context;

        public RepositoryClient(SqlContext context)
            : base(context)
        {
            _context = context;
        }
    }
}