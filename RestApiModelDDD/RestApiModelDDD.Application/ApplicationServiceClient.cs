using RestApiModelDDD.Application.DTOs;
using RestApiModelDDD.Application.Interfaces;
using RestApiModelDDD.Application.Interfaces.Mappers;
using RestApiModelDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiModelDDD.Application
{
    public class ApplicationServiceClient : IApplicationServiceClient
    {
        private readonly IServiceClient _serviceClient;
        private readonly IMapperClient _mapperClient;

        public ApplicationServiceClient(IServiceClient serviceClient,
                                        IMapperClient mapperClient)
        {
            _serviceClient = serviceClient;
            _mapperClient = mapperClient;
        }

        public void Add(ClientDto clientDto)
        {
            var client = _mapperClient.MapperDtoToEntity(clientDto); 
            _serviceClient.Add(client);
        }

        public IEnumerable<ClientDto> GetAll()
        {
            var clients = _serviceClient.GetAll();
            return _mapperClient.MapperListClientsDto(clients);
        }

        public ClientDto GetById(int id)
        {
            var client = _serviceClient.GetById(id);
            return _mapperClient.MapperEntityToDto(client);
        }

        public void Remove(ClientDto clientDto)
        {
            var client = _mapperClient.MapperDtoToEntity(clientDto);
            _serviceClient.Remove(client);
        }

        public void Update(ClientDto clientDto)
        {
            var client = _mapperClient.MapperDtoToEntity(clientDto);
            _serviceClient.Update(client);
        }
    }
}