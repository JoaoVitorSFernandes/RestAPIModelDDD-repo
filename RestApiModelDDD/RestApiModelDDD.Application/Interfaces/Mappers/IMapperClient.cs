using RestApiModelDDD.Application.DTOs;
using RestApiModelDDD.Domain.Entities;
using System.Collections.Generic;

namespace RestApiModelDDD.Application.Interfaces.Mappers
{
    public interface IMapperClient
    {
        Client MapperDtoToEntity(ClientDto cLientDto);

        IEnumerable<ClientDto> MapperListClientsDto(IEnumerable<Client> clients);

        ClientDto MapperEntityToDto(Client client);
    }
}