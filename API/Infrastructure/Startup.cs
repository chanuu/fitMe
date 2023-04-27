using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class Startup
    {
        public static IServiceCollection AddDB(
           this IServiceCollection services,
           string connectionString,
           string migrationsAssemblyName)
        {
            return services.AddDbContext<ApiContext>(options =>
            {
                options.UseNpgsql(connectionString, npgsqlOptionsAction: npgsqlOptions =>
                {
                    npgsqlOptions.MigrationsAssembly(migrationsAssemblyName);
                });
            });
        }
    }
}
