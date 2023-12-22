using RestApiModelDDD.Domain.Core.Interfaces.Repositories;
using RestApiModelDDD.Domain.Core.Interfaces.Services;
using RestApiModelDDD.Domain.Entities;

namespace RestApiModelDDD.Domain.Services
{
    public class ServiceClient : ServiceBase<Client>, IServiceClient
    {
        private readonly IRepositoryClient _repositoryClient;

        public ServiceClient(IRepositoryClient repositoryClient)
            : base(repositoryClient)
        {
            _repositoryClient = repositoryClient;
        }
    }
}
