using RestApiModelDDD.Application.DTOs;
using System.Collections;
using System.Collections.Generic;

namespace RestApiModelDDD.Application.Interfaces
{
    public interface IApplicationServiceClient
    {
        IEnumerable<ClientDto> GetAll();

        ClientDto GetById(int id);

        void Add(ClientDto clientDto);

        void Update(ClientDto clientDto);

        void Remove(ClientDto clientDto);
    }
}