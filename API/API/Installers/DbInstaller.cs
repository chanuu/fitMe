using Infrastructure;
using System.Reflection;

namespace API.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallService(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDB(
             configuration["Database:ConnectionString"],
             typeof(Startup).GetTypeInfo().Assembly.GetName().Name);
        }
    }
}
