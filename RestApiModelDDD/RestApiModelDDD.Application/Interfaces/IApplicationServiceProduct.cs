using RestApiModelDDD.Application.DTOs;
using System.Collections.Generic;

namespace RestApiModelDDD.Application.Interfaces
{
    public interface IApplicationServiceProduct
    {
        IEnumerable<ProductDto> GetAll();

        ProductDto GetById(int id);

        void Add(ProductDto productDto);

        void Update(ProductDto productDto);

        void Remove(ProductDto productDto);
    }
}
