using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SimpbeApi.Core.DbContexts;
using SimpleApi.Core.AppSettings;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreDbContexts(this IServiceCollection services)
        {
            return services.AddDbContextPool<CoreDbContext>((serviceProvider, builder) =>
            {
                var databaseSettings = serviceProvider.GetRequiredService<IOptionsMonitor<DatabaseAppSettings>>();
                builder
                    .UseSqlServer(databaseSettings.CurrentValue.CoreDb.ConnectionString)
                    .ConfigureWarnings(w => w.Throw(RelationalEventId.MultipleCollectionIncludeWarning));
            });
        }

        public static IServiceCollection AddCoreAppSettings(this IServiceCollection services, IConfiguration configuration)
        {
            return services.Configure<DatabaseAppSettings>(configuration.GetSection("Databases"));
        }
    }
}
