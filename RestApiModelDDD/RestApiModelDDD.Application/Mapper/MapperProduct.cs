using RestApiModelDDD.Application.DTOs;
using RestApiModelDDD.Application.Interfaces.Mappers;
using RestApiModelDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModelDDD.Application.Mapper
{
    public class MapperProduct : IMapperProduct
    {
        public Product MapperDtoToEntity(ProductDto productDto)
        {
            var product = new Product()
            {
                Id = productDto.Id,
                Name = productDto.Name,
                Price = productDto.Price
            };

            return product;
        }

        public ProductDto MapperEntityToDto(Product product)
        {
            var productDto = new ProductDto()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };

            return productDto;
        }

        public IEnumerable<ProductDto> MapperListProductsDto(IEnumerable<Product> products)
        {
            var dtos = products.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price
            });

            return dtos;
        }
    }
}