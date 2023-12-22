using Autofac;
using RestApiModelDDD.Application;
using RestApiModelDDD.Application.Interfaces;
using RestApiModelDDD.Application.Interfaces.Mappers;
using RestApiModelDDD.Application.Mapper;
using RestApiModelDDD.Domain.Core.Interfaces.Repositories;
using RestApiModelDDD.Domain.Core.Interfaces.Services;
using RestApiModelDDD.Domain.Services;
using RestApiModelDDD.Infrastructure.Data.Repositories;

namespace RestApiModelDDD.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceClient>().As<IApplicationServiceClient>();
            builder.RegisterType<ApplicationServiceProduct>().As<IApplicationServiceProduct>();

            builder.RegisterType<ServiceClient>().As<IServiceClient>();
            builder.RegisterType<ServiceProduct>().As<IServiceProduct>();

            builder.RegisterType<RepositoryClient>().As<IRepositoryClient>();
            builder.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();

            builder.RegisterType<MapperClient>().As<IMapperClient>();
            builder.RegisterType<MapperProduct>().As<IMapperProduct>();

            #endregion IOC
        }
    }
}