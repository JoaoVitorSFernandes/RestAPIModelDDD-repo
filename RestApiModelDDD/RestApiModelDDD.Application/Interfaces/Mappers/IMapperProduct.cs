using RestApiModelDDD.Application.DTOs;
using RestApiModelDDD.Domain.Entities;
using System.Collections.Generic;

namespace RestApiModelDDD.Application.Interfaces.Mappers
{
    public interface IMapperProduct
    {
        Product MapperDtoToEntity(ProductDto productDto);

        IEnumerable<ProductDto> MapperListProductsDto(IEnumerable<Product> products);

        ProductDto MapperEntityToDto(Product product);
    }
}