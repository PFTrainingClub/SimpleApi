using Microsoft.Extensions.DependencyInjection;
using SimpleApi.Core.Startups;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Hosting
{
    public static class HostStartupsExtensions
    {
        public static async Task RunWithCoreStartupsAsync(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                await CoreDbStartup.MigrateDbAsync(scope.ServiceProvider);
            }

            await host.RunAsync();
        }
    }
}
