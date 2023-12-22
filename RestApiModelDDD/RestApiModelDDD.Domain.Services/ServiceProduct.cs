using RestApiModelDDD.Domain.Core.Interfaces.Repositories;
using RestApiModelDDD.Domain.Core.Interfaces.Services;
using RestApiModelDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModelDDD.Domain.Services
{
    public class ServiceProduct : ServiceBase<Product>, IServiceProduct
    {
        private readonly IRepositoryProduct _repositoryProduct;

        public ServiceProduct(IRepositoryProduct repositoryProduct)
            : base (repositoryProduct)
        {
            _repositoryProduct = repositoryProduct;
        }
    }
}
