using RestApiModelDDD.Application.DTOs;
using RestApiModelDDD.Application.Interfaces.Mappers;
using RestApiModelDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModelDDD.Application.Mapper
{
    public class MapperClient : IMapperClient
    {
        List<ClientDto> clientsDto = new List<ClientDto>();

        public Client MapperDtoToEntity(ClientDto cLientDto)
        {
            var client = new Client()
            {
                Id = cLientDto.Id,
                Name = cLientDto.Name,
                Nickname = cLientDto.Nickname,
                Email = cLientDto.Email,
            };

            return client;
        }

        public ClientDto MapperEntityToDto(Client client)
        {
            var clientDto = new ClientDto()
            {
                Id = client.Id,
                Name = client.Name,
                Nickname = client.Nickname,
                Email = client.Email,
            };

            return clientDto;
        }

        public IEnumerable<ClientDto> MapperListClientsDto(IEnumerable<Client> clients)
        {
            var dtos = clients.Select(c => new ClientDto
            {
                Id = c.Id,
                Name = c.Name,
                Nickname = c.Nickname,
                Email = c.Email
            });

            return dtos;
        }
    }
}
