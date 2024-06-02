using Crud.Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Crud.Presentation.Api.Extensions.ServiceCollection;

public static class DatabaseProviderExtensions
{
    /// <summary>
    /// Configure database dependencies.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    public static void ConfigureDatabaseDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        var connection = configuration["ConnectionStrings:DatabaseName"]?.ToString();

        services.AddDbContext<DatabaseContext>(options =>
        {
            options.UseInMemoryDatabase(databaseName: connection);
        });
    }
}