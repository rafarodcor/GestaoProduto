using Microsoft.Extensions.DependencyInjection;
using System;

namespace API.Service.Extensions
{
    public static class ExtensionClass
    {
        public static IServiceCollection AddAutoMapperDependency(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return services;
        }
    }
}
