using RestApiModelDDD.Application.DTOs;
using RestApiModelDDD.Application.Interfaces;
using RestApiModelDDD.Application.Interfaces.Mappers;
using RestApiModelDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiModelDDD.Application
{
    public class ApplicationServiceProduct : IApplicationServiceProduct
    {
        private readonly IServiceProduct _serviceProduct;
        private readonly IMapperProduct _mapperProduct;

        public ApplicationServiceProduct(IServiceProduct serviceProduct, 
                                         IMapperProduct mapperProduct)
        {
            _serviceProduct = serviceProduct;
            _mapperProduct = mapperProduct;
        }

        public void Add(ProductDto productDto)
        {
            var product = _mapperProduct.MapperDtoToEntity(productDto);
            _serviceProduct.Add(product);
        }

        public IEnumerable<ProductDto> GetAll()
        {
            var products = _serviceProduct.GetAll();
            return _mapperProduct.MapperListProductsDto(products);
        }

        public ProductDto GetById(int id)
        {
            var product = _serviceProduct.GetById(id);
            return _mapperProduct.MapperEntityToDto(product);
        }

        public void Remove(ProductDto productDto)
        {
            var product = _mapperProduct.MapperDtoToEntity(productDto);
            _serviceProduct.Remove(product);
        }

        public void Update(ProductDto productDto)
        {
            var product = _mapperProduct.MapperDtoToEntity(productDto);
            _serviceProduct.Update(product);
        }
    }
}
