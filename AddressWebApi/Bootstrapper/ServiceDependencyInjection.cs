using AddressWebApi.Interfaces;
using AddressWebApi.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AddressWebApi.Bootstrapper;

internal static class ServiceDependencyInjection
{
    internal static void AddServices(this IServiceCollection services)
    {
        services.AddTransient<IRegionService, RegionService>();
        services.AddTransient<IRegionDistrictService, RegionDistrictService>();
    }
}