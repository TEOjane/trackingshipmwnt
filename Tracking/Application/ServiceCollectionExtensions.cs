using DataAccess;
using Domain;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationService(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IApplicationService, ApplicationService>();
        serviceCollection.AddSingleton<ICargoRepository, CargoRepository>();

        return serviceCollection;
    }
}
