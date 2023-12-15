using AddressWebApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AddressWebApi.Bootstrapper;

internal static class DatabaseDependencyInjection
{
    private const string _defaultConnectionName = "DefaultConnection";

    public static void AddContext(this IServiceCollection services, IConfiguration configuration)
    {
        string defaultConnection = configuration.GetConnectionString(_defaultConnectionName);

        services.AddDbContext<AddressContext>(options => options.UseSqlServer(defaultConnection));
    }
}